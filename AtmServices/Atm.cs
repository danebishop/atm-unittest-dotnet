﻿namespace AtmServices;

public class Atm
{
    public int balance; 

    //new atm class that accepts outside balance
    public Atm(int intialBalance){
        this.balance = intialBalance;
    }


    public bool withdraw(int amount){
        if (amount < balance){
            this.balance -= amount;
            return true;
        }
        return false; 

    }

    public bool deposit(int amount){
        if (amount < 0){
            return false;
        }
        balance += amount; 
        return true;

    }

    public int getBalance(){
        return balance;
    }


}
