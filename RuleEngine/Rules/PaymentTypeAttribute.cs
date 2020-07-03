using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.Rules
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class PaymentTypeAttribute : Attribute
    {
        public Type PaymentType { get; set; }
        public PaymentTypeAttribute() : base()
        {
        }
        public PaymentTypeAttribute(string ItemType)
        {
            if (ItemType == "Physical Product")
            {
                GeneratePackingSlip();
            }
            else if(ItemType == "book")
            {
                GenerateDuplicatePaymentSlip();
            }
            else if (ItemType == "MemberShip")
            {
                ActivateMemberShip();
            }
            else if (ItemType == "Upgrade")
            {
                Upgrade();
            }
            else if (ItemType == "Learning to ski")
            {
                Packaging();
            }
        }

        private void Packaging()
        {
            throw new NotImplementedException();
        }

        private void Upgrade()
        {
            throw new NotImplementedException();
        }

        private void GenerateDuplicatePaymentSlip()
        {
            throw new NotImplementedException();
        }

        private void ActivateMemberShip()
        {
            throw new NotImplementedException();
        }

        private void GeneratePackingSlip()
        {
            throw new NotImplementedException();
        }
    }
}
