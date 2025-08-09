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
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            TxbxTitulo = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            BtEliminar = new Button();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Activo", "Mantenimiento", "Fuera de Servicio" });
            comboBox1.Location = new Point(461, 230);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(63, 23);
            comboBox1.TabIndex = 23;
            comboBox1.Tag = "";
            comboBox1.Text = "Estado";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(395, 172);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 22;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(206, 259);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 21;
            textBox5.Text = "Capacidad";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(206, 230);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 20;
            textBox4.Text = "Matricula";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(206, 201);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 19;
            textBox3.Text = "Frabicante";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(206, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 18;
            textBox2.Text = "Modelo";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(206, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 17;
            textBox1.Text = "ID";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // TxbxTitulo
            // 
            TxbxTitulo.Location = new Point(339, 63);
            TxbxTitulo.Name = "TxbxTitulo";
            TxbxTitulo.Size = new Size(94, 23);
            TxbxTitulo.TabIndex = 16;
            TxbxTitulo.Text = "Avion";
            TxbxTitulo.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            button3.Location = new Point(231, 342);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 15;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(474, 342);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(312, 342);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            // 
            // BtEliminar
            // 
            BtEliminar.Location = new Point(393, 342);
            BtEliminar.Name = "BtEliminar";
            BtEliminar.Size = new Size(75, 23);
            BtEliminar.TabIndex = 12;
            BtEliminar.Text = "Eliminar";
            BtEliminar.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(206, 288);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 24;
            textBox6.Text = "Aerolinea";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(435, 143);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(126, 23);
            textBox7.TabIndex = 25;
            textBox7.Text = "Fecha De Fabricacion";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // FrmAvion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(TxbxTitulo);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BtEliminar);
            Name = "FrmAvion";
            Text = "Form3";
            Load += FrmAvion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox TxbxTitulo;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button BtEliminar;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}