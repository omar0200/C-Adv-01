using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Cache<TKey, TValue>
{
    private Dictionary<TKey, TValue > _cache
        = new Dictionary<TKey, TValue>();

    public void Add(TKey key, TValue value)
    {
        _cache[key] = (value);
    }

    public TValue Get(TKey key)
    {
            return _cache[key];
    }

       

    public void Remove(TKey key)
    {
        _cache.Remove(key);
    }


    public bool Contains(TKey key)
    {
        return _cache.ContainsKey(key);
    }
}