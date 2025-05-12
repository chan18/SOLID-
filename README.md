
The four pillars may define object orientation, They tell you what's possible, but not how to get there.

# SOLID Princples

SRP
OCP
LSP
ISP
DIP

## Single Responsibility Principle - SRP

A class should have one, and only one, reason to change. There should never be more than one reason for a class to change

**Definition**
Every module should have a clearly‑defined job

**Scopes of Responsibility**
principle can apply at multiple different levels.

### SRP Design

- identify "responsibilites" and "jobs"

- watch out for "reasons to change"

- Favor multiple small classes over fewr, more complex ones.

Examine your classes looking for individual responsibilities or jobs. In the original terms, you'd be *looking for reasons to change*. Each time you find one of these, <ins>it's potentially another class that you could extract</ins>. 


## Open Close Principle

## Liskov-Substitution Principle

## Interface Segregation Principle

## Dependency Inversion Principle

# Refactoring to SOLID

leverage principles like **SOLID**, as we look for ways in which the code could be improved, and <ins>identify some code smells for future attention</ins>. Then, we'll take what we've learned and develop a plan

> refactoring complex legacy code that's mission‑critical to the business planning is an important part of the process.

identify low‑hanging fruit, things that we can do with minimal risk and/or effort that will yield the biggest gains in code quality and maintainability.

## Domain

Home Remodeling

The main function we're going to be looking at is called `CalculateTotalPrice`.

## Requirements

When determining the price for a given part of a kitchen remodel, the software breaks down the project into individual **walls**. Within a given wall, there will be one or more **cabinets**. 

We'll also have to deal with *things on the wall* where there are no cabinets. Then, within a **cabinet**, there may be *some number of features*. 

**Features** is just a generic term for things like **doors**, **shelves**, **handles**, **knobs**, etc. As you can probably guess, there are some exceptions to this **taxonomy**. 


The `CalculateTotalPrice` method can also be run in one of three different modes based on a parameter that is passed into it. 

- It can show a real‑time quote on the kitchen builder web application. This is the default behavior and is used to reprice a kitchen remodel every time changes are made.
- It can also be used to place an order for the current configuration. Once the customer has agreed to move forward, this is the functionality that creates the order. Finally, 
- it can generate a text report, summarizing the details of the configuration and its components. This may include specific information about customization in addition to serving as a parts list for the contractor. 
- In addition to the parts and quantities, it also contains information about pricing and measurements.



