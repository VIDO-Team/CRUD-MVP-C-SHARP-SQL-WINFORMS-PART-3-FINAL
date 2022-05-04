using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWinFormsMVP.Models
{
    public interface IFQADetailsRepository
    {
        void Add(FQADetailsModel fqaDetailsModel);
        void Edit(FQADetailsModel fqaDetailsModel);
        void Delete(int fqaid);
        IEnumerable<FQADetailsModel> GetAll();
        IEnumerable<FQADetailsModel> GetByValue(string value);//Searchs
    }
}
