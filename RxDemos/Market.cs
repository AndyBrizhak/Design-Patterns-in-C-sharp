using System.ComponentModel;

namespace RxDemos
{
    public class Market
    {
//    public List<float> Prices = new List<float>();
//
        public void AddPrice(float price)
        {
            Prices.Add(price);
            //PriceAdded?.Invoke(this, new PriceAddedEventArgs{ Price = price});
        }
//
//    public event EventHandler<PriceAddedEventArgs> PriceAdded;
        public BindingList<float> Prices = new BindingList<float>();
    }
}