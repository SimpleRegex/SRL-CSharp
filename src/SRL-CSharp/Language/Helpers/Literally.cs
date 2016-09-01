using SRL.Extensions;

namespace SRL.Language.Helpers
{
    public class Literally
    {
        /** @var string The literal string. */
        protected string _string;

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
