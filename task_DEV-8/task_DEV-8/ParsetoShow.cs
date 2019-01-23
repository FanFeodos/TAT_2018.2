using System.Xml.Linq;

namespace task_DEV_8
{
    class ParsetoShow
    {
        public void ParseXmlToAutoShow(string fileName, AutoCatalog autoCatalog)
        {
            XDocument doc = XDocument.Load(fileName);
            foreach (XElement el in doc.Root.Elements())
            {
                string brand=null, model=null;
                int count=0, price=0;
                foreach (XElement element in el.Elements())
                {
                    switch (element.Name.ToString())
                    {
                        case "brand":
                            brand = element.Value;
                            break;
                        case "model":
                            model = element.Value;
                            break;
                        case "count":
                            count = int.Parse(element.Value);
                            break;
                        case "price":
                            price = int.Parse(element.Value);
                            break;
                    }
                }
                Auto currentAuto = new Auto(brand, model, count, price);
                Add added=new Add(autoCatalog,currentAuto);
                added.Execute();
            }
        }
        
}
}
