using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWinFormsMVP.Models
{
    public interface IFQAAppRepository
    {
        void AddFQADetails(int fqaId, FQADetailsModel model);
        void Add(FQAAppModel fqaAppModel);
        void Edit(FQAAppModel fqaAppModel);
        void Delete(int id);
        IEnumerable<FQAAppModel> GetAll();

        IEnumerable<FQADetailsModel> GetQuestion(int fqaID);
        IEnumerable<FQAAppModel> GetByValue(string value);//Searchs
    }
}
