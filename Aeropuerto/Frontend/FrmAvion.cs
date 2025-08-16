using System;
using System.Linq;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmAvion : Form
    {
        private bool expandido = false;

        public FrmAvion()
        {
            InitializeComponent();
            butGuardar.Click += butGuardar_Click;
            butEditar.Click += butEditar_Click;
            buteliminar.Click += buteliminar_Click;
            botBuscar.Click += botBuscar_Click;
            Butdata.Click += Butdata_Click;
            CargarGrid();
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var av = ConstruirDesdeFormulario();
                Backend.Avion.Guardar(av);
                MessageBox.Show("Avión guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string id = textID.Text.Trim().ToUpper();
                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("Ingrese el ID para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var lista = Backend.Avion.Leer();
                int idx = lista.FindIndex(x => x.Id == id);
                if (idx < 0)
                {
                    MessageBox.Show("No se encontró un avión con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var actualizado = ConstruirDesdeFormulario();
                actualizado.Id = id;
                lista[idx] = actualizado;
                Backend.Avion.GuardarLista(lista);

                MessageBox.Show("Avión editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarGrid();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string id = textID.Text.Trim().ToUpper();
                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("Ingrese el ID para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var lista = Backend.Avion.Leer();
                var existente = lista.FirstOrDefault(x => x.Id == id);
                if (existente == null)
                {
                    MessageBox.Show("No se encontró un avión con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var confirm = MessageBox.Show($"¿Seguro que desea eliminar el avión {existente.MostrarInfo()}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    lista.RemoveAll(x => x.Id == id);
                    Backend.Avion.GuardarLista(lista);
                    MessageBox.Show("Avión eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarGrid();
                }
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
                string id = textID.Text.Trim().ToUpper();
                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("Ingrese el ID para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var lista = Backend.Avion.Leer();
                var av = lista.FirstOrDefault(x => x.Id == id);
                if (av == null)
                {
                    MessageBox.Show("No se encontró un avión con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                textID.Text = av.Id;
                texmodelo.Text = av.Modelo;
                nupdCapacidad.Value = av.Capacidad;
                texfabricante.Text = av.Fabricante;
                dtpfabricacion.Value = new DateTime(av.AnioFabricacion, 1, 1); // solo el año
                cbEstado.Text = av.Estado;
                texmatricula.Text = av.Matricula;
                cbmotor.Text = av.Motor;

                dgvDatos.DataSource = null;
                dgvDatos.DataSource = new[] { av };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Backend.Avion ConstruirDesdeFormulario()
        {
            var id = (textID.Text ?? "").Trim().ToUpper();
            var av = new Backend.Avion
            {
                Id = id,
                Modelo = (texmodelo.Text ?? "").Trim(),
                Capacidad = (int)nupdCapacidad.Value,
                Fabricante = (texfabricante.Text ?? "").Trim(),
                AnioFabricacion = dtpfabricacion.Value.Year,
                Estado = cbEstado.Text.Trim(),
                Matricula = (texmatricula.Text ?? "").Trim().ToUpper(),
                Motor = (cbmotor.Text ?? "").Trim()
            };
            return av;
        }

        private void LimpiarCampos()
        {
            textID.Clear();
            texmodelo.Clear();
            nupdCapacidad.Value = 0;
            texfabricante.Clear();
            dtpfabricacion.Value = DateTime.Now;
            cbEstado.SelectedIndex = -1;
            texmatricula.Clear();
            cbmotor.SelectedIndex = -1;
            textID.Focus();
        }

        private void CargarGrid()
        {
            var lista = Backend.Avion.Leer();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = lista;
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
                dgvDatos.Size = new System.Drawing.Size(600, 200);
                dgvDatos.Location = new System.Drawing.Point(100, 300);
                expandido = false;
                lbdata.Text = "DataGridView";
            }
        }
    }
}