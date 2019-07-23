namespace Bridge_Coding_Exercise
{
    public abstract class Shape
    {
       public string Name
       {
           get;
           set;
       }
       
       protected IRenderer renderer;

       protected Shape(IRenderer renderer)
       {
           this.renderer = renderer;
       }

       

       public abstract void Draw();
    }
}