namespace Frontend
{
    partial class FrmCheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckIn));
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
            lbreserva = new Label();
            lbempleado = new Label();
            lbhora = new Label();
            textID = new TextBox();
            texreserva = new TextBox();
            lbmostrador = new Label();
            ibfacturado = new Label();
            lbfecha = new Label();
            lbestado = new Label();
            cbestado = new ComboBox();
            texempleado = new TextBox();
            DTPhora = new DateTimePicker();
            DTPfecha = new DateTimePicker();
            cbfacturado = new ComboBox();
            texmostrador = new TextBox();
            lbdata = new Label();
            Butdata = new Button();
            dgvDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picboxlogo).BeginInit();
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
            LabelTitulo.Text = "Gestion de CheckIn";
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
            // lbreserva
            // 
            lbreserva.BackColor = Color.LightSkyBlue;
            lbreserva.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbreserva.Location = new Point(169, 169);
            lbreserva.Name = "lbreserva";
            lbreserva.Size = new Size(81, 21);
            lbreserva.TabIndex = 15;
            lbreserva.Text = "ID Reserva:";
            lbreserva.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbempleado
            // 
            lbempleado.BackColor = Color.LightSkyBlue;
            lbempleado.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbempleado.Location = new Point(161, 211);
            lbempleado.Name = "lbempleado";
            lbempleado.Size = new Size(89, 21);
            lbempleado.TabIndex = 16;
            lbempleado.Text = "ID Empleado:";
            lbempleado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbhora
            // 
            lbhora.BackColor = Color.LightSkyBlue;
            lbhora.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbhora.Location = new Point(386, 127);
            lbhora.Name = "lbhora";
            lbhora.Size = new Size(69, 21);
            lbhora.TabIndex = 17;
            lbhora.Text = "Hora:";
            lbhora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textID
            // 
            textID.Location = new Point(256, 125);
            textID.Name = "textID";
            textID.Size = new Size(100, 23);
            textID.TabIndex = 18;
            // 
            // texreserva
            // 
            texreserva.Location = new Point(256, 170);
            texreserva.Name = "texreserva";
            texreserva.Size = new Size(100, 23);
            texreserva.TabIndex = 19;
            // 
            // lbmostrador
            // 
            lbmostrador.BackColor = Color.LightSkyBlue;
            lbmostrador.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbmostrador.Location = new Point(386, 172);
            lbmostrador.Name = "lbmostrador";
            lbmostrador.Size = new Size(74, 21);
            lbmostrador.TabIndex = 22;
            lbmostrador.Text = "Mostrador: ";
            lbmostrador.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ibfacturado
            // 
            ibfacturado.BackColor = Color.LightSkyBlue;
            ibfacturado.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ibfacturado.Location = new Point(391, 213);
            ibfacturado.Name = "ibfacturado";
            ibfacturado.Size = new Size(131, 21);
            ibfacturado.TabIndex = 24;
            ibfacturado.Text = "Equipaje Facturado:";
            ibfacturado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbfecha
            // 
            lbfecha.BackColor = Color.LightSkyBlue;
            lbfecha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbfecha.Location = new Point(103, 256);
            lbfecha.Name = "lbfecha";
            lbfecha.Size = new Size(71, 21);
            lbfecha.TabIndex = 25;
            lbfecha.Text = "Fecha:";
            lbfecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbestado
            // 
            lbestado.BackColor = Color.LightSkyBlue;
            lbestado.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbestado.Location = new Point(391, 256);
            lbestado.Name = "lbestado";
            lbestado.Size = new Size(69, 21);
            lbestado.TabIndex = 32;
            lbestado.Text = "Estado:";
            lbestado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbestado
            // 
            cbestado.FormattingEnabled = true;
            cbestado.Items.AddRange(new object[] { "Pendiente", "Completado", "Cancelado" });
            cbestado.Location = new Point(466, 257);
            cbestado.Name = "cbestado";
            cbestado.Size = new Size(121, 23);
            cbestado.TabIndex = 37;
            // 
            // texempleado
            // 
            texempleado.Location = new Point(256, 211);
            texempleado.Name = "texempleado";
            texempleado.Size = new Size(100, 23);
            texempleado.TabIndex = 38;
            // 
            // DTPhora
            // 
            DTPhora.Format = DateTimePickerFormat.Time;
            DTPhora.Location = new Point(461, 127);
            DTPhora.Name = "DTPhora";
            DTPhora.Size = new Size(200, 23);
            DTPhora.TabIndex = 39;
            // 
            // DTPfecha
            // 
            DTPfecha.Location = new Point(180, 256);
            DTPfecha.Name = "DTPfecha";
            DTPfecha.Size = new Size(200, 23);
            DTPfecha.TabIndex = 40;
            // 
            // cbfacturado
            // 
            cbfacturado.FormattingEnabled = true;
            cbfacturado.Location = new Point(528, 211);
            cbfacturado.Name = "cbfacturado";
            cbfacturado.Size = new Size(100, 23);
            cbfacturado.TabIndex = 36;
            // 
            // texmostrador
            // 
            texmostrador.Location = new Point(461, 172);
            texmostrador.Name = "texmostrador";
            texmostrador.Size = new Size(100, 23);
            texmostrador.TabIndex = 41;
            // 
            // lbdata
            // 
            lbdata.BackColor = Color.LightSkyBlue;
            lbdata.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbdata.Location = new Point(694, 410);
            lbdata.Name = "lbdata";
            lbdata.Size = new Size(97, 21);
            lbdata.TabIndex = 67;
            lbdata.Text = "DataGridView";
            lbdata.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Butdata
            // 
            Butdata.BackgroundImage = (Image)resources.GetObject("Butdata.BackgroundImage");
            Butdata.FlatStyle = FlatStyle.Flat;
            Butdata.Image = (Image)resources.GetObject("Butdata.Image");
            Butdata.Location = new Point(711, 354);
            Butdata.Name = "Butdata";
            Butdata.Size = new Size(56, 53);
            Butdata.TabIndex = 66;
            Butdata.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(736, 378);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(10, 10);
            dgvDatos.TabIndex = 65;
            // 
            // FrmCheckIn
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
            Controls.Add(texmostrador);
            Controls.Add(DTPfecha);
            Controls.Add(DTPhora);
            Controls.Add(texempleado);
            Controls.Add(cbestado);
            Controls.Add(cbfacturado);
            Controls.Add(lbestado);
            Controls.Add(lbfecha);
            Controls.Add(ibfacturado);
            Controls.Add(lbmostrador);
            Controls.Add(texreserva);
            Controls.Add(textID);
            Controls.Add(lbhora);
            Controls.Add(lbempleado);
            Controls.Add(lbreserva);
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
            Name = "FrmCheckIn";
            Text = "Gestion de CheckIn";
            ((System.ComponentModel.ISupportInitialize)picboxlogo).EndInit();
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
        private Label lbreserva;
        private Label lbempleado;
        private Label lbhora;
        private TextBox textID;
        private TextBox texreserva;
        private Label lbmostrador;
        private Label lbIngreso;
        private Label ibfacturado;
        private Label lbfecha;
        private DateTimePicker DTPfechadeingreso;
        private Label lbestado;
        private ComboBox cbestado;
        private TextBox texempleado;
        private DateTimePicker DTPhora;
        private DateTimePicker DTPfecha;
        private ComboBox cbfacturado;
        private TextBox texmostrador;
        private Label lbdata;
        private Button Butdata;
        private DataGridView dgvDatos;
    }
}