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
    
    public class Game : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private Texture2D link0;        //on créé un attribut
        private int Largeur;
        private int Longueur;
        private int Speed = 2;
        private int Droite = 0;
        private int Haut = 0;
        private int Bas = 0;
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
            link0 = Content.Load<Texture2D>("1");   //chargement de l'image
            Position = new Vector2(Largeur / 2 - link0.Width / 2, Longueur / 2 - link0.Height / 2); //place initialement l'image au centre


        }

        protected override void UnloadContent()
        {

        }


        protected override void Update(GameTime gameTime)
        {
            keyboard = Keyboard.GetState();

           

            if (Position.X <= 0)
            {
                Position.X += Speed;
            }

            else if (Position.X >= (Largeur - link0.Width))
            {
                Position.X -= Speed;
            }

            else if (Position.Y <= 0)
            {
                Position.Y += Speed;
            }

            else if (Position.Y >= (Longueur - link0.Height))
            {
                Position.Y -= Speed;
            }

            #region -Mouvements en Haut-
       
            if (keyboard.IsKeyDown(Keys.Up))                   //si la touche up est enfoncée...
            {
                if (Haut == 0)
                {
                    link0 = Content.Load<Texture2D>("1");
                    Haut++;
                }

                else if (Haut == 1)
                {
                    link0 = Content.Load<Texture2D>("2");
                    Haut++;
                }

                else if (Haut == 2)
                {
                    link0 = Content.Load<Texture2D>("3");
                    Haut++;
                }

                else if (Haut == 3)
                {
                    link0 = Content.Load<Texture2D>("4");
                    Haut++;
                }

                else if (Haut == 4)
                {
                    link0 = Content.Load<Texture2D>("5");
                    Haut++;
                }

                else if (Haut == 5)
                {
                    link0 = Content.Load<Texture2D>("6");
                    Haut++;
                }

                else if (Haut == 6)
                {
                    link0 = Content.Load<Texture2D>("7");
                    Haut++;
                }

                else if (Haut == 7)
                {
                    link0 = Content.Load<Texture2D>("8");
                    Haut++;
                }

                else if (Haut == 8)
                {
                    link0 = Content.Load<Texture2D>("9");
                    Haut++;
                }

                else if (Haut == 9)
                {
                    link0 = Content.Load<Texture2D>("10");
                    Haut++;
                }

                else if (Haut ==10)
                {
                    link0 = Content.Load<Texture2D>("11");
                    Haut -= 10;
                }
                    Position.Y -= Speed;
            }
#endregion

            #region -Mouvements en Bas-

            if (keyboard.IsKeyDown(Keys.Down))
            {
                if (Bas == 0)
                {
                    link0 = Content.Load<Texture2D>("23");
                    Bas++;
                }

                else if (Bas == 1)
                {
                    link0 = Content.Load<Texture2D>("24");
                    Bas++;
                }

                else if (Bas == 2)
                {
                    link0 = Content.Load<Texture2D>("25");
                    Bas++;
                }

                else if (Bas == 3)
                {
                    link0 = Content.Load<Texture2D>("26");
                    Bas++;
                }

                else if (Bas == 4)
                {
                    link0 = Content.Load<Texture2D>("27");
                    Bas++;
                }

                else if (Bas == 5)
                {
                    link0 = Content.Load<Texture2D>("28");
                    Bas++;
                }

                else if (Bas == 6)
                {
                    link0 = Content.Load<Texture2D>("29");
                    Bas++;
                }

                else if (Bas == 7)
                {
                    link0 = Content.Load<Texture2D>("30");
                    Bas++;
                }

                else if (Bas == 8)
                {
                    link0 = Content.Load<Texture2D>("31");
                    Bas++;
                }

                else if (Bas == 9)
                {
                    link0 = Content.Load<Texture2D>("32");
                    Bas -= 9;
                }

                    Position.Y += Speed;
            }
#endregion

            //pour savoir si une touche est relachée on utilise IsKeyUp(Keys."le nom de la touche") sisi!

            #region -Mouvements à Droite-
            if (keyboard.IsKeyDown(Keys.Right))                
            {
                if (Droite == 0)
                {
                    link0 = Content.Load<Texture2D>("12");
                    Droite++;
                }

                else if (Droite == 1)
                {
                    link0 = Content.Load<Texture2D>("13");
                    Droite++;
                }

                else if (Droite == 2)
                {
                    link0 = Content.Load<Texture2D>("14");
                    Droite++;
                }

                else if (Droite == 3)
                {
                    link0 = Content.Load<Texture2D>("15");
                    Droite++;
                }

                else if (Droite == 4)
                {
                    link0 = Content.Load<Texture2D>("16");
                    Droite++;
                }

                else if (Droite == 5)
                {
                    link0 = Content.Load<Texture2D>("17");
                    Droite++;
                }

                else if (Droite == 6)
                {
                    link0 = Content.Load<Texture2D>("18");
                    Droite++;
                }

                else if (Droite == 7)
                {
                    link0 = Content.Load<Texture2D>("19");
                    Droite++;
                }

                else if (Droite == 8)
                {
                    link0 = Content.Load<Texture2D>("20");
                    Droite++;
                }

                else if (Droite == 9)
                {
                    link0 = Content.Load<Texture2D>("21");
                    Droite++;
                }

                else if (Droite == 10)
                {
                    link0 = Content.Load<Texture2D>("22");
                    Droite -= 10;
                }
                    Position.X += Speed;
            }
            #endregion


            if (keyboard.IsKeyDown(Keys.Left))
            {
                    Position.X -= Speed;
            }
            

            base.Update(gameTime);

        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            spriteBatch.Begin();                                                       //affiche image pour la déplacer 
            spriteBatch.Draw(link0, Position, Color.White);
            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}

