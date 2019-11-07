using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace AngWebApp.Models
{
    public class Customers: DataService
    {
        public Customers()
        {

        }

        public int customerNumber { get; set; }
        public string customerName { get; set; }
        public string contactLastName { get; set; }
        public string contactFirstName { get; set; }
        public string phone { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
        public int salesRepEmployeeNumber { get; set; }
        public decimal creditLimit { get; set; }

        public List<Customers> GetCustomers()
        {
            List<Customers> customers = new List<Customers>();
            if (Open())
            {
                try
                {

                    cmd = new MySqlCommand("select * from customers", con);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        Customers customers1 = new Customers
                        {
                            customerNumber = sdr["customerNumber"] == DBNull.Value ? 0 : (int)sdr["customerNumber"],
                            customerName = sdr["customerName"] == DBNull.Value ? "" : (string)sdr["customerName"],
                            contactFirstName = sdr["contactFirstName"] == DBNull.Value ? "" : (string)sdr["contactFirstName"],
                            contactLastName = sdr["contactLastName"] == DBNull.Value? "" : (string)sdr["contactLastName"],
                            phone = sdr["phone"] == DBNull.Value ? "": (string)sdr["phone"],
                            addressLine1 = sdr["addressLine1"] == DBNull.Value ? "" : (string)sdr["addressLine1"],
                            addressLine2 = sdr["addressLine2"] == DBNull.Value ? "" : (string)sdr["addressLine2"],
                            city = sdr["city"] == DBNull.Value ? "" :(string)sdr["city"],
                            state = sdr["state"] == DBNull.Value ? "" : (string)sdr["state"],
                            postalCode = sdr["postalCode"] == DBNull.Value ? "" :(string)sdr["postalCode"],
                            country = sdr["country"] == DBNull.Value ? "" : (string)sdr["country"],
                            salesRepEmployeeNumber = sdr["salesRepEmployeeNumber"] == DBNull.Value ? 0 : (int)sdr["salesRepEmployeeNumber"],
                            creditLimit = sdr["creditLimit"] == DBNull.Value ? 0 :(decimal)sdr["creditLimit"]

                        };

                        customers.Add(customers1);
                    }
                }
                catch (Exception ex)
                {

                }
            }
           // selCustomers();
            return customers;
        }
    }
}
