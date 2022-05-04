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
    public  class FQAAppRepository: BaseRepository, IFQAAppRepository
    {
        public FQAAppRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(FQAAppModel fqaAppModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(FQAAppModel fqaAppModel)
        {
            throw new NotImplementedException();
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
                        faqAppList.Add(fqaAppModel);
                    }
                }
            }
            return faqAppList;
        }
        //...
    }
}
