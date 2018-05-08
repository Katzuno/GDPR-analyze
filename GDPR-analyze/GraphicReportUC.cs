﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDPR_analyze
{
	public partial class GraphicReportUC : UserControl
	{
		public GraphicReportUC()
		{
			InitializeComponent();
            legalGrf.Value = displayAsPercentage(AUDIT_SINGLE_PAGE.lstNrQPerCty[0], AUDIT_SINGLE_PAGE.lstYesNumberPerCty[0]);
            bunifuGauge2.Value = displayAsPercentage(AUDIT_SINGLE_PAGE.lstNrQPerCty[1], AUDIT_SINGLE_PAGE.lstYesNumberPerCty[1]);
            bunifuGauge3.Value = displayAsPercentage(AUDIT_SINGLE_PAGE.lstNrQPerCty[2], AUDIT_SINGLE_PAGE.lstYesNumberPerCty[2]);
        }

        private int displayAsPercentage(int total, int value)
        {
            int percentage;
            percentage = value * 100 / total;
            return percentage;
        }
        private void legalGrf_Load(object sender, EventArgs e)
        {

        }

        private void bunifuGauge2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuGauge3_Load(object sender, EventArgs e)
        {

        }
    }
}