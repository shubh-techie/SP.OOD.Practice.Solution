using System;
using System.Collections.Generic;
using System.Text;

namespace DesignLibraryManagementSystem
{
    public abstract class Account
    {
        private string Id;
        private string Password;
        private AccountStatus Status;
        private Person person;

        public abstract bool ResetPassword();
    }

    public class Librarian : Account
    {
        public override bool ResetPassword()
        {
            throw new NotImplementedException();
        }

        public bool BlockMember(Member member)
        {
            return true;
        }

        public bool UnBlockMember(Member member)
        {
            return true;
        }
    }

    public class Member : Account
    {
        public int DateOfMembership { get; set; }
        public int TotalCheckOutBook { get; set; }

        public override bool ResetPassword()
        {
            return true;
        }

        public bool CheckoutBookItem(BookItem bookItem)
        {
            return true;
        }

        private void CeckForFine(String bookItemBarcode)
        {
            return;
        }
        public void ReturnBookItem(BookItem bookItem)
        {
        }

        public bool RenewBookItem(BookItem bookItem)
        {
            return true;
        }
    }
}
