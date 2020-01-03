using System.ComponentModel.DataAnnotations.Schema;
using Altan.Core.Common;
using Altan.Core.Organizations;
using Altan.Core.Users;

namespace Altan.Core.Transactions
{
    public class Transaction : FullAuditedEntity
    {
        private int _amount;

        private Transaction()
        {
        }

        public Transaction(int amount)
        {
            _amount = amount * 100;
        }

        public decimal Amount
        {
            get => (decimal) _amount / 100;
            private set { _amount = (int) (value * 100); }
        }

        public TransactionType Type { get; set; }
    }
}