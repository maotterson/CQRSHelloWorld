using System.Collections;
using Domain.Validation.Enumss;

namespace Domain.Validation.Entities;

public class PropertyRules : IEnumerable<(GuardClause clause, int? constraint)>
{
    private readonly IReadOnlyList<(GuardClause clause, int? constraint)> list;

    public PropertyRules(params (GuardClause clause, int? value)[] options)
    {
        list = options.ToList();
    }

    public IEnumerator<(GuardClause clause, int? constraint)> GetEnumerator()
    {
        return list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)list).GetEnumerator();
    }
}
