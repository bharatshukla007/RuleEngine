using RulesEngine.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.Model
{
    [RuleEngineType(RuleType = typeof(DefaultRuleEngine<Registration>))]
    class Payment
    {
        [RequiredField("Item", "Item cannot be empty")]
        [MaxLenField("Item", "Max 15 chars", 15)]
        public string Item { get; set; }
    }
}
