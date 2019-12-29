using System;

namespace Bonus.Beyond.Elvis.Operator
{
    public class MaybeMonadDemo
    {
        /// <summary>
        /// +
        /// </summary>
        /// <param name="p"></param>
        public void MyMethod(Person p)
        {
//      string postcode;
//      if (p != null)
//      {
//        if (HasMedicalRecord(p) && p.Address != null)
//        {
//          CheckAddress(p.Address);
//          if (p.Address.PostCode != null)
//            postcode = p.Address.PostCode.ToString();
//          else
//            postcode = "UNKNOWN";
//        }
//      }
            string postcode = p.With(x => x.Address).With(x => x.PostCode);

            postcode = p
                .If(HasMedicalRecord)
                .With(x => x.Address)
                .Do(CheckAddress)
                .Return(x => x.PostCode, "UNKNOWN");
        }

        private void CheckAddress(Address pAddress)
        {
            throw new NotImplementedException();
        }

        private bool HasMedicalRecord(Person person)
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {

        }
    }
}