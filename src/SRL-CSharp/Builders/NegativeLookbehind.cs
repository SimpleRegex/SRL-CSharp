using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRL_CSharp.Builders
{
    public class NegativeLookbehind : Builder
    {
        /** @var string Desired lookbehind group. */
        protected string group = "(?<!{0})";
    }
}
