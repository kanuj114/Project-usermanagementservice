using mgmtService.Database;
using mgmtService.Functionality;
using mgmtService.Model;

namespace mgmtService.Service
{
    public class ProductService : IProductOperation
    {
        UserDbContext dbContext;
        public ProductService()
        {
            dbContext = new UserDbContext();
        }
        int IProductOperation.Addproduct(Product product)
        {
            dbContext.products.Add(product);
            return dbContext.SaveChanges();
        }

        int IProductOperation.Deleteproduct(int id)
        {
            var del = dbContext.products.Where(u=>u.ID == id).FirstOrDefault();
            dbContext.products.Remove(del);
            return dbContext.SaveChanges(); 
        }

        List<Product> IProductOperation.Showproduct()
        {
             var temp =  dbContext.products.ToList();
             return temp;
        }

        int IProductOperation.Updateproduct(int id, string name, string des, int price)
        {
             var upd = dbContext.products.Where(u=>u.ID == id).FirstOrDefault();
             upd.ProductName = name;
             upd.Productprice = price;
             upd.ProductDescription = des;
             return dbContext.SaveChanges();

        }

    }
}