using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace WindowsGame1
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private Texture2D Pika;     //on créé un attribut
        private Texture2D zonzor;
        private Vector2 Position;
        private Vector2 Position2;
        private Vector2 Displacement;
        private Vector2 Displacement2;
        private int Largeur;
        private int Longueur;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        
   
        protected override void Initialize()
        {
            Position = Vector2.Zero;                         //initialisation de la position de l'image
            Position2 = new Vector2(0, 5);
            Displacement = new Vector2(3, 2);                      //initialisation de son déplacement
            Displacement2 = new Vector2(2, 3);
            Largeur = Window.ClientBounds.Width;             //prend la largeur et longueur de la fenêtre
            Longueur = Window.ClientBounds.Height;
                
            base.Initialize();

        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            Pika = Content.Load<Texture2D>("Pika");                     //chargement de l'image
            zonzor = Content.Load<Texture2D>("zonzor");

        }

        protected override void UnloadContent()
        {
            
        }


        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            Position += Displacement;   //la position change pour chaque update 
            Position2 += Displacement2;

            if ((Displacement.X < 0 && Position.X <= 0) || (Displacement.X > 0 && Position.X + Pika.Width >= Largeur))
            {
                Displacement.X = -Displacement.X;
            }

            if ((Displacement.Y < 0 && Position.Y <= 0) || (Displacement.Y > 0 && Position.Y + Pika.Width >= Longueur))
            {
                Displacement.Y = -Displacement.Y;
            }

            if ((Displacement2.X < 0 && Position2.X <= 0) || (Displacement2.X > 0 && Position2.X + zonzor.Width >= Largeur))
                {
                    Displacement2.X = -Displacement2.X;
                }

            if ((Displacement2.Y < 0 && Position2.Y <= 0) || (Displacement2.Y > 0 && Position2.Y + zonzor.Width >= Longueur))
                {
                    Displacement2.Y = -Displacement2.Y;
                }

                base.Update(gameTime);
            
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Yellow);

            spriteBatch.Begin();                                                       //affiche image et la déplace 
            spriteBatch.Draw(Pika, Position,Color.White);
            spriteBatch.Draw(zonzor, Position2, Color.White);          
            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
