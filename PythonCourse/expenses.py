expenses = []

meow = 0 
total = 0

for x in expenses:
    meow = meow + x

num_expenses = int(input("Enter number of expenses please mate\n"))

for i in range(num_expenses):
    expenses.append(float(input("Enter expense ")))

total = sum(expenses)

print('you spent £', total, sep = '')

