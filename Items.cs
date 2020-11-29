using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ZombieShooter
{
    public class Items
    {
        public static List<Obj> objList = new List<Obj>();

        public static void Initialize()
        {
            //Adds bullets. It doesn't start updating or drawing the bullets until the bullets are fired
            for (int i = 0; i < 64; i++)
            {
                Obj bullet = new Bullet(Vector2.Zero);
                bullet.alive = false;
                objList.Add(bullet);
            }
            objList.Add(new Man(new Vector2(50, 50)));
        }

        public static void Reset()
        {
            foreach (Obj obj in objList)
            {
                obj.alive = false;
            }
        }
    }
}
