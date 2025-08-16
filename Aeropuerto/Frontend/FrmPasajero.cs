using System;
using System.Linq;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmPasajero : Form
    {
        public FrmPasajero()
        {
            InitializeComponent();

            butGuardar.Click += butGuardar_Click;
            butEditar.Click += butEditar_Click;
            buteliminar.Click += buteliminar_Click;
            botBuscar.Click += botBuscar_Click;
        }

        // ====== BOTONES ======

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
                // Mantener el mismo ID normalizado
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

                // Llenar controles
                textID.Text = p.Id;
                texDestino.Text = p.Nombre;       
                textBox4.Text = p.Apellido;
                textBox3.Text = p.Nacionalidad;
                texpasaporte.Text = p.Pasaporte;
                textelefono.Text = p.Telefono;
                textBox2.Text = p.Email;
                DTPhoradelle.Value = p.FechaNacimiento;

                MessageBox.Show("Pasajero cargado.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ====== HELPERS ======

        private Backend.Pasajero ConstruirDesdeFormulario()
        {
            // Normalizamos el ID a mayúsculas porque el backend lo exige
            var id = (textID.Text ?? "").Trim().ToUpper();

            var pasajero = new Backend.Pasajero
            {
                Id = id,
                Nombre = (texDestino.Text ?? "").Trim(),       
                Apellido = (textBox4.Text ?? "").Trim(),
                Nacionalidad = (textBox3.Text ?? "").Trim(),
                Pasaporte = (texpasaporte.Text ?? "").Trim().ToUpper(),
                Telefono = (textelefono.Text ?? "").Trim(),
                Email = (textBox2.Text ?? "").Trim(),
                FechaNacimiento = DTPhoradelle.Value.Date
            };

            return pasajero;
        }

        private void LimpiarCampos()
        {
            textID.Clear();
            texDestino.Clear();
            textBox4.Clear();
            textBox3.Clear();
            texpasaporte.Clear();
            textelefono.Clear();
            textBox2.Clear();
            DTPhoradelle.Value = DateTime.Today;
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