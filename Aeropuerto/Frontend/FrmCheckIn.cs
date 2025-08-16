using Backend;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmCheckIn : Form
    {
        private bool expandido = false;

        public FrmCheckIn()
        {
            InitializeComponent();

            cbfacturado.Items.AddRange(new string[] { "SI", "NO" });

            CargarGrid();

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
                var c = ConstruirDesdeFormulario();
                CheckIn.Guardar(c);
                MessageBox.Show("Check-in guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var lista = CheckIn.Leer();
                var existente = lista.FirstOrDefault(x => x.Id == id);

                if (existente != null)
                {
                    var actualizado = ConstruirDesdeFormulario();
                    actualizado.Id = id;
                    int idx = lista.FindIndex(x => x.Id == id);
                    lista[idx] = actualizado;

                    CheckIn.GuardarLista(lista);
                    MessageBox.Show("Check-in editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("Check-in no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var lista = CheckIn.Leer();
                var existente = lista.FirstOrDefault(x => x.Id == id);

                if (existente != null)
                {
                    lista.Remove(existente);
                    CheckIn.GuardarLista(lista);
                    MessageBox.Show("Check-in eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("Check-in no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var lista = CheckIn.Leer();
                var c = lista.FirstOrDefault(x => x.Id == id);

                if (c != null)
                {
                    textID.Text = c.Id;
                    texreserva.Text = c.IdReserva;
                    texempleado.Text = c.IdPasajero;
                    texmostrador.Text = c.IdVuelo;
                    cbfacturado.Text = c.Facturado;
                    cbestado.Text = c.Estado;
                    DTPfecha.Value = c.Fecha;

                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = new List<CheckIn> { c };
                }
                else
                {
                    MessageBox.Show("Check-in no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            texreserva.Clear();
            texempleado.Clear();
            texmostrador.Clear();
            cbfacturado.SelectedIndex = -1;
            cbestado.SelectedIndex = -1;
            DTPfecha.Value = DateTime.Today;
            textID.Focus();
        }

        private void CargarGrid()
        {
            List<CheckIn> lista = CheckIn.Leer();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = lista;
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvDatos.Rows[e.RowIndex].DataBoundItem as CheckIn;
                if (fila != null)
                {
                    textID.Text = fila.Id;
                    texreserva.Text = fila.IdReserva;
                    texempleado.Text = fila.IdPasajero;
                    texmostrador.Text = fila.IdVuelo;
                    cbfacturado.Text = fila.Facturado;
                    cbestado.Text = fila.Estado;
                    DTPfecha.Value = fila.Fecha;
                }
            }
        }

        private CheckIn ConstruirDesdeFormulario()
        {
            return new CheckIn
            {
                Id = (textID.Text ?? "").Trim().ToUpper(),
                IdReserva = (texreserva.Text ?? "").Trim().ToUpper(),
                IdPasajero = (texempleado.Text ?? "").Trim().ToUpper(),
                IdVuelo = (texmostrador.Text ?? "").Trim().ToUpper(),
                Facturado = (cbfacturado.Text ?? "").Trim().ToUpper(),
                Estado = (cbestado.Text ?? "").Trim(),
                Fecha = DTPfecha.Value.Date
            };
        }
    }
}