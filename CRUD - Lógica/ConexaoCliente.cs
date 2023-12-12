using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD___Lógica
{
    internal class ConexaoCliente
    {
        MySqlConnection mySqlConnection;
        void ConexaoBanco()
        {
            try
            {
                mySqlConnection = new MySqlConnection("Persist security info=false; server = localhost;database=db_loja ;user=brunohoske;pwd=123;");
                mySqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao se conectar com o banco de dados.");
            }

        }

        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                ConexaoBanco();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, mySqlConnection);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar consulta" + ex);
                return null;
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
            public int ExcutarComando(string sql)
            {
                int resultado;
                try
                {
                    ConexaoBanco();
                    MySqlCommand command = new MySqlCommand(sql, mySqlConnection);
                    command.ExecuteNonQuery();
                    resultado = 1;

                }
                catch (Exception ex)
                {
                    resultado = 0;
                MessageBox.Show("Erro ao realizar o coamando" + ex);
            }
                finally
                {
                    mySqlConnection.Close();
                }
                return resultado;
            }
        }
    }


