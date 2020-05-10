using AutoMapper;


namespace Frontend.Profiles
{
    public class LogObjectProfile : Profile
    {
        public LogObjectProfile()
        {
            CreateMap<Entities.LogObject, Models.LogModel>();
        }
    }
}
