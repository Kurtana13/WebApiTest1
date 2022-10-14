using System.Collections.Generic;
namespace WebApiTest.Models
{
    public static class PeopleRepository
    {
        private static List<Person> people = new List<Person> {
            new Person(1,"Shota"),
            new Person(2,"Irakli"),
            new Person(3,"Giorgi"),
            new Person(4,"Ana")
            };

        public static IEnumerable<Person> PeopleList
        {
            get { return people; }
        }
        public static Person? GetPersonById(int id)
        {
             return people.Find(person => person.Id == id); 
        }
        public static void AddPersonToList(int id,string name)
        {
            people.Add(new Person(id,name));
        }
        public static void EditItemInList(int id,string name)
        {
            Person? person = people.Find(person => person.Id == id);
            if(person == null)
            {
                throw new Exception("Couldn't find the person");
            }
            person.Name = name;
        }
        public static void RemovePersonFromTheList(int id)
        {
            people.Remove(GetPersonById(id));//It's Okay if parameter is null
        }
    }
}
