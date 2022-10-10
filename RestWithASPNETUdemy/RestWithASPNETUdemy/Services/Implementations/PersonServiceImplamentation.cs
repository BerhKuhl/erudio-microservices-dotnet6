using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImplamentation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        public Person FindByID(long id)
        {
            return new Person
            {
                Id = IncrementAndget(),
                FirstName = "Bernardo",
                LastName = "Kuhl",
                Address = "Várzea Paulista - São Paulo - Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndget(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName" + i,
                Address = "Some address" + i,
                Gender = "Male"
            };
        }

        private long IncrementAndget()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
