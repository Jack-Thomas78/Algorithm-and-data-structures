namespace week5TaskB
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
            this.name = new System.Windows.Forms.TextBox();
            this.xNode = new System.Windows.Forms.TextBox();
            this.yNode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addEdgeB = new System.Windows.Forms.Button();
            this.removeB = new System.Windows.Forms.Button();
            this.displayB = new System.Windows.Forms.Button();
            this.countL = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(28, 39);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 0;
            // 
            // xNode
            // 
            this.xNode.Location = new System.Drawing.Point(28, 97);
            this.xNode.Name = "xNode";
            this.xNode.Size = new System.Drawing.Size(100, 20);
            this.xNode.TabIndex = 1;
            // 
            // yNode
            // 
            this.yNode.Location = new System.Drawing.Point(28, 134);
            this.yNode.Name = "yNode";
            this.yNode.Size = new System.Drawing.Size(100, 20);
            this.yNode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(144, 18);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(102, 23);
            this.addB.TabIndex = 4;
            this.addB.Text = "Add person";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add connection from";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "to";
            // 
            // addEdgeB
            // 
            this.addEdgeB.Location = new System.Drawing.Point(28, 169);
            this.addEdgeB.Name = "addEdgeB";
            this.addEdgeB.Size = new System.Drawing.Size(100, 23);
            this.addEdgeB.TabIndex = 7;
            this.addEdgeB.Text = "Add connection";
            this.addEdgeB.UseVisualStyleBackColor = true;
            this.addEdgeB.Click += new System.EventHandler(this.addEdgeB_Click);
            // 
            // removeB
            // 
            this.removeB.Location = new System.Drawing.Point(265, 18);
            this.removeB.Name = "removeB";
            this.removeB.Size = new System.Drawing.Size(102, 23);
            this.removeB.TabIndex = 8;
            this.removeB.Text = "Remove person";
            this.removeB.UseVisualStyleBackColor = true;
            this.removeB.Click += new System.EventHandler(this.removeB_Click);
            // 
            // displayB
            // 
            this.displayB.Location = new System.Drawing.Point(194, 47);
            this.displayB.Name = "displayB";
            this.displayB.Size = new System.Drawing.Size(121, 23);
            this.displayB.TabIndex = 9;
            this.displayB.Text = "Display connections";
            this.displayB.UseVisualStyleBackColor = true;
            this.displayB.Click += new System.EventHandler(this.displayB_Click);
            // 
            // countL
            // 
            this.countL.AutoSize = true;
            this.countL.Location = new System.Drawing.Point(57, 213);
            this.countL.Name = "countL";
            this.countL.Size = new System.Drawing.Size(47, 13);
            this.countL.TabIndex = 11;
            this.countL.Text = "Count: 0";
            // 
            // listBox1
            // 
            this.listBox1.HideSelection = false;
            this.listBox1.Location = new System.Drawing.Point(144, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 145);
            this.listBox1.TabIndex = 12;
            this.listBox1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 241);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.countL);
            this.Controls.Add(this.displayB);
            this.Controls.Add(this.removeB);
            this.Controls.Add(this.addEdgeB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yNode);
            this.Controls.Add(this.xNode);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox xNode;
        private System.Windows.Forms.TextBox yNode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addEdgeB;
        private System.Windows.Forms.Button removeB;
        private System.Windows.Forms.Button displayB;
        private System.Windows.Forms.Label countL;
        private System.Windows.Forms.ListView listBox1;
    }
}

