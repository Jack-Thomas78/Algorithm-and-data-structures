namespace Week1_2TaskB
{
    partial class Form1
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
            this.titleT = new System.Windows.Forms.TextBox();
            this.authorT = new System.Windows.Forms.TextBox();
            this.journalT = new System.Windows.Forms.TextBox();
            this.yearT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addB = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.removeB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleT
            // 
            this.titleT.Location = new System.Drawing.Point(33, 48);
            this.titleT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titleT.Name = "titleT";
            this.titleT.Size = new System.Drawing.Size(132, 22);
            this.titleT.TabIndex = 0;
            // 
            // authorT
            // 
            this.authorT.Location = new System.Drawing.Point(33, 101);
            this.authorT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.authorT.Name = "authorT";
            this.authorT.Size = new System.Drawing.Size(132, 22);
            this.authorT.TabIndex = 1;
            // 
            // journalT
            // 
            this.journalT.Location = new System.Drawing.Point(33, 154);
            this.journalT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.journalT.Name = "journalT";
            this.journalT.Size = new System.Drawing.Size(132, 22);
            this.journalT.TabIndex = 2;
            // 
            // yearT
            // 
            this.yearT.Location = new System.Drawing.Point(33, 207);
            this.yearT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearT.Name = "yearT";
            this.yearT.Size = new System.Drawing.Size(132, 22);
            this.yearT.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Journal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Publication Year";
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(32, 237);
            this.addB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(133, 28);
            this.addB.TabIndex = 8;
            this.addB.Text = "Add Paper";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(225, 28);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(768, 244);
            this.listBox1.TabIndex = 9;
            // 
            // removeB
            // 
            this.removeB.Location = new System.Drawing.Point(33, 273);
            this.removeB.Margin = new System.Windows.Forms.Padding(4);
            this.removeB.Name = "removeB";
            this.removeB.Size = new System.Drawing.Size(133, 28);
            this.removeB.TabIndex = 10;
            this.removeB.Text = "Remove Paper";
            this.removeB.UseVisualStyleBackColor = true;
            this.removeB.Click += new System.EventHandler(this.removeB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 309);
            this.Controls.Add(this.removeB);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearT);
            this.Controls.Add(this.journalT);
            this.Controls.Add(this.authorT);
            this.Controls.Add(this.titleT);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleT;
        private System.Windows.Forms.TextBox authorT;
        private System.Windows.Forms.TextBox journalT;
        private System.Windows.Forms.TextBox yearT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button removeB;
    }
}

