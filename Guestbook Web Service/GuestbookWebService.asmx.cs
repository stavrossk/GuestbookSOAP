using System;
using System.Data;
using System.Data.Common;
using System.Web.Services;

using System.Data.SQLite;




namespace Guestbook_Web_Service
{



    /// <summary>
    /// Summary description for Service1
    /// </summary>
    
    
    [WebService(Namespace = "http://tempuri.org/")]
    

    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    

    [System.ComponentModel.ToolboxItem(false)]
    
    
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]



    public class Service1 : WebService
    {


        private DbConnection CreateDbConnection()
        {


            string root = Server.MapPath(".");

            //SQLiteConnection.CreateFile("Guestbook.sqlite");


            string fileName = root + "\\Guestbook.sqlite";

            var conn = new SQLiteConnection();


            conn.ConnectionString = new DbConnectionStringBuilder()
                                        {
                                            {"Data Source", fileName},
                                            {"Version", "3"},
                                            {"FailIfMissing", "False"},
                                        }.ConnectionString;


            conn.Open();

            return conn;
        }




   




        [WebMethod]
        public void SignGuestBook(string userName, string userMessage)
        {


            DbConnection guestbookWsDbConnection = CreateDbConnection();


            string sql = "INSERT INTO guestbook (name, message) VALUES";

            sql += "(@name, @message)";



            var cmd = new SQLiteCommand(sql);



            cmd.Parameters.AddWithValue("@name", userName);

            cmd.Parameters.AddWithValue("@message", userMessage);




            cmd.Connection = guestbookWsDbConnection as SQLiteConnection;



            var trans = guestbookWsDbConnection.BeginTransaction() as SQLiteTransaction;


            try
            {
                int cmdReturnValue = cmd.ExecuteNonQuery();


                //MessageBox.Show
                //    (cmdReturnValue == 1
                //    ? "Row inserted!"
                //    : "Row NOT inserted.");


            }

            catch (Exception ex)
            {

                if (trans != null)
                    trans.Rollback();
            
            }


            finally
            {

                if (trans != null) 
                    trans.Commit();


                cmd.Dispose();


                guestbookWsDbConnection.Close();


            }





        }




        [WebMethod]
        public DataTable RetrieveGuestBookData()
        {


            DbConnection guestbookWsDbConnection = CreateDbConnection();

            var dataTable = new DataTable();


            const string sql = "SELECT * FROM guestbook";

            var cmd = new SQLiteCommand(sql);



            cmd.Connection = guestbookWsDbConnection as SQLiteConnection;


            var dataAdapter = new SQLiteDataAdapter(cmd);



            var dataSet = new DataSet();



            try
            {

                dataAdapter.Fill(dataSet);

                dataTable = dataSet.Tables[0];

               

            }



            catch (Exception)
            {



            }

            finally
            {

                cmd.Dispose();

                guestbookWsDbConnection.Close();

            }


            return dataTable;

        }






    }




}