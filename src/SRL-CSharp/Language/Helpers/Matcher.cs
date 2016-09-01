using SRL_CSharp.Interfaces;

namespace SRL_CSharp.Language.Helpers
{
    public class Matcher
    {
        private static Matcher instance;

        private Matcher() { }

        /// <summary>
        /// Get matcher instance. Since this matcher contains static functionality, we'll use a singleton.
        /// </summary>
        public static Matcher GetInstance => instance ?? (instance = new Matcher());

        public Method Match(string part)
        {
            return null;
        }
    }
}