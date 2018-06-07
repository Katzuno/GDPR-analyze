namespace GDPR_analyze
{
	partial class HistoricCompareAudit
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoricCompareAudit));
            this.HistoricCompareTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.GoToDiagram = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.historicTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current_answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.HistoricCompareTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // HistoricCompareTable
            // 
            this.HistoricCompareTable.AllowUserToAddRows = false;
            this.HistoricCompareTable.AllowUserToDeleteRows = false;
            this.HistoricCompareTable.AllowUserToResizeColumns = false;
            this.HistoricCompareTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.HistoricCompareTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.HistoricCompareTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.HistoricCompareTable.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.HistoricCompareTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HistoricCompareTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HistoricCompareTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.HistoricCompareTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoricCompareTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.question,
            this.last_answer,
            this.current_answer});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HistoricCompareTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.HistoricCompareTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoricCompareTable.DoubleBuffered = true;
            this.HistoricCompareTable.EnableHeadersVisualStyles = false;
            this.HistoricCompareTable.HeaderBgColor = System.Drawing.Color.DarkOrange;
            this.HistoricCompareTable.HeaderForeColor = System.Drawing.Color.White;
            this.HistoricCompareTable.Location = new System.Drawing.Point(100, 100);
            this.HistoricCompareTable.Name = "HistoricCompareTable";
            this.HistoricCompareTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.HistoricCompareTable.RowTemplate.DividerHeight = 2;
            this.HistoricCompareTable.RowTemplate.Height = 100;
            this.HistoricCompareTable.RowTemplate.ReadOnly = true;
            this.HistoricCompareTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HistoricCompareTable.Size = new System.Drawing.Size(1457, 837);
            this.HistoricCompareTable.TabIndex = 0;
            this.HistoricCompareTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // GoToDiagram
            // 
            this.GoToDiagram.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.GoToDiagram.BackColor = System.Drawing.Color.DarkOrange;
            this.GoToDiagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GoToDiagram.BorderRadius = 0;
            this.GoToDiagram.ButtonText = "Avanseaza la analiza grafica";
            this.GoToDiagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToDiagram.DisabledColor = System.Drawing.Color.Gray;
            this.GoToDiagram.Iconcolor = System.Drawing.Color.Transparent;
            this.GoToDiagram.Iconimage = ((System.Drawing.Image)(resources.GetObject("GoToDiagram.Iconimage")));
            this.GoToDiagram.Iconimage_right = null;
            this.GoToDiagram.Iconimage_right_Selected = null;
            this.GoToDiagram.Iconimage_Selected = null;
            this.GoToDiagram.IconMarginLeft = 0;
            this.GoToDiagram.IconMarginRight = 0;
            this.GoToDiagram.IconRightVisible = true;
            this.GoToDiagram.IconRightZoom = 0D;
            this.GoToDiagram.IconVisible = true;
            this.GoToDiagram.IconZoom = 90D;
            this.GoToDiagram.IsTab = false;
            this.GoToDiagram.Location = new System.Drawing.Point(1236, 27);
            this.GoToDiagram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoToDiagram.Name = "GoToDiagram";
            this.GoToDiagram.Normalcolor = System.Drawing.Color.DarkOrange;
            this.GoToDiagram.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.GoToDiagram.OnHoverTextColor = System.Drawing.Color.White;
            this.GoToDiagram.selected = false;
            this.GoToDiagram.Size = new System.Drawing.Size(321, 59);
            this.GoToDiagram.TabIndex = 1;
            this.GoToDiagram.Text = "Avanseaza la analiza grafica";
            this.GoToDiagram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GoToDiagram.Textcolor = System.Drawing.Color.White;
            this.GoToDiagram.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToDiagram.Click += new System.EventHandler(this.GoToDiagram_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HistoricCompareTable);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1657, 1037);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GoToDiagram);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 937);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1657, 100);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.historicTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1657, 100);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 837);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1557, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(100, 837);
            this.panel6.TabIndex = 6;
            // 
            // historicTitle
            // 
            this.historicTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historicTitle.AutoSize = true;
            this.historicTitle.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historicTitle.Location = new System.Drawing.Point(172, 31);
            this.historicTitle.Name = "historicTitle";
            this.historicTitle.Size = new System.Drawing.Size(918, 56);
            this.historicTitle.TabIndex = 0;
            this.historicTitle.Text = "Comparatie intre ultimele doua audite";
            this.historicTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // question
            // 
            this.question.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.question.FillWeight = 500F;
            this.question.HeaderText = "Intrebare";
            this.question.Name = "question";
            this.question.ReadOnly = true;
            this.question.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // last_answer
            // 
            this.last_answer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.last_answer.HeaderText = "Raspunsul dumneavoastra la ultimul audit";
            this.last_answer.Name = "last_answer";
            this.last_answer.ReadOnly = true;
            this.last_answer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.last_answer.Width = 247;
            // 
            // current_answer
            // 
            this.current_answer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.current_answer.HeaderText = "Raspunsul dumneavoastra la auditul curent";
            this.current_answer.Name = "current_answer";
            this.current_answer.ReadOnly = true;
            this.current_answer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.current_answer.Width = 251;
            // 
            // HistoricCompareAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "HistoricCompareAudit";
            this.Size = new System.Drawing.Size(1657, 1037);
            ((System.ComponentModel.ISupportInitialize)(this.HistoricCompareTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid HistoricCompareTable;
        private Bunifu.Framework.UI.BunifuFlatButton GoToDiagram;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuCustomLabel historicTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn question;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn current_answer;
    }
}
