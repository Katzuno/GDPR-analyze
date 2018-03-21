namespace GDPR_analyze
{
    partial class Start_Form
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
            this.Login_Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_Btn
            // 
            this.Login_Btn.FlatAppearance.BorderSize = 0;
            this.Login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Btn.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Btn.Location = new System.Drawing.Point(23, 266);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(445, 163);
            this.Login_Btn.TabIndex = 0;
            this.Login_Btn.Text = "LOGARE";
            this.Login_Btn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(641, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(445, 163);
            this.button1.TabIndex = 1;
            this.button1.Text = "INREGISTRARE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Start_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Login_Btn);
            this.Name = "Start_Form";
            this.Text = "Home_Menu";
            this.Load += new System.EventHandler(this.Start_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Login_Btn;
        private System.Windows.Forms.Button button1;
    }
}