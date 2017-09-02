namespace AddSciryApp
{
    partial class 文件加解密
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
            this.AddOrSub = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.AddOrSubs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddOrSub
            // 
            this.AddOrSub.Location = new System.Drawing.Point(761, 88);
            this.AddOrSub.Name = "AddOrSub";
            this.AddOrSub.Size = new System.Drawing.Size(75, 23);
            this.AddOrSub.TabIndex = 0;
            this.AddOrSub.Text = "加/解";
            this.AddOrSub.UseVisualStyleBackColor = true;
            this.AddOrSub.Click += new System.EventHandler(this.AddOrSub_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(465, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(290, 21);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "请支付晓明老师100元 (●ˇ∀ˇ●)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 21);
            this.textBox3.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(653, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Browser";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddOrSubs
            // 
            this.AddOrSubs.Location = new System.Drawing.Point(761, 156);
            this.AddOrSubs.Name = "AddOrSubs";
            this.AddOrSubs.Size = new System.Drawing.Size(75, 23);
            this.AddOrSubs.TabIndex = 6;
            this.AddOrSubs.Text = "批量加/解";
            this.AddOrSubs.UseVisualStyleBackColor = true;
            this.AddOrSubs.Click += new System.EventHandler(this.AddOrSubs_Click);
            // 
            // 文件加解密
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 258);
            this.Controls.Add(this.AddOrSubs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddOrSub);
            this.Name = "文件加解密";
            this.Text = "晓明老师的加密宝典";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddOrSub;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddOrSubs;
    }
}

