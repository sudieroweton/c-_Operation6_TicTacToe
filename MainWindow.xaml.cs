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

namespace Operation6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[,] gameBoard;
        private int turn;
        private BitmapImage[] imageArr;

        public MainWindow()
        {
            InitializeComponent();
            turn = 1;

            imageArr = new BitmapImage[3];
            imageArr[0] = new BitmapImage(new Uri(@"img/x.png", UriKind.RelativeOrAbsolute)); 
            imageArr[1] = new BitmapImage(new Uri(@"img/o.jpg", UriKind.RelativeOrAbsolute)); 
            imageArr[2] = new BitmapImage(new Uri(@"img/blank.png", UriKind.RelativeOrAbsolute));

            gameBoard = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameBoard[i, j] = 0;
                }
            }
        }

        private void btnTopLeft_Click(object sender, RoutedEventArgs e)
        {
            //tlImg.Source = imageArr[0];
            if (gameBoard[0, 0] == 0)
            {
                if (turn == 1)
                {
                    tlImg.Source = imageArr[0];
                    gameBoard[0, 0] = 1;
                    turn = 2;
                }
                else
                {
                    tlImg.Source = imageArr[1];
                    gameBoard[0, 0] = 2;
                    turn = 1;
                }
            }

        }

        private void btnTopCenter_Click(object sender, RoutedEventArgs e)
        {
            if (gameBoard[0, 1] == 0)
            {
                if (turn == 1)
                {
                    tcImg.Source = imageArr[0];
                    gameBoard[0, 1] = 1;
                    turn = 2;
                }
                else
                {
                    tcImg.Source = imageArr[1];
                    gameBoard[0, 1] = 2;
                    turn = 1;
                }
            }


        }

        private void btnTopRight_Click(object sender, RoutedEventArgs e)
        {
            if (gameBoard[0, 2] == 0)
            {
                if (turn == 1)
                {
                    trImg.Source = imageArr[0];
                    gameBoard[0, 2] = 1;
                    turn = 2;
                }
                if (turn == 2)
                {
                    trImg.Source = imageArr[1];
                    gameBoard[0, 2] = 2;
                    turn = 1;
                }
            }


        }

        private void btnMidLeft_Click(object sender, RoutedEventArgs e)
        {
            if (gameBoard[1, 0] == 0)
            {
                if (turn == 1)
                {
                    mlImg.Source = imageArr[0];
                    gameBoard[1, 0] = 1;
                    turn = 2;
                }
                else
                {
                    mlImg.Source = imageArr[1];
                    gameBoard[1, 0] = 2;
                    turn = 1;
                }
            }


        }

        private void btnMidCenter_Click(object sender, RoutedEventArgs e)
        {
            if (gameBoard[1, 1] == 0)
            {
                if (turn == 1)
                {
                    mcImg.Source = imageArr[0];
                    gameBoard[1, 1] = 1;
                    turn = 2;
                }
                else
                {
                    mcImg.Source = imageArr[1];
                    gameBoard[1, 1] = 2;
                    turn = 1;
                }
            }


        }

        private void btnMidRight_Click(object sender, RoutedEventArgs e)
        {
            if (gameBoard[1, 2] == 0)
            {
                if (turn == 1)
                {
                    mrImg.Source = imageArr[0];
                    gameBoard[1, 2] = 1;
                    turn = 2;
                }
                else
                {
                    mrImg.Source = imageArr[1];
                    gameBoard[1, 2] = 2;
                    turn = 1;
                }
            }

        }

        private void btnLowLeft_Click(object sender, RoutedEventArgs e)
        {
            if (gameBoard[2, 0] == 0)
            {
                if (turn == 1)
                {
                    llImg.Source = imageArr[0];
                    gameBoard[2, 0] = 1;
                    turn = 2;
                }
                else
                {
                    llImg.Source = imageArr[1];
                    gameBoard[2, 0] = 2;
                    turn = 1;
                }
            }

        }

        private void btnLowCenter_Click(object sender, RoutedEventArgs e)
        {
            if (gameBoard[2, 1] == 0)
            {
                if (turn == 1)
                {
                    lcImg.Source = imageArr[0];
                    gameBoard[2, 1] = 1;
                    turn = 2;
                }
                else
                {
                    lcImg.Source = imageArr[1];
                    gameBoard[2, 1] = 2;
                    turn = 1;
                }
            }

        }

        private void btnLowRight_Click(object sender, RoutedEventArgs e)
        {
            if (gameBoard[2, 2] == 0)
            {
                if (turn == 1)
                {
                    lrImg.Source = imageArr[0];
                    gameBoard[2, 2] = 1;
                    turn = 2;
                }
                else
                {
                    lrImg.Source = imageArr[1];
                    gameBoard[2, 2] = 2;
                    turn = 1;
                }
            }

        }

    }
}
