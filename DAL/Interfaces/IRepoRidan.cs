﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IRepoRidan<CLASS, ID, RES>
    {
        List<CLASS> Get();
        CLASS Get(ID id);
        RES Add(CLASS obj);
        RES Update(CLASS obj);
        bool Delete(ID id);
    }
}
