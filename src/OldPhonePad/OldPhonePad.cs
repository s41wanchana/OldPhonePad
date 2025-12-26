using System.Text;
public static class PhonePad
{
    public static string OldPhonePad(string input)
    {
        var keyGroup = GroupConsecutiveKey(input);

        var outputCharacters = ConvertKeyToCharacter(keyGroup);

        return Concatenate(outputCharacters);
    }

    private static List<string> GroupConsecutiveKey(string input)
    {
        var keyGroup = new List<string>();

        for (int i = 0; i < input.Length; i++)
        {
            string temp = input[i].ToString();
            int counter = 1;

            while (i + 1 < input.Length && input[i] == input[i + 1])
            {
                if (input[i] == '9' || input[i] == '7')
                {
                    if (counter == 4) break;
                }
                else if (counter == 3)
                {
                    break;
                }

                temp += input[i];
                i++;
                counter++;
            }

            keyGroup.Add(temp);
        }

        return keyGroup;
    }

    private static List<string> ConvertKeyToCharacter(List<string> input)
    {
        var numberToCharacterMap = new Dictionary<string, string>
        {
            ["1"] = "&",
            ["11"] = "'",
            ["111"] = "(",
            ["2"] = "A",
            ["22"] = "B",
            ["222"] = "C",
            ["3"] = "D",
            ["33"] = "E",
            ["333"] = "F",
            ["4"] = "G",
            ["44"] = "H",
            ["444"] = "I",
            ["5"] = "J",
            ["55"] = "K",
            ["555"] = "L",
            ["6"] = "M",
            ["66"] = "N",
            ["666"] = "O",
            ["7"] = "P",
            ["77"] = "Q",
            ["777"] = "R",
            ["7777"] = "S",
            ["8"] = "T",
            ["88"] = "U",
            ["888"] = "V",
            ["9"] = "W",
            ["99"] = "X",
            ["999"] = "Y",
            ["9999"] = "Z",
            ["0"] = " "
        };

        var outputCharacters = new List<string>();

        for (int i = 0; i < input.Count; i++)
        {
            if (input[i] == "#") break;

            if (input[i] == "*")
            {
                if (outputCharacters.Count > 0)
                    outputCharacters.RemoveAt(outputCharacters.Count - 1);
            }
            else
            {

                if (numberToCharacterMap.TryGetValue(input[i], out var mapped))
                    outputCharacters.Add(mapped);
                else
                    outputCharacters.Add(null);
            }
        }

        return outputCharacters;
    }

    private static string Concatenate(List<string> input)
    {
        var sb = new StringBuilder();
        foreach (var s in input)
            sb.Append(s);

        return sb.ToString();
    }
}
