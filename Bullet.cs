using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;



namespace ZombieShooter
{
    public class Bullet : Obj
    {
        public Bullet(Vector2 pos) : base(pos)
        {
            position = pos;
            spriteName = "bullet";
            scale = 0.20f;
        }
    }
}
