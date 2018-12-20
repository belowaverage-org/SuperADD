using System.Xml.Linq;

namespace SuperADD
{
    class Config
    {
        public static XElement Current = null;
        public static void GenerateConfig()
        {
            new XDocument(new XElement("SuperADD",
                new XElement("OrganizationalUnits",
                    new XElement("OrganizationalUnit",
                        new XElement("Name", "Domain Controllers"),
                        new XElement("DistinguishedName", "OU=Domain Controllers,DC=ad,DC=contoso,DC=com")
                    )
                ),
                new XElement("DescriptionItems",
                    new XElement("DescriptionItem",
                        new XElement("Name", "Department"),
                        new XElement("Type", "List"),
                        new XElement("ListItems",
                            new XElement("ListItem", "Accounting"),
                            new XElement("ListItem", "Finance"),
                            new XElement("ListItem", "Human Resources")
                        )
                    ),
                    new XElement("DescriptionItem",
                        new XElement("Name", "Person / Location"),
                        new XElement("Type", "Text")
                    )
                )
            )).Save("SuperADD.xml");
        }
        public static void ReadConfig()
        {
            Current = XDocument.Load("SuperADD.xml").Root;
        }
    }
}