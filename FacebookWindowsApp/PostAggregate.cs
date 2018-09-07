using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookWindowsApp
{
    internal class PostAggregate : IEnumerable, IEnumerable<string>
    {
        public List<string> Posts { get; }
        public Func<string, bool> Test { get; set; }

        public PostAggregate(User user, Func<string, bool> i_Test)
        {
            Posts = new List<string>();
            this.Test = i_Test;
            foreach (Post post in user.Posts)
            {
                if(post.Message != null)
                {
                    Posts.Add(post.Message);
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PostIterator(this, Test);
        }
        
        IEnumerator<string> IEnumerable<string>.GetEnumerator()
        {
            for (int i = 0; i < Posts.Count; ++i)
            {
                if ( !Test.Invoke(Posts[i]))
                {
                    continue;
                }
                yield return Posts[i];
            }
        }
    }
}