namespace ORM_Dapper;

public interface IDepartmentRepository
{
    public IEnumerable<Department> GetAllFromDepartments();
    public void InsertDepartment(string newDepartmentName);
}