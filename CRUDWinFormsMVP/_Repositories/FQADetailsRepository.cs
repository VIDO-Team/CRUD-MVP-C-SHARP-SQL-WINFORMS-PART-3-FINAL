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
    public  class FQADetailsRepository : BaseRepository, IFQADetailsRepository
    {
        public FQADetailsRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(FQADetailsModel fqaAppModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"usp_FQA_Add";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@pQuestion", SqlDbType.NVarChar).Value = fqaAppModel.Question;
                command.Parameters.Add("@pQuestionType", SqlDbType.Int).Value = fqaAppModel.QuestionType;
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
                command.Parameters.Add("@pFQAId", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Edit(FQADetailsModel fqaAppModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"usp_FQA_Edit";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@pQuestion", SqlDbType.NVarChar).Value = fqaAppModel.Question;
                command.Parameters.Add("@pQuestionType ", SqlDbType.Int).Value = fqaAppModel.QuestionType;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<FQADetailsModel> GetAll(int fqaId)
        {
            var fqaAppList = new List<FQADetailsModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from FQADetails WHERE FQAId=@faqId order by Id desc";
                command.Parameters.Add("@faqId", SqlDbType.Int).Value = fqaId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var fqaAppModel = new FQADetailsModel();
                        fqaAppModel.Question = reader[2].ToString();
                        fqaAppModel.QuestionType = (int)reader[3];
                        fqaAppList.Add(fqaAppModel);
                    }
                }
            }
            return fqaAppList;
        }

        public IEnumerable<FQADetailsModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FQADetailsModel> GetByValue(string value)
        {
            var fqaAppList = new List<FQADetailsModel>();
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
                        var fqaAppModel = new FQADetailsModel();
                        fqaAppModel.Question = reader[2].ToString();
                        fqaAppModel.QuestionType = (int)reader[3];
                        fqaAppList.Add(fqaAppModel);
                    }
                }
            }
            return fqaAppList;
        }
        //...
    }
}
