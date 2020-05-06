namespace Bai01
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
            this.label1 = new System.Windows.Forms.Label();
            this.tboxX = new System.Windows.Forms.TextBox();
            this.tboxY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPow = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "x:";
            // 
            // tboxX
            // 
            this.tboxX.Location = new System.Drawing.Point(62, 32);
            this.tboxX.Name = "tboxX";
            this.tboxX.Size = new System.Drawing.Size(90, 20);
            this.tboxX.TabIndex = 1;
            // 
            // tboxY
            // 
            this.tboxY.Location = new System.Drawing.Point(62, 66);
            this.tboxY.Name = "tboxY";
            this.tboxY.Size = new System.Drawing.Size(90, 20);
            this.tboxY.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "y:";
            // 
            // btnPow
            // 
            this.btnPow.Location = new System.Drawing.Point(31, 104);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(62, 23);
            this.btnPow.TabIndex = 4;
            this.btnPow.Text = "Pow";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(108, 109);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(71, 13);
            this.lbResult.TabIndex = 5;
            this.lbResult.Text = "Result is here";
            this.lbResult.Click += new System.EventHandler(this.lbResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 173);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxY);
            this.Controls.Add(this.tboxX);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "x";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxX;
        private System.Windows.Forms.TextBox tboxY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Label lbResult;
    }
}

