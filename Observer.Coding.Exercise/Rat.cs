using System;

namespace Observer.Coding.Exercise
{
    public class Rat : IDisposable
    {
        private readonly Game game;
        public int Attack = 1;
      
        public Rat(Game game)
        {
            this.game = game;
            game.RatEnters += (sender, args) =>
            {
                if (sender != this)
                {
                    ++Attack;
                    game.FireNotifyRat(this, (Rat)sender);
                }
            };
            game.NotifyRat += (sender, rat) =>
            {
                if (rat == this) ++Attack;
            };
            game.RatDies += (sender, args) => --Attack;
            game.FireRatEnters(this);
        }
  
  
        public void Dispose()
        {
            game.FireRatDies(this);
        }
    }
}