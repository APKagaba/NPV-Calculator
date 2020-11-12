namespace Lab7
{
    partial class Lab7
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
            this.fvaluelbl = new System.Windows.Forms.Label();
            this.ratelbl = new System.Windows.Forms.Label();
            this.yearlbl = new System.Windows.Forms.Label();
            this.pvaluelbl = new System.Windows.Forms.Label();
            this.fvalueTxt = new System.Windows.Forms.TextBox();
            this.rateTxt = new System.Windows.Forms.TextBox();
            this.yearTxt = new System.Windows.Forms.TextBox();
            this.outputVlbl = new System.Windows.Forms.Label();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fvaluelbl
            // 
            this.fvaluelbl.AutoSize = true;
            this.fvaluelbl.Location = new System.Drawing.Point(12, 23);
            this.fvaluelbl.Name = "fvaluelbl";
            this.fvaluelbl.Size = new System.Drawing.Size(93, 17);
            this.fvaluelbl.TabIndex = 0;
            this.fvaluelbl.Text = "Future Value:";
            // 
            // ratelbl
            // 
            this.ratelbl.AutoSize = true;
            this.ratelbl.Location = new System.Drawing.Point(12, 60);
            this.ratelbl.Name = "ratelbl";
            this.ratelbl.Size = new System.Drawing.Size(141, 17);
            this.ratelbl.TabIndex = 1;
            this.ratelbl.Text = "Annual Interest Rate:";
            // 
            // yearlbl
            // 
            this.yearlbl.AutoSize = true;
            this.yearlbl.Location = new System.Drawing.Point(12, 106);
            this.yearlbl.Name = "yearlbl";
            this.yearlbl.Size = new System.Drawing.Size(84, 17);
            this.yearlbl.TabIndex = 2;
            this.yearlbl.Text = "No. of Year:";
            // 
            // pvaluelbl
            // 
            this.pvaluelbl.AutoSize = true;
            this.pvaluelbl.Location = new System.Drawing.Point(12, 147);
            this.pvaluelbl.Name = "pvaluelbl";
            this.pvaluelbl.Size = new System.Drawing.Size(101, 17);
            this.pvaluelbl.TabIndex = 3;
            this.pvaluelbl.Text = "Present Value:";
            // 
            // fvalueTxt
            // 
            this.fvalueTxt.Location = new System.Drawing.Point(186, 18);
            this.fvalueTxt.Name = "fvalueTxt";
            this.fvalueTxt.Size = new System.Drawing.Size(100, 22);
            this.fvalueTxt.TabIndex = 4;
            // 
            // rateTxt
            // 
            this.rateTxt.Location = new System.Drawing.Point(186, 60);
            this.rateTxt.Name = "rateTxt";
            this.rateTxt.Size = new System.Drawing.Size(100, 22);
            this.rateTxt.TabIndex = 5;
            // 
            // yearTxt
            // 
            this.yearTxt.Location = new System.Drawing.Point(186, 106);
            this.yearTxt.Name = "yearTxt";
            this.yearTxt.Size = new System.Drawing.Size(100, 22);
            this.yearTxt.TabIndex = 6;
            // 
            // outputVlbl
            // 
            this.outputVlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputVlbl.Location = new System.Drawing.Point(186, 146);
            this.outputVlbl.Name = "outputVlbl";
            this.outputVlbl.Size = new System.Drawing.Size(100, 23);
            this.outputVlbl.TabIndex = 7;
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(124, 224);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(162, 32);
            this.CalcBtn.TabIndex = 8;
            this.CalcBtn.Text = "Calculate";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // Lab7
            // 
            this.AcceptButton = this.CalcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.outputVlbl);
            this.Controls.Add(this.yearTxt);
            this.Controls.Add(this.rateTxt);
            this.Controls.Add(this.fvalueTxt);
            this.Controls.Add(this.pvaluelbl);
            this.Controls.Add(this.yearlbl);
            this.Controls.Add(this.ratelbl);
            this.Controls.Add(this.fvaluelbl);
            this.Name = "Lab7";
            this.Text = "Lab 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fvaluelbl;
        private System.Windows.Forms.Label ratelbl;
        private System.Windows.Forms.Label yearlbl;
        private System.Windows.Forms.Label pvaluelbl;
        private System.Windows.Forms.TextBox fvalueTxt;
        private System.Windows.Forms.TextBox rateTxt;
        private System.Windows.Forms.TextBox yearTxt;
        private System.Windows.Forms.Label outputVlbl;
        private System.Windows.Forms.Button CalcBtn;
    }
}

