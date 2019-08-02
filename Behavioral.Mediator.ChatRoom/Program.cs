namespace Behavioral.Mediator.ChatRoom
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var room = new ChatRoom();
            var john = new Person("John");
            var jane = new Person("Jane");
            room.Join(john);
            room.Join(jane);
            john.Say("hi");
             john.Say("oh,hi");
             
             var    simon =new Person("Simon");
             room.Join(simon);
             simon.Say("Hi everyone");
             
             jane.PrivateMessage("Simon", "Ok");
             
             
             
            
        }
    }
}