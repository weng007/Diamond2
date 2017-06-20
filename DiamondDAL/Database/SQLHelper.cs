using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

public class SQLHelper : IDisposable
{
    const int commandTimeOut = 600;
    const string appName = "OSP";
    SqlConnection connection = null;
    static SqlTransaction tran = null;
    List<SqlParameter> parameters = new List<SqlParameter>();

    #region Property
    public static string ConnectionString
    {
        get
        {
            //INIHelper ini = new INIHelper();
            //string server = ini.Read("DataBase", "Server");
            //string dbName = ini.Read("DataBase", "DBName");
            //string userName = ini.Read("DataBase", "UserName");
            //string password = ini.Read("DataBase", "Password");

            //ชั่วคราว
            //string server = ".";
            //string dbName = "DiamondShop";
            //string userName = "sa2";
            //string password = "tostos";

            string server = "mssql-2012.chaiyohosting.com";
            string dbName = "Jusmin";
            string userName = "sa4";
            string password = "weng4525017#";

            return string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;Application Name={4};User ID={2};Password={3};"
                , server
                , dbName
                , userName
                , password
                , appName);
        }
    }

    public List<SqlParameter> Parameters
    {
        get
        {
            return parameters;
        }
    }

    private SqlCommand comm;
    public SqlCommand SQLComm
    {
        /*TOS 20130924 > เพื่อให้ DAL ของแต่เมนูสารมารถ Get ค่าจากคอลัมน์ที่กำหนดเป็น Auto Increment ได้*/
        get { return comm; }
        //set { comm = value; }
    }
    #endregion

    #region OpenConnection
    public SqlConnection OpenConnection()
    {
        if (connection == null)
        {
            connection = new SqlConnection(ConnectionString);
            connection.Open();
        }
        else if (connection != null && connection.State != ConnectionState.Open) connection.Open();
        //connection.Open();
        return connection;
    }
    #endregion

    #region CloseConnection
    public void CloseConnection()
    {
        if (connection != null) connection.Close();
    }

    public void CloseConnection(SqlConnection connection)
    {
        if (connection != null) connection.Close();
    }
    #endregion

    public SqlTransaction BeginTransaction()
    {
        if (tran == null)
        {
            tran = OpenConnection().BeginTransaction();
        }
        return tran;
    }

    public void CommitTransaction()
    {
        if (tran != null && tran.Connection != null) tran.Commit();
    }

    public void RollbackTransaction()
    {
        if (tran != null && tran.Connection != null) tran.Rollback();
    }

    #region CreateParameter
    public SqlParameter CreateParameter(string parameterName, object value)
    {
        return CreateParameter(parameterName, value, ParameterDirection.Input);
    }
    public SqlParameter CreateParameter(string parameterName, object value, ParameterDirection direction)
    {
        SqlParameter parameter = new SqlParameter(parameterName, value);
        parameter.Direction = direction;
        //if (parameters == null) parameters = new ArrayList();
        parameters.Add(parameter);
        return parameter;
    }
    #endregion

    #region GetParameter
    public SqlParameter GetParameter(string parameterName)
    {
        SqlParameter result = null;
        foreach (SqlParameter p in parameters)
        {
            if (p.ParameterName.ToLower() == parameterName.ToLower())
            {
                result = p;
                break;
            }
        }
        return result;
    }
    #endregion

    #region ClearParameter
    public void ClearParameter()
    {
        if (parameters != null) parameters.Clear();
    }
    #endregion

    #region FillDataSet
    public DataSet FillDataSet(string sql)
    {
        DataSet ds = new DataSet();
        ds.Tables.Add();
        return FillDataSet(sql, ds.Tables[0]);
    }

    public DataSet FillDataSet(string sql, DataSet ds)
    {
        if (ds.Tables.Count == 0)
        {
            ds.Tables.Add();
        }
        return FillDataSet(sql, ds.Tables[0]);
    }

    public DataSet FillDataSet(string sql, DataSet ds, string tableName)
    {
        DataTable tb = null;
        if (!ds.Tables.Contains(tableName))
        {
            tb = ds.Tables.Add();
        }
        else
        {
            tb = ds.Tables[tableName];
        }
        return FillDataSet(sql, tb);
    }

    public DataSet FillDataSet(string sql, DataTable tb)
    {
        SqlConnection connection = OpenConnection();
        SqlDataAdapter adap = new SqlDataAdapter(sql, connection);
        adap.SelectCommand.CommandTimeout = commandTimeOut;
        adap.Fill(tb);
        connection.Close();
        return tb.DataSet;
    }
    #endregion

    #region FillDataSetBySP
    public DataSet FillDataSetBySP(string sql, params SqlParameter[] parameters)
    {
        DataSet ds = new DataSet();
        ds.Tables.Add();
        return FillDataSetBySP(sql, ds.Tables[0], parameters);
    }

    public DataSet FillDataSetBySP(string sql, DataSet ds, params SqlParameter[] parameters)
    {
        if (ds.Tables.Count == 0)
        {
            ds.Tables.Add();
        }
        return FillDataSetBySP(sql, ds.Tables[0], parameters);
    }

    //สำหรับ Return DataTable หลายๆตัว
    public DataSet FillDataSetBySP2(string sql, DataSet ds, params SqlParameter[] parameters)
    {
        if (ds.Tables.Count == 0)
        {
            ds.Tables.Add();
        }
        return FillDataSetBySP3(sql, ds, parameters);
    }

    public DataSet FillDataSetBySP(string sql, DataSet ds, string tableName, params SqlParameter[] parameters)
    {
        DataTable tb = null;
        if (!ds.Tables.Contains(tableName))
        {
            tb = ds.Tables.Add();
        }
        else
        {
            tb = ds.Tables[tableName];
        }
        return FillDataSetBySP(sql, tb, parameters);
    }

    public DataSet FillDataSetBySP(string spName, DataTable tb, params SqlParameter[] parameters)
    {
        SqlConnection connection = OpenConnection();
        SqlCommand com = new SqlCommand();
        com.CommandText = spName;
        com.CommandTimeout = commandTimeOut;
        com.CommandType = CommandType.StoredProcedure;
        com.Connection = connection;
        com.Transaction = tran;
        if (parameters != null && parameters.Length > 0)
        {
            foreach (SqlParameter parameter in parameters)
            {
                com.Parameters.Add(parameter);
            }
        }
        else if (this.parameters != null && this.parameters.Count > 0)
        {
            foreach (SqlParameter parameter in this.parameters)
            {
                com.Parameters.Add(parameter);
            }
        }
        //DataTable[] tables = new DataTable[tb.DataSet.Tables.Count];
        //for (int index = 0; index < tb.DataSet.Tables.Count; index++)
        //{
        //    tables[index] = tb.DataSet.Tables[index];
        //}
        SqlDataAdapter adap = new SqlDataAdapter(com);
        adap.Fill(0, 0, tb);
        connection.Close();
        com.Parameters.Clear();
        return tb.DataSet;
    }

    // สำหรับ Return DataSet
    public DataSet FillDataSetBySP3(string spName, DataSet ds, params SqlParameter[] parameters)
    {
        SqlConnection connection = OpenConnection();
        SqlCommand com = new SqlCommand();
        com.CommandText = spName;
        com.CommandTimeout = commandTimeOut;
        com.CommandType = CommandType.StoredProcedure;
        com.Connection = connection;
        com.Transaction = tran;
        if (parameters != null && parameters.Length > 0)
        {
            foreach (SqlParameter parameter in parameters)
            {
                com.Parameters.Add(parameter);
            }
        }
        else if (this.parameters != null && this.parameters.Count > 0)
        {
            foreach (SqlParameter parameter in this.parameters)
            {
                com.Parameters.Add(parameter);
            }
        }

        SqlDataAdapter adap = new SqlDataAdapter(com);
        adap.Fill(ds);
        connection.Close();
        com.Parameters.Clear();
        return ds;
    }

    public DataSet FillDataSetBySP(string spName, DataTable[] tb, params SqlParameter[] parameters)
    {
        SqlConnection connection = OpenConnection();
        SqlCommand com = new SqlCommand();
        com.CommandText = spName;
        com.CommandTimeout = commandTimeOut;
        com.CommandType = CommandType.StoredProcedure;
        com.Connection = connection;
        com.Transaction = tran;
        if (parameters != null && parameters.Length > 0)
        {
            foreach (SqlParameter parameter in parameters)
            {
                com.Parameters.Add(parameter);
            }
        }
        else if (this.parameters != null && this.parameters.Count > 0)
        {
            foreach (SqlParameter parameter in this.parameters)
            {
                com.Parameters.Add(parameter);
            }
        }
        SqlDataAdapter adap = new SqlDataAdapter(com);
        adap.Fill(0, 0, tb);
        connection.Close();
        com.Parameters.Clear();
        return tb[0].DataSet;
    }

    #endregion

    #region ExecuteSQL
    public int ExecuteSQL(string sql)
    {
        SqlConnection connection = OpenConnection();
        try
        {
            SqlCommand comm = new SqlCommand(sql, connection, tran);
            comm.CommandTimeout = commandTimeOut;
            int count = comm.ExecuteNonQuery();
            //connection.Close();
            return count;
        }
        catch (Exception er)
        {
            //if (connection != null) connection.Close();
            throw er;
        }
    }
    public object ExecuteScalar(string sql)
    {
        SqlConnection connection = OpenConnection();
        try
        {
            SqlCommand comm = new SqlCommand(sql, connection, tran);
            comm.CommandTimeout = commandTimeOut;
            object count = comm.ExecuteScalar();
            //connection.Close();
            return count;
        }
        catch (Exception er)
        {
            //if (connection != null) connection.Close();
            throw er;
        }
    }
    #endregion

    #region ExecuteSP
    public int ExecuteSP(string spName, params SqlParameter[] parameters)
    {
        SqlConnection connection = OpenConnection();
        try
        {
            SqlCommand comm = new SqlCommand(spName, connection, tran);
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandTimeout = commandTimeOut;
            if (parameters != null && parameters.Length > 0)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    comm.Parameters.Add(parameter);
                }
            }
            else if (this.parameters != null && this.parameters.Count > 0)
            {
                foreach (SqlParameter parameter in this.parameters)
                {
                    comm.Parameters.Add(parameter);
                }
            }

            int count = comm.ExecuteNonQuery();
            //connection.Close();
            return count;
        }
        catch (Exception er)
        {
            //if (connection != null) connection.Close();
            throw er;
        }
    }

    public int ExecuteSP(string spName, DataRow row)
    {
        SqlConnection connection = OpenConnection();
        try
        {
            /*TOS 20130924 > เพื่อให้ DAL ของแต่เมนูสามารถ Get ค่าจากคอลัมน์ที่กำหนดเป็น Auto Increment ได้*/
            ////SqlCommand comm = new SqlCommand(spName, connection, tran);
            comm = new SqlCommand(spName, connection);
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandTimeout = commandTimeOut;
            SqlCommandBuilder.DeriveParameters(comm);
            foreach (SqlParameter parameter in comm.Parameters)
            {
                if (parameter.Direction != ParameterDirection.ReturnValue)
                {
                    parameter.Value = DBNull.Value;
                    string columnName = parameter.ParameterName.Replace("@", "");
                    if (row.Table.Columns.Contains(columnName))
                    {
                        parameter.Value = DBNull.Value;
                        if (row.RowState == DataRowState.Deleted)
                        {
                            if (row[columnName, DataRowVersion.Original] != null) parameter.Value = row[columnName, DataRowVersion.Original];
                        }
                        else
                        {

                            if (!row.IsNull(columnName))
                            {
                                parameter.Value = row[columnName];
                            }
                        }
                    }
                    parameters.Add(parameter);
                }
            }

            int count = comm.ExecuteNonQuery();
            return count;
        }
        catch (Exception er)
        {
            throw er;
        }
    }
    #endregion

    #region ConvertDateTimeToString
    public static string ConvertDateTimeToString(DateTime date)
    {
        string str = "";
        if (date.Year > 2400) date = date.AddYears(-543);
        str = date.Year.ToString() + date.ToString("MMdd");
        return str;
    }
    #endregion

    #region IDisposable Members

    public void Dispose()
    {
        if (parameters != null) parameters.Clear();
        if (tran != null && tran.Connection != null) tran.Rollback();
        if (connection != null) connection.Close();
    }

    #endregion

}
