using Mini.Classes;
using System.Windows;

namespace Mini.WPF
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

        private void btnExec_Click(object sender, RoutedEventArgs e)
        {
            Minificador.Executar(new string[] { "/o=" + txtOrigem.Text, "/d=" + txtDestino.Text });
        }
    }
}
