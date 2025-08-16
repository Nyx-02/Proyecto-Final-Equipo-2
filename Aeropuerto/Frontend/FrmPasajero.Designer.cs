namespace Frontend
{
    partial class FrmPasajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPasajero));
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
            lbNombre = new Label();
            lbApellido = new Label();
            LabNacionalidad = new Label();
            textID = new TextBox();
            texnombre = new TextBox();
            texnacionalidad = new TextBox();
            texapellido = new TextBox();
            lbemail = new Label();
            lbnacimiento = new Label();
            lbtelefono = new Label();
            lbPasaporte = new Label();
            DTPnacimiento = new DateTimePicker();
            texpasaporte = new TextBox();
            texemail = new TextBox();
            textelefono = new TextBox();
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
            LabelTitulo.Text = "Gestion de Pasajeros";
            LabelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            LabelTitulo.Click += label1_Click;
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
            // lbNombre
            // 
            lbNombre.BackColor = Color.LightSkyBlue;
            lbNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbNombre.Location = new Point(189, 169);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(61, 21);
            lbNombre.TabIndex = 15;
            lbNombre.Text = "Nombre:";
            lbNombre.TextAlign = ContentAlignment.MiddleCenter;
            lbNombre.Click += lbDestino_Click;
            // 
            // lbApellido
            // 
            lbApellido.BackColor = Color.LightSkyBlue;
            lbApellido.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbApellido.Location = new Point(189, 211);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(61, 21);
            lbApellido.TabIndex = 16;
            lbApellido.Text = "Apellido:";
            lbApellido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabNacionalidad
            // 
            LabNacionalidad.BackColor = Color.LightSkyBlue;
            LabNacionalidad.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LabNacionalidad.Location = new Point(161, 253);
            LabNacionalidad.Name = "LabNacionalidad";
            LabNacionalidad.Size = new Size(89, 21);
            LabNacionalidad.TabIndex = 17;
            LabNacionalidad.Text = "Nacionalidad:";
            LabNacionalidad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textID
            // 
            textID.Location = new Point(256, 125);
            textID.Name = "textID";
            textID.Size = new Size(100, 23);
            textID.TabIndex = 18;
            // 
            // texnombre
            // 
            texnombre.Location = new Point(256, 170);
            texnombre.Name = "texnombre";
            texnombre.Size = new Size(100, 23);
            texnombre.TabIndex = 19;
            // 
            // texnacionalidad
            // 
            texnacionalidad.Location = new Point(256, 254);
            texnacionalidad.Name = "texnacionalidad";
            texnacionalidad.Size = new Size(100, 23);
            texnacionalidad.TabIndex = 20;
            // 
            // texapellido
            // 
            texapellido.Location = new Point(256, 211);
            texapellido.Name = "texapellido";
            texapellido.Size = new Size(100, 23);
            texapellido.TabIndex = 21;
            // 
            // lbemail
            // 
            lbemail.BackColor = Color.LightSkyBlue;
            lbemail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbemail.Location = new Point(386, 213);
            lbemail.Name = "lbemail";
            lbemail.Size = new Size(69, 21);
            lbemail.TabIndex = 22;
            lbemail.Text = "Email:";
            lbemail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbnacimiento
            // 
            lbnacimiento.BackColor = Color.LightSkyBlue;
            lbnacimiento.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbnacimiento.Location = new Point(386, 253);
            lbnacimiento.Name = "lbnacimiento";
            lbnacimiento.Size = new Size(141, 21);
            lbnacimiento.TabIndex = 23;
            lbnacimiento.Text = "Feha de Nacimiento:";
            lbnacimiento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbtelefono
            // 
            lbtelefono.BackColor = Color.LightSkyBlue;
            lbtelefono.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbtelefono.Location = new Point(386, 169);
            lbtelefono.Name = "lbtelefono";
            lbtelefono.Size = new Size(69, 21);
            lbtelefono.TabIndex = 24;
            lbtelefono.Text = "Telefono:";
            lbtelefono.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbPasaporte
            // 
            lbPasaporte.BackColor = Color.LightSkyBlue;
            lbPasaporte.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbPasaporte.Location = new Point(386, 127);
            lbPasaporte.Name = "lbPasaporte";
            lbPasaporte.Size = new Size(69, 21);
            lbPasaporte.TabIndex = 25;
            lbPasaporte.Text = "Pasaporte:";
            lbPasaporte.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DTPnacimiento
            // 
            DTPnacimiento.Location = new Point(533, 254);
            DTPnacimiento.Name = "DTPnacimiento";
            DTPnacimiento.Size = new Size(200, 23);
            DTPnacimiento.TabIndex = 27;
            // 
            // texpasaporte
            // 
            texpasaporte.Location = new Point(461, 128);
            texpasaporte.Name = "texpasaporte";
            texpasaporte.Size = new Size(100, 23);
            texpasaporte.TabIndex = 28;
            // 
            // texemail
            // 
            texemail.Location = new Point(461, 209);
            texemail.Name = "texemail";
            texemail.Size = new Size(100, 23);
            texemail.TabIndex = 29;
            // 
            // textelefono
            // 
            textelefono.Location = new Point(461, 169);
            textelefono.Name = "textelefono";
            textelefono.Size = new Size(100, 23);
            textelefono.TabIndex = 30;
            // 
            // lbdata
            // 
            lbdata.BackColor = Color.LightSkyBlue;
            lbdata.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbdata.Location = new Point(690, 410);
            lbdata.Name = "lbdata";
            lbdata.Size = new Size(97, 21);
            lbdata.TabIndex = 52;
            lbdata.Text = "DataGridView";
            lbdata.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Butdata
            // 
            Butdata.BackgroundImage = (Image)resources.GetObject("Butdata.BackgroundImage");
            Butdata.FlatStyle = FlatStyle.Flat;
            Butdata.Image = (Image)resources.GetObject("Butdata.Image");
            Butdata.Location = new Point(707, 354);
            Butdata.Name = "Butdata";
            Butdata.Size = new Size(56, 53);
            Butdata.TabIndex = 51;
            Butdata.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(732, 378);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(10, 10);
            dgvDatos.TabIndex = 50;
            // 
            // FrmPasajero
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
            Controls.Add(textelefono);
            Controls.Add(texemail);
            Controls.Add(texpasaporte);
            Controls.Add(DTPnacimiento);
            Controls.Add(lbPasaporte);
            Controls.Add(lbtelefono);
            Controls.Add(lbnacimiento);
            Controls.Add(lbemail);
            Controls.Add(texapellido);
            Controls.Add(texnacionalidad);
            Controls.Add(texnombre);
            Controls.Add(textID);
            Controls.Add(LabNacionalidad);
            Controls.Add(lbApellido);
            Controls.Add(lbNombre);
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
            Name = "FrmPasajero";
            Text = "Gestion de Pasajeros";
            Load += FrmVuelo_Load;
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
        private Label lbNombre;
        private Label lbApellido;
        private Label LabNacionalidad;
        private TextBox textID;
        private TextBox texnombre;
        private TextBox texnacionalidad;
        private TextBox texapellido;
        private Label lbemail;
        private Label lbnacimiento;
        private Label lbtelefono;
        private Label lbPasaporte;
        private DateTimePicker DTPnacimiento;
        private TextBox texpasaporte;
        private TextBox texemail;
        private TextBox textelefono;
        private Label lbdata;
        private Button Butdata;
        private DataGridView dgvDatos;
    }
}