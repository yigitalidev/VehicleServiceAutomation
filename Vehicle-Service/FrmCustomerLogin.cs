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
    public partial class FrmCustomerLogin : Form
    {
        public FrmCustomerLogin()
        {
            InitializeComponent();
        }

        Connection connection = new Connection();


        private void button1_Click(object sender, EventArgs e)
        {
            var ent = connection.EntityFramework();
            var login = (from x in ent.Tbl_Vehicles where x.VehicleOwners == textBox1.Text && x.VehiclePlate == textBox2.Text select x);
            if (login.Any())
            {
                FrmCustomerCar fr = new FrmCustomerCar();
                fr.Plate = textBox2.Text;
                fr.Show();
                this.Hide();
                MessageBox.Show("Login Successful", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Login Failed", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAdminLogin fr = new FrmAdminLogin();
            fr.Show();
            this.Hide();
        }
    }
}
