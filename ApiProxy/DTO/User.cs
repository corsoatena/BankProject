using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ApiProxy.DTo
{
    public class RootElement
    { 
        public List<User>  Users { get; set; }
    } 
    public class User
    {
        public string name { get; set; }  
        public string age { get; set; }
        public List<Prelievo> prelievi { get; set; }

    }
    public class Prelievo
    {
        public string currency { get; set; }
        public int amount { get; set; }
    }
}
