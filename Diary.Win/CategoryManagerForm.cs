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

        private void btnOK_Click(object sender, EventArgs e)
        {
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
            List<Model.Category> listCategory = new List<Model.Category>()
            {
                new Model.Category { Id = 0, Name = "无", HasChild=false, ParentId=-1, Type="Normal", ShowOrder=0 },
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
            cbxParent.DataSource = Model.Category.Sort(listCategory);
            cbxParent.DisplayMember = "Name";
            cbxParent.ValueMember = "Id";
            cbxParent.SelectedValue = 0;

            //分类类型
            List<Tuple<string, string>> listType = new List<Tuple<string, string>>()
            {
                new Tuple<string, string>("正常", "Normal"),
                new Tuple<string, string>("代码", "Code"),
            };
            
            cbxType.DataSource = listType;
            cbxType.DisplayMember = "Item1";
            cbxType.ValueMember = "Item2";
            cbxType.SelectedValue = "Normal";
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
