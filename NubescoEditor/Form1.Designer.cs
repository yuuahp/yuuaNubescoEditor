namespace NubescoEditor
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.IMOcheck = new System.Windows.Forms.RadioButton();
            this.Nubescocheck = new System.Windows.Forms.RadioButton();
            this.output = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.wcheck = new System.Windows.Forms.RadioButton();
            this.daaacheck = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nullcheck = new System.Windows.Forms.RadioButton();
            this.nicocheck = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "あなただけの(　՞ةڼ◔)や顔文字を作成しましょう！ｗ";
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.input.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.input.Location = new System.Drawing.Point(189, 87);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(120, 26);
            this.input.TabIndex = 3;
            this.input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IMOcheck
            // 
            this.IMOcheck.AutoSize = true;
            this.IMOcheck.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IMOcheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IMOcheck.Location = new System.Drawing.Point(15, 19);
            this.IMOcheck.Name = "IMOcheck";
            this.IMOcheck.Size = new System.Drawing.Size(121, 23);
            this.IMOcheck.TabIndex = 5;
            this.IMOcheck.Text = "└(┐┘)┌";
            this.IMOcheck.UseVisualStyleBackColor = true;
            this.IMOcheck.CheckedChanged += new System.EventHandler(this.IMOcheck_CheckedChanged);
            // 
            // Nubescocheck
            // 
            this.Nubescocheck.AutoSize = true;
            this.Nubescocheck.Checked = true;
            this.Nubescocheck.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Nubescocheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Nubescocheck.Location = new System.Drawing.Point(15, 48);
            this.Nubescocheck.Name = "Nubescocheck";
            this.Nubescocheck.Size = new System.Drawing.Size(124, 23);
            this.Nubescocheck.TabIndex = 6;
            this.Nubescocheck.TabStop = true;
            this.Nubescocheck.Text = "└(　՞ةڼ◔)┘";
            this.Nubescocheck.UseVisualStyleBackColor = true;
            this.Nubescocheck.CheckedChanged += new System.EventHandler(this.IMOcheck_CheckedChanged);
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.output.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.output.Location = new System.Drawing.Point(15, 166);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(542, 26);
            this.output.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(571, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Copy !";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wcheck
            // 
            this.wcheck.AutoSize = true;
            this.wcheck.Location = new System.Drawing.Point(35, 21);
            this.wcheck.Name = "wcheck";
            this.wcheck.Size = new System.Drawing.Size(34, 16);
            this.wcheck.TabIndex = 9;
            this.wcheck.Text = "!w";
            this.wcheck.UseVisualStyleBackColor = true;
            this.wcheck.CheckedChanged += new System.EventHandler(this.IMOcheck_CheckedChanged);
            // 
            // daaacheck
            // 
            this.daaacheck.AutoSize = true;
            this.daaacheck.Checked = true;
            this.daaacheck.Location = new System.Drawing.Point(35, 43);
            this.daaacheck.Name = "daaacheck";
            this.daaacheck.Size = new System.Drawing.Size(331, 28);
            this.daaacheck.TabIndex = 10;
            this.daaacheck.TabStop = true;
            this.daaacheck.Text = "だァーーーーーーーーーーーー!!!!!!!\r\n(ﾄｩﾙﾛﾛﾃｯﾃﾚｰwwwwwwﾃﾚﾃｯﾃﾃwwwwﾃﾃｰwww)www(以下略\r\n";
            this.daaacheck.UseVisualStyleBackColor = true;
            this.daaacheck.CheckedChanged += new System.EventHandler(this.IMOcheck_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nullcheck);
            this.groupBox1.Controls.Add(this.wcheck);
            this.groupBox1.Controls.Add(this.daaacheck);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(331, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 115);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text2";
            // 
            // nullcheck
            // 
            this.nullcheck.AutoSize = true;
            this.nullcheck.Location = new System.Drawing.Point(35, 77);
            this.nullcheck.Name = "nullcheck";
            this.nullcheck.Size = new System.Drawing.Size(43, 16);
            this.nullcheck.TabIndex = 11;
            this.nullcheck.Text = "Null";
            this.nullcheck.UseVisualStyleBackColor = true;
            this.nullcheck.CheckedChanged += new System.EventHandler(this.IMOcheck_CheckedChanged);
            // 
            // nicocheck
            // 
            this.nicocheck.AutoSize = true;
            this.nicocheck.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nicocheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nicocheck.Location = new System.Drawing.Point(15, 77);
            this.nicocheck.Name = "nicocheck";
            this.nicocheck.Size = new System.Drawing.Size(105, 23);
            this.nicocheck.TabIndex = 12;
            this.nicocheck.Text = "  ( ◠‿◠ )";
            this.nicocheck.UseVisualStyleBackColor = true;
            this.nicocheck.CheckedChanged += new System.EventHandler(this.IMOcheck_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nicocheck);
            this.groupBox2.Controls.Add(this.IMOcheck);
            this.groupBox2.Controls.Add(this.Nubescocheck);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(17, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 115);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(748, 210);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NubescoEditor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.RadioButton IMOcheck;
        private System.Windows.Forms.RadioButton Nubescocheck;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton wcheck;
        private System.Windows.Forms.RadioButton daaacheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton nicocheck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton nullcheck;
    }
}

