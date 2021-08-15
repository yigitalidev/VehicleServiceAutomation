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
    public partial class FrmVehicles : Form
    {
        public FrmVehicles()
        {
            InitializeComponent();

        }

        Connection connection = new Connection();
       

        void refresh()
        {
            var ent = connection.EntityFramework();
            dataGridView1.DataSource = ent.Tbl_Vehicles.ToList();
        }

        private void FrmVehicles_Load(object sender, EventArgs e)
        {
            refresh();
        }


        private void btnVehAdd_Click(object sender, EventArgs e)
        {
            var ent = connection.EntityFramework();
            try
            {
                Tbl_Vehicles tbl_Vehicles = new Tbl_Vehicles();
                tbl_Vehicles.VehicleOwners = txtOwner.Text;
                tbl_Vehicles.VehicleBrand = txtBrand.Text;
                tbl_Vehicles.VehicleModel = txtModel.Text;
                tbl_Vehicles.VehiclePlate = txtPlate.Text;
                tbl_Vehicles.VehiclePlate = txtPlate.Text;
                tbl_Vehicles.VehicleProblem = txtProblem.Text;
                if (rbPreparing.Checked)
                {
                    tbl_Vehicles.VehicleStatus = "Preparing";
                }
                else if (rbReady.Checked)
                {
                    tbl_Vehicles.VehicleStatus = "Ready";
                }
                ent.Tbl_Vehicles.Add(tbl_Vehicles);
                ent.SaveChanges();
                MessageBox.Show("Vehicle Added", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("System Error", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnVehDelete_Click(object sender, EventArgs e)
        {
            var ent = connection.EntityFramework();
            try
            {
                var vehicle = ent.Tbl_Vehicles.Find(Convert.ToInt32(txtID.Text));
                ent.Tbl_Vehicles.Remove(vehicle);
                ent.SaveChanges();
                MessageBox.Show("Vehicle Deleted", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("System Error", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnVehUpdate_Click(object sender, EventArgs e)
        {
            var ent = connection.EntityFramework();
            try
            {
                var vehicle = ent.Tbl_Vehicles.Find(Convert.ToInt32(txtID.Text));
                vehicle.VehicleOwners = txtOwner.Text;
                vehicle.VehicleBrand = txtBrand.Text;
                vehicle.VehicleModel = txtModel.Text;
                vehicle.VehiclePlate = txtPlate.Text;
                vehicle.VehicleProblem = txtProblem.Text;
                if (rbPreparing.Checked)
                {
                    vehicle.VehicleStatus = "Preparing";
                }
                else if (rbReady.Checked)
                {
                    vehicle.VehicleStatus = "Ready";
                }
                ent.SaveChanges();
                MessageBox.Show("Vehicle Information Updated", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("System Error", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtOwner.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBrand.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtModel.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "Preparing")
            {
                rbPreparing.Checked = true;
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "Ready")
            {
                rbReady.Checked = true;
            }
            txtPlate.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtProblem.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btunGraphics_Click(object sender, EventArgs e)
        {
            FrmGraphics fr = new FrmGraphics();
            fr.Show();
        }
    }
}
