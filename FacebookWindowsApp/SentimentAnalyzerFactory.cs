using System;
using System.Collections.Generic;
using System.Reflection;

namespace FacebookWindowsApp
{
    internal static class SentimentAnalyzerFactory
    {
        public static Dictionary<String, ConstructorInfo> ClassifiersList { get; private set; }

        static SentimentAnalyzerFactory()
        {
            loadClassifiers();
        }

        public static SentimentAnalyzer createSentimentAnalyzer(String i_ClassifierType)
        {
            ConstructorInfo ret = null;

            ClassifiersList.TryGetValue(i_ClassifierType, out ret);

            return ret.Invoke(new Object[] { }) as SentimentAnalyzer;
        }

        // Use reflection to retrieve all classifiers in the App Domain
        private static void loadClassifiers()
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
    }
}