using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class Form2 : Form
    {
        private int registroActual = 0;
        private DataTable datos = new DataTable();
        private List<string> imagenes = new List<string>(); // almacena las rutas de las imágenes
        private int imagenActual = 0; // controla la imagen actual
        private string rutaImagenes = @"C:\Users\Ventu\OneDrive\Desktop\Pokedex"; // Ruta de la carpeta de imágenes


        public Form2()
        {
            BackgroundImage = Image.FromFile("C:\\Users\\Ventu\\OneDrive\\Desktop\\poke2.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
            InitializeComponent();
            CargarDatos();
            CargarImagenes(); // Llama para cargar las imágenes

        }
        private void CargarDatos()
        {
            SqlConnection conexion = new SqlConnection(@"server=MSI\SQLEXPRESS; database=Pokedex; INTEGRATED SECURITY=true");
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT nDexNa,Nombre,Descripcion,Habilidad1,Habilidad2,HabilidadOculta,Tipo1,Tipo2 FROM Pokemon", conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        private void MostrarRegistro()
        {
            if (datos.Rows.Count > 0 && registroActual < datos.Rows.Count)
            {
                DataRow fila = datos.Rows[registroActual];
                lbld.Text = $"nDexNa: {fila["nDexNa"]}\nNombre: {fila["Nombre"]}\nDescripcion: {fila["Descripcion"]}\nHabilidad1: {fila["Habilidad1"]}\nHabilidad2: {fila["Habilidad2"]}\nHabilidadoculta: {fila["Habilidadoculta"]}\nTipo1: {fila["Tipo1"]}\nTipo2: {fila["Tipo2"]}";
            }
            else
            {
                MessageBox.Show("No hay más registros.");
            }
        }
        private void CargarImagenes()
        {
            // Verifica si la carpeta
            if (Directory.Exists(rutaImagenes))
            {
                // Obtiene todas las imágenes con extensión .jpg y .png
                imagenes = Directory.GetFiles(rutaImagenes, "*.jpg").ToList();
                imagenes.AddRange(Directory.GetFiles(rutaImagenes, "*.png"));

            }
        }
        private void MostrarImagen()

        {
            // Verifica si hay imágenes en la lista y muestra la imagen actual
            if (imagenes.Count > 1 && imagenActual < imagenes.Count)
            {
                pictureBox2.Image = Image.FromFile(imagenes[imagenActual]);
            }

            else
            {
                MessageBox.Show("No hay más imágenes.");
            }

        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (registroActual < datos.Rows.Count - 1)
                {
                    registroActual++;
                    MostrarRegistro();
                }
                else
                {
                    MessageBox.Show("No hay más registros.");
                }

                // Verifica si hay imágenes en la lista
                if (imagenes.Count == 0 && imagenActual > 0)
                {
                    MessageBox.Show("No se encontraron imágenes en la carpeta.");
                    return;
                }
                if (imagenes.Count > 0) // Si hay imágenes disponibles
                {
                    //  Cambia la imagen en el mismo clic
                    imagenActual = registroActual % imagenes.Count; // Sincroniza la imagen
                    MostrarImagen(); // Muestra la imagen correspondiente
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnr_Click(object sender, EventArgs e)
        {
            if (registroActual > 0)
            {
                registroActual--;
                MostrarRegistro();
            }
            else
            {
                MessageBox.Show("Este es el primer registro.");
            }

            // Regresa a la imagen anterior si no estamos en la primera
            if (imagenes.Count > 0)
            {
                imagenActual--; // Retrocede a la imagen anterior
                MostrarImagen(); // Muestra la imagen actual
            }
            else
            {
                MessageBox.Show("Ya estás en la primera imagen.");
            }

        }

        private void btne_Click(object sender, EventArgs e)
        {
            MostrarRegistro();
            // Muestra la primera imagen
            if (imagenes.Count > 0)
            {
                imagenActual = 0; // índice de la primera imagen
                MostrarImagen();  // primera imagen la muestra
            }
            else
            {
                MessageBox.Show("No se encontraron imágenes en la carpeta.");
            }

        }

        private void lbld_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}