import random

computer_choice = random.choice(['rock', 'paper', 'scissors'])



user_choice = input("Choose rock, paper or scissors\n")

if user_choice == computer_choice:
    print("tis a draw m8")

elif user_choice == "scissors" and computer_choice == "paper":
    print("Damn you beat me")

elif user_choice == "paper" and computer_choice == "rock":
    print("Damn you're good at this")

elif user_choice == "rock" and computer_choice == "scissors":
    print("Damn you're good at this")

else :
    print("hahahaha i beat youuu")
