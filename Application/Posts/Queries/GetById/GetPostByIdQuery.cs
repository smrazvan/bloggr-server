﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloggr.Application.Posts.Queries.GetById
{
    public record class GetPostByIdQuery(int id) : IRequest<PostQueryDto>;
}
