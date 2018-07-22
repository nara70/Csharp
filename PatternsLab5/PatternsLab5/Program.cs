using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace PatternsLab5
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "User Id=CourseProject;Password=Mrtmrtmrt97;Data Source=127.0.0.1:1521";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                string cmd1 = "SELECT * FROM CABIN";
                string cmd2 = "SELECT * FROM TICKET";
                string cmd3 = "SELECT * FROM PASSANGER";
                string cmd4 = "SELECT * FROM VEHICLE";
                string cmd5 = "SELECT * FROM PASSANGER_VEHICLE";
                OracleDataAdapter cabinAdapter = new OracleDataAdapter(cmd1, connection);
                OracleDataAdapter ticketAdapter = new OracleDataAdapter(cmd2, connection);
                OracleDataAdapter passangerAdapter = new OracleDataAdapter(cmd3, connection);
                OracleDataAdapter vehicleAdapter = new OracleDataAdapter(cmd4, connection);
                OracleDataAdapter linkAdapter = new OracleDataAdapter(cmd5, connection);
                DataSet ferry = new DataSet();
                cabinAdapter.Fill(ferry, "CABIN");
                ticketAdapter.Fill(ferry, "TICKET");
                passangerAdapter.Fill(ferry, "PASSANGER");
                vehicleAdapter.Fill(ferry, "VEHICLE");
                linkAdapter.Fill(ferry, "PASSANGER_VEHICLE");

                DataRelation relation1 = new DataRelation("CabTick",
                                                           ferry.Tables["CABIN"].Columns["ID"],
                                                           ferry.Tables["TICKET"].Columns["ID_CABIN"]);
                DataRelation relation2 = new DataRelation("PassTick",
                                                       ferry.Tables["PASSANGER"].Columns["ID"],
                                                       ferry.Tables["TICKET"].Columns["ID_PASSANGER"]);
                DataRelation relation3 = new DataRelation("PassLink",
                                                       ferry.Tables["PASSANGER"].Columns["ID"],
                                                       ferry.Tables["PASSANGER_VEHICLE"].Columns["ID_PASSANGER"]);
                DataRelation relation4 = new DataRelation("VehicleLink",
                                                       ferry.Tables["VEHICLE"].Columns["ID"],
                                                       ferry.Tables["PASSANGER_VEHICLE"].Columns["ID_VEHICLE"]);
                foreach(DataTable tab in ferry.Tables)
                {
                    Console.WriteLine(tab.TableName);
                    Console.WriteLine();
                    foreach(DataRow row in tab.Rows)
                    {
                        foreach (DataColumn col in tab.Columns)
                            Console.WriteLine(col.ColumnName + "\t\t" + row[col]);
                        Console.WriteLine();
                    }
                }
                //INSERT
                OracleCommand insert = new OracleCommand("INSERT INTO PASSANGER VALUES('21', 'UA', 'HM995967', '31')", connection);
                //insert.ExecuteNonQuery();
                //UPDATE
                OracleCommand update = new OracleCommand("UPDATE PASSANGER SET PASSPORTDATA = 'HM000000' WHERE ID = '21'", connection);
                //update.ExecuteNonQuery();
                //DELETE
                OracleCommand delete = new OracleCommand("DELETE FROM PASSANGER WHERE ID = '21'", connection);
                delete.ExecuteNonQuery();
            }
        }
    }
}
