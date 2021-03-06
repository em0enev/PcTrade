﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PcTrade.Data
{
    public class PcDbContext : IdentityDbContext
    {
        public PcDbContext(DbContextOptions<PcDbContext> options)
            : base(options)
        {
        }
    }
}
