using RegistroUsuarios.UI.Consultas;
using RegistroUsuarios.UI.Registros;
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

namespace RegistroUsuarios
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void UsuarioButton_Click(object sender, RoutedEventArgs e)
        {
            rUsuarios user = new rUsuarios();
            user.Show();
        }

        private void RolesButton_Click(object sender, RoutedEventArgs e)
        {
            rRoles roles = new rRoles();
            roles.Show();
        }

        private void CUsuarioButton_Click(object sender, RoutedEventArgs e)
        {
            cUsuarios cuser = new cUsuarios();
            cuser.Show();
        }

        private void CRolesButton_Click(object sender, RoutedEventArgs e)
        {
            cRoles croles = new cRoles();
            croles.Show();

        }

        private void ConsultaUsuariosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cUsuarios cuser = new cUsuarios();
            cuser.Show();
        }

        private void ConsultaRolesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cRoles croles = new cRoles();
            croles.Show();
        }


        private void RolesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rRoles roles = new rRoles();
            roles.Show();
        }

        private void UsuariosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rUsuarios user = new rUsuarios();
            user.Show();
        }

        
    }
}
