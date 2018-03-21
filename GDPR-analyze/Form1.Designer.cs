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
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
			this.materialCheckBox2 = new MaterialSkin.Controls.MaterialCheckBox();
			this.SuspendLayout();
			// 
			// materialLabel1
			// 
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(148, 202);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(136, 24);
			this.materialLabel1.TabIndex = 0;
			this.materialLabel1.Text = "materialLabel1";
			// 
			// materialCheckBox1
			// 
			this.materialCheckBox1.AutoSize = true;
			this.materialCheckBox1.Depth = 0;
			this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
			this.materialCheckBox1.Location = new System.Drawing.Point(152, 144);
			this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
			this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCheckBox1.Name = "materialCheckBox1";
			this.materialCheckBox1.Ripple = true;
			this.materialCheckBox1.Size = new System.Drawing.Size(181, 30);
			this.materialCheckBox1.TabIndex = 1;
			this.materialCheckBox1.Text = "materialCheckBox1";
			this.materialCheckBox1.UseVisualStyleBackColor = true;
			// 
			// materialCheckBox2
			// 
			this.materialCheckBox2.AutoSize = true;
			this.materialCheckBox2.Depth = 0;
			this.materialCheckBox2.Font = new System.Drawing.Font("Roboto", 10F);
			this.materialCheckBox2.Location = new System.Drawing.Point(140, 275);
			this.materialCheckBox2.Margin = new System.Windows.Forms.Padding(0);
			this.materialCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialCheckBox2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCheckBox2.Name = "materialCheckBox2";
			this.materialCheckBox2.Ripple = true;
			this.materialCheckBox2.Size = new System.Drawing.Size(181, 30);
			this.materialCheckBox2.TabIndex = 2;
			this.materialCheckBox2.Text = "materialCheckBox2";
			this.materialCheckBox2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 408);
			this.Controls.Add(this.materialCheckBox2);
			this.Controls.Add(this.materialCheckBox1);
			this.Controls.Add(this.materialLabel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
		private MaterialSkin.Controls.MaterialCheckBox materialCheckBox2;
	}
}

