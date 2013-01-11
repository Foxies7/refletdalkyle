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

        int sexyviolon;
        int sexysaxo;

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

        Texture2D fondMenu;
        MouseEvent mouseEvent;
        Song musiqueMenu;


        public Menu()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
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

            graphics.ToggleFullScreen();
            sexysaxo = Window.ClientBounds.Height; //Variables de troll pour hauteur
            sexyviolon = Window.ClientBounds.Width; //et longueur

            mouseEvent = new MouseEvent();
            base.IsMouseVisible = true;

            graphics.ApplyChanges();

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            

            fondMenu = Content.Load<Texture2D>("ecrantitre");

            boutonBonus.LoadContent(Content, "bonus");
            boutonBonus.Position = new Vector2((3 * sexyviolon / 4), 4 * sexysaxo / 7);
            boutonBonusSelect.LoadContent(Content, "bonusq");
            boutonBonusSurvol.LoadContent(Content, "bonus_surbrillance");

            boutonChargerDONTDOTHIS.LoadContent(Content, "chargerpartie_inactif");
            boutonChargerDONTDOTHIS.Position = new Vector2(3 * sexyviolon / 4, 2 * sexysaxo / 7);
            boutonChargerPartie.LoadContent(Content, "chargerpartievrai");
            boutonChargerSelect.LoadContent(Content, "chargerpartie");
            boutonChargerSurvol.LoadContent(Content, "chargerpartie_surbrillance");

            boutonNouveauJeu.LoadContent(Content, "nouveaujeuvrai");
            boutonNouveauJeu.Position = new Vector2(3 * sexyviolon / 4, sexysaxo / 7);
            boutonNouveauJeuSelect.LoadContent(Content, "nouveaujeu");
            boutonNouveauJeuSurvol.LoadContent(Content, "nouveaujeu_surbrillance");

            boutonOptions.LoadContent(Content, "options");
            boutonOptions.Position = new Vector2(3 * sexyviolon / 4, 3 * sexysaxo / 7);
            boutonOptionsSelect.LoadContent(Content, "optionsyf");
            boutonOptionsSurvol.LoadContent(Content, "options_surbrillance");

            musiqueMenu = Content.Load<Song>("Compo");
            MediaPlayer.Play(musiqueMenu);

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // Les quatre "if" suivants vérifient si la souris passe sur un bouton.
            // Si oui, elle change la texture du dit bouton
            // Elle vérifie également si on clique sur la souris, auquel cas elle change la texture puis réalise l'action voulue, cad rien pour l'instant \o/
            if (mouseEvent.getMouseRectangle().Intersects(boutonBonus.getContainer()))
            {
                if (mouseEvent.UpdateMouse() == true)
                    this.Exit();
            }

            if (mouseEvent.getMouseRectangle().Intersects(boutonChargerPartie.getContainer()))
            {
                if (mouseEvent.UpdateMouse() == true)
                    this.Exit();
            }

            if (mouseEvent.getMouseRectangle().Intersects(boutonNouveauJeu.getContainer()))
            {
                if (mouseEvent.UpdateMouse() == true)
                    this.Exit();
            }

            if (mouseEvent.getMouseRectangle().Intersects(boutonOptions.getContainer()))
            {
                if (mouseEvent.UpdateMouse() == true)
                    this.Exit();
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            spriteBatch.Draw(fondMenu, Vector2.Zero, Color.White);

            boutonBonus.Draw(spriteBatch);
            boutonChargerDONTDOTHIS.Draw(spriteBatch);            
            boutonNouveauJeu.Draw(spriteBatch);
            boutonOptions.Draw(spriteBatch);
            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
