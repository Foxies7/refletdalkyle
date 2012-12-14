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

        private Texture2D zonzor;        //on créé un attribut
        private int Largeur;
        private int Longueur;
        private Vector2 Position;
        private KeyboardState keyboard;  //état du clavier

        public Game1()
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
            zonzor = Content.Load<Texture2D>("zonzor");   //chargement de l'image
            Position = new Vector2(Largeur / 2 - zonzor.Width / 2, Longueur / 2 - zonzor.Height / 2);
            

        }

        protected override void UnloadContent()
        {
            
        }


        protected override void Update(GameTime gameTime)
        {
            keyboard = Keyboard.GetState();

            if (keyboard.IsKeyDown(Keys.Up))                   //si la touche up est effoncée...
            {
                Position.Y -= 2;                                
            }
            else if (keyboard.IsKeyDown(Keys.Down))
            {
                Position.Y += 2;
            }

            if (keyboard.IsKeyDown(Keys.Right))                //pour savoir si une touche est relachée on utilise IsKeyUp(Keys.) sisi!
            {
                Position.X += 2;
            }
            else if (keyboard.IsKeyDown(Keys.Left))
            {
                Position.X -= 2;
            }
            base.Update(gameTime);
            
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Yellow);

            spriteBatch.Begin();                                                       //affiche image et la déplace 
            spriteBatch.Draw(zonzor, Position, Color.White);          
            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
