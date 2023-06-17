using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavuzRezervasyon.Data
{
    public class SQLiteDataManager : IDisposable
    {
        #region Global Variable

        private SQLiteConnection conn;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter adp;
        private SQLiteTransaction transaction;
        private DataTable dt;
        private DataSet ds;
        public static string connStr = "Data Source=rezervasyon.db; Version =3; New=True; Compress =True;";

        #endregion Global Variable

        #region Constructor

        public SQLiteDataManager()
        {
            conn = new SQLiteConnection();
            conn.ConnectionString = connStr;
            try
            {
                conn.Open();
            }
            catch
            {

            }

            cmd = new SQLiteCommand();
            cmd.Connection = conn;
            adp = new SQLiteDataAdapter();
            adp.SelectCommand = cmd;
        }

        #endregion Constructor

        #region Property

        public SQLiteCommand DataCommand
        {
            get { return cmd; }
            set { cmd = value; }
        }

        public SQLiteConnection GetConnection
        {
            get { return conn; }
            set { conn = value; }
        }

        public SQLiteDataAdapter SqlDataAdapter
        {
            get { return adp; }
            set { adp = value; }
        }

        #endregion Property

        #region Connection Functions

        public enum ConnType
        {
            webConfigFile,
            connectionStringText
        }

        public string GetConnectionString()
        {
            return conn.ConnectionString;
        }

        /// <summary>
        /// Open SQL Connection
        /// </summary>
        /// <returns>If open connection return true, else return false</returns>
        public bool ConnOpen()
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Close SQL Connection
        /// </summary>
        /// <returns>If close connection return true, else return false</returns>
        public bool ConnClose()
        {
            try
            {
                if (ConnOpen()) conn.Close();
                return true;
            }
            catch { return false; }
        }

        public bool BeginTransaction()
        {
            try { transaction = conn.BeginTransaction(); return true; }
            catch { return false; }
        }

        #endregion Connection Functions

        #region Functions

        #region Get

        public SQLiteDataReader GetDataReader(string sqlCode)
        {
            return GetDataReader(sqlCode, CommandType.Text);
        }

        public SQLiteDataReader GetDataReader(string sqlCode, CommandType commandType)
        {
            ConnOpen();
            SQLiteDataReader dr = null;
            try
            {
                cmd.CommandType = commandType;
                cmd.CommandText = sqlCode;
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception ex)
            {
                dr?.Close();
                dr?.Dispose();
                throw ex;
            }
        }

        public DataTable GetDataTable(string sqlCode)
        {
            return GetDataTable(sqlCode, CommandType.Text);
        }

        public DataTable GetDataTable(string sqlCode, CommandType commandType)
        {
            ConnOpen();
            dt = new DataTable();
            cmd.CommandType = commandType;
            cmd.CommandText = sqlCode;
            adp.Fill(dt);
            ConnClose();
            return dt;
        }

        public static string getdatacell(string sqlselect)
        {
            try
            {
                //return true;
                return getdatacell(sqlselect);
            }
            catch
            {
                return null;
            }
        }

        public string GetDataCell(string sqlCode, SQLiteParameter[] sqlParameters)
        {
            string result = "";
            using (SQLiteCommand command = new SQLiteCommand())
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = conn;
                    command.CommandText = sqlCode;
                    if (sqlParameters != null) command.Parameters.AddRange(sqlParameters);
                    result = command.ExecuteScalar().ToString();
                }
                catch
                {
                    return "0";
                }
                finally
                {
                    command.Dispose();
                }
            }
            return result;
        }

        public DataSet GetDataSet(string sqlCode)
        {
            return GetDataSet(sqlCode, CommandType.Text);
        }

        public DataSet GetDataSet(string sqlCode, CommandType commandType)
        {
            ConnOpen();
            ds = new DataSet();
            cmd.CommandText = sqlCode;
            cmd.CommandType = commandType;
            DataTable dt = new DataTable();
            try
            {
                adp.Fill(dt);
                ds.Tables.Add(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            ConnClose();
            return ds;
        }

        public SQLiteDataAdapter GetDataSqlDataAdapter(string sqlCode)
        {
            return GetDataSqlDataAdapter(sqlCode, CommandType.Text);
        }

        public SQLiteDataAdapter GetDataSqlDataAdapter(string sqlCode, CommandType commandType)
        {
            ConnOpen();
            ds = new DataSet();
            cmd.CommandText = sqlCode;
            cmd.CommandType = commandType;
            DataTable dt = new DataTable();
            try
            {
                adp.Fill(dt);
                ds.Tables.Add(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            ConnClose();
            return adp;
        }

        public DataSet GetDataSet(string sqlCode, CommandType commandType, DataSet dataSet, string tableName)
        {
            ConnOpen();
            ds = new DataSet();
            cmd.CommandText = sqlCode;
            cmd.CommandType = commandType;
            try
            {
                adp.Fill(dataSet, tableName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            ConnClose();
            return dataSet;
        }

        public DataRow GetDataRow(string sqlCode)
        {
            return GetDataRow(sqlCode, CommandType.Text);
        }

        public DataRow GetDataRow(string sqlCode, CommandType commandType)
        {
            ConnOpen();
            DataRow dRow;
            if (GetDataTable(sqlCode, commandType).Rows.Count > 0) dRow = GetDataTable(sqlCode, commandType).Rows[0];
            else dRow = GetDataTable(sqlCode, commandType).NewRow();

            ConnClose();
            return dRow;
        }

        public object GetExecuteScalar(string sqlCode)
        {
            return GetExecuteScalar(sqlCode, CommandType.Text);
        }

        public object GetExecuteScalar(string sqlCode, CommandType commandType)
        {
            ConnOpen();
            object objValue;
            cmd.CommandType = commandType;
            cmd.CommandText = sqlCode;
            try
            {
                if (!sqlCode.Contains("@")) cmd.Parameters.Clear();
                objValue = DataCommand.ExecuteScalar();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                objValue = null;
                throw ex;
            }
            ConnClose();
            return objValue;
        }

        public int GetDataTableID(string sqlCode)
        {
            return GetDataTableID(sqlCode, CommandType.Text);
        }

        public int GetDataTableID(string sqlCode, CommandType commandType)
        {
            int id = 0;
            ConnOpen();
            dt = new DataTable();
            cmd.CommandType = commandType;
            cmd.CommandText = sqlCode;
            try
            {
                adp.Fill(dt);
                ConnClose();
                id = Convert.ToInt32(dt.Rows[0][0]);
            }
            catch
            {
            }
            return id;
        }

        #endregion Get

        public bool CommitTransaction()
        {
            if (transaction == null) return false;
            try { transaction.Commit(); return true; }
            catch { return false; }
        }

        public int RunCommand(string sqlCode)
        {
            return RunCommand(sqlCode, CommandType.Text);
        }

        public int RunCommand(string sqlCode, CommandType commandType)
        {
            ConnOpen();
            transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;
            int identityID = 1;
            try
            {
                cmd.CommandText = sqlCode;
                cmd.CommandType = commandType;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                cmd.Parameters.Clear();
                if (sqlCode.ToLower().StartsWith("insert") || sqlCode.ToLower().StartsWith("ınsert"))
                    identityID = Convert.ToInt32(GetExecuteScalar("select last_insert_rowid();"));
            }
            catch (Exception ex)
            {

                if (transaction != null) transaction.Rollback();
                ConnClose();
                return -1;
            }
            ConnClose();
            return identityID;
        }

        public bool IsThereRow(string sqlCode)
        {
            ConnOpen();
            bool state = GetDataTable(sqlCode).Rows.Count > 0;
            ConnClose();
            return state;
        }

        #endregion Functions

        public void Dispose()
        {
            GC.SuppressFinalize((object)this);
            GC.Collect();
            ConnClose();
            conn?.Dispose();
            cmd?.Dispose();
            adp?.Dispose();
            dt?.Dispose();
            ds?.Dispose();
            transaction?.Dispose();
        }
    }

}
