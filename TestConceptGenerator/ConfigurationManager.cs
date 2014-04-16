using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Reflection;


namespace TestConceptGenerator
{
    public class ConfigurationManager : GenericConfigurationManager
    {
        // names for configuration file values
        public const string ConfigurationSubDir = "ConfigurationSubDir";
        public const string ConfigurationFilename = "ConfigurationFilename";

        public const string TestprocedureCategoriesDefinitionFilename = "TestprocedureCategoriesDefinitionFilename";

        public const string ExcelOverviewTemplateSubDir = "ExcelOverviewTemplateSubDir";
        public const string ExcelOverviewTemplateFilename = "ExcelOverviewTemplateFilename";
        public const string ExcelOverviewTemplateConfig = "ExcelOverviewTemplateConfig";

        public const string TestProcedureCatalogSubDir = "TestProcedureCatalogSubDir";
        public const string TestProcedureCatalogFilename = "TestProcedureCatalogFilename";


        // default values for configuration file values
        private const string ConfigurationSubDir_ = @"\configuration\";
        private const string ConfigurationFilename_ = @"config.xml";

        private const string TestprocedureCategoriesDefinitionFilename_ = @"testprocedure_categories_definitions.xml";
        
        private const string ExcelOverviewTemplateSubDir_ = @"\templates\TestingOverviewTemplate\";
        private const string ExcelOverviewTemplateFilename_ = @"testing_overview_v1.2_template.xltm";
        private const string ExcelOverviewTemplateConfig_ = @"testing_overview_v1.2_config.xml";

        private const string TestProcedureCatalogSubDir_ = @"\catalog\";
        private const string TestProcedureCatalogFilename_ = @"testprocedure_catalog.tpcatalog";


        private static ConfigurationManager instance_ = null;

        public static ConfigurationManager getInstance()
        {
            if(instance_ == null)
            {
                instance_ = new ConfigurationManager();
            }

            return instance_;
        }

        public ConfigurationManager() : base(getProgramDir() + ConfigurationSubDir_ + ConfigurationFilename_)
        {
        }

        
        protected override void generateDefaultConfig()
        {
            configurationSet = new Dictionary<string, ConfigurationValue>();

            configurationSet.Add(ConfigurationSubDir, new ConfigurationValue(ConfigurationSubDir_, "name of the subdirectory that contains all configuration files"));
            configurationSet.Add(ConfigurationFilename, new ConfigurationValue(ConfigurationFilename_, "file name of the XML file that holds the main configuration values"));
            
            configurationSet.Add(TestprocedureCategoriesDefinitionFilename, new ConfigurationValue(TestprocedureCategoriesDefinitionFilename_, "file name of the XML file that holds the definitions of testprocedure categories"));

            configurationSet.Add(ExcelOverviewTemplateSubDir, new ConfigurationValue(ExcelOverviewTemplateSubDir_, "name of the subdirectory that contains the Testing Overview template"));
            configurationSet.Add(ExcelOverviewTemplateFilename, new ConfigurationValue(ExcelOverviewTemplateFilename_, "file name of the Excel Template that is used as Testing Overview template"));
            configurationSet.Add(ExcelOverviewTemplateConfig, new ConfigurationValue(ExcelOverviewTemplateConfig_, "file name of the XML file that is holds information about the used Testing Overview template"));

            configurationSet.Add(TestProcedureCatalogSubDir, new ConfigurationValue(TestProcedureCatalogSubDir_, "name of the subdirectory that contains the Test Procedure catalog"));
            configurationSet.Add(TestProcedureCatalogFilename, new ConfigurationValue(TestProcedureCatalogFilename_, "file name of the Test Procedure catalog"));

        }
    }
}
