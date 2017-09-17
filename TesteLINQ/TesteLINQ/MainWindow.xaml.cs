using System;
using System.Windows;
using TesteLINQ.DataAccess;

namespace TesteLINQ
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


        private void Salvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Produto novo = new Produto();

                novo.codigoBarras = int.Parse(codigoBarras.Text);
                novo.nome = nome.Text;
                novo.fabricante = fabricante.Text;
                novo.categoria = byte.Parse(categoria.Text);
                novo.valor = decimal.Parse(valor.Text);
                novo.peso = decimal.Parse(peso.Text);
                novo.quantidade = int.Parse(quantidade.Text);
                novo.Categoria1 = null;

                if (!ProdutoDataAccess.Insere(novo))
                    MessageBox.Show("Falha ao tentar inserir novo produto");
                else
                    MessageBox.Show("Cliente inserido com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = ProdutoDataAccess.Obter();
        }
    }
}
