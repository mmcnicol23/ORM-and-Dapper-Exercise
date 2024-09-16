﻿using System;
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

var departmentRepo = new DepartmentRepository(conn);

departmentRepo.InsertDepartment("CSharp-50");

var departments = departmentRepo.GetAllFromDepartments();

foreach (var dep in departments)
{
    Console.WriteLine($"Name: {dep.Name} | ID: {dep.DepartmentID}");
}