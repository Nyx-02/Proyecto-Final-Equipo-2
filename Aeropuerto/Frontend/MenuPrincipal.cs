using System;
using System.Windows.Forms;

namespace Frontend
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();

            butvuelos.Click += Butvuelos_Click;
            butpasajeros.Click += Butpasajeros_Click;
            butempleados.Click += Butempleados_Click;
            butaviones.Click += Butaviones_Click;
            butaerolineas.Click += Butaerolineas_Click;
            butreservas.Click += Butreservas_Click;
            butequipaje.Click += Butequipaje_Click;
            butpuertadeembarque.Click += Butpuertadeembarque_Click;
            butseguridad.Click += Butseguridad_Click;
            butmantenimiento.Click += Butmantenimiento_Click;
            butcheckin.Click += Butcheckin_Click;
            butitinerario.Click += Butitinerario_Click;
        }

        private void Butvuelos_Click(object sender, EventArgs e)
        {
            FrmVuelo frm = new FrmVuelo();
            frm.ShowDialog();
        }

        private void Butpasajeros_Click(object sender, EventArgs e)
        {
            FrmPasajero frm = new FrmPasajero();
            frm.ShowDialog();
        }

        private void Butempleados_Click(object sender, EventArgs e)
        {
            FrmEmpleado frm = new FrmEmpleado();
            frm.ShowDialog();
        }

        private void Butaviones_Click(object sender, EventArgs e)
        {
            FrmAvion frm = new FrmAvion();
            frm.ShowDialog();
        }

        private void Butaerolineas_Click(object sender, EventArgs e)
        {
            FrmAerolinea frm = new FrmAerolinea();
            frm.ShowDialog();
        }

        private void Butreservas_Click(object sender, EventArgs e)
        {
            FrmReserva frm = new FrmReserva();
            frm.ShowDialog();
        }

        private void Butequipaje_Click(object sender, EventArgs e)
        {
            FrmEquipaje frm = new FrmEquipaje();
            frm.ShowDialog();
        }

        private void Butpuertadeembarque_Click(object sender, EventArgs e)
        {
            FrmPuertaEmbarque frm = new FrmPuertaEmbarque();
            frm.ShowDialog();
        }

        private void Butseguridad_Click(object sender, EventArgs e)
        {
            FrmSeguridad frm = new FrmSeguridad();
            frm.ShowDialog();
        }

        private void Butmantenimiento_Click(object sender, EventArgs e)
        {
            FrmMantenimiento frm = new FrmMantenimiento();
            frm.ShowDialog();
        }

        private void Butcheckin_Click(object sender, EventArgs e)
        {
            FrmCheckIn frm = new FrmCheckIn();
            frm.ShowDialog();
        }

        private void Butitinerario_Click(object sender, EventArgs e)
        {
            FrmItinerario frm = new FrmItinerario();
            frm.ShowDialog();
        }
    }
}