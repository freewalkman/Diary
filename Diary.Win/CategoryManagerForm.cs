using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary.Win
{
    public partial class CategoryManagerForm : Form
    {
        public CategoryManagerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 用于窗体间数据传递
        /// </summary>
        public Model.Category CategoryData = new Model.Category();

        private void btnOK_Click(object sender, EventArgs e)
        {
            CategoryData.Name = tbxName.Text;
            CategoryData.ParentId = (int)cbxParent.SelectedValue;
            CategoryData.Type = cbxType.SelectedValue.ToString();
            CategoryData.ShowOrder = int.Parse(tbxShowOrder.Text);
            CategoryData.Description = tbxDescription.Text;
            CategoryData.Remark = tbxRemark.Text;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CategoryManagerForm_Load(object sender, EventArgs e)
        {
            //所属分类
            List<Model.Category> listCategory = BAL.Category.query_all();
            listCategory.Add(new Model.Category { Id = 0, Name = "无", HasChild = false, ParentId = -1, Type = "Normal", ShowOrder = 0 });
            cbxParent.DataSource = Model.Category.Sort(listCategory);
            cbxParent.DisplayMember = "Name";
            cbxParent.ValueMember = "Id";

            //分类类型
            List<Tuple<string, string>> listType = new List<Tuple<string, string>>()
            {
                new Tuple<string, string>("正常", "Normal"),
                new Tuple<string, string>("代码", "Code"),
            };
            
            cbxType.DataSource = listType;
            cbxType.DisplayMember = "Item1";
            cbxType.ValueMember = "Item2";

            //初始化控件
            if (CategoryData.Id > 0)
            {
                //修改
                Text = string.Format("{0}(ID:{1})", Text, CategoryData.Id);
                tbxName.Text = CategoryData.Name;
                cbxParent.SelectedValue = CategoryData.ParentId;
                cbxType.SelectedValue = CategoryData.Type;
                tbxShowOrder.Text = CategoryData.ShowOrder.ToString();
                tbxDescription.Text = CategoryData.Description;
                tbxRemark.Text = CategoryData.Remark;
            }
            else
            {
                //新建
                Text = string.Format("{0}(新建)", Text);
                tbxShowOrder.Text = "99";
                cbxParent.SelectedValue = 0;
                cbxType.SelectedValue = "Normal";
            }
        }

        private void cbxParent_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();

            Brush brush = new SolidBrush(e.ForeColor);
            Model.Category category = cbxParent.Items[e.Index] as Model.Category;
            if (category == null) return;

            string text = "";
            for (int i = 1; i <= category.Depth; i++)
            {
                text += "    ";
            }
            text += category.Name;

            Font font = null;
            if (category.HasChild)
            {
                font = new Font(e.Font.FontFamily, e.Font.Size, FontStyle.Bold);
            }
            else
            {
                font = new Font(e.Font.FontFamily, e.Font.Size);
            }

            e.Graphics.DrawString(text, font, brush, e.Bounds.X, e.Bounds.Y + 3);
            brush.Dispose();
            font.Dispose();
        }
    }
}
