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
    public partial class FrmMember : Form
    {
        public FrmMember()
        {
            InitializeComponent();
        }
        MemberDAO memberDAO = null;
        string radiobutton = "";
        private void FrmMember_Load(object sender, EventArgs e)
        {
            try
            {
               memberDAO= new MemberDAO(Setting.connString);
                this.tbNoMember.Text =
                    memberDAO.GetNomorTransaksiBerikutnya();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (this.tbNoMember.Text.Trim() == "")//jika isian nama kosong
            {
                MessageBox.Show("Sorry , nomor wajib isi ...");
                this.tbNoMember.Focus();
            }
            else if (this.tbNama.Text.Trim() == "")
            {
                MessageBox.Show("Sorry ,nama wajib isi ...");
                this.tbNama.Focus();
            }
            else if (this.tbNoHp.Text.Trim() == "")
            {
                MessageBox.Show("Sorry , No Hp wajib isi ...");
                this.tbNoHp.Focus();
            }
            else if (this.tbEmail.Text.Trim() == "")
            {
                MessageBox.Show("Sorry , email wajib isi ...");
                this.tbEmail.Focus();

            }
            else if (radiobutton == "")
            {
                MessageBox.Show("Sorry , jenis kelamin wajib isi ...");
                this.rbPria.Focus();
            }
            else
            {
                Member member = new Member();
                member.Nama = this.tbNama.Text;
                member.Nomor = this.tbNoMember.Text;
                member.NoHp = this.tbNoHp.Text;
                member.Email = this.tbEmail.Text;
                member.JenisKelamin = radiobutton;
                radiobutton = "";
                memberDAO.Insert(member);
                this.Close();
            }
        }

        private void rbPria_CheckedChanged(object sender, EventArgs e)
        {
            radiobutton = "Pria";
        }

        private void rbWanita_CheckedChanged(object sender, EventArgs e)
        {
            radiobutton = "Wanita";
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnlyNumber(object sender, KeyPressEventArgs e)
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
        public void tbEmail_Leave(object sender, EventArgs e)

        {

            if (this.tbEmail.Text.Trim() != "")

            {

                if (!memberDAO.EmailIsValid(this.tbEmail.Text))

                {

                    MessageBox.Show("Sorry, data email tidak valid ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.tbEmail.Clear();

                    this.tbEmail.Focus();

                }

            }
        }
    }
}
