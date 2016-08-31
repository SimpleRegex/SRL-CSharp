using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRL_CSharp.Builders
{
    public class NonCapture : Builder
    {
        /** @var string Desired non capture group. */
        protected string group = "(?:{0})";
    }
}
