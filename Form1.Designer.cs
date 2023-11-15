namespace Practica_1U4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            numero1 = new Label();
            numero2 = new Label();
            btnSumar = new Button();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnLimpiar = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 16);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // numero1
            // 
            numero1.AutoSize = true;
            numero1.Location = new Point(117, 69);
            numero1.Name = "numero1";
            numero1.Size = new Size(127, 32);
            numero1.TabIndex = 1;
            numero1.Text = "Numero 1:";
            // 
            // numero2
            // 
            numero2.AutoSize = true;
            numero2.Location = new Point(117, 138);
            numero2.Name = "numero2";
            numero2.Size = new Size(127, 32);
            numero2.TabIndex = 2;
            numero2.Text = "Numero 2:";
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(590, 30);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(150, 46);
            btnSumar.TabIndex = 3;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(590, 94);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(150, 46);
            btnRestar.TabIndex = 4;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(590, 159);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(150, 46);
            btnMultiplicar.TabIndex = 5;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(592, 225);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(150, 46);
            btnDividir.TabIndex = 6;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(44, 225);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 46);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 319);
            label4.Name = "label4";
            label4.Size = new Size(118, 32);
            label4.TabIndex = 8;
            label4.Text = "Resultado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 370);
            label5.Name = "label5";
            label5.Size = new Size(123, 32);
            label5.TabIndex = 9;
            label5.Text = "Resultado:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(250, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(250, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(250, 363);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnLimpiar);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(numero2);
            Controls.Add(numero1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Propiedades y Funciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label numero1;
        private Label numero2;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnLimpiar;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}