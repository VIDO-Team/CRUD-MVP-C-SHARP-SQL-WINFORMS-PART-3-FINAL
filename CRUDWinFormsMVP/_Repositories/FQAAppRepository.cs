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
    public class FQAAppRepository : BaseRepository, IFQAAppRepository
    {
        public FQAAppRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(FQAAppModel fqaAppModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"usp_FQA_Add";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@pAnswer", SqlDbType.NVarChar).Value = fqaAppModel.Answers;
                command.Parameters.Add("@pQuestion", SqlDbType.NVarChar).Value = fqaAppModel.Question;
                command.Parameters.Add("@pQuestionType", SqlDbType.Int).Value = fqaAppModel.QuestionType;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void AddFQADetails(int fqaId, FQADetailsModel model)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"usp_FQADetails_Add";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@pFQAId", SqlDbType.Int).Value = fqaId;
                command.Parameters.Add("@pQuestion", SqlDbType.NVarChar).Value = model.Question;
                command.Parameters.Add("@pQuestionType", SqlDbType.Int).Value = model.QuestionType;
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
                command.Parameters.Add("@pQuestionId", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Edit(FQAAppModel fqaAppModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"usp_FQA_Edit";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@pFQAId", SqlDbType.Int).Value = fqaAppModel.ID;
                command.Parameters.Add("@pAnswer ", SqlDbType.NVarChar).Value = fqaAppModel.Answers;
                command.Parameters.Add("@pQuestionID", SqlDbType.Int).Value = fqaAppModel.QuestionId;
                command.Parameters.Add("@pQuestion", SqlDbType.NVarChar).Value = fqaAppModel.Question;
                command.Parameters.Add("@pQuestionType ", SqlDbType.Int).Value = fqaAppModel.QuestionType;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<FQAAppModel> GetAll()
        {
            var fqaAppList = new List<FQAAppModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                    
                command.CommandText = "Select * from FAQApp order by Id desc";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var fqaAppModel = new FQAAppModel();
                        fqaAppModel.Answers = reader[0].ToString();
                        fqaAppModel.Question = reader[1].ToString();
                        fqaAppModel.ID = (int)reader[2];
                        fqaAppModel.QuestionType = (int)reader[3];
                        fqaAppModel.QuestionId = (int)reader[4];
                        fqaAppList.Add(fqaAppModel);
                    }
                }
            }
            return fqaAppList;
        }

        public IEnumerable<FQAAppModel> GetByValue(string value)
        {
            var faqAppList = new List<FQAAppModel>();
            string answers = value;
            string question = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *from FAQApp
                                    where Answers like @answers+'%' or Question like @question+'%' 
                                    order by Id desc";
                command.Parameters.Add("@answers", SqlDbType.NVarChar).Value = answers;
                command.Parameters.Add("@question", SqlDbType.NVarChar).Value = question;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var fqaAppModel = new FQAAppModel();
                        fqaAppModel.Answers = reader[0].ToString();
                        fqaAppModel.Question = reader[1].ToString();
                        fqaAppModel.ID = (int)reader[2];
                        fqaAppModel.QuestionType = (int)reader[3];
                        fqaAppModel.QuestionId = (int)reader[4];
                        faqAppList.Add(fqaAppModel);
                    }
                }
            }
            return faqAppList;
        }

        public IEnumerable<FQADetailsModel> GetQuestion(int fqaId)
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
        //...
    }
    }