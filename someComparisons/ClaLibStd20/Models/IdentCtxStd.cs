using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClaLibStd20.Models
{
    public partial class IdentCtxStd : IdentityDbContext
    {
        public IdentCtxStd(DbContextOptions<IdentCtxStd> options)
            : base(options)
        {
        }
    }
}
