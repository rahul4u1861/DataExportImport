﻿using DataExportImport.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataExportImport.Service
{
    public class DbContext
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand("exe");
        public void save(Customer customer)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=HackathonDatabase;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("sp_save_customer", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = customer.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = customer.LastName;
                    cmd.Parameters.Add("@Mobile", SqlDbType.VarChar).Value = customer.Mobile;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = customer.Email;
                    cmd.Parameters.Add("@SSN", SqlDbType.VarChar).Value = customer.SSN;

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}