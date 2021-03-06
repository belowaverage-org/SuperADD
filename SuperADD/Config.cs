﻿using System.Xml.Linq;

namespace SuperADD
{
    class Config
    {
        public static XElement Current = null;
        public static void GenerateConfig()
        {
            new XDocument(new XElement("SuperADD",
                new XComment("The hostname of the domain for authentication."),
                new XElement("DomainName", "ad.contoso.com"),
                new XComment("The hostname of the domain controller to connect to."),
                new XElement("DomainController", "condc1.ad.contoso.com"),
                new XComment("The search base for name generation / unique verification."),
                new XElement("BaseDN", "DC=ad,DC=contoso,DC=com"),
                new XElement("OrganizationalUnits",
                    new XElement("OrganizationalUnit",
                        new XComment("The description of this OU that will appear in the UI."),
                        new XElement("Name", "Computers"),
                        new XComment("The OU DN where computer objects will be placed."),
                        new XElement("DistinguishedName", "CN=Computers,DC=ad,DC=contoso,DC=com"),
                        new XComment("Auto Name Generating Patterns:"),
                        new XComment("#: Increment with a lefthand padding (Append Mode). E.g: #### = 0001"),
                        new XComment("+: Increment with a lefthand padding (Fill Mode). E.g: ++++ = 0001"),
                        new XComment("*: Random Alpha Numeric Lowercase. E.g: **** = j3g2"),
                        new XComment("$: Random Alpha Numeric Uppercase. E.g: $$$$ = J3G2"),
                        new XComment("@: Random Alpha Numeric Both Case. E.g: @@@@ = J3g2"),
                        new XComment("%: Random Numeric. E.g: %%%% = 5473"),
                        new XComment("!: Random Alpha Lowecase. E.g: !!!! = jwkx"),
                        new XComment("?: Random Alpha Uppercase. E.g: ???? = JWKX"),
                        new XComment("~: Random Alpha Both Case. E.g: ~~~~ = JwKx"),
                        new XElement("AutoName", "CONTOSOPC####"),
                        new XComment("The security groups that will be auto applied. (the DNs must exist below in 'SecurityGroups')"),
                        new XElement("SecurityGroupsDNs",
                            new XElement("SecurityGroupDN", "CN=COMP_Wifi,OU=Groups,OU=Computers,DC=ad,DC=contoso,DC=com")
                        )
                    )
                ),
                new XElement("SecurityGroups",
                    new XElement("SecurityGroup",
                        new XComment("The description of this Security Group that will appear in the UI."),
                        new XElement("Name", "Computer Wifi Access"),
                        new XComment("The distinguished name of the security group."),
                        new XElement("DistinguishedName", "CN=COMP_Wifi,OU=Groups,OU=Computers,DC=ad,DC=contoso,DC=com")
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