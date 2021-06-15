using AutoMapper;
using BookStore_API.Data;
using BookStore_API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.Mappings
{
    public class Maps : Profile
    {
        //Create the mapping
        //two classes should be mapped
        //DTO and Data class

        public Maps()
        {
            CreateMap<Author, AuthorDTO>().ReverseMap();
            CreateMap<Book, BookDTO>().ReverseMap();
        }
    }
}
