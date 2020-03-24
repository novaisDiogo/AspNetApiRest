using System.Collections.Generic;
using UsingDiferentVerbs.Data.VO;
using UsingDiferentVerbs.Model;

namespace UsingDiferentVerbs.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(long id);
    }
}
