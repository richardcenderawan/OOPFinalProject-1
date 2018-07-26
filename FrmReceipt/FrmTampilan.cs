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
    public partial class FrmTampilan : Form
    {
        FrmMember member = new FrmMember();
        MemberDAO memberDAO = new MemberDAO(Setting.connString);
      
        string jenis;
        int jlh001, jlh002, jlh003, jlh004, jlh005, jlh006, jlh007, jlh008, jlh009, jlh010, jlh011, jlh012 = 0;
        public FrmTampilan()
        {
            InitializeComponent();
            this.FrmTampilan_Resize(null, null);
        }

        private void btnSpaghetti_Click(object sender, EventArgs e)
        {
            jenis = "Spaghetti Aglio Olio";
            tbJumlahItem.Text = jlh001.ToString();
        }
        private void btnFriedRice_Click(object sender, EventArgs e)
        {
            jenis = "Fried Rice";
            tbJumlahItem.Text = jlh002.ToString();
        }
        private void btnRamen_Click(object sender, EventArgs e)
        {
            jenis = "Ramen Soyu";
            tbJumlahItem.Text = jlh003.ToString();
        }
        private void btnSteak_Click(object sender, EventArgs e)
        {
            jenis = "Beef Steak";
            tbJumlahItem.Text = jlh004.ToString();
        }
        private void btnOmu_Click(object sender, EventArgs e)
        {
            jenis = "Omu Rice";
            tbJumlahItem.Text = jlh005.ToString();
        }

        private void btnHainan_Click(object sender, EventArgs e)
        {
            jenis = "Hainan Chicken Rice";
            tbJumlahItem.Text = jlh006.ToString();
        }

        private void btnFishnChips_Click(object sender, EventArgs e)
        {
            jenis = "Fish n Chips";
            tbJumlahItem.Text = jlh007.ToString();
        }
        private void btnCheese_Click(object sender, EventArgs e)
        {
            jenis = "Cheese Fondue";
            tbJumlahItem.Text = jlh008.ToString();
        }

        private void btnMemberBaru_Click(object sender, EventArgs e)
        {
            member.ShowDialog();
            
        }
        Member result = new Member();
        
        private void tbNoMember_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue== (char)Keys.Enter)
            {
              result = memberDAO.GetDataMemberByNomor(tbNoMember.Text);
              if(result != null) 
                    MessageBox.Show("Member Terdaftar",this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
              else
                    MessageBox.Show("Member Tidak Terdaftar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void tbJumlahItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            FrmKonfirmasi konfirmasi = new FrmKonfirmasi(tbNoMember.Text);
            konfirmasi.ShowDialog();
        }

        private void btnDelete_Leave(object sender, EventArgs e)
        {
            tbJumlahItem.Text = "0";
        }

        private void BtnSake_Click(object sender, EventArgs e)
        {
            jenis = "Sake Holy Water";
            tbJumlahItem.Text = jlh009.ToString();
        }

        private void btnMocktail_Click(object sender, EventArgs e)
        {
            jenis = "Mocktail";
            tbJumlahItem.Text = jlh010.ToString();
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            jenis = "Red Wine";
            tbJumlahItem.Text = jlh011.ToString();
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            jenis = "Coffee";
            tbJumlahItem.Text = jlh012.ToString();
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            tbJumlahItem.Text = (Convert.ToInt16(tbJumlahItem.Text) + 1).ToString();
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16((tbJumlahItem.Text)) > 0)
                tbJumlahItem.Text = (Convert.ToInt16(tbJumlahItem.Text) - 1).ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!tbJumlahItem.Text.Equals("0") && jenis != null)
            {
                if (jenis.Equals("Spaghetti Aglio Olio"))
                    jlh001 = 0;
                else if (jenis.Equals("Fried Rice"))
                    jlh002 = 0;
                else if (jenis.Equals("Ramen Soyu"))
                    jlh003 = 0;
                else if (jenis.Equals("Beef Steak"))
                    jlh004 = 0;
                else if (jenis.Equals("Omu Rice"))
                    jlh005 = 0;
                else if (jenis.Equals("Hainan Chicken Rice"))
                    jlh006 = 0;
                else if (jenis.Equals("Fish n Chips"))
                    jlh007 = 0;
                else if (jenis.Equals("Cheese Fondue"))
                    jlh008 = 0;
                else if (jenis.Equals("Sake Holy Water"))
                    jlh009 = 0;
                else if (jenis.Equals("Mocktail"))
                    jlh010 = 0;
                else if (jenis.Equals("Red Wine"))
                    jlh011 = 0;
                else if (jenis.Equals("Coffee"))
                    jlh012 = 0;
            }
            else if (jenis == null && tbJumlahItem.Text != "0")
                tbJumlahItem.Text = "0";
        }

        private void tbJumlahItem_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16((tbJumlahItem.Text)) < 0)
                tbJumlahItem.Text = "0";
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!tbJumlahItem.Text.Equals("0") && jenis != null)
            {
                if (jenis.Equals("Spaghetti Aglio Olio"))
                    jlh001 = Convert.ToInt16(tbJumlahItem.Text);
                else if (jenis.Equals("Fried Rice"))
                    jlh002 = Convert.ToInt16(tbJumlahItem.Text);
                else if (jenis.Equals("Ramen Soyu"))
                    jlh003 = Convert.ToInt16(tbJumlahItem.Text);
                else if (jenis.Equals("Beef Steak"))
                    jlh004 = Convert.ToInt16(tbJumlahItem.Text);
                else if (jenis.Equals("Omu Rice"))
                    jlh005 = Convert.ToInt16(tbJumlahItem.Text);
                else if (jenis.Equals("Hainan Chicken Rice"))
                    jlh006 = Convert.ToInt16(tbJumlahItem.Text);
                else if (jenis.Equals("Fish n Chips"))
                    jlh007 = Convert.ToInt16(tbJumlahItem.Text);
                else if (jenis.Equals("Cheese Fondue"))
                    jlh008 = Convert.ToInt16(tbJumlahItem.Text);
                else if (jenis.Equals("Sake Holy Water"))
                    jlh009 = Convert.ToInt16(tbJumlahItem.Text);
                else if (jenis.Equals("Mocktail"))
                    jlh010 = Convert.ToInt16(tbJumlahItem.Text);
                else if (jenis.Equals("Red Wine"))
                    jlh011 = Convert.ToInt16(tbJumlahItem.Text);
                else if (jenis.Equals("Coffee"))
                    jlh012 = Convert.ToInt16(tbJumlahItem.Text);
                jenis = null;
            }
            else if (jenis == null && tbJumlahItem.Text != "0")
                tbJumlahItem.Text = "0";

        }

        private void FrmTampilan_Resize(object sender, EventArgs e)
        {
            this.dgvData.Columns[0].Width = 20 * this.dgvData.Width / 100;
            this.dgvData.Columns[1].Width = 50 * this.dgvData.Width / 100;
            this.dgvData.Columns[2].Width = 30 * this.dgvData.Width / 100;

        }
    }
}

