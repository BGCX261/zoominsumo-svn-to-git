using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;

namespace Pers_Pastoral
{
    public class Connect
    {
 
    //define string de conexao e cria a conexao
      MySqlConnection mConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=ZM_PASTORAL;uid=root;server=localhost;database=ZM_PASTORAL;uid=root;pwd=volateis");


        public void ConnectToMySql()
        {
            try
            {
              //abre a conexao
                mConn.Open( );

            }
            catch(System.Exception e)
            {
                throw e;
            }
           
        }

        public void SalvarLocal(string nome, string cidade, string bairro, string estado)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                MySqlParameter parameters = new MySqlParameter();

                command.CommandText = string.Format("INSERT INTO ZM_LOCAL (NOME_ZM_LOCAL, CIDADE_ZM_LOCAL, BAIRRO_ZM_LOCAL, ESTADO_ZM_LOCAL) VALUES(@Nome, @Cidade, @Bairro, @Estado)");
                command.Parameters.Add("@Nome", nome);
                command.Parameters.Add("@Cidade", cidade);
                command.Parameters.Add("@Bairro", bairro);
                command.Parameters.Add("@Estado", estado);

                command.Connection = mConn;

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public DataSet SelecionaTodosLocais()
        {
            try
            {
                DataSet mDataSet = new DataSet();
                //cria um adapter usando a instrução SQL para acessar a tabela Clientes
                MySqlDataAdapter mAdapter = new MySqlDataAdapter("SELECT * FROM ZM_LOCAL", mConn);
                
                ////preenche o dataset via adapter
                mAdapter.Fill(mDataSet, "ZM_LOCAL");
                ////atribui a resultado a propriedade DataSource do DataGrid
                //mDataGrid.DataSource = mDataSet;
                //mDataGrid.DataMember = "Clientes";

                return mDataSet;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
