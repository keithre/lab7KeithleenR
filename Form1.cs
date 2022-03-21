using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7KeithleenR
{
    public partial class Form1 : Form
    {
        List<Propiedad> propiedades = new List<Propiedad>();
        List<Propietario> propietarios = new List<Propietario>();
        List<Resumen> resumen = new List<Resumen>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CargarPropiedades()
        {
            FileStream stream = new FileStream("Propiedades.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Propiedad propiedad = new Propiedad();
                propiedad.NoCasa = Convert.ToInt16(reader.ReadLine());
                propiedad.DPI = reader.ReadLine();
                propiedad.CuotaMantenimiento =Convert.ToDecimal(reader.ReadLine());
                propiedades.Add(propiedad);
            }
            
            reader.Close();
        }

        private void CargarPropietarios()
        {
            FileStream stream = new FileStream("Propietarios.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Propietario propietario = new Propietario();
                propietario.DPI = reader.ReadLine();
                propietario.Nombre = reader.ReadLine();
                propietario.Apellido = reader.ReadLine();
                propietarios.Add(propietario);
            }

            reader.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            btnOrdenar.Enabled = true;
            CargarPropiedades();
            CargarPropietarios();

            for (int i = 0; i < propiedades.Count; i++)
            {
                for (int j = 0; j < propietarios.Count; j++)
                {
                    if (propiedades[i].DPI == propietarios[j].DPI)
                    {
                        Resumen resumen1 = new Resumen();
                        resumen1.Nombre = propietarios[j].Nombre;
                        resumen1.Apellido = propietarios[j].Apellido;
                        resumen1.NoCasa = propiedades[i].NoCasa;
                        resumen1.CuotaMantenimiento = propiedades[i].CuotaMantenimiento;
                        resumen.Add(resumen1);

                    }
                }
            }

            dataGridView1.DataSource = resumen;
            dataGridView1.Refresh();

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            btnMam.Enabled = true;
            btnMostrarMayor.Enabled = true;
            resumen = resumen.OrderBy(x => x.CuotaMantenimiento).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = resumen;
            dataGridView1.Refresh();

        }

        private void btnMam_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            labelme.Text = resumen[0].CuotaMantenimiento.ToString();
            int cant = resumen.Count();
            labelM.Text = resumen[cant - 1].CuotaMantenimiento.ToString();
        }

        private void btnMostrarMayor_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            label1.Visible = true;
            labelme.Text = "";
            int cant = resumen.Count();
            labelM.Text = resumen[cant - 1].Nombre.ToString()+ " " + resumen[cant - 1].Apellido.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
