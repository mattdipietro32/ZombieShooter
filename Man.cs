using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ZombieShooter
{
    public class Man : Obj
    {
        KeyboardState keyboard;
        KeyboardState previousKeyboard;
        float speed;
        MouseState mouse;
        MouseState previousMouse;

        public Man(Vector2 pos) : base(pos)
        {
            position = pos;
            speed = 3.0f;
            spriteName = "man";
        }

        public override void Update()
        {
            //Gets the current state of the keyboard, as of that frame
            keyboard = Keyboard.GetState();
            mouse = Mouse.GetState();
            //Implement what you want to happen during a game loop frame


            //Move the man UP if the w key is pressed
            if (keyboard.IsKeyDown(Keys.W))
            {
                position.Y -= speed;
            }
            if (keyboard.IsKeyDown(Keys.S))
            {
                position.Y += speed;
            }
            if (keyboard.IsKeyDown(Keys.A))
            {
                position.X -= speed;
            }
            if (keyboard.IsKeyDown(Keys.D))
            {
                position.X += speed;
            }

            rotation = PointDirection(position.X, position.Y,
                                        mouse.X, mouse.Y);

            //Assigned all the keyboard stuff has been done to get the previous state
            previousKeyboard = keyboard;
            previousMouse = mouse;
            base.Update();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            scale = 0.5f;
            base.Draw(spriteBatch);
        }

        public float PointDirection(float x, float y, float x2, float y2)
        {
            float diffx = x - x2;
            float diffy = y - y2;
            float tan = diffy / diffx;
            float res = MathHelper.ToDegrees((float)Math.Atan2(diffy, diffx));
            res = (res - 180) % 360;
            if (res < 0) { res += 360; }
            return res;
        }
    }
}
