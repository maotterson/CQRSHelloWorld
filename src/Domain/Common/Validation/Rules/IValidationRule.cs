using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common.Validation.Rules;

public interface IValidationRule<T>
{
    public (bool, string?) Check(T obj);
}
