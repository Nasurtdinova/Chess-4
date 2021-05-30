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
using ClassCore;
using Figure = ClassCore.Figure;

namespace WpfChess_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private Button[,] cells = new Button[8, 8];
        public MainWindow()
        {
            InitializeComponent();

            lbFiguresDate.ItemsSource = FigureFab.InitFiguresData();

        }
        private void btnContent()
        {
            var fig = lbFiguresDate.SelectedItem as FiguresData;
            switch (fig.Name)
            {
                case "Knight":
                    btn_X2Y2.Content = "K";
                    break;
                case "Bishop":
                    btn_X2Y2.Content = "B";
                    break;
                case "Rook":
                    btn_X2Y2.Content = "R";
                    break;
                case "Queen":
                    btn_X2Y2.Content = "Q";
                    break;
                case "King":
                    btn_X2Y2.Content = "Ki";
                    break;
            }
        }
      
        private void btn_X2Y2_Click(object sender, RoutedEventArgs e)
        {
            btnContent();
        }
    }

}

    

       
    


