using Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmMantenimiento : Form
    {
        public FrmMantenimiento()
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
                var m = new Mantenimiento
                {
                    Id = textID.Text.Trim(),
                    Tipo = cbmantenimiento.SelectedItem?.ToString() ?? cbmantenimiento.Text.Trim(),
                    Descripcion = texdescripcion.Text.Trim(),
                    Fecha = DTPfecha.Value,
                    Estado = cbestado.SelectedItem?.ToString() ?? cbestado.Text.Trim(),
                    Costo = nupdcosto.Value,
                    Responsable = textBox1.Text.Trim(),
                    Ubicacion = texavion.Text.Trim()
                };

                Mantenimiento.Guardar(m);
                MessageBox.Show("Mantenimiento guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var lista = Mantenimiento.Leer();
                var existente = lista.FirstOrDefault(x => x.Id == textID.Text.Trim());

                if (existente == null)
                {
                    MessageBox.Show("No se encontró un mantenimiento con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var actualizado = new Mantenimiento
                {
                    Id = existente.Id,
                    Tipo = cbmantenimiento.SelectedItem?.ToString() ?? cbmantenimiento.Text.Trim(),
                    Descripcion = texdescripcion.Text.Trim(),
                    Fecha = DTPfecha.Value,
                    Estado = cbestado.SelectedItem?.ToString() ?? cbestado.Text.Trim(),
                    Costo = nupdcosto.Value,
                    Responsable = textBox1.Text.Trim(),
                    Ubicacion = texavion.Text.Trim()
                };

                int idx = lista.IndexOf(existente);
                lista[idx] = actualizado;
                GuardarLista(lista);

                MessageBox.Show("Mantenimiento editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var lista = Mantenimiento.Leer();
                var existente = lista.FirstOrDefault(x => x.Id == textID.Text.Trim());

                if (existente == null)
                {
                    MessageBox.Show("No se encontró un mantenimiento con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var confirm = MessageBox.Show($"¿Desea eliminar el mantenimiento {existente.MostrarInfo()}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    lista.RemoveAll(x => x.Id == existente.Id);
                    GuardarLista(lista);
                    MessageBox.Show("Mantenimiento eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var lista = Mantenimiento.Leer();
                var m = lista.FirstOrDefault(x => x.Id == textID.Text.Trim());

                if (m == null)
                {
                    MessageBox.Show("No se encontró un mantenimiento con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                textID.Text = m.Id;
                cbmantenimiento.SelectedItem = m.Tipo;
                texdescripcion.Text = m.Descripcion;
                DTPfecha.Value = m.Fecha;
                cbestado.SelectedItem = m.Estado;
                nupdcosto.Value = m.Costo;
                textBox1.Text = m.Responsable;
                texavion.Text = m.Ubicacion;

                MessageBox.Show("Mantenimiento cargado en el formulario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            textID.Clear();
            cbmantenimiento.SelectedIndex = -1;
            texdescripcion.Clear();
            DTPfecha.Value = DateTime.Today;
            cbestado.SelectedIndex = -1;
            nupdcosto.Value = 0;
            textBox1.Clear();
            texavion.Clear();
            textID.Focus();
        }

        private void GuardarLista(List<Mantenimiento> lista)
        {
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText("mantenimientos.json", json);
        }
    }
}