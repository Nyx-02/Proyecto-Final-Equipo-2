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
            textBox6 = new TextBox();
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
            textBox7 = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Location = new Point(203, 280);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 50;
            textBox6.Text = "Observaciones";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Facturado", "En Cabina ", "Perdido" });
            comboBox1.Location = new Point(456, 242);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(63, 23);
            comboBox1.TabIndex = 49;
            comboBox1.Tag = "";
            comboBox1.Text = "Estado";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(390, 181);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 48;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(203, 251);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 47;
            textBox5.Text = "Dimensiones";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(203, 222);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 46;
            textBox4.Text = "Peso";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(203, 164);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 45;
            textBox3.Text = "ID Pasajero";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(203, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 44;
            textBox2.Text = "Tipo";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(203, 135);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 43;
            textBox1.Text = "ID";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // TxbxTitulo
            // 
            TxbxTitulo.Location = new Point(336, 55);
            TxbxTitulo.Name = "TxbxTitulo";
            TxbxTitulo.Size = new Size(94, 23);
            TxbxTitulo.TabIndex = 42;
            TxbxTitulo.Text = "Equipaje";
            TxbxTitulo.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            button3.Location = new Point(228, 334);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 41;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(471, 334);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 40;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(309, 334);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 39;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            // 
            // BtEliminar
            // 
            BtEliminar.Location = new Point(390, 334);
            BtEliminar.Name = "BtEliminar";
            BtEliminar.Size = new Size(75, 23);
            BtEliminar.TabIndex = 38;
            BtEliminar.Text = "Eliminar";
            BtEliminar.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(446, 152);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 51;
            textBox7.Text = "Fecha De Registro";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(47, 40);
            button4.TabIndex = 52;
            button4.UseVisualStyleBackColor = true;
            // 
            // FrmEquipaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
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
            Name = "FrmEquipaje";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox6;
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
        private TextBox textBox7;
        private Button button4;
    }
}