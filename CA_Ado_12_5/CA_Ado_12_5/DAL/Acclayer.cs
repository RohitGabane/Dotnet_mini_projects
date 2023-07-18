using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_Ado_12_5.Modal;

namespace CA_Ado_12_5.DAL
{
    internal class Acclayer
    {
        private string _connectionString;
        public Acclayer(IConfiguration iconfiguration)
        {
            _connectionString = iconfiguration.GetConnectionString("Default");
        }
        public SqlConnection getconnection()
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = _connectionString;
            return sqlconn;
        }

        public int AddData(Account e)
        {
            SqlConnection sqlconn = null;
            SqlCommand sqlcmd;
            int record = 0;
            try
            {
                sqlconn = getconnection();
                sqlcmd = new SqlCommand("Ronny", sqlconn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@pname", SqlDbType.NVarChar).Value = e.Name;
                sqlcmd.Parameters.AddWithValue("@pBalance", SqlDbType.Float).Value = e.Balance;
                sqlconn.Open();
                record = sqlcmd.ExecuteNonQuery();
            }
            catch (SqlException se)
            { Console.WriteLine(se.Message); }
            finally
            {
                sqlconn.Close();
            }
            return record;

        }




        public List<Account> search(int id, string name)
        {
            List<Account> Acc3 = new List<Account>(); ;
            try
            {
                SqlConnection sqlconn;
                using (sqlconn = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand("Select * from Employee where  Id=@id and Name=@name ", sqlconn);
                    sqlconn.Open();
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    SqlDataReader read = cmd.ExecuteReader();

                    Account Acc2 = new Account();
                    if (read.HasRows)
                    {

                        while (read.Read())
                        {
                            Acc2.Id = Convert.ToInt32(read["Id"]);
                            Acc2.Name = read["Name"].ToString();
                            Acc2.Balance = Convert.ToSingle(read["Balance"]);
                            Acc3.Add(Acc2);


                        }

                    }

                    else
                        Console.WriteLine("Data not found");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return Acc3;


        }
        public int deletedata(int id)
        {
            int row = 0;

            try
            {
                SqlConnection sqlconn;
                using (sqlconn = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand("Deletedata", sqlconn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    sqlconn.Open();

                    cmd.Parameters.Add("@pid", SqlDbType.Int).Value = id;
                    row = cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return row;


        }
        public int updatedata(Account e)
        {
            int row = 0;

            try
            {
                SqlConnection sqlconn;
                using (sqlconn = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand("Updatedata", sqlconn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    sqlconn.Open();

                     cmd.Parameters.Add("@pid", SqlDbType.Int).Value = e.Id;
                    cmd.Parameters.Add("@pname", SqlDbType.NVarChar).Value = e.Name;
                    //cmd.Parameters.Add("@Balance", SqlDbType.Float).Value = e.Balance;
                    row = cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            return row;


        }


    }
}
