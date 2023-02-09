using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ModType
{
    public List<string> defaultTypes = new List<string>();
    public List<string> classTypes = new List<string>();

    ModStringParser parser = ModManager.parser;
    ModError error = ModManager.errors;
    ModDefinedVariables variables = ModManager.variables;

    public void Init()
    {
        defaultTypes.Add("byte");
        defaultTypes.Add("short");
        defaultTypes.Add("int");
        defaultTypes.Add("float");
        defaultTypes.Add("uint");
        defaultTypes.Add("long");
        defaultTypes.Add("char");
        defaultTypes.Add("void");
    }

    public void CheckForErrors(string[] file)
    {
        for(int f = 0; f < defaultTypes.Count; f++)
        {
            string[] subdividedFile = parser.GetWords(file);

            if (!parser.HasWord(subdividedFile, defaultTypes[f]) && parser.HasWord(file, subdividedFile[f + 1]))
            {
                error.ThrowError(1);
            }
            else
                continue;

            if (!parser.HasWord(file, variables.GetVariable(f)) && subdividedFile[f + 1] != "")
            {
                error.ThrowError(0);
            }
            else
            {
                variables.definedVariables.Add(subdividedFile[f + 1] + subdividedFile[f]);
                continue;
            }
                
        }
    }

    public void Register(string[] file)
    {
        for (int f = 0; f < defaultTypes.Count; f++)
        {
            string[] subdividedFile = parser.GetWords(file);

            if (parser.HasWord(subdividedFile, defaultTypes[f]) && parser.HasWord(file, subdividedFile[f + 1]))
            {
                variables.definedVariables.Add(subdividedFile[f + 1]);
            }

            if (parser.HasWord(subdividedFile, classTypes[f]) && parser.HasWord(file, subdividedFile[f + 1]))
            {
                variables.definedVariables.Add(subdividedFile[f + 1]);
            }
        }
    }
}
