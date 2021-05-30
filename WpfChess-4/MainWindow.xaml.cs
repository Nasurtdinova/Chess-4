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

            chessBoard.Rows = 8;
            chessBoard.Columns = 8;



           
        }

    

       
    }
}

