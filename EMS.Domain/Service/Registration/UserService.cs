﻿using EMS.Domain.Entity;
using EMS.Domain.Repository;
using EMS.Framework.Core.Common.Service;

namespace EMS.Domain.Service.Registration
{
    public class UserService : BaseEntityService<User, IUserRepository>, IUserService
    {
    }
}