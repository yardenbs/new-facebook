using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookWindowsApp
{
    internal class PostIterator : IEnumerator
    {
        private PostAggregate m_Collection;
        private int m_CurrentIdx = -1;
        private int m_Count = -1;
        private Func<string, bool> m_Test;

        public PostIterator(PostAggregate i_Collection, Func<string, bool> i_Test)
        {
            m_Test = i_Test;
            m_Collection = i_Collection;
            m_Count = m_Collection.Posts.Count;
        }

        public object Current
        {
            get
            {
                return m_Collection.Posts[m_CurrentIdx];
            }
        }

        public bool MoveNext()
        {
            ++m_CurrentIdx;
            if (!m_Test(m_Collection.Posts[m_CurrentIdx]))
            {
                ++m_CurrentIdx;
            }

            return m_CurrentIdx < m_Collection.Posts.Count;
        }

        public void Reset()
        {
            m_CurrentIdx = 0;
        }

    }
}
