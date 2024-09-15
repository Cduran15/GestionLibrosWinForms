using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionLibrosWinForms
{
    public partial class FormLibros : Form
    {
        public FormLibros(IEnumerable<Libro> libros)
        {
            InitializeComponent();
            ConfigurarListView();
            CargarLibrosEnListView(libros);
            AjustarColumnas();
        }

        private void ConfigurarListView()
        {
            // Configurar el ListView para mostrar datos en formato de tabla
            listViewLibros.View = View.Details;
            listViewLibros.Columns.Clear();
            listViewLibros.Columns.Add("Título", 150); // Ancho inicial
            listViewLibros.Columns.Add("Autor", 150);  // Ancho inicial
            listViewLibros.Columns.Add("Estado", 150); // Ancho inicial
        }

        private void CargarLibrosEnListView(IEnumerable<Libro> libros)
        {
            // Limpiar los ítems actuales
            listViewLibros.Items.Clear();

            // Agregar los libros al ListView
            foreach (var libro in libros)
            {
                var item = new ListViewItem(libro.Titulo);
                item.SubItems.Add(libro.Autor);
                item.SubItems.Add(libro.Estado);
                listViewLibros.Items.Add(item);
            }
        }

        private void AjustarColumnas()
        {
            // Ajustar el tamaño de las columnas para adaptarse al contenido
            foreach (ColumnHeader column in listViewLibros.Columns)
            {
                column.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }
    }
}

