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
            texDestino = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            lbemail = new Label();
            lbhoradelle = new Label();
            lbtelefono = new Label();
            lbPasaporte = new Label();
            DTPhoradelle = new DateTimePicker();
            texpasaporte = new TextBox();
            textBox2 = new TextBox();
            textelefono = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picboxlogo).BeginInit();
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
            // texDestino
            // 
            texDestino.Location = new Point(256, 170);
            texDestino.Name = "texDestino";
            texDestino.Size = new Size(100, 23);
            texDestino.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(256, 254);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(256, 211);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 21;
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
            // lbhoradelle
            // 
            lbhoradelle.BackColor = Color.LightSkyBlue;
            lbhoradelle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbhoradelle.Location = new Point(386, 253);
            lbhoradelle.Name = "lbhoradelle";
            lbhoradelle.Size = new Size(141, 21);
            lbhoradelle.TabIndex = 23;
            lbhoradelle.Text = "Feha de Nacimiento:";
            lbhoradelle.TextAlign = ContentAlignment.MiddleCenter;
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
            // DTPhoradelle
            // 
            DTPhoradelle.Location = new Point(533, 254);
            DTPhoradelle.Name = "DTPhoradelle";
            DTPhoradelle.Size = new Size(200, 23);
            DTPhoradelle.TabIndex = 27;
            // 
            // texpasaporte
            // 
            texpasaporte.Location = new Point(461, 128);
            texpasaporte.Name = "texpasaporte";
            texpasaporte.Size = new Size(100, 23);
            texpasaporte.TabIndex = 28;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(461, 209);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 29;
            // 
            // textelefono
            // 
            textelefono.Location = new Point(461, 169);
            textelefono.Name = "textelefono";
            textelefono.Size = new Size(100, 23);
            textelefono.TabIndex = 30;
            // 
            // FrmPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(textelefono);
            Controls.Add(textBox2);
            Controls.Add(texpasaporte);
            Controls.Add(DTPhoradelle);
            Controls.Add(lbPasaporte);
            Controls.Add(lbtelefono);
            Controls.Add(lbhoradelle);
            Controls.Add(lbemail);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(texDestino);
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
        private TextBox texDestino;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lbemail;
        private Label lbhoradelle;
        private Label lbtelefono;
        private Label lbPasaporte;
        private DateTimePicker DTPhoradelle;
        private TextBox texpasaporte;
        private TextBox textBox2;
        private TextBox textelefono;
    }
}