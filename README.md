# OOPS Concepts in C#

This repo is for demonstrating OOPS concepts in C# programming. I will update it with more examples.

You can :star: it, would be useful when brushing up OOP basics.

### Contents
<ol>
<li>Try Catch Finally blocks</li>
<li>Interface, Classes Inheritance scenario</li>
<li>Polymorphism</li>
<li>Static Members</li>
<li>Abstract Classes/Methods</li>
<li>Interfaces</li>
</ol>

#### Compile-Time Polymorphism
Polymorphism means same method name used in but different forms. It is also known as method overloading, early binding.
It works on:
1. Number of parameters
2. Data type of parameters
3. Return Type of the method is never comsidered for polymorphism.

``` csharp
int sum (int a, int b);
string sum (int a, int b);

var x = sum(2,5); // this will result in error as compile wil not be sure which method to call.
```
