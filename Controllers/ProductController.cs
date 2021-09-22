using ProductBL;
using ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductAPI.Controllers
{
    public class ProductController : ApiController
    {

        ProdBL blObj;

        public List<ProdDTO> GetProduct()
        {
            blObj = new ProdBL();
            var result = blObj.GetProduct();
            return (List<ProdDTO>)result;
        }
    }
}
