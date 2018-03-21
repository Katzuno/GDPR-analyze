namespace GDPR_analyze
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnAudit = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnFormulare = new System.Windows.Forms.Button();
			this.btnReqAccess = new System.Windows.Forms.Button();
			this.panelChoice = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Aquamarine;
			this.panel1.Controls.Add(this.btnReqAccess);
			this.panel1.Controls.Add(this.btnFormulare);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.btnAudit);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(257, 604);
			this.panel1.TabIndex = 3;
			// 
			// btnAudit
			// 
			this.btnAudit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnAudit.FlatAppearance.BorderSize = 0;
			this.btnAudit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAudit.Location = new System.Drawing.Point(0, 124);
			this.btnAudit.Name = "btnAudit";
			this.btnAudit.Size = new System.Drawing.Size(257, 121);
			this.btnAudit.TabIndex = 0;
			this.btnAudit.Text = "AUDIT";
			this.btnAudit.UseVisualStyleBackColor = true;
			this.btnAudit.Click += new System.EventHandler(this.btnAudit_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Turquoise;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(257, 124);
			this.panel2.TabIndex = 1;
			// 
			// btnFormulare
			// 
			this.btnFormulare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnFormulare.FlatAppearance.BorderSize = 0;
			this.btnFormulare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFormulare.Location = new System.Drawing.Point(0, 244);
			this.btnFormulare.Name = "btnFormulare";
			this.btnFormulare.Size = new System.Drawing.Size(257, 121);
			this.btnFormulare.TabIndex = 2;
			this.btnFormulare.Text = "FORMULARE";
			this.btnFormulare.UseVisualStyleBackColor = true;
			this.btnFormulare.Click += new System.EventHandler(this.btnFormulare_Click);
			// 
			// btnReqAccess
			// 
			this.btnReqAccess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnReqAccess.FlatAppearance.BorderSize = 0;
			this.btnReqAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReqAccess.Location = new System.Drawing.Point(0, 364);
			this.btnReqAccess.Name = "btnReqAccess";
			this.btnReqAccess.Size = new System.Drawing.Size(257, 121);
			this.btnReqAccess.TabIndex = 3;
			this.btnReqAccess.Text = "Solicita Acces";
			this.btnReqAccess.UseVisualStyleBackColor = true;
			this.btnReqAccess.Click += new System.EventHandler(this.btnReqAccess_Click);
			// 
			// panelChoice
			// 
			this.panelChoice.BackColor = System.Drawing.Color.Turquoise;
			this.panelChoice.Location = new System.Drawing.Point(256, 124);
			this.panelChoice.Name = "panelChoice";
			this.panelChoice.Size = new System.Drawing.Size(10, 121);
			this.panelChoice.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1107, 604);
			this.Controls.Add(this.panelChoice);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnAudit;
		private System.Windows.Forms.Button btnReqAccess;
		private System.Windows.Forms.Button btnFormulare;
		private System.Windows.Forms.Panel panelChoice;
	}
}

