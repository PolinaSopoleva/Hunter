using System.Drawing;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Tomato : Collider
    {
        int y;
        int x;
        int speed;

        private Point position;
        int width = 20;
        int height = 20;
        bool toStart = false;
        public Image rabbit;
        Image rabbit;
        int move = 1;
        int moving = 1;
        bool testcollision;
        bool show;

        public Rabbit(int x, int y, int speed)
        {
            rabbit = Image.FromFile("..\\Resources\\rabbit.png");

            this.x = x;
            this.y = y;
            this.speed = speed;
            executeAnimationTask();
            // position = point;
            // this.width = width;
            // this.height = height;
        }
        public Point getPosition()
        {
            return new Point(x, y);
        }
        private async void executeAnimationTask()
        {
            await onSide();
            executeAnimationTask();
        }
        async Task onSide()
        {
            show = true;
            await Task.Delay(100);
            show = false;
            await Task.Delay(100);
        }
        public void render(Graphics graphics, int clientSizeWight, Point player, int playerWidth, int playerHeight, Point sause, int sauseWidth, int sauseHeight,bool shooterMode)
        {
            if (shooterMode)
            {
               // bool sssss;
                //if(sause != new Point(player.X + playerWidth / 2, player.Y + playerHeight / 2)) { sssss = true; } else { sssss = false; }


                if ((!(testCollision(bullet, bulletWidth, bulletHeight, getPosition(), 20, 20)) && (bullet != new Point(player.X+ playerWidth / 2,player.Y+ playerHeight / 2)))) { testcollision = false; }
                else { testcollision = true; }
            }
            else
            {
                if (!testCollision(player, playerWidth, playerHeight, getPosition(), 20, 20)) { testcollision = false; }
                else { testcollision = true; }
            }
            //testcollision = testCollision(player, playerWidth, playerHeight, getPosition(), 20, 20);
            //testCollision(player, pwidth, pheigh);

            draw(graphics, clientSizeWight);
        }
        bool visible = true;
        public void draw(Graphics graphics, int clientSizeWight)
        {
            if (testcollision)
            {
                x = x + move * speed;
                if (x > clientSizeWight + 10)
                {
                    x = -300;
                    visible = true;
                }
                position = new Point(x, y);

            }
            else
            {
                PutTaskDelay();
            }
            //testcollision = testCollision(player, playerWidth, playerHeight, getPosition(), 20, 20);

            if (show)
            {
                graphics.DrawImage(rabbit, position);
            }
            else
            {
                graphics.DrawImage(rabbit, position);
            }
        }

        /*private async void executeAnimationTask()
    {
        await PutTaskDelay();
        //executeAnimationTask();
    }*/
        async Task PutTaskDelay()
        {
            x = -300;
            move = 0;
            await Task.Delay(3000);
            move = moving;
            //toStart = true;

            //show = false;
            //await Task.Delay(100);
        }

        /*public bool testCollision(Point player, int pwidth, int pheight)
        {
            if (visible)
            {
                int centerX = player.X + pwidth / 2;
                int centerY = player.Y + pheight / 2;


                // Point pLeftUp = player;
                //Point pLeftDown = new Point(player.X, player.Y - pheight);
                //Point pRightUp = new Point(player.X + width, player.Y);
                //Point pRightDown = new Point(player.X + width, player.Y - pheight); ;

                if (centerX >= position.X + 20 / 2
                    && centerX < position.X + 20 / 2  + width
                    && centerY >= position.Y + 30 / 2
                    && centerY < position.Y + 30 / 2 + height)
                {
                    //x = -10;
                    // executeAnimationTask();
                    PutTaskDelay();

                   // visible = false;
                    return false;
                }
                return true;
            }
            return true;
        }*/
        /*if (!testCollision(player, playerWidth, playerHeight, getPosition(), 20, 20)
                || !testCollision(sause, sauseWidth, sauseHeight, getPosition(), 20, 20)
                ) { testcollision = false; }
            else { testcollision = true; }*/
    }
}
 