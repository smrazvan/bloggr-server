﻿using Bloggr.Application.Interests.Queries.GetInterests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloggr.Application.Posts.Commands.UpdatePost
{
    public class UpdatePostDto
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Caption { get; set; }

        public IEnumerable<InterestQueryDto>? Interests { get; set; }
    }
}
