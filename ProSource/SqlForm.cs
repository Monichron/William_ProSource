using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProSource
{
    public partial class SqlForm : Form
    {
        public bool Default { get; set; }
        public SqlForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DefaulrRdo.Checked)
            {
                this.Hide();
            }
            if (Tb1.Text != "" && Tb2.Text != "" && Tb2.Text != "")
            {
                this.Hide();
            }
            
          
        }
        public string Con
        {
            get { return $@"Server={Tb1.Text};Database={Tb2.Text};Trusted_Connection=True;"; }
        }
        public string Table
        {
            get { return $@"{Tb3.Text}"; }
        }
        public bool IsDefault
        {
            
            get { return DefaulrRdo.Checked; }
        }

        private void CustomRdo_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomRdo.Checked)
            {
                DetailsGrp.Visible = true;
                DefaulrRdo.Checked = false;
            }
        }
    }
}
