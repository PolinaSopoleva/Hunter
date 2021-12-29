using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Collider
    {
        

        public bool testCollision(Point player, int playerWidth, int playerHeight, Point animal, int animalWidth, int animalHeight)
        {



             if ((player.X >= animal.X
                     && player.X < animal.X + animalWidth
                     && player.Y >= animal.Y
                     && player.Y < animal.Y + animalHeight)

                 || (player.X  >= animal.X
                     && player.X  < animal.X + animalWidth
                     && player.Y +playerHeight >= animal.Y
                     && player.Y + playerHeight < animal.Y + animalHeight)
                 || (player.X+ playerWidth/2 >= animal.X
                     && player.X + playerWidth/2 < animal.X + animalWidth
                     && player.Y + playerHeight/2 >= animal.Y
                     && player.Y + playerHeight /2< animal.Y + animalHeight)
                  || (player.X + playerWidth /2>= animal.X
                     && player.X + playerWidth/2 < animal.X + animalWidth
                     && player.Y + playerHeight >= animal.Y
                     && player.Y + playerHeight < animal.Y + animalHeight)
                     || (player.X + playerWidth / 3 >= animal.X
                     && player.X + playerWidth / 3 < animal.X + animalWidth
                     && player.Y + playerHeight >= animal.Y/3
                     && player.Y + playerHeight < animal.Y/3 + animalHeight)
                    || (player.X + playerWidth / 3 >= animal.X
                     && player.X + playerWidth / 3 < animal.X + animalWidth
                     && player.Y + playerHeight >= animal.Y/3
                     && player.Y + playerHeight < animal.Y/3 + animalHeight)



                           || (animal.X >= player.X
                              && animal.X < player.X + playerWidth
                              && animal.Y >= player.Y
                              && animal.Y < player.Y + playerHeight)
                           || (animal.X + animalWidth >= player.X
                              && animal.X < player.X + playerWidth
                              && animal.Y + animalWidth >= player.Y
                              && animal.Y < player.Y + playerHeight)
                           || (animal.X + animalWidth >= player.X
                              && animal.X + animalWidth < player.X + playerWidth
                              && animal.Y + animalHeight >= player.Y
                              && animal.Y + animalHeight < player.Y + playerHeight)
                           || (animal.X >= player.X
                              && animal.X < player.X + playerWidth
                              && animal.Y + animalHeight >= player.Y
                              && animal.Y + animalHeight < player.Y + playerHeight) ) {
                
                return false; }
             return true;
        }


    }
}
