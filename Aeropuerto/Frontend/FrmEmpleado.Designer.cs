namespace Frontend
{
    partial class FrmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
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
            LabCargo = new Label();
            textID = new TextBox();
            texDestino = new TextBox();
            texCargo = new TextBox();
            textBox4 = new TextBox();
            lbemail = new Label();
            lbIngreso = new Label();
            lbturno = new Label();
            lbSalario = new Label();
            DTPfechadeingreso = new DateTimePicker();
            textBox2 = new TextBox();
            nupdsalario = new NumericUpDown();
            cbturno = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picboxlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupdsalario).BeginInit();
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
            LabelTitulo.Text = "Gestion de Empleados";
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
            // LabCargo
            // 
            LabCargo.BackColor = Color.LightSkyBlue;
            LabCargo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LabCargo.Location = new Point(189, 253);
            LabCargo.Name = "LabCargo";
            LabCargo.Size = new Size(61, 21);
            LabCargo.TabIndex = 17;
            LabCargo.Text = "Cargo:";
            LabCargo.TextAlign = ContentAlignment.MiddleCenter;
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
            // texCargo
            // 
            texCargo.Location = new Point(256, 254);
            texCargo.Name = "texCargo";
            texCargo.Size = new Size(100, 23);
            texCargo.TabIndex = 20;
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
            // lbIngreso
            // 
            lbIngreso.BackColor = Color.LightSkyBlue;
            lbIngreso.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbIngreso.Location = new Point(386, 253);
            lbIngreso.Name = "lbIngreso";
            lbIngreso.Size = new Size(106, 21);
            lbIngreso.TabIndex = 23;
            lbIngreso.Text = "Feha de Ingreso:";
            lbIngreso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbturno
            // 
            lbturno.BackColor = Color.LightSkyBlue;
            lbturno.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbturno.Location = new Point(386, 169);
            lbturno.Name = "lbturno";
            lbturno.Size = new Size(69, 21);
            lbturno.TabIndex = 24;
            lbturno.Text = "Turno:";
            lbturno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbSalario
            // 
            lbSalario.BackColor = Color.LightSkyBlue;
            lbSalario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbSalario.Location = new Point(386, 127);
            lbSalario.Name = "lbSalario";
            lbSalario.Size = new Size(69, 21);
            lbSalario.TabIndex = 25;
            lbSalario.Text = "Salario:";
            lbSalario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DTPfechadeingreso
            // 
            DTPfechadeingreso.Location = new Point(498, 254);
            DTPfechadeingreso.Name = "DTPfechadeingreso";
            DTPfechadeingreso.Size = new Size(200, 23);
            DTPfechadeingreso.TabIndex = 27;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(461, 209);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 29;
            // 
            // nupdsalario
            // 
            nupdsalario.Location = new Point(461, 129);
            nupdsalario.Name = "nupdsalario";
            nupdsalario.Size = new Size(120, 23);
            nupdsalario.TabIndex = 32;
            // 
            // cbturno
            // 
            cbturno.FormattingEnabled = true;
            cbturno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cbturno.Location = new Point(460, 169);
            cbturno.Name = "cbturno";
            cbturno.Size = new Size(121, 23);
            cbturno.TabIndex = 33;
            // 
            // FrmEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(cbturno);
            Controls.Add(nupdsalario);
            Controls.Add(textBox2);
            Controls.Add(DTPfechadeingreso);
            Controls.Add(lbSalario);
            Controls.Add(lbturno);
            Controls.Add(lbIngreso);
            Controls.Add(lbemail);
            Controls.Add(textBox4);
            Controls.Add(texCargo);
            Controls.Add(texDestino);
            Controls.Add(textID);
            Controls.Add(LabCargo);
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
            Name = "FrmEmpleado";
            Text = "Gestion de Empleados";
            ((System.ComponentModel.ISupportInitialize)picboxlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupdsalario).EndInit();
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
        private Label LabCargo;
        private TextBox textID;
        private TextBox texDestino;
        private TextBox texCargo;
        private TextBox textBox4;
        private Label lbemail;
        private Label lbIngreso;
        private Label lbturno;
        private Label lbSalario;
        private DateTimePicker DTPfechadeingreso;
        private TextBox textBox2;
        private NumericUpDown nupdsalario;
        private ComboBox cbturno;
    }
}