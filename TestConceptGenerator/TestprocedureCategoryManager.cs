using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Xml;

namespace TestConceptGenerator
{
    public class TestprocedureCategoryDefinition
    {
        public int ID;

        public string name;
        public int number;

        public List<TestprocedureCategoryDefinition> subcategories;

        public TestprocedureCategoryDefinition parent;

        public TestprocedureCategoryDefinition()
        {
            ID = -1;

            name = "";
            number = -1;

            parent = null;

            subcategories = new List<TestprocedureCategoryDefinition>();
        }

        public TestprocedureCategoryDefinition(string name, int number, TestprocedureCategoryDefinition parent = null)
        {
            ID = -1;

            this.name = String.Copy(name);
            this.number = number;

            this.parent = parent;

            subcategories = new List<TestprocedureCategoryDefinition>();
        }
    }

    public class TestprocedureCategoryManager
    {
        public List<TestprocedureCategoryDefinition> mainCategories;

        static private TestprocedureCategoryManager instance = null;

        public TestprocedureCategoryManager()
        {
            ConfigurationManager confMan = ConfigurationManager.getInstance();

            string xmlDefinitionsPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + confMan.getConfigurationValue(ConfigurationManager.ConfigurationSubDir) + confMan.getConfigurationValue(ConfigurationManager.TestprocedureCategoriesDefinitionFilename);

            if(File.Exists(xmlDefinitionsPath))
            {
                initFromXML(xmlDefinitionsPath);
            }
            else
            {
                initWithDefaults();

                writeToXML(xmlDefinitionsPath);
            }
        }

        public void initWithDefaults()
        {
            mainCategories = new List<TestprocedureCategoryDefinition>();
            List<TestprocedureCategoryDefinition> subCategories;
            TestprocedureCategoryDefinition mainCategory;


            // fill "Electrical" category -----------------------------------------------------------------------------
            mainCategories.Add(new TestprocedureCategoryDefinition("Electrical", 1));

            mainCategory = mainCategories[mainCategories.Count - 1];

            subCategories = new List<TestprocedureCategoryDefinition>();
            subCategories.Add(new TestprocedureCategoryDefinition("Run-up Tests", 1, mainCategory));
            subCategories.Add(new TestprocedureCategoryDefinition("General Tests", 2, mainCategory));
            subCategories.Add(new TestprocedureCategoryDefinition("HF Interface", 3, mainCategory));
            subCategories.Add(new TestprocedureCategoryDefinition("Battery Tests", 4, mainCategory));
            subCategories.Add(new TestprocedureCategoryDefinition("Destructive Tests", 5, mainCategory));
            subCategories.Add(new TestprocedureCategoryDefinition("Climate Tests", 6, mainCategory));
            subCategories.Add(new TestprocedureCategoryDefinition("Replaced Procedures", 7, mainCategory));

            mainCategory.subcategories.AddRange(subCategories);


            // fill "Electrical Functional" category ------------------------------------------------------------------
            mainCategories.Add(new TestprocedureCategoryDefinition("Electrical Functional", 2));

            mainCategory = mainCategories[mainCategories.Count - 1];

            subCategories = new List<TestprocedureCategoryDefinition>();
            subCategories.Add(new TestprocedureCategoryDefinition("Electrical Functional", 1, mainCategory));

            mainCategory.subcategories.AddRange(subCategories);


            // fill "Functional" category -----------------------------------------------------------------------------
            mainCategories.Add(new TestprocedureCategoryDefinition("Functional", 3));

            mainCategory = mainCategories[mainCategories.Count - 1];

            subCategories = new List<TestprocedureCategoryDefinition>();
            subCategories.Add(new TestprocedureCategoryDefinition("Functional", 1, mainCategory));

            mainCategory.subcategories.AddRange(subCategories);


            // fill "Lifetime Estimation" category --------------------------------------------------------------------
            mainCategories.Add(new TestprocedureCategoryDefinition("Lifetime Estimation", 4));

            mainCategory = mainCategories[mainCategories.Count - 1];

            subCategories = new List<TestprocedureCategoryDefinition>();
            subCategories.Add(new TestprocedureCategoryDefinition("Lifetime Estimation", 1, mainCategory));

            mainCategory.subcategories.AddRange(subCategories);


            // fill "Environmental" category --------------------------------------------------------------------------
            mainCategories.Add(new TestprocedureCategoryDefinition("Environmental", 5));

            mainCategory = mainCategories[mainCategories.Count - 1];

            subCategories = new List<TestprocedureCategoryDefinition>();
            subCategories.Add(new TestprocedureCategoryDefinition("Operation", 1, mainCategory));
            subCategories.Add(new TestprocedureCategoryDefinition("Storage", 2, mainCategory));

            mainCategory.subcategories.AddRange(subCategories);


            // fill "EMC" category ------------------------------------------------------------------------------------
            mainCategories.Add(new TestprocedureCategoryDefinition("EMC", 6));

            mainCategory = mainCategories[mainCategories.Count - 1];

            subCategories = new List<TestprocedureCategoryDefinition>();
            subCategories.Add(new TestprocedureCategoryDefinition("EMC", 1, mainCategory));
            subCategories.Add(new TestprocedureCategoryDefinition("R&TTE", 2, mainCategory));
            subCategories.Add(new TestprocedureCategoryDefinition("ESD", 3, mainCategory));

            mainCategory.subcategories.AddRange(subCategories);


            // fill "Risk Analysis" category --------------------------------------------------------------------------
            mainCategories.Add(new TestprocedureCategoryDefinition("Risk Analysis", 7));

            mainCategory = mainCategories[mainCategories.Count - 1];

            subCategories = new List<TestprocedureCategoryDefinition>();
            subCategories.Add(new TestprocedureCategoryDefinition("Risk Analysis", 1, mainCategory));

            mainCategory.subcategories.AddRange(subCategories);


            // fill "Certification" category --------------------------------------------------------------------------
            mainCategories.Add(new TestprocedureCategoryDefinition("Certification", 8));

            mainCategory = mainCategories[mainCategories.Count - 1];

            subCategories = new List<TestprocedureCategoryDefinition>();
            subCategories.Add(new TestprocedureCategoryDefinition("UL", 1, mainCategory));
            subCategories.Add(new TestprocedureCategoryDefinition("FCC", 2, mainCategory));
            subCategories.Add(new TestprocedureCategoryDefinition("TÜV", 3, mainCategory));
            subCategories.Add(new TestprocedureCategoryDefinition("CE General", 4, mainCategory));

            mainCategory.subcategories.AddRange(subCategories);


            // fill "Aging" category -----------------------------------------------------------------------------
            mainCategories.Add(new TestprocedureCategoryDefinition("Aging", 9));

            mainCategory = mainCategories[mainCategories.Count - 1];

            subCategories = new List<TestprocedureCategoryDefinition>();
            subCategories.Add(new TestprocedureCategoryDefinition("Aging", 1, mainCategory));

            mainCategory.subcategories.AddRange(subCategories);


            // fill "Mechanical" category -----------------------------------------------------------------------------
            mainCategories.Add(new TestprocedureCategoryDefinition("Mechanical", 10));

            mainCategory = mainCategories[mainCategories.Count - 1];

            subCategories = new List<TestprocedureCategoryDefinition>();
            subCategories.Add(new TestprocedureCategoryDefinition("Mechanical", 1, mainCategory));

            mainCategory.subcategories.AddRange(subCategories);


            // fill "Quality Assurance" category ----------------------------------------------------------------------
            mainCategories.Add(new TestprocedureCategoryDefinition("Quality Assurance", 11));

            mainCategory = mainCategories[mainCategories.Count - 1];

            subCategories = new List<TestprocedureCategoryDefinition>();
            subCategories.Add(new TestprocedureCategoryDefinition("Quality Assurance", 1, mainCategory));

            mainCategory.subcategories.AddRange(subCategories);


            // fill "Misc" category ----------------------------------------------------------------------
            mainCategories.Add(new TestprocedureCategoryDefinition("Misc", 12));

            mainCategory = mainCategories[mainCategories.Count - 1];

            subCategories = new List<TestprocedureCategoryDefinition>();
            subCategories.Add(new TestprocedureCategoryDefinition("Misc", 1, mainCategory));

            mainCategory.subcategories.AddRange(subCategories);
        }


