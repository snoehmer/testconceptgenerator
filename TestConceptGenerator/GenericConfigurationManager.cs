using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TestConceptGenerator
{
    public class GenericConfigurationManager
    {
        public class ConfigurationValue
        {
            public string value;
            public string comment;

            public ConfigurationValue()
            {
                value = "";
                comment = "";
            }

            public ConfigurationValue(string value, string comment = "")
            {
                this.value = String.Copy(value);
                this.comment = String.Copy(comment);
            }

            public ConfigurationValue(int value, string comment = "")
            {
                this.value = value.ToString();
                this.comment = String.Copy(comment);
            }

            public int getNumericValue()
            {
                return int.Parse(value);
            }
        }


        protected Dictionary<string, ConfigurationValue> configurationSet;
        protected string configPath;

        public GenericConfigurationManager(string configPath)
        {
            this.configPath = String.Copy(configPath);

            if(!File.Exists(configPath))
            {
                generateDefaultConfig();
                writeConfigXML(configPath);
            }
            else
            {
                readConfigXML(configPath);
            }
        }

        
        protected virtual void generateDefaultConfig()
        {
            configurationSet = new Dictionary<string, ConfigurationValue>();
        }


        private void writeConfigXML(string configPath)
        {
            XmlDocument doc = new XmlDocument();

            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);

            XmlNode configurationList = doc.CreateElement("configurationList");
            doc.AppendChild(configurationList);

            foreach(KeyValuePair<string, ConfigurationValue> configuration in configurationSet)
            {
                XmlNode xmlConfiguration = xmlFromConfiguration(doc, configuration);

                configurationList.AppendChild(xmlConfiguration);
            }

            if(!Directory.Exists(Path.GetDirectoryName(configPath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(configPath));
            }

            doc.Save(configPath);
        }


        private XmlNode xmlFromConfiguration(XmlDocument doc, KeyValuePair<string, ConfigurationValue> configuration)
        {
            XmlNode xmlConfiguration = doc.CreateElement("configuration");
            XmlAttribute attributeKey = doc.CreateAttribute("key");
            XmlAttribute attributeValue = doc.CreateAttribute("value");
            XmlAttribute attributeComment = doc.CreateAttribute("comment");

            attributeKey.Value = configuration.Key;
            attributeValue.Value = configuration.Value.value;
            attributeComment.Value = configuration.Value.comment;

            xmlConfiguration.Attributes.Append(attributeKey);
            xmlConfiguration.Attributes.Append(attributeValue);
            xmlConfiguration.Attributes.Append(attributeComment);

            return xmlConfiguration;
        }


        private void readConfigXML(string configPath)
        {
            if(!File.Exists(configPath))
            {
                throw new Exception("ConfigurationManager: readFromXML(): could not open XML file '" + configPath + "'!");
            }

            if(configurationSet == null)
            {
                configurationSet = new Dictionary<string,ConfigurationValue>();
            }
            else
            {
                configurationSet.Clear();
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(configPath);

            if(doc == null)
            {
                throw new Exception("ConfigurationManager: readFromXML(): could not read XML file '" + configPath + "'!");
            }

            XmlNode xmlConfigList = doc.SelectSingleNode("/configurationList");

            if(xmlConfigList == null)
            {
                throw new Exception("ConfigurationManager: readFromXML(): could not find configuration list in XML file!");
            }

            XmlNodeList xmlConfigValues = xmlConfigList.SelectNodes("configuration");

            foreach(XmlNode xmlConfigValue in xmlConfigValues)
            {
                string configKey = configKeyFromXML(xmlConfigValue);
                ConfigurationValue configValue = configValueFromXML(xmlConfigValue);

                configurationSet.Add(configKey, configValue);

            }
        }

        private string configKeyFromXML(XmlNode xmlConfig)
        {
            return xmlConfig.Attributes.GetNamedItem("key").Value;
        }

        private ConfigurationValue configValueFromXML(XmlNode xmlConfig)
        {
            return new ConfigurationValue(xmlConfig.Attributes.GetNamedItem("value").Value, xmlConfig.Attributes.GetNamedItem("comment").Value);
        }

        public bool isKnownKey(string key)
        {
            return configurationSet.ContainsKey(key);
        }

        public string getConfigurationValue(string key)
        {
            if(configurationSet.ContainsKey(key))
            {
                return configurationSet[key].value;
            }
            else
            {
                return null;
            }
        }

        public int getNumericConfigurationValue(string key)
        {
            if(configurationSet.ContainsKey(key))
            {
                return int.Parse(configurationSet[key].value);
            }
            else
            {
                return -1;
            }
        }

        public string getConfigurationComment(string key)
        {
            if(configurationSet.ContainsKey(key))
            {
                return configurationSet[key].comment;
            }
            else
            {
                return null;
            }
        }

        public void setConfiguration(string key, string value, string comment = "")
        {
            if(configurationSet.ContainsKey(key))
            {
                configurationSet[key].value = String.Copy(value);
                configurationSet[key].comment = String.Copy(comment);
            }
            else
            {
                configurationSet.Add(key, new ConfigurationValue(value, comment));
            }
        }

        public void setConfiguration(string key, int value, string comment = "")
        {
            if(configurationSet.ContainsKey(key))
            {
                configurationSet[key].value = value.ToString();
                configurationSet[key].comment = String.Copy(comment);
            }
            else
            {
                configurationSet.Add(key, new ConfigurationValue(value.ToString(), comment));
            }
        }

        public void updateXML()
        {
            writeConfigXML(configPath);
        }

        public static string getProgramDir()
        {
            return Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        }
    }
}
