using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesTrackBusiness.Interfaces;

namespace SalesTrackBusiness
{
    public class DbManagement : IDbManagement
    {
        private  SalesTrackerContext _salesTrackerContext  = new SalesTrackerContext();
        public void InitializeDb()
        {
            // Code to initialize the database
            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            _salesTrackerContext.Database.EnsureCreated();
            _salesTrackerContext.Products.Load();   
        }

        public void UnInitializeDb()
        {
            _salesTrackerContext?.Dispose();
        }
    }
}
