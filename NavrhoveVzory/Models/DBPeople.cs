using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavrhoveVzory.Models
{
    public class DBPeople
    {
        static DBPeople instance = null;
        public Dictionary<string, People> dbPeople;
        public DBPeople()
        {
            dbPeople = new Dictionary<string, People>();
        }

        public static DBPeople PeopleDatabase
        {
            // Lazy model - až někdo bude potřebovat databázi zpráv,
            // tak se vytvoří, ale ne dřív!
            get
            {
                if (instance == null)
                {
                    instance = new DBPeople();
                }

                return instance;
            }
        }
    }
}
