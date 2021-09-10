using System;
using System.Collections.Generic;

namespace Diary.BAL
{
    public class Category
    {
        /// <summary>
        /// 向数据库中插入Category数据，如成功返回新记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        static public Model.Category Insert(Model.Category model)
        {
            return model;
        }

        /// <summary>
        /// 删除指定ID的记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public bool Delete(int id)
        {
            return true;
        }


        /// <summary>
        /// 修改指定ID的记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public bool Modify(Model.Category model)
        {
            return true;
        }

        /// <summary>
        /// 返回所有记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public List<Model.Category> query_all()
        {
            //List<Model.Category> categories = new List<Model.Category>();
            List<Model.Category> categories = new List<Model.Category>()
            {
                new Model.Category { Id = 1, Name = "一层节点1", HasChild=true, ParentId=-1, Type="Normal", ShowOrder=1 },
                new Model.Category { Id = 3, Name = "一层节点3", HasChild=true, ParentId=-1, Type="Normal", ShowOrder=3 },
                new Model.Category { Id = 4, Name = "二层节点2.1", HasChild=true, ParentId=2, Type="Normal", ShowOrder=2 },
                new Model.Category { Id = 5, Name = "二层节点3.1", HasChild=false, ParentId=3, Type="Normal", ShowOrder=3 },
                new Model.Category { Id = 6, Name = "二层节点1.1", HasChild=true, ParentId=1, Type="Normal", ShowOrder=1 },
                new Model.Category { Id = 7, Name = "三层节点2.1.1", HasChild=false, ParentId=4, Type="Normal", ShowOrder=1 },
                new Model.Category { Id = 8, Name = "三层节点1.1.1", HasChild=false, ParentId=6, Type="Normal", ShowOrder=1 },
                new Model.Category { Id = 9, Name = "二层节点1.2", HasChild=false, ParentId=1, Type="Normal", ShowOrder=2 },
                new Model.Category { Id = 10, Name = "三层节点1.1.2", HasChild=false, ParentId=6, Type="Normal", ShowOrder=2 },
                new Model.Category { Id = 2, Name = "一层节点2", HasChild=true, ParentId=-1, Type="Normal", ShowOrder=2 },
            };

            return categories;
        }
    }
}
