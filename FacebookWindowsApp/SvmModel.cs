using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookWindowsApp
{
    class SvmModel : SentimentAnalyzer
    {
        //using SVM classifier
        private Vec m_trainedSvmModel;

        public SvmModel()
        {
            Name = this.GetType().Name;
            m_trainedSvmModel = getSvmModelFromFile();
        }

        private Vec getSvmModelFromFile()
        {
            List<float> res = new List<float>();

            string[] vectorAsStrings = (FacebookWindowsApp.Resource.SVM_model).Split('\r');

            foreach (string num in vectorAsStrings)
            {
                float parsedFloat;
                float.TryParse(num.Replace("\r", string.Empty), out parsedFloat);
                res.Add(parsedFloat);
            }

            return new Vec(res);
        }


        public override bool Predict(string i_Sentence)
        {
            Vec vec = new Vec(i_Sentence);

            return calculateDotProduct(vec, m_trainedSvmModel) - 0.5 > 0 ? true : false;
        }

        private double calculateDotProduct(Vec i_Vec1, Vec i_Vec2)
        {
            double sum = 0;
            int vLength = i_Vec1.Vectr.Count;

            for (int i = 0; i < vLength; i++)
            {
                sum += i_Vec1.Vectr[i] * i_Vec2.Vectr[i];
            }

            return sum;
        }

        protected override void setExplanation()
        {
            this.ClassifierExplanation = FacebookWindowsApp.Resource.SvmExplanation;
        }
    }
}
