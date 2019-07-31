using System;

namespace Coding_Exercise._Command
{
    public class Account
    {
        public int Balance { get; set; }
    
        public void Process(Command c)
        {
            switch (c.TheAction)
            {
                case Command.Action.Deposit:
                    Balance += c.Amount;
                    c.Success = true;
                    break;
                case Command.Action.Withdraw:
                    if (Balance>=c.Amount)
                    {
                        c.Success = true;
                        Balance -= c.Amount;
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}