using AutoMapper;
using Filmos_Rating_CleanArchitecture.Application.Common.Mappings;
using Filmos_Rating_CleanArchitecture.Domain.Entities;

namespace Filmos_Rating_CleanArchitecture.Application.Films.Queries.GetFilmsList
{
    public class FilmsLookupDto : IMapFrom<Film>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public FilmsLookupDto(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Film, FilmsLookupDto>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id_film))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.Name_film));
        }
    }
}
