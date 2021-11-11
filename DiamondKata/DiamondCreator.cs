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
                    string secondPart = null;
                    if (current == input)
                    {
                        secondPart = string.Concat(builder.ToString().TrimEnd('\n').ToArray().Reverse());
                    }

                    builder.Append(indentation)
                        .Append(current)
                        .Append(GetMiddleSpacesFor(current, input))
                        .Append(current)
                        .Append(indentation);

                    if (current == input)
                    {
                        builder.Append('\n');
                        builder.Append(string.Concat(secondPart));
                    }
                }

                builder.Append('\n');
            }


            return builder.ToString();
        }

        public string GetIndentationFor(char current, char input) =>
            new StringBuilder().Append(emptySpaceCharacter, input - current).ToString();

        public string GetMiddleSpacesFor(char current, char input) =>
            new StringBuilder().Append(emptySpaceCharacter, ((current - 'A') * 2) - 1).ToString();
    }
}
