using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common.Validation;

public class ValidationOptions : IEnumerable<(ValidationRule Rule, int? Value)>
{
    private IList<(ValidationRule Rule, int? Value)> _ruleList;

    public ValidationOptions(params (ValidationRule Rule, int? Value)[] rules)
    {
        _ruleList = new List<(ValidationRule, int?)>();
        foreach(var rule in rules)
        {
            var item = (rule.Rule, rule.Value);
            _ruleList.Add(item);
        }
    }

    public IEnumerator<(ValidationRule Rule, int? Value)> GetEnumerator()
    {
        return _ruleList.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)_ruleList).GetEnumerator();
    }
}
