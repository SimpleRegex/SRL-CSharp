using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRL.Builders
{
    public class NegativeLookahead : Builder
    {
        /** @var string Desired lookahead group. */
        protected string group = "(?!{0})";
    }
}
