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
            this.ClassIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Create = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Senior1 = new System.Windows.Forms.Button();
            this.Senior2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.GroupList.Location = new System.Drawing.Point(12, 12);
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
            // ClassIndex
            // 
            this.ClassIndex.Text = "班级编号";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(12, 261);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(192, 23);
            this.Create.TabIndex = 3;
            this.Create.Text = "生成";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Senior1
            // 
            this.Senior1.Location = new System.Drawing.Point(210, 33);
            this.Senior1.Name = "Senior1";
            this.Senior1.Size = new System.Drawing.Size(77, 23);
            this.Senior1.TabIndex = 5;
            this.Senior1.Text = "高一";
            this.Senior1.UseVisualStyleBackColor = true;
            this.Senior1.Click += new System.EventHandler(this.Senior1_Click);
            // 
            // Senior2
            // 
            this.Senior2.Location = new System.Drawing.Point(210, 84);
            this.Senior2.Name = "Senior2";
            this.Senior2.Size = new System.Drawing.Size(77, 23);
            this.Senior2.TabIndex = 6;
            this.Senior2.Text = "高二";
            this.Senior2.UseVisualStyleBackColor = true;
            this.Senior2.Click += new System.EventHandler(this.Senior2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "  双十中学\r\n 网络科技部 \r\n   杨承岳";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 296);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Senior2);
            this.Controls.Add(this.Senior1);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.GroupList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "班级分组";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

