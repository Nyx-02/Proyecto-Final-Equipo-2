namespace Frontend
{
    partial class FrmAvion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAvion));
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
            lbmodelo = new Label();
            lbcapacidad = new Label();
            Labfabricante = new Label();
            textID = new TextBox();
            texmodelo = new TextBox();
            texfabricante = new TextBox();
            lbmatricula = new Label();
            lbestado = new Label();
            lbfabricacion = new Label();
            texmatricula = new TextBox();
            lbmotoro = new Label();
            nupdCapacidad = new NumericUpDown();
            cbEstado = new ComboBox();
            cbmotor = new ComboBox();
            dtpfabricacion = new DateTimePicker();
            lbdata = new Label();
            Butdata = new Button();
            dgvDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picboxlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupdCapacidad).BeginInit();
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
            LabelTitulo.Text = "Gestion de Aviones";
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
            // lbmodelo
            // 
            lbmodelo.BackColor = Color.LightSkyBlue;
            lbmodelo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbmodelo.Location = new Point(189, 169);
            lbmodelo.Name = "lbmodelo";
            lbmodelo.Size = new Size(61, 21);
            lbmodelo.TabIndex = 15;
            lbmodelo.Text = "Modelo:";
            lbmodelo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbcapacidad
            // 
            lbcapacidad.BackColor = Color.LightSkyBlue;
            lbcapacidad.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbcapacidad.Location = new Point(179, 211);
            lbcapacidad.Name = "lbcapacidad";
            lbcapacidad.Size = new Size(71, 21);
            lbcapacidad.TabIndex = 16;
            lbcapacidad.Text = "Capacidad:";
            lbcapacidad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Labfabricante
            // 
            Labfabricante.BackColor = Color.LightSkyBlue;
            Labfabricante.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Labfabricante.Location = new Point(174, 253);
            Labfabricante.Name = "Labfabricante";
            Labfabricante.Size = new Size(76, 21);
            Labfabricante.TabIndex = 17;
            Labfabricante.Text = "Fabricante:";
            Labfabricante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textID
            // 
            textID.Location = new Point(256, 125);
            textID.Name = "textID";
            textID.Size = new Size(100, 23);
            textID.TabIndex = 18;
            // 
            // texmodelo
            // 
            texmodelo.Location = new Point(256, 170);
            texmodelo.Name = "texmodelo";
            texmodelo.Size = new Size(100, 23);
            texmodelo.TabIndex = 19;
            // 
            // texfabricante
            // 
            texfabricante.Location = new Point(256, 254);
            texfabricante.Name = "texfabricante";
            texfabricante.Size = new Size(100, 23);
            texfabricante.TabIndex = 20;
            // 
            // lbmatricula
            // 
            lbmatricula.BackColor = Color.LightSkyBlue;
            lbmatricula.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbmatricula.Location = new Point(386, 213);
            lbmatricula.Name = "lbmatricula";
            lbmatricula.Size = new Size(69, 21);
            lbmatricula.TabIndex = 22;
            lbmatricula.Text = "Matricula:";
            lbmatricula.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbestado
            // 
            lbestado.BackColor = Color.LightSkyBlue;
            lbestado.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbestado.Location = new Point(386, 169);
            lbestado.Name = "lbestado";
            lbestado.Size = new Size(69, 21);
            lbestado.TabIndex = 24;
            lbestado.Text = "Estado:";
            lbestado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbfabricacion
            // 
            lbfabricacion.BackColor = Color.LightSkyBlue;
            lbfabricacion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbfabricacion.Location = new Point(386, 127);
            lbfabricacion.Name = "lbfabricacion";
            lbfabricacion.Size = new Size(125, 21);
            lbfabricacion.TabIndex = 25;
            lbfabricacion.Text = "Año de Fabricacion:";
            lbfabricacion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // texmatricula
            // 
            texmatricula.Location = new Point(461, 214);
            texmatricula.Name = "texmatricula";
            texmatricula.Size = new Size(100, 23);
            texmatricula.TabIndex = 29;
            // 
            // lbmotoro
            // 
            lbmotoro.BackColor = Color.LightSkyBlue;
            lbmotoro.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbmotoro.Location = new Point(386, 256);
            lbmotoro.Name = "lbmotoro";
            lbmotoro.Size = new Size(97, 21);
            lbmotoro.TabIndex = 32;
            lbmotoro.Text = "Tipo de Motor:";
            lbmotoro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nupdCapacidad
            // 
            nupdCapacidad.Location = new Point(256, 213);
            nupdCapacidad.Name = "nupdCapacidad";
            nupdCapacidad.Size = new Size(100, 23);
            nupdCapacidad.TabIndex = 34;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Operativo", "En Mantenimiento", "Retirado" });
            cbEstado.Location = new Point(461, 170);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(121, 23);
            cbEstado.TabIndex = 36;
            // 
            // cbmotor
            // 
            cbmotor.FormattingEnabled = true;
            cbmotor.Items.AddRange(new object[] { "Turbofan ", "Turbohélice", "Pistón" });
            cbmotor.Location = new Point(489, 257);
            cbmotor.Name = "cbmotor";
            cbmotor.Size = new Size(121, 23);
            cbmotor.TabIndex = 37;
            // 
            // dtpfabricacion
            // 
            dtpfabricacion.Format = DateTimePickerFormat.Custom;
            dtpfabricacion.Location = new Point(517, 125);
            dtpfabricacion.Name = "dtpfabricacion";
            dtpfabricacion.Size = new Size(200, 23);
            dtpfabricacion.TabIndex = 38;
            // 
            // lbdata
            // 
            lbdata.BackColor = Color.LightSkyBlue;
            lbdata.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbdata.Location = new Point(689, 410);
            lbdata.Name = "lbdata";
            lbdata.Size = new Size(97, 21);
            lbdata.TabIndex = 46;
            lbdata.Text = "DataGridView";
            lbdata.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Butdata
            // 
            Butdata.BackgroundImage = (Image)resources.GetObject("Butdata.BackgroundImage");
            Butdata.FlatStyle = FlatStyle.Flat;
            Butdata.Image = (Image)resources.GetObject("Butdata.Image");
            Butdata.Location = new Point(706, 354);
            Butdata.Name = "Butdata";
            Butdata.Size = new Size(56, 53);
            Butdata.TabIndex = 45;
            Butdata.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(731, 378);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(10, 10);
            dgvDatos.TabIndex = 44;
            // 
            // FrmAvion
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
            Controls.Add(dtpfabricacion);
            Controls.Add(cbmotor);
            Controls.Add(cbEstado);
            Controls.Add(nupdCapacidad);
            Controls.Add(lbmotoro);
            Controls.Add(texmatricula);
            Controls.Add(lbfabricacion);
            Controls.Add(lbestado);
            Controls.Add(lbmatricula);
            Controls.Add(texfabricante);
            Controls.Add(texmodelo);
            Controls.Add(textID);
            Controls.Add(Labfabricante);
            Controls.Add(lbcapacidad);
            Controls.Add(lbmodelo);
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
            Name = "FrmAvion";
            Text = "Gestion de Aviones";
            ((System.ComponentModel.ISupportInitialize)picboxlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupdCapacidad).EndInit();
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
        private Label lbmodelo;
        private Label lbcapacidad;
        private Label Labfabricante;
        private TextBox textID;
        private TextBox texmodelo;
        private TextBox texfabricante;
        private Label lbmatricula;
        private Label lbIngreso;
        private Label lbestado;
        private Label lbfabricacion;
        private DateTimePicker DTPfechadeingreso;
        private TextBox texmatricula;
        private Label lbmotoro;
        private NumericUpDown nupdCapacidad;
        private ComboBox cbEstado;
        private ComboBox cbmotor;
        private DateTimePicker dtpfabricacion;
        private Label lbdata;
        private Button Butdata;
        private DataGridView dgvDatos;
    }
}