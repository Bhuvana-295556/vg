using ProductDAL;
using ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductBL
{
    public class ProdBL
    {
        ProdDAL DALObj = new ProdDAL();
        public List<ProdDTO> GetProduct()
        {
            return DALObj.FetchDetails();
        }

    }
}
