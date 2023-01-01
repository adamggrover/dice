You will be creating a program that will allow the user to roll a series of dice for any number of reasons, the only function for the system is to allow the user to select dice and roll them a number of times as their desire.

Task 1

First things first, lets create the basic software solution for rolling some dice. All you need to do is create a system that will allow the user to select the number of dice they wish to roll, and then output the result of rolling those dice. We are using standard 6-sided dices. Essentially, you will need to output a number of random numbers between 1 and 6.

Task 2

Once you have succeeded with task 1, we will now expand the system to incorporate additional types of
dice. You will therefore need some kind of menu system. The user should be able to roll the following
types:

- D3
- D4
- D6
- D8
- D10
- D12
- D20
- D100

Remember, they will also still need to input the number of those dice to be rolled. Ensure the user
is returned to the first menu when they are finished rolling dice.


Task 3

Now that we have a decent system set up, let’s try collect some data when rolling the dice. After each roll of the dice, the system should display all of the following data:

- Number of dice that rolled a 1
- Number of dice that rolled their highest value
- Total value of all rolled dice

Task 3.1

Give the user the option to display some or all of the information above – they may not want to see any
of it or only some parts of it.

Task 4

Now its time to really get fancy, give the user the option to re-roll dice rolls of 1! But they can only re-roll each dice once. Display in addition to the information in task 3 the following:
- Number of dice re-rolled

Task 4.1

Give the user the option to choose to re-roll 1s, or any result from 1 to a number of their choice. For
example they can re-roll any result from 1 to 3.

Task 5
The user should now have the option to set a “target” value their dice will need to roll to “succeed”. For example, they must roll a 4 or more. You will then display additional information:
- Number of successes

Task 5.1

The user may implement a rule that means whenever a dice rolls its maximum value it score an additional
success, for example for each d6 roll of a 6 they add 2 to their successes.Extension
If you would like to push this program even further, then you can consider including any of the following
functionality:
- Adding the ability to roll “successful” die rolls again, with the option of changing the second
success value AND giving the same options for re-rolling based on certain numbers (re-rolling 1s)
- Adding custom text responses: such as changing “total 6s rolled” to “total criticals rolled” for
example