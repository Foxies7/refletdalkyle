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
        private Texture2D mob0;
        private int Largeur;
        private int Longueur;
        private int Speed = 2;
        private int Speed_mob = 1;
        private int Droite = 0;
        private int Haut = 0;
        private int Bas = 0;
        private Vector2 Position;
        private Vector2 Position_mob;
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
            link0 = Content.Load<Texture2D>("21");   //chargement de l'image
            Position = new Vector2(Largeur / 4 - link0.Width / 2, Longueur / 2 - link0.Height / 2); 
            mob0 = Content.Load<Texture2D>("goku0");
            Position_mob = new Vector2(3 * Largeur / 4 -mob0.Width / 2, Longueur / 2 - mob0.Height / 2); 
             //place les deux images de chaque coté de l'écran (comme dans un jeu de combat 2D) 

        }

        protected override void UnloadContent()
        {

        }


        protected override void Update(GameTime gameTime)
        {
            keyboard = Keyboard.GetState();


            #region -Collision Bords-
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
            #endregion

            #region -Mouvements Mob-
            if (keyboard.IsKeyDown(Keys.D))
            {
                Position_mob.X += Speed_mob;
            }

            if (keyboard.IsKeyDown(Keys.Q))
            {
                Position_mob.X -= Speed_mob;
            }

            if (keyboard.IsKeyDown(Keys.S))
            {
                Position_mob.Y += Speed_mob;
            }

            if (keyboard.IsKeyDown(Keys.Z))
            {
                Position_mob.Y -= Speed_mob;
            }
            #endregion

            #region -Mouvements en Haut-

            if (keyboard.IsKeyDown(Keys.Up))                   //si la touche up est enfoncée...
            {
                if ((Haut == 0) || (Haut == 1) || (Haut == 2))
                {
                    link0 = Content.Load<Texture2D>("1");
                    Haut++;
                }

                else if ((Haut == 3) || (Haut == 4) || ( Haut == 5))
                {
                    link0 = Content.Load<Texture2D>("2");
                    Haut++;
                }

                else if ((Haut == 6) || (Haut == 7) || (Haut == 8))
                {
                    link0 = Content.Load<Texture2D>("3");
                    Haut++;
                }

                else if ((Haut == 9) || (Haut == 10) || (Haut == 11))
                {
                    link0 = Content.Load<Texture2D>("4");
                    Haut++;
                }

                else if ((Haut == 12) || (Haut == 13) || (Haut == 14))
                {
                    link0 = Content.Load<Texture2D>("5");
                    Haut++;
                }

                else if ((Haut == 15) || (Haut == 16) || (Haut == 17))
                {
                    link0 = Content.Load<Texture2D>("6");
                    Haut++;
                }

                else if ((Haut == 18) || (Haut == 19) || (Haut == 20))
                {
                    link0 = Content.Load<Texture2D>("7");
                    Haut++;
                }

                else if ((Haut == 21) || (Haut == 22) || (Haut == 23))
                {
                    link0 = Content.Load<Texture2D>("8");
                    Haut++;
                }

                else if ((Haut == 24) || (Haut == 25) || (Haut == 26))
                {
                    link0 = Content.Load<Texture2D>("9");
                    Haut++;
                }

                else if ((Haut == 27) || (Haut == 28) || (Haut == 29))
                {
                    link0 = Content.Load<Texture2D>("10");
                    Haut++;
                }

                else if ((Haut == 30) || (Haut == 31))
                {
                    link0 = Content.Load<Texture2D>("11");
                    Haut++;
                }

                else if (Haut == 32)
                {
                    link0 = Content.Load<Texture2D>("11");
                    Haut -= 32;
                }
                    
                    Position.Y -= Speed;
            }
#endregion

            #region -Mouvements en Bas-

            if (keyboard.IsKeyDown(Keys.Down))
            {
                if ((Bas == 0) || (Bas == 1) || (Bas == 2))
                {
                    link0 = Content.Load<Texture2D>("23");
                    Bas++;
                }

                else if ((Bas == 3) || (Bas == 4) || (Bas == 5))
                {
                    link0 = Content.Load<Texture2D>("24");
                    Bas++;
                }

                else if ((Bas == 6) || (Bas == 7) || (Bas == 8))
                {
                    link0 = Content.Load<Texture2D>("25");
                    Bas++;
                }

                else if ((Bas == 9) || (Bas == 10) || (Bas == 11))
                {
                    link0 = Content.Load<Texture2D>("26");
                    Bas++;
                }

                else if ((Bas == 12) || (Bas == 13) || (Bas == 14))
                {
                    link0 = Content.Load<Texture2D>("27");
                    Bas++;
                }

                else if ((Bas == 15) || ( Bas == 16) || (Bas == 17))
                {
                    link0 = Content.Load<Texture2D>("28");
                    Bas++;
                }

                else if ((Bas == 18) || (Bas == 19) || (Bas == 20))
                {
                    link0 = Content.Load<Texture2D>("29");
                    Bas++;
                }

                else if ((Bas == 21) || (Bas == 22))
                {
                    link0 = Content.Load<Texture2D>("30");
                    Bas++;
                }

                else if (Bas == 23)
                {
                    link0 = Content.Load<Texture2D>("30");
                    Bas -= 23;
                }


                    Position.Y += Speed;
            }
#endregion

            //pour savoir si une touche est relachée on utilise IsKeyUp(Keys."le nom de la touche") sisi!

            #region -Mouvements à Droite-
            if (keyboard.IsKeyDown(Keys.Right))                
            {
                if ((Droite == 0) || (Droite == 1) || (Droite == 2))
                {
                    link0 = Content.Load<Texture2D>("12");
                    Droite++;
                }

                else if ((Droite == 3) || (Droite == 4) || (Droite == 5))
                {
                    link0 = Content.Load<Texture2D>("13");
                    Droite++;
                }

                else if ((Droite == 6) || (Droite == 7) || (Droite == 8))
                {
                    link0 = Content.Load<Texture2D>("14");
                    Droite++;
                }

                else if ((Droite == 9) || (Droite == 10) || (Droite == 11))
                {
                    link0 = Content.Load<Texture2D>("15");
                    Droite++;
                }

                else if ((Droite == 12) || (Droite == 13) || (Droite == 14))
                {
                    link0 = Content.Load<Texture2D>("16");
                    Droite++;
                }

                else if ((Droite == 15) || (Droite == 16) || (Droite == 17))
                {
                    link0 = Content.Load<Texture2D>("17");
                    Droite++;
                }

                else if ((Droite == 18) || (Droite == 19) || (Droite == 20))
                {
                    link0 = Content.Load<Texture2D>("18");
                    Droite++;
                }

                else if ((Droite == 21) || (Droite == 22) || (Droite == 23))
                {
                    link0 = Content.Load<Texture2D>("19");
                    Droite++;
                }

                else if ((Droite == 24) || (Droite == 25))
                {
                    link0 = Content.Load<Texture2D>("20");
                    Droite++;
                }

                else if (Droite == 26)
                {
                    link0 = Content.Load<Texture2D>("20");
                    Droite -= 26;
                }
                    Position.X += Speed;
            }
            #endregion

            #region -Mouvements à Gauche-
            if (keyboard.IsKeyDown(Keys.Left))
            {
                    Position.X -= Speed;
            }
            #endregion


                        
            base.Update(gameTime);

        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            spriteBatch.Begin();                                                       //affiche image pour la déplacer 
            spriteBatch.Draw(link0, Position, Color.White);
            spriteBatch.Draw(mob0, Position_mob, Color.White);
            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}

