﻿using AutoMapper;
using Bloggr.Application.Posts.Commands.CreatePost;
using Bloggr.Application.Posts.Commands.UpdatePost;
using Bloggr.Application.Posts.Queries.GetById;
using Bloggr.Application.Posts.Queries.GetPosts;
using Domain.Entities;

namespace Bloggr.WebUI.Profiles
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<CreatePostDto, Post>();
            CreateMap<UpdatePostDto, Post>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<Post, PostQueryDto>()
                .ForMember(dest => dest.Interests, opt => opt.MapFrom(x => x.InterestPosts.Select(x => x.Interest)));
            CreateMap<Post, PostsQueryDto>()
                .ForMember(dest => dest.Interests, opt => opt.MapFrom(x => x.InterestPosts.Select(x => x.Interest)));
        }
    }
}
