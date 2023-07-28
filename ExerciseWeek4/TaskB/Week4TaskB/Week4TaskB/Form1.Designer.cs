
namespace Week4TaskB
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
            this.desc = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.TextBox();
            this.fin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bSubmit = new System.Windows.Forms.Button();
            this.Activities = new System.Windows.Forms.ListBox();
            this.display = new System.Windows.Forms.Button();
            this.sort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(44, 40);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(233, 27);
            this.desc.TabIndex = 0;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(44, 102);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(95, 27);
            this.start.TabIndex = 1;
            // 
            // fin
            // 
            this.fin.Location = new System.Drawing.Point(182, 102);
            this.fin.Name = "fin";
            this.fin.Size = new System.Drawing.Size(95, 27);
            this.fin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Activity description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter time in HH.MM format";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "to";
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(114, 135);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(94, 29);
            this.bSubmit.TabIndex = 6;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // Activities
            // 
            this.Activities.FormattingEnabled = true;
            this.Activities.ItemHeight = 20;
            this.Activities.Location = new System.Drawing.Point(12, 181);
            this.Activities.Name = "Activities";
            this.Activities.Size = new System.Drawing.Size(452, 224);
            this.Activities.TabIndex = 7;
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(12, 411);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(138, 29);
            this.display.TabIndex = 8;
            this.display.Text = "Remove activities";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(169, 411);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(138, 29);
            this.sort.TabIndex = 9;
            this.sort.Text = "Sort activities";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.display);
            this.Controls.Add(this.Activities);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fin);
            this.Controls.Add(this.start);
            this.Controls.Add(this.desc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.TextBox start;
        private System.Windows.Forms.TextBox fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.ListBox Activities;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button sort;
    }
}

