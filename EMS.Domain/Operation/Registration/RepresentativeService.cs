﻿using EMS.Domain.Entity;
using EMS.Domain.Repository;
using EMS.Framework.Core.Common.Service;

namespace EMS.Domain.Operation.Registration
{
    public class RepresentativeService : BaseEntityService<Representative, IRepresentativeRepository>, IRepresentativeService
    {
    }
}
