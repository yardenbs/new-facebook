using System;
using System.Collections.Generic;

namespace FacebookWindowsApp
{
    internal class RocchioModel : SentimentAnalyzer
    {
        //using Rocchio Algorithm
        private List<float> m_Centroid_Neg;
        private List<float> m_Centroid_Pos;

        public RocchioModel()
        {
            Name = this.GetType().Name;
            m_Centroid_Neg = getNegVecFromFile();
            m_Centroid_Pos = getPosVecFromFile();
        }

        public override bool Predict(string i_Sentence)
        {
            Vec vec = new Vec(i_Sentence);

            return (calculateVecDistance(vec, new Vec(m_Centroid_Neg)) - 0.5 < calculateVecDistance(vec, new Vec(m_Centroid_Pos))) ? false : true;
        }

        protected override void setExplanation()
        {
            this.ClassifierExplanation = FacebookWindowsApp.Resource.RocchioExplanation;
        }

        private List<float> getNegVecFromFile()
        {
            List<float> res = new List<float>();

            string[] vectorAsStrings = (FacebookWindowsApp.Resource.centroid_Neg).Split('\r');

            foreach (string num in vectorAsStrings)
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

            string[] vectorAsStrings = (FacebookWindowsApp.Resource.centroid_Pos).Split('\r');

            foreach (string num in vectorAsStrings)
            {
                float parsedFloat;
                float.TryParse(num.Replace("\r", string.Empty), out parsedFloat);
                res.Add(parsedFloat);
            }

            return res;
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

            for (int i = 0; i < length - 1; i++)
            {
                sum += Math.Pow(i_Vec2.Vectr[i] - i_Vec1.Vectr[i], 2);
            }

            return sum;
        }
    }
}