using Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmSeguridad : Form
    {
        public FrmSeguridad()
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
                var seg = new Seguridad
                {
                    Id = textID.Text.Trim(),
                    NombreGuardia = texempleado.Text.Trim(),
                    Puesto = texpuesto.Text.Trim(),
                    Turno = cbclase.SelectedItem?.ToString() ?? cbclase.Text.Trim(),
                    ZonaAsignada = texasiento.Text.Trim(),
                    FechaInicio = dateTimePicker1.Value,
                    NivelAcceso = cbniveleacceso.SelectedIndex + 1, // Asignamos nivel según selección
                    Estado = cbestado.SelectedItem?.ToString() ?? cbestado.Text.Trim(),
                    Identificacion = texasiento.Text.Trim()
                };

                Seguridad.Guardar(seg);
                MessageBox.Show("Registro de seguridad guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var lista = Seguridad.Leer();
                var existente = lista.FirstOrDefault(x => x.Id == textID.Text.Trim());

                if (existente == null)
                {
                    MessageBox.Show("No se encontró un registro con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var actualizado = new Seguridad
                {
                    Id = existente.Id,
                    NombreGuardia = texempleado.Text.Trim(),
                    Puesto = texpuesto.Text.Trim(),
                    Turno = cbclase.SelectedItem?.ToString() ?? cbclase.Text.Trim(),
                    ZonaAsignada = texasiento.Text.Trim(),
                    FechaInicio = dateTimePicker1.Value,
                    NivelAcceso = cbniveleacceso.SelectedIndex + 1,
                    Estado = cbestado.SelectedItem?.ToString() ?? cbestado.Text.Trim(),
                    Identificacion = texasiento.Text.Trim()
                };

                int idx = lista.IndexOf(existente);
                lista[idx] = actualizado;
                GuardarLista(lista);

                MessageBox.Show("Registro de seguridad editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var lista = Seguridad.Leer();
                var existente = lista.FirstOrDefault(x => x.Id == textID.Text.Trim());

                if (existente == null)
                {
                    MessageBox.Show("No se encontró un registro con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var confirm = MessageBox.Show($"¿Desea eliminar el registro {existente.MostrarInfo()}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    lista.RemoveAll(x => x.Id == existente.Id);
                    GuardarLista(lista);
                    MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var lista = Seguridad.Leer();
                var seg = lista.FirstOrDefault(x => x.Id == textID.Text.Trim());

                if (seg == null)
                {
                    MessageBox.Show("No se encontró un registro con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                textID.Text = seg.Id;
                texempleado.Text = seg.NombreGuardia;
                texpuesto.Text = seg.Puesto;
                cbclase.SelectedItem = seg.Turno;
                texasiento.Text = seg.ZonaAsignada;
                dateTimePicker1.Value = seg.FechaInicio;
                cbniveleacceso.SelectedIndex = seg.NivelAcceso - 1;
                cbestado.SelectedItem = seg.Estado;

                MessageBox.Show("Registro cargado en el formulario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            textID.Focus();
        }

        private void GuardarLista(List<Seguridad> lista)
        {
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText("seguridad.json", json);
        }
    }
}