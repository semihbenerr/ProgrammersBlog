using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Data.Concrete.EntityFramework;

namespace ProgrammersBlog.Data.Concrete
{
    public class RoleRepository:EfEntityRepositoryBase<Role>,IRoleRepository
    {
        public RoleRepository(DbContext context) : base(context)
        {
        }
    }
}
