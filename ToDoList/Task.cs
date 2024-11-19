using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ToDoList
{
    [Serializable]
    public class Task
    {
        public string Title { get; set; }
        public DateTime DateTime { get; set; }

        public Task()
        {}

        public Task(string title, DateTime dateTime)
        {
            this.Title = title;
            this.DateTime = dateTime;
        }

        public void Serialize(string fileName, List<Task> tasks)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Task>));

            using (TextWriter writer = new StreamWriter(fileName))
            {
                xmlSerializer.Serialize(writer, tasks);
                writer.Close();
            }
        }

        public void Deserialize(string fileName, ref List<Task> tasks)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Task>));

            if (new FileInfo(fileName).Length > 0)
            {
                using (TextReader reader = new StreamReader(fileName))
                {
                    tasks = (List<Task>)xmlSerializer.Deserialize(reader);
                    reader.Close();
                }
            }
        }
    }
}