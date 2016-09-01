using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRL.Builders
{
    public class Optional : Builder
    {
        /** @var string Desired match group.*/
        protected string group = "(?:{0})?";
    }
}
