﻿using DAL.EF;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IUser<Advisor, int, Advisor> AdvisorDataAccess()
        {
            return new AdvisorRepo();
        }
    }
}