using System;

namespace Behavioral.NullObject
{
    public class Account
    {
        private ILog log;
  
        public Account(ILog log)
        {
            this.log = log;
        }
  
        public void SomeOperation()
        {
            int c = log.RecordCount;
            log.LogInfo("Performing an operation");
            if (c+1 != log.RecordCount)
                throw new Exception();
            if (log.RecordCount >= log.RecordLimit)
                throw new Exception();
        }
    }
}