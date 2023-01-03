using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ModDefinedVariables
{
    public List<string> definedVariables = new List<string>();

    public string GetVariable(int index)
    {
        return definedVariables[index];
    }
}
