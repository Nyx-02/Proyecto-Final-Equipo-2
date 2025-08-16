using Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmPuertaEmbarque : Form
    {
        public FrmPuertaEmbarque()
        {
            InitializeComponent();
            butGuardar.Click += butGuardar_Click;
            butEditar.Click += butEditar_Click;
            buteliminar.Click += buteliminar_Click;
            botBuscar.Click += botBuscar_Click;
        }

        private PuertaEmbarque CrearPuertaDesdeFormulario()
        {
            return new PuertaEmbarque
            {
                Id = textID.Text.Trim(),
                Numero = texnumero.Text.Trim(),
                Terminal = cbterminal.SelectedItem?.ToString() ?? "",
                Estado = comboBox1.SelectedItem?.ToString() ?? "",
                Capacidad = (int)nupdCapacidad.Value,
                Ubicacion = texubicacion.Text.Trim(),
                HorarioApertura = DTPapertura.Value,
                HorarioCierre = DTPcierre.Value
            };
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                PuertaEmbarque obj = CrearPuertaDesdeFormulario();
                PuertaEmbarque.Guardar(obj);
                MessageBox.Show("Puerta de embarque guardada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void butEditar_Click(object sender, EventArgs e)
        {
            try
            {
                List<PuertaEmbarque> lista = PuertaEmbarque.Leer();
                PuertaEmbarque existente = lista.FirstOrDefault(x => x.Id == textID.Text.Trim());

                if (existente == null)
                {
                    MessageBox.Show("Puerta de embarque no encontrada.");
                    return;
                }

                PuertaEmbarque actualizado = CrearPuertaDesdeFormulario();
                int index = lista.IndexOf(existente);
                lista[index] = actualizado;

                PuertaEmbarque.GuardarLista(lista);
                MessageBox.Show("Puerta de embarque editada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }
        }

        private void buteliminar_Click(object sender, EventArgs e)
        {
            try
            {
                List<PuertaEmbarque> lista = PuertaEmbarque.Leer();
                PuertaEmbarque existente = lista.FirstOrDefault(x => x.Id == textID.Text.Trim());

                if (existente == null)
                {
                    MessageBox.Show("Puerta de embarque no encontrada.");
                    return;
                }

                lista.Remove(existente);
                PuertaEmbarque.GuardarLista(lista);
                MessageBox.Show("Puerta de embarque eliminada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void botBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<PuertaEmbarque> lista = PuertaEmbarque.Leer();
                PuertaEmbarque obj = lista.FirstOrDefault(x => x.Id == textID.Text.Trim());

                if (obj == null)
                {
                    MessageBox.Show("Puerta de embarque no encontrada.");
                    return;
                }

                texnumero.Text = obj.Numero;
                cbterminal.SelectedItem = obj.Terminal;
                comboBox1.SelectedItem = obj.Estado;
                nupdCapacidad.Value = obj.Capacidad;
                texubicacion.Text = obj.Ubicacion;
                DTPapertura.Value = obj.HorarioApertura;
                DTPcierre.Value = obj.HorarioCierre;

                MessageBox.Show("Puerta de embarque encontrada y cargada en el formulario.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }
    }
}