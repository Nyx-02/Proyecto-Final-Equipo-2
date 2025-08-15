namespace Frontend
{
    partial class FrmVuelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVuelo));
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
            lbDestino = new Label();
            lbAerolinea = new Label();
            LabOrigen = new Label();
            textID = new TextBox();
            texDestino = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            lbEstado = new Label();
            lbhoradelle = new Label();
            lbHorasali = new Label();
            lbFecha = new Label();
            DTPFecha = new DateTimePicker();
            DTPhoradelle = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            comboBox1 = new ComboBox();
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
            LabelTitulo.Text = "Gestion de Vuelos";
            LabelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            LabelTitulo.Click += label1_Click;
            // 
            // lbId
            // 
            lbId.BackColor = Color.LightSkyBlue;
            lbId.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbId.Location = new Point(189, 127);
            lbId.Name = "lbId";
            lbId.Size = new Size(56, 21);
            lbId.TabIndex = 13;
            lbId.Text = "ID:";
            lbId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbDestino
            // 
            lbDestino.BackColor = Color.LightSkyBlue;
            lbDestino.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbDestino.Location = new Point(175, 169);
            lbDestino.Name = "lbDestino";
            lbDestino.Size = new Size(70, 21);
            lbDestino.TabIndex = 15;
            lbDestino.Text = "Destino:";
            lbDestino.TextAlign = ContentAlignment.MiddleCenter;
            lbDestino.Click += lbDestino_Click;
            // 
            // lbAerolinea
            // 
            lbAerolinea.BackColor = Color.LightSkyBlue;
            lbAerolinea.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbAerolinea.Location = new Point(175, 211);
            lbAerolinea.Name = "lbAerolinea";
            lbAerolinea.Size = new Size(70, 21);
            lbAerolinea.TabIndex = 16;
            lbAerolinea.Text = "Aerolinea:";
            lbAerolinea.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabOrigen
            // 
            LabOrigen.BackColor = Color.LightSkyBlue;
            LabOrigen.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LabOrigen.Location = new Point(189, 253);
            LabOrigen.Name = "LabOrigen";
            LabOrigen.Size = new Size(56, 21);
            LabOrigen.TabIndex = 17;
            LabOrigen.Text = "Origen:";
            LabOrigen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textID
            // 
            textID.Location = new Point(251, 125);
            textID.Name = "textID";
            textID.Size = new Size(100, 23);
            textID.TabIndex = 18;
            // 
            // texDestino
            // 
            texDestino.Location = new Point(251, 170);
            texDestino.Name = "texDestino";
            texDestino.Size = new Size(100, 23);
            texDestino.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(251, 254);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(251, 211);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 21;
            // 
            // lbEstado
            // 
            lbEstado.BackColor = Color.LightSkyBlue;
            lbEstado.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbEstado.Location = new Point(381, 253);
            lbEstado.Name = "lbEstado";
            lbEstado.Size = new Size(56, 21);
            lbEstado.TabIndex = 22;
            lbEstado.Text = "Estado:";
            lbEstado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbhoradelle
            // 
            lbhoradelle.BackColor = Color.LightSkyBlue;
            lbhoradelle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbhoradelle.Location = new Point(381, 211);
            lbhoradelle.Name = "lbhoradelle";
            lbhoradelle.Size = new Size(112, 21);
            lbhoradelle.TabIndex = 23;
            lbhoradelle.Text = "Hora de LLegada:";
            lbhoradelle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbHorasali
            // 
            lbHorasali.BackColor = Color.LightSkyBlue;
            lbHorasali.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbHorasali.Location = new Point(381, 169);
            lbHorasali.Name = "lbHorasali";
            lbHorasali.Size = new Size(101, 21);
            lbHorasali.TabIndex = 24;
            lbHorasali.Text = "Hora de Salida:";
            lbHorasali.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbFecha
            // 
            lbFecha.BackColor = Color.LightSkyBlue;
            lbFecha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbFecha.Location = new Point(381, 127);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(56, 21);
            lbFecha.TabIndex = 25;
            lbFecha.Text = "Fecha:";
            lbFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DTPFecha
            // 
            DTPFecha.Location = new Point(443, 127);
            DTPFecha.Name = "DTPFecha";
            DTPFecha.Size = new Size(200, 23);
            DTPFecha.TabIndex = 26;
            // 
            // DTPhoradelle
            // 
            DTPhoradelle.Location = new Point(499, 211);
            DTPhoradelle.Name = "DTPhoradelle";
            DTPhoradelle.Size = new Size(200, 23);
            DTPhoradelle.TabIndex = 27;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(488, 170);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 28;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Activo", "Retrasado", "Cancelado" });
            comboBox1.Location = new Point(443, 253);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 29;
            // 
            // FrmVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker3);
            Controls.Add(DTPhoradelle);
            Controls.Add(DTPFecha);
            Controls.Add(lbFecha);
            Controls.Add(lbHorasali);
            Controls.Add(lbhoradelle);
            Controls.Add(lbEstado);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(texDestino);
            Controls.Add(textID);
            Controls.Add(LabOrigen);
            Controls.Add(lbAerolinea);
            Controls.Add(lbDestino);
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
            Name = "FrmVuelo";
            Text = "Gestion de Vuelos";
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
        private Label lbDestino;
        private Label lbAerolinea;
        private Label LabOrigen;
        private TextBox textID;
        private TextBox texDestino;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lbEstado;
        private Label lbhoradelle;
        private Label lbHorasali;
        private Label lbFecha;
        private DateTimePicker DTPFecha;
        private DateTimePicker DTPhoradelle;
        private DateTimePicker dateTimePicker3;
        private ComboBox comboBox1;
    }
}