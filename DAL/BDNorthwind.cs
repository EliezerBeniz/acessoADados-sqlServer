using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Produto
    {
        SqlConnection cnSql = new SqlConnection(DAL.Properties.Settings.Default.cnStr);
        public static class Campos
        {
            public static string IdProduto
            {
                get
                {
                    return "ProductID";
                }
            }
            public static string NomeProduto
            {
                get
                {
                    return "ProductName";
                }
            }

        }

        private int _idProduto;
        private string _nome;

        public int IdProduto
        {
            get
            {
                return _idProduto;
            }

            set
            {
                _idProduto = value;
            }
        }
        public String Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public Produto()
        { }

        public Produto(int IdProduto) {
            SqlConnection cnSql = new SqlConnection();
            cnSql.ConnectionString = Properties.Settings.Default.cnStr;

            SqlCommand crmProdutos = new SqlCommand();
            crmProdutos.Connection = cnSql;
            crmProdutos.CommandText = "Produto";
            crmProdutos.CommandType = CommandType.StoredProcedure;
            crmProdutos.Parameters.AddWithValue("@IdProduto", IdProduto);

            cnSql.Open();

            SqlDataReader drProduto = crmProdutos.ExecuteReader();

            while (drProduto.Read()) {
                _idProduto = drProduto.GetInt32(0);
                //_nome = drCategorias.GetString(1);
                //_lastName = drCategorias.GetString(2);
                //DataNascimento = drCategorias.GetDateTime(3);
            }

            cnSql.Close();
        }

        public bool Inserir()
        {
            throw new System.NotImplementedException();
        }

        public bool Atualizar()
        {
            throw new System.NotImplementedException();
        }

        public bool Eliminar()
        {
            throw new System.NotImplementedException();
        }


    }

    public static class Produtos
    {
        public static List<Produto> ListaTodos()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Categoria
    {
        public static class Campos
        {
            public static string IdCategoria
            {
                get
                {
                    return "CategoryID";
                }
            }

            public static string NomeCategoria
            {
                get
                {
                    return "CategoryName";
                }
            }
        }

        // private int _id;
        private int _idCategoria;
        private string _nome;

        public int IdCategoria
        {
            get
            {
                return _idCategoria;
            }

            set
            {
                _idCategoria = value;
            }
        }

        public String Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public Categoria()
        { }

        public Categoria(int idCategoria) {
            SqlConnection cnSql = new SqlConnection();
            cnSql.ConnectionString = Properties.Settings.Default.cnStr;

            SqlCommand crmCategorias = new SqlCommand();
            crmCategorias.Connection = cnSql;
            crmCategorias.CommandText = "Categoria";
            crmCategorias.CommandType = CommandType.StoredProcedure;
            crmCategorias.Parameters.AddWithValue("@IdCategoria", idCategoria);

            cnSql.Open();

            SqlDataReader drCategorias = crmCategorias.ExecuteReader();

            while (drCategorias.Read()) {
                _idCategoria = drCategorias.GetInt32(0);
            }

            cnSql.Close();
        }

        public bool Inserir()
        {
            throw new System.NotImplementedException();
        }

        public bool Atualizar()
        {
            throw new System.NotImplementedException();
        }

        public bool Eliminar()
        {
            throw new System.NotImplementedException();
        }

    }

    public static class Categorias
    {
        public static List<Categoria> ListaTodas()
        {
            List<Categoria> categorias = new List<Categoria>();

            SqlConnection cnSql = new SqlConnection();
            cnSql.ConnectionString = Properties.Settings.Default.cnStr;

            SqlCommand cmdListaTodasCategorias = new SqlCommand();
            cmdListaTodasCategorias.Connection = cnSql;
            cmdListaTodasCategorias.CommandText = "ListaTodasCategorias";
            cmdListaTodasCategorias.CommandType = CommandType.StoredProcedure;

            cnSql.Open();

            SqlDataReader drListaTodosEmpregados = cmdListaTodasCategorias.ExecuteReader();

            while (drListaTodosEmpregados.Read()) {
                Categoria novaCategoria = new Categoria();
                novaCategoria.IdCategoria = drListaTodosEmpregados.GetInt32(0);
                novaCategoria.Nome = drListaTodosEmpregados.GetString(1);
                categorias.Add(novaCategoria);
            }

            cnSql.Close();

            return categorias;
        }
        public static List<Produto> ListaProdutos(int idCategoria)
        {
            List<Produto> produtos = new List<Produto>();

            SqlConnection cnSql = new SqlConnection();
            cnSql.ConnectionString = Properties.Settings.Default.cnStr;

            SqlCommand cmdListaTodosProdutos = new SqlCommand();
            cmdListaTodosProdutos.Connection = cnSql;
            cmdListaTodosProdutos.CommandText = "ListarProdutosDaCategoria";
            cmdListaTodosProdutos.CommandType = CommandType.StoredProcedure;
            cmdListaTodosProdutos.Parameters.AddWithValue("@ID_Categoria", idCategoria);

            cnSql.Open();

            SqlDataReader drListaTodosProdutos = cmdListaTodosProdutos.ExecuteReader();

            while (drListaTodosProdutos.Read()) {
                Produto novoProduto = new Produto();
                novoProduto.IdProduto = drListaTodosProdutos.GetInt32(0);
                novoProduto.Nome = drListaTodosProdutos.GetString(1);
                produtos.Add(novoProduto);
            }

            cnSql.Close();

            return produtos;
        }

    }
}
