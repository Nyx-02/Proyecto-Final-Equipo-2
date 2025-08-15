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
            lbpasajero = new Label();
            lbvuelo = new Label();
            Labfecha = new Label();
            textID = new TextBox();
            texempleado = new TextBox();
            lbacceso = new Label();
            ibturno = new Label();
            lbobservaciones = new Label();
            texasiento = new TextBox();
            lbestado = new Label();
            cbclase = new ComboBox();
            cbestado = new ComboBox();
            texpuesto = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            cbniveleacceso = new ComboBox();
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
            // lbpasajero
            // 
            lbpasajero.BackColor = Color.LightSkyBlue;
            lbpasajero.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbpasajero.Location = new Point(163, 169);
            lbpasajero.Name = "lbpasajero";
            lbpasajero.Size = new Size(87, 21);
            lbpasajero.TabIndex = 15;
            lbpasajero.Text = "ID Empleado:";
            lbpasajero.TextAlign = ContentAlignment.MiddleCenter;
            lbpasajero.Click += lbDestino_Click;
            // 
            // lbvuelo
            // 
            lbvuelo.BackColor = Color.LightSkyBlue;
            lbvuelo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbvuelo.Location = new Point(194, 211);
            lbvuelo.Name = "lbvuelo";
            lbvuelo.Size = new Size(56, 21);
            lbvuelo.TabIndex = 16;
            lbvuelo.Text = "Puesto:";
            lbvuelo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Labfecha
            // 
            Labfecha.BackColor = Color.LightSkyBlue;
            Labfecha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Labfecha.Location = new Point(386, 127);
            Labfecha.Name = "Labfecha";
            Labfecha.Size = new Size(69, 21);
            Labfecha.TabIndex = 17;
            Labfecha.Text = "Fecha:";
            Labfecha.TextAlign = ContentAlignment.MiddleCenter;
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
            // lbacceso
            // 
            lbacceso.BackColor = Color.LightSkyBlue;
            lbacceso.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbacceso.Location = new Point(386, 213);
            lbacceso.Name = "lbacceso";
            lbacceso.Size = new Size(115, 21);
            lbacceso.TabIndex = 22;
            lbacceso.Text = "Nivel de Acceso:";
            lbacceso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ibturno
            // 
            ibturno.BackColor = Color.LightSkyBlue;
            ibturno.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ibturno.Location = new Point(181, 256);
            ibturno.Name = "ibturno";
            ibturno.Size = new Size(69, 21);
            ibturno.TabIndex = 24;
            ibturno.Text = "Turno:";
            ibturno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbobservaciones
            // 
            lbobservaciones.BackColor = Color.LightSkyBlue;
            lbobservaciones.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbobservaciones.Location = new Point(389, 170);
            lbobservaciones.Name = "lbobservaciones";
            lbobservaciones.Size = new Size(97, 21);
            lbobservaciones.TabIndex = 25;
            lbobservaciones.Text = "Observaciones:";
            lbobservaciones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // texasiento
            // 
            texasiento.Location = new Point(492, 170);
            texasiento.Name = "texasiento";
            texasiento.Size = new Size(100, 23);
            texasiento.TabIndex = 29;
            // 
            // lbestado
            // 
            lbestado.BackColor = Color.LightSkyBlue;
            lbestado.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbestado.Location = new Point(386, 258);
            lbestado.Name = "lbestado";
            lbestado.Size = new Size(69, 21);
            lbestado.TabIndex = 32;
            lbestado.Text = "Estado:";
            lbestado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbclase
            // 
            cbclase.FormattingEnabled = true;
            cbclase.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cbclase.Location = new Point(256, 256);
            cbclase.Name = "cbclase";
            cbclase.Size = new Size(103, 23);
            cbclase.TabIndex = 36;
            // 
            // cbestado
            // 
            cbestado.FormattingEnabled = true;
            cbestado.Items.AddRange(new object[] { "Pendiente", "Pagado", "Cancelado" });
            cbestado.Location = new Point(461, 259);
            cbestado.Name = "cbestado";
            cbestado.Size = new Size(121, 23);
            cbestado.TabIndex = 37;
            // 
            // texpuesto
            // 
            texpuesto.Location = new Point(256, 211);
            texpuesto.Name = "texpuesto";
            texpuesto.Size = new Size(100, 23);
            texpuesto.TabIndex = 38;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(461, 125);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 39;
            // 
            // cbniveleacceso
            // 
            cbniveleacceso.FormattingEnabled = true;
            cbniveleacceso.Items.AddRange(new object[] { "Bajo", "Medio", "Alto" });
            cbniveleacceso.Location = new Point(507, 214);
            cbniveleacceso.Name = "cbniveleacceso";
            cbniveleacceso.Size = new Size(121, 23);
            cbniveleacceso.TabIndex = 40;
            // 
            // FrmSeguridad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(cbniveleacceso);
            Controls.Add(dateTimePicker1);
            Controls.Add(texpuesto);
            Controls.Add(cbestado);
            Controls.Add(cbclase);
            Controls.Add(lbestado);
            Controls.Add(texasiento);
            Controls.Add(lbobservaciones);
            Controls.Add(ibturno);
            Controls.Add(lbacceso);
            Controls.Add(texempleado);
            Controls.Add(textID);
            Controls.Add(Labfecha);
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
        private Label lbpasajero;
        private Label lbvuelo;
        private Label Labfecha;
        private TextBox textID;
        private TextBox texempleado;
        private Label lbacceso;
        private Label lbIngreso;
        private Label ibturno;
        private Label lbobservaciones;
        private DateTimePicker DTPfechadeingreso;
        private TextBox texasiento;
        private Label lbestado;
        private ComboBox cbclase;
        private ComboBox cbestado;
        private TextBox texpuesto;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbniveleacceso;
    }
}