using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ModStringParser
{
    public string[] GetWords(string[] file)
    {
        string concat = string.Join("", file);

        return concat.Split(' ');
    }

    public bool HasWord(string[] file, string word)
    {
        for(int f = 0; f < file.Length; f++)
        {
            if(file[f].Contains(word))
                return true;
        }

        return false;
    }
}
