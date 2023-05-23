namespace Calculadora
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
            txbResultado = new TextBox();
            btnPorcentaje = new Button();
            btnCE = new Button();
            btnBorrarTodo = new Button();
            btnBorrarUno = new Button();
            btnDivision = new Button();
            btnCuadrado = new Button();
            btnRaiz = new Button();
            btnDivi = new Button();
            btnSiete = new Button();
            btnOcho = new Button();
            btnNueve = new Button();
            btnMultip = new Button();
            btnCuatro = new Button();
            btnCinco = new Button();
            btn6 = new Button();
            btnResta = new Button();
            btnUno = new Button();
            btnDos = new Button();
            btnTres = new Button();
            btnSuma = new Button();
            btnIncrement = new Button();
            btnCero = new Button();
            btnComa = new Button();
            btnIgual = new Button();
            txbCadenaResultado = new TextBox();
            SuspendLayout();
            // 
            // txbResultado
            // 
            txbResultado.BackColor = SystemColors.WindowText;
            txbResultado.BorderStyle = BorderStyle.None;
            txbResultado.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            txbResultado.ForeColor = SystemColors.Window;
            txbResultado.Location = new Point(3, 42);
            txbResultado.Multiline = true;
            txbResultado.Name = "txbResultado";
            txbResultado.ReadOnly = true;
            txbResultado.Size = new Size(352, 70);
            txbResultado.TabIndex = 0;
            txbResultado.Text = "0";
            txbResultado.TextAlign = HorizontalAlignment.Right;
            txbResultado.TextChanged += txbResultado_TextChanged;
            // 
            // btnPorcentaje
            // 
            btnPorcentaje.AllowDrop = true;
            btnPorcentaje.BackColor = Color.DimGray;
            btnPorcentaje.FlatStyle = FlatStyle.Popup;
            btnPorcentaje.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnPorcentaje.ForeColor = SystemColors.ButtonHighlight;
            btnPorcentaje.Location = new Point(3, 115);
            btnPorcentaje.Margin = new Padding(0);
            btnPorcentaje.Name = "btnPorcentaje";
            btnPorcentaje.Size = new Size(88, 68);
            btnPorcentaje.TabIndex = 1;
            btnPorcentaje.Text = "%";
            btnPorcentaje.UseVisualStyleBackColor = false;
            // 
            // btnCE
            // 
            btnCE.BackColor = Color.DimGray;
            btnCE.FlatStyle = FlatStyle.Popup;
            btnCE.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnCE.ForeColor = SystemColors.ButtonHighlight;
            btnCE.Location = new Point(91, 115);
            btnCE.Margin = new Padding(0);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(88, 68);
            btnCE.TabIndex = 2;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.BackColor = Color.DimGray;
            btnBorrarTodo.FlatStyle = FlatStyle.Popup;
            btnBorrarTodo.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrarTodo.ForeColor = SystemColors.ButtonHighlight;
            btnBorrarTodo.Location = new Point(179, 115);
            btnBorrarTodo.Margin = new Padding(0);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(88, 68);
            btnBorrarTodo.TabIndex = 3;
            btnBorrarTodo.Text = "C";
            btnBorrarTodo.UseVisualStyleBackColor = false;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnBorrarUno
            // 
            btnBorrarUno.BackColor = Color.DimGray;
            btnBorrarUno.FlatStyle = FlatStyle.Popup;
            btnBorrarUno.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrarUno.ForeColor = SystemColors.ButtonHighlight;
            btnBorrarUno.Location = new Point(267, 115);
            btnBorrarUno.Margin = new Padding(0);
            btnBorrarUno.Name = "btnBorrarUno";
            btnBorrarUno.Size = new Size(88, 68);
            btnBorrarUno.TabIndex = 4;
            btnBorrarUno.Text = "⌫";
            btnBorrarUno.UseVisualStyleBackColor = false;
            btnBorrarUno.Click += btnBorrarUno_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.DimGray;
            btnDivision.FlatStyle = FlatStyle.Popup;
            btnDivision.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivision.ForeColor = SystemColors.ButtonHighlight;
            btnDivision.Location = new Point(3, 183);
            btnDivision.Margin = new Padding(0);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(88, 68);
            btnDivision.TabIndex = 5;
            btnDivision.Text = "1/x";
            btnDivision.UseVisualStyleBackColor = false;
            // 
            // btnCuadrado
            // 
            btnCuadrado.BackColor = Color.DimGray;
            btnCuadrado.FlatStyle = FlatStyle.Popup;
            btnCuadrado.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnCuadrado.ForeColor = SystemColors.ButtonHighlight;
            btnCuadrado.Location = new Point(91, 183);
            btnCuadrado.Margin = new Padding(0);
            btnCuadrado.Name = "btnCuadrado";
            btnCuadrado.Size = new Size(88, 68);
            btnCuadrado.TabIndex = 6;
            btnCuadrado.Text = "x2";
            btnCuadrado.UseVisualStyleBackColor = false;
            // 
            // btnRaiz
            // 
            btnRaiz.BackColor = Color.DimGray;
            btnRaiz.FlatStyle = FlatStyle.Popup;
            btnRaiz.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnRaiz.ForeColor = SystemColors.ButtonHighlight;
            btnRaiz.Location = new Point(179, 183);
            btnRaiz.Margin = new Padding(0);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(88, 68);
            btnRaiz.TabIndex = 7;
            btnRaiz.Text = "raiz";
            btnRaiz.UseVisualStyleBackColor = false;
            // 
            // btnDivi
            // 
            btnDivi.BackColor = Color.DimGray;
            btnDivi.FlatStyle = FlatStyle.Popup;
            btnDivi.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivi.ForeColor = SystemColors.ButtonHighlight;
            btnDivi.Location = new Point(267, 183);
            btnDivi.Margin = new Padding(0);
            btnDivi.Name = "btnDivi";
            btnDivi.Size = new Size(88, 68);
            btnDivi.TabIndex = 8;
            btnDivi.Text = "÷";
            btnDivi.UseVisualStyleBackColor = false;
            btnDivi.Click += btnDivi_Click;
            // 
            // btnSiete
            // 
            btnSiete.BackColor = Color.DimGray;
            btnSiete.FlatStyle = FlatStyle.Popup;
            btnSiete.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiete.ForeColor = SystemColors.ButtonHighlight;
            btnSiete.Location = new Point(3, 251);
            btnSiete.Margin = new Padding(0);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(88, 68);
            btnSiete.TabIndex = 9;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = false;
            btnSiete.Click += btnSiete_Click;
            // 
            // btnOcho
            // 
            btnOcho.BackColor = Color.DimGray;
            btnOcho.FlatStyle = FlatStyle.Popup;
            btnOcho.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnOcho.ForeColor = SystemColors.ButtonHighlight;
            btnOcho.Location = new Point(91, 251);
            btnOcho.Margin = new Padding(0);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(88, 68);
            btnOcho.TabIndex = 10;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = false;
            btnOcho.Click += btnOcho_Click;
            // 
            // btnNueve
            // 
            btnNueve.BackColor = Color.DimGray;
            btnNueve.FlatStyle = FlatStyle.Popup;
            btnNueve.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnNueve.ForeColor = SystemColors.ButtonHighlight;
            btnNueve.Location = new Point(179, 251);
            btnNueve.Margin = new Padding(0);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(88, 68);
            btnNueve.TabIndex = 11;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = false;
            btnNueve.Click += btnNueve_Click;
            // 
            // btnMultip
            // 
            btnMultip.BackColor = Color.DimGray;
            btnMultip.FlatStyle = FlatStyle.Popup;
            btnMultip.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultip.ForeColor = SystemColors.ButtonHighlight;
            btnMultip.Location = new Point(267, 251);
            btnMultip.Margin = new Padding(0);
            btnMultip.Name = "btnMultip";
            btnMultip.Size = new Size(88, 68);
            btnMultip.TabIndex = 12;
            btnMultip.Text = "x";
            btnMultip.UseVisualStyleBackColor = false;
            btnMultip.Click += btnMultip_Click;
            // 
            // btnCuatro
            // 
            btnCuatro.BackColor = Color.DimGray;
            btnCuatro.FlatStyle = FlatStyle.Popup;
            btnCuatro.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnCuatro.ForeColor = SystemColors.ButtonHighlight;
            btnCuatro.Location = new Point(3, 319);
            btnCuatro.Margin = new Padding(0);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(88, 68);
            btnCuatro.TabIndex = 13;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = false;
            btnCuatro.Click += btnCuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = Color.DimGray;
            btnCinco.FlatStyle = FlatStyle.Popup;
            btnCinco.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnCinco.ForeColor = SystemColors.ButtonHighlight;
            btnCinco.Location = new Point(91, 319);
            btnCinco.Margin = new Padding(0);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(88, 68);
            btnCinco.TabIndex = 14;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += btnCinco_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.DimGray;
            btn6.FlatStyle = FlatStyle.Popup;
            btn6.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.ForeColor = SystemColors.ButtonHighlight;
            btn6.Location = new Point(179, 319);
            btn6.Margin = new Padding(0);
            btn6.Name = "btn6";
            btn6.Size = new Size(88, 68);
            btn6.TabIndex = 15;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btnResta
            // 
            btnResta.BackColor = Color.DimGray;
            btnResta.FlatStyle = FlatStyle.Popup;
            btnResta.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnResta.ForeColor = SystemColors.ButtonHighlight;
            btnResta.Location = new Point(267, 319);
            btnResta.Margin = new Padding(0);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(88, 68);
            btnResta.TabIndex = 16;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = false;
            btnResta.Click += btnResta_Click;
            // 
            // btnUno
            // 
            btnUno.BackColor = Color.DimGray;
            btnUno.FlatStyle = FlatStyle.Popup;
            btnUno.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnUno.ForeColor = SystemColors.ButtonHighlight;
            btnUno.Location = new Point(3, 387);
            btnUno.Margin = new Padding(0);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(88, 68);
            btnUno.TabIndex = 17;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = false;
            btnUno.Click += btnUno_Click;
            // 
            // btnDos
            // 
            btnDos.BackColor = Color.DimGray;
            btnDos.FlatStyle = FlatStyle.Popup;
            btnDos.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnDos.ForeColor = SystemColors.ButtonHighlight;
            btnDos.Location = new Point(91, 387);
            btnDos.Margin = new Padding(0);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(88, 68);
            btnDos.TabIndex = 18;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = false;
            btnDos.Click += btnDos_Click;
            // 
            // btnTres
            // 
            btnTres.BackColor = Color.DimGray;
            btnTres.FlatStyle = FlatStyle.Popup;
            btnTres.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnTres.ForeColor = SystemColors.ButtonHighlight;
            btnTres.Location = new Point(179, 387);
            btnTres.Margin = new Padding(0);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(88, 68);
            btnTres.TabIndex = 19;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += btnTres_Click;
            // 
            // btnSuma
            // 
            btnSuma.BackColor = Color.DimGray;
            btnSuma.FlatStyle = FlatStyle.Popup;
            btnSuma.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuma.ForeColor = SystemColors.ButtonHighlight;
            btnSuma.Location = new Point(267, 387);
            btnSuma.Margin = new Padding(0);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(88, 68);
            btnSuma.TabIndex = 20;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnIncrement
            // 
            btnIncrement.BackColor = Color.DimGray;
            btnIncrement.FlatStyle = FlatStyle.Popup;
            btnIncrement.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnIncrement.ForeColor = SystemColors.ButtonHighlight;
            btnIncrement.Location = new Point(3, 455);
            btnIncrement.Margin = new Padding(0);
            btnIncrement.Name = "btnIncrement";
            btnIncrement.Size = new Size(88, 68);
            btnIncrement.TabIndex = 21;
            btnIncrement.Text = "+/-";
            btnIncrement.UseVisualStyleBackColor = false;
            // 
            // btnCero
            // 
            btnCero.BackColor = Color.DimGray;
            btnCero.FlatStyle = FlatStyle.Popup;
            btnCero.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnCero.ForeColor = SystemColors.ButtonHighlight;
            btnCero.Location = new Point(91, 455);
            btnCero.Margin = new Padding(0);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(88, 68);
            btnCero.TabIndex = 22;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = false;
            btnCero.Click += btnCero_Click;
            // 
            // btnComa
            // 
            btnComa.BackColor = Color.DimGray;
            btnComa.FlatStyle = FlatStyle.Popup;
            btnComa.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnComa.ForeColor = SystemColors.ButtonHighlight;
            btnComa.Location = new Point(179, 455);
            btnComa.Margin = new Padding(0);
            btnComa.Name = "btnComa";
            btnComa.Size = new Size(88, 68);
            btnComa.TabIndex = 23;
            btnComa.Text = ",";
            btnComa.UseVisualStyleBackColor = false;
            btnComa.Click += btnComa_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.DimGray;
            btnIgual.FlatStyle = FlatStyle.Popup;
            btnIgual.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnIgual.ForeColor = SystemColors.ButtonHighlight;
            btnIgual.Location = new Point(267, 455);
            btnIgual.Margin = new Padding(0);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(88, 68);
            btnIgual.TabIndex = 24;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // txbCadenaResultado
            // 
            txbCadenaResultado.BackColor = SystemColors.MenuText;
            txbCadenaResultado.BorderStyle = BorderStyle.None;
            txbCadenaResultado.ForeColor = SystemColors.MenuBar;
            txbCadenaResultado.Location = new Point(3, 2);
            txbCadenaResultado.Multiline = true;
            txbCadenaResultado.Name = "txbCadenaResultado";
            txbCadenaResultado.Size = new Size(352, 34);
            txbCadenaResultado.TabIndex = 25;
            txbCadenaResultado.TextChanged += txbCadenaResultado_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(358, 525);
            Controls.Add(txbCadenaResultado);
            Controls.Add(btnIgual);
            Controls.Add(btnComa);
            Controls.Add(btnCero);
            Controls.Add(btnIncrement);
            Controls.Add(btnSuma);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnUno);
            Controls.Add(btnResta);
            Controls.Add(btn6);
            Controls.Add(btnCinco);
            Controls.Add(btnCuatro);
            Controls.Add(btnMultip);
            Controls.Add(btnNueve);
            Controls.Add(btnOcho);
            Controls.Add(btnSiete);
            Controls.Add(btnDivi);
            Controls.Add(btnRaiz);
            Controls.Add(btnCuadrado);
            Controls.Add(btnDivision);
            Controls.Add(btnBorrarUno);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnCE);
            Controls.Add(btnPorcentaje);
            Controls.Add(txbResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbResultado;
        private Button btnPorcentaje;
        private Button btnCE;
        private Button btnBorrarTodo;
        private Button btnBorrarUno;
        private Button btnDivision;
        private Button btnCuadrado;
        private Button btnRaiz;
        private Button btnDivi;
        private Button btnSiete;
        private Button btnOcho;
        private Button btnNueve;
        private Button btnMultip;
        private Button btnCuatro;
        private Button btnCinco;
        private Button btn6;
        private Button btnResta;
        private Button btnUno;
        private Button btnDos;
        private Button btnTres;
        private Button btnSuma;
        private Button btnIncrement;
        private Button btnCero;
        private Button btnComa;
        private Button btnIgual;
        private TextBox txbCadenaResultado;
    }
}