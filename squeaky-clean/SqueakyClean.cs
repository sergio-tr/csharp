using System;
using System.Text;

public static class Identifier
{
    private static readonly char UnderScored = '_';
    private static readonly char Dash = '-';
    private static readonly string Ctrl = "CTRL";

    public static string Clean(string identifier) {
        
        // Won't be necessary in this case 
        if (identifier == null){
            throw new ArgumentNullException("Identifier must not be null");
        }

        if(identifier.Length == 0){
            return "";
        }

        var result = new StringBuilder();
        bool nextUpper = false;

        foreach (var c in identifier) {
            if (char.IsWhiteSpace(c))
            {
                result.Append(UnderScored);
            }
            else if (char.IsControl(c))
            {
                result.Append(Ctrl);
            }
            else if (c == Dash)
            {
                nextUpper = true;
            }
            else if (char.IsLetter(c))
            {
                if (nextUpper)
                {
                    result.Append(char.ToUpper(c));
                    nextUpper = false;
                }
                else if (!IsGreekLowerCase(c))
                {
                    result.Append(c);
                }
            }
        }

        return result.ToString();
    }

    private static bool IsGreekLowerCase(char c) {
        return c >= '\u03B1' && c <= '\u03C9';
    }

}
