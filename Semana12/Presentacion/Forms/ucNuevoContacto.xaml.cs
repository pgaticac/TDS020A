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
using Datos;
using Negocio;

namespace Presentacion.Forms
{
    /// <summary>
    /// Lógica de interacción para ucNuevoContacto.xaml
    /// </summary>
    public partial class ucNuevoContacto : UserControl
    {

        //Crear instancia de Agenda (Clase de negocio)
        Agenda miAgenda = new Agenda();

        public ucNuevoContacto()
        {
            InitializeComponent();
            cboGrupo.ItemsSource = Enum.GetValues(typeof(Grupo));
            cboGrupo.SelectedValue = Grupo.Default;
            dpFechaNacimiento.DisplayDateEnd = DateTime.Today;
            
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            //Crear un objeto persona
            Persona nuevo = new Persona();

            //validaciones de formulario

            //Cargar el objeto persona con los datos del formulario
            nuevo.Nombre = txtNombre.Text;
            nuevo.Apellido = txtApellido.Text;
            nuevo.Telefono = txtTelefono.Text;
            nuevo.FechaNacimiento = (DateTime)dpFechaNacimiento.SelectedDate;
            nuevo.Grupo = (Grupo)cboGrupo.SelectedValue;
           
            

            //Llamar al método que agrega en la clase de negocio
            miAgenda.Add(nuevo);

            //Limpio formulario
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            dpFechaNacimiento.SelectedDate = DateTime.Today;
            cboGrupo.SelectedValue = Grupo.Default;

            //Mensaje de exito
            MessageBox.Show("Contacto ingresado correctamente");

            //Mostrar los contactos (Por ahora)
            MessageBox.Show(string.Join("\n", miAgenda.GetAll()));
        }
    }
}
