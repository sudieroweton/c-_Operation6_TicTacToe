using System;
using System.Windows;
using System.Windows.Media.Imaging;


namespace Operation6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[,] gameBoard;
        private int turn;
        private int gameStatus;
        private int numPositions;
        private BitmapImage[] imageArr;

        public MainWindow()
        {
            InitializeComponent();
            turn = 1;
            gameStatus = 0;
            numPositions = 0;

            imageArr = new BitmapImage[3];
            imageArr[0] = new BitmapImage(new Uri(@"img/x.png", UriKind.RelativeOrAbsolute)); 
            imageArr[1] = new BitmapImage(new Uri(@"img/o.jpg", UriKind.RelativeOrAbsolute)); 
            imageArr[2] = new BitmapImage(new Uri(@"img/blank.png", UriKind.RelativeOrAbsolute));

            gameBoard = new int[3, 3];
        }

        private void btnTopLeft_Click(object sender, RoutedEventArgs e)
        {
            if (gameBoard[0, 0] == 0) //checks if the space is open
            {
                if (turn == 1) //indicates that it is x's turn
                {
                    tlImg.Source = imageArr[0]; //place the x
                    gameBoard[0, 0] = 1; //put a marker in the array
                    turn = 2; //change the turn 
                    numPositions++;
                    checkForWinner(gameBoard, "tl", 1); //check for winner
                                  
                }
                else
                {
                    tlImg.Source = imageArr[1];
                    gameBoard[0, 0] = 2;
                    turn = 1;
                    numPositions++;
                    checkForWinner(gameBoard, "tl", 2);                   
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
                    numPositions++;
                    checkForWinner(gameBoard, "tc", 1);
                }
                else
                {
                    tcImg.Source = imageArr[1];
                    gameBoard[0, 1] = 2;
                    turn = 1;
                    numPositions++;
                    checkForWinner(gameBoard, "tc", 2);
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
                    numPositions++;
                    checkForWinner(gameBoard, "tr", 1);
                }
                else
                {
                    trImg.Source = imageArr[1];
                    gameBoard[0, 2] = 2;
                    turn = 1;
                    numPositions++;
                    checkForWinner(gameBoard, "tr", 2);
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
                    numPositions++;
                    checkForWinner(gameBoard, "ml", 1);
                }
                else
                {
                    mlImg.Source = imageArr[1];
                    gameBoard[1, 0] = 2;
                    turn = 1;
                    numPositions++;
                    checkForWinner(gameBoard, "ml", 2);
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
                    numPositions++;
                }
                else
                {
                    mcImg.Source = imageArr[1];
                    gameBoard[1, 1] = 2;
                    turn = 1;
                    numPositions++;
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
                    numPositions++;
                }
                else
                {
                    mrImg.Source = imageArr[1];
                    gameBoard[1, 2] = 2;
                    turn = 1;
                    numPositions++;
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
                    numPositions++;
                }
                else
                {
                    llImg.Source = imageArr[1];
                    gameBoard[2, 0] = 2;
                    turn = 1;
                    numPositions++;
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
                    numPositions++;
                }
                else
                {
                    lcImg.Source = imageArr[1];
                    gameBoard[2, 1] = 2;
                    turn = 1;
                    numPositions++;
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
                    numPositions++;
                }
                else
                {
                    lrImg.Source = imageArr[1];
                    gameBoard[2, 2] = 2;
                    turn = 1;
                    numPositions++;
                }
            }

        }

        private void checkForWinner(int[,] arr, string position, int which)
        {
            int feedBack = 0;
            //a feedBack of '0' means no winner yet
            //a feedBack of '1' means winner and is whoever called

            switch (position)
            {
                case "tl":
                    if (gameBoard[0, 0] == gameBoard[0, 1])
                    {
                        if (gameBoard[0, 1] == gameBoard[0, 2])
                        {
                            feedBack = 1;
                        }
                    }
                    if (gameBoard[0, 0] == gameBoard[1, 0])
                    {
                        if (gameBoard[1, 0] == gameBoard[2, 0])
                        {
                            feedBack = 1;
                        }
                    }
                    if (gameBoard[0, 0] == gameBoard[1, 1])
                    {
                        if (gameBoard[1, 1] == gameBoard[2, 2])
                        {
                            feedBack = 1;
                        }
                    }
                 
                    break;

                case "tc":
                    if(gameBoard[0,1] == gameBoard[0, 0])
                    {
                        if(gameBoard[0,0] == gameBoard[0, 2])
                        {
                            feedBack = 1;
                        }
                    }
                    if(gameBoard[0,1] == gameBoard[1, 1])
                    {
                        if(gameBoard[1,1] == gameBoard[2, 1])
                        {
                            feedBack = 1;
                        }
                    }
                   
                    break;

                case "tr":
                    if(gameBoard[0,2] == gameBoard[0, 1])
                    {
                        if(gameBoard[0,1] == gameBoard[0, 0])
                        {
                            feedBack = 1;    
                        }
                    }
                    if(gameBoard[0,2] == gameBoard[1, 1])
                    {
                        if(gameBoard[1,1] == gameBoard[2, 0])
                        {
                            feedBack = 1;
                        }
                    }
                    if(gameBoard[0,2] == gameBoard[1, 2])
                    {
                        if(gameBoard[1,2]== gameBoard[2, 2])
                        {
                            feedBack = 1;
                        }
                    }
                    break;

                case "ml":
                    if (gameBoard[1,0] == gameBoard[0, 0])
                    {
                        if (gameBoard[0, 0] == gameBoard[2,0])
                        {
                            feedBack = 1;
                        }
                    }
                    if (gameBoard[1,0] == gameBoard[1, 1])
                    {
                        if (gameBoard[1, 1] == gameBoard[1,2])
                        {
                            feedBack = 1;
                        }
                    }
                    break;
                case "mc":
                    break;
                case "mr":
                    break;
                case "ll":
                    break;
                case "lc":
                    break;
                case "lr":
                    break;
            }

            winOrTie(feedBack, which);
        }

        private void winOrTie(int result, int which)
        {
            if (result == 1)
            {

                winner(which);

            }
            else
            {
                if (numPositions == 9)
                {
                    tie();
                }
            }
        }

        private void winner(int which)
        {
            //x
            if(which == 1)
            {
                MessageBoxResult result = MessageBox.Show("X is the winner!", "Game Over", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                if (result == MessageBoxResult.OK)
                {
                    Application.Current.Shutdown();
                }
            }
            //o
            if(which == 2)
            {
                MessageBoxResult result = MessageBox.Show("O is the winner!", "Game Over", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                if (result == MessageBoxResult.OK)
                {
                    Application.Current.Shutdown();
                }
            }
        }

        private void tie()
        {
            MessageBoxResult result = MessageBox.Show("It's a Tie!", "Game Over", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            if (result == MessageBoxResult.OK)
            {
                Application.Current.Shutdown();
            }
        }

    }
}
