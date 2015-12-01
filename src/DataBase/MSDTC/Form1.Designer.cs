namespace MSDTC
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
            this.btnSample = new System.Windows.Forms.Button();
            this.txtSample = new System.Windows.Forms.TextBox();
            this.btnTrans = new System.Windows.Forms.Button();
            this.txtTrans = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSample
            // 
            this.btnSample.Location = new System.Drawing.Point(12, 55);
            this.btnSample.Name = "btnSample";
            this.btnSample.Size = new System.Drawing.Size(75, 23);
            this.btnSample.TabIndex = 1;
            this.btnSample.Text = "sample";
            this.btnSample.UseVisualStyleBackColor = true;
            this.btnSample.Click += new System.EventHandler(this.btnSample_Click);
            // 
            // txtSample
            // 
            this.txtSample.Location = new System.Drawing.Point(1, 118);
            this.txtSample.Name = "txtSample";
            this.txtSample.Size = new System.Drawing.Size(100, 20);
            this.txtSample.TabIndex = 3;
            // 
            // btnTrans
            // 
            this.btnTrans.Location = new System.Drawing.Point(197, 55);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(75, 23);
            this.btnTrans.TabIndex = 4;
            this.btnTrans.Text = "trans";
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // txtTrans
            // 
            this.txtTrans.Location = new System.Drawing.Point(184, 118);
            this.txtTrans.Name = "txtTrans";
            this.txtTrans.Size = new System.Drawing.Size(100, 20);
            this.txtTrans.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtTrans);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.txtSample);
            this.Controls.Add(this.btnSample);
            this.Name = "Form1";
            this.Text = "Sample DB vs Transaction DB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSample;
        private System.Windows.Forms.TextBox txtSample;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.TextBox txtTrans;
    }
}

