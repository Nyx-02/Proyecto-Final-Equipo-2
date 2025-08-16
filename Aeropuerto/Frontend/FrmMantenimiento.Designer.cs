namespace Frontend
{
    partial class FrmMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimiento));
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
            idavion = new Label();
            lbestado = new Label();
            lbcosto = new Label();
            textID = new TextBox();
            texavion = new TextBox();
            lbmantenimiento = new Label();
            lbfecha = new Label();
            lbresponsable = new Label();
            DTPfecha = new DateTimePicker();
            cbmantenimiento = new ComboBox();
            cbestado = new ComboBox();
            lbdescripcion = new Label();
            texdescripcion = new TextBox();
            nupdcosto = new NumericUpDown();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picboxlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupdcosto).BeginInit();
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
            LabelTitulo.Text = "Gestion de Mantenimiento";
            LabelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbId
            // 
            lbId.BackColor = Color.LightSkyBlue;
            lbId.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbId.Location = new Point(209, 137);
            lbId.Name = "lbId";
            lbId.Size = new Size(56, 21);
            lbId.TabIndex = 13;
            lbId.Text = "ID:";
            lbId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // idavion
            // 
            idavion.BackColor = Color.LightSkyBlue;
            idavion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            idavion.Location = new Point(195, 179);
            idavion.Name = "idavion";
            idavion.Size = new Size(70, 21);
            idavion.TabIndex = 15;
            idavion.Text = "ID Avion:";
            idavion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbestado
            // 
            lbestado.BackColor = Color.LightSkyBlue;
            lbestado.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbestado.Location = new Point(396, 254);
            lbestado.Name = "lbestado";
            lbestado.Size = new Size(70, 21);
            lbestado.TabIndex = 16;
            lbestado.Text = "Estado:";
            lbestado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbcosto
            // 
            lbcosto.BackColor = Color.LightSkyBlue;
            lbcosto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbcosto.Location = new Point(392, 175);
            lbcosto.Name = "lbcosto";
            lbcosto.Size = new Size(74, 21);
            lbcosto.TabIndex = 17;
            lbcosto.Text = "Costo:";
            lbcosto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textID
            // 
            textID.Location = new Point(271, 135);
            textID.Name = "textID";
            textID.Size = new Size(100, 23);
            textID.TabIndex = 18;
            // 
            // texavion
            // 
            texavion.Location = new Point(271, 180);
            texavion.Name = "texavion";
            texavion.Size = new Size(100, 23);
            texavion.TabIndex = 19;
            // 
            // lbmantenimiento
            // 
            lbmantenimiento.BackColor = Color.LightSkyBlue;
            lbmantenimiento.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbmantenimiento.Location = new Point(88, 255);
            lbmantenimiento.Name = "lbmantenimiento";
            lbmantenimiento.Size = new Size(157, 21);
            lbmantenimiento.TabIndex = 22;
            lbmantenimiento.Text = "Tipo de Mantenimiento:";
            lbmantenimiento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbfecha
            // 
            lbfecha.BackColor = Color.LightSkyBlue;
            lbfecha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbfecha.Location = new Point(99, 221);
            lbfecha.Name = "lbfecha";
            lbfecha.Size = new Size(74, 21);
            lbfecha.TabIndex = 23;
            lbfecha.Text = "Fecha:";
            lbfecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbresponsable
            // 
            lbresponsable.BackColor = Color.LightSkyBlue;
            lbresponsable.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbresponsable.Location = new Point(380, 221);
            lbresponsable.Name = "lbresponsable";
            lbresponsable.Size = new Size(94, 21);
            lbresponsable.TabIndex = 24;
            lbresponsable.Text = "Responsable:";
            lbresponsable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DTPfecha
            // 
            DTPfecha.Location = new Point(179, 221);
            DTPfecha.Name = "DTPfecha";
            DTPfecha.Size = new Size(193, 23);
            DTPfecha.TabIndex = 27;
            // 
            // cbmantenimiento
            // 
            cbmantenimiento.FormattingEnabled = true;
            cbmantenimiento.Items.AddRange(new object[] { "Preventivo", "Correctivo", "Inspección" });
            cbmantenimiento.Location = new Point(251, 255);
            cbmantenimiento.Name = "cbmantenimiento";
            cbmantenimiento.Size = new Size(121, 23);
            cbmantenimiento.TabIndex = 29;
            // 
            // cbestado
            // 
            cbestado.FormattingEnabled = true;
            cbestado.Items.AddRange(new object[] { "Programado", "En Proceso", "Completado" });
            cbestado.Location = new Point(472, 254);
            cbestado.Name = "cbestado";
            cbestado.Size = new Size(100, 23);
            cbestado.TabIndex = 30;
            // 
            // lbdescripcion
            // 
            lbdescripcion.BackColor = Color.LightSkyBlue;
            lbdescripcion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbdescripcion.Location = new Point(392, 133);
            lbdescripcion.Name = "lbdescripcion";
            lbdescripcion.Size = new Size(82, 21);
            lbdescripcion.TabIndex = 31;
            lbdescripcion.Text = "Descripcion:";
            lbdescripcion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // texdescripcion
            // 
            texdescripcion.Location = new Point(480, 134);
            texdescripcion.Name = "texdescripcion";
            texdescripcion.Size = new Size(100, 23);
            texdescripcion.TabIndex = 32;
            // 
            // nupdcosto
            // 
            nupdcosto.Location = new Point(460, 177);
            nupdcosto.Name = "nupdcosto";
            nupdcosto.Size = new Size(120, 23);
            nupdcosto.TabIndex = 33;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(480, 219);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 34;
            // 
            // FrmMantenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(nupdcosto);
            Controls.Add(texdescripcion);
            Controls.Add(lbdescripcion);
            Controls.Add(cbestado);
            Controls.Add(cbmantenimiento);
            Controls.Add(DTPfecha);
            Controls.Add(lbresponsable);
            Controls.Add(lbfecha);
            Controls.Add(lbmantenimiento);
            Controls.Add(texavion);
            Controls.Add(textID);
            Controls.Add(lbcosto);
            Controls.Add(lbestado);
            Controls.Add(idavion);
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
            Name = "FrmMantenimiento";
            Text = "Gestion de Mantenimiento";
            ((System.ComponentModel.ISupportInitialize)picboxlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupdcosto).EndInit();
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
        private Label idavion;
        private Label lbestado;
        private Label lbcosto;
        private TextBox textID;
        private TextBox texavion;
        private Label lbmantenimiento;
        private Label lbfecha;
        private Label lbresponsable;
        private DateTimePicker DTPfecha;
        private ComboBox cbmantenimiento;
        private ComboBox cbestado;
        private Label lbdescripcion;
        private TextBox texdescripcion;
        private NumericUpDown nupdcosto;
        private TextBox textBox1;
    }
}