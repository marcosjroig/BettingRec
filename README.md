# Code Review Challenge

The solution contains a class name MarketManager and your task is to perform the code review for the same.

We are looking for approaches to improve this code and want you to come up with suggestions

Ideally we would like to see a pull request created with the suggested changes. 

If you face any issue with pull request, don't worry. You can do the changes locally and we can discuss in our next face to face meet.

Best of luck

## Code Review

At first look at the code, I can clearly see three paths:
 - Specific logic for Football
 - Specific logic for tennis
 - And an exception at the end
 
As the logic of football and tennis are similar it can be resolved with a parent class “Sport” and specialized classes Football and Tennis that inherits from Sport.
This way will avoid the If-Else-If and will avoid increasing the If-Else of this class.

I will also avoid the creation of objects inside of other objects and add dependency injection. In a .Net Core web solution, it is easy as this comes with an IoC container.

The object “markets” has low cohesion inside of the method as it is not used in all the code, the football path does not use it.

In addition, the object “markets” it is used in a “disconnected” mode from some part of the code, which make the code difficult to read, example:

•	It is declared at the top but used in the middle of the method. This is a bad practice for code readability.
•	It is also making the calculation for Tennis, then it comes an exception and then the final return. Here is also far from the peace of code that use this variable. Another bad practice for clean code and for readability. 

The for loop could be moved to another method to make it a single responsibility: this loop is filtering the result coming from the TennisMarketGenerator, and potentially it could have argument null exception, in addition it could be possible to create different types of filters in the future, so I will move this functionality to a specific class FilterService or similar name. 

