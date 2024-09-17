using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using ORM_Dapper;

//^^^^MUST HAVE USING DIRECTIVES^^^^

var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();
string connString = config.GetConnectionString("DefaultConnection");
IDbConnection conn = new MySqlConnection(connString);

//Department Section:
// var departmentRepo = new DepartmentRepository(conn);
//
// departmentRepo.InsertDepartment("CSharp-50");
//
// var departments = departmentRepo.GetAllFromDepartments();
//
// foreach (var dep in departments)
// {
//     Console.WriteLine($"Name: {dep.Name} | ID: {dep.DepartmentID}");
// }

//Product Section:
var productRepository = new DapperProductRepository(conn);

productRepository.GetAllProducts();
var products = productRepository.GetAllProducts();
foreach (var product in products)
{
    Console.WriteLine(product.ProductID);
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.CategoryID);
    Console.WriteLine(product.OnSale);
    Console.WriteLine(product.StockLevel);
    Console.WriteLine();
    Console.WriteLine();
    
}