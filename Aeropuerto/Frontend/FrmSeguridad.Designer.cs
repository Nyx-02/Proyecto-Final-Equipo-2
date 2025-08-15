namespace Frontend
{
    partial class FrmSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeguridad));
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
            lbempleado = new Label();
            lbpuesto = new Label();
            this.lbobservaciones = new Label();
            textID = new TextBox();
            texempleado = new TextBox();
            this.texobservaciones = new TextBox();
            this.lbnivelacceso = new Label();
            lbestado = new Label();
            lbturno = new Label();
            cbEstado = new ComboBox();
            cbturno = new ComboBox();
            lbfecha = new Label();
            texpuesto = new TextBox();
            DTPfecha = new DateTimePicker();
            cbAcceso = new ComboBox();
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
            LabelTitulo.Text = "Gestion de Seguridad";
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
            // lbempleado
            // 
            lbempleado.BackColor = Color.LightSkyBlue;
            lbempleado.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbempleado.Location = new Point(162, 169);
            lbempleado.Name = "lbempleado";
            lbempleado.Size = new Size(88, 21);
            lbempleado.TabIndex = 15;
            lbempleado.Text = "ID Empleado:";
            lbempleado.TextAlign = ContentAlignment.MiddleCenter;
            lbempleado.Click += lbDestino_Click;
            // 
            // lbpuesto
            // 
            lbpuesto.BackColor = Color.LightSkyBlue;
            lbpuesto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbpuesto.Location = new Point(194, 211);
            lbpuesto.Name = "lbpuesto";
            lbpuesto.Size = new Size(56, 21);
            lbpuesto.TabIndex = 16;
            lbpuesto.Text = "Puesto:";
            lbpuesto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbobservaciones
            // 
            this.lbobservaciones.BackColor = Color.LightSkyBlue;
            this.lbobservaciones.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            this.lbobservaciones.Location = new Point(386, 172);
            this.lbobservaciones.Name = "lbobservaciones";
            this.lbobservaciones.Size = new Size(97, 21);
            this.lbobservaciones.TabIndex = 17;
            this.lbobservaciones.Text = "Observaciones:";
            this.lbobservaciones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textID
            // 
            textID.Location = new Point(256, 125);
            textID.Name = "textID";
            textID.Size = new Size(100, 23);
            textID.TabIndex = 18;
            // 
            // texempleado
            // 
            texempleado.Location = new Point(256, 170);
            texempleado.Name = "texempleado";
            texempleado.Size = new Size(100, 23);
            texempleado.TabIndex = 19;
            // 
            // texobservaciones
            // 
            this.texobservaciones.Location = new Point(489, 169);
            this.texobservaciones.Name = "texobservaciones";
            this.texobservaciones.Size = new Size(100, 23);
            this.texobservaciones.TabIndex = 20;
            // 
            // lbnivelacceso
            // 
            this.lbnivelacceso.BackColor = Color.LightSkyBlue;
            this.lbnivelacceso.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            this.lbnivelacceso.Location = new Point(386, 213);
            this.lbnivelacceso.Name = "lbnivelacceso";
            this.lbnivelacceso.Size = new Size(106, 21);
            this.lbnivelacceso.TabIndex = 22;
            this.lbnivelacceso.Text = "Nivel de Acceso:";
            this.lbnivelacceso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbestado
            // 
            lbestado.BackColor = Color.LightSkyBlue;
            lbestado.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbestado.Location = new Point(386, 253);
            lbestado.Name = "lbestado";
            lbestado.Size = new Size(69, 21);
            lbestado.TabIndex = 24;
            lbestado.Text = "Estado:";
            lbestado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbturno
            // 
            lbturno.BackColor = Color.LightSkyBlue;
            lbturno.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbturno.Location = new Point(194, 252);
            lbturno.Name = "lbturno";
            lbturno.Size = new Size(56, 21);
            lbturno.TabIndex = 32;
            lbturno.Text = "Turno:";
            lbturno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbEstado.Location = new Point(461, 254);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(121, 23);
            cbEstado.TabIndex = 36;
            // 
            // cbturno
            // 
            cbturno.FormattingEnabled = true;
            cbturno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cbturno.Location = new Point(256, 253);
            cbturno.Name = "cbturno";
            cbturno.Size = new Size(100, 23);
            cbturno.TabIndex = 37;
            // 
            // lbfecha
            // 
            lbfecha.BackColor = Color.LightSkyBlue;
            lbfecha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbfecha.Location = new Point(386, 127);
            lbfecha.Name = "lbfecha";
            lbfecha.Size = new Size(76, 21);
            lbfecha.TabIndex = 38;
            lbfecha.Text = "Fecha:";
            lbfecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // texpuesto
            // 
            texpuesto.Location = new Point(256, 214);
            texpuesto.Name = "texpuesto";
            texpuesto.Size = new Size(100, 23);
            texpuesto.TabIndex = 40;
            // 
            // DTPfecha
            // 
            DTPfecha.Location = new Point(461, 125);
            DTPfecha.Name = "DTPfecha";
            DTPfecha.Size = new Size(200, 23);
            DTPfecha.TabIndex = 41;
            // 
            // cbAcceso
            // 
            cbAcceso.FormattingEnabled = true;
            cbAcceso.Items.AddRange(new object[] { "Bajo", "Medio", "Alto" });
            cbAcceso.Location = new Point(498, 214);
            cbAcceso.Name = "cbAcceso";
            cbAcceso.Size = new Size(121, 23);
            cbAcceso.TabIndex = 42;
            // 
            // FrmSeguridad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(cbAcceso);
            Controls.Add(DTPfecha);
            Controls.Add(texpuesto);
            Controls.Add(lbfecha);
            Controls.Add(cbturno);
            Controls.Add(cbEstado);
            Controls.Add(lbturno);
            Controls.Add(lbestado);
            Controls.Add(this.lbnivelacceso);
            Controls.Add(this.texobservaciones);
            Controls.Add(texempleado);
            Controls.Add(textID);
            Controls.Add(this.lbobservaciones);
            Controls.Add(lbpuesto);
            Controls.Add(lbempleado);
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
            Name = "FrmSeguridad";
            Text = "Gestion de Seguridad";
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
        private Label lbempleado;
        private Label lbpuesto;
        private Label labdimesiones;
        private TextBox textID;
        private TextBox texempleado;
        private TextBox texdimensiones;
        private Label lbetiqueta;
        private Label lbIngreso;
        private Label lbestado;
        private DateTimePicker DTPfechadeingreso;
        private TextBox texetiqueta;
        private Label lbturno;
        private ComboBox cbEstado;
        private ComboBox cbturno;
        private TextBox texcolor;
        private Label lbfecha;
        private TextBox texpuesto;
        private DateTimePicker DTPfecha;
        private ComboBox cbAcceso;
    }
}