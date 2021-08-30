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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //测试数据
        //List<Model.Category> categories = new List<Model.Category>();

        private void tsmiCategoryCreate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("新建");
            Model.Category model = new Model.Category()
            {
                Name = "测试",
                Id = 1,
                ParentId = -1,
                HasChild = false,
                Type = "test"
            };

            TreeNode tn = new TreeNode()
            {
                Text = model.Name,
                Tag = model,
            };
            if (tvCategory.SelectedNode == null)
            {
                tvCategory.Nodes.Add(tn);
            }
            else
            {
                tvCategory.SelectedNode.Nodes.Add(tn);
                tvCategory.SelectedNode.Expand();
            }
            
        }


        private void tsmiCategoryModify_Click(object sender, EventArgs e)
        {
            MessageBox.Show("修改");
        }

        private void tsmiCategoryDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除吗？", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("删除");
            }
        }

        private void cmsCategory_Opening(object sender, CancelEventArgs e)
        {
            bool hasSelected = (tvCategory.SelectedNode != null);
            tsmiCategoryModify.Enabled = hasSelected;
            tsmiCategoryDelete.Enabled = hasSelected;

            //以下代码为不显示修改或删除菜单项
            //tsmiCategoryModify.Visible = hasSelected;
            //tsmiCategoryDelete.Visible = hasSelected;
        }

        private void tvCategory_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Model.Category model = e.Node.Tag as Model.Category;
                if (model != null)
                {
                    MessageBox.Show(model.Id.ToString());
                }
            }
        }


    }
}
