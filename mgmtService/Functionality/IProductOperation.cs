using mgmtService.Model;

namespace mgmtService.Functionality
{
    public interface IProductOperation
    {
         public int Addproduct(Product product);

         public List<Product> Showproduct();

         public int Updateproduct(int id, string name,string des, int price);

         public int Deleteproduct(int id);

    }
}