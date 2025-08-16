using Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Frontend
{
    public partial class FrmVuelo : Form
    {
        private bool expandido = false; 

        public FrmVuelo()
        {
            InitializeComponent();
            CargarGrid();

            Butdata.Click += Butdata_Click;
            butGuardar.Click += butGuardar_Click;
            butEditar.Click += butEditar_Click;
            buteliminar.Click += buteliminar_Click;
            botBuscar.Click += botBuscar_Click;
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var vuelo = new Backend.Vuelo
                {
                    Id = textID.Text.Trim(),
                    Destino = texDestino.Text.Trim(),
                    Origen = textBox3.Text.Trim(),
                    Aerolinea = textBox4.Text.Trim(),
                    Estado = comboBox1.SelectedItem?.ToString() ?? "",
                    Fecha = DTPFecha.Value.Date,
                    HoraSalida = dateTimePicker3.Value,
                    HoraLlegada = DTPhoradelle.Value
                };

                Backend.Vuelo.Guardar(vuelo);
                MessageBox.Show("Vuelo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void butEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = Backend.Vuelo.Leer();
                var vuelo = lista.FirstOrDefault(v => v.Id == textID.Text.Trim());

                if (vuelo != null)
                {
                    vuelo.Destino = texDestino.Text.Trim();
                    vuelo.Origen = textBox3.Text.Trim();
                    vuelo.Aerolinea = textBox4.Text.Trim();
                    vuelo.Estado = comboBox1.SelectedItem?.ToString() ?? "";
                    vuelo.Fecha = DTPFecha.Value.Date;
                    vuelo.HoraSalida = dateTimePicker3.Value;
                    vuelo.HoraLlegada = DTPhoradelle.Value;

                    Backend.Vuelo.GuardarLista(lista);
                    MessageBox.Show("Vuelo editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("Vuelo no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buteliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = Backend.Vuelo.Leer();
                var vuelo = lista.FirstOrDefault(v => v.Id == textID.Text.Trim());

                if (vuelo != null)
                {
                    lista.Remove(vuelo);
                    Backend.Vuelo.GuardarLista(lista);
                    MessageBox.Show("Vuelo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("Vuelo no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void botBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = Backend.Vuelo.Leer();
                var vuelo = lista.FirstOrDefault(v => v.Id == textID.Text.Trim());

                if (vuelo != null)
                {
                    texDestino.Text = vuelo.Destino;
                    textBox3.Text = vuelo.Origen;
                    textBox4.Text = vuelo.Aerolinea;
                    comboBox1.SelectedItem = vuelo.Estado;
                    DTPFecha.Value = vuelo.Fecha;
                    dateTimePicker3.Value = vuelo.HoraSalida;
                    DTPhoradelle.Value = vuelo.HoraLlegada;

                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = new List<Backend.Vuelo> { vuelo };
                }
                else
                {
                    MessageBox.Show("Vuelo no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = lista;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            texDestino.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
            DTPFecha.Value = DateTime.Today;
            dateTimePicker3.Value = DateTime.Now;
            DTPhoradelle.Value = DateTime.Now;
        }

        private void CargarGrid()
        {
            List<Vuelo> lista = Vuelo.Leer();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = lista;
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}