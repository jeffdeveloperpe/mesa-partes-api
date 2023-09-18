﻿using DBEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContext
{
    public interface IProjectRepository
    {
        EntityBaseResponse GetProjects();
        EntityBaseResponse GetProject(int id);
    }
}
