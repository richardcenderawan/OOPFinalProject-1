using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReceiptLibrary;

namespace FrmReceipt
{
    public partial class FrmKonfirmasi : Form
    {
        String noMember;
        public FrmKonfirmasi()
        {
            InitializeComponent();
        }
        public FrmKonfirmasi(String NoMember)
        {
            noMember = NoMember;
            InitializeComponent();
            
        } 
       
        private void FrmKonfirmasi_Load(object sender, EventArgs e)
        {
            if (noMember.Trim() == "")
            {
                 lblNoMember.Text = "Non Member";
                 tbPPNPersen.Text = Convert.ToInt64(10%);
            }
            else if(noMember.Trim() != "")
            {
                lblNoMember.Text = $"No Member :{noMember}";
                tbDiscPersen.Text = "10%";
               
            }


        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {

        }
    }
}
