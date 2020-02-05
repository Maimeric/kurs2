using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
namespace ATM
{
    class IOF
    {
        public static void OutputXmlFile(List<StructCard> listStruct)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<StructCard>));
            using (FileStream fs = new FileStream("Card.xml", FileMode.OpenOrCreate))
            {
                // сериализация (сохранение объекта в поток) 
                xmlSerializer.Serialize(fs, listStruct);
                fs.Close();
            }
        }
        public static int InputXmlFile(int numb, string nameFile, List<StructCard> listStrut)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(StructCard[]));
            using (FileStream fs = new FileStream(nameFile, FileMode.OpenOrCreate))
            {
                StructCard[] newCard = (StructCard[])formatter.Deserialize(fs);
                foreach (StructCard p in newCard)
                {
                    StructCard obj = new StructCard(p.numbcard, p.pasword, p.balance);
                    listStrut.Add(obj);
                    numb++;
                }
            }
            return numb;
        }
    }
}
