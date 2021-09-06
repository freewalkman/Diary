
namespace Diary.Win
{
    partial class CategoryManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblParent = new System.Windows.Forms.Label();
            this.cbxParent = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.lblShowOrder = new System.Windows.Forms.Label();
            this.tbxShowOrder = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.tbxRemark = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "分类名称：";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(88, 13);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(380, 23);
            this.tbxName.TabIndex = 1;
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.Location = new System.Drawing.Point(13, 52);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(68, 17);
            this.lblParent.TabIndex = 0;
            this.lblParent.Text = "所属分类：";
            // 
            // cbxParent
            // 
            this.cbxParent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxParent.FormattingEnabled = true;
            this.cbxParent.Location = new System.Drawing.Point(88, 52);
            this.cbxParent.Name = "cbxParent";
            this.cbxParent.Size = new System.Drawing.Size(380, 24);
            this.cbxParent.TabIndex = 2;
            this.cbxParent.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbxParent_DrawItem);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(13, 95);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 17);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "类型：";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(88, 92);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(380, 25);
            this.cbxType.TabIndex = 2;
            // 
            // lblShowOrder
            // 
            this.lblShowOrder.AutoSize = true;
            this.lblShowOrder.Location = new System.Drawing.Point(13, 134);
            this.lblShowOrder.Name = "lblShowOrder";
            this.lblShowOrder.Size = new System.Drawing.Size(68, 17);
            this.lblShowOrder.TabIndex = 0;
            this.lblShowOrder.Text = "显示顺序：";
            // 
            // tbxShowOrder
            // 
            this.tbxShowOrder.Location = new System.Drawing.Point(88, 134);
            this.tbxShowOrder.Name = "tbxShowOrder";
            this.tbxShowOrder.Size = new System.Drawing.Size(380, 23);
            this.tbxShowOrder.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(13, 175);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(44, 17);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "描述：";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(88, 175);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(380, 82);
            this.tbxDescription.TabIndex = 1;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(13, 269);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(44, 17);
            this.lblRemark.TabIndex = 0;
            this.lblRemark.Text = "备注：";
            // 
            // tbxRemark
            // 
            this.tbxRemark.Location = new System.Drawing.Point(88, 269);
            this.tbxRemark.Multiline = true;
            this.tbxRemark.Name = "tbxRemark";
            this.tbxRemark.Size = new System.Drawing.Size(380, 82);
            this.tbxRemark.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(298, 367);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(393, 367);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CategoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 408);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.cbxParent);
            this.Controls.Add(this.tbxRemark);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.tbxShowOrder);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblShowOrder);
            this.Controls.Add(this.lblParent);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.Name = "CategoryManagerForm";
            this.Text = "分类管理对话框";
            this.Load += new System.EventHandler(this.CategoryManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.ComboBox cbxParent;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label lblShowOrder;
        private System.Windows.Forms.TextBox tbxShowOrder;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox tbxRemark;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
    }
}