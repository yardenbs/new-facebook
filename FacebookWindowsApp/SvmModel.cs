using System.Collections.Generic;

namespace FacebookWindowsApp
{
    internal class SvmModel : SentimentAnalyzer
    {
        //using SVM classifier
        private Vec m_TrainedSvmModel;

        public SvmModel()
        {
            Name = this.GetType().Name;
            m_TrainedSvmModel = getSvmModelFromFile();
        }
        
        public override Prediction Predict(string i_Sentence)
        {
            Vec vec = new Vec(i_Sentence);

            double dotProduct = calculateDotProduct(vec, m_TrainedSvmModel) - 0.5;
            bool pred = dotProduct > 0 ? true : false;
            double posPred = 100 / (1 + System.Math.Exp((-1) * dotProduct));
            double negPred = 100 - posPred;
            
            return new Prediction() { isPositive = pred , NegScore = negPred, PosScore = posPred};
        }

        protected override void setExplanation()
        {
            this.ClassifierExplanation = FacebookWindowsApp.Resource.SvmExplanation;
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
    }
}