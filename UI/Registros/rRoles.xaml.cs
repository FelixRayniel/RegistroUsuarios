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
    /// Lógica de interacción para rRoles.xaml
    /// </summary>
    public partial class rRoles : Window
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
        public Roles roles = new Roles();
        public rRoles()
        {
            InitializeComponent();
            this.DataContext = roles;

            
        }

        private void Limpiar()
        {
            this.roles = new Roles();
            this.DataContext = roles;
        }

        private bool Validar()
        {
            bool Paso = true;

            if (Fecha.Text.Length == 0)
            {
                Paso = false;
                MessageBox.Show("Porfavor ingrese una fecha", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if (DescripcionTextBox.Text.Length == 0)
            {
                Paso = false;
                MessageBox.Show("Porfavor ingrese una descripcion", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return Paso;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var roless = RolesBLL.Buscar(Utilidades.ToInt(RolIDTextBox.Text));
            if (roless != null)
                this.roles = roless;
            else
            {
                this.roles = new Roles();
                MessageBox.Show("Transaccion Fallida", "Error",
                   MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            this.DataContext = this.roles;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            if (RolesBLL.ExisteDescripcion(DescripcionTextBox.Text))
            {
                MessageBox.Show("Ya Existe un rol con esta descripcion, ingrese uno diferente nuevamente", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (RolesBLL.ExisteID(Utilidades.ToInt(RolIDTextBox.Text)))
            {
                MessageBox.Show("Ya Existe un rol con este ID, ingrese uno diferente nuevamente", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }


            var paso = RolesBLL.Guardar(this.roles);

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
            if (RolesBLL.Eliminar(Utilidades.ToInt(RolIDTextBox.Text)))
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
            

            if (RolesBLL.ExisteDescripcion(DescripcionTextBox.Text))
            {
                MessageBox.Show("Ya Existe un rol con esta descripcion, ingrese uno diferente nuevamente", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }


            var paso = RolesBLL.Modificar(this.roles);

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

