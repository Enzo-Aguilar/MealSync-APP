using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System;

namespace DataAccessLayer
{
    public class DAL
    {
        private readonly SqlConnection _SqlConn;
        private SqlCommand _SqlCommand;
        private SqlDataReader _SqlReader;

        public DAL()//Conexão com a Base de Dados
        {
            _SqlConn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + System.Windows.Forms.Application.StartupPath + @"\MealSync_DB.mdf;Integrated Security = True; Connect Timeout = 30");
        }

        //Caminho do DB na escola -> C:\Users\Vosso numero\_MealSync_\Database\MealSync_DB.mdf;
        //Caminho da DB no pc pessoal -> C:\_MealSync_\Database\MealSync_DB.mdf;

        // Abrir Conexão
        private void OpenConnection()
        {
            try
            {
                _SqlConn.Open();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        //Fechar Conexão
        private void CloseConnection()
        {
            try
            {
                _SqlConn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }


        //Associar os Comandos
        private void BindCommand(String sqlCmd)
        {
            _SqlCommand = new SqlCommand(sqlCmd, _SqlConn);
        }


        //Verificação antes de executar
        public DataTable ExecuteStoredProcReader(String sqlCmd, SqlParameter[] sqlParams)
        {
            DataTable returnTable = new DataTable("returnTable");

            BindCommand(sqlCmd);

            _SqlCommand.CommandType = CommandType.StoredProcedure;

            if(sqlParams != null)
            {
                _SqlCommand.Parameters.AddRange(sqlParams);
            }

            OpenConnection();

            if(_SqlConn.State == ConnectionState.Open)
            {
                _SqlReader = _SqlCommand.ExecuteReader();
                returnTable.Load(_SqlReader);
                _SqlReader.Close();
            }

            CloseConnection();

            return returnTable;
        }

        //"Stored Procedure" sem parâmetros
        public DataTable ExecuteStoredProcReader(String sqlCmd)
        {
            return this.ExecuteStoredProcReader(sqlCmd, null);
        }

        public int ExecuteStoredProcNonQuery(String sqlCmd, SqlParameter[] sqlParams)
        {
            int feedback = -1;

            BindCommand(sqlCmd);

            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.Parameters.AddRange(sqlParams);

            OpenConnection();

            if(_SqlConn.State == ConnectionState.Open)
            {
                feedback = _SqlCommand.ExecuteNonQuery();
            }

            CloseConnection();
            return feedback;
        }

        public object ExecuteStoredProcScalar(String sqlCmd, SqlParameter[] sqlParams)
        {
            object result = null;
            BindCommand(sqlCmd);
            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.Parameters.AddRange(sqlParams);

            OpenConnection() ;

            if(_SqlConn.State == ConnectionState.Open)
            {
                result = _SqlCommand.ExecuteScalar();
            }
            
            CloseConnection() ;
            _SqlCommand.Parameters.Clear();
            return result;
        }

        public DataTable ExecuteReader(String sqlCmd, SqlParameter[] sqlParams)
        {
            DataTable returnTable = new DataTable("returnTable");

            BindCommand(sqlCmd);

            _SqlCommand.CommandType= CommandType.Text;

            if(sqlParams != null)
            {
                _SqlCommand.Parameters.AddRange(sqlParams);
            }
            OpenConnection();

            if(_SqlConn.State == ConnectionState.Open)
            {
                _SqlReader = _SqlCommand.ExecuteReader();
                returnTable.Load(_SqlReader);
                _SqlReader.Close();
            }

            CloseConnection();
            _SqlCommand.Parameters.Clear();
            return returnTable;
        }

        public int ExecuteNonQuery(String sqlCmd, SqlParameter[] sqlParams)
        {
            int feedback = -1 ;
            
            BindCommand(sqlCmd);

            _SqlCommand.CommandType = CommandType.Text;
            _SqlCommand.Parameters.AddRange(sqlParams);

            OpenConnection();

            if(_SqlConn.State == ConnectionState.Open)
            {
                _SqlCommand.ExecuteNonQuery();
            }

            CloseConnection();
            _SqlCommand.Parameters.Clear();
            return feedback;
        }

        public object ExecuteScalar(String sqlCmd, SqlParameter[] sqlParams)
        {
            object result = null;
            BindCommand(sqlCmd);
            _SqlCommand.CommandType = CommandType.Text;
            _SqlCommand.Parameters.AddRange(sqlParams);

            OpenConnection();

            if(_SqlConn.State == ConnectionState.Open)
            {
                result = _SqlCommand.ExecuteScalar();
            }

            CloseConnection();
            _SqlCommand.Parameters.Clear();
            return result;
        }
    }
}