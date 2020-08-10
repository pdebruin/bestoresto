using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data
{
    public class RestoEntity
    {
        public Int32 id{get;set;}
        public string name{get;set;}
        public string PartitionKey{get;set;}
    }

    public class RestoDA{

        public async Task Add(RestoEntity resto)
        {
            using (var context = new RestoContext())
            {
                //await context.Database.EnsureDeletedAsync();
                await context.Database.EnsureCreatedAsync();

                context.Add(new RestoEntity
                {
                    id = 1,
                    name = "De Librije",
                    PartitionKey = "1"
                });

                await context.SaveChangesAsync();
            }
        }
    }
}
