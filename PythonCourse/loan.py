#Get details of loan

money_owed = float(input('How much money do you owe in £?\n'))
apr = float(input('What is annual interest rate of loan in %?\n'))
payment = float(input('How much can you afford to pay back a month?\n'))
months = int(input('How many months do you want to pay it off by? \n'))

monthly_rate = apr/100/12 

for i in range(months):
    interest_paid = money_owed * monthly_rate

    money_owed = money_owed + interest_paid

    if (money_owed - payment < 0):
        print('The last payment is, money_owed')
        print('You have paid off the loan in', i+1, 'months')
        break
    
    
    money_owed = money_owed - payment

    print('Paid', payment, 'of which', interest_paid, 'was interest')

    print('Now I owe', money_owed)