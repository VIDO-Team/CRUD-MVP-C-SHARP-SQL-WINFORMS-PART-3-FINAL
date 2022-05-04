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
    public abstract class FQARepository: BaseRepository, IFQARepository
    {
        public FQARepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(FQAModel fqaModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(FQAModel fqaModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FQAModel> GetAll()
        {
            var fqaList = new List<FQAModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from FAQApp order by Id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var fqaModel = new FQAModel();
                        fqaModel.Id = (int)reader[0];
                        fqaModel.Type = reader[1].ToString();
                        fqaModel.Answers = reader[2].ToString();
                        fqaModel.Stt = (byte)reader[3];
                        fqaList.Add(fqaModel);
                    }
                }
            }
            return fqaList;
        }

        public IEnumerable<FQAModel> GetByValue(string value)
        {
            throw new NotImplementedException();
        }
        //...
    }
}
