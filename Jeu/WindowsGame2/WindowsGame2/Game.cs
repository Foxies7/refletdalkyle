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

        private Texture2D link0;        //on cr�� un attribut
        private Texture2D mob0;
        private int Largeur;
        private int Longueur;
        private int Speed = 1 ;
        private int Speed0 = 2;
        private int Gauche = 0;
        private int Droite = 0;
        private int Haut = 0;
        private int Bas = 0;
        private int batard = 2;
        private Texture2D ecran;
        private Rectangle r_Sprite1, r_Sprite2;
        private int hauteurR_link = 24;
        private int largeurR_link = 19;
        private int hauteurR_mob = 65;
        private int largeurR_mob = 66;
        private KeyboardState keyboard;  //�tat du clavier

        public Game()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {
            
            Largeur = Window.ClientBounds.Width;             //prend la largeur et longueur de la fen�tre
            Longueur = Window.ClientBounds.Height;
            r_Sprite1 = new Rectangle(Largeur / 2, Longueur / 2 , largeurR_link, hauteurR_link);

            r_Sprite2 = new Rectangle(60, 80, largeurR_mob, hauteurR_mob);

            base.Initialize();

        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            link0 = Content.Load<Texture2D>("21");
            mob0 = Content.Load<Texture2D>("arbre");   //chargement de l'image 
             //place les deux images de chaque cot� de l'�cran (comme dans un jeu de combat 2D) 
            /*ecran = Content.Load<Texture2D>("ground"); */
        }

        protected override void UnloadContent()
        {

        }


        protected override void Update(GameTime gameTime)
        {
            keyboard = Keyboard.GetState();

            if (Keyboard.GetState().IsKeyDown(Keys.Escape))               // on quitte si echap
                this.Exit();

            #region Collision 

            if (r_Sprite1.X < r_Sprite2.X)
            {
                if (r_Sprite1.Intersects(r_Sprite2))
                    r_Sprite1.X -= Speed;     
            }
            else
                if (r_Sprite1.X >= r_Sprite2.X)
                {
                    if (r_Sprite1.Intersects(r_Sprite2))
                        r_Sprite1.X += Speed;
                }
            #endregion




            #region -Bords-

            if (r_Sprite1.X <= 1)
            {
                r_Sprite1.X = 1;
            }

            else if (r_Sprite1.X >= (Largeur - link0.Width))
            {
                r_Sprite1.X -= Speed;
            }

            else if (r_Sprite1.Y <= 1)
            {
                r_Sprite1.Y = 1;
            }

            else if (r_Sprite1.Y >= (Longueur - link0.Height))
            {
                r_Sprite1.Y -= Speed;
            }
            #endregion
            
            
            
            //pour savoir si une touche est relach�e on utilise IsKeyUp(Keys."le nom de la touche") sisi! LOL

            if (Keyboard.GetState().IsKeyDown(Keys.RightShift))
            {
                Speed = Speed0 + 2;
            }

            else
                Speed = Speed0;
       

            #region-Position Statique-
            if (keyboard.IsKeyUp(Keys.Up) && (batard == 1))
            {
                link0 = Content.Load<Texture2D>("5");
            }

            else if (keyboard.IsKeyUp(Keys.Down) && (batard == 2))
            {
                link0 = Content.Load<Texture2D>("21");
            }

            else if (keyboard.IsKeyUp(Keys.Right) && (batard == 3))
            {
                link0 = Content.Load<Texture2D>("20");
            }

            else if (keyboard.IsKeyUp(Keys.Left) && (batard == 4))
            {
                link0 = Content.Load<Texture2D>("39");
            }
            #endregion

            #region -Mouvements en Haut-

            if (keyboard.IsKeyDown(Keys.Up))                   //si la touche up est enfonc�e...
            {
                batard = 1;
                if ((Haut == 0) || (Haut == 1) || (Haut == 2))
                {
                    link0 = Content.Load<Texture2D>("1");
                    r_Sprite1.Y--;
                    Haut++;
                }

                else if ((Haut == 3) || (Haut == 4) || ( Haut == 5))
                {
                    link0 = Content.Load<Texture2D>("2");
                    r_Sprite1.Y--;
                    Haut++;
                }

                else if ((Haut == 6) || (Haut == 7) || (Haut == 8))
                {
                    link0 = Content.Load<Texture2D>("3");
                    r_Sprite1.Y--;
                    Haut++;
                }

                else if ((Haut == 9) || (Haut == 10) || (Haut == 11))
                {
                    link0 = Content.Load<Texture2D>("4");
                    r_Sprite1.Y--;
                    Haut++;
                }

                else if ((Haut == 12) || (Haut == 13) || (Haut == 14))
                {
                    link0 = Content.Load<Texture2D>("5");
                    r_Sprite1.Y--;
                    Haut++;
                }

                else if ((Haut == 15) || (Haut == 16) || (Haut == 17))
                {
                    link0 = Content.Load<Texture2D>("6");
                    r_Sprite1.Y--;
                    Haut++;
                }

                else if ((Haut == 18) || (Haut == 19) || (Haut == 20))
                {
                    link0 = Content.Load<Texture2D>("7");
                    r_Sprite1.Y--;
                    Haut++;
                }

                else if ((Haut == 21) || (Haut == 22) || (Haut == 23))
                {
                    link0 = Content.Load<Texture2D>("8");
                    r_Sprite1.Y--;
                    Haut++;
                }

                else if ((Haut == 24) || (Haut == 25) || (Haut == 26))
                {
                    link0 = Content.Load<Texture2D>("9");
                    r_Sprite1.Y--;
                    Haut++;
                }

                else if ((Haut == 27) || (Haut == 28) || (Haut == 29))
                {
                    link0 = Content.Load<Texture2D>("10");
                    r_Sprite1.Y--;
                    Haut++;
                }

                else if ((Haut == 30) || (Haut == 31))
                {
                    link0 = Content.Load<Texture2D>("11");
                    r_Sprite1.Y--;
                    Haut++;
                }

                else if (Haut == 32)
                {
                    link0 = Content.Load<Texture2D>("11");
                    r_Sprite1.Y--;
                    Haut -= 32;
                }

                r_Sprite1.Y -= Speed - 1;
            }
#endregion

            #region -Mouvements en Bas-

            if (keyboard.IsKeyDown(Keys.Down))
            {
                batard = 2;
                if ((Bas == 0) || (Bas == 1) || (Bas == 2))
                {
                    link0 = Content.Load<Texture2D>("23");
                    r_Sprite1.Y++;
                    Bas++;
                }

                else if ((Bas == 3) || (Bas == 4) || (Bas == 5))
                {
                    link0 = Content.Load<Texture2D>("24");
                    r_Sprite1.Y++;
                    Bas++;
                }

                else if ((Bas == 6) || (Bas == 7) || (Bas == 8))
                {
                    link0 = Content.Load<Texture2D>("25");
                    r_Sprite1.Y++;
                    Bas++;
                }

                else if ((Bas == 9) || (Bas == 10) || (Bas == 11))
                {
                    link0 = Content.Load<Texture2D>("26");
                    r_Sprite1.Y++;
                    Bas++;
                }

                else if ((Bas == 12) || (Bas == 13) || (Bas == 14))
                {
                    link0 = Content.Load<Texture2D>("27");
                    r_Sprite1.Y++;
                    Bas++;
                }

                else if ((Bas == 15) || ( Bas == 16) || (Bas == 17))
                {
                    link0 = Content.Load<Texture2D>("28");
                    r_Sprite1.Y++;
                    Bas++;
                }

                else if ((Bas == 18) || (Bas == 19) || (Bas == 20))
                {
                    link0 = Content.Load<Texture2D>("29");
                    r_Sprite1.Y++;
                    Bas++;
                }

                else if ((Bas == 21) || (Bas == 22))
                {
                    link0 = Content.Load<Texture2D>("30");
                    r_Sprite1.Y++;
                    Bas++;
                }

                else if (Bas == 23)
                {
                    link0 = Content.Load<Texture2D>("30");
                    r_Sprite1.Y++;
                    Bas -= 23;
                }


                r_Sprite1.Y += Speed -1;
            }
#endregion
                        
            #region -Mouvements � Droite-
            if (keyboard.IsKeyDown(Keys.Right))                
            {
                batard = 3;
                if ((Droite == 0) || (Droite == 1) || (Droite == 2))
                {
                    link0 = Content.Load<Texture2D>("12");
                    r_Sprite1.X++;
                    Droite++;
                }

                else if ((Droite == 3) || (Droite == 4) || (Droite == 5))
                {
                    link0 = Content.Load<Texture2D>("13");
                    r_Sprite1.X++;
                    Droite++;
                }

                else if ((Droite == 6) || (Droite == 7) || (Droite == 8))
                {
                    link0 = Content.Load<Texture2D>("14");
                    r_Sprite1.X++;
                    Droite++;
                }

                else if ((Droite == 9) || (Droite == 10) || (Droite == 11))
                {
                    link0 = Content.Load<Texture2D>("15");
                    r_Sprite1.X++;
                    Droite++;
                }

                else if ((Droite == 12) || (Droite == 13) || (Droite == 14))
                {
                    link0 = Content.Load<Texture2D>("16");
                    r_Sprite1.X++;
                    Droite++;
                }

                else if ((Droite == 15) || (Droite == 16) || (Droite == 17))
                {
                    link0 = Content.Load<Texture2D>("17");
                    r_Sprite1.X++;
                    Droite++;
                }

                else if ((Droite == 18) || (Droite == 19) || (Droite == 20))
                {
                    link0 = Content.Load<Texture2D>("18");
                    r_Sprite1.X++;
                    Droite++;
                }

                else if ((Droite == 21) || (Droite == 22) || (Droite == 23))
                {
                    link0 = Content.Load<Texture2D>("19");
                    r_Sprite1.X++;
                    Droite++;
                }

                else if ((Droite == 24) || (Droite == 25))
                {
                    link0 = Content.Load<Texture2D>("20");
                    r_Sprite1.X++;
                    Droite++;
                }

                else if (Droite == 26)
                {
                    link0 = Content.Load<Texture2D>("20");
                    Droite -= 26;
                }
                r_Sprite1.X += Speed -1;
            }
            #endregion

            #region -Mouvements � Gauche-
            if (keyboard.IsKeyDown(Keys.Left))
            {
                batard = 4;
                if ((Gauche == 0) || (Gauche == 1) || (Gauche == 2) || (Gauche == 3))
                {
                    link0 = Content.Load<Texture2D>("39");
                    r_Sprite1.X--;
                    Gauche++;
                }

                if ((Gauche == 4) || (Gauche == 5) || (Gauche == 6) || (Gauche == 7))
                {
                    link0 = Content.Load<Texture2D>("38");
                    r_Sprite1.X--;
                    Gauche++;
                }

                if ((Gauche == 8) || (Gauche == 9) || (Gauche == 10) || (Gauche == 11))
                {
                    link0 = Content.Load<Texture2D>("37");
                    r_Sprite1.X--;
                    Gauche++;
                }

                if ((Gauche == 12) || (Gauche == 13) || (Gauche == 14) || (Gauche == 15))
                {
                    link0 = Content.Load<Texture2D>("36");
                    r_Sprite1.X--;
                    Gauche++;
                }

                if ((Gauche == 16) || (Gauche == 17) || (Gauche == 18) || (Gauche == 19))
                {
                    link0 = Content.Load<Texture2D>("35");
                    r_Sprite1.X--;
                    Gauche++;
                }

                if ((Gauche == 20) || (Gauche == 21) || (Gauche == 22) || (Gauche == 23))
                {
                    link0 = Content.Load<Texture2D>("34");
                    r_Sprite1.X--;
                    Gauche++;
                }

                if ((Gauche == 24) || (Gauche == 25) || (Gauche == 26) || (Gauche == 27))
                {
                    link0 = Content.Load<Texture2D>("33");
                    r_Sprite1.X--;
                    Gauche++;
                }

                if ((Gauche == 28) || (Gauche == 29) || (Gauche == 30))
                {
                    link0 = Content.Load<Texture2D>("32");
                    r_Sprite1.X--;
                    Gauche++;
                }

                if ((Gauche == 31) || (Gauche == 32))
                {
                    link0 = Content.Load<Texture2D>("31");
                    r_Sprite1.X--;
                    Gauche++;
                }

                else if (Gauche == 33)
                {
                    link0 = Content.Load<Texture2D>("31");
                    r_Sprite1.X--;
                    Gauche -= 33;
                }

                r_Sprite1.X -= Speed -1;  
            }
            #endregion

            
            base.Update(gameTime);

        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            spriteBatch.Begin();                                                       //affiche image pour la d�placer
            /*spriteBatch.Draw(ecran, Vector2.Zero, Color.White); */
            spriteBatch.Draw(link0, r_Sprite1, Color.White);
            spriteBatch.Draw(mob0, r_Sprite2, Color.White);
            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}



