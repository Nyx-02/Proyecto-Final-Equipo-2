using Backend;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmReserva : Form
    {
        public FrmReserva()
        {
            InitializeComponent();
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var reserva = new Reserva
                {
                    Id = textID.Text,
                    IdPasajero = texpasajero.Text,
                    IdVuelo = texvuelo.Text,
                    FechaReserva = dateTimePicker1.Value,
                    Asiento = texasiento.Text,
                    Clase = cbclase.Text,
                    Precio = nupdprecio.Value,
                    EstadoPago = cbpago.Text
                };

                Reserva.Guardar(reserva);
                MessageBox.Show("Reserva guardada correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void butEditar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Reserva> lista = Reserva.Leer();
                var reserva = lista.Find(r => r.Id == textID.Text);

                if (reserva != null)
                {
                    reserva.IdPasajero = texpasajero.Text;
                    reserva.IdVuelo = texvuelo.Text;
                    reserva.FechaReserva = dateTimePicker1.Value;
                    reserva.Asiento = texasiento.Text;
                    reserva.Clase = cbclase.Text;
                    reserva.Precio = nupdprecio.Value;
                    reserva.EstadoPago = cbpago.Text;

                    GuardarLista(lista);
                    MessageBox.Show("Reserva editada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró una reserva con ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buteliminar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Reserva> lista = Reserva.Leer();
                var reserva = lista.Find(r => r.Id == textID.Text);

                if (reserva != null)
                {
                    lista.Remove(reserva);
                    GuardarLista(lista);
                    MessageBox.Show("Reserva eliminada correctamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró una reserva con ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void botBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Reserva> lista = Reserva.Leer();
                var reserva = lista.Find(r => r.Id == textID.Text);

                if (reserva != null)
                {
                    texpasajero.Text = reserva.IdPasajero;
                    texvuelo.Text = reserva.IdVuelo;
                    dateTimePicker1.Value = reserva.FechaReserva;
                    texasiento.Text = reserva.Asiento;
                    cbclase.Text = reserva.Clase;
                    nupdprecio.Value = reserva.Precio;
                    cbpago.Text = reserva.EstadoPago;
                }
                else
                {
                    MessageBox.Show("No se encontró una reserva con ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            textID.Clear();
            texpasajero.Clear();
            texvuelo.Clear();
            texasiento.Clear();
            cbclase.SelectedIndex = -1;
            nupdprecio.Value = 0;
            cbpago.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today;
        }

        private void GuardarLista(List<Reserva> lista)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(lista, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText("reservas.json", json);
        }
    }
}