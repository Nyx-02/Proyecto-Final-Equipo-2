using Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Drawing;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmSeguridad : Form
    {
        private bool expandido = false; 

        public FrmSeguridad()
        {
            InitializeComponent();
            CargarGrid();

            // Conectar eventos
            butGuardar.Click += butGuardar_Click;
            butEditar.Click += butEditar_Click;
            buteliminar.Click += buteliminar_Click;
            botBuscar.Click += botBuscar_Click;
            Butdata.Click += Butdata_Click;
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var seg = new Seguridad
                {
                    Id = textID.Text.Trim(),
                    IdEmpleado = texempleado.Text.Trim(),  
                    Puesto = texpuesto.Text.Trim(),
                    Turno = cbclase.SelectedItem?.ToString() ?? cbclase.Text.Trim(),
                    ZonaAsignada = texasiento.Text.Trim(),
                    FechaInicio = dateTimePicker1.Value,
                    NivelAcceso = cbniveleacceso.SelectedIndex + 1,
                    Estado = cbestado.SelectedItem?.ToString() ?? cbestado.Text.Trim(),
                    Identificacion = texasiento.Text.Trim()
                };

                Seguridad.Guardar(seg);
                MessageBox.Show("Registro de seguridad guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarGrid();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = Seguridad.Leer();
                var existente = lista.FirstOrDefault(x => x.Id == textID.Text.Trim());

                if (existente == null)
                {
                    MessageBox.Show("No se encontró un registro con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                existente.IdEmpleado = texempleado.Text.Trim();  
                existente.Puesto = texpuesto.Text.Trim();
                existente.Turno = cbclase.SelectedItem?.ToString() ?? cbclase.Text.Trim();
                existente.ZonaAsignada = texasiento.Text.Trim();
                existente.FechaInicio = dateTimePicker1.Value;
                existente.NivelAcceso = cbniveleacceso.SelectedIndex + 1;
                existente.Estado = cbestado.SelectedItem?.ToString() ?? cbestado.Text.Trim();
                existente.Identificacion = texasiento.Text.Trim();

                Seguridad.GuardarLista(lista);
                MessageBox.Show("Registro editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buteliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = Seguridad.Leer();
                var existente = lista.FirstOrDefault(x => x.Id == textID.Text.Trim());

                if (existente == null)
                {
                    MessageBox.Show("No se encontró un registro con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                lista.Remove(existente);
                Seguridad.GuardarLista(lista);

                MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = Seguridad.Leer();
                var seg = lista.FirstOrDefault(x => x.Id == textID.Text.Trim());

                if (seg != null)
                {
                    textID.Text = seg.Id;
                    texempleado.Text = seg.IdEmpleado;   
                    texpuesto.Text = seg.Puesto;
                    cbclase.SelectedItem = seg.Turno;
                    texasiento.Text = seg.ZonaAsignada;
                    dateTimePicker1.Value = seg.FechaInicio;
                    cbniveleacceso.SelectedIndex = seg.NivelAcceso - 1;
                    cbestado.SelectedItem = seg.Estado;

                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = new List<Seguridad> { seg };
                }
                else
                {
                    MessageBox.Show("No se encontró un registro con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = lista;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            texempleado.Clear();
            texpuesto.Clear();
            cbclase.SelectedIndex = -1;
            texasiento.Clear();
            dateTimePicker1.Value = DateTime.Today;
            cbniveleacceso.SelectedIndex = -1;
            cbestado.SelectedIndex = -1;
        }

        private void CargarGrid()
        {
            List<Seguridad> lista = Seguridad.Leer();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = lista;
        }
    }
}
