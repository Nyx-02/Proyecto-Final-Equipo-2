namespace Frontend
{
    partial class FrmReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReserva));
            butGuardar = new Button();
            butEditar = new Button();
            buteliminar = new Button();
            botBuscar = new Button();
            labGuardar = new Label();
            labeditar = new Label();
            labborrar = new Label();
            labBuscar = new Label();
            picboxlogo = new PictureBox();
            labeNombrecorpo = new Label();
            LabelTitulo = new Label();
            lbId = new Label();
            lbpasajero = new Label();
            lbvuelo = new Label();
            Labreserva = new Label();
            textID = new TextBox();
            texpasajero = new TextBox();
            lbprecio = new Label();
            ibclase = new Label();
            lbasiento = new Label();
            texasiento = new TextBox();
            lbpago = new Label();
            nupdprecio = new NumericUpDown();
            cbclase = new ComboBox();
            cbpago = new ComboBox();
            texvuelo = new TextBox();
            DTPReserva = new DateTimePicker();
            lbdata = new Label();
            Butdata = new Button();
            dgvDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picboxlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupdprecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // butGuardar
            // 
            butGuardar.BackgroundImage = (Image)resources.GetObject("butGuardar.BackgroundImage");
            butGuardar.FlatStyle = FlatStyle.Flat;
            butGuardar.Image = (Image)resources.GetObject("butGuardar.Image");
            butGuardar.Location = new Point(280, 354);
            butGuardar.Name = "butGuardar";
            butGuardar.Size = new Size(56, 53);
            butGuardar.TabIndex = 3;
            butGuardar.UseVisualStyleBackColor = true;
            // 
            // butEditar
            // 
            butEditar.BackgroundImage = (Image)resources.GetObject("butEditar.BackgroundImage");
            butEditar.FlatStyle = FlatStyle.Flat;
            butEditar.Image = (Image)resources.GetObject("butEditar.Image");
            butEditar.Location = new Point(342, 354);
            butEditar.Name = "butEditar";
            butEditar.Size = new Size(56, 53);
            butEditar.TabIndex = 4;
            butEditar.UseVisualStyleBackColor = true;
            butEditar.Click += butEditar_Click;
            // 
            // buteliminar
            // 
            buteliminar.BackgroundImage = (Image)resources.GetObject("buteliminar.BackgroundImage");
            buteliminar.FlatStyle = FlatStyle.Flat;
            buteliminar.Image = (Image)resources.GetObject("buteliminar.Image");
            buteliminar.Location = new Point(404, 354);
            buteliminar.Name = "buteliminar";
            buteliminar.Size = new Size(56, 53);
            buteliminar.TabIndex = 5;
            buteliminar.UseVisualStyleBackColor = true;
            // 
            // botBuscar
            // 
            botBuscar.BackgroundImage = (Image)resources.GetObject("botBuscar.BackgroundImage");
            botBuscar.FlatStyle = FlatStyle.Flat;
            botBuscar.Image = (Image)resources.GetObject("botBuscar.Image");
            botBuscar.Location = new Point(466, 354);
            botBuscar.Name = "botBuscar";
            botBuscar.Size = new Size(56, 53);
            botBuscar.TabIndex = 6;
            botBuscar.UseVisualStyleBackColor = true;
            // 
            // labGuardar
            // 
            labGuardar.BackColor = Color.LightSkyBlue;
            labGuardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labGuardar.Location = new Point(280, 410);
            labGuardar.Name = "labGuardar";
            labGuardar.Size = new Size(56, 21);
            labGuardar.TabIndex = 7;
            labGuardar.Text = "Guardar";
            labGuardar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labeditar
            // 
            labeditar.BackColor = Color.LightSkyBlue;
            labeditar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labeditar.Location = new Point(342, 410);
            labeditar.Name = "labeditar";
            labeditar.Size = new Size(56, 21);
            labeditar.TabIndex = 8;
            labeditar.Text = "Editar";
            labeditar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labborrar
            // 
            labborrar.BackColor = Color.LightSkyBlue;
            labborrar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labborrar.Location = new Point(404, 410);
            labborrar.Name = "labborrar";
            labborrar.Size = new Size(56, 21);
            labborrar.TabIndex = 9;
            labborrar.Text = "Borrar";
            labborrar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labBuscar
            // 
            labBuscar.BackColor = Color.LightSkyBlue;
            labBuscar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labBuscar.Location = new Point(466, 410);
            labBuscar.Name = "labBuscar";
            labBuscar.Size = new Size(56, 21);
            labBuscar.TabIndex = 10;
            labBuscar.Text = "Buscar";
            labBuscar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picboxlogo
            // 
            picboxlogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picboxlogo.BackgroundImage = (Image)resources.GetObject("picboxlogo.BackgroundImage");
            picboxlogo.Image = (Image)resources.GetObject("picboxlogo.Image");
            picboxlogo.Location = new Point(12, 12);
            picboxlogo.Name = "picboxlogo";
            picboxlogo.Size = new Size(78, 61);
            picboxlogo.SizeMode = PictureBoxSizeMode.Zoom;
            picboxlogo.TabIndex = 11;
            picboxlogo.TabStop = false;
            // 
            // labeNombrecorpo
            // 
            labeNombrecorpo.BackColor = Color.LightSkyBlue;
            labeNombrecorpo.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labeNombrecorpo.Location = new Point(12, 76);
            labeNombrecorpo.Name = "labeNombrecorpo";
            labeNombrecorpo.Size = new Size(78, 20);
            labeNombrecorpo.TabIndex = 1;
            labeNombrecorpo.Text = "AeroLink";
            labeNombrecorpo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelTitulo
            // 
            LabelTitulo.BackColor = Color.LightSkyBlue;
            LabelTitulo.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelTitulo.Location = new Point(280, 34);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(242, 39);
            LabelTitulo.TabIndex = 12;
            LabelTitulo.Text = "Gestion de Reservas";
            LabelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbId
            // 
            lbId.BackColor = Color.LightSkyBlue;
            lbId.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbId.Location = new Point(194, 127);
            lbId.Name = "lbId";
            lbId.Size = new Size(56, 21);
            lbId.TabIndex = 13;
            lbId.Text = "ID:";
            lbId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbpasajero
            // 
            lbpasajero.BackColor = Color.LightSkyBlue;
            lbpasajero.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbpasajero.Location = new Point(169, 169);
            lbpasajero.Name = "lbpasajero";
            lbpasajero.Size = new Size(81, 21);
            lbpasajero.TabIndex = 15;
            lbpasajero.Text = "ID Pasajero:";
            lbpasajero.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbvuelo
            // 
            lbvuelo.BackColor = Color.LightSkyBlue;
            lbvuelo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbvuelo.Location = new Point(179, 211);
            lbvuelo.Name = "lbvuelo";
            lbvuelo.Size = new Size(71, 21);
            lbvuelo.TabIndex = 16;
            lbvuelo.Text = "ID Vuelo:";
            lbvuelo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Labreserva
            // 
            Labreserva.BackColor = Color.LightSkyBlue;
            Labreserva.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Labreserva.Location = new Point(386, 127);
            Labreserva.Name = "Labreserva";
            Labreserva.Size = new Size(115, 21);
            Labreserva.TabIndex = 17;
            Labreserva.Text = "Fecha de Reserva:";
            Labreserva.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textID
            // 
            textID.Location = new Point(256, 125);
            textID.Name = "textID";
            textID.Size = new Size(100, 23);
            textID.TabIndex = 18;
            // 
            // texpasajero
            // 
            texpasajero.Location = new Point(256, 170);
            texpasajero.Name = "texpasajero";
            texpasajero.Size = new Size(100, 23);
            texpasajero.TabIndex = 19;
            // 
            // lbprecio
            // 
            lbprecio.BackColor = Color.LightSkyBlue;
            lbprecio.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbprecio.Location = new Point(386, 213);
            lbprecio.Name = "lbprecio";
            lbprecio.Size = new Size(69, 21);
            lbprecio.TabIndex = 22;
            lbprecio.Text = "Precio:";
            lbprecio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ibclase
            // 
            ibclase.BackColor = Color.LightSkyBlue;
            ibclase.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ibclase.Location = new Point(386, 169);
            ibclase.Name = "ibclase";
            ibclase.Size = new Size(69, 21);
            ibclase.TabIndex = 24;
            ibclase.Text = "Clase:";
            ibclase.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbasiento
            // 
            lbasiento.BackColor = Color.LightSkyBlue;
            lbasiento.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbasiento.Location = new Point(179, 256);
            lbasiento.Name = "lbasiento";
            lbasiento.Size = new Size(71, 21);
            lbasiento.TabIndex = 25;
            lbasiento.Text = "Asiento:";
            lbasiento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // texasiento
            // 
            texasiento.Location = new Point(256, 257);
            texasiento.Name = "texasiento";
            texasiento.Size = new Size(100, 23);
            texasiento.TabIndex = 29;
            // 
            // lbpago
            // 
            lbpago.BackColor = Color.LightSkyBlue;
            lbpago.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbpago.Location = new Point(386, 256);
            lbpago.Name = "lbpago";
            lbpago.Size = new Size(115, 21);
            lbpago.TabIndex = 32;
            lbpago.Text = "Estado de Pago:";
            lbpago.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nupdprecio
            // 
            nupdprecio.Location = new Point(461, 215);
            nupdprecio.Name = "nupdprecio";
            nupdprecio.Size = new Size(100, 23);
            nupdprecio.TabIndex = 35;
            // 
            // cbclase
            // 
            cbclase.FormattingEnabled = true;
            cbclase.Items.AddRange(new object[] { "Economy", "Premium Economy", "Business", "First" });
            cbclase.Location = new Point(461, 170);
            cbclase.Name = "cbclase";
            cbclase.Size = new Size(121, 23);
            cbclase.TabIndex = 36;
            // 
            // cbpago
            // 
            cbpago.FormattingEnabled = true;
            cbpago.Items.AddRange(new object[] { "Pendiente", "Pagado", "Cancelado" });
            cbpago.Location = new Point(507, 256);
            cbpago.Name = "cbpago";
            cbpago.Size = new Size(121, 23);
            cbpago.TabIndex = 37;
            // 
            // texvuelo
            // 
            texvuelo.Location = new Point(256, 211);
            texvuelo.Name = "texvuelo";
            texvuelo.Size = new Size(100, 23);
            texvuelo.TabIndex = 38;
            // 
            // DTPReserva
            // 
            DTPReserva.Location = new Point(507, 127);
            DTPReserva.Name = "DTPReserva";
            DTPReserva.Size = new Size(200, 23);
            DTPReserva.TabIndex = 39;
            // 
            // lbdata
            // 
            lbdata.BackColor = Color.LightSkyBlue;
            lbdata.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbdata.Location = new Point(689, 410);
            lbdata.Name = "lbdata";
            lbdata.Size = new Size(97, 21);
            lbdata.TabIndex = 46;
            lbdata.Text = "DataGridView";
            lbdata.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Butdata
            // 
            Butdata.BackgroundImage = (Image)resources.GetObject("Butdata.BackgroundImage");
            Butdata.FlatStyle = FlatStyle.Flat;
            Butdata.Image = (Image)resources.GetObject("Butdata.Image");
            Butdata.Location = new Point(706, 354);
            Butdata.Name = "Butdata";
            Butdata.Size = new Size(56, 53);
            Butdata.TabIndex = 45;
            Butdata.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(731, 378);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(10, 10);
            dgvDatos.TabIndex = 44;
            // 
            // FrmReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(lbdata);
            Controls.Add(Butdata);
            Controls.Add(dgvDatos);
            Controls.Add(DTPReserva);
            Controls.Add(texvuelo);
            Controls.Add(cbpago);
            Controls.Add(cbclase);
            Controls.Add(nupdprecio);
            Controls.Add(lbpago);
            Controls.Add(texasiento);
            Controls.Add(lbasiento);
            Controls.Add(ibclase);
            Controls.Add(lbprecio);
            Controls.Add(texpasajero);
            Controls.Add(textID);
            Controls.Add(Labreserva);
            Controls.Add(lbvuelo);
            Controls.Add(lbpasajero);
            Controls.Add(lbId);
            Controls.Add(LabelTitulo);
            Controls.Add(picboxlogo);
            Controls.Add(labBuscar);
            Controls.Add(labborrar);
            Controls.Add(labeditar);
            Controls.Add(labGuardar);
            Controls.Add(botBuscar);
            Controls.Add(buteliminar);
            Controls.Add(butEditar);
            Controls.Add(butGuardar);
            Controls.Add(labeNombrecorpo);
            Name = "FrmReserva";
            Text = "Gestion de Reservas";
            ((System.ComponentModel.ISupportInitialize)picboxlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupdprecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button butGuardar;
        private Button butEditar;
        private Button buteliminar;
        private Button botBuscar;
        private Label labGuardar;
        private Label labeditar;
        private Label labborrar;
        private Label labBuscar;
        private PictureBox picboxlogo;
        private Label labeNombrecorpo;
        private Label LabelTitulo;
        private Label lbId;
        private Label lbpasajero;
        private Label lbvuelo;
        private Label Labreserva;
        private TextBox textID;
        private TextBox texpasajero;
        private Label lbprecio;
        private Label lbIngreso;
        private Label ibclase;
        private Label lbasiento;
        private DateTimePicker DTPfechadeingreso;
        private TextBox texasiento;
        private Label lbpago;
        private NumericUpDown nupdprecio;
        private ComboBox cbclase;
        private ComboBox cbpago;
        private TextBox texvuelo;
        private DateTimePicker DTPReserva;
        private Label lbdata;
        private Button Butdata;
        private DataGridView dgvDatos;
    }
}