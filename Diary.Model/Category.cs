using System;
using System.Collections.Generic;

namespace Diary.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ParentId;

        /// <summary>
        /// 是否有子类
        /// </summary>
        public bool HasChild;

        /// <summary>
        /// 分类类型
        /// </summary>
        public string Type;
        /// <summary>
        /// 显示序号，数字越小，显示越靠前
        /// </summary>
        public int ShowOrder;
        /// <summary>
        /// 分类描述
        /// </summary>
        public string Description;
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark;

        /// <summary>
        /// 深度，通过计算得出
        /// </summary>
        public int Depth;

        /// <summary>
        /// 获取当前数据在categories中的深度
        /// </summary>
        /// <param name="categories"></param>
        /// <returns></returns>
        void count_depth(List<Category> categories)
        {
            Depth = 0;
            int parentId = ParentId;
            while (parentId > 0)
            {
                bool isExistParent = false;
                foreach (Category category in categories)
                {
                    if (parentId == -1) return;
                    if (parentId == category.Id)
                    {
                        parentId = category.ParentId;
                        Depth++;
                        isExistParent = true;
                    }
                }
                if (!isExistParent) break;
            }
        }

        /// <summary>
        /// 获取当前数据在categories的序号
        /// </summary>
        /// <param name="categories"></param>
        /// <returns></returns>
        int getIndexByParentId(List<Category> categories)
        {
            int index = 0;
            foreach (Category category in categories)
            {
                if (ParentId == category.Id)
                {
                    break;
                }
                index++;
            }
            return index;
        }

        /// <summary>
        /// 将categories按深度和ShowOrder排序，并计算每个数据的深度
        /// </summary>
        /// <param name="categories"></param>
        /// <returns></returns>
        static public List<Category> Sort(List<Category> categories)
        {
            return categories;

            List<Category> return_categories = new List<Category>();

            //计算所有节点的深度，并按深度排序，深度相等的按显示顺序排序
            foreach (Category category in categories)
            {
                category.count_depth(categories);
            }
            categories.Sort((x, y) => {
                if (x.Depth > y.Depth) return 1;
                if (x.Depth < y.Depth) return -1;
                return x.ShowOrder - y.ShowOrder;
            } );

            //得到最大深度
            int max_depth = -999999;
            foreach (Category depth_category in categories)
            {
                max_depth = Math.Max(depth_category.Depth, max_depth);
            }

            //按深度依次提取
            for (int depth = 0; depth<=max_depth; depth++)
            {
                List<Category> cur_depth_categories = detach_category_current_depth(depth, categories);
                if (return_categories.Count == 0)
                {
                    //根目录级别的直接添加到返回列表
                    return_categories.AddRange(cur_depth_categories);
                }
                else
                {
                    //多级目录的先添加到缓存列表，如果parentId发生改变，则将缓存列表添加到返回列表
                    List<Category> cache_categories = new List<Category>();
                    int last_parentId = -999;
                    if (cur_depth_categories.Count > 0) last_parentId = cur_depth_categories[0].ParentId;

                    foreach (Model.Category depth_category in cur_depth_categories)
                    {
                        if (last_parentId != depth_category.ParentId)
                        {
                            insert_into_categories(cache_categories, ref return_categories);
                            cache_categories.Clear();
                            cache_categories.Add(depth_category);
                        }
                        else
                        {
                            cache_categories.Add(depth_category);
                        }
                        last_parentId = depth_category.ParentId;
                    }
                    //最后的缓存列表添加到返回列表
                    insert_into_categories(cache_categories, ref return_categories);
                }
            }
            return return_categories;
        }

        /// <summary>
        /// 提取当前深度的所有类别
        /// </summary>
        /// <param name="parentId"></param>
        /// <param name="categories"></param>
        /// <returns></returns>
        static List<Category> detach_category_current_depth(int depth, List<Category> depth_categories)
        {
            List<Category> return_categories = new List<Category>();
            foreach (Category depth_category in depth_categories)
            {
                if (depth == depth_category.Depth)
                {
                    return_categories.Add(depth_category);
                }
            }

            return_categories.Sort( (x,y) => {
                    if (x.ParentId > y.ParentId) return 1;
                    if (x.ParentId < y.ParentId) return -1;
                    return x.ShowOrder - y.ShowOrder;
            } );
            return return_categories;
        }

        /// <summary>
        /// 将提取出来的分类列表按顺序插入到目标列表
        /// </summary>
        /// <param name="from_categories"></param>
        /// <param name="to_categories"></param>
        static void insert_into_categories(List<Category> from_categories, ref List<Category> to_categories)
        {
            if (from_categories.Count > 0)
            {
                int index = from_categories[0].getIndexByParentId(to_categories);
                to_categories.InsertRange(index + 1, from_categories);
            }
        }

    }

    
}
