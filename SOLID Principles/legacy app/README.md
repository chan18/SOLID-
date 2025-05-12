
Legacy app requirements are mentioned in [SOLID-/README.md at main · chan18/SOLID-](https://github.com/chan18/SOLID-/blob/main/README.md) , I am adding essential classes that i will go through a refactoring from legacy code to SOLID principles. 


The project is focused on only refactoring from bad to good, is not compliable it is intended choice, This project acts as a reference for me self gong forward. 

what should we be looking for?

We want to get a sense of the structure of the code. Where does it live? 
What are its inputs? 
What calls it? 
What does it return? 

We want to figure out how the code fits into the larger application, w
hat other code calls it,
what parts of the code does it call and especially what are its tight coupling points? 

especially wary of static code and instances of the new keyword. 
Of course, we'll want to look for any code smells that jump out at us

There are sure to be some **violations of SOLID and related principles**, which we will point out. And any issues we find with the code **organization**, **complexity**, **maintainability** or **testability** will all be worth noting as well. 

