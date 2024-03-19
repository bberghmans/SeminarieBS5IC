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

namespace SudokuGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        TextBox[,] sudokuWaardes = new TextBox[9, 9];

        public MainWindow()
        {
            InitializeComponent();

            Label1.Content = "Dit is een label";


            for (int rij  = 0; rij < 9; rij++)
            {
                for (int kol =  0; kol < 9; kol++)
                {
                    TextBox sudokuWaarde = new TextBox();
                    sudokuWaardes[rij, kol] = sudokuWaarde;

                    SudokuGrid.
                }
            }






            //int rijnummer = Grid.GetRow(Knop1);
            //RowDefinition rowDef = MainGrid.RowDefinitions[rijnummer];

            Knop1.Content = "knop1";

        }

        private void Knop1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}