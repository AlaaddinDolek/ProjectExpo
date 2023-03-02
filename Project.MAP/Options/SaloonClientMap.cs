using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
	public class SaloonClientMap:BaseMap<SaloonClient>
	{
        public SaloonClientMap()
        {
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.SaloonID,
                x.ClientID
            });
        }
    }
}
