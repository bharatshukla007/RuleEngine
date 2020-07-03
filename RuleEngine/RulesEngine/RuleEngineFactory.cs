using System.Configuration;
using InterfaceDemo.RulesEngine;

namespace RulesEngine
{
    public static class RuleEngineFactory<T> where T: class
    {
        public static IRuleEngine<T> GetEngine()
        {
            IRuleEngine<T> ruleEngine;

            string configurationString = ConfigurationManager.AppSettings["RuleEngineType"];

            if (configurationString.ToLower() == "xmlruleengine")
            {
                ruleEngine = new XMLRuleEngine<T>();
            }
            else
            {
                ruleEngine = new DefaultRuleEngine<T>();
            }

            return ruleEngine;

       
        }
    }
}
