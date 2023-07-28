
namespace Week5_TaskA
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
            this.nodeX = new System.Windows.Forms.TextBox();
            this.nodeInsert = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nodeY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nodeAdjX = new System.Windows.Forms.TextBox();
            this.nodeAdjY = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.adj = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nodeX
            // 
            this.nodeX.Location = new System.Drawing.Point(12, 180);
            this.nodeX.Name = "nodeX";
            this.nodeX.Size = new System.Drawing.Size(71, 27);
            this.nodeX.TabIndex = 1;
            // 
            // nodeInsert
            // 
            this.nodeInsert.Location = new System.Drawing.Point(12, 54);
            this.nodeInsert.Name = "nodeInsert";
            this.nodeInsert.Size = new System.Drawing.Size(125, 27);
            this.nodeInsert.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insert Nodes";
            // 
            // nodeY
            // 
            this.nodeY.Location = new System.Drawing.Point(89, 180);
            this.nodeY.Name = "nodeY";
            this.nodeY.Size = new System.Drawing.Size(71, 27);
            this.nodeY.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add edge";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Are nodes adjacent?";
            // 
            // nodeAdjX
            // 
            this.nodeAdjX.Location = new System.Drawing.Point(12, 266);
            this.nodeAdjX.Name = "nodeAdjX";
            this.nodeAdjX.Size = new System.Drawing.Size(71, 27);
            this.nodeAdjX.TabIndex = 7;
            // 
            // nodeAdjY
            // 
            this.nodeAdjY.Location = new System.Drawing.Point(89, 266);
            this.nodeAdjY.Name = "nodeAdjY";
            this.nodeAdjY.Size = new System.Drawing.Size(71, 27);
            this.nodeAdjY.TabIndex = 8;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(186, 54);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(94, 29);
            this.insert.TabIndex = 9;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(186, 178);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(94, 29);
            this.add.TabIndex = 10;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(186, 266);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(94, 29);
            this.check.TabIndex = 11;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // adj
            // 
            this.adj.AutoSize = true;
            this.adj.Location = new System.Drawing.Point(25, 307);
            this.adj.Name = "adj";
            this.adj.Size = new System.Drawing.Size(21, 20);
            this.adj.TabIndex = 13;
            this.adj.Text = "//";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(8, 95);
            this.count.Name = "count";
            this.count.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.count.Size = new System.Drawing.Size(102, 20);
            this.count.TabIndex = 14;
            this.count.Text = "Node count: 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "To";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 343);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.count);
            this.Controls.Add(this.adj);
            this.Controls.Add(this.check);
            this.Controls.Add(this.add);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.nodeAdjY);
            this.Controls.Add(this.nodeAdjX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nodeY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nodeInsert);
            this.Controls.Add(this.nodeX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nodeX;
        private System.Windows.Forms.TextBox nodeInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nodeY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nodeAdjX;
        private System.Windows.Forms.TextBox nodeAdjY;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label adj;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

