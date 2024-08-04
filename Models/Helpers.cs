using Microsoft.EntityFrameworkCore.Diagnostics;
using mvc4ESL.Models.Dal;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace PocketBook.Models
{
    //ToDo
    public class Helpers
    {
        public static string GetEmpFullName(string qryField, int? empNo, int FacilNo)
        {
            string _qryField = qryField;
            string _empNo = string.Empty;
            int _FacilNo = FacilNo;
            if (empNo.HasValue && empNo != 0)
            {
                _empNo = Convert.ToString(empNo.Value);

                using (OracleConnection myConnection = new OracleConnection(AppConfiguration.ConnectionString)) // ("Data Source=dev7.world;Persist Security Info=false;User ID=esl;Password=esl;Unicode=True;Min Pool Size=10;Connection Lifetime=120;"))
                {
                    string _sql = "SELECT DISTINCT FIRSTNAME || ' ' || LASTNAME " + _qryField + ", COMPANY FROM ESL.ESL_EMPLOYEES ";
                    _sql += "WHERE EMPLOYEENO = '" + _empNo + "'";
                    //_sql += "AND FACILNO = '" + _FacilNo + "'";

                    OracleCommand myCommand = new OracleCommand(_sql, myConnection);
                    myCommand.CommandType = CommandType.Text;

                    try
                    {
                        myConnection.Open();
                        using (OracleDataReader myReader = myCommand.ExecuteReader())
                        {
                            if (myReader.HasRows)
                            {
                                while (myReader.Read())
                                {
                                    string tempQryField = (string)myReader[_qryField];
                                    if (!myReader.IsDBNull(myReader.GetOrdinal("COMPANY")) && myReader.GetString(myReader.GetOrdinal("COMPANY")) != "MWD")
                                    {
                                        tempQryField += " - " + (string)myReader["COMPANY"];
                                    }
                                    _qryField = tempQryField;
                                }
                                myReader.Close();
                            }
                        }
                    }
                    catch (OracleException ex)
                    {
                        //throw new OracleException(e);
                        Console.WriteLine("Record is not read from the database table.");
                        Console.WriteLine("Exception Message: " + ex.Message);
                        Console.WriteLine("Exception Source: " + ex.Source);
                    }
                    finally
                    {
                        if (myConnection.State == ConnectionState.Open)
                        {
                            myConnection.Close();
                        }
                    }

                }
            }
            else
            {
                _qryField = string.Empty;
            }

            return _qryField;
        }

        public static int KeepSessionAlive()
        {
            using (OracleConnection myConnection = new OracleConnection(AppConfiguration.ConnectionString)) 
            {
                string _sql = "SELECT 1 FROM DUAL";

                OracleCommand myCommand = new OracleCommand(_sql, myConnection);
                myCommand.CommandType = CommandType.Text;

                try
                {
                    myConnection.Open();
                    using (OracleDataReader myReader = myCommand.ExecuteReader())
                    {
                        if (myReader.HasRows)
                        {
                            myReader.Close();
                        }
                    }
                }
                catch (OracleException e)
                {
                    throw e; 
                }
                finally
                {
                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Close();
                    }
                }
            }
            return 1;
        }
    }
}
