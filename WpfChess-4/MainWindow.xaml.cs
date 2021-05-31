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
        public Button prevButton;
        private Button[,] cells = new Button[8, 8];
        public MainWindow()
        {
            InitializeComponent();
            chessDeck.Rows = 8;
            chessDeck.Columns = 8;
            lbFiguresDate.ItemsSource = FigureFab.InitFiguresData();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    cells[i, j] = new Button();


                    chessDeck.Children.Add(cells[i, j]);
                    if ((i + j) % 2 == 0)
                    {
                        cells[i, j].Background = Brushes.White;
                    }
                    else
                        cells[i, j].Background = Brushes.Brown;


                }
            }
        }
        private void btnContent(Button name)
        {
            var fig = lbFiguresDate.SelectedItem as FiguresData;
            switch (fig.Name)
            {
                case "Knight":
                    name.Content = "Kn";
                    break;
                case "Bishop":
                    name.Content = "B";
                    break;
                case "Rook":
                    name.Content = "R";
                    break;
                case "Queen":
                    name.Content = "Q";
                    break;
                case "King":
                    name.Content = "Ki";
                    break;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    cells[i, j].Content = String.Empty;
                }
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i == int.Parse(TBX1.Text)-1) && (j == int.Parse(TBY1.Text)-1))
                    {
                        if (prevButton != null)
                        {
                            prevButton.Content = "";
                        }
                        Button pressedButton = cells[i, j];

                        prevButton = pressedButton;
                        btnContent(prevButton);
                    }
                }
            }
        }

        private void btnOk1_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i == int.Parse(TBX2.Text) - 1) && (j == int.Parse(TBY2.Text) - 1))
                    {
                        if (prevButton != null)
                        {
                            prevButton.Content = "";
                        }
                        Button pressedButton = cells[i, j];

                        prevButton = pressedButton;
                        btnContent(prevButton);
                    }
                }
            }
        }
    }

}


    

       
    


