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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(FQADetailsModel fqaAppModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FQADetailsModel> GetAll()
        {
            var fqaAppList = new List<FQADetailsModel>();
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
                        var fqaAppModel = new FQADetailsModel();
                        fqaAppModel.Id = (int)reader[0];
                        fqaAppModel.FQAId = (int)reader[1];
                        fqaAppModel.Question = reader[2].ToString();
                        fqaAppModel.QuestionType = (int)reader[3];
                        fqaAppList.Add(fqaAppModel);
                    }
                }
            }
            return fqaAppList;
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
                        fqaAppModel.Id = (int)reader[0];
                        fqaAppModel.FQAId = (int)reader[1];
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
