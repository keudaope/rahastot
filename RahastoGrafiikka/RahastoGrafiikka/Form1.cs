using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;

namespace RahastoGrafiikka
{
    public partial class Form1 : Form
    {
        RAHASTO rahasto = new RAHASTO();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RahastotDG.DataSource = rahasto.haeSijoitukset();
            tulosTaulu.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Päivä",
                Labels = new[] { "1.", "2.", "1.", "2.", "1.", "2.", "1.", "2.", "1.", "2.", "1.", "2." }
            });
            tulosTaulu.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Markkina-arvot",
                LabelFormatter = value => value.ToString("C")
            });
            tulosTaulu.LegendLocation = LiveCharts.LegendLocation.Right;
        }

        private void LataaPainike_Click(object sender, EventArgs e)
        {
            tulosTaulu.Series.Clear();
            SeriesCollection sarjat = new SeriesCollection();
            var paivat = (from o in RahastotDG.DataSource as List<Rahastot> select new { Paiva = o.Paiva }).Distinct();
            foreach(var paiva in paivat)
            {
                List<double> arvot = new List<double>();
                for(int kk = 1; kk <=12; kk++)
                {
                    double arvo = 0;
                    var data = from o in tulosTaulu.Da as List<Rahastot>
                }
            }
        }
    }
}
