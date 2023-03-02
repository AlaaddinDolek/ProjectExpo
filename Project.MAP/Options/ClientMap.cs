using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
	public class ClientMap:BaseMap<Client>
	{
        public ClientMap()
        {
            // 1'e 1 ilişki
            HasOptional(x => x.Profile).WithRequired(x => x.Client);
        }
    }
}
