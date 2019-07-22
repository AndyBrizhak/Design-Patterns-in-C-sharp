namespace Adapter.Coding.Exercise
{
    public static class ExtensionMethods
    {
        public static int Area(this IRectangle rc)
              {
                return rc.Width * rc.Height;
              }
    }
}