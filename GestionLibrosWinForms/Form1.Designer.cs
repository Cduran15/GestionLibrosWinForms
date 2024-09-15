namespace GestionLibrosWinForms
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
            btnPrestarLibro = new Button();
            btnDevolverLibro = new Button();
            label1 = new Label();
            txtNombreUsuario = new TextBox();
            btnSalir = new Button();
            btnMostrarTodos = new Button();
            comboBoxLibros = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnPrestarLibro
            // 
            btnPrestarLibro.Location = new Point(319, 110);
            btnPrestarLibro.Margin = new Padding(4, 5, 4, 5);
            btnPrestarLibro.Name = "btnPrestarLibro";
            btnPrestarLibro.Size = new Size(117, 70);
            btnPrestarLibro.TabIndex = 1;
            btnPrestarLibro.Text = "Prestar Libro";
            btnPrestarLibro.UseVisualStyleBackColor = true;
            btnPrestarLibro.Click += btnPrestarLibro_Click_1;
            // 
            // btnDevolverLibro
            // 
            btnDevolverLibro.Location = new Point(319, 190);
            btnDevolverLibro.Margin = new Padding(4, 5, 4, 5);
            btnDevolverLibro.Name = "btnDevolverLibro";
            btnDevolverLibro.Size = new Size(117, 70);
            btnDevolverLibro.TabIndex = 2;
            btnDevolverLibro.Text = "Devolver Libro";
            btnDevolverLibro.UseVisualStyleBackColor = true;
            btnDevolverLibro.Click += btnDevolverLibro_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(409, 25);
            label1.TabIndex = 3;
            label1.Text = "Ingresa el nombre del usuario que hara el proceso";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(27, 66);
            txtNombreUsuario.Margin = new Padding(4, 5, 4, 5);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(409, 31);
            txtNombreUsuario.TabIndex = 4;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(321, 437);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(117, 35);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Location = new Point(319, 268);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new Size(117, 70);
            btnMostrarTodos.TabIndex = 6;
            btnMostrarTodos.Text = "Mostrar Libros";
            btnMostrarTodos.UseVisualStyleBackColor = true;
            btnMostrarTodos.Click += btnMostrarTodos_Click;
            // 
            // comboBoxLibros
            // 
            comboBoxLibros.FormattingEnabled = true;
            comboBoxLibros.Location = new Point(27, 147);
            comboBoxLibros.Name = "comboBoxLibros";
            comboBoxLibros.Size = new Size(242, 33);
            comboBoxLibros.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 110);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 8;
            label2.Text = "Selecciona un libro";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(450, 494);
            Controls.Add(label2);
            Controls.Add(comboBoxLibros);
            Controls.Add(btnMostrarTodos);
            Controls.Add(btnSalir);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label1);
            Controls.Add(btnDevolverLibro);
            Controls.Add(btnPrestarLibro);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Gestion de libros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPrestarLibro;
        private Button btnDevolverLibro;
        private Label label1;
        private TextBox txtNombreUsuario;
        private Button btnSalir;
        private Button btnMostrarTodos;
        private ComboBox comboBoxLibros;
        private Label label2;
    }
}
