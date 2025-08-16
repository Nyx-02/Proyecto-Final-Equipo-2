using System;
using System.Linq;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmAvion : Form
    {
        public FrmAvion()
        {
            InitializeComponent();
            butGuardar.Click += butGuardar_Click;
            butEditar.Click += butEditar_Click;
            buteliminar.Click += buteliminar_Click;
            botBuscar.Click += botBuscar_Click;
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var av = ConstruirDesdeFormulario();
                Backend.Avion.Guardar(av);
                MessageBox.Show("Avión guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
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
                nupdfabricacion.Value = av.AnioFabricacion;
                cbEstado.Text = av.Estado;
                tematricula.Text = av.Matricula;
                cbmotor.Text = av.Motor;

                MessageBox.Show("Avión cargado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                AnioFabricacion = (int)nupdfabricacion.Value,
                Estado = cbEstado.Text.Trim(),
                Matricula = (tematricula.Text ?? "").Trim().ToUpper(),
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
            nupdfabricacion.Value = DateTime.Now.Year;
            cbEstado.SelectedIndex = -1;
            tematricula.Clear();
            cbmotor.SelectedIndex = -1;
            textID.Focus();
        }
    }
}
