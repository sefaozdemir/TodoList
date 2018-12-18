using AutoMapper;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoAppV1.Models;

namespace TodoAppV1.Helper
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            //CreateMap<TODO_LIST, TodoListDto>().ForMember(dest=>dest.);
        }
    }
}