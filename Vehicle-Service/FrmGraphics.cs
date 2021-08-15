using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vehicle_Service
{
    public partial class FrmGraphics : Form
    {
        public FrmGraphics()
        {
            InitializeComponent();
        }

        private void FrmGraphics_Load(object sender, EventArgs e)
        {
            SqlCommand chartCommand1 = new SqlCommand("Select VehicleStatus,Count(*) from Tbl_Vehicles group by VehicleStatus", Connection.SqlServer());
            SqlDataReader chartReader = chartCommand1.ExecuteReader();
            while (chartReader.Read())
            {
                chart1.Series["Vehicles"].Points.AddXY(chartReader[0],chartReader[1]);  
            }
            Connection.SqlServer().Close();


            SqlCommand chartCommand2 = new SqlCommand("Select VehicleStatus,Count(*) from Tbl_Vehicles group by VehicleStatus", Connection.SqlServer());
            SqlDataReader chartReader2 = chartCommand2.ExecuteReader();
            while (chartReader2.Read())
            {
                chart2.Series["Vehicles"].Points.AddXY(chartReader2[0], chartReader2[1]);
            }
            Connection.SqlServer().Close();
        }
    }
}
