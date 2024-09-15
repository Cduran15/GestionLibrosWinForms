namespace GestionLibrosWinForms
{
    partial class FormLibros
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
            listViewLibros = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            SuspendLayout();
            // 
            // listViewLibros
            // 
            listViewLibros.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3, columnHeader1 });
            listViewLibros.Dock = DockStyle.Fill;
            listViewLibros.Location = new Point(0, 0);
            listViewLibros.Name = "listViewLibros";
            listViewLibros.Size = new Size(575, 246);
            listViewLibros.TabIndex = 0;
            listViewLibros.UseCompatibleStateImageBehavior = false;
            listViewLibros.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 1;
            columnHeader2.Text = "Autor";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 2;
            columnHeader3.Text = "Estado";
            columnHeader3.Width = 200;
            // 
            // columnHeader1
            // 
            columnHeader1.DisplayIndex = 0;
            columnHeader1.Text = "Titulo";
            columnHeader1.Width = 150;
            // 
            // FormLibros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(575, 246);
            Controls.Add(listViewLibros);
            Name = "FormLibros";
            Text = "Libros";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewLibros;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}