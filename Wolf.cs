using System;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Wolf : Collider
    {
        int y;
        int x;
        int speed;
        bool visible = true;

        private Point position;
        int width = 20;
        int height = 20;
        //bool toStart = false;
        Image wolf;

        int move = 1;
        bool direction;
        bool vertical;
        int counter = 0;
        int moving;
        int clientSizeHeight;
        bool testcollision;
        bool show;


        public Wolf(int x, int y, int speed, bool direction)
        {

            this.direction = direction;
            this.vertical = vertical;
            //if (vertical)
            //{
            wolf = Image.FromFile("..\\Resources\\wolf.png");

            executeAnimationTask();
            if (direction)
            {
                move = 1;
                moving = move;
            }
            else
            {
                move = -1;
                moving = move;
            }
            this.x = x;
            this.y = y;
            this.speed = speed;
            // position = point;
            // this.width = width;
            // this.height = height;
        }
        public Point getPosition()
        {
            return new Point(x, y);
        }
        public Point getWolfPosition(int clientSizeHeight)
        {
            if (testcollision)
            {
                this.clientSizeHeight = clientSizeHeight;
                //if (visible)
                //{
                y = y + move * speed;
                if (y > clientSizeHeight + 10)
                {
                    y = -150;
                    visible = true;
                }
                else if (y < -150)
                {
                    y = clientSizeHeight + 10;
                    visible = true;
                }
                //}
            }
            else
            {
                // y = -10;
                PutTaskDelay();
            }
            position = new Point(x, y);
            return position;
        }
        public void render(Graphics graphics, int clientSizeHeight, Point player, int playerWidth, int playerHeight, Point bullet, int bulletWidth, int bulletHeight, bool shooterMode)
        {
            //testCollision(player, pwidth, pheight);
            if (shooterMode)
            {
                if ((!(testCollision(bullet, bulletWidth, bulletHeight, getPosition(), 20, 20)) && (bullet != new Point(player.X+ playerWidth / 2,player.Y+ playerHeight / 2)))) { testcollision = false; }
                else { testcollision = true; }
            }
            else
            {
                if (!testCollision(player, playerWidth, playerHeight, getPosition(), 20, 20)) { testcollision = false; }
                else { testcollision = true; }
            }
                getWolfPosition(clientSizeHeight);
                if (show)
                {
                    graphics.DrawImage(wolf, position);
                }
                else
                {
                    graphics.DrawImage(wolf, position);
                }
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
        async Task PutTaskDelay()
        {
            //toStart = true;
            if (direction)
            {
                y = clientSizeHeight + 150;
            }
            else { y = -150; }
            move = 0;
            await Task.Delay(3000);
            move = moving;
            //toStart = false;
            //toStart = true;

            //show = false;
            //await Task.Delay(100);
        }

        /*  public bool testCollision(Point player, int pwidth, int pheight)
          {
              if (visible)
              {
                  //int centerX = player.X + pwidth / 2;
                  //int centerY = player.Y + pheight / 2;
                  //Point playerCenter=new Point { }

                  // Point pLeftUp = player;
                  //Point pLeftDown = new Point(player.X, player.Y - pheight);
                  //Point pRightUp = new Point(player.X + width, player.Y);
                  //Point pRightDown = new Point(player.X + width, player.Y - pheight); ;
                  Point mushroomCenter = new Point ( 1,3);
                  Point playerCenter = new Point(player.X + pwidth / 2, player.Y + pheight / 2);

                  if (playerCenter.X >= position.X + 20 / 2
                      && playerCenter.X < position.X + 20 / 2 + width
                      && playerCenter.Y >= position.Y + 30 / 2
                      && playerCenter.Y < position.Y + 30 / 2 + height
                      )
                  {
                      PutTaskDelay();
                      return false;
                  }
                  return true;
              }
              return true;
          }*/
        /*  if (!testCollision(player, playerWidth, playerHeight, getPosition(), 20, 20)
                  || !testCollision(sause, sauseWidth, sauseHeight, getPosition(), 20, 20)
                  ) { testcollision = false; }
              else { testcollision = true; }
              getMushroomPosition(clientSizeHeight);
              if (show)
              {
                  graphics.DrawImage(mushroomOnSide, position);
              }
              else
              {
                  graphics.DrawImage(mushroomV, position);
              }*/
  }
}
 