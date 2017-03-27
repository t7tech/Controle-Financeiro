using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace T7.ControleFinanceiro.Core
{
    public class SerializeHelper
    {
        /// <summary>
        /// Serializa um Objeto
        /// </summary>
        /// <typeparam name="T">Tipo do Objeto</typeparam>
        /// <param name="value">Objeto Original</param>
        /// <returns>Objeto Serializado</returns>
        public static string Serialize<T>(object value)
        {
            var stringWriter = new StringWriter();

            using (var writer = XmlWriter.Create(stringWriter, new XmlWriterSettings()
            {
                Indent = true,
                OmitXmlDeclaration = true
            }))
            {

                new XmlSerializer(typeof(T)).Serialize(writer, value);

                return stringWriter.ToString();

            }
        }

        /// <summary>
        /// Deserializa um Objeto
        /// </summary>
        /// <typeparam name="T">Tipo do Objeto</typeparam>
        /// <param name="value">Objeto Serializado</param>
        /// <returns>Objeto Deserializado</returns>
        public static T Deserialize<T>(string value)
        {
            T result;

            var serializer = new XmlSerializer(typeof(T), "");
            using (var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(value)))
            {
                result = (T)serializer.Deserialize(memoryStream);
                memoryStream.Close();
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToJson(object value)
        {
            return JsonConvert.SerializeObject(value, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T JsonToObject<T>(string json)
        {
            return (T)JsonConvert.DeserializeObject<T>(json);
        }
    }
}