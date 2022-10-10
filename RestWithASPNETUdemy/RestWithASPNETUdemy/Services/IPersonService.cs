using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        List<Person> FindAll();
        Person FindByID(long id);
        Person Update(Person person);
        void Delete(long id);

    }
}
