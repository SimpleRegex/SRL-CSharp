using SRL.Interfaces;
using System.Collections.Generic;

namespace SRL
{
    public class Builder : TestMethodProvider
    {
        protected const string NON_LITERAL_CHARACTERS = "[\\^$.|?*+()";

        // Binary literals will come with C# 7.0
        protected const int METHOD_TYPE_BEGIN = 1;      //"0b00001";
        protected const int METHOD_TYPE_CHARACTER = 2;  //"0b00010";
        protected const int METHOD_TYPE_GROUP = 4;      //"0b00100";
        protected const int METHOD_TYPE_QUANTIFIER = 8; //"0b01000";
        protected const int METHOD_TYPE_ANCHOR = 16;    //"0b10000";
        protected const int METHOD_TYPE_UNKNOWN = 31;   //"0b11111";
        //protected const string METHOD_TYPES_ALLOWED_FOR_CHARACTERS = self::METHOD_TYPE_BEGIN | self::METHOD_TYPE_ANCHOR | self::METHOD_TYPE_GROUP | self::METHOD_TYPE_QUANTIFIER | self::METHOD_TYPE_CHARACTER;

        /** @var string[] RegEx being built. */
        protected List<string> regEx = new List<string>();
        /** @var string Raw modifiers to apply on get(). */
        protected string modifiers = "";

        /** @var int Type of last method, to avoid invalid builds. */
        protected int lastMethodType = METHOD_TYPE_BEGIN;

        protected Dictionary<string, string> modifierMapper = new Dictionary<string, string>
        {
            { "all", "g" },
            { "multiLine", "m" },
            { "singleLine", "s" },
            { "caseInsensitive", "i" },
            { "unicode", "u" },
            { "allLazy", "U" }
        };
    }
}
