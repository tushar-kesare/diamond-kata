using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiamondKata
{
    public class DiamondCreator
    {
        public string Create(char input)
        {
            var builder = new StringBuilder();

            for (char current = 'A'; current <= input; current++)
            {
                // Middle spaces not required for 'A'
                if (current == 'A')
                {
                    builder.AppendIndentationFor(current, input)
                        .Append(current)
                        .AppendIndentationFor(current, input);
                }
                else
                {
                    string secondHalf = null;
                    // Mirror the first half before appending line for input letter
                    if (current == input)
                    {
                        secondHalf = string.Concat(builder.ToString().TrimEnd('\n').ToArray().Reverse());
                    }

                    builder.AppendIndentationFor(current, input)
                        .Append(current)
                        .AppendMiddleSpacesFor(current)
                        .Append(current)
                        .AppendIndentationFor(current, input);

                    if (secondHalf != null)
                    {
                        builder.Append('\n');
                        builder.Append(string.Concat(secondHalf));
                    }
                }

                builder.Append('\n');
            }

            return builder.ToString();
        }
    }
}
