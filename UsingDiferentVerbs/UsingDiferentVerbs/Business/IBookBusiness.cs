using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsingDiferentVerbs.Data.VO;
using UsingDiferentVerbs.Model;

namespace UsingDiferentVerbs.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindById(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO person);
        void Delete(long id);
    }
}
