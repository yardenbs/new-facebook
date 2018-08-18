using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookWindowsApp
{
    class RocchioModel : SentimentAnalyzer 
    {
        //using Rocchio Algorithm
        private List<float> m_Centroid_Neg;
        private List<float> m_Centroid_Pos;

        public RocchioModel()
        {
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

        public override bool Predict(string i_Sentence)
        {
            Vec vec = new Vec(i_Sentence);

            return (calculateVecDistance(vec, new Vec(m_Centroid_Neg)) -0.5  < calculateVecDistance(vec, new Vec(m_Centroid_Pos))) ? false : true;
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
