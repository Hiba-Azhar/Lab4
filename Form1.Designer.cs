namespace MatrixAdv
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
            this.f100 = new System.Windows.Forms.TextBox();
            this.f101 = new System.Windows.Forms.TextBox();
            this.f110 = new System.Windows.Forms.TextBox();
            this.f111 = new System.Windows.Forms.TextBox();
            this.Sbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // f100
            // 
            this.f100.Location = new System.Drawing.Point(39, 107);
            this.f100.Name = "f100";
            this.f100.Size = new System.Drawing.Size(100, 23);
            this.f100.TabIndex = 0;
            // 
            // f101
            // 
            this.f101.Location = new System.Drawing.Point(187, 107);
            this.f101.Name = "f101";
            this.f101.Size = new System.Drawing.Size(100, 23);
            this.f101.TabIndex = 1;
            // 
            // f110
            // 
            this.f110.Location = new System.Drawing.Point(39, 169);
            this.f110.Name = "f110";
            this.f110.Size = new System.Drawing.Size(100, 23);
            this.f110.TabIndex = 3;
            // 
            // f111
            // 
            this.f111.Location = new System.Drawing.Point(187, 169);
            this.f111.Name = "f111";
            this.f111.Size = new System.Drawing.Size(100, 23);
            this.f111.TabIndex = 4;
            // 
            // Sbtn
            // 
            this.Sbtn.Location = new System.Drawing.Point(375, 131);
            this.Sbtn.Name = "Sbtn";
            this.Sbtn.Size = new System.Drawing.Size(91, 37);
            this.Sbtn.TabIndex = 6;
            this.Sbtn.Text = "Submit";
            this.Sbtn.UseVisualStyleBackColor = true;
            this.Sbtn.Click += new System.EventHandler(this.Sbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.Sbtn);
            this.Controls.Add(this.f111);
            this.Controls.Add(this.f110);
            this.Controls.Add(this.f101);
            this.Controls.Add(this.f100);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox f100;
        private TextBox f101;
        private TextBox f110;
        private TextBox f111;
        private Button Sbtn;
    }
}