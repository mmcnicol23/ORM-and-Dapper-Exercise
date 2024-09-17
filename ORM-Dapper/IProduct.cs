namespace ORM_Dapper;

public interface IProduct
{
   public IEnumerable<Product> GetAllProducts();
}