using Backend;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmCheckIn : Form
    {
        public FrmCheckIn()
        {
            InitializeComponent();
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var checkin = new CheckIn
                {
                    Id = textID.Text,
                    IdReserva = texreserva.Text,
                    IdPasajero = texpasajero.Text,
                    IdVuelo = texvuelo.Text,
                    NumeroAsiento = texasiento.Text,
                    Estado = cbEstado.Text,
                    Fecha = dtpFecha.Value
                };

                CheckIn.Guardar(checkin);
                MessageBox.Show("Check-in guardado correctamente.");
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
                List<CheckIn> lista = CheckIn.Leer();
                var checkin = lista.Find(c => c.Id == textID.Text);

                if (checkin != null)
                {
                    checkin.IdReserva = texreserva.Text;
                    checkin.IdPasajero = texpasajero.Text;
                    checkin.IdVuelo = texvuelo.Text;
                    checkin.NumeroAsiento = texasiento.Text;
                    checkin.Estado = cbEstado.Text;
                    checkin.Fecha = dtpFecha.Value;

                    GuardarLista(lista);
                    MessageBox.Show("Check-in editado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró un check-in con ese ID.");
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
                List<CheckIn> lista = CheckIn.Leer();
                var checkin = lista.Find(c => c.Id == textID.Text);

                if (checkin != null)
                {
                    lista.Remove(checkin);
                    GuardarLista(lista);
                    MessageBox.Show("Check-in eliminado correctamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró un check-in con ese ID.");
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
                List<CheckIn> lista = CheckIn.Leer();
                var checkin = lista.Find(c => c.Id == textID.Text);

                if (checkin != null)
                {
                    texreserva.Text = checkin.IdReserva;
                    texpasajero.Text = checkin.IdPasajero;
                    texvuelo.Text = checkin.IdVuelo;
                    texasiento.Text = checkin.NumeroAsiento;
                    cbEstado.Text = checkin.Estado;
                    dtpFecha.Value = checkin.Fecha;
                }
                else
                {
                    MessageBox.Show("No se encontró un check-in con ese ID.");
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
            texreserva.Clear();
            texpasajero.Clear();
            texvuelo.Clear();
            texasiento.Clear();
            cbEstado.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Today;
        }

        private void GuardarLista(List<CheckIn> lista)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(lista, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText("checkins.json", json);
        }
    }
}