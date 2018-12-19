using System.Xml.Linq;

namespace SuperADD
{
    class Config
    {
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
            /*
            XElement root = XDocument.Load("SuperCAL.xml").Root;
            Wipe.EGatewayURL = root.Element("EGatewayURL").Value;
            Wipe.EGatewayHost = root.Element("EGatewayHostName").Value;
            DomainJoin.DomainName = root.Element("DomainJoinDomain").Value;
            DomainJoin.OU = root.Element("DomainJoinOU").Value;
            Misc.AutoLogonUserName = root.Element("AutoLogonUserName").Value;
            Misc.AutoLogonPassword = root.Element("AutoLogonPassword").Value;
            Misc.AutoLogonADDomain = root.Element("AutoLogonADDomain").Value;
            */
        }
    }
}