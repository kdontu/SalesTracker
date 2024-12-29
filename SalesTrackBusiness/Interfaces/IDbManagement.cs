﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTrackBusiness.Interfaces
{
    public interface IDbManagement
    {
        public  void InitializeDb();
        public void UnInitializeDb();
    }
}
