namespace Frontend
{
    partial class FrmAerolinea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAerolinea));
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
            lbpais = new Label();
            Labtelefono = new Label();
            textID = new TextBox();
            texnombre = new TextBox();
            textelefono = new TextBox();
            texpais = new TextBox();
            lbemail = new Label();
            lbdirecion = new Label();
            lbsitiowb = new Label();
            texsitioweb = new TextBox();
            texemail = new TextBox();
            texcodigo = new TextBox();
            labcodigoiata = new Label();
            texdireccion = new TextBox();
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
            LabelTitulo.Text = "Gestion de Aerolineas";
            LabelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbId
            // 
            lbId.BackColor = Color.LightSkyBlue;
            lbId.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbId.Location = new Point(218, 133);
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
            lbNombre.Location = new Point(213, 175);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(61, 21);
            lbNombre.TabIndex = 15;
            lbNombre.Text = "Nombre:";
            lbNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbpais
            // 
            lbpais.BackColor = Color.LightSkyBlue;
            lbpais.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbpais.Location = new Point(213, 217);
            lbpais.Name = "lbpais";
            lbpais.Size = new Size(61, 21);
            lbpais.TabIndex = 16;
            lbpais.Text = "Pais:";
            lbpais.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Labtelefono
            // 
            Labtelefono.BackColor = Color.LightSkyBlue;
            Labtelefono.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Labtelefono.Location = new Point(208, 259);
            Labtelefono.Name = "Labtelefono";
            Labtelefono.Size = new Size(66, 21);
            Labtelefono.TabIndex = 17;
            Labtelefono.Text = "Telefono:";
            Labtelefono.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textID
            // 
            textID.Location = new Point(280, 131);
            textID.Name = "textID";
            textID.Size = new Size(100, 23);
            textID.TabIndex = 18;
            // 
            // texnombre
            // 
            texnombre.Location = new Point(280, 176);
            texnombre.Name = "texnombre";
            texnombre.Size = new Size(100, 23);
            texnombre.TabIndex = 19;
            // 
            // textelefono
            // 
            textelefono.Location = new Point(280, 260);
            textelefono.Name = "textelefono";
            textelefono.Size = new Size(100, 23);
            textelefono.TabIndex = 20;
            // 
            // texpais
            // 
            texpais.Location = new Point(280, 217);
            texpais.Name = "texpais";
            texpais.Size = new Size(100, 23);
            texpais.TabIndex = 21;
            // 
            // lbemail
            // 
            lbemail.BackColor = Color.LightSkyBlue;
            lbemail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbemail.Location = new Point(410, 131);
            lbemail.Name = "lbemail";
            lbemail.Size = new Size(69, 21);
            lbemail.TabIndex = 22;
            lbemail.Text = "Email:";
            lbemail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbdirecion
            // 
            lbdirecion.BackColor = Color.LightSkyBlue;
            lbdirecion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbdirecion.Location = new Point(410, 175);
            lbdirecion.Name = "lbdirecion";
            lbdirecion.Size = new Size(69, 21);
            lbdirecion.TabIndex = 24;
            lbdirecion.Text = "Direccion:";
            lbdirecion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbsitiowb
            // 
            lbsitiowb.BackColor = Color.LightSkyBlue;
            lbsitiowb.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbsitiowb.Location = new Point(410, 219);
            lbsitiowb.Name = "lbsitiowb";
            lbsitiowb.Size = new Size(69, 21);
            lbsitiowb.TabIndex = 25;
            lbsitiowb.Text = "SitioWeb:";
            lbsitiowb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // texsitioweb
            // 
            texsitioweb.Location = new Point(485, 220);
            texsitioweb.Name = "texsitioweb";
            texsitioweb.Size = new Size(100, 23);
            texsitioweb.TabIndex = 28;
            // 
            // texemail
            // 
            texemail.Location = new Point(485, 130);
            texemail.Name = "texemail";
            texemail.Size = new Size(100, 23);
            texemail.TabIndex = 29;
            // 
            // texcodigo
            // 
            texcodigo.Location = new Point(502, 264);
            texcodigo.Name = "texcodigo";
            texcodigo.Size = new Size(100, 23);
            texcodigo.TabIndex = 32;
            // 
            // labcodigoiata
            // 
            labcodigoiata.BackColor = Color.LightSkyBlue;
            labcodigoiata.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labcodigoiata.Location = new Point(410, 264);
            labcodigoiata.Name = "labcodigoiata";
            labcodigoiata.Size = new Size(86, 21);
            labcodigoiata.TabIndex = 31;
            labcodigoiata.Text = "CodigoIATA: ";
            labcodigoiata.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // texdireccion
            // 
            texdireccion.Location = new Point(485, 173);
            texdireccion.Name = "texdireccion";
            texdireccion.Size = new Size(100, 23);
            texdireccion.TabIndex = 33;
            // 
            // lbdata
            // 
            lbdata.BackColor = Color.LightSkyBlue;
            lbdata.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbdata.Location = new Point(689, 410);
            lbdata.Name = "lbdata";
            lbdata.Size = new Size(97, 21);
            lbdata.TabIndex = 70;
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
            Butdata.TabIndex = 69;
            Butdata.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(731, 378);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(10, 10);
            dgvDatos.TabIndex = 68;
            // 
            // FrmAerolinea
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
            Controls.Add(texdireccion);
            Controls.Add(texcodigo);
            Controls.Add(labcodigoiata);
            Controls.Add(texemail);
            Controls.Add(texsitioweb);
            Controls.Add(lbsitiowb);
            Controls.Add(lbdirecion);
            Controls.Add(lbemail);
            Controls.Add(texpais);
            Controls.Add(textelefono);
            Controls.Add(texnombre);
            Controls.Add(textID);
            Controls.Add(Labtelefono);
            Controls.Add(lbpais);
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
            Name = "FrmAerolinea";
            Text = "Gestion de Aerolineas";
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
        private Label lbpais;
        private Label Labtelefono;
        private TextBox textID;
        private TextBox texnombre;
        private TextBox texpais;
        private Label lbemail;
        private Label lbdirecion;
        private Label lbsitiowb;
        private TextBox texsitioweb;
        private TextBox texemail;
        private TextBox textelefono;
        private TextBox texcodigo;
        private Label labcodigoiata;
        private TextBox texdireccion;
        private Label lbdata;
        private Button Butdata;
        private DataGridView dgvDatos;
    }
}