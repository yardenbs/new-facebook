using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FacebookWindowsApp
{
    public abstract class SentimentAnalyzer
    {
        protected static List<string> s_Corpus;
        public String Name { get; protected set; }
        public String ClassifierExplanation { get; protected set; }

        public SentimentAnalyzer()
        {
            s_Corpus = createCorpus();
            setExplanation();
        }

        public abstract bool Predict(string i_Sentence);

        protected abstract void setExplanation();

        private List<string> createCorpus()
        {
            List<string> res = new List<string>();
            string[] corpusAsStrings = (FacebookWindowsApp.Resource.corpus).Split('\n');

            foreach (string word in corpusAsStrings)
            {
                if (word != "")
                {
                    res.Add(word.Replace("\r", string.Empty));
                }
            }

            return res;
        }

        protected class Vec
        {
            public List<float> Vectr { get; set; }

            public Vec(string i_Sentence)
            {
                Vectr = vectorize(tokenize(i_Sentence));
            }

            public Vec(List<float> i_Vectr)
            {
                Vectr = i_Vectr;
            }

            private List<string> tokenize(string i_Sentence)
            {
                List<string> res = new List<string>();
                string[] dummyStrings = { "" };
                string[] tokens = (i_Sentence != null) ? i_Sentence.Split(' ') : dummyStrings;

                foreach (string str in tokens)
                {
                    string currTok = str.ToLower();
                    currTok = Regex.Replace(currTok, @"[^a-z]+", "");
                    res.Add(currTok);
                }

                return res;
            }

            private List<float> vectorize(List<string> i_Tokens)
            {
                List<float> res = new List<float>();

                foreach (string word in s_Corpus)
                {
                    if (i_Tokens.Contains(word))
                    {
                        int frequency = 0;

                        foreach (string tok in i_Tokens)
                        {
                            if (word == tok)
                            {
                                frequency++;
                            }
                        }

                        res.Add(frequency);
                    }
                    else
                    {
                        res.Add(0);
                    }
                }

                return res;
            }
        }
    }
}