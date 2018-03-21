namespace GDPR_analyze
{
    partial class Login_Form
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
            this.username_label = new MaterialSkin.Controls.MaterialLabel();
            this.user_field = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pass_field = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.submit_login_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Depth = 0;
            this.username_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.username_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.username_label.Location = new System.Drawing.Point(184, 253);
            this.username_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(165, 24);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "Nume de utilizator";
            // 
            // user_field
            // 
            this.user_field.Depth = 0;
            this.user_field.Hint = "";
            this.user_field.Location = new System.Drawing.Point(431, 253);
            this.user_field.MaxLength = 32767;
            this.user_field.MouseState = MaterialSkin.MouseState.HOVER;
            this.user_field.Name = "user_field";
            this.user_field.PasswordChar = '\0';
            this.user_field.SelectedText = "";
            this.user_field.SelectionLength = 0;
            this.user_field.SelectionStart = 0;
            this.user_field.Size = new System.Drawing.Size(338, 28);
            this.user_field.TabIndex = 1;
            this.user_field.TabStop = false;
            this.user_field.UseSystemPasswordChar = false;
            this.user_field.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // pass_field
            // 
            this.pass_field.Depth = 0;
            this.pass_field.Hint = "";
            this.pass_field.Location = new System.Drawing.Point(431, 337);
            this.pass_field.MaxLength = 32767;
            this.pass_field.MouseState = MaterialSkin.MouseState.HOVER;
            this.pass_field.Name = "pass_field";
            this.pass_field.PasswordChar = '\0';
            this.pass_field.SelectedText = "";
            this.pass_field.SelectionLength = 0;
            this.pass_field.SelectionStart = 0;
            this.pass_field.Size = new System.Drawing.Size(338, 28);
            this.pass_field.TabIndex = 3;
            this.pass_field.TabStop = false;
            this.pass_field.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(184, 337);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 24);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Parola";
            // 
            // submit_login_btn
            // 
            this.submit_login_btn.AutoSize = true;
            this.submit_login_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submit_login_btn.Depth = 0;
            this.submit_login_btn.Icon = null;
            this.submit_login_btn.Location = new System.Drawing.Point(524, 461);
            this.submit_login_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.submit_login_btn.Name = "submit_login_btn";
            this.submit_login_btn.Primary = true;
            this.submit_login_btn.Size = new System.Drawing.Size(136, 36);
            this.submit_login_btn.TabIndex = 4;
            this.submit_login_btn.Text = "Logheaza-te";
            this.submit_login_btn.UseVisualStyleBackColor = true;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 610);
            this.Controls.Add(this.submit_login_btn);
            this.Controls.Add(this.pass_field);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.user_field);
            this.Controls.Add(this.username_label);
            this.Name = "Login_Form";
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel username_label;
        private MaterialSkin.Controls.MaterialSingleLineTextField user_field;
        private MaterialSkin.Controls.MaterialSingleLineTextField pass_field;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton submit_login_btn;
    }
}