using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSSqul.Data;
using Utilities;

namespace Rhenium.Client
{
    public partial class RheniumLeague : Form
    {
        public RheniumLeague()
        {
            InitializeComponent();
        }

        private async void CreateSqlServerDb_Click(object sender, EventArgs e)
        {
            var msSqlRepo = new MSSqlRepo();

            //var task = msSqlRepo.CreateDb();
            await msSqlRepo.CreateDb();
            MessageBox.Show(
                "The db is created",
                "Db creation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


        }

        private void GenerateJsonReport_btn_Click(object sender, EventArgs e)
        {
            JsonUtils.JsonCreateReports();
                MessageBox.Show(
                    "The JSON report is generated",
                    "JSON report",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            
        }
    }
}
