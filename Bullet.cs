using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    internal class Bullet : Collider
    {
        public Point playerPosition;
        int x;
        int y;
        Image bullet;
        Keys keyCode;
        bool visible = false;
        int playerWidth;
        int playerHeight;
        //String direction;
        bool left;
        bool right;
        bool up;
        bool down;
        int speed = 5;
        int clientSizeWidth;
        int clientSizeHeight;
        bool shoot;
        int i = 1;


        public Bullet(int playerWidth, int playerHeight, int clientSizeWidth, int clientSizeHeight)
        {
            //this.playerPosition = playerPosition;
            bullet = Image.FromFile("..\\Resources\\bullet.png");
            this.playerWidth = playerWidth;
            this.playerHeight = playerHeight;
            this.clientSizeWidth = clientSizeWidth;
            this.clientSizeHeight = clientSizeHeight;
        }

        public Point getPosition()
        {
            return new Point(x, y);
        }

        private void toStart(Point playerPosition)
        {
            x = playerPosition.X + playerWidth / 2;
            y = playerPosition.Y + playerHeight / 2;
        }

        public void changePosition(Graphics graphics, Point playerPosition, bool shoot)
        {
            if (!visible)
            {
                x = playerPosition.X + playerWidth / 2;
                y = playerPosition.Y + playerHeight / 2;
                if (shoot)
                {
                    if (keyCode == Keys.W)
                    {
                        //direction = "Up";
                        up = true;
                        fight(graphics, playerPosition);
                        visible = true;
                    }
                    if (keyCode == Keys.A)
                    {
                        left = true;
                        //direction = "Left";
                        fight(graphics, playerPosition);
                        visible = true;
                    }
                    if (keyCode == Keys.D)
                    {
                        right = true;
                        //direction = "Right";
                        fight(graphics, playerPosition);
                        visible = true;
                    }
                    if (keyCode == Keys.S)
                    {
                        down = true;
                        //direction = "Down";
                        fight(graphics, playerPosition);
                        visible = true;
                    }
                }
            }
            else
            {
                fight(graphics, playerPosition);
            }

        }
        public void updatePosition(Keys keyCode)
        {
            this.keyCode = keyCode;

        }
        async Task PutTaskDelay()
        {
            await Task.Delay(1000);
        }
        public void reset()
        {
            this.keyCode = keyCode = Keys.None;

        }

        public void fight(Graphics graphics, Point playerPosition)
        {
            if (left)
            {
                if (x < -20)
                {
                    //i = 1;
                    toStart(playerPosition);
                    visible = false;
                    left = false;
                }
                else
                {
                    x = x - i * speed;
                    //i =i+ 1;
                    graphics.DrawImage(bullet, x, y);
                }
            }
            else if (right)
            {
                if (x > clientSizeWidth + 20)
                {
                    toStart(playerPosition);
                    visible = false;
                    right = false;
                }
                else
                {
                    x = x + 1 * speed;
                    graphics.DrawImage(bullet, x, y);
                }
            }
            else if (up)
            {
                if (y < -20)
                {
                    toStart(playerPosition);
                    visible = false;
                    up = false;
                }
                else
                {
                    y = y - 1 * speed;
                    graphics.DrawImage(bullet, x, y);
                }
            }
            else if (down)
            {
                if (y > clientSizeHeight + 20)
                {
                    toStart(playerPosition);
                    visible = false;
                    down = false;
                }
                else
                {
                    y = y + 1 * speed;
                    graphics.DrawImage(bullet, x, y);
                }
            }
        }

    }
}
