using Backend;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmAerolinea : Form
    {
        private bool expandido = false;

        public FrmAerolinea()
        {
            InitializeComponent();
            CargarGrid();

            // Conectar eventos
            Butdata.Click += Butdata_Click;
            butGuardar.Click += butGuardar_Click;
            butEditar.Click += butEditar_Click;
            buteliminar.Click += buteliminar_Click;
            botBuscar.Click += botBuscar_Click;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var a = ConstruirDesdeFormulario();
                Aerolinea.Guardar(a);
                MessageBox.Show("Aerolínea guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void butEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textID.Text.Trim().ToUpper();
                var lista = Aerolinea.Leer();
                var existente = lista.FirstOrDefault(x => x.Id == id);

                if (existente != null)
                {
                    var actualizado = ConstruirDesdeFormulario();
                    actualizado.Id = id;
                    int idx = lista.FindIndex(x => x.Id == id);
                    lista[idx] = actualizado;

                    Aerolinea.GuardarLista(lista);
                    MessageBox.Show("Aerolínea editada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("Aerolínea no encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buteliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textID.Text.Trim().ToUpper();
                var lista = Aerolinea.Leer();
                var existente = lista.FirstOrDefault(x => x.Id == id);

                if (existente != null)
                {
                    lista.Remove(existente);
                    Aerolinea.GuardarLista(lista);
                    MessageBox.Show("Aerolínea eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("Aerolínea no encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void botBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textID.Text.Trim().ToUpper();
                var lista = Aerolinea.Leer();
                var a = lista.FirstOrDefault(x => x.Id == id);

                if (a != null)
                {
                    textID.Text = a.Id;
                    texnombre.Text = a.Nombre;
                    texpais.Text = a.Pais;
                    textelefono.Text = a.Telefono;
                    texemail.Text = a.Email;
                    texdireccion.Text = a.Direccion;
                    texsitioweb.Text = a.SitioWeb;
                    texcodigo.Text = a.CodigoIATA;

                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = new List<Aerolinea> { a };
                }
                else
                {
                    MessageBox.Show("Aerolínea no encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Butdata_Click(object sender, EventArgs e)
        {
            if (!expandido)
            {
                dgvDatos.Dock = DockStyle.Fill;
                dgvDatos.BringToFront();
                expandido = true;
                lbdata.Text = "Restaurar";
            }
            else
            {
                dgvDatos.Dock = DockStyle.None;
                dgvDatos.Size = new Size(600, 200);
                dgvDatos.Location = new Point(100, 300);
                expandido = false;
                lbdata.Text = "DataGridView";
            }
        }

        private void LimpiarCampos()
        {
            textID.Clear();
            texnombre.Clear();
            texpais.Clear();
            textelefono.Clear();
            texemail.Clear();
            texdireccion.Clear();
            texsitioweb.Clear();
            texcodigo.Clear();
            textID.Focus();
        }

        private void CargarGrid()
        {
            List<Aerolinea> lista = Aerolinea.Leer();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = lista;
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvDatos.Rows[e.RowIndex].DataBoundItem as Aerolinea;
                if (fila != null)
                {
                    textID.Text = fila.Id;
                    texnombre.Text = fila.Nombre;
                    texpais.Text = fila.Pais;
                    textelefono.Text = fila.Telefono;
                    texemail.Text = fila.Email;
                    texdireccion.Text = fila.Direccion;
                    texsitioweb.Text = fila.SitioWeb;
                    texcodigo.Text = fila.CodigoIATA;
                }
            }
        }

        private Aerolinea ConstruirDesdeFormulario()
        {
            return new Aerolinea
            {
                Id = (textID.Text ?? "").Trim().ToUpper(),
                Nombre = (texnombre.Text ?? "").Trim(),
                Pais = (texpais.Text ?? "").Trim(),
                Telefono = (textelefono.Text ?? "").Trim(),
                Email = (texemail.Text ?? "").Trim(),
                Direccion = (texdireccion.Text ?? "").Trim(),
                SitioWeb = (texsitioweb.Text ?? "").Trim(),
                CodigoIATA = (texcodigo.Text ?? "").Trim().ToUpper()
            };
        }
    }
}