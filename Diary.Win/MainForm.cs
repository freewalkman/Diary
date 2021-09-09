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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //测试数据
        //List<Model.Category> categories = new List<Model.Category>();

        private void tsmiCategoryCreate_Click(object sender, EventArgs e)
        {
            TreeNode tn_select = tvCategory.SelectedNode;

            CategoryManagerForm form = new CategoryManagerForm();
            if (form.ShowDialog() != DialogResult.OK) return;

            Model.Category model = form.CategoryData;
            model.Id = tvCategory.Nodes.Count + 1;
            TreeNode tn = new TreeNode()
            {
                Text = model.Name,
                Tag = model,
            };
            if (tn_select == null)
            {
                tvCategory.Nodes.Add(tn);
            }
            else
            {
                tn_select.Nodes.Add(tn);
                tn_select.Expand();
            }
        }

        TreeNode find_by_id(TreeNode tnParent, int findId)
        {
            TreeNodeCollection tnc = (tnParent == null) ? tvCategory.Nodes : tnParent.Nodes;

            foreach (TreeNode node in tnc)
            {
                Model.Category model = node.Tag as Model.Category;
                if (model.Id == findId) return node;

                if (node.Nodes.Count > 0)
                {
                    find_by_id(node, findId);
                }
            }
            return null;
        }


        private void tsmiCategoryModify_Click(object sender, EventArgs e)
        {
            TreeNode tn_select = tvCategory.SelectedNode;
            if (tn_select == null) return;

            TreeNode oldParentNode = tn_select.Parent;

            Model.Category model = tn_select.Tag as Model.Category;
            if (model == null) return;

            CategoryManagerForm form = new CategoryManagerForm();
            form.CategoryData = model;
            if (form.ShowDialog() != DialogResult.OK) return;

            tn_select.Text = model.Name;

            TreeNode newParentNode = find_by_id(null, model.ParentId);

            if (oldParentNode != newParentNode)
            {
                //删除原节点
                if (oldParentNode != null)
                {
                    oldParentNode.Nodes.Remove(tn_select);
                }
                else
                {
                    tvCategory.Nodes.Remove(tn_select);
                }

                //添加新节点
                if (newParentNode != null)
                {
                    newParentNode.Nodes.Add(tn_select);
                }
                else
                {
                    tvCategory.Nodes.Add(tn_select);
                }
            }
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
                    //MessageBox.Show(model.Id.ToString());
                }
            }
        }

        private void tvCategory_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void tvCategory_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

            }
        }

        private void tvCategory_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (tvCategory.SelectedNode != null)
                {
                    Point ptMouse = PointToClient(MousePosition);
                    if (!tvCategory.SelectedNode.Bounds.Contains(ptMouse))
                    {
                        tvCategory.SelectedNode = null;
                    }
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                string filepath = string.Format("{0}Diray.db", Application.StartupPath);
                if (!System.IO.File.Exists(filepath))
                {
                    MessageBox.Show("数据库文件不存在");
                }
                string connstring = string.Format("Data Source={0};", filepath);
                Microsoft.Data.Sqlite.SqliteConnection conn = new Microsoft.Data.Sqlite.SqliteConnection(connstring);
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("数据库连接测试成功");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
