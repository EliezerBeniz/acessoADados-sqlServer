using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Empregado
    {
        public static class Campos
        {
            public static string FirstName
            {
                get
                {
                    return "FirstName";
                }
            }

            public static string LastName
            {
                get
                {
                    return "LastName";
                }
            }

        }

        private int _id;
        private string _name;

        private string _firstName;
        private string _lastName;
        private DateTime _dataNascimento;

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime DataNascimento { get => _dataNascimento; set => _dataNascimento = value; }

        public Empregado()
        { }

        public Empregado(int idEmpregado)
        {
            SqlConnection cnSql = new SqlConnection();
            cnSql.ConnectionString = Properties.Settings.Default.cnStr;

            SqlCommand cmdEmpregado = new SqlCommand();
            cmdEmpregado.Connection = cnSql;
            cmdEmpregado.CommandText = "Empregado";
            cmdEmpregado.CommandType = CommandType.StoredProcedure;
            cmdEmpregado.Parameters.AddWithValue("@IdEmpregado", idEmpregado);
            // cmdListaTodosEmpregados.CommandType = CommandType.StoredProcedure;

            cnSql.Open();

            SqlDataReader drEmpregado = cmdEmpregado.ExecuteReader();

            while (drEmpregado.Read())
            {
                _id = drEmpregado.GetInt32(0);
                _firstName = drEmpregado.GetString(1);
                _lastName = drEmpregado.GetString(2);
                DataNascimento = drEmpregado.GetDateTime(3);
            }

            cnSql.Close();
        }

        public bool Inserir()
        {
            try
            {
                SqlConnection cnSql = new SqlConnection();
                cnSql.ConnectionString = Properties.Settings.Default.cnStr;

                SqlCommand cmdEmpregado = new SqlCommand();
                cmdEmpregado.Connection = cnSql;
                cmdEmpregado.CommandText = "InserirEmpregado";
                cmdEmpregado.CommandType = CommandType.StoredProcedure;
                cmdEmpregado.Parameters.AddWithValue("@Nome", _firstName);
                cmdEmpregado.Parameters.AddWithValue("@Apelido", _lastName);
                cmdEmpregado.Parameters.AddWithValue("@DataNascimento", _dataNascimento);

                cnSql.Open();

                cmdEmpregado.ExecuteNonQuery();

                cnSql.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
    public static class  Empregados
    {
        public static List<Empregado> ListaTodos()
        {
            List<Empregado> empregados = new List<Empregado>();

            SqlConnection cnSql = new SqlConnection();
            cnSql.ConnectionString = Properties.Settings.Default.cnStr;

            SqlCommand cmdListaTodosEmpregados = new SqlCommand();
            cmdListaTodosEmpregados.Connection = cnSql;
            cmdListaTodosEmpregados.CommandText = "ListaTodosEmpregados";
            cmdListaTodosEmpregados.CommandType = CommandType.StoredProcedure;

            cnSql.Open();

            SqlDataReader drListaTodosEmpregados = cmdListaTodosEmpregados.ExecuteReader();

            while (drListaTodosEmpregados.Read())
            {
                Empregado novoEmpregado = new Empregado();
                novoEmpregado.Id = drListaTodosEmpregados.GetInt32(0);
                novoEmpregado.Name = drListaTodosEmpregados.GetString(1);
                empregados.Add(novoEmpregado);
            }

            cnSql.Close();

            return empregados;
        }
    }


}
