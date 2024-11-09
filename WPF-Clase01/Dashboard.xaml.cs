using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Clase01
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
            cargarDatosAlumnos();
        }

        private void cargarDatosAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>{
                new Alumno { Nombres = "Jose", Apellidos = "Yon", Edad = 30, DNI = "12345678" },
                new Alumno { Nombres = "Ana", Apellidos = "Gomez", Edad = 20, DNI = "12345678" },
                new Alumno { Nombres = "Luis", Apellidos = "Sanchez", Edad = 40, DNI = "12345678" },
                new Alumno { Nombres = "Maria", Apellidos = "Perez", Edad = 50, DNI = "12345678" }
            };
            // Asignar la lista de Alumnos al DataGrid
            AlumnosDataGrid.ItemsSource = alumnos;
        }
    }
}
