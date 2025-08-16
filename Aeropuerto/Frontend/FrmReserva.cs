using Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmReserva : Form
    {
        private bool expandido = false;

        public FrmReserva()
        {
            InitializeComponent();

            butGuardar.Click += butGuardar_Click;
            butEditar.Click += butEditar_Click;
            buteliminar.Click += buteliminar_Click;
            botBuscar.Click += botBuscar_Click;
            Butdata.Click += Butdata_Click;

            dgvDatos.AutoGenerateColumns = true;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.MultiSelect = false;
            dgvDatos.ReadOnly = true;
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvDatos.CellClick += dgvDatos_CellClick;
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
                    FechaReserva = DTPReserva.Value,
                    Asiento = texasiento.Text,
                    Clase = cbclase.Text,
                    Precio = nupdprecio.Value,
                    EstadoPago = cbpago.Text
                };

                Reserva.Guardar(reserva);
                MessageBox.Show("Reserva guardada correctamente.");
                LimpiarCampos();
                CargarGrid();
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
                var reserva = lista.FirstOrDefault(r => r.Id == textID.Text);

                if (reserva != null)
                {
                    reserva.IdPasajero = texpasajero.Text;
                    reserva.IdVuelo = texvuelo.Text;
                    reserva.FechaReserva = DTPReserva.Value;
                    reserva.Asiento = texasiento.Text;
                    reserva.Clase = cbclase.Text;
                    reserva.Precio = nupdprecio.Value;
                    reserva.EstadoPago = cbpago.Text;

                    GuardarLista(lista);
                    MessageBox.Show("Reserva editada correctamente.");
                    LimpiarCampos();
                    CargarGrid();
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
                var reserva = lista.FirstOrDefault(r => r.Id == textID.Text);

                if (reserva != null)
                {
                    lista.Remove(reserva);
                    GuardarLista(lista);
                    MessageBox.Show("Reserva eliminada correctamente.");
                    LimpiarCampos();
                    CargarGrid();
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
                var reserva = lista.FirstOrDefault(r => r.Id == textID.Text);

                if (reserva != null)
                {
                    texpasajero.Text = reserva.IdPasajero;
                    texvuelo.Text = reserva.IdVuelo;
                    DTPReserva.Value = reserva.FechaReserva;
                    texasiento.Text = reserva.Asiento;
                    cbclase.Text = reserva.Clase;

                    decimal precio = reserva.Precio;
                    if (precio < nupdprecio.Minimum) precio = nupdprecio.Minimum;
                    if (precio > nupdprecio.Maximum) precio = nupdprecio.Maximum;
                    nupdprecio.Value = precio;

                    cbpago.Text = reserva.EstadoPago;

                    dgvDatos.DataSource = new List<Reserva> { reserva };
                }
                else
                {
                    MessageBox.Show("No se encontró una reserva con ese ID.");
                    dgvDatos.DataSource = lista;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var item = dgvDatos.Rows[e.RowIndex].DataBoundItem as Reserva;
            if (item == null) return;

            textID.Text = item.Id;
            texpasajero.Text = item.IdPasajero;
            texvuelo.Text = item.IdVuelo;
            DTPReserva.Value = item.FechaReserva;
            texasiento.Text = item.Asiento;
            cbclase.Text = item.Clase;

            decimal precio = item.Precio;
            if (precio < nupdprecio.Minimum) precio = nupdprecio.Minimum;
            if (precio > nupdprecio.Maximum) precio = nupdprecio.Maximum;
            nupdprecio.Value = precio;

            cbpago.Text = item.EstadoPago;
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

            CargarGrid();
        }

        private void CargarGrid()
        {
            var lista = Reserva.Leer() ?? new List<Reserva>();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = lista;
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
            DTPReserva.Value = DateTime.Today;
        }

        private void GuardarLista(List<Reserva> lista)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(lista, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText("reservas.json", json);
        }
    }
}