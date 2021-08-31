
namespace Diary.Win
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvCategory = new System.Windows.Forms.TreeView();
            this.cmsCategory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCategoryCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCategoryModify = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCategoryDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.imgsCategory = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cmsCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvCategory);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvCategory
            // 
            this.tvCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvCategory.ContextMenuStrip = this.cmsCategory;
            this.tvCategory.ImageIndex = 0;
            this.tvCategory.ImageList = this.imgsCategory;
            this.tvCategory.Location = new System.Drawing.Point(0, 0);
            this.tvCategory.Name = "tvCategory";
            this.tvCategory.SelectedImageIndex = 0;
            this.tvCategory.Size = new System.Drawing.Size(266, 450);
            this.tvCategory.TabIndex = 1;
            this.tvCategory.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvCategory_NodeMouseClick);
            this.tvCategory.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tvCategory_MouseUp);
            // 
            // cmsCategory
            // 
            this.cmsCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCategoryCreate,
            this.tsmiCategoryModify,
            this.tsmiCategoryDelete});
            this.cmsCategory.Name = "cmsCategory";
            this.cmsCategory.Size = new System.Drawing.Size(101, 70);
            this.cmsCategory.Opening += new System.ComponentModel.CancelEventHandler(this.cmsCategory_Opening);
            // 
            // tsmiCategoryCreate
            // 
            this.tsmiCategoryCreate.Name = "tsmiCategoryCreate";
            this.tsmiCategoryCreate.Size = new System.Drawing.Size(100, 22);
            this.tsmiCategoryCreate.Text = "新建";
            this.tsmiCategoryCreate.Click += new System.EventHandler(this.tsmiCategoryCreate_Click);
            // 
            // tsmiCategoryModify
            // 
            this.tsmiCategoryModify.Name = "tsmiCategoryModify";
            this.tsmiCategoryModify.Size = new System.Drawing.Size(100, 22);
            this.tsmiCategoryModify.Text = "修改";
            this.tsmiCategoryModify.Click += new System.EventHandler(this.tsmiCategoryModify_Click);
            // 
            // tsmiCategoryDelete
            // 
            this.tsmiCategoryDelete.Name = "tsmiCategoryDelete";
            this.tsmiCategoryDelete.Size = new System.Drawing.Size(100, 22);
            this.tsmiCategoryDelete.Text = "删除";
            this.tsmiCategoryDelete.Click += new System.EventHandler(this.tsmiCategoryDelete_Click);
            // 
            // imgsCategory
            // 
            this.imgsCategory.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgsCategory.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgsCategory.ImageStream")));
            this.imgsCategory.TransparentColor = System.Drawing.Color.Transparent;
            this.imgsCategory.Images.SetKeyName(0, "folder.png");
            this.imgsCategory.Images.SetKeyName(1, "key.png");
            this.imgsCategory.Images.SetKeyName(2, "text.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.cmsCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvCategory;
        private System.Windows.Forms.ContextMenuStrip cmsCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmiCategoryCreate;
        private System.Windows.Forms.ToolStripMenuItem tsmiCategoryModify;
        private System.Windows.Forms.ToolStripMenuItem tsmiCategoryDelete;
        private System.Windows.Forms.ImageList imgsCategory;
    }
}

