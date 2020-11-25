using NorthwindDAC;
using NorthwindVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinNorthwind.Services
{
     class OrderService
    {
        public List<ProductInfoVO> GetProductAllList()
        {
            OrderDAC dac = new OrderDAC();
            List dac.GetProductAllList();
        }

        }
}
