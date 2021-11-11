using System;
using System.Collections.Generic;
using System.Text;

namespace DiamondKata
{
    public class DiamondCreator
    {
        public string Create(char input)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(input);

            return builder.ToString();
        }
    }
}
