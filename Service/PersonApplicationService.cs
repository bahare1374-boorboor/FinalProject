using Model.DomainModels;
using Model.ServiceModels;
using Service.Dtos;

namespace Service
{
   public class PersonApplicationService
    {
        private readonly PersonServiceModel _personServiceModel;

        public PersonApplicationService()
        {
            _personServiceModel = new PersonServiceModel();
        }
        //public void Post(PostPersonDto postPersonDto)
        //{
        //    var person=new Person() { 
        //        FirstName = postPersonDto.FirstName,
        //        LastName = postPersonDto.LastName,
        //    };
        //    _personServiceModel.Post(person);
        //}
        public List<Person> GetAll()
        {
            var persons = _personServiceModel.SelectAll();
            var getPersonDtos=new List<GetPersonDto>();
            foreach (var item in persons)
            {
                var gpd = new GetPersonDto()
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                };
                getPersonDtos.Add(gpd);
            }
            return persons;
        }
    }
}
