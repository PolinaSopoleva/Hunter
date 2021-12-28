using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;
namespace Lab9
{
    class PlayerController
    {
        private int x = 10;
        private int y = 10;
        private int moveX = 0;
        private int moveY = 0;
        private int count = 0;
        private int speed = 5;

        private int width = 40;
        private int height = 60;

        private int directionV = 1;
        private int directionH = 0;
        private int clientSizeWidth;
        private int clientSizeHeight;
        private Keys keyCode;

        public PlayerController(int clientSizeWidth, int clientSizeHeight)
        {
            this.clientSizeWidth = clientSizeWidth;
            this.clientSizeHeight = clientSizeHeight;
        }

        public void reset()
        {
            keyCode = Keys.None;
            moveX = 0;
            moveY = 0;
        }


        public Point getPosition()
        {
            return new Point(x, y);
        }
        public Point getPlayerPosition()
        {
            if (keyCode == Keys.Left )
            {
                //moveX = x - 1 <= 0 ? 0 : -1;
                moveY = 0;
                if (x <= -20)
                {
                    x = clientSizeWidth + 20;
                }
                else
                {
                    moveX = -1;
                }
            }
            if (keyCode == Keys.Right )
            {
                //moveX = x + 1 >= clientSizeWidth - 58 ? 0 : 1;
                moveY = 0;
                if (x >= clientSizeWidth)
                {
                    x = 0 - 20;
                }
                else
                {
                    moveX = 1;
                }
            }
            if (keyCode == Keys.Up)
            {
                // moveY = y - 1 <= 0 ? 0 : -1;
                moveX = 0;
                if (y <= -40)
                {
                    y = clientSizeHeight + 40;
                }
                else
                {
                    moveY = -1;
                }
            }
            if (keyCode == Keys.Down )
            {
                //moveY = y + 1 >= clientSizeHeight - 80 ? 0 : 1;
                if (y >= clientSizeHeight)
                {
                    y = -40;
                }
                else
                {
                    moveY = 1;
                }

                // moveY = y + 1 >= clientSizeHeight - 80 ? 0 : 1;
                moveX = 0;
            }
            x = x + moveX * speed;
            y = y + moveY * speed;
            return new Point(x, y);
        }

        public void updatePlayerPosition(Keys keyCode)
        {
            this.keyCode = keyCode;
        }

        private bool borderTest(Point player, int pwidth, int pheight)
        {
            Point center = new Point(player.X + pwidth / 2, player.Y + pheight / 2);
            return center.X > 0
                && center.Y > 0
                && center.X < clientSizeWidth
                && center.Y < clientSizeHeight;
        }
    }
}
