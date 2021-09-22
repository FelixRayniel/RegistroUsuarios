using RegistroUsuarios.BLL;
using RegistroUsuarios.Entidades;
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

namespace RegistroUsuarios.UI.Registros
{
    /// <summary>
    /// Lógica de interacción para rUsuarios.xaml
    /// </summary>
    public partial class rUsuarios : Window
    {
        public class DateFormat : System.Windows.Data.IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                if (value == null) return null;

                return ((DateTime)value).ToString("dd/MM/yyyy");
            }

            public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }

        public Usuarios usuario = new Usuarios();

        public rUsuarios()
        {
            InitializeComponent();
            this.DataContext = usuario;
            RolComboBox.ItemsSource = RolesBLL.GetRoles();
            RolComboBox.SelectedValuePath = "RolID";
            RolComboBox.DisplayMemberPath = "Descripcion";

        }

        private void Limpiar()
        {
            this.usuario = new Usuarios();
            this.DataContext = usuario;
            
        }

        private bool Validar()
        {
            bool Paso = true;

            if (FechaIngresoDatePicker.Text.Length == 0)
            {
                Paso = false;
                MessageBox.Show("Porfavor ingrese una fecha", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
           

            return Paso;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {

            
            var usuarios = UsuariosBLL.Buscar(Utilidades.ToInt(UsuarioIDTextBox.Text));
            if (usuarios != null)
                this.usuario = usuarios;
                
            else
            {
                this.usuario = new Usuarios();
                MessageBox.Show("Transaccion Fallida", "Error",
                   MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            this.DataContext = this.usuario;
            
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            if (UsuariosBLL.ExisteID(Utilidades.ToInt(UsuarioIDTextBox.Text)))
            {
                MessageBox.Show("Ya Existe un rol con este ID, ingrese uno diferente nuevamente", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var paso = UsuariosBLL.Guardar(usuario);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccion Existosa!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Transaccion Fallida", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (UsuariosBLL.Eliminar(Utilidades.ToInt(UsuarioIDTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro Eliminado!", "Exito",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("No se puede eliminar", "Fallo",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void EditarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;


            var paso = UsuariosBLL.Modificar(usuario);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccion Existosa!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Transaccion Fallida", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }

       
}

    

