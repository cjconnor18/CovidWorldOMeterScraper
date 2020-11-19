using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidWorldOMeterScraper.Models
{
    public class CovidStat
    {
        public int StatId { get; set; }
        public DateTime Date { get; set; }
        public long Cases { get; set; }
        public static int NextId { get; set; } = 1; 

        public CovidStat ()
        {
            StatId = NextId;
            NextId++;
        }
        public CovidStat(int cases) : this()
        {
            Date = DateTime.Today.AddDays(-1);
            Cases = cases;
        }

        public CovidStat(DateTime date, int cases): this()
        {
            Date = date;
            Cases = cases;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is CovidStat stat &&
                   StatId == stat.StatId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StatId);
        }
    }
}
