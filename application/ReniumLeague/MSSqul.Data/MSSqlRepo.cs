using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RheniumLeague.DtoModels;

namespace MSSqul.Data
{
    public class MSSqlRepo
    {
        public async Task CreateDb()
        {
            var ctx = new RhenumLeague();
            using (ctx)
            {
                var matches = ctx.Matches.ToListAsync();
                var task = ctx.SaveChangesAsync();

                await Task.WhenAll(matches, task);
            }
        }

        public ICollection<DtoStadiumReport> GetStadiumReport()
        {
            var ctx = new RhenumLeague();

            using (ctx)
            {
                var stadiumReport = ctx.Stadiums.Select(s => new DtoStadiumReport
                {
                    Id = s.id,
                    Name = s.Name,
                    Capacity = s.Capacity,
                    }).ToList();

                return stadiumReport;
            }
        }
    }
}
