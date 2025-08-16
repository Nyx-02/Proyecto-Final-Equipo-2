using System;
using System.Linq;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmPasajero : Form
    {
        private bool expandido = false; 

        public FrmPasajero()
        {
            InitializeComponent();

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
                var p = ConstruirDesdeFormulario();
                Backend.Pasajero.Guardar(p);
                MessageBox.Show("Pasajero guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textID.Text.Trim().ToUpper();
                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("Ingrese el ID para editar.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var lista = Backend.Pasajero.Leer();
                int idx = lista.FindIndex(x => x.Id == id);
                if (idx < 0)
                {
                    MessageBox.Show("No se encontró un pasajero con ese ID.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var actualizado = ConstruirDesdeFormulario();
                actualizado.Id = id; 

                lista[idx] = actualizado;
                Backend.Pasajero.GuardarLista(lista);

                MessageBox.Show("Pasajero editado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buteliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textID.Text.Trim().ToUpper();
                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("Ingrese el ID para eliminar.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var lista = Backend.Pasajero.Leer();
                var existente = lista.FirstOrDefault(x => x.Id == id);
                if (existente == null)
                {
                    MessageBox.Show("No se encontró un pasajero con ese ID.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var confirm = MessageBox.Show(
                    $"¿Seguro que desea eliminar al pasajero {existente.MostrarInfo()}?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    lista.RemoveAll(x => x.Id == id);
                    Backend.Pasajero.GuardarLista(lista);
                    MessageBox.Show("Pasajero eliminado.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textID.Text.Trim().ToUpper();
                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("Ingrese el ID para buscar.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var lista = Backend.Pasajero.Leer();
                var p = lista.FirstOrDefault(x => x.Id == id);
                if (p == null)
                {
                    MessageBox.Show("No se encontró un pasajero con ese ID.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                textID.Text = p.Id;
                texnombre.Text = p.Nombre;
                texapellido.Text = p.Apellido;
                texnacionalidad.Text = p.Nacionalidad;
                texpasaporte.Text = p.Pasaporte;
                textelefono.Text = p.Telefono;
                texemail.Text = p.Email;
                DTPnacimiento.Value = p.FechaNacimiento;

                MessageBox.Show("Pasajero cargado.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Butdata_Click(object sender, EventArgs e)
        {
            try
            {
                if (!expandido)
                {

                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = Backend.Pasajero.Leer();
                    dgvDatos.Dock = DockStyle.Fill;
                    dgvDatos.BringToFront();
                    expandido = true;
                }
                else
                {
                    dgvDatos.Dock = DockStyle.None;
                    dgvDatos.Visible = false;
                    expandido = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Backend.Pasajero ConstruirDesdeFormulario()
        {
            var id = (textID.Text ?? "").Trim().ToUpper();

            return new Backend.Pasajero
            {
                Id = id,
                Nombre = (texnombre.Text ?? "").Trim(),
                Apellido = (texapellido.Text ?? "").Trim(),
                Nacionalidad = (texnacionalidad.Text ?? "").Trim(),
                Pasaporte = (texpasaporte.Text ?? "").Trim().ToUpper(),
                Telefono = (textelefono.Text ?? "").Trim(),
                Email = (texemail.Text ?? "").Trim(),
                FechaNacimiento = DTPnacimiento.Value.Date
            };
        }

        private void LimpiarCampos()
        {
            textID.Clear();
            texnombre.Clear();
            texapellido.Clear();
            texnacionalidad.Clear();
            texpasaporte.Clear();
            textelefono.Clear();
            texemail.Clear();
            DTPnacimiento.Value = DateTime.Today;
            textID.Focus();
        }

        private void TxbxTitulo_TextChanged(object sender, EventArgs e) { }
        private void FrmVuelo_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void lbDestino_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void button1_Click_1(object sender, EventArgs e) { }
        private void button3_Click(object sender, EventArgs e) { }
    }
}
