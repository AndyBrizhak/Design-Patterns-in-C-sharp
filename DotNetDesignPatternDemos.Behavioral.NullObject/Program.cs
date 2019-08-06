namespace DotNetDesignPatternDemos.Behavioral.NullObject
{
  public class Demo
  {
    static void Main()
    {
      //var log = new ConsoleLog();
      //ILog log = null;
      //var log = new NullLog();
      var log = Null<ILog>.Instance;
      var ba = new BankAccount(log);
      ba.Deposit(100);
      ba.Withdraw(200);
    }
  }
}