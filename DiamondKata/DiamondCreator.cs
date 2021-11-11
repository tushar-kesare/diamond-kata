using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiamondKata
{
    public class DiamondCreator
    {
        private const char indentCharacter = ' ';

        public string Create(char input)
        {
            StringBuilder builder = new StringBuilder();

            var indentation = GetIndentationFor('A', input);

            builder.Append(indentation)
                .Append('A')
                .Append(indentation);

            return builder.ToString();
        }

        public string GetIndentationFor(char current, char input) =>
            new StringBuilder().Append(indentCharacter, input - current).ToString();
    }
}
