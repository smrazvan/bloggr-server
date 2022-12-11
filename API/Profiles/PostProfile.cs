﻿using Application.Models;
using AutoMapper;
using Bloggr.Domain.Interfaces;
using Domain.Entities;

namespace Bloggr.WebUI.Profiles
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<AddPostDTO, Post>()
                .ForMember(dest => dest.Interests, opt => opt.Ignore());
            CreateMap<UpdatePostDTO, Post>();
        }
    }
}
