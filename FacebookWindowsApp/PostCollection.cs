using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookWindowsApp
{
    class PostCollection : IEnumerable, IEnumerable<string>
    {
        private readonly List<string> m_Posts = new List<string>();
        public Func<string, bool> Test { get; set; }

        public PostCollection(User user, Func<string, bool> i_Test)
        {
            this.Test = i_Test;
            foreach (Post post in user.Posts)
            {
                if(post.Message != null)
                {
                    m_Posts.Add(post.Message);
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PostIterator(this, Test);
        }
        
        IEnumerator<string> IEnumerable<string>.GetEnumerator()
        {
            for (int i = 0; i < m_Posts.Count; ++i)
            {
                if ( !Test.Invoke(m_Posts[i]))
                {
                    continue;
                }
                yield return m_Posts[i];
            }
        }

        private class PostIterator : IEnumerator
        {
            private PostCollection m_Collection;
            private int m_CurrentIdx = -1;
            private int m_Count = -1;
            private Func<string, bool> m_Test;

            public PostIterator(PostCollection i_Collection, Func<string, bool> i_Test)
            {
                m_Test = i_Test;
                m_Collection = i_Collection;
                m_Count = m_Collection.m_Posts.Count;
            }

            public object Current
            {
                get
                {
                    return m_Collection.m_Posts[m_CurrentIdx];
                }
            }

            public bool MoveNext()
            {
                ++m_CurrentIdx;
                if ( !m_Test(m_Collection.m_Posts[m_CurrentIdx]) )
                {
                    ++m_CurrentIdx;
                }

                return m_CurrentIdx < m_Collection.m_Posts.Count;
            }

            public void Reset()
            {
                m_CurrentIdx = 0;
            }

        }
    }
}