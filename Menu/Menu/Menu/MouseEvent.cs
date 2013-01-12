using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Menu
{
    class MouseEvent
    {

        MouseState mouse = Mouse.GetState();
        public MouseEvent()
        {

        }


        public Rectangle getMouseRectangle()
        {
            Rectangle mouseRectangle;
            mouseRectangle = new Rectangle((int)mouse.X,
                (int)mouse.Y, 1, 1);
            return mouseRectangle;
        }

        

    }
}
