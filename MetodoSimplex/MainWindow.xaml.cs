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

namespace MetodoSimplex
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int NumVariablesFuncionObjetivo = 0;
        public MainWindow()
        {
            InitializeComponent();

            PanelDeVariablesParaFuncionObjetivo.Visibility = Visibility.Hidden;
            PanelDeVariablesParaEcuacionesDeRestriccion.Visibility = Visibility.Hidden;
            panelDeIgualacionDeEcuacion.IsEnabled = false;
            LimpiarCampos();
            HabilitarBotones(false);
            
        }

        private void HabilitarBotones(bool Habilitar)
        {
            btnAceptarVariablesDeFuncionObjetivo.IsEnabled = Habilitar;
            btnAceptarEcuacionesDeReintriccion.IsEnabled = Habilitar;
            btnNuevo.IsEnabled = !Habilitar;
            btnCancelar.IsEnabled = Habilitar;
            btnAceptarDatos.IsEnabled = Habilitar;
            rdMaximizar.IsEnabled = Habilitar;
            rdMinimizar.IsEnabled = Habilitar;
        }

        private void LimpiarCampos()
        {
            TxtDeVariableDeDecicion.Clear();
            txtNumEcuaciones.Clear();
            txtNumVariables.Clear();
            txtCoeficientesDeFuncionObjetivo.Clear();
            txtCoeficientesDeFuncionRestriccion.Clear();
            txtFuncionIgualA.Clear();
            rdMinimizar.IsChecked = false;
            rdMaximizar.IsChecked = false;
            rdIgual.IsChecked = false;
            rdMayorIgual.IsChecked = false;
            rdMenorIgual.IsChecked = false;

        }

        private void btnAceptarVariablesDeFuncionObjetivo_Click(object sender, RoutedEventArgs e)
        {
            PanelDeVariablesParaFuncionObjetivo.Visibility = Visibility.Visible;
            PanelDeVariablesYMaxOMin.Visibility = Visibility.Hidden;
            NumVariablesFuncionObjetivo = int.Parse(txtNumVariables.Text);
        }

        private void btnAceptarEcuacionesDeReintriccion_Click(object sender, RoutedEventArgs e)
        {
            PanelDeVariablesParaEcuacionesDeRestriccion.Visibility = Visibility.Visible;
            PanelDeEcuacionesDeRestriccion.Visibility = Visibility.Hidden;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            PanelDeVariablesParaFuncionObjetivo.Visibility = Visibility.Hidden;
            PanelDeVariablesParaEcuacionesDeRestriccion.Visibility = Visibility.Hidden;
            PanelDeEcuacionesDeRestriccion.Visibility = Visibility.Visible;
            PanelDeVariablesYMaxOMin.Visibility = Visibility.Visible;
            HabilitarBotones(false);
            LimpiarCampos();
            
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            LimpiarCampos();
            HabilitarBotones(true);
            PanelDeVariablesParaEcuacionesDeRestriccion.IsEnabled = false;
        }
        
        
    }
}
