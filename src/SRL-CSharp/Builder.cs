using SRL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRL
{
    public class Builder : TestMethodProvider
    {
        protected const string NON_LITERAL_CHARACTERS = "[\\^$.|?*+()";
        protected const string METHOD_TYPE_BEGIN = "0b00001";
        protected const string METHOD_TYPE_CHARACTER = "0b00010";
        protected const string METHOD_TYPE_GROUP = "0b00100";
        protected const string METHOD_TYPE_QUANTIFIER = "0b01000";
        protected const string METHOD_TYPE_ANCHOR = "0b10000";
        protected const string METHOD_TYPE_UNKNOWN = "0b11111";
        //protected const string METHOD_TYPES_ALLOWED_FOR_CHARACTERS = self::METHOD_TYPE_BEGIN | self::METHOD_TYPE_ANCHOR | self::METHOD_TYPE_GROUP | self::METHOD_TYPE_QUANTIFIER | self::METHOD_TYPE_CHARACTER;

        /** @var string[] RegEx being built. */
        protected List<string> regEx = new List<string>();
        /** @var string Raw modifiers to apply on get(). */
        protected string modifiers = string.Empty;

        /** @var int Type of last method, to avoid invalid builds. */
        protected string lastMethodType = METHOD_TYPE_BEGIN;

        protected Dictionary<string, string> modifierMapper = new Dictionary<string, string>();

        public Builder()
        {
            modifierMapper.Add("all", "g");
            modifierMapper.Add("multiLine", "m");
            modifierMapper.Add("singleLine", "s");
            modifierMapper.Add("caseInsensitive", "i");
            modifierMapper.Add("unicode", "u");
            modifierMapper.Add("allLazy", "U");
        }
    }
}
