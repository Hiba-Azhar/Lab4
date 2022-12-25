namespace MatrixAdv
{
    partial class Form2
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
            this.f200 = new System.Windows.Forms.TextBox();
            this.f201 = new System.Windows.Forms.TextBox();
            this.f210 = new System.Windows.Forms.TextBox();
            this.f211 = new System.Windows.Forms.TextBox();
            this.Sbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // f200
            // 
            this.f200.Location = new System.Drawing.Point(66, 102);
            this.f200.Name = "f200";
            this.f200.Size = new System.Drawing.Size(100, 23);
            this.f200.TabIndex = 0;
            // 
            // f201
            // 
            this.f201.Location = new System.Drawing.Point(247, 102);
            this.f201.Name = "f201";
            this.f201.Size = new System.Drawing.Size(100, 23);
            this.f201.TabIndex = 1;
            // 
            // f210
            // 
            this.f210.Location = new System.Drawing.Point(66, 173);
            this.f210.Name = "f210";
            this.f210.Size = new System.Drawing.Size(100, 23);
            this.f210.TabIndex = 3;
            // 
            // f211
            // 
            this.f211.Location = new System.Drawing.Point(247, 173);
            this.f211.Name = "f211";
            this.f211.Size = new System.Drawing.Size(100, 23);
            this.f211.TabIndex = 4;
            // 
            // Sbtn
            // 
            this.Sbtn.Location = new System.Drawing.Point(521, 128);
            this.Sbtn.Name = "Sbtn";
            this.Sbtn.Size = new System.Drawing.Size(100, 46);
            this.Sbtn.TabIndex = 6;
            this.Sbtn.Text = "Submit";
            this.Sbtn.UseVisualStyleBackColor = true;
            this.Sbtn.Click += new System.EventHandler(this.Sbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sbtn);
            this.Controls.Add(this.f211);
            this.Controls.Add(this.f210);
            this.Controls.Add(this.f201);
            this.Controls.Add(this.f200);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox f200;
        private TextBox f201;
        private TextBox f210;
        private TextBox f211;
        private Button Sbtn;
    }
}