using System;


namespace BestOil
{
    [Serializable]
    public class Gasoline
    {
        public string type { get; set; }
        public double price { get; set; }
        public Gasoline()
        {
            type = null;
            price = default(double);
        }
    }
}
