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

namespace Menu
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Menu : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        #region -Définition des boutons & int-
        int sexyviolon;
        int sexysaxo;

        public Rectangle container;

        Bouton boutonBonus;
        Bouton boutonBonusSurvol;
        Bouton boutonBonusSelect;
        Bouton boutonChargerPartie;
        Bouton boutonChargerSurvol;
        Bouton boutonChargerSelect;
        Bouton boutonChargerDONTDOTHIS;
        Bouton boutonNouveauJeu;
        Bouton boutonNouveauJeuSurvol;
        Bouton boutonNouveauJeuSelect;
        Bouton boutonOptions;
        Bouton boutonOptionsSurvol;
        Bouton boutonOptionsSelect;
        Bouton boutonQuitter;
        Bouton boutonQuitterSurvol;
        Bouton boutonQuitterSelect;

        Bouton boutonRetour;
        Bouton boutonRetourSurvol;
        Bouton boutonRetourSelect;
        Bouton boutonFenetre;
        Bouton boutonFenetreSurvol;
        #endregion

        #region -Définition des booléens & fond du menu & musique-

        bool survolquitter = false;
        bool selectquitter = false;
        bool survoloptions = false;
        bool selectoptions = false;
        bool survolnouveau = false;
        bool selectnouveau = false;
        bool survolbonus = false;
        bool selectbonus = false;
        bool display = true;
        bool displayopts = false;
        bool survolretour = false;
        bool selectretour = false;
        bool survolfenetre = false;

        Texture2D fondMenu;
        Song musiqueMenu;

        #endregion


        public Menu()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {

            #region -Initialisation des boutons-

            container = new Rectangle();
            boutonBonus = new Bouton();
            boutonBonusSelect = new Bouton();
            boutonBonusSurvol = new Bouton();
            boutonChargerPartie = new Bouton();
            boutonChargerDONTDOTHIS = new Bouton();
            boutonChargerSelect = new Bouton();
            boutonChargerSurvol = new Bouton();
            boutonNouveauJeu = new Bouton();
            boutonNouveauJeuSelect = new Bouton();
            boutonNouveauJeuSurvol = new Bouton();
            boutonOptions = new Bouton();
            boutonOptionsSelect = new Bouton();
            boutonOptionsSurvol = new Bouton();
            boutonQuitter = new Bouton();
            boutonQuitterSelect = new Bouton();
            boutonQuitterSurvol = new Bouton();

            boutonRetour = new Bouton();
            boutonRetourSelect = new Bouton();
            boutonRetourSurvol = new Bouton();
            boutonFenetre = new Bouton();
            boutonFenetreSurvol = new Bouton();

            #endregion

            this.graphics.IsFullScreen = false;
            sexyviolon = graphics.PreferredBackBufferWidth = 1920;
            sexysaxo = graphics.PreferredBackBufferHeight = 1080;

            Window.Title = "Menu";


            this.IsMouseVisible = true;

            graphics.ApplyChanges();

            base.Initialize();
        }


        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);



            fondMenu = Content.Load<Texture2D>("ecrantitre");

            #region -Bouton Nouveau Jeu-

            boutonNouveauJeu.LoadContent(Content, "nouveaujeuvrai"); // NOUVEAU JEU
            boutonNouveauJeu.Position = new Vector2(3 * sexyviolon / 4, sexysaxo / 10);
            boutonNouveauJeuSelect.LoadContent(Content, "nouveaujeu");
            boutonNouveauJeuSelect.Position = boutonNouveauJeu.Position;
            boutonNouveauJeuSurvol.LoadContent(Content, "nouveaujeu_surbrillance");
            boutonNouveauJeuSurvol.Position = boutonNouveauJeu.Position;

            #endregion

            #region -Bouton Charger Partie-

            boutonChargerDONTDOTHIS.LoadContent(Content, "chargerpartie_inactif"); // CHARGER PARTIE
            boutonChargerDONTDOTHIS.Position = new Vector2(3 * sexyviolon / 4, sexysaxo / 10 + 100);
            boutonChargerPartie.LoadContent(Content, "chargerpartievrai");
            boutonChargerPartie.Position = boutonChargerDONTDOTHIS.Position;
            boutonChargerSelect.LoadContent(Content, "chargerpartie");
            boutonChargerSelect.Position = boutonChargerDONTDOTHIS.Position;
            boutonChargerSurvol.LoadContent(Content, "chargerpartie_surbrillance");
            boutonChargerSurvol.Position = boutonChargerDONTDOTHIS.Position;

            #endregion

            #region -Bouton Bonus-

            boutonBonus.LoadContent(Content, "bonus"); // BONUS
            boutonBonus.Position = new Vector2((3 * sexyviolon / 4), sexysaxo / 10 + 200);
            boutonBonusSelect.LoadContent(Content, "bonusq");
            boutonBonusSelect.Position = boutonBonus.Position;
            boutonBonusSurvol.LoadContent(Content, "bonus_surbrillance");
            boutonBonusSurvol.Position = boutonBonus.Position;

            #endregion

            #region -Bouton Options-

            boutonOptions.LoadContent(Content, "options"); //OPTIONS
            boutonOptions.Position = new Vector2(3 * sexyviolon / 4, sexysaxo / 10 + 300);
            boutonOptionsSelect.LoadContent(Content, "optionsyf");
            boutonOptionsSelect.Position = boutonOptions.Position;
            boutonOptionsSurvol.LoadContent(Content, "options_surbrillance");
            boutonOptionsSurvol.Position = boutonOptions.Position;

            #endregion

            #region -Bouton Quitter-

            boutonQuitter.LoadContent(Content, "quitter"); // QUITTER
            boutonQuitter.Position = new Vector2(3 * sexyviolon / 4, sexysaxo / 10 + 400);
            boutonQuitterSelect.LoadContent(Content, "quitterSelect");
            boutonQuitterSelect.Position = boutonQuitter.Position;
            boutonQuitterSurvol.LoadContent(Content, "quitterSurvol");
            boutonQuitterSurvol.Position = boutonQuitter.Position;

            #endregion

            #region -Bouton Retour-

            boutonRetour.LoadContent(Content, "retour"); // RETOUR
            boutonRetour.Position = new Vector2((3 * sexyviolon / 4) - 200, sexysaxo / 10 + 300);
            boutonRetourSelect.LoadContent(Content, "retourSelect");
            boutonRetourSelect.Position = boutonRetour.Position;
            boutonRetourSurvol.LoadContent(Content, "retourSurvol");
            boutonRetourSurvol.Position = boutonRetour.Position;

            #endregion

            #region -Bouton Fenetre-

            boutonFenetre.LoadContent(Content, "fenetre"); // FENETRE
            boutonFenetre.Position = new Vector2((3 * sexyviolon / 4) - 200, sexysaxo / 10 + 400);
            boutonFenetreSurvol.LoadContent(Content, "fenetreSurvol");
            boutonFenetreSurvol.Position = boutonFenetre.Position;

            #endregion

            musiqueMenu = Content.Load<Song>("Compo");
            MediaPlayer.Play(musiqueMenu);

        }


        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }


        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            MouseState mouse = Mouse.GetState();

            #region -Surbrillance & sélection-

            // Bouton Options
            if ((mouse.X >= boutonOptions.Position.X && mouse.X <= boutonOptions.Position.X + 200)
                && (mouse.Y >= boutonOptions.Position.Y && mouse.Y <= boutonOptions.Position.Y + 100) && display)
            {
                survoloptions = true;
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    selectoptions = true;
                    survoloptions = false;                 // On désactive tous les boutons
                    display = false;                       // et on affiche les nouveaux
                    displayopts = true;
                    selectnouveau = false;
                    survolnouveau = false;
                    selectbonus = false;
                    survolbonus = false;
                    selectquitter = false;
                    survolquitter = false;
                    selectretour = false;
                }
            }

            else
                survoloptions = false;



            // Bouton Nouveau Jeu
            if ((mouse.X >= boutonNouveauJeu.Position.X && mouse.X <= boutonNouveauJeu.Position.X + 200)
                && (mouse.Y >= boutonNouveauJeu.Position.Y && mouse.Y <= boutonNouveauJeu.Position.Y + 100) && display) // sous-entendu display == true
            // si la souris rencontre le bouton, les booleens changent
            {                                                                  // ce qui draw les boutons dans la méthode Draw
                survolnouveau = true;
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    selectnouveau = true;
                    survolnouveau = false;
                }
                else
                    selectnouveau = false;
            }
            else
                survolnouveau = false;

            // Bouton Bonus
            if ((mouse.X >= boutonBonus.Position.X && mouse.X <= boutonBonus.Position.X + 200)
                && (mouse.Y >= boutonBonus.Position.Y && mouse.Y <= boutonBonus.Position.Y + 100) && display)
            {
                survolbonus = true;
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    selectbonus = true;
                    survolbonus = false;
                }
                else
                {
                    selectbonus = false;
                }
            }

            else
                survolbonus = false;


            // Bouton Quitter
            if ((mouse.X >= boutonQuitter.Position.X && mouse.X <= boutonQuitter.Position.X + 200)
                && (mouse.Y >= boutonQuitter.Position.Y && mouse.Y <= boutonQuitter.Position.Y + 100) && display)
            {
                survolquitter = true;
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    selectquitter = true;
                    survolquitter = false;
                }
                else
                {
                    selectquitter = false;
                }
            }

            else
                survolquitter = false;

            #endregion

            #region -Boutons des options-

            // Bouton Retour
            if ((mouse.X >= boutonRetour.Position.X && mouse.X <= boutonRetour.Position.X + 200)
                    && (mouse.Y >= boutonRetour.Position.Y && mouse.Y <= boutonRetour.Position.Y + 100) && displayopts)
            {
                survolretour = true;
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    selectoptions = false;
                    selectretour = true;
                    survolretour = false;
                    displayopts = false;
                    display = true;
                }
            }

            else
                survolretour = false;

            // Bouton Fenêtré
            if ((mouse.X >= boutonFenetre.Position.X && mouse.X <= boutonFenetre.Position.X + 200)
                    && (mouse.Y >= boutonFenetre.Position.Y && mouse.Y <= boutonFenetre.Position.Y + 100) && displayopts)
            {
                survolfenetre = true;
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    survolfenetre = false;
                    graphics.ToggleFullScreen();
                }
            }

            else
                survolfenetre = false;


            #endregion

            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            spriteBatch.Draw(fondMenu, Vector2.Zero, Color.White);

            if (display == true)
            {
                boutonNouveauJeu.Draw(spriteBatch);
                boutonChargerDONTDOTHIS.Draw(spriteBatch);
                boutonOptions.Draw(spriteBatch);
                boutonBonus.Draw(spriteBatch);
                boutonQuitter.Draw(spriteBatch);
            }
            if (displayopts == true)
            {
                boutonRetour.Draw(spriteBatch);
                boutonFenetre.Draw(spriteBatch);
            }

            #region -Affichage des boutons survolés et sélectionnés du menu-

            if (selectnouveau) // si nouveau jeu est sélectionné (le booleen est vrai) ET options n'a pas encore été cliqué, on affiche le bouton sélectionné
            {                                   // on affiche le bouton sélectionné
                boutonNouveauJeuSelect.Draw(spriteBatch);
            }

            if (survolnouveau) // si nouveau jeu est sélectionné ET options n'a pas encore été cliqué (les booleens sont vrais)
            {                                   // on affiche le bouton survolé
                boutonNouveauJeuSurvol.Draw(spriteBatch);
            }


            if (selectbonus)   // Même principe pour les suivants, le but est de gérer les affichages successifs des boutons en fonction de "Options"
            {
                boutonBonusSelect.Draw(spriteBatch);
            }

            if (survolbonus)
            {
                boutonBonusSurvol.Draw(spriteBatch);
            }

            if (selectoptions && selectretour != true)
            {
                boutonOptionsSelect.Draw(spriteBatch);
            }

            if (survoloptions)
            {
                boutonOptionsSurvol.Draw(spriteBatch);
            }

            if (selectquitter)
            {
                boutonQuitterSelect.Draw(spriteBatch);
                this.Exit(); // Quitte le jeu si cliqué
            }

            if (survolquitter)
            {
                boutonQuitterSurvol.Draw(spriteBatch);
            }

            #endregion

            #region -Affichage des boutons après le clic sur le bouton option-

            if (selectretour && selectoptions != true)
            {
                boutonOptions.Draw(spriteBatch);
            }

            if (survolretour)
            {
                boutonRetourSurvol.Draw(spriteBatch);
            }

            if (survolfenetre)
            {
                boutonFenetreSurvol.Draw(spriteBatch);
            }

            #endregion
            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
