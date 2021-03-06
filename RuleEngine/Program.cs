﻿using System;
using RulesEngine.Model;

namespace RulesEngine
{
    class Program
    {
        static void Main(string[] args)
    {
            Registration register = new Registration();
            Payment payment = new Payment();
            payment.Item = "Product";
            Payment("Rules is broken");
            IRuleEngine<Registration> ruleEngine = RuleEngineFactory<Registration>.GetEngine();

            register.UserName = "";
            register.Password = "test123";
            register.Email = "";
            register.EmailConfirm = "test";

            var results = ruleEngine.Validate(register);

            foreach (var r in results)
            {
                if (r.IsBroken)
                {
                    Console.WriteLine("{0} rule is broken and the error is {1}", r.Name, r.ErrorMessage);
                }
            }

            Console.Read();
        }
    }
}
