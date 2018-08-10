using System;
using System.IO;
using System.Xml.Serialization;

namespace FacebookWindowsApp
{
    public sealed class AppSettings
    {
        private static readonly string sr_Path = Environment.CurrentDirectory + "AppSettings.xml";
        private static AppSettings s_Instance = null;
        private static readonly object sr_Padlock = new object();
        public bool RememberUser { get; set; }
        public string LastAccessToken { get; set; }

        private AppSettings()
        {

        }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = Instance;

            if (File.Exists(sr_Path))
            {
                using (Stream stream = new FileStream(sr_Path, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return appSettings;
        }
        
        public static AppSettings Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_Padlock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new AppSettings();
                        }
                    }
                }
                return s_Instance;
            }
        }

        public void SaveToFile()
        {
            FileMode fileMode = File.Exists(sr_Path) ? FileMode.Truncate : FileMode.Create;

            using (Stream stream = new FileStream(sr_Path, fileMode))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}
