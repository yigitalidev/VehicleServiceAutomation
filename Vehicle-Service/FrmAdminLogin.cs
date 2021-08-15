using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Service
{
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }

        Connection connection = new Connection();

        private void button1_Click(object sender, EventArgs e)
        {
            var ent = connection.EntityFramework();

            var login = (from x in ent.Tbl_Admin where x.AdminName == textBox1.Text && x.AdminPassword == textBox2.Text select x);
            if (login.Any())
            {
                FrmVehicles fr = new FrmVehicles();
                fr.Show();
                this.Hide();
                MessageBox.Show("Giriş Başarılı", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Giriş Başarısız", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmAdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
