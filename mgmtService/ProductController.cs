using System;
using mgmtService.Functionality;
using mgmtService.Model;
using mgmtService.Service;
using Microsoft.AspNetCore.Mvc;

namespace mgmtService
{
    [ApiController]
    [Route("Api/[controller]")]
    public class ProductController : ControllerBase
    {
        IProductOperation productOperation;
        public ProductController()
        {
           productOperation = new ProductService();
        }


        [HttpPost("Add_Product")]
        public ActionResult ProductAdd(Product product)
        {
            string mssg = string.Empty;
            var temp = productOperation.Addproduct(product);
            if (temp > 0)
            {
                mssg = "One Product Added";
            }
            return Ok(temp);
        }

        [HttpPost("Delete_Product")]
        public ActionResult ProductDelete(int id)
        {
            string msg = string.Empty;
            var del = productOperation.Deleteproduct(id);
            if (del > 0)
            {
               msg = "Product Deleted"; 
            }
            return Ok(del);        
        }


        [HttpPost("Update_Product")]
        public ActionResult ProductUpdate(int id, string name, string desc, int price)
        {
            string mssg = string.Empty;
            var upd = productOperation.Updateproduct(id,name,desc,price);
            if (upd > 0)
            {
                mssg = "Update Successful";
            }
            return Ok(mssg);        
        }

        [HttpGet("Get_Products")]
        public ActionResult Show_Product()
        {          
            var show = productOperation.Showproduct();
            return Ok(show);        
        }
    }
    
}