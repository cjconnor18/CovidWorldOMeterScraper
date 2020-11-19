using CovidWorldOMeterScraper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidWorldOMeterScraper.Data
{
    public class CovidStatData
    {
        private static Dictionary<int, CovidStat> CovidStats = new Dictionary<int, CovidStat>();
        private static Boolean IsDataLoaded = false;

        private static bool LoadData()
        {
            if(!IsDataLoaded)
            {
                IsDataLoaded = true;
                return true;
            }
            return true;
        }

        //create
        public static bool Add(CovidStat covidStat)
        {
            CovidStats.Add(covidStat.StatId, covidStat);
            return true;
        }

        //read
        public static IEnumerable<CovidStat> GetAll()
        {
            LoadData();
            return CovidStats.Values;
        }

        public static CovidStat GetById(int id)
        {
            LoadData();
            return CovidStats[id];
        }

        //delete
        public static bool Remove(int id)
        {
            LoadData();
            if(CovidStats.ContainsKey(id))
            {
                CovidStats.Remove(id);
                return true;
            }
            return false;
        }
        
    }
}
