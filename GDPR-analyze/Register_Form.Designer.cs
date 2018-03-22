namespace GDPR_analyze
{
    partial class Register_Form
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
			this.register_User_label = new MaterialSkin.Controls.MaterialLabel();
			this.register_User_field = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.register_Pass_field = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.register_Pass_label = new MaterialSkin.Controls.MaterialLabel();
			this.register_Pass2_field = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.register_Pass2_label = new MaterialSkin.Controls.MaterialLabel();
			this.register_Email_field = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.register_Email_label = new MaterialSkin.Controls.MaterialLabel();
			this.register_Company_field = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.register_Company_label = new MaterialSkin.Controls.MaterialLabel();
			this.submit_register_btn = new MaterialSkin.Controls.MaterialRaisedButton();
			this.register_bck_btn = new MaterialSkin.Controls.MaterialRaisedButton();
			this.SuspendLayout();
			// 
			// register_User_label
			// 
			this.register_User_label.AutoSize = true;
			this.register_User_label.Depth = 0;
			this.register_User_label.Font = new System.Drawing.Font("Roboto", 11F);
			this.register_User_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.register_User_label.Location = new System.Drawing.Point(234, 171);
			this.register_User_label.MouseState = MaterialSkin.MouseState.HOVER;
			this.register_User_label.Name = "register_User_label";
			this.register_User_label.Size = new System.Drawing.Size(165, 24);
			this.register_User_label.TabIndex = 0;
			this.register_User_label.Text = "Nume de utilizator";
			// 
			// register_User_field
			// 
			this.register_User_field.Depth = 0;
			this.register_User_field.Hint = "";
			this.register_User_field.Location = new System.Drawing.Point(476, 171);
			this.register_User_field.MaxLength = 32767;
			this.register_User_field.MouseState = MaterialSkin.MouseState.HOVER;
			this.register_User_field.Name = "register_User_field";
			this.register_User_field.PasswordChar = '\0';
			this.register_User_field.SelectedText = "";
			this.register_User_field.SelectionLength = 0;
			this.register_User_field.SelectionStart = 0;
			this.register_User_field.Size = new System.Drawing.Size(262, 28);
			this.register_User_field.TabIndex = 1;
			this.register_User_field.TabStop = false;
			this.register_User_field.UseSystemPasswordChar = false;
			this.register_User_field.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
			// 
			// register_Pass_field
			// 
			this.register_Pass_field.Depth = 0;
			this.register_Pass_field.Hint = "";
			this.register_Pass_field.Location = new System.Drawing.Point(476, 238);
			this.register_Pass_field.MaxLength = 32767;
			this.register_Pass_field.MouseState = MaterialSkin.MouseState.HOVER;
			this.register_Pass_field.Name = "register_Pass_field";
			this.register_Pass_field.PasswordChar = '\0';
			this.register_Pass_field.SelectedText = "";
			this.register_Pass_field.SelectionLength = 0;
			this.register_Pass_field.SelectionStart = 0;
			this.register_Pass_field.Size = new System.Drawing.Size(262, 28);
			this.register_Pass_field.TabIndex = 3;
			this.register_Pass_field.TabStop = false;
			this.register_Pass_field.UseSystemPasswordChar = false;
			// 
			// register_Pass_label
			// 
			this.register_Pass_label.AutoSize = true;
			this.register_Pass_label.Depth = 0;
			this.register_Pass_label.Font = new System.Drawing.Font("Roboto", 11F);
			this.register_Pass_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.register_Pass_label.Location = new System.Drawing.Point(234, 238);
			this.register_Pass_label.MouseState = MaterialSkin.MouseState.HOVER;
			this.register_Pass_label.Name = "register_Pass_label";
			this.register_Pass_label.Size = new System.Drawing.Size(64, 24);
			this.register_Pass_label.TabIndex = 2;
			this.register_Pass_label.Text = "Parola";
			// 
			// register_Pass2_field
			// 
			this.register_Pass2_field.Depth = 0;
			this.register_Pass2_field.Hint = "";
			this.register_Pass2_field.Location = new System.Drawing.Point(476, 316);
			this.register_Pass2_field.MaxLength = 32767;
			this.register_Pass2_field.MouseState = MaterialSkin.MouseState.HOVER;
			this.register_Pass2_field.Name = "register_Pass2_field";
			this.register_Pass2_field.PasswordChar = '\0';
			this.register_Pass2_field.SelectedText = "";
			this.register_Pass2_field.SelectionLength = 0;
			this.register_Pass2_field.SelectionStart = 0;
			this.register_Pass2_field.Size = new System.Drawing.Size(262, 28);
			this.register_Pass2_field.TabIndex = 5;
			this.register_Pass2_field.TabStop = false;
			this.register_Pass2_field.UseSystemPasswordChar = false;
			// 
			// register_Pass2_label
			// 
			this.register_Pass2_label.AutoSize = true;
			this.register_Pass2_label.Depth = 0;
			this.register_Pass2_label.Font = new System.Drawing.Font("Roboto", 11F);
			this.register_Pass2_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.register_Pass2_label.Location = new System.Drawing.Point(234, 316);
			this.register_Pass2_label.MouseState = MaterialSkin.MouseState.HOVER;
			this.register_Pass2_label.Name = "register_Pass2_label";
			this.register_Pass2_label.Size = new System.Drawing.Size(127, 24);
			this.register_Pass2_label.TabIndex = 4;
			this.register_Pass2_label.Text = "Repeta parola";
			// 
			// register_Email_field
			// 
			this.register_Email_field.Depth = 0;
			this.register_Email_field.Hint = "";
			this.register_Email_field.Location = new System.Drawing.Point(476, 381);
			this.register_Email_field.MaxLength = 32767;
			this.register_Email_field.MouseState = MaterialSkin.MouseState.HOVER;
			this.register_Email_field.Name = "register_Email_field";
			this.register_Email_field.PasswordChar = '\0';
			this.register_Email_field.SelectedText = "";
			this.register_Email_field.SelectionLength = 0;
			this.register_Email_field.SelectionStart = 0;
			this.register_Email_field.Size = new System.Drawing.Size(262, 28);
			this.register_Email_field.TabIndex = 7;
			this.register_Email_field.TabStop = false;
			this.register_Email_field.UseSystemPasswordChar = false;
			// 
			// register_Email_label
			// 
			this.register_Email_label.AutoSize = true;
			this.register_Email_label.Depth = 0;
			this.register_Email_label.Font = new System.Drawing.Font("Roboto", 11F);
			this.register_Email_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.register_Email_label.Location = new System.Drawing.Point(234, 381);
			this.register_Email_label.MouseState = MaterialSkin.MouseState.HOVER;
			this.register_Email_label.Name = "register_Email_label";
			this.register_Email_label.Size = new System.Drawing.Size(63, 24);
			this.register_Email_label.TabIndex = 6;
			this.register_Email_label.Text = "E-Mail";
			// 
			// register_Company_field
			// 
			this.register_Company_field.Depth = 0;
			this.register_Company_field.Hint = "";
			this.register_Company_field.Location = new System.Drawing.Point(476, 439);
			this.register_Company_field.MaxLength = 32767;
			this.register_Company_field.MouseState = MaterialSkin.MouseState.HOVER;
			this.register_Company_field.Name = "register_Company_field";
			this.register_Company_field.PasswordChar = '\0';
			this.register_Company_field.SelectedText = "";
			this.register_Company_field.SelectionLength = 0;
			this.register_Company_field.SelectionStart = 0;
			this.register_Company_field.Size = new System.Drawing.Size(262, 28);
			this.register_Company_field.TabIndex = 9;
			this.register_Company_field.TabStop = false;
			this.register_Company_field.UseSystemPasswordChar = false;
			// 
			// register_Company_label
			// 
			this.register_Company_label.AutoSize = true;
			this.register_Company_label.Depth = 0;
			this.register_Company_label.Font = new System.Drawing.Font("Roboto", 11F);
			this.register_Company_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.register_Company_label.Location = new System.Drawing.Point(234, 439);
			this.register_Company_label.MouseState = MaterialSkin.MouseState.HOVER;
			this.register_Company_label.Name = "register_Company_label";
			this.register_Company_label.Size = new System.Drawing.Size(150, 24);
			this.register_Company_label.TabIndex = 8;
			this.register_Company_label.Text = "Nume companie";
			// 
			// submit_register_btn
			// 
			this.submit_register_btn.AutoSize = true;
			this.submit_register_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.submit_register_btn.Depth = 0;
			this.submit_register_btn.Icon = null;
			this.submit_register_btn.Location = new System.Drawing.Point(497, 540);
			this.submit_register_btn.MouseState = MaterialSkin.MouseState.HOVER;
			this.submit_register_btn.Name = "submit_register_btn";
			this.submit_register_btn.Primary = true;
			this.submit_register_btn.Size = new System.Drawing.Size(176, 36);
			this.submit_register_btn.TabIndex = 10;
			this.submit_register_btn.Text = "INREGISTREAZA-TE";
			this.submit_register_btn.UseVisualStyleBackColor = true;
			this.submit_register_btn.Click += new System.EventHandler(this.submit_register_btn_Click);
			// 
			// register_bck_btn
			// 
			this.register_bck_btn.AutoSize = true;
			this.register_bck_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.register_bck_btn.Depth = 0;
			this.register_bck_btn.FlatAppearance.BorderSize = 0;
			this.register_bck_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.register_bck_btn.Icon = null;
			this.register_bck_btn.Location = new System.Drawing.Point(1006, 92);
			this.register_bck_btn.MouseState = MaterialSkin.MouseState.HOVER;
			this.register_bck_btn.Name = "register_bck_btn";
			this.register_bck_btn.Primary = true;
			this.register_bck_btn.Size = new System.Drawing.Size(66, 36);
			this.register_bck_btn.TabIndex = 11;
			this.register_bck_btn.Text = "BACK";
			this.register_bck_btn.UseVisualStyleBackColor = true;
			this.register_bck_btn.Click += new System.EventHandler(this.register_bck_btn_Click);
			// 
			// Register_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1139, 610);
			this.Controls.Add(this.register_bck_btn);
			this.Controls.Add(this.submit_register_btn);
			this.Controls.Add(this.register_Company_field);
			this.Controls.Add(this.register_Company_label);
			this.Controls.Add(this.register_Email_field);
			this.Controls.Add(this.register_Email_label);
			this.Controls.Add(this.register_Pass2_field);
			this.Controls.Add(this.register_Pass2_label);
			this.Controls.Add(this.register_Pass_field);
			this.Controls.Add(this.register_Pass_label);
			this.Controls.Add(this.register_User_field);
			this.Controls.Add(this.register_User_label);
			this.Name = "Register_Form";
			this.Text = "Register_Form";
			this.Load += new System.EventHandler(this.Register_Form_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel register_User_label;
        private MaterialSkin.Controls.MaterialSingleLineTextField register_User_field;
        private MaterialSkin.Controls.MaterialSingleLineTextField register_Pass_field;
        private MaterialSkin.Controls.MaterialLabel register_Pass_label;
        private MaterialSkin.Controls.MaterialSingleLineTextField register_Pass2_field;
        private MaterialSkin.Controls.MaterialLabel register_Pass2_label;
        private MaterialSkin.Controls.MaterialSingleLineTextField register_Email_field;
        private MaterialSkin.Controls.MaterialLabel register_Email_label;
        private MaterialSkin.Controls.MaterialSingleLineTextField register_Company_field;
        private MaterialSkin.Controls.MaterialLabel register_Company_label;
        private MaterialSkin.Controls.MaterialRaisedButton submit_register_btn;
		private MaterialSkin.Controls.MaterialRaisedButton register_bck_btn;
	}
}