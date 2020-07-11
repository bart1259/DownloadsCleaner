using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using Syroot.Windows.IO;

namespace DownloadsCleanerConfig
{
    public class CleanerConfig
    {
        public static string DEFAULT_CONFIG_PATH = "CleanerSettings.xml";
        public static CleanerConfig DefaultConfig
        {
            get
            {
                CleanerConfig config = new CleanerConfig();
                Console.WriteLine(new KnownFolder(KnownFolderType.Downloads).ExpandedPath);
                config.SearchedDirectories.Add(new SearchedDirectory(new KnownFolder(KnownFolderType.Downloads).ExpandedPath, 60));

                return config;
            }
        }

        public List<SearchedDirectory> SearchedDirectories { get; protected set; }
        public string DeletionStrategy { get; set; } = "Notify";

        /// <summary>
        /// Value assicoiated with deletion strategy, for notify its the time
        /// before the file gets deleted
        /// </summary>
        public int PromptValue { get; set; } = 1;

        /// <summary>
        /// The number of minutes to wait before asking to delete again
        /// when a user presses decide later
        /// </summary>
        public int BreakTime { get; set; } = 1;

        /// <summary>
        /// Combine file deletions if they are within this many minutes
        /// </summary>
        public int CombineTime { get; set; } = 5;

        /// <summary>
        /// Number of minutes before deleting starts
        /// </summary>
        public int DelayedStart { get; set; } = 5;

        /// <summary>
        /// If by default the notification should keep the file or delete it
        /// </summary>
        public bool DefaultKeep { get; set; } = true;

        public CleanerConfig()
        {
            SearchedDirectories = new List<SearchedDirectory>();
        }

        public static CleanerConfig ParseConfig(string path)
        {
            //Try and read the config from the xml file

            //Get new config
            CleanerConfig config = new CleanerConfig();

            try
            {
                XDocument doc = XDocument.Load(path);
                foreach (var searchedDirectory in doc.Root.Element("paths").Elements("searchedDirectory"))
                {
                    string directoryPath = searchedDirectory.Element("path").Value;
                    int time = int.Parse(searchedDirectory.Element("deleteTime").Value);
                    config.SearchedDirectories.Add(new SearchedDirectory(directoryPath, time));
                }

                string strategy = doc.Root.Element("prompt").Attribute("type").Value;
                config.DeletionStrategy = strategy;
                config.PromptValue = int.Parse(doc.Root.Element("prompt").Value);

                config.BreakTime = int.Parse(doc.Root.Element("breakTime").Value);
                config.CombineTime = int.Parse(doc.Root.Element("combineTime").Value);
                config.DelayedStart = int.Parse(doc.Root.Element("delayedStart").Value);
                config.DefaultKeep = bool.Parse(doc.Root.Element("keepDefault").Value);
            }
            catch (Exception)
            {
                Console.WriteLine("Config file is invalid, dropping default config");
                config = DefaultConfig;
            }

            return config;
        }

        /// <summary>
        /// Writes a config file as xml to the file
        /// </summary>
        /// <param name="config">the config to write</param>
        /// <param name="path">the path to the file</param>
        public static void SaveConfigToFile(CleanerConfig config, string path)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.NewLineChars = "\r\n";
            settings.NewLineHandling = NewLineHandling.Replace;
            XmlWriter writer = XmlWriter.Create(path, settings);
            writer.WriteStartDocument();
            writer.WriteStartElement("settings");
            writer.WriteStartElement("paths");

            for (int i = 0; i < config.SearchedDirectories.Count; i++)
            {
                writer.WriteStartElement("searchedDirectory");
                WriteOneLineXmlElement(writer, "path", config.SearchedDirectories[i].Path);
                WriteOneLineXmlElement(writer, "deleteTime", config.SearchedDirectories[i].FileAgeLimit.ToString());
                writer.WriteEndElement();
            }

            writer.WriteEndElement();

            writer.WriteStartElement("prompt");
            writer.WriteAttributeString("type", config.DeletionStrategy);
            writer.WriteString(config.PromptValue.ToString());
            writer.WriteEndElement();

            WriteOneLineXmlElement(writer, "breakTime", config.BreakTime.ToString());
            WriteOneLineXmlElement(writer, "combineTime", config.CombineTime.ToString());
            WriteOneLineXmlElement(writer, "delayedStart", config.DelayedStart.ToString());
            WriteOneLineXmlElement(writer, "keepDefault", config.DefaultKeep.ToString());

            writer.WriteEndElement();
            writer.Close();
        }


        /// <summary>
        /// Writes a simple xml element
        /// </summary>
        /// <param name="writer">the xml writer to write with</param>
        /// <param name="elementName">the name of the element</param>
        /// <param name="elementValue">the value of the element</param>
        private static void WriteOneLineXmlElement(XmlWriter writer, string elementName, string elementValue)
        {
            writer.WriteStartElement(elementName);
            writer.WriteString(elementValue);
            writer.WriteEndElement();
        }

        public override string ToString()
        {
            string ret = "Searches " + SearchedDirectories.Count + " directories: ";

            for (int i = 0; i < SearchedDirectories.Count; i++)
            {
                ret += "\n Age limit " + SearchedDirectories[i].FileAgeLimit + " minutes for: " + SearchedDirectories[i].Path;
            }

            return ret;
        }
    }
}
