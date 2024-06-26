﻿using BitTagModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BitTagDAL
{
    public class OrganiztionEmployees
    {
        //get function to be added
        public static async Task<List<Orgnization_EmployeeModel>> GetOrgEmployees()
        {
            SqlConnection con = DBhelper.GetConnection();
            await con.OpenAsync();
            SqlCommand cmd = new SqlCommand("Sp_GetOrgEmployees", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = await cmd.ExecuteReaderAsync();
            List<Orgnization_EmployeeModel> employeeList = new List<Orgnization_EmployeeModel>();
            while (reader.Read())
            {
                Orgnization_EmployeeModel employeeModel = new Orgnization_EmployeeModel();
                employeeModel.orgID_FK = Guid.Parse(reader["orgID_FK"].ToString());
                employeeModel.Emp_ID = Guid.Parse(reader["Emp_ID"].ToString());
                employeeModel.Emp_firstName = reader["Emp_firstName"].ToString();
                employeeModel.Emp_lastName = reader["Emp_lastName"].ToString();
                employeeModel.Emp_CNIC = reader["Emp_CNIC"].ToString();
                employeeModel.Pin = int.Parse(reader["Pin"].ToString());
                employeeModel.Designation = reader["Designation"].ToString();
                employeeModel.PhoneNum = reader["PhoneNum"].ToString();
                employeeList.Add(employeeModel);
            }
            await con.CloseAsync();
            return employeeList;
        }
        public static async Task<List<Orgnization_EmployeeModel>> GetOrgEmployeesByID(Guid id)
        {
            try
            {
                SqlConnection con = DBhelper.GetConnection();
                await con.OpenAsync();
                SqlCommand cmd = new SqlCommand("Sp_GetEmpByID", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orgID_FK", id);
                SqlDataReader reader = await cmd.ExecuteReaderAsync();
                List<Orgnization_EmployeeModel> employeeList = new List<Orgnization_EmployeeModel>();
                while (reader.Read())
                {
                    Orgnization_EmployeeModel employeeModel = new Orgnization_EmployeeModel();
                    employeeModel.orgID_FK = Guid.Parse(reader["orgID_FK"].ToString());
                    employeeModel.Emp_ID = Guid.Parse(reader["Emp_ID"].ToString());
                    employeeModel.Emp_firstName = reader["Emp_firstName"].ToString();
                    employeeModel.Emp_lastName = reader["Emp_lastName"].ToString();
                    employeeModel.Emp_CNIC = reader["Emp_CNIC"].ToString();
                    employeeModel.Pin = int.Parse(reader["Pin"].ToString());
                    employeeModel.Designation = reader["Designation"].ToString();
                    employeeModel.PhoneNum = reader["PhoneNum"].ToString();
                    employeeList.Add(employeeModel);
                }
                await con.CloseAsync();
                return employeeList;

            }
            catch (JsonException ex)
            {
                //await Console.Out.WriteLineAsync(ex.Message);
                List < Orgnization_EmployeeModel> oe =new List<Orgnization_EmployeeModel>();
                oe[0].Emp_firstName = ex.Message;
                return oe;// Console.WriteLine("JSON Deserialization Error: " + ex.Message);


            }
           
        }
    }
}
