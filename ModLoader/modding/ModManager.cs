using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ModManager
{
    public static ModDefinedVariables variables = new ModDefinedVariables();
    public static ModError errors = new ModError();
    public static ModPackages packages = new ModPackages();
    public static ModStringParser parser = new ModStringParser();
    public static ModType type = new ModType();
}