using System.Collections.Generic;
using System.Xml.Serialization;

namespace AppUpdate
{
    [XmlRoot("Update")]
    public class DataModel
    {
        [XmlArray("Android")]
        [XmlArrayItem("Item")]
        public List<Item> ItemsAndroid { get; set; }

        [XmlArray("IOS")]
        [XmlArrayItem("Item")]
        public List<Item> ItemsIOS { get; set; }
    }

    [XmlRoot("Item")]
    public class Item
    {
        [XmlAttribute("minUpdateVer")]
        public string minUpdateVer { get; set; }
        [XmlAttribute("maxUpdateVer")]
        public string maxUpdateVer { get; set; }
        [XmlAttribute("version")]
        public string version { get; set; }
        [XmlAttribute("versionName")]
        public string versionName { get; set; }
        [XmlAttribute("size")]
        public string size { get; set; }
        [XmlAttribute("versionDescription")]
        public string versionDescription { get; set; }
        [XmlAttribute("downUrl")]
        public string downUrl { get; set; }
        [XmlAttribute("appMarketCode")]
        public string appMarketCode { get; set; }
        [XmlAttribute("appMarketName")]
        public string appMarketName { get; set; }
    }
}
