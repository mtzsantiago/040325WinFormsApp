using System;
using System.Windows.Forms;
using System.Collections.Generic;
using _040325WinFormsApp;

namespace _250225
{
    public partial class Form1 : Form
    {
        private DiscoRepository repo;

        public Form1()
        {
            InitializeComponent();
            repo = new DiscoRepository();
            CargarDiscos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var disco = new Disco
            {
                nombre = txtNombre.Text,
                artista = txtArtista.Text,
                genero = txtGenero.Text,
                anio = int.Parse(txtAnio.Text),
                precio = decimal.Parse(txtPrecio.Text)
            };

            repo.InsertarDisco(disco);
            CargarDiscos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDiscos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvDiscos.SelectedRows[0].Cells[0].Value);
                repo.EliminarDisco(id);
                CargarDiscos();
            }
            else
            {
                MessageBox.Show("Selecciona un disco para eliminar.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvDiscos.SelectedRows.Count > 0)
            {
                var disco = new Disco
                {
                    id = Convert.ToInt32(dgvDiscos.SelectedRows[0].Cells[0].Value),
                    nombre = txtNombre.Text,
                    artista = txtArtista.Text,
                    genero = txtGenero.Text,
                    anio = int.Parse(txtAnio.Text),
                    precio = decimal.Parse(txtPrecio.Text)
                };

                repo.ActualizarDisco(disco);
                CargarDiscos();
            }
            else
            {
                MessageBox.Show("Selecciona un disco para actualizar.");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarDiscos();
        }

        private void CargarDiscos()
        {
            List<Disco> discos = repo.ObtenerDisco();
            dgvDiscos.DataSource = discos;
        }
    }
}
