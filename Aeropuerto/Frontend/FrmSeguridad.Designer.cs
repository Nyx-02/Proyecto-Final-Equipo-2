namespace Frontend
{
    partial class FrmSeguridad
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
            textBox8 = new TextBox();
            textBox6 = new TextBox();
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
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // textBox8
            // 
            textBox8.Location = new Point(473, 160);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(72, 23);
            textBox8.TabIndex = 81;
            textBox8.Text = "Fecha";
            textBox8.TextAlign = HorizontalAlignment.Center;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(215, 258);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 79;
            textBox6.Text = "Nivel De Acceso";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(410, 189);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 78;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(215, 229);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 77;
            textBox5.Text = "Observaciones";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(215, 200);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 76;
            textBox4.Text = "Turno";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(215, 142);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 75;
            textBox3.Text = "ID Empleado";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(215, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 74;
            textBox2.Text = "Puesto";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(215, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 73;
            textBox1.Text = "ID";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // TxbxTitulo
            // 
            TxbxTitulo.Location = new Point(336, 76);
            TxbxTitulo.Name = "TxbxTitulo";
            TxbxTitulo.Size = new Size(110, 23);
            TxbxTitulo.TabIndex = 72;
            TxbxTitulo.Text = "Puerta Embarque";
            TxbxTitulo.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            button3.Location = new Point(240, 330);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 71;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(483, 330);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 70;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(321, 330);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 69;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            // 
            // BtEliminar
            // 
            BtEliminar.Location = new Point(402, 330);
            BtEliminar.Name = "BtEliminar";
            BtEliminar.Size = new Size(75, 23);
            BtEliminar.TabIndex = 68;
            BtEliminar.Text = "Eliminar";
            BtEliminar.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(215, 287);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 82;
            textBox7.Text = "Estado";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // FrmSeguridad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(textBox6);
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
            Name = "FrmSeguridad";
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox8;
        private TextBox textBox6;
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
        private TextBox textBox7;
    }
}