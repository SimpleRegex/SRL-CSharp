using System.Collections.Generic;

namespace SRL_CSharp.Language.Helpers
{
    public class Cache
    {
        /** @var Builder[] */
        protected static Dictionary<string, Builder> cache = new Dictionary<string, Builder>();

        /// <summary>
        /// Add Builder for SRL to cache.
        /// </summary>
        /// <param name="srl">String SRL</param>
        /// <param name="builder">Builder object</param>
        public static void Add(string srl, Builder builder)
        {
            cache.Add(srl, builder);
        }

        /// <summary>
        /// Validate if current SRL is already in cache.
        /// </summary>
        /// <param name="srl">SRL key</param>
        /// <returns>True if the current SRL is in cache; otherwise, false</returns>
        public static bool Has(string srl)
        {
            return cache.ContainsKey(srl);
        }

        /// <summary>
        /// Get SRL from cache, or return new Builder.
        /// </summary>
        /// <param name="srl">SRL key</param>
        /// <returns>Builder object</returns>
        public static Builder Get(string srl)
        {
            Builder builder;
            return cache.TryGetValue(srl, out builder) ? builder : new Builder();
        }
    }
}