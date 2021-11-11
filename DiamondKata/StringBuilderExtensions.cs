using System.Text;

namespace DiamondKata
{
    public static class StringBuilderExtensions
    {
        private const char emptySpaceCharacter = ' ';

        public static StringBuilder AppendIndentationFor(this StringBuilder stringBuilder, char current, char input)
        {
            stringBuilder.Append(emptySpaceCharacter, input - current);
            return stringBuilder;
        }

        public static StringBuilder AppendMiddleSpacesFor(this StringBuilder stringBuilder, char current)
        {
            stringBuilder.Append(emptySpaceCharacter, ((current - 'A') * 2) - 1);
            return stringBuilder;
        }
    }
}