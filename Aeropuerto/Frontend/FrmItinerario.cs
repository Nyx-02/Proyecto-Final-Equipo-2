using Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmItinerario : Form
    {
        public FrmItinerario()
        {
            InitializeComponent();

            // Asignar eventos
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
                var itinerario = new Itinerario
                {
                    Id = textID.Text.Trim(),
                    IdVuelo = texvuelo.Text.Trim(),
                    Actividades = texactividades.Text.Trim(),
                    FechaInicio = DTPfechadeinicio.Value,
                    FechaFin = DTPfechadefin.Value,
                    Escalas = texescalas.Text.Trim(),
                    Observaciones = texobservaciones.Text.Trim(),
                    Estado = cbestado.SelectedItem?.ToString() ?? cbestado.Text.Trim()
                };

                Itinerario.Guardar(itinerario);
                MessageBox.Show("Itinerario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var lista = Itinerario.Leer();
                var existente = lista.FirstOrDefault(i => i.Id == textID.Text.Trim());

                if (existente == null)
                {
                    MessageBox.Show("No se encontró un itinerario con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var actualizado = new Itinerario
                {
                    Id = existente.Id,
                    IdVuelo = texvuelo.Text.Trim(),
                    Actividades = texactividades.Text.Trim(),
                    FechaInicio = DTPfechadeinicio.Value,
                    FechaFin = DTPfechadefin.Value,
                    Escalas = texescalas.Text.Trim(),
                    Observaciones = texobservaciones.Text.Trim(),
                    Estado = cbestado.SelectedItem?.ToString() ?? cbestado.Text.Trim()
                };

                int idx = lista.IndexOf(existente);
                lista[idx] = actualizado;
                GuardarLista(lista);

                MessageBox.Show("Itinerario editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var lista = Itinerario.Leer();
                var existente = lista.FirstOrDefault(i => i.Id == textID.Text.Trim());

                if (existente == null)
                {
                    MessageBox.Show("No se encontró un itinerario con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var confirm = MessageBox.Show($"¿Desea eliminar el itinerario {existente.MostrarInfo()}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    lista.RemoveAll(x => x.Id == existente.Id);
                    GuardarLista(lista);
                    MessageBox.Show("Itinerario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var lista = Itinerario.Leer();
                var i = lista.FirstOrDefault(x => x.Id == textID.Text.Trim());

                if (i == null)
                {
                    MessageBox.Show("No se encontró un itinerario con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                textID.Text = i.Id;
                texvuelo.Text = i.IdVuelo;
                texactividades.Text = i.Actividades;
                DTPfechadeinicio.Value = i.FechaInicio;
                DTPfechadefin.Value = i.FechaFin;
                texescalas.Text = i.Escalas;
                texobservaciones.Text = i.Observaciones;
                cbestado.SelectedItem = i.Estado;

                MessageBox.Show("Itinerario cargado en el formulario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Butdata_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = Itinerario.Leer();

                Form ventanaDatos = new Form
                {
                    Text = "Lista de Itinerarios",
                    Width = 1000,
                    Height = 600
                };

                DataGridView dgv = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    ReadOnly = true,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    DataSource = lista
                };

                ventanaDatos.Controls.Add(dgv);
                ventanaDatos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            textID.Clear();
            texvuelo.Clear();
            texactividades.Clear();
            texescalas.Clear();
            texobservaciones.Clear();
            cbestado.SelectedIndex = -1;
            DTPfechadeinicio.Value = DateTime.Today;
            DTPfechadefin.Value = DateTime.Today;
            textID.Focus();
        }

        private void GuardarLista(List<Itinerario> lista)
        {
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText("itinerarios.json", json);
        }
    }
}