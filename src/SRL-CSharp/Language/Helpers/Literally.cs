using SRL_CSharp.Extensions;

namespace SRL_CSharp.Language.Helpers
{
    public class Literally
    {
        /** @var string The literal string. */
        protected string _string = string.Empty;

        public Literally(string _string)
        {
            this._string = _string.StripSlashes();
        }

        /// <summary>
        /// Get the string
        /// </summary>
        /// <returns>Literally string</returns>
        public string GetString()
        {
            return this._string;
        }
    }
}
