// The main state of the game.

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ZEngine.Source.Graphics;
using ZEngine.Source.Objects;

namespace ZEngine.Source.States
{
    internal class Main : State
    {
        private State currentState;

        private LevelState levelState;

        public Main()
        {
            // Set States
            levelState = new LevelState();

            // Set Current State
            currentState = levelState;
        }

        public override void OnUpdate(GameTime gameTime)
        {
            // Update Current State
            currentState.Update(gameTime);
        }

        public override void OnDraw(SpriteBatch spriteBatch)
        {
            // Draw Current State
            currentState.OnDraw(spriteBatch);
        }
    }
}
