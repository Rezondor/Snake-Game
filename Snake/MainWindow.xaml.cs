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

namespace Snake
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Vector _moveVector = new (0,0);
        private const int _moveSpeed = 5;
        public MainWindow()
        {
            InitializeComponent();
            MoveSnake();
        }

        async void MoveSnake()
        {
            while (true)
            {
                int height = (int)Canvas.GetTop(Rect);
                Canvas.SetTop(Rect, height + _moveVector.Y);
                int width = (int)Canvas.GetLeft(Rect);
                Canvas.SetLeft(Rect, width + _moveVector.X);
                await Task.Delay(10);
            }
        }

        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Up:
                    _moveVector.X = 0;
                    _moveVector.Y = -_moveSpeed;
                    break;
                case Key.Down:
                    _moveVector.X = 0;
                    _moveVector.Y = _moveSpeed;
                    break;
                case Key.Right:
                    _moveVector.X = _moveSpeed;
                    _moveVector.Y = 0;
                    break;
                case Key.Left:
                    _moveVector.X = -_moveSpeed;
                    _moveVector.Y = 0;
                    break;
                default:
                    break;
            }
            
        }
    }
}
