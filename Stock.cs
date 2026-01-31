using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QDentalStockApp26
{
    internal class Stock
    {
        public struct MonthlyStockItem
        {
            public string month;
            public int qtyPpackO;
            public int qtyPpackC;
            public int unitsPpackC;
            public int unitsPpackO;
            public int id;

            public MonthlyStockItem(string month, int qtyPpackO, int qtyPpackC, int unitsPpackC, int unitsPpackO, int id)
            {
                this.month = month;
                this.qtyPpackO = qtyPpackO;
                this.qtyPpackC = qtyPpackC;
                this.unitsPpackC = unitsPpackC;
                this.unitsPpackO = unitsPpackO;
                this.id = id;
            }

        }//monthlyStock
        private List<MonthlyStockItem> stockList = new List<MonthlyStockItem>();

        public void AddStock(MonthlyStockItem item) 
        { 
            stockList.Add(item); 
        }
        public List<MonthlyStockItem> GetStockList()
        {
            return stockList;
        }
        public void ClearStock()
        {
            stockList.Clear();
        }

    }
}
