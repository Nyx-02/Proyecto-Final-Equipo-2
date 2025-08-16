namespace Frontend
{
    partial class FrmPuertaEmbarque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPuertaEmbarque));
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
            idnumero = new Label();
            lbterminal = new Label();
            labubicacion = new Label();
            textID = new TextBox();
            texnumero = new TextBox();
            texubicacion = new TextBox();
            lbEstado = new Label();
            lbhoracierre = new Label();
            lbHoraarpe = new Label();
            DTPcierre = new DateTimePicker();
            DTPapertura = new DateTimePicker();
            comboBox1 = new ComboBox();
            cbterminal = new ComboBox();
            lbcapacidad = new Label();
            nupdCapacidad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)picboxlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupdCapacidad).BeginInit();
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
            LabelTitulo.Location = new Point(233, 34);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(340, 39);
            LabelTitulo.TabIndex = 12;
            LabelTitulo.Text = "Gestion de Puerta de Embarque";
            // 
            // lbId
            // 
            lbId.BackColor = Color.LightSkyBlue;
            lbId.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbId.Location = new Point(189, 133);
            lbId.Name = "lbId";
            lbId.Size = new Size(56, 21);
            lbId.TabIndex = 13;
            lbId.Text = "ID:";
            lbId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // idnumero
            // 
            idnumero.BackColor = Color.LightSkyBlue;
            idnumero.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            idnumero.Location = new Point(175, 175);
            idnumero.Name = "idnumero";
            idnumero.Size = new Size(70, 21);
            idnumero.TabIndex = 15;
            idnumero.Text = "Numero:";
            idnumero.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbterminal
            // 
            lbterminal.BackColor = Color.LightSkyBlue;
            lbterminal.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbterminal.Location = new Point(175, 217);
            lbterminal.Name = "lbterminal";
            lbterminal.Size = new Size(70, 21);
            lbterminal.TabIndex = 16;
            lbterminal.Text = "Terminal:";
            lbterminal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labubicacion
            // 
            labubicacion.BackColor = Color.LightSkyBlue;
            labubicacion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labubicacion.Location = new Point(392, 175);
            labubicacion.Name = "labubicacion";
            labubicacion.Size = new Size(74, 21);
            labubicacion.TabIndex = 17;
            labubicacion.Text = "Ubicacion:";
            labubicacion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textID
            // 
            textID.Location = new Point(251, 131);
            textID.Name = "textID";
            textID.Size = new Size(100, 23);
            textID.TabIndex = 18;
            // 
            // texnumero
            // 
            texnumero.Location = new Point(251, 176);
            texnumero.Name = "texnumero";
            texnumero.Size = new Size(100, 23);
            texnumero.TabIndex = 19;
            // 
            // texubicacion
            // 
            texubicacion.Location = new Point(472, 173);
            texubicacion.Name = "texubicacion";
            texubicacion.Size = new Size(100, 23);
            texubicacion.TabIndex = 20;
            // 
            // lbEstado
            // 
            lbEstado.BackColor = Color.LightSkyBlue;
            lbEstado.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbEstado.Location = new Point(189, 255);
            lbEstado.Name = "lbEstado";
            lbEstado.Size = new Size(56, 21);
            lbEstado.TabIndex = 22;
            lbEstado.Text = "Estado:";
            lbEstado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbhoracierre
            // 
            lbhoracierre.BackColor = Color.LightSkyBlue;
            lbhoracierre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbhoracierre.Location = new Point(392, 257);
            lbhoracierre.Name = "lbhoracierre";
            lbhoracierre.Size = new Size(74, 21);
            lbhoracierre.TabIndex = 23;
            lbhoracierre.Text = "Cierre:";
            lbhoracierre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbHoraarpe
            // 
            lbHoraarpe.BackColor = Color.LightSkyBlue;
            lbHoraarpe.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbHoraarpe.Location = new Point(392, 219);
            lbHoraarpe.Name = "lbHoraarpe";
            lbHoraarpe.Size = new Size(74, 21);
            lbHoraarpe.TabIndex = 24;
            lbHoraarpe.Text = "Apertura:";
            lbHoraarpe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DTPcierre
            // 
            DTPcierre.Location = new Point(472, 257);
            DTPcierre.Name = "DTPcierre";
            DTPcierre.Size = new Size(200, 23);
            DTPcierre.TabIndex = 27;
            // 
            // DTPapertura
            // 
            DTPapertura.Location = new Point(472, 219);
            DTPapertura.Name = "DTPapertura";
            DTPapertura.Size = new Size(200, 23);
            DTPapertura.TabIndex = 28;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Disponible", "Ocupada", "Mantenimiento" });
            comboBox1.Location = new Point(251, 255);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 29;
            // 
            // cbterminal
            // 
            cbterminal.FormattingEnabled = true;
            cbterminal.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cbterminal.Location = new Point(251, 217);
            cbterminal.Name = "cbterminal";
            cbterminal.Size = new Size(100, 23);
            cbterminal.TabIndex = 30;
            // 
            // lbcapacidad
            // 
            lbcapacidad.BackColor = Color.LightSkyBlue;
            lbcapacidad.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbcapacidad.Location = new Point(392, 133);
            lbcapacidad.Name = "lbcapacidad";
            lbcapacidad.Size = new Size(74, 21);
            lbcapacidad.TabIndex = 31;
            lbcapacidad.Text = "Capacidad:";
            lbcapacidad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nupdCapacidad
            // 
            nupdCapacidad.Location = new Point(472, 135);
            nupdCapacidad.Name = "nupdCapacidad";
            nupdCapacidad.Size = new Size(120, 23);
            nupdCapacidad.TabIndex = 32;
            // 
            // FrmPuertaEmbarque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(nupdCapacidad);
            Controls.Add(lbcapacidad);
            Controls.Add(cbterminal);
            Controls.Add(comboBox1);
            Controls.Add(DTPapertura);
            Controls.Add(DTPcierre);
            Controls.Add(lbHoraarpe);
            Controls.Add(lbhoracierre);
            Controls.Add(lbEstado);
            Controls.Add(texubicacion);
            Controls.Add(texnumero);
            Controls.Add(textID);
            Controls.Add(labubicacion);
            Controls.Add(lbterminal);
            Controls.Add(idnumero);
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
            Name = "FrmPuertaEmbarque";
            Text = "Gestion de Puerta de Embarque";
            ((System.ComponentModel.ISupportInitialize)picboxlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupdCapacidad).EndInit();
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
        private Label idnumero;
        private Label lbterminal;
        private Label labubicacion;
        private TextBox textID;
        private TextBox texnumero;
        private TextBox texubicacion;
        private Label lbEstado;
        private Label lbhoracierre;
        private Label lbHoraarpe;
        private DateTimePicker DTPcierre;
        private DateTimePicker DTPapertura;
        private ComboBox comboBox1;
        private ComboBox cbterminal;
        private Label lbcapacidad;
        private NumericUpDown nupdCapacidad;
    }
}