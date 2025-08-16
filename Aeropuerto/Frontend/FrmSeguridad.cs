using Backend;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
                    IdEmpleado = texidempleado.Text.Trim(),
                    Puesto = texpuesto.Text.Trim(),
                    Turno = cbturno.SelectedItem?.ToString() ?? cbturno.Text.Trim(),
                    FechaIngreso = dtpfecha.Value,
                    Observaciones = texobservaciones.Text.Trim(),
                    NivelAcceso = cbniveleacceso.SelectedIndex + 1,
                    Estado = cbestado.SelectedItem?.ToString() ?? cbestado.Text.Trim()
                };

                Seguridad.Guardar(seg);
                MessageBox.Show("Registro de seguridad guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarGrid();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("No se encontró un registro con ese ID.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                existente.IdEmpleado = texidempleado.Text.Trim();
                existente.Puesto = texpuesto.Text.Trim();
                existente.Turno = cbturno.SelectedItem?.ToString() ?? cbturno.Text.Trim();
                existente.FechaIngreso = dtpfecha.Value;
                existente.Observaciones = texobservaciones.Text.Trim();
                existente.NivelAcceso = cbniveleacceso.SelectedIndex + 1;
                existente.Estado = cbestado.SelectedItem?.ToString() ?? cbestado.Text.Trim();

                Seguridad.GuardarLista(lista);
                MessageBox.Show("Registro editado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("No se encontró un registro con ese ID.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                lista.Remove(existente);
                Seguridad.GuardarLista(lista);

                MessageBox.Show("Registro eliminado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    texidempleado.Text = seg.IdEmpleado;
                    texpuesto.Text = seg.Puesto;
                    cbturno.SelectedItem = seg.Turno;
                    dtpfecha.Value = seg.FechaIngreso;
                    texobservaciones.Text = seg.Observaciones;
                    cbniveleacceso.SelectedIndex = seg.NivelAcceso - 1;
                    cbestado.SelectedItem = seg.Estado;

                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = new List<Seguridad> { seg };
                }
                else
                {
                    MessageBox.Show("No se encontró un registro con ese ID.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = lista;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            texidempleado.Clear();
            texpuesto.Clear();
            cbturno.SelectedIndex = -1;
            dtpfecha.Value = DateTime.Today;
            texobservaciones.Clear();
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
