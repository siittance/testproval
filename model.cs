using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testiki
{
    public class model
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public pravda PravdaOtvet { get; set; }
    }
    public enum pravda
    {
        Answer1,
        Answer2,
        Answer3,
    }
}
