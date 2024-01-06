/*
*	<copyright file="SQL" company="IPCA">
*	</copyright>
* 	<author>Marco Macedo</author>
*	<contact>a26874@alunos.ipca.pt</contact>
*   <date>2024 1/4/2024 4:21:55 PM</date>
*	<description></description>
**/

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoAAD
{
    public class SQL
    {
        #region ATRIBUTOS
        private SqlConnection baseDadosAad;
        #endregion

        
        #region COMPORTAMENTO

        #region CONSTRUTORES

        /// <summary>
        /// Construtor com parametros
        /// </summary>
        /// <param name="source"></param>
        /// <param name="user"></param>
        /// <param name="catalog"></param>
        public SQL(string source, string user, string catalog)
        {
            SqlConnectionStringBuilder novaConexao = new SqlConnectionStringBuilder();
            novaConexao.DataSource = source;
            novaConexao.UserID = user;
            novaConexao.IntegratedSecurity = true;
            novaConexao.InitialCatalog = catalog;
            baseDadosAad = new SqlConnection(novaConexao.ConnectionString);
        }
        #endregion

        #region PROPRIEDADES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROS METODOS
        /// <summary>
        /// Conexão à base de dados
        /// </summary>
        /// <returns></returns>
        public bool Conectar()
        {
            try
            {
                baseDadosAad.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
        /// <summary>
        /// Fechar conexão à base de dados
        /// </summary>
        public void FecharConexao()
        {
            baseDadosAad.Close();
        }


        public bool InsereDados(string nomeTabela)
        {
            SqlCommand inserirDados = new SqlCommand("insert into CodigoPostal (CodPostal, Localidade) values ('4211-123','asdasd');",baseDadosAad);

            inserirDados.ExecuteNonQuery();
            return true;
        }
        /// <summary>
        /// Dado nome de uma tabela mostra todos os dados
        /// </summary>
        /// <param name="dadosMostrar"></param>
        public DataGridView MostrarDados(string dadosMostrar)
        {
            SqlCommand mostraDados = new SqlCommand($"Select * from {dadosMostrar};", baseDadosAad);

            var adaptadorDados = new SqlDataAdapter(mostraDados);
            var auxDataset = new DataSet();

            adaptadorDados.Fill(auxDataset);

            DataGridView aux = new DataGridView();
            aux.DataSource = auxDataset.Tables;
            aux.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            aux.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            return aux;
        }
        #endregion

        #endregion
    }
}