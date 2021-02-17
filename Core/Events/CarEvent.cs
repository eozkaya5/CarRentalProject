using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Events
{
    // Uygulamalarda bir haraket olduğunda bu harakete ek olarak işlem yapmak isterken kullanılır
    public delegate void StockControl();
    public class CarEvent
    {
        private int _stock;

        public CarEvent(int stock)
        {
            _stock = stock;
        }

        public event StockControl StockControlEvent;
        public string CarName { get; set; }
        public int Stock
        {
            get { return _stock; }
            set
            {
                _stock = value;
                if (value <= 15 && StockControlEvent != null)
                {
                    StockControlEvent();
                }
            }
        }

        public void Sell(int amout)
        {
            Stock -= amout;
            Console.WriteLine("Stock amout : {0}", Stock);
        }
    }
}