        public void initFromXML(string path)
        {
            if(!File.Exists(path))
            {
                throw new Exception("TestprocedureCategoryManager: initFromXML(): could not open XML file '" + path + "'!");
            }

            if(mainCategories == null)
            {
                mainCategories = new List<TestprocedureCategoryDefinition>();
            }
            else
            {
                mainCategories.Clear();
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            if(doc == null)
            {
                throw new Exception("TestprocedureCategoryManager: initFromXML(): could not read XML file '" + path + "'!");
            }

            XmlNode xmlCategoryTree = doc.SelectSingleNode("/categoryTree");

            if(xmlCategoryTree == null)
            {
                throw new Exception("TestprocedureCategoryManager: initFromXML(): could not find category tree in XML file!");
            }

            XmlNodeList xmlMainCategories = xmlCategoryTree.SelectNodes("mainCategory");

            foreach(XmlNode xmlMainCategory in xmlMainCategories)
            {
                TestprocedureCategoryDefinition mainCategory = categoryFromXML(xmlMainCategory);
                mainCategory.parent = null;
                //mainCategory.subcategories = new List<TestprocedureCategoryDefinition>();

                mainCategories.Add(mainCategory);

                readSubcategoriesFromXMLTree(doc, xmlMainCategory, mainCategory);
            }
        }


        private void readSubcategoriesFromXMLTree(XmlDocument doc, XmlNode parentNode, TestprocedureCategoryDefinition parentCategory)
        {
            XmlNodeList xmlCategories = parentNode.SelectNodes("category");

            foreach(XmlNode xmlCategory in xmlCategories)
            {
                TestprocedureCategoryDefinition category = categoryFromXML(xmlCategory);
                category.parent = parentCategory;
                //category.subcategories = new List<TestprocedureCategoryDefinition>();

                parentCategory.subcategories.Add(category);

                readSubcategoriesFromXMLTree(doc, xmlCategory, category);
            }
        }


        public TestprocedureCategoryDefinition categoryFromXML(XmlNode xmlCategory)
        {
            TestprocedureCategoryDefinition category = new TestprocedureCategoryDefinition();

            category.ID = int.Parse(xmlCategory.Attributes.GetNamedItem("ID").Value);
            category.name = String.Copy(xmlCategory.Attributes.GetNamedItem("name").Value);
            category.number = int.Parse(xmlCategory.Attributes.GetNamedItem("number").Value);

            return category;
        }

        
        public void writeToXML(string path)
        {
            XmlDocument doc = new XmlDocument();

            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);

            XmlNode categoryTree = doc.CreateElement("categoryTree");
            doc.AppendChild(categoryTree);

            foreach(TestprocedureCategoryDefinition mainCategory in mainCategories)
            {
                XmlNode xmlMainCategory = xmlFromMainCategory(doc, mainCategory);

                categoryTree.AppendChild(xmlMainCategory);

                addSubcategoriesToXMLTree(doc, xmlMainCategory, mainCategory);
            }

            if(!Directory.Exists(Path.GetDirectoryName(path)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }

            doc.Save(path);
        }

        private void addSubcategoriesToXMLTree(XmlDocument doc, XmlNode parentNode, TestprocedureCategoryDefinition category)
        {
            if(category == null)
                return;

            foreach(TestprocedureCategoryDefinition subcategory in category.subcategories)
            {
                XmlNode xmlCategory = xmlFromCategory(doc, subcategory);

                parentNode.AppendChild(xmlCategory);

                addSubcategoriesToXMLTree(doc, xmlCategory, subcategory);
            }
        }

        public XmlNode xmlFromMainCategory(XmlDocument doc, TestprocedureCategoryDefinition category)
        {
            XmlNode xmlMainCategory = doc.CreateElement("mainCategory");
            XmlAttribute attributeID = doc.CreateAttribute("ID");
            XmlAttribute attributeName = doc.CreateAttribute("name");
            XmlAttribute attributeNumber = doc.CreateAttribute("number");

            attributeID.Value = category.ID.ToString();
            attributeName.Value = category.name;
            attributeNumber.Value = category.number.ToString();

            xmlMainCategory.Attributes.Append(attributeID);
            xmlMainCategory.Attributes.Append(attributeName);
            xmlMainCategory.Attributes.Append(attributeNumber);

            return xmlMainCategory;
        }

        public XmlNode xmlFromCategory(XmlDocument doc, TestprocedureCategoryDefinition category)
        {
            XmlNode xmlCategory = doc.CreateElement("category");
            XmlAttribute attributeID = doc.CreateAttribute("ID");
            XmlAttribute attributeName = doc.CreateAttribute("name");
            XmlAttribute attributeNumber = doc.CreateAttribute("number");

            attributeID.Value = category.ID.ToString();
            attributeName.Value = category.name;
            attributeNumber.Value = category.number.ToString();

            xmlCategory.Attributes.Append(attributeID);
            xmlCategory.Attributes.Append(attributeName);
            xmlCategory.Attributes.Append(attributeNumber);

            return xmlCategory;
        }


        public static TestprocedureCategoryManager getInstance()
        {
            if(instance == null)
                instance = new TestprocedureCategoryManager();

            return instance;
        }

        private TestprocedureCategoryDefinition getByName(string name, List<TestprocedureCategoryDefinition> collection)
        {
            foreach(TestprocedureCategoryDefinition tpDef in collection)
            {
                if(tpDef.name.Equals(name))
                    return tpDef;
            }

            return null;
        }

        private TestprocedureCategoryDefinition getByNumber(int number, List<TestprocedureCategoryDefinition> collection)
        {
            foreach(TestprocedureCategoryDefinition tpDef in collection)
            {
                if(tpDef.number == number)
                    return tpDef;
            }

            return null;
        }

        public TestprocedureCategoryDefinition getMainCategory(int i)
        {
            return mainCategories[i];
        }

        public TestprocedureCategoryDefinition getSubCategory(int iMain, int iSub)
        {
            return mainCategories[iMain].subcategories[iSub];
        }

        public TestprocedureCategoryDefinition getMainCategoryByName(string name)
        {
            return getByName(name, mainCategories);
        }

        public TestprocedureCategoryDefinition getMainCategoryByNumber(int number)
        {
            return getByNumber(number, mainCategories);
        }

        public TestprocedureCategoryDefinition getSubCategoryByName(string mainName, string subName)
        {
            TestprocedureCategoryDefinition mainCat = getByName(mainName, mainCategories);

            return getByName(subName, mainCat.subcategories);
        }

        public TestprocedureCategoryDefinition getSubCategoryByNumber(int mainNumber, int subNumber)
        {
            TestprocedureCategoryDefinition mainCat = getByNumber(mainNumber, mainCategories);

            return getByNumber(subNumber, mainCat.subcategories);
        }

        public int getIndexOfMainCategoryByName(string name)
        {
            TestprocedureCategoryDefinition tpDef = getMainCategoryByName(name);

            return mainCategories.IndexOf(tpDef);
        }

        public int getIndexOfSubCategoryByName(string mainName, string subName)
        {
            TestprocedureCategoryDefinition tpDef = getSubCategoryByName(mainName, subName);

            return tpDef.parent.subcategories.IndexOf(tpDef);
        }

        public int getNrOfMainCategories()
        {
            return mainCategories.Count;
        }

        public int getNrOfSubCategories(TestprocedureCategoryDefinition category)
        {
            return category.subcategories.Count;
        }
    }
}
