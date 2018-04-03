using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using printfEngine.printfHelpers;
using printfEngine.printf;

namespace printfEngine
{
    public class monogameClass : Game
    {
        public static Point fontSize = renameThisGameClass.characterSize;   //do not delete, only change sizes accordingly to match font or else it will cause errors in drawing to screen//
        public static GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public static int millisecondsPerFrame = 300; //Update every 30ms
        double timeSinceLastUpdate = 0; //Accumulate the elapsed time
        public static Texture2D FontSheet;
        drawBuffer characterDrawBuffer;

        public monogameClass()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        protected override void Initialize()
        {
            base.Initialize();
            Components.Add(characterDrawBuffer);
        }
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            FontSheet = this.Content.Load<Texture2D>(@"FontSheets\Cheepicus_12x12");
            renameThisGameClass.Initialise();
            characterDrawBuffer = new drawBuffer(this);
        }
        protected override void UnloadContent()
        {
            spriteBatch.Dispose();
            characterDrawBuffer.Dispose();
            Components.Clear();
            FontSheet.Dispose();
            renameThisGameClass.Unload();
        }
        protected override void Update(GameTime gameTime)
        {

            timeSinceLastUpdate += gameTime.ElapsedGameTime.TotalMilliseconds;

            renameThisGameClass.Update(gameTime);
            if (timeSinceLastUpdate > millisecondsPerFrame)
            {
                timeSinceLastUpdate = 0;
                millisecondsPerFrame = 1000 / MathHelper.Clamp(renameThisGameClass.framesPerSecond, 1, 120);
                renameThisGameClass.Draw();
            }
            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();
            characterDrawBuffer.Draw(gameTime);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
