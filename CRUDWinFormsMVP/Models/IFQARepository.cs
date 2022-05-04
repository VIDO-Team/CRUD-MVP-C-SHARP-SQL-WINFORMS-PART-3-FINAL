using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWinFormsMVP.Models
{
    public interface IFQARepository
    {
        void Add(FQAModel fqaModel);
        void Edit(FQAModel fqaModel);
        void Delete(int id);
        IEnumerable<FQAModel> GetAll();
        IEnumerable<FQAModel> GetByValue(string value);//Searchs
    }
}
