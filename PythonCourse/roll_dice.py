import random 

roll = random.randint(1,6)

print("Computer rolled a " + str(roll))

guess = int(input('Guess the dice roll \n'))

if guess == roll:
    print('Correct')
else:
    print('Nah mate')