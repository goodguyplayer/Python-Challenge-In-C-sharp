using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace PythonChallengeInCSharp
{
    // https://blog.kowalczyk.info/article/8n/serialization-in-c.html
    class Serialization
    {
        const int VERSION = 1;
        static void Save(MySettings settings, string fileName)
        {
            Stream stream = null;
            try
            {
                IFormatter formatter = new BinaryFormatter();
                stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, VERSION);
                formatter.Serialize(stream, settings);
            }
            catch
            {
                // do nothing, just ignore any possible errors
            }
            finally
            {
                if (null != stream)
                    stream.Close();
            }
        }

        static MySettings Load(string fileName)
        {
            Stream stream = null;
            MySettings settings = null;
            try
            {
                IFormatter formatter = new BinaryFormatter();
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
                int version = (int)formatter.Deserialize(stream);
                Debug.Assert(version == VERSION);
                settings = (MySettings)formatter.Deserialize(stream);
            }
            catch
            {
                // do nothing, just ignore any possible errors
            }
            finally
            {
                if (null != stream)
                    stream.Close();
            }
            return settings;
        }
    }

    public class MySettings
    {
        public int screenDx;
        public ArrayList recentlyOpenedFiles;
        [NonSerialized] public string dummy;
    }
}
