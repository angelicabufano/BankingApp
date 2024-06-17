using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp;
public class Account {
    public int AccountId { get; set; } = 0;
    public string Description { get; set; } = string.Empty;
    public decimal Balance { get; set; } = 0;

    public bool Deposit(decimal Amount) {
        if(Amount <= 0) { 
            Console.WriteLine("Amount cannot be zero or negative!");
        return false;
        }
        Balance += Amount;
        return true;
    }
    public bool Withdraw(decimal Amount) {
        if(Amount <= 0) {
            Console.WriteLine("Amount cannot be zero or negative!");
            return false;
        } 
        if(Amount > Balance) {
            Console.WriteLine("Insufficient Funds!");
            return false;
        }
        Balance -= Amount;
        return true;
    }
    public bool Transfer(decimal Amount, Account account) {
        var success = this.Withdraw(Amount);                    // don't NEED to put "this."
        if (success == true) {
            account.Deposit(Amount);
        }
        return true;        
    }
}
