using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount{
    class Account{
        public string name;
        int accountNum;
        public double balance = 0;
        double interest = 0;

        public Account(string accountName,double firstDeposit){
            name = accountName;
            balance += firstDeposit;
        }

        public void setIntRate(double per){
            interest = per;
        }

        public double getBal(){
            return balance;
        }

        public string getName(){
            return this.name;
        }

        public void deposit(double addAmt){
            balance += addAmt;
        }

        public bool withdraw(double outAmt){
            bool chk = true;

            if(outAmt <= balance){
                balance -= outAmt;
            } else if(outAmt > balance){
                chk = false;
            }

            return chk;
        }

        public double getBalAfter(int mos){
            double prin = balance;
            double intFeed;

            for(int g=1;g<=mos;g++){
                intFeed = prin * interest;
                prin += intFeed;
            }

            return prin;
        }
    }
}