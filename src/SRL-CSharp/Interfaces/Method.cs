using SRL.Exceptions;
using SRL.Extensions;
using SRL.Language.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRL.Interfaces
{
    /// <summary>
    /// Abstract Method class. Method strings recognized by the Matcher will result in an object of type Method.
    /// </summary>
    public abstract class Method
    {
        /** @var string Contains the original method name (case-sensitive). */
        protected string Original { get; set; }

        /** @var string Contains the method name to execute. */
        protected string MethodName { get; set; }

        /** @var array Contains the parsed parameters to pass on execution. */
        protected List<object> Parameters { get; set; }

        /** @var int[] Contains all executed callbacks for that method. Helps finding "lost" groups. */
        private List<int> executedCallbacks = new List<int>();

        protected Method(string original, string methodName)
        {
            Original = original;
            MethodName = methodName;
            Parameters = new List<object>();
        }
        
        public void CallMethodOn(Builder builder)
        {
            try
            {

            }
            catch (Exception)
            {
                //Fix Exception handling
                throw new SyntaxException();
            }
        }
        
        public Method SetParameters(List<object> parameters)
        {
            for (int i = 0; i < parameters.Count; i++)
            {
                if (parameters[i].GetType() == typeof(Literally))
                {
                    parameters[i] = parameters[i].As<Literally>().GetString();
                }
                else if (parameters[i].IsList())
                {
                    // Assuming the user wanted to start a sub-query. This means, we'll create a callback for them.
                    //$cb = function(Builder $query) use($parameter, $k) {
                        //$this->executedCallbacks[] = $k;
                        //Interpreter::buildQuery($parameter, $query);
                    //};
                    //$parameter = $cb;
                }
            }
            this.Parameters = parameters;
            return this;
        }
    }
}
