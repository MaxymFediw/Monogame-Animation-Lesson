using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Monogame_Animation_Lesson
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //Maxym F.

        //             ---SLIGHT SEIZURE WARNING---

        Rectangle window;

        Random generator1, generator2, generator3, generator4;

        Texture2D tribbleBrownTexture, tribbleCreamTexture, tribbleGreyTexture, tribbleOrangeTexture;

        Rectangle brownTribbleRect, creamTribbleRect, greyTribbleRect, orangeTribbleRect;
        Vector2 brownTribbleSpeed, creamTribbleSpeed, greyTribbleSpeed, orangeTribbleSpeed;

        SoundEffect tribbleSound;

        Color backColor;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            window = new Rectangle(0, 0, 800, 600);

            generator1 = new Random();

            generator2 = new Random();

            generator3 = new Random();

            generator4 = new Random();


            int start1, start2, start3, start4;

            start1 = generator1.Next(1, 400);

            start2 = generator2.Next(1, 400);

            start3 = generator3.Next(1, 400);

            start4 = generator4.Next(1, 400);

            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();

                                     //      (X,  Y)
            brownTribbleRect = new Rectangle(start1, start4, 100, 100); 

            creamTribbleRect = new Rectangle(start2, start1, 100, 100);

            greyTribbleRect = new Rectangle(start3, start2, 100, 100);

            orangeTribbleRect = new Rectangle(start4, start3, 100, 100);

            brownTribbleSpeed = new Vector2(2, 2);
            creamTribbleSpeed = new Vector2(3, 0);
            greyTribbleSpeed = new Vector2(0, 8);
            orangeTribbleSpeed = new Vector2(12, 7);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            tribbleBrownTexture = Content.Load<Texture2D>("tribbleBrown");

            tribbleCreamTexture = Content.Load<Texture2D>("tribbleCream");

            tribbleGreyTexture = Content.Load<Texture2D>("tribbleGrey");

            tribbleOrangeTexture = Content.Load<Texture2D>("tribbleOrange");

            tribbleSound = Content.Load<SoundEffect>("tribble_coo");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            

            brownTribbleRect.X += (int)brownTribbleSpeed.X;
            if (brownTribbleRect.Right >= window.Width || brownTribbleRect.Left <= 0) 
            {
                brownTribbleSpeed.X *= -1;

                tribbleSound.Play();

                backColor = Color.Pink;
            }
            brownTribbleRect.Y += (int)brownTribbleSpeed.Y;
            if (brownTribbleRect.Bottom >= window.Height || brownTribbleRect.Top <= 0) 
            {
                brownTribbleSpeed.Y *= -1;

                tribbleSound.Play();

                backColor = Color.Pink;
            }


            creamTribbleRect.X += (int)creamTribbleSpeed.X;
            if (creamTribbleRect.Right >= window.Width || creamTribbleRect.Left <= 0)
            {
                creamTribbleSpeed.X *= -1;

                tribbleSound.Play();

                backColor = Color.Purple;
            }
            creamTribbleRect.Y += (int)creamTribbleSpeed.Y;
            if (creamTribbleRect.Bottom >= window.Height || creamTribbleRect.Top <= 0)
            {
                creamTribbleSpeed.Y *= -1;

                tribbleSound.Play();

                backColor = Color.Purple;
            }

            
            greyTribbleRect.X += (int)greyTribbleSpeed.X;
            if (greyTribbleRect.Right >= window.Width || greyTribbleRect.Left <= 0)
            {
                greyTribbleSpeed.X *= -1;

                tribbleSound.Play();

                backColor = Color.Lime;
            }
            greyTribbleRect.Y += (int)greyTribbleSpeed.Y;
            if (greyTribbleRect.Bottom >= window.Height || greyTribbleRect.Top <= 0)
            {
                greyTribbleSpeed.Y *= -1;

                tribbleSound.Play();

                backColor = Color.Lime;
            }

           
            orangeTribbleRect.X += (int)orangeTribbleSpeed.X;
            if (orangeTribbleRect.Right >= window.Width || orangeTribbleRect.Left <= 0)
            {
                orangeTribbleSpeed.X *= -1;

                tribbleSound.Play();

                backColor = Color.Red;
            }
            orangeTribbleRect.Y += (int)orangeTribbleSpeed.Y;
            if (orangeTribbleRect.Bottom >= window.Height || orangeTribbleRect.Top <= 0)
            {
                orangeTribbleSpeed.Y *= -1;

                tribbleSound.Play();

                backColor = Color.Red;
            }



            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(backColor);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(tribbleBrownTexture, brownTribbleRect, Color.White);

            _spriteBatch.Draw(tribbleCreamTexture, creamTribbleRect, Color.White);

            _spriteBatch.Draw(tribbleGreyTexture, greyTribbleRect, Color.White);

            _spriteBatch.Draw(tribbleOrangeTexture, orangeTribbleRect, Color.White);

            _spriteBatch.End();
            
            base.Draw(gameTime);
        }
    }
}
