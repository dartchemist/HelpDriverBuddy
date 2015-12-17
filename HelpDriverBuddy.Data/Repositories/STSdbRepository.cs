namespace HelpDriverBuddy.Data.Repositories
{
    using STSdb4.Database;
    using System;
    using System.Collections.Generic;

    public class STSdbRepository<TKey, TValue> : IRepository<TKey, TValue>
    {
        public readonly STSdbContext Context;

        public STSdbRepository(STSdbContext context)
        {
            if(context == null)
            {
                throw new ArgumentNullException("context");
            }

            this.Context = context;
            this.Table = Context.Table<TKey, TValue>();
        }

        protected ITable<TKey,TValue> Table { get; set; }

        public void Replace(TKey key, TValue value)
        {
            if(this.Table.Exists(key))
            {
                throw new ArgumentException("key present already!");
            }

            this.Table.Replace(key, value);
        }

        public IEnumerable<KeyValuePair<TKey, TValue>> All()
        {
            return this.Table;
        }

        public void Delete(TKey key)
        {
            this.Table.Delete(key);
        }

        public TValue GetByKey(TKey key)
        {
            return this.Table[key];
        }

        public void SaveChanges()
        {
            this.Context.Commit();
        }

        public void Update(TKey key, TValue newValue)
        {
            this.Table.Replace(key, newValue);
        }
    }
}
