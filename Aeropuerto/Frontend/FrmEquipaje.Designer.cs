namespace Frontend
{
    partial class FrmEquipaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEquipaje));
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
            lbpeso = new Label();
            labdimesiones = new Label();
            textID = new TextBox();
            texpasajero = new TextBox();
            texdimensiones = new TextBox();
            lbetiqueta = new Label();
            lbestado = new Label();
            texetiqueta = new TextBox();
            lbtipo = new Label();
            nupdpeso = new NumericUpDown();
            cbEstado = new ComboBox();
            cbtipo = new ComboBox();
            texcolor = new TextBox();
            lbcolor = new Label();
            ((System.ComponentModel.ISupportInitialize)picboxlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupdpeso).BeginInit();
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
            LabelTitulo.Text = "Gestion de Equipaje";
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
            lbpasajero.Location = new Point(162, 169);
            lbpasajero.Name = "lbpasajero";
            lbpasajero.Size = new Size(88, 21);
            lbpasajero.TabIndex = 15;
            lbpasajero.Text = "ID Pasajero:";
            lbpasajero.TextAlign = ContentAlignment.MiddleCenter;
            lbpasajero.Click += lbDestino_Click;
            // 
            // lbpeso
            // 
            lbpeso.BackColor = Color.LightSkyBlue;
            lbpeso.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbpeso.Location = new Point(194, 211);
            lbpeso.Name = "lbpeso";
            lbpeso.Size = new Size(56, 21);
            lbpeso.TabIndex = 16;
            lbpeso.Text = "Peso:";
            lbpeso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labdimesiones
            // 
            labdimesiones.BackColor = Color.LightSkyBlue;
            labdimesiones.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labdimesiones.Location = new Point(386, 172);
            labdimesiones.Name = "labdimesiones";
            labdimesiones.Size = new Size(87, 21);
            labdimesiones.TabIndex = 17;
            labdimesiones.Text = "Dimensiones:";
            labdimesiones.TextAlign = ContentAlignment.MiddleCenter;
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
            // texdimensiones
            // 
            texdimensiones.Location = new Point(479, 170);
            texdimensiones.Name = "texdimensiones";
            texdimensiones.Size = new Size(100, 23);
            texdimensiones.TabIndex = 20;
            // 
            // lbetiqueta
            // 
            lbetiqueta.BackColor = Color.LightSkyBlue;
            lbetiqueta.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbetiqueta.Location = new Point(386, 213);
            lbetiqueta.Name = "lbetiqueta";
            lbetiqueta.Size = new Size(69, 21);
            lbetiqueta.TabIndex = 22;
            lbetiqueta.Text = "Etiqueta:";
            lbetiqueta.TextAlign = ContentAlignment.MiddleCenter;
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
            // texetiqueta
            // 
            texetiqueta.Location = new Point(461, 214);
            texetiqueta.Name = "texetiqueta";
            texetiqueta.Size = new Size(100, 23);
            texetiqueta.TabIndex = 29;
            // 
            // lbtipo
            // 
            lbtipo.BackColor = Color.LightSkyBlue;
            lbtipo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbtipo.Location = new Point(194, 252);
            lbtipo.Name = "lbtipo";
            lbtipo.Size = new Size(56, 21);
            lbtipo.TabIndex = 32;
            lbtipo.Text = "Tipo:";
            lbtipo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nupdpeso
            // 
            nupdpeso.Location = new Point(256, 213);
            nupdpeso.Name = "nupdpeso";
            nupdpeso.Size = new Size(100, 23);
            nupdpeso.TabIndex = 34;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Registrado", "En Tránsito", "Extraviado", "Entregado" });
            cbEstado.Location = new Point(461, 254);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(121, 23);
            cbEstado.TabIndex = 36;
            // 
            // cbtipo
            // 
            cbtipo.FormattingEnabled = true;
            cbtipo.Items.AddRange(new object[] { "Mano", "Facturado", "Especial" });
            cbtipo.Location = new Point(256, 253);
            cbtipo.Name = "cbtipo";
            cbtipo.Size = new Size(100, 23);
            cbtipo.TabIndex = 37;
            // 
            // texcolor
            // 
            texcolor.Location = new Point(468, 128);
            texcolor.Name = "texcolor";
            texcolor.Size = new Size(100, 23);
            texcolor.TabIndex = 39;
            // 
            // lbcolor
            // 
            lbcolor.BackColor = Color.LightSkyBlue;
            lbcolor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbcolor.Location = new Point(386, 127);
            lbcolor.Name = "lbcolor";
            lbcolor.Size = new Size(76, 21);
            lbcolor.TabIndex = 38;
            lbcolor.Text = "Color:";
            lbcolor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmEquipaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(texcolor);
            Controls.Add(lbcolor);
            Controls.Add(cbtipo);
            Controls.Add(cbEstado);
            Controls.Add(nupdpeso);
            Controls.Add(lbtipo);
            Controls.Add(texetiqueta);
            Controls.Add(lbestado);
            Controls.Add(lbetiqueta);
            Controls.Add(texdimensiones);
            Controls.Add(texpasajero);
            Controls.Add(textID);
            Controls.Add(labdimesiones);
            Controls.Add(lbpeso);
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
            Name = "FrmEquipaje";
            Text = "Gestion de Equipaje";
            Load += FrmVuelo_Load;
            ((System.ComponentModel.ISupportInitialize)picboxlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupdpeso).EndInit();
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
        private Label lbpeso;
        private Label labdimesiones;
        private TextBox textID;
        private TextBox texpasajero;
        private TextBox texdimensiones;
        private Label lbetiqueta;
        private Label lbIngreso;
        private Label lbestado;
        private DateTimePicker DTPfechadeingreso;
        private TextBox texetiqueta;
        private Label lbtipo;
        private NumericUpDown nupdpeso;
        private ComboBox cbEstado;
        private ComboBox cbtipo;
        private TextBox texcolor;
        private Label lbcolor;
    }
}