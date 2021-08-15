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
    public partial class FrmCustomerCar : Form
    {
        public FrmCustomerCar()
        {
            InitializeComponent();
        }

        public string Plate;

        Connection connection = new Connection();

        private void FrmCustomerCar_Load(object sender, EventArgs e)
        {
            var ent = connection.EntityFramework();
            Tbl_Vehicles tbl_Vehicles = new Tbl_Vehicles();
            dataGridView1.DataSource = (from x in ent.Tbl_Vehicles where x.VehiclePlate == Plate select new {x.VehicleID,x.VehicleBrand,x.VehicleModel,x.VehiclePlate,x.VehicleOwners,x.VehicleStatus,x.VehicleProblem}).ToList();
        }
    }
}
