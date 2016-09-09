using SRL.Interfaces;
using System;
using System.Collections.Generic;

namespace SRL
{
    public class Builder : TestMethodProvider
    {
        protected const string NON_LITERAL_CHARACTERS = "[\\^$.|?*+()";

        protected const MethodType METHOD_TYPES_ALLOWED_FOR_CHARACTERS = MethodType.Begin | MethodType.Anchor | MethodType.Group | MethodType.Quantifier | MethodType.Character;

        /** @var string[] RegEx being built. */
        protected List<string> regEx = new List<string>();
        /** @var string Raw modifiers to apply on get(). */
        protected string modifiers = "";

        /** @var int Type of last method, to avoid invalid builds. */
        protected MethodType lastMethodType = MethodType.Begin;

        protected Dictionary<string, string> modifierMapper = new Dictionary<string, string>
        {
            { "all", "g" },
            { "multiLine", "m" },
            { "singleLine", "s" },
            { "caseInsensitive", "i" },
            { "unicode", "u" },
            { "allLazy", "U" }
        };

        [Flags]
        protected enum MethodType
        {
            // Replace with binary literals if we use C# 7.0 in the future
            Begin = 1,       //0b00001
            Character = 2,   //0b00010
            Group = 4,       //0b00100
            Quantifier = 8,  //0b01000
            Anchor = 16,     //0b10000
            Unknown = 31     //0b11111
        }

        public override string get(string delimiter = "/", bool ignoreInvalid = false)
        {
            throw new NotImplementedException();
        }
    }
}
