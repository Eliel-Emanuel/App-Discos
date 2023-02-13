using Dominio;
using Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class AddForm : Form
    {
        private Disco disco = null;
        public AddForm()
        {
            InitializeComponent();
        }

        public AddForm(Disco disco)
        {
            InitializeComponent();
            this.disco = disco;
            Text = "Modify disc";

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            EstiloStore estilo = new EstiloStore();
            EdicionStore edicion = new EdicionStore();

            try
            {
                cboxEstilo.DataSource = estilo.listar();
                cboxEstilo.ValueMember = "Id";
                cboxEstilo.DisplayMember = "Descripcion";
                cboxEdicion.DataSource = edicion.listar();
                cboxEdicion.ValueMember = "Id";
                cboxEdicion.DisplayMember = "Descripcion";

                if (disco != null)
                {
                    tbxTitulo.Text = disco.Titulo;
                    tbxCantidadCanciones.Text = disco.CantidadCanciones.ToString();
                    dtpLanzamiento.Value = disco.FechaLanzamiento;
                    tboxImagen.Text = disco.ImagenTapa;
                    cargarImagen(disco.ImagenTapa);
                    cboxEstilo.SelectedValue = disco.EstiloMusical.Id;
                    cboxEdicion.SelectedValue = disco.TipoEdicion.Id;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Disco nuevoDisco = new Disco();
            DiscoStore conexion = new DiscoStore();

            try
            {
                if(disco == null)
                    disco = new Disco();


                disco.Titulo = tbxTitulo.Text;
                disco.CantidadCanciones = int.Parse(tbxCantidadCanciones.Text);
                disco.FechaLanzamiento = dtpLanzamiento.Value;
                disco.ImagenTapa = tboxImagen.Text;
                cargarImagen(tboxImagen.Text);
                disco.EstiloMusical = (Estilo)cboxEstilo.SelectedItem;
                disco.TipoEdicion = (Edicion)cboxEdicion.SelectedItem;

                if(disco.Id != 0)
                {
                    conexion.modify(disco);
                    MessageBox.Show("Disco modificado");
                }
                else
                {
                    conexion.add(disco);
                    MessageBox.Show("Disco agregado");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxModificar.Load(imagen);
            }
            catch (Exception)
            {

                pbxModificar.Load("https://www.came-educativa.com.ar/wp-content/uploads/2022/03/placeholder-3.png");
            }
        }

        private void tboxImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(tboxImagen.Text);
        }
    }
}
