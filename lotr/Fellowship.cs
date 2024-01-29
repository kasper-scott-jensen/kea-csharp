using System.Collections;

namespace lotr;

public class Fellowship<T> : IEnumerable
{

    private List<T> Members { get; }

    public Fellowship()
    {
        Members = new List<T>();
    }

    public void Add(T member)
    {
        Members.Add(member);
    }

    public void Remove(T member)
    {
        Members.Remove(member);
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (T member in Members)
        {
            yield return member;
        }
    }
 
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
}