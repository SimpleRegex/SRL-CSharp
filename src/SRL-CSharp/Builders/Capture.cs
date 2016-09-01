using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRL_CSharp.Builders
{
    public class Capture : Builder
    {
        /** @var string Desired match group. */
        protected string group = "({0})";

        /// <summary>
        /// Set name for capture group.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>The group name set</returns>
        public string SetName(string name)
        {
            return string.Format(group, name);
        }
    }
}
