using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Consecionario
{
    public partial class Form1 : Form
    {
        Consecionario CC1 = new Consecionario();
        //public static DataGridView dgv = new DataGridView();
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            object[] Data;
            string tipo = TypeBox.Text;
            string marca = comboBox2.Text;
            string modelo = comboBox3.Text;
            int km = Int32.Parse(comboBox4.Text);
            double precio = Convert.ToDouble(comboBox5.Text);
            bool Airbag = true, Seguro = false;
            CC1.AddCar(tipo, marca, modelo, km, precio, Airbag, Seguro);
            Data = CC1.ShowCars("auto");
            dataGridView1.DataSource = Data;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
