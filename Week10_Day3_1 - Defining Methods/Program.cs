
using Week_10_Day_3;


BankAccount testAccount = new BankAccount();

testAccount.InitializeBankAccount("Jane Doe",12345678);

testAccount.DepositMoney(-10);
testAccount.DepositMoney(100);
_=testAccount.WithdrawMoney(50);
testAccount.WithdrawMoney(-100);
testAccount.WithdrawMoney(100);


Console.WriteLine(testAccount.GetInfo());
Console.ReadLine();