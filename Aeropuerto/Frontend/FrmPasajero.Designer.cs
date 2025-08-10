namespace Frontend
{
    partial class FrmPasajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPasajero));
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            BtEliminar = new Button();
            TxbxTitulo = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            comboBox1 = new ComboBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(237, 323);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(480, 323);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(318, 323);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            // 
            // BtEliminar
            // 
            BtEliminar.Location = new Point(399, 323);
            BtEliminar.Name = "BtEliminar";
            BtEliminar.Size = new Size(75, 23);
            BtEliminar.TabIndex = 4;
            BtEliminar.Text = "Eliminar";
            BtEliminar.UseVisualStyleBackColor = true;
            // 
            // TxbxTitulo
            // 
            TxbxTitulo.Location = new Point(352, 54);
            TxbxTitulo.Name = "TxbxTitulo";
            TxbxTitulo.Size = new Size(94, 23);
            TxbxTitulo.TabIndex = 8;
            TxbxTitulo.Text = "Pasajero";
            TxbxTitulo.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(237, 214);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 14;
            textBox5.Text = "Nacionalidad";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(237, 185);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 13;
            textBox4.Text = "Documento";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(237, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            textBox3.Text = "Apellido";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(237, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 11;
            textBox2.Text = "Nombre";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            textBox1.Text = "ID";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(237, 243);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 15;
            textBox6.Text = "Telefono";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(237, 272);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 16;
            textBox7.Text = "Email";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Economica", "Ejecutiva", "Primera Clase " });
            comboBox1.Location = new Point(480, 185);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(75, 23);
            comboBox1.TabIndex = 17;
            comboBox1.Text = "Clase";
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(47, 40);
            button4.TabIndex = 20;
            button4.UseVisualStyleBackColor = true;
            // 
            // FrmPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(comboBox1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
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
            Name = "FrmPasajero";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Button BtEliminar;
        private TextBox TxbxTitulo;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox6;
        private TextBox textBox7;
        private ComboBox comboBox1;
        private Button button4;
    }
}