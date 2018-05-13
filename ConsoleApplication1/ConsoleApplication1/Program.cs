using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] reqSkills = { "CodeIgniter", "CSS3", "Sinatra" };

            XmlTextReader reader = null;
            reader = new XmlTextReader("feed-test.xml");
            reader.WhitespaceHandling = WhitespaceHandling.None;

            String name = null;


           /* try
            {
                while (!reader.EOF)
                {
                    try
                    {
                        reader.Read();
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            if (reader.Name == "name")
                            {
                                reader.Read();
                                name = reader.Value;
                                //Console.WriteLine(name);
                            }

                            if (reader.Name == "skills")
                            {
                                reader.Read();
                                while (reader.Name == "skill")
                                {
                                    reader.Read();
                                    if (reqSkills.Contains(reader.Value))
                                    {
                                        if (name != null)
                                        {
                                            Console.WriteLine(name);
                                            name = null;
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    catch (XmlException exception)
                    {
           
                    }
                }
            } catch (FileLoadException)
            {
                Console.WriteLine("Данный файл не сущесвует");
            } finally
            {
                reader.Dispose();
            }*/
            try
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "name")
                        {
                            reader.Read();
                            name = reader.Value;
                            //Console.WriteLine(name);
                        }

                        if (reader.Name == "skills")
                        {
                            reader.Read();
                            while (reader.Name == "skill")
                            {
                                reader.Read();
                                if (reqSkills.Contains(reader.Value))
                                {
                                    Console.WriteLine(name);
                                    break;
                                }
                            }
                        }
                    }
                }
            } catch(FileNotFoundException exception)
            {
                Console.WriteLine("Данный файл не сущесвует");
            } catch(XmlException exception)
            {
                Console.WriteLine("Ошибка разбора XML-документа\n Неверная структура");
            }
            finally
            {
                reader.Dispose();
            }

            Console.ReadKey();
        }
        /* static void Main(string[] args)
         {
             Console.Write("Full path to xml file: ");
             //for example D:\directory\file.xml
             string filename = Console.ReadLine();

             int maleCount = 0, femaleCount = 0;

             XmlTextReader reader = new XmlTextReader(filename);

             Console.Write("Input city: ");
             string city = Console.ReadLine();
             while (reader.Read())
             {
                 if (reader.NodeType == XmlNodeType.Element)
                 {
                     if (reader.Name == "city")
                     {
                         reader.Read();
                         if (reader.Value == city)
                         {
                             while (reader.Name != "gender")
                             {
                                 reader.Read();
                             }
                             reader.Read();
                             if (reader.Value == "male")
                             {
                                 maleCount++;
                             }
                             else if (reader.Value == "female")
                             {
                                 femaleCount++;
                             }
                         }
                     }

                 }
             }
             Console.WriteLine("Males: " + maleCount);
             Console.WriteLine("Females: " + femaleCount);
             Console.ReadLine();
         }
     }*/
    }
}
