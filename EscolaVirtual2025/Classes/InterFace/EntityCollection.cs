using System;
using System.Collections.Generic;
using System.Linq;

namespace EscolaVirtual2025.Classes.InterFace
{
    public class EntityCollection<T, Tid>
    {
        private List<Tid> m_ids = new List<Tid>();
        private List<T> m_dataSource;
        private Func<T, Tid> getIdFunc;

        public EntityCollection(List<T> dataSource, Func<T, Tid> getIdFunc)
        {
            m_dataSource = dataSource;
            this.getIdFunc = getIdFunc;
        }

        public List<T> Items => m_dataSource.Where(x => m_ids.Contains(getIdFunc(x))).ToList();

        public void Add(T item)
        {
            var id = getIdFunc(item);
            if (!m_ids.Contains(id))
            {
                m_ids.Add(id);
                if (!m_dataSource.Contains(item))
                    m_dataSource.Add(item);
            }
        }

        public void Remove(T item)
        {
            var id = getIdFunc(item);
            if (m_ids.Contains(id))
                m_ids.Remove(id);
        }

        public void Reorder<Tkey>(Func<T, Tkey> keySelector)
        {
            m_ids = Items.OrderBy(keySelector).Select(getIdFunc).ToList();
        }

        public void RemoveAll(Func<T, bool> predicate)
        {
            var toRemove = Items.Where(predicate).ToList();
            foreach (var item in toRemove)
                Remove(item);
        }

        public void Clear()
        {
            m_ids.Clear();
        }

    }
}
