using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Geometria;
namespace rozszezenie
{
    public interface IWyświetl
    {
        string PobierzIdentyfikator();

    }
    public static class ListBoxExtensions
    {
        // Metoda rozszerzająca do dodawania obiektów implementujących IWyświetl
        public static void Dodaj(this ListBox listBox, IWyświetl obiekt)
        {
            listBox.Items.Add(obiekt.PobierzIdentyfikator());  // Dodajemy identyfikator do listy
        }
    }
}
}
public class rozszez :
namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double w, h, P, O;
            DaneWejścioweOkno okno1 = new DaneWejścioweOkno();
            okno1.ShowDialog();
            w = okno1.Szczerosc;
            h = okno1.wyskosc;
            P = w * h;
            O = 2 * w + 2 * h;
            DaneWyjścioweOkno okno2 = new DaneWyjścioweOkno(P,O);
            
            okno2.ShowDialog();


        }

        private void btnstozek_Click(object sender, RoutedEventArgs e)
        {
            labelzad1.Content = "";
            Stozek XD = new Stozek(5,4, 3, 2); // Tworzymy obiekt klasy Stozek
            labelzad1.Content = XD.ToString();
        }

        private void btnkula_Click(object sender, RoutedEventArgs e)
        {
            labelzad1.Content = "";
            Kula XD = new Kula(4, 3, 2); // Tworzymy obiekt klasy Kula
            labelzad1.Content = XD.ToString();
        }
    }
}