﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracer.Repository
{
    public interface IClientRepository : IRepository<Clients>
    {
        bool CheckExistance(string id, string password);
    }
}
