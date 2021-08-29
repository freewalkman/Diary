using System;

namespace Diary.Model
{
    public class Category
    {
        public int Id;
        public string Name;
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
    }

    
}
