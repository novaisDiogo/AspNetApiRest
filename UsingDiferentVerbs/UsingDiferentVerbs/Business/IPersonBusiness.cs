using System.Collections.Generic;
using UsingDiferentVerbs.Model;

namespace UsingDiferentVerbs.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
