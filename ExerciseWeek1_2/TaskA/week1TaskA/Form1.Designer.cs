
namespace week1TaskA
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
            this.taskinput = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.taskoutput = new System.Windows.Forms.TextBox();
            this.complete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taskinput
            // 
            this.taskinput.Location = new System.Drawing.Point(111, 53);
            this.taskinput.Name = "taskinput";
            this.taskinput.Size = new System.Drawing.Size(183, 27);
            this.taskinput.TabIndex = 0;
            this.taskinput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(320, 50);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(94, 29);
            this.submit.TabIndex = 1;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // taskoutput
            // 
            this.taskoutput.Location = new System.Drawing.Point(111, 230);
            this.taskoutput.Name = "taskoutput";
            this.taskoutput.ReadOnly = true;
            this.taskoutput.Size = new System.Drawing.Size(183, 27);
            this.taskoutput.TabIndex = 2;
            this.taskoutput.Text = "Queue is empty";
            this.taskoutput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // complete
            // 
            this.complete.Location = new System.Drawing.Point(320, 230);
            this.complete.Name = "complete";
            this.complete.Size = new System.Drawing.Size(94, 29);
            this.complete.TabIndex = 3;
            this.complete.Text = "Completed";
            this.complete.UseVisualStyleBackColor = true;
            this.complete.Click += new System.EventHandler(this.complete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Next Task";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // countlabel
            // 
            this.countlabel.AutoSize = true;
            this.countlabel.Location = new System.Drawing.Point(320, 104);
            this.countlabel.Name = "countlabel";
            this.countlabel.Size = new System.Drawing.Size(51, 20);
            this.countlabel.TabIndex = 6;
            this.countlabel.Text = "Count:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 358);
            this.Controls.Add(this.countlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.complete);
            this.Controls.Add(this.taskoutput);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.taskinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox taskinput;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox taskoutput;
        private System.Windows.Forms.Button complete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label countlabel;
    }
}

