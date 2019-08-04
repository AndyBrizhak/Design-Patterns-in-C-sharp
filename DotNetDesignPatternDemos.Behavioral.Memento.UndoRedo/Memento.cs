namespace DotNetDesignPatternDemos.Behavioral.Memento.UndoRedo
{
    public class Memento
    {
        public int Balance { get; }

        public Memento(int balance)
        {
            Balance = balance;
        }
    }
}