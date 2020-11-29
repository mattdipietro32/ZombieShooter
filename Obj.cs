using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace ZombieShooter
{
    public class Obj
    {
        public Vector2 position;
        public float rotation = 0.0f;
        public Texture2D spriteIndex;
        public string spriteName;
        public float speed = 0.0f;
        public float scale = 1.0f;
        public bool alive = true;
  

        public Obj(Vector2 pos)
        {
            position = pos;
        }

        public Obj()
        {

        }

        public virtual void Update()
        {
            if (!alive) return;
             MoveTo(speed, rotation);
      
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            //TODO: Make this dynamic
            if (!alive) return;
            Rectangle size;
               Vector2 center = new Vector2(spriteIndex.Width / 2, spriteIndex.Height / 2);
               spriteBatch.Draw(spriteIndex, position, null, Color.White, MathHelper.ToRadians(rotation), center, scale, SpriteEffects.None, 0);
        }

        //TODO: WHen this brakes, fix this  
        public virtual void LoadContent(ContentManager content, string spriteName)
        {
            this.spriteName = spriteName;
            spriteIndex = content.Load<Texture2D>(spriteName);
        }

        private void MoveTo(float speed, float dir)
        {
            float newX = (float)Math.Cos(MathHelper.ToRadians(dir));
            float newY = (float)Math.Sin(MathHelper.ToRadians(dir));
           
            position.X += speed * newX;
            position.Y += speed * newY;
        }

    }
}
