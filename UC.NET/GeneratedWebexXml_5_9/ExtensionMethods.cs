using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace WebexNetClient
{
    public static class ExtensionMethods
    {
        private static readonly Dictionary<RuntimeTypeHandle, XmlSerializer> ms_serializers = new Dictionary<RuntimeTypeHandle, XmlSerializer>();
        private static readonly XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces(new XmlQualifiedName[] {
            new XmlQualifiedName("meeting", "http://www.webex.com/schemas/2002/06/service/meeting"),
            new XmlQualifiedName("user", "http://www.webex.com/schemas/2002/06/service/user"),
            new XmlQualifiedName("attendee", "http://www.webex.com/schemas/2002/06/service/attendee"),
            new XmlQualifiedName("meetingtype", "http://www.webex.com/schemas/2002/06/service/meetingtype"),
            new XmlQualifiedName("training", "http://www.webex.com/schemas/2002/06/service/training"),
            new XmlQualifiedName("history", "http://www.webex.com/schemas/2002/06/service/history"),
            new XmlQualifiedName("event", "http://www.webex.com/schemas/2002/06/service/event"),
            new XmlQualifiedName("site", "http://www.webex.com/schemas/2002/06/service/site"),
            new XmlQualifiedName("ep", "http://www.webex.com/schemas/2002/06/service/ep"),
            new XmlQualifiedName("sales", "http://www.webex.com/schemas/2002/06/service/sales"),
            new XmlQualifiedName("supportsession", "http://www.webex.com/schemas/2002/06/service/supportsession"),
            new XmlQualifiedName("serv", "http://www.webex.com/schemas/2002/06/service"),
            });

        public static string Serialize<T>(this T value)
        {
            var _serializer = GetValue(typeof(T));
            using (var _stream = new MemoryStream())
            {
                using (var _writer = new XmlTextWriter(_stream, new UTF8Encoding()))
                {
                    _serializer.Serialize(_writer, value, namespaces);
                    return Encoding.UTF8.GetString(_stream.ToArray()).Replace("d3p1", "xsi")
                        .Replace(@"type=""meeting:", @"type=""meeting.");  //hack of sadness
                }
            }
        }

        public static T Deserialize<T>(this string srcString)
            where T : new()
        {
            var _serializer = GetValue(typeof(T));
            using (var _stringReader = new StringReader(srcString))
            {
                using (XmlReader _reader = new XmlTextReader(_stringReader))
                {
                    return (T)_serializer.Deserialize(_reader);
                }
            }
        }

        private static XmlSerializer GetValue(Type type)
        {
            XmlSerializer _serializer;
            if (!ms_serializers.TryGetValue(type.TypeHandle, out _serializer))
            {
                lock (ms_serializers)
                {
                    if (!ms_serializers.TryGetValue(type.TypeHandle, out _serializer))
                    {
                        _serializer = new XmlSerializer(type);
                        ms_serializers.Add(type.TypeHandle, _serializer);
                    }
                }
            }
            return _serializer;
        }
    }
}
