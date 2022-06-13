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

            ListarTrabajadores();
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
            List<Trabajador> trabajadores = tbll.GetAll();
            dgTrabajadores.ItemsSource = trabajadores;
            
        }

        private void BtnListar_Click(object sender, RoutedEventArgs e)
        {
            ListarTrabajadores();
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            Trabajador t = (Trabajador) dgTrabajadores.SelectedItem;
            tbll.Delete(t.Id);
            ListarTrabajadores();
        }

        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {
            Trabajador t = (Trabajador)dgTrabajadores.SelectedItem;
            txtNombre.Text = t.Nombre;
            dtFechaNacimiento.SelectedDate = t.FechaNacimiento;
            cboExperiencia.SelectedValue = Enum.Parse(typeof(Experiencia), t.Experiencia);
            cboProfesion.SelectedValue = Enum.Parse(typeof(Profesion),t.Profesion);


        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Trabajador t = (Trabajador)dgTrabajadores.SelectedItem;

            tbll.Update(t.Id, 
                        txtNombre.Text,
                        (DateTime)dtFechaNacimiento.SelectedDate, 
                        (Experiencia)cboExperiencia.SelectedValue, 
                        (Profesion)cboProfesion.SelectedValue);

            ListarTrabajadores();

        }
    }
}
