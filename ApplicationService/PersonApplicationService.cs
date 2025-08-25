using ApplicationService.Dtos;
using Model.DomainModels;
using Model.ServiceModels;
using Service.Dtos;

namespace ApplicationService
{
    public class PersonApplicationService
    {
        private readonly PersonServiceModel _personServiceModel;

        #region [- Ctor -]
        public PersonApplicationService()
        {
            _personServiceModel = new PersonServiceModel();
        } 
        #endregion

        #region [- Post() -]
        public void Post(PostPersonDto postPersonDto)
        {
            var person = new Person()
            {
                FirstName = postPersonDto.FirstName,
                LastName = postPersonDto.LastName,
            };
            _personServiceModel.Insert(person);
        }
        #endregion

        #region [- GetAll() -]
        public List<GetPersonDto> GetAll()
        {
            var persons = _personServiceModel.SelectAll();
            var getPersonDtos = new List<GetPersonDto>();
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
            return getPersonDtos;
        }
        #endregion

        #region [- Edit() -]
        public void Edit(PatchPersonDto personDto)
        {
            var person = new Person()
            {
                Id = personDto.Id,
                FirstName = personDto.FirstName,
                LastName = personDto.LastName
            };
            _personServiceModel.Update(person);
        }
        #endregion

        #region [- Delete() -]
        public void Delete(int id) 
        {
            _personServiceModel.Delete(id);
        }
        #endregion
    }
}