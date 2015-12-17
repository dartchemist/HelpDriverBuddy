namespace HelpDriverBuddy.Data
{
    using System;
    using STSdb4.Database;
    using Models;

    public class STSdbContext : IDisposable
    {
        private IStorageEngine storageEngine;

        public STSdbContext(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("provide valid file path");
            }

            this.storageEngine = STSdb.FromFile(filePath);
            this.TableProblem = this.storageEngine.OpenXTable<long, VehicleProblem>("Problems");
        }

        public ITable<long, VehicleProblem> TableProblem { get; private set; }

        public ITable<TKey, TValue> Table<TKey, TValue>()
        {
            if (typeof(TKey) == typeof(long) && typeof(TValue) == typeof(VehicleProblem))
            {
                return (ITable<TKey, TValue>)this.TableProblem;
            }

            throw new ArgumentException("doesn't present such table");
        }

        public void Dispose()
        {
            this.storageEngine.Dispose();
        }

        public void Commit()
        {
            this.storageEngine.Commit();
        }
    }
}
