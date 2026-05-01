using AutoMapper;
using FilmRental.API.Models;
using FilmRental.API.DTOs;

namespace FilmRental.API.Mapping
{
    public class StaffProfile : Profile
    {
        public StaffProfile()
        {
            CreateMap<StaffCreateDto, Staff>();
            CreateMap<Staff, StaffReadDto>();
        }
    }
}