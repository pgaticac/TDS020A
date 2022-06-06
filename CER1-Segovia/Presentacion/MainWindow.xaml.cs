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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DatosSQL;
using Negocio;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TrabajadorBLL tbll = new TrabajadorBLL();
        public MainWindow()
        {
            InitializeComponent();
            cboProfesion.ItemsSource = Enum.GetValues(typeof(Profesion));
            cboExperiencia.ItemsSource = Enum.GetValues(typeof(Experiencia));
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Trabajador trabajador = new Trabajador();
            trabajador.Nombre = txtNombre.Text;
            trabajador.FechaNacimiento = (DateTime) dtFechaNacimiento.SelectedDate;
            trabajador.Profesion = cboProfesion.SelectedValue.ToString();
            trabajador.Experiencia = cboExperiencia.SelectedValue.ToString();

            tbll.Add(trabajador);

            MessageBox.Show("Sueldo: " + trabajador.Sueldo);
            MessageBox.Show("Trabajador registrado exitosamente");

            txtNombre.Text = String.Empty;

            ListarTrabajadores();
            
            
        }

        private void ListarTrabajadores()
        {
            List<Trabajador> trabajadores = tbll.getAll();
            string lista = "";
            foreach (Trabajador trabajador in trabajadores)
            {
                lista += trabajador;
                lista += "-------------------\n";
            }

            txtTrabajadores.Text = lista;
        }

        private void BtnListar_Click(object sender, RoutedEventArgs e)
        {
            ListarTrabajadores();
        }
    }
}
