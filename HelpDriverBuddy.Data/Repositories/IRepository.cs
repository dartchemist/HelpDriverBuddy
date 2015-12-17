namespace HelpDriverBuddy.Data.Repositories
{
    using System.Collections.Generic;

    public interface IRepository<TKey, TValue>
    {
        void Replace(TKey key, TValue value);
        IEnumerable<KeyValuePair<TKey, TValue>> All();
        void Delete(TKey key);
        TValue GetByKey(TKey key);
        void SaveChanges();
    }
}
