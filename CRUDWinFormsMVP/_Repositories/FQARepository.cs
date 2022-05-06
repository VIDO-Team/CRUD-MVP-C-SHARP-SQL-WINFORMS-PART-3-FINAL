using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CRUDWinFormsMVP.Models;

namespace CRUDWinFormsMVP._Repositories
{
    public  class FQARepository : BaseRepository, IFQARepository
    {
        public FQARepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(FQAModel fqaAppModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"usp_FQA_Add";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@pType", SqlDbType.NVarChar).Value = fqaAppModel.Type;
                command.Parameters.Add("@pAnswers", SqlDbType.NVarChar).Value = fqaAppModel.Answers;
                command.Parameters.Add("@pStt", SqlDbType.Int).Value = fqaAppModel.Stt;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"usp_FQA_Delete";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@pId", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Edit(FQAModel fqaAppModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"usp_FQA_Edit";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@pType", SqlDbType.Int).Value = fqaAppModel.Type;
                command.Parameters.Add("@pAnswers", SqlDbType.NVarChar).Value = fqaAppModel.Answers;
                command.Parameters.Add("@pStt ", SqlDbType.Int).Value = fqaAppModel.Stt;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<FQAModel> GetAll()
        {
            var fqaAppList = new List<FQAModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from FQADetails order by Id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var fqaAppModel = new FQAModel();
                        fqaAppModel.Id = (int)reader[0];
                        fqaAppModel.Type = reader[1].ToString();
                        fqaAppModel.Answers = reader[2].ToString();
                        fqaAppModel.Stt = (byte)reader[3];
                        fqaAppList.Add(fqaAppModel);
                    }
                }
            }
            return fqaAppList;
        }

        public IEnumerable<FQAModel> GetByValue(string value)
        {
            var fqaAppList = new List<FQAModel>();
            int fqaId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string question = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *from FQADetails
                                        where FQAId = @fqaId or Question like @question+'%' 
                                        order by Id desc";
                command.Parameters.Add("@faqId", SqlDbType.Int).Value = fqaId;
                command.Parameters.Add("@question", SqlDbType.NVarChar).Value = question;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var fqaAppModel = new FQAModel();
                        fqaAppModel.Id = (int)reader[0];
                        fqaAppModel.Type = reader[1].ToString();
                        fqaAppModel.Answers = reader[2].ToString();
                        fqaAppModel.Stt = (byte)reader[3];
                        fqaAppList.Add(fqaAppModel);
                    }
                }
            }
            return fqaAppList;
        }
        //...
    }
}
