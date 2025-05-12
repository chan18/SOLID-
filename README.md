
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

