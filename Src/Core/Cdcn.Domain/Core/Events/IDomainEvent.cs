﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cdcn.Domain.Core.Events
{
    public interface IDomainEvent : INotification
    {
    }
}
