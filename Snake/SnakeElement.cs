
using System.Windows;
using System.Windows.Shapes;

namespace Snake;

public class SnakeElement
{
    private Rectangle _snakeRectangle;
    private Point _snakePosition;
    private SnakeElement _childSnakeElement;
    private Vector _snakeMotionVector;
}
