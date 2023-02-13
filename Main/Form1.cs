using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Store;

namespace Main
{
    public partial class FrmDisco : Form
    {
        private List<Disco> discoList;
        public FrmDisco()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            try
            {
                DiscoStore store = new DiscoStore();
                discoList = store.listar();
                DgvDisco.DataSource = discoList;
                PbxDisco.Load(discoList[0].ImagenTapa);
                DgvDisco.Columns["ImagenTapa"].Visible = false;
                DgvDisco.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void FrmDisco_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void DgvDisco_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                Disco discoSeleccionado = (Disco)DgvDisco.CurrentRow.DataBoundItem;
                PbxDisco.Load(discoSeleccionado.ImagenTapa);
            }
            catch (Exception)
            {

                 PbxDisco.Load("https://www.came-educativa.com.ar/wp-content/uploads/2022/03/placeholder-3.png");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm agregar = new AddForm();
            agregar.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Disco seleccionado;
            seleccionado = (Disco)DgvDisco.CurrentRow.DataBoundItem;

            AddForm modificar = new AddForm(seleccionado);
            modificar.ShowDialog();
            cargar();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DiscoStore store = new DiscoStore();
            try
            {
                Disco eliminar;
                eliminar = (Disco)DgvDisco.CurrentRow.DataBoundItem;

                store.delete(eliminar.Id);
                cargar();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }
    }
}
