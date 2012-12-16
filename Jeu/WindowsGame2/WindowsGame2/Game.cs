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

namespace WindowsGame2
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private Texture2D link0;        //on créé un attribut
        private int Largeur;
        private int Longueur;
        private int Speed = 1;
        private Vector2 Position;
        private KeyboardState keyboard;  //état du clavier

        public Game()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {
            Largeur = Window.ClientBounds.Width;             //prend la largeur et longueur de la fenêtre
            Longueur = Window.ClientBounds.Height;

            base.Initialize();

        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            link0 = Content.Load<Texture2D>("0");   //chargement de l'image
            Position = new Vector2(Largeur / 2 - link0.Width / 2, Longueur / 2 - link0.Height / 2);


        }

        protected override void UnloadContent()
        {

        }


        protected override void Update(GameTime gameTime)
        {
            keyboard = Keyboard.GetState();

            if (keyboard.IsKeyDown(Keys.Up))                   //si la touche up est effoncée...
            {
                Position.Y -= Speed;
            }
            else if (keyboard.IsKeyDown(Keys.Down))
            {
                Position.Y += Speed;
            }

            if (keyboard.IsKeyDown(Keys.Right))                //pour savoir si une touche est relachée on utilise IsKeyUp(Keys.) sisi!
            {
                Position.X += Speed;
            }
            else if (keyboard.IsKeyDown(Keys.Left))
            {
                Position.X -= Speed;
            }
            base.Update(gameTime);

        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            spriteBatch.Begin();                                                       //affiche image et la déplace 
            spriteBatch.Draw(link0, Position, Color.White);
            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}

