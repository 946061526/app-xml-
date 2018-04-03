using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace AppUpdate
{
    public class Tool
    {
        public static T XmlDeserialize<T>(string xml)
        {
            if (string.IsNullOrEmpty(xml)) return default(T);
            using (MemoryStream stream = new MemoryStream())
            {
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(xml);
                writer.Flush();
                stream.Seek(0, SeekOrigin.Begin);
                StreamReader reader = new StreamReader(stream);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                T obj = (T)xmlSerializer.Deserialize(reader);
                reader.Close();
                reader.Close();
                writer.Close();
                writer.Dispose();
                return obj;
            }
        }

        public static bool Serialization<T>(T obj, string outPutFilePath)
        {
            bool result = true;
            XmlWriter writer = null;
            XmlSerializerNamespaces nameSpace;
            MemoryStream ms = new MemoryStream();
            try
            {
                writer = XmlWriter.Create(outPutFilePath, new XmlWriterSettings
                {
                    Indent = true,
                });
                nameSpace = new XmlSerializerNamespaces();
                nameSpace.Add("", "");
            }
            catch (ArgumentException error)
            {
                result = false;
                throw error;
            }
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            try
            {
                serializer.Serialize(writer, obj, nameSpace);

            }
            catch (InvalidOperationException error)
            {
                result = false;
                throw error;
            }
            finally
            {
                writer.Close();
            }
            return result;
        }

        #region 检测是否Json格式
        /// <summary>
        /// 检测是否Json格式
        /// </summary>
        /// <param name="model"></param>
        /// <param name="errIndex"></param>
        /// <returns></returns>
        public static bool IsJson(DataModel model)
        {
            try
            {
                string json = JsonConvert.SerializeObject(model);
                JObject.Parse(json);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static string IsJson(string str)
        {
            string jsonStr = "";
            try
            {
                object jsonObj = JsonConvert.DeserializeObject(str);
                jsonStr = JsonConvert.SerializeObject(jsonObj);
            }
            catch
            {
                return "";
            }
            return jsonStr;
        }
        #endregion
    }
}
