namespace Bridge_Coding_Exercise
{
    public class Triangle : Shape
    {
        public string Name;
        
        public override void Draw()
        {
            throw new System.NotImplementedException();
        }

        public Triangle(IRenderer renderer, string name) : base(renderer)
        {
            Name = name;
        }
    }
}