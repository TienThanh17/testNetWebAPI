using AutoMapper;
using MyApiNetCore6.Data;
using MyApiNetCore6.Models;

namespace testNetWebAPI.Helper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Book, BookModel>().ReverseMap();
        }
    }
}
