using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

            //ngatur warna
            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Purple;
            dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.LightCoral;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.DarkBlue;
            dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Turquoise;
            dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.Green;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Green;
            dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Maroon;
            dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.Maroon;

            //ganti nama yang di atas
            dataGridView1.Columns[0].HeaderText = "No. Mahasiswa";
            dataGridView1.Columns[1].HeaderText = "Nama Mahasiswa";
            dataGridView1.Columns[2].HeaderText = "Alamat Mahasiswa";
            dataGridView1.Columns[3].HeaderText = "Jenis Kelamin";
            dataGridView1.Columns[4].HeaderText = "No. Telepon";

        }
    }
}
