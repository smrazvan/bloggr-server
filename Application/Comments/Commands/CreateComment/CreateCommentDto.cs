﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloggr.Application.Comments.Commands.CreateComment
{
    public class CreateCommentDto
    {
        public string Content { get; set; }

        public int UserId { get; set; }
    }
}
