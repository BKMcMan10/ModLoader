using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ModError
{
    public List<string> errors = new List<string>();

    static Logger logger = Logger.GetLogger();

    public void Init()
    {
        errors.Add("UndefinedVariableExeption");
        errors.Add("UndefinedTypeExeption");
        errors.Add("ClassNotFoundExeption");
        errors.Add("PackageNotFoundExeption");
    }

    public void ThrowError(int index)
    {
        logger.Log(errors[index], LogLevel.ERROR);
    }
}