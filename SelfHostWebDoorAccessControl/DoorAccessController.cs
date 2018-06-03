using System;
using System.Collections.Generic;
using System.Web.Http;

namespace SelfHostWebDoorAccessControl
{
    public class DoorAccessController : ApiController
    {
        List<string> CardIDs = new List<string> {"669D38E0","669D38E0","04C4554E","840DFA4D","A6BD37E0","54F04F4E","4495544E"}; //"107CCC73","0482554E","D3B4511C",

        // GET api/values 
        public IEnumerable<string> Get()
        {
            return CardIDs;
        }

        // GET api/values/5 
        public string Get(string id)
        {
            var ret = string.Empty;
            Console.WriteLine($"\r\nReceive --> {id}");
            if (CardIDs.Contains(id))
            {
                Console.WriteLine("ID Found, Access Granted.");
                ret = "Pass";
            }
            else
            {
                Console.WriteLine("ID Not Found, Access Denied.");
                ret = "Fail";
            }
            return ret;
        }

    }
}
