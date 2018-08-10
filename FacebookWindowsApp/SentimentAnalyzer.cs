using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace FacebookWindowsApp
{
    public class SentimentAnalyzer
    {
        //using Rocchio Algorithm
        private List<float> m_Centroid_Neg;
        private List<float> m_Centroid_Pos;
        private static List<string> s_Corpus;

        public SentimentAnalyzer()
        {
            s_Corpus = createCorpus();
            m_Centroid_Neg = getNegVecFromFile();
            m_Centroid_Pos = getPosVecFromFile();
        }

        private List<float> getNegVecFromFile()
        {
            List<float> res = new List<float>();

            string[] corpusAsStrings = (FacebookWindowsApp.Resource.centroid_Neg).Split('\r');

            foreach (string num in corpusAsStrings)
            {
                float parsedFloat;
                float.TryParse(num.Replace("\r", string.Empty), out parsedFloat);
                res.Add(parsedFloat);
            }

            return res;
        }

        private List<float> getPosVecFromFile()
        {
            List<float> res = new List<float>();

            string[] corpusAsStrings = (FacebookWindowsApp.Resource.centroid_Pos).Split('\r');

            foreach (string num in corpusAsStrings)
            {
                float parsedFloat;
                float.TryParse(num.Replace("\r", string.Empty), out parsedFloat);
                res.Add(parsedFloat);
            }

            return res;
        }

        private List<string> createCorpus()
        {
            List<string> res = new List<string>();
            string[] corpusAsStrings = (FacebookWindowsApp.Resource.corpus).Split('\n');
           
            foreach (string word in corpusAsStrings)
            {
                if( word != "")
                {
                    res.Add(word.Replace("\r", string.Empty));
                }
            }

            return res;
        }

        private class Vec
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

        public bool Predict(string i_Sentence)
        {
            Vec vec = new Vec(i_Sentence);

            return (calculateVecDistance(vec, new Vec(m_Centroid_Neg)) - 2.1 < calculateVecDistance(vec, new Vec(m_Centroid_Pos))) ? false : true;
        }

        private double calculateVecDistance(Vec i_Vec1, Vec i_Vec2)
        {
            double sum = sumOfSquares(i_Vec1, i_Vec2);

            return sum;
        }

        private double sumOfSquares(Vec i_Vec1, Vec i_Vec2)
        {
            int length = i_Vec1.Vectr.Count;
            double sum = 0;

            for (int i = 0; i < length-1; i++)
            {
                sum += Math.Pow(i_Vec2.Vectr[i] - i_Vec1.Vectr[i], 2);
            }

            return sum;
        }
    }
}
