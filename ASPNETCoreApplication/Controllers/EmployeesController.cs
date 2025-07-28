﻿using ASPNETCoreApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System.Text.Json.Serialization;

namespace ASPNETCoreApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public readonly IConfiguration _configuration;
        public EmployeesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        [Route("GetAllEmployees")]
        public string GetEmployees()
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("EmployeeAppCon").ToString());
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from Employees", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Employee> employeeList = new List<Employee>();
            Response response = new Response();
            if(dt.Rows.Count > 0)
            {
                for(int i = 0; i< dt.Rows.Count; i++)
                {
                    Employee employee = new Employee();
                    employee.Id = Convert.ToInt32(dt.Rows[i]["EmpId"]);
                    employee.Empname = Convert.ToString(dt.Rows[i]["EmpName"]);
                    employee.Password = Convert.ToString(dt.Rows[i]["Password"]);
                    employeeList.Add(employee);
                }
            }
            if(employeeList.Count > 0)
            {
                return JsonConvert.SerializeObject(employeeList);
            }
            else
            {
                response.StatusCode = 100;
                response.ErrorMessage = "No Data Found";
                return JsonConvert.SerializeObject(response);

            }
           
        }
    }
}
