﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloggr.Application.Interests.Commands.RemoveInterest
{
    public record class RemoveInterestByIdCommand(int id) : IRequest<Interest>;
}
