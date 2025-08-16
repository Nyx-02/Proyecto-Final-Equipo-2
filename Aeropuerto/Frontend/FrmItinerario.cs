using Backend;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmItinerario : Form
    {
        public FrmItinerario()
        {
            InitializeComponent();
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var itinerario = new Itinerario
                {
                    Id = textID.Text,
                    Origen = texvuelo.Text,          // Ajusta: aquí debería ir un TextBox de Origen
                    Destino = texempleado.Text,      // Ajusta: aquí debería ir un TextBox de Destino
                    FechaSalida = DTPfechadeinicio.Value,
                    FechaLlegada = dateTimePicker1.Value,
                    Aerolinea = texescalas.Text,     // Ajusta: aquí debería ir un TextBox de Aerolínea
                    NumeroVuelo = texobservaciones.Text, // Ajusta: aquí debería ir un TextBox de NroVuelo
                    Estado = cbestado.Text
                };

                Itinerario.Guardar(itinerario);
                MessageBox.Show("Itinerario guardado correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}");
            }
        }

        private void butEditar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Itinerario> lista = Itinerario.Leer();
                var itinerario = lista.Find(i => i.Id == textID.Text);

                if (itinerario != null)
                {
                    itinerario.Origen = texvuelo.Text;
                    itinerario.Destino = texempleado.Text;
                    itinerario.FechaSalida = DTPfechadeinicio.Value;
                    itinerario.FechaLlegada = dateTimePicker1.Value;
                    itinerario.Aerolinea = texescalas.Text;
                    itinerario.NumeroVuelo = texobservaciones.Text;
                    itinerario.Estado = cbestado.Text;

                    GuardarLista(lista);
                    MessageBox.Show("Itinerario editado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró un itinerario con ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar: {ex.Message}");
            }
        }

        private void buteliminar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Itinerario> lista = Itinerario.Leer();
                var itinerario = lista.Find(i => i.Id == textID.Text);

                if (itinerario != null)
                {
                    lista.Remove(itinerario);
                    GuardarLista(lista);
                    MessageBox.Show("Itinerario eliminado correctamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró un itinerario con ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}");
            }
        }

        private void botBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Itinerario> lista = Itinerario.Leer();
                var itinerario = lista.Find(i => i.Id == textID.Text);

                if (itinerario != null)
                {
                    texvuelo.Text = itinerario.Origen;
                    texempleado.Text = itinerario.Destino;
                    DTPfechadeinicio.Value = itinerario.FechaSalida;
                    dateTimePicker1.Value = itinerario.FechaLlegada;
                    texescalas.Text = itinerario.Aerolinea;
                    texobservaciones.Text = itinerario.NumeroVuelo;
                    cbestado.Text = itinerario.Estado;
                }
                else
                {
                    MessageBox.Show("No se encontró un itinerario con ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            textID.Clear();
            texvuelo.Clear();
            texempleado.Clear();
            texescalas.Clear();
            texobservaciones.Clear();
            cbestado.SelectedIndex = -1;
            DTPfechadeinicio.Value = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today;
        }

        private void GuardarLista(List<Itinerario> lista)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(lista, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText("itinerarios.json", json);
        }
    }
}