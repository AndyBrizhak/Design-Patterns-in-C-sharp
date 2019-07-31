using System;

namespace Coding_Exercise._Command
{
    public class Command
    {
//        public Command(Action theAction, int amount, bool success)
//        {
//            TheAction = theAction;
//            Amount = amount;
//            Success = success;
//        }

        public enum Action
        {
            Deposit,
            Withdraw
        }
    
        public Action TheAction;
        public int Amount;
        public bool Success;

        
          
    }
}