using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dateBase
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

   
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();

            // При загрузке окна добавляем в comboBox1


            comboBox1.Items.AddRange(new string[] { "Уругвай", "Эквадор" });

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void database1DataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
