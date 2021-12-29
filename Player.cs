using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Player
    {

        public Image hunter;

        bool show = true;

        public Player()
        {
            hunter = Image.FromFile("..\\Resources\\hunter.png");
            executeAnimationTask();
        }

        private async void executeAnimationTask()
        {
            await PutTaskDelay();
            executeAnimationTask();
        }

        async Task PutTaskDelay()
        {
            show = true;
            await Task.Delay(1000);
            show = false;
            await Task.Delay(100);
        }

        public void render(Graphics graphics, Point point)
        {
            if (show)
            {
                graphics.DrawImage(hunter, point);
            }
            else
            {
                graphics.DrawImage(hunter, point);
            }
        }


    }
}
