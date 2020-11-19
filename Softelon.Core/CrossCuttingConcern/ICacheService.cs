using System;
namespace Softelon.Core.CrossCuttingConcern
{
    public interface ICacheService
    {
        T Get<T>(string key);
        void Add(string key, object data, int cacheTime);
        bool IsAdd(string key);
        void Remove(string key);
        void RemoveByPattern(string pattern);
        void Clear();
    }
}
