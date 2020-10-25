namespace RandomDivide
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GroupList = new System.Windows.Forms.ListView();
            this.Class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Create = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ClassIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Senior1 = new System.Windows.Forms.Button();
            this.Senior2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GroupList
            // 
            this.GroupList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Class,
            this.Group,
            this.ClassIndex});
            this.GroupList.HideSelection = false;
            this.GroupList.LabelEdit = true;
            this.GroupList.Location = new System.Drawing.Point(24, 12);
            this.GroupList.Name = "GroupList";
            this.GroupList.ShowItemToolTips = true;
            this.GroupList.Size = new System.Drawing.Size(192, 243);
            this.GroupList.TabIndex = 2;
            this.toolTip1.SetToolTip(this.GroupList, "按\"+\"按钮 添加班级,按\"Delete键\"删除班级。");
            this.GroupList.UseCompatibleStateImageBehavior = false;
            this.GroupList.View = System.Windows.Forms.View.Details;
            this.GroupList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GroupList_KeyDown);
            // 
            // Class
            // 
            this.Class.Text = "班级";
            this.Class.Width = 50;
            // 
            // Group
            // 
            this.Group.Text = "组别";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(24, 261);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(192, 23);
            this.Create.TabIndex = 3;
            this.Create.Text = "生成";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // ClassIndex
            // 
            this.ClassIndex.Text = "班级编号";
            // 
            // Senior1
            // 
            this.Senior1.Location = new System.Drawing.Point(222, 123);
            this.Senior1.Name = "Senior1";
            this.Senior1.Size = new System.Drawing.Size(65, 23);
            this.Senior1.TabIndex = 5;
            this.Senior1.Text = "高一";
            this.Senior1.UseVisualStyleBackColor = true;
            this.Senior1.Click += new System.EventHandler(this.Senior1_Click);
            // 
            // Senior2
            // 
            this.Senior2.Location = new System.Drawing.Point(222, 170);
            this.Senior2.Name = "Senior2";
            this.Senior2.Size = new System.Drawing.Size(65, 23);
            this.Senior2.TabIndex = 6;
            this.Senior2.Text = "高二";
            this.Senior2.UseVisualStyleBackColor = true;
            this.Senior2.Click += new System.EventHandler(this.Senior2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 296);
            this.Controls.Add(this.Senior2);
            this.Controls.Add(this.Senior1);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.GroupList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "班级分组";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView GroupList;
        private System.Windows.Forms.ColumnHeader Class;
        private System.Windows.Forms.ColumnHeader Group;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColumnHeader ClassIndex;
        private System.Windows.Forms.Button Senior1;
        private System.Windows.Forms.Button Senior2;
    }
}

