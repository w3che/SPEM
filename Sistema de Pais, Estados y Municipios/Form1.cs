using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Pais__Estados_y_Municipios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxMunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxEstado.SelectedItem)
            {
                case "Quintana Roo":
                    listBoxMunicipios.Items.Add("Bacalar");
                    listBoxMunicipios.Items.Add("Benito Juárez");
                    listBoxMunicipios.Items.Add("Cozumel");
                    listBoxMunicipios.Items.Add("Isla Mujeres");
                    listBoxMunicipios.Items.Add("José María Morelos");
                    listBoxMunicipios.Items.Add("Lázaro Cárdenas");
                    listBoxMunicipios.Items.Add("Othón P. Blanco");
                    listBoxMunicipios.Items.Add("Puerto Morelos");
                    listBoxMunicipios.Items.Add("Solidaridad");
                    listBoxMunicipios.Items.Add("Tulum");
                    listBoxMunicipios.SelectedIndex = 0;
                    break;
                case "Yucatán":
                    break;
                default:
                    listBoxMunicipios.Items.Clear();
                    break;
            }
        }

        private void comboBoxPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonConexion_Click(object sender, EventArgs e)
        {
            Clases.CConnection objetoConexion = new Clases.CConnection();
            objetoConexion.establecerConexion();
        }
    }
}
