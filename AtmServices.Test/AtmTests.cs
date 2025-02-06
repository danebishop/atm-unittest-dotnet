namespace AtmServices.Test;

//need using statement so it know what we are using to test
using AtmServices; 

public class AtmTests
{
    //Here is the set up for our test ATM
    Atm testAtm; 
    int intialBalance = 100;


    public AtmTests(){
        testAtm = new Atm(intialBalance);
    }

    //this is the end of set up for the test cases



    //this is first test, need fact at start of each test 
    //this is a test of success
    [Fact]
    public void Test_Withdraw()
    {
        //we are testing withdraw and checking it with assert statment
        var result = testAtm.withdraw(25);
        Assert.True(result);

        //checking to see if balance got updated 
        Assert.Equal(75, testAtm.getBalance());

    }

    //this is second test, need fact at start of each test 
    //this is a test of failure
    [Fact]
    public void Test_Withdraw_Failure()
    {
        //we are testing withdraw and checking it with assert statment
        var result = testAtm.withdraw(125);
        Assert.False(result);

        //checking to see if balance got updated 
        Assert.Equal(100, testAtm.getBalance());

    }


    //last test for sanity 
    //this is a test of success
    [Fact]
    public void Test_Withdraw_And_Deposit()
    {
        //we are testing withdraw and checking it with assert statment
        var result = testAtm.withdraw(25);
        Assert.True(result);
        //checking to see if balance got updated 
        Assert.Equal(75, testAtm.getBalance());


        var resultOfDeposit = testAtm.deposit(25);
        Assert.True(resultOfDeposit);
        //checking to see if balance got updated 
        Assert.Equal(100, testAtm.getBalance());

    }



}