using Model.DomainModels;

namespace Model.ServiceModels
{
    public class PersonServiceModel
    {
        #region [- SelectAll() -]
        public List<Person> SelectAll()
        {
            using (var context = new Model.FinalProjectDbContext())
            {
                try
                {
                    var people = context.Person.ToList();
                    return people;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- SelectById() -]
        public Person SelectById(int id)
        {
            using (var context = new Model.FinalProjectDbContext())
            {
                try
                {
                    var person = context.Person.Where(p => p.Id == id).FirstOrDefault();
                    if (person != null)
                    {
                        return person;
                    }
                    else
                    {
                        return new Person();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        } 
        #endregion

        #region [- Insert() -]
        public void Insert(Person person)
        {
            using (var context = new Model.FinalProjectDbContext())
            {
                try
                {
                    context.Add(person);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- Update() -]
        public void Update(Person person)
        {
            using (var context = new FinalProjectDbContext())
            {
                try
                {
                    context.Update(person);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- Delete() -]

        public void Delete(int id)
        {
            using (var context = new FinalProjectDbContext())
            {
                try
                {
                    var personToRemove = SelectById(id);
                    if (personToRemove.Id > 0)
                    {
                        context.Person.Remove(personToRemove);
                        context.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        } 

        #endregion
    }
}