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
        private int Largeur;
        private int Longueur;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
   
        protected override void Initialize()
        {
            Position = Vector2.Zero;                         //initialisation de la position de l'image
            Position2 = new Vector2(0, 3);
            Displacement = new Vector2(5, 3);                      //initialisation de son déplacement
            Largeur = Window.ClientBounds.Width;             //initialise la largeur pui la longueur de l'écran
            Longueur = Window.ClientBounds.Height;
                
            base.Initialize();

        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            Pika = Content.Load<Texture2D>("Pika");                     //chargement de l'image
            zonzor = Content.Load<Texture2D>("zonzor");

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }


        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            Position += Displacement;   //la position change pour chaque update ( on ajoute 1,1 aux coordonnées)

            if ((Displacement.X < 0 && Position.X <= 0) || (Displacement.X > 0 && Position.X + Pika.Width >= Largeur))
            {
                Displacement.X = -Displacement.X;
            }

            if ((Displacement.Y < 0 && Position.Y <= 0) || (Displacement.Y > 0 && Position.Y + Pika.Width >= Longueur))
            {
                Displacement.Y = -Displacement.Y;

                if ((Displacement.X < 0 && Position.X <= 0) || (Displacement.X > 0 && Position.X + zonzor.Width >= Largeur))
                {
                    Displacement.X = -Displacement.X;
                }

                if ((Displacement.Y < 0 && Position.Y <= 0) || (Displacement.Y > 0 && Position.Y + zonzor.Width >= Longueur))
                {
                    Displacement.Y = -Displacement.Y;
                }

                base.Update(gameTime);
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
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
