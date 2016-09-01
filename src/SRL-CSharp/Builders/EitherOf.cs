using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRL.Builders
{
    public class EitherOf : Builder
    {
        /** @var string Desired match group. */
        protected string group = "(?:{0})";
        
        /** @var string String to implode with. */
        protected string implodeString = "|";
    }
}
