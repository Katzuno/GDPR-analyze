namespace GDPR_analyze
{
    partial class MainMenu
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnReqAccess = new System.Windows.Forms.Button();
			this.btnFormulare = new System.Windows.Forms.Button();
			this.btnAudit = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
			this.tabPageAudit = new System.Windows.Forms.TabPage();
			this.tabPageForm = new System.Windows.Forms.TabPage();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.materialTabControl1.SuspendLayout();
			this.tabPageAudit.SuspendLayout();
			this.tabPageForm.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel1.Controls.Add(this.btnReqAccess);
			this.panel1.Controls.Add(this.btnFormulare);
			this.panel1.Controls.Add(this.btnAudit);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(256, 604);
			this.panel1.TabIndex = 3;
			// 
			// btnReqAccess
			// 
			this.btnReqAccess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnReqAccess.FlatAppearance.BorderSize = 0;
			this.btnReqAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReqAccess.Location = new System.Drawing.Point(0, 312);
			this.btnReqAccess.Name = "btnReqAccess";
			this.btnReqAccess.Size = new System.Drawing.Size(257, 121);
			this.btnReqAccess.TabIndex = 3;
			this.btnReqAccess.Text = "Solicita Acces";
			this.btnReqAccess.UseVisualStyleBackColor = true;
			this.btnReqAccess.Click += new System.EventHandler(this.btnReqAccess_Click);
			// 
			// btnFormulare
			// 
			this.btnFormulare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnFormulare.FlatAppearance.BorderSize = 0;
			this.btnFormulare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFormulare.Location = new System.Drawing.Point(0, 192);
			this.btnFormulare.Name = "btnFormulare";
			this.btnFormulare.Size = new System.Drawing.Size(257, 121);
			this.btnFormulare.TabIndex = 2;
			this.btnFormulare.Text = "FORMULARE";
			this.btnFormulare.UseVisualStyleBackColor = true;
			this.btnFormulare.Click += new System.EventHandler(this.btnFormulare_Click);
			// 
			// btnAudit
			// 
			this.btnAudit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnAudit.FlatAppearance.BorderSize = 0;
			this.btnAudit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAudit.Location = new System.Drawing.Point(0, 72);
			this.btnAudit.Name = "btnAudit";
			this.btnAudit.Size = new System.Drawing.Size(257, 121);
			this.btnAudit.TabIndex = 0;
			this.btnAudit.Text = "AUDIT";
			this.btnAudit.UseVisualStyleBackColor = true;
			this.btnAudit.Click += new System.EventHandler(this.btnAudit_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.materialTabControl1);
			this.panel2.Location = new System.Drawing.Point(256, 64);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(852, 540);
			this.panel2.TabIndex = 4;
			// 
			// materialTabControl1
			// 
			this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialTabControl1.Controls.Add(this.tabPageAudit);
			this.materialTabControl1.Controls.Add(this.tabPageForm);
			this.materialTabControl1.Depth = 0;
			this.materialTabControl1.Location = new System.Drawing.Point(-6, -7);
			this.materialTabControl1.Margin = new System.Windows.Forms.Padding(0);
			this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialTabControl1.Name = "materialTabControl1";
			this.materialTabControl1.Padding = new System.Drawing.Point(0, 0);
			this.materialTabControl1.SelectedIndex = 0;
			this.materialTabControl1.Size = new System.Drawing.Size(862, 554);
			this.materialTabControl1.TabIndex = 0;
			// 
			// tabPageAudit
			// 
			this.tabPageAudit.BackColor = System.Drawing.Color.LightGray;
			this.tabPageAudit.Controls.Add(this.panel4);
			this.tabPageAudit.Font = new System.Drawing.Font("Bahnschrift", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPageAudit.Location = new System.Drawing.Point(4, 42);
			this.tabPageAudit.Name = "tabPageAudit";
			this.tabPageAudit.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAudit.Size = new System.Drawing.Size(854, 508);
			this.tabPageAudit.TabIndex = 0;
			this.tabPageAudit.Text = "Audit";
			// 
			// tabPageForm
			// 
			this.tabPageForm.BackColor = System.Drawing.Color.Silver;
			this.tabPageForm.Controls.Add(this.panel3);
			this.tabPageForm.Font = new System.Drawing.Font("Bahnschrift", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPageForm.Location = new System.Drawing.Point(4, 42);
			this.tabPageForm.Name = "tabPageForm";
			this.tabPageForm.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageForm.Size = new System.Drawing.Size(854, 508);
			this.tabPageForm.TabIndex = 1;
			this.tabPageForm.Text = "Form";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel3.Controls.Add(this.vScrollBar1);
			this.panel3.Controls.Add(this.materialRadioButton1);
			this.panel3.Controls.Add(this.materialLabel1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(848, 502);
			this.panel3.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(3, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(848, 502);
			this.panel4.TabIndex = 0;
			// 
			// materialLabel1
			// 
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(71, 236);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(136, 24);
			this.materialLabel1.TabIndex = 0;
			this.materialLabel1.Text = "materialLabel1";
			// 
			// materialRadioButton1
			// 
			this.materialRadioButton1.AutoSize = true;
			this.materialRadioButton1.Depth = 0;
			this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
			this.materialRadioButton1.Location = new System.Drawing.Point(334, 236);
			this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
			this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRadioButton1.Name = "materialRadioButton1";
			this.materialRadioButton1.Ripple = true;
			this.materialRadioButton1.Size = new System.Drawing.Size(198, 30);
			this.materialRadioButton1.TabIndex = 2;
			this.materialRadioButton1.TabStop = true;
			this.materialRadioButton1.Text = "materialRadioButton1";
			this.materialRadioButton1.UseVisualStyleBackColor = true;
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
			this.vScrollBar1.Location = new System.Drawing.Point(827, 0);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(21, 502);
			this.vScrollBar1.TabIndex = 3;
			// 
			// MainMenu
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1107, 604);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MainMenu";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.materialTabControl1.ResumeLayout(false);
			this.tabPageAudit.ResumeLayout(false);
			this.tabPageForm.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAudit;
		private System.Windows.Forms.Button btnReqAccess;
		private System.Windows.Forms.Button btnFormulare;
		private System.Windows.Forms.Panel panel2;
		private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
		private System.Windows.Forms.TabPage tabPageAudit;
		private System.Windows.Forms.TabPage tabPageForm;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private System.Windows.Forms.VScrollBar vScrollBar1;
	}
}

