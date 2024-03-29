﻿using Bloggr.Application.Models;
using Bloggr.Domain.Models;
using Domain.Abstracts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloggr.Application.Posts.Queries.GetPosts
{
    public record class GetPostsQuery(PageModel pageDto,string? username, string? input, string[]? interests, string? orderBy, bool? isBookmarked) : IRequest<PagedResultDto<PostsQueryDto>>;
}
