using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiamondKata
{
    public class DiamondCreator
    {
        private const char emptySpaceCharacter = ' ';

        public string Create(char input)
        {
            StringBuilder builder = new StringBuilder();

            for (Char current = 'A'; current <= input; current++)
            {
                var indentation = GetIndentationFor(current, input);

                if (current == 'A')
                {
                    builder.Append(indentation)
                        .Append(current)
                        .Append(indentation);
                }
                else
                {
                    builder.Append(indentation)
                        .Append(current)
                        .Append(GetMiddleSpacesFor(current, input))
                        .Append(current)
                        .Append(indentation);
                }

                builder.Append("\\n");
            }


            return builder.ToString();
        }

        public string GetIndentationFor(char current, char input) =>
            new StringBuilder().Append(emptySpaceCharacter, input - current).ToString();

        public string GetMiddleSpacesFor(char current, char input) =>
            new StringBuilder().Append(emptySpaceCharacter, ((current - 'A') * 2) - 1).ToString();
    }
}
