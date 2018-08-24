using System;
using System.Collections.Generic;
using System.Reflection;

namespace FacebookWindowsApp
{
    internal class SentimentAnalyzerFactory
    {
        public Dictionary<String, ConstructorInfo> ClassifiersList { get; private set; }

        public SentimentAnalyzerFactory()
        {
            loadClassifiers();
        }

        // Use reflection to retrieve all classifiers in the App Domain
        private void loadClassifiers()
        {
            ClassifiersList = new Dictionary<String, ConstructorInfo>();

            foreach (Assembly assembley in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Type type in assembley.GetTypes())
                {
                    if (type.IsSubclassOf(typeof(SentimentAnalyzer)) && !type.IsAbstract)
                    {
                        ConstructorInfo ctor = type.GetConstructor(new Type[] { });
                        ClassifiersList.Add(type.Name, ctor);
                    }
                }
            }
        }

        public SentimentAnalyzer createSentimentAnalyzer(String i_classifierType)
        {
            ConstructorInfo ret = null;

            if (ClassifiersList.TryGetValue(i_classifierType, out ret))
            {
                return ret.Invoke(new Object[] { }) as SentimentAnalyzer;
            }

            // default:
            return new RocchioModel();
        }
    }
}