using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace GestionLibrosWinForms
{
    public partial class Form1 : Form
    {
        private Biblioteca _biblioteca = new Biblioteca();

        public Form1()
        {
            InitializeComponent();
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            comboBoxLibros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLibros.DisplayMember = "Titulo";
            comboBoxLibros.ValueMember = "Id";
            ActualizarComboBoxLibros();
          
        }

        private void ActualizarComboBoxLibros()
        {
            comboBoxLibros.Items.Clear();
            var librosDisponibles = _biblioteca.GetLibros().Where(l => !l.EstaPrestado).ToList();
            comboBoxLibros.DataSource = librosDisponibles;
            if (comboBoxLibros.Items.Count > 0)
            {
                comboBoxLibros.SelectedIndex = 0;
            }
        }

        private void btnPrestarLibro_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del usuario.");
                return;
            }

            if (comboBoxLibros.SelectedItem is Libro libroSeleccionado)
            {
                bool exito = _biblioteca.PrestarLibro(libroSeleccionado.Id, txtNombreUsuario.Text);
                if (exito)
                {
                    MessageBox.Show("El libro ha sido prestado exitosamente.");
                   //    ActualizarComboBoxLibros();
                }
                else
                {
                    MessageBox.Show("El libro no pudo ser prestado. Verifique si ya está prestado.");
                }

                txtNombreUsuario.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un libro en el ComboBox.");
            }
        }

        private void btnDevolverLibro_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del usuario.");
                return;
            }

            if (comboBoxLibros.SelectedItem is Libro libroSeleccionado)
            {
                bool exito = _biblioteca.DevolverLibro(libroSeleccionado.Id, txtNombreUsuario.Text);
                if (exito)
                {
                    MessageBox.Show("El libro ha sido devuelto exitosamente.");
                    //ActualizarComboBoxLibros();
                }
                else
                {
                    MessageBox.Show("El libro no pudo ser devuelto. Verifique si está prestado a este usuario.");
                }

                txtNombreUsuario.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un libro en el ComboBox.");
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            // Obtener la lista de libros como IEnumerable<Libro>
            var libros = _biblioteca.GetLibros().ToList();

            // Crear e iniciar el formulario FormLibros
            var formLibros = new FormLibros(libros);
            formLibros.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public bool EstaPrestado { get; set; }
        public string? Usuario { get; set; } // Nullable

        public string Estado => EstaPrestado ? $"Prestado por {Usuario}" : "Disponible";
    }

    public class Biblioteca
    {
        private readonly BindingList<Libro> _libros = new BindingList<Libro>();

        public Biblioteca()
        {
            _libros.Add(new Libro { Id = 1, Titulo = "1984", Autor = "George Orwell", EstaPrestado = false });
            _libros.Add(new Libro { Id = 2, Titulo = "To Kill a Mockingbird", Autor = "Harper Lee", EstaPrestado = false });
        }

        public bool PrestarLibro(int id, string usuario)
        {
            var libro = _libros.FirstOrDefault(l => l.Id == id);
            if (libro != null && !libro.EstaPrestado)
            {
                libro.EstaPrestado = true;
                libro.Usuario = usuario;
                return true;
            }
            return false;
        }

        public bool DevolverLibro(int id, string usuario)
        {
            var libro = _libros.FirstOrDefault(l => l.Id == id);
            if (libro != null && libro.EstaPrestado && libro.Usuario == usuario)
            {
                libro.EstaPrestado = false;
                libro.Usuario = null;
                return true;
            }
            return false;
        }

        public BindingList<Libro> GetLibros()
        {
            return _libros;
        }
    }
}
