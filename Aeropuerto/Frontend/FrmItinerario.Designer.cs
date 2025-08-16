namespace Frontend
{
    partial class FrmItinerario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItinerario));
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
            lbvuelo = new Label();
            idactividades = new Label();
            lbfechadefin = new Label();
            textID = new TextBox();
            texvuelo = new TextBox();
            ibescalas = new Label();
            ibobservaciones = new Label();
            lbfechadeinicio = new Label();
            lbestado = new Label();
            cbestado = new ComboBox();
            texempleado = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            DTPfechadeinicio = new DateTimePicker();
            texescalas = new TextBox();
            texobservaciones = new TextBox();
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
            LabelTitulo.Text = "Gestion de Itinerario";
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
            // lbvuelo
            // 
            lbvuelo.BackColor = Color.LightSkyBlue;
            lbvuelo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbvuelo.Location = new Point(169, 169);
            lbvuelo.Name = "lbvuelo";
            lbvuelo.Size = new Size(81, 21);
            lbvuelo.TabIndex = 15;
            lbvuelo.Text = "ID Vuelo:";
            lbvuelo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // idactividades
            // 
            idactividades.BackColor = Color.LightSkyBlue;
            idactividades.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            idactividades.Location = new Point(161, 211);
            idactividades.Name = "idactividades";
            idactividades.Size = new Size(89, 21);
            idactividades.TabIndex = 16;
            idactividades.Text = "Actividades:";
            idactividades.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbfechadefin
            // 
            lbfechadefin.BackColor = Color.LightSkyBlue;
            lbfechadefin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbfechadefin.Location = new Point(386, 127);
            lbfechadefin.Name = "lbfechadefin";
            lbfechadefin.Size = new Size(87, 21);
            lbfechadefin.TabIndex = 17;
            lbfechadefin.Text = "Fecha de Fin:";
            lbfechadefin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textID
            // 
            textID.Location = new Point(256, 125);
            textID.Name = "textID";
            textID.Size = new Size(100, 23);
            textID.TabIndex = 18;
            // 
            // texvuelo
            // 
            texvuelo.Location = new Point(256, 170);
            texvuelo.Name = "texvuelo";
            texvuelo.Size = new Size(100, 23);
            texvuelo.TabIndex = 19;
            // 
            // ibescalas
            // 
            ibescalas.BackColor = Color.LightSkyBlue;
            ibescalas.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ibescalas.Location = new Point(386, 172);
            ibescalas.Name = "ibescalas";
            ibescalas.Size = new Size(74, 21);
            ibescalas.TabIndex = 22;
            ibescalas.Text = "Escalas:";
            ibescalas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ibobservaciones
            // 
            ibobservaciones.BackColor = Color.LightSkyBlue;
            ibobservaciones.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ibobservaciones.Location = new Point(391, 213);
            ibobservaciones.Name = "ibobservaciones";
            ibobservaciones.Size = new Size(98, 21);
            ibobservaciones.TabIndex = 24;
            ibobservaciones.Text = "Observaciones:";
            ibobservaciones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbfechadeinicio
            // 
            lbfechadeinicio.BackColor = Color.LightSkyBlue;
            lbfechadeinicio.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbfechadeinicio.Location = new Point(103, 256);
            lbfechadeinicio.Name = "lbfechadeinicio";
            lbfechadeinicio.Size = new Size(114, 21);
            lbfechadeinicio.TabIndex = 25;
            lbfechadeinicio.Text = "Fecha de Inicio:";
            lbfechadeinicio.TextAlign = ContentAlignment.MiddleCenter;
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
            cbestado.Items.AddRange(new object[] { "Activo ", "Cancelado" });
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(479, 127);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(182, 23);
            dateTimePicker1.TabIndex = 39;
            // 
            // DTPfechadeinicio
            // 
            DTPfechadeinicio.Location = new Point(223, 256);
            DTPfechadeinicio.Name = "DTPfechadeinicio";
            DTPfechadeinicio.Size = new Size(157, 23);
            DTPfechadeinicio.TabIndex = 40;
            // 
            // texescalas
            // 
            texescalas.Location = new Point(461, 172);
            texescalas.Name = "texescalas";
            texescalas.Size = new Size(100, 23);
            texescalas.TabIndex = 41;
            // 
            // texobservaciones
            // 
            texobservaciones.Location = new Point(495, 214);
            texobservaciones.Name = "texobservaciones";
            texobservaciones.Size = new Size(100, 23);
            texobservaciones.TabIndex = 42;
            // 
            // FrmItinerario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(texobservaciones);
            Controls.Add(texescalas);
            Controls.Add(DTPfechadeinicio);
            Controls.Add(dateTimePicker1);
            Controls.Add(texempleado);
            Controls.Add(cbestado);
            Controls.Add(lbestado);
            Controls.Add(lbfechadeinicio);
            Controls.Add(ibobservaciones);
            Controls.Add(ibescalas);
            Controls.Add(texvuelo);
            Controls.Add(textID);
            Controls.Add(lbfechadefin);
            Controls.Add(idactividades);
            Controls.Add(lbvuelo);
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
            Name = "FrmItinerario";
            Text = "Gestion de Itinerario";
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
        private Label lbvuelo;
        private Label idactividades;
        private Label lbfechadefin;
        private TextBox textID;
        private TextBox texvuelo;
        private Label ibescalas;
        private Label lbIngreso;
        private Label ibobservaciones;
        private Label lbfechadeinicio;
        private DateTimePicker DTPfechadeingreso;
        private Label lbestado;
        private ComboBox cbestado;
        private TextBox texempleado;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker DTPfechadeinicio;
        private TextBox texescalas;
        private TextBox texobservaciones;
    }
}