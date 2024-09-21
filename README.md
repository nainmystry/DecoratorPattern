**Coffee Machine Example - Decorator Pattern**
This repository demonstrates the Decorator Pattern using a coffee shop example. The goal is to showcase how you can enhance the functionality of coffee objects dynamically at runtime.

**Overview**
In this example, we define a base Coffee class and several decorators to add various ingredients (like milk, cream, etc.) without modifying the original class. This approach allows for flexible combinations of coffee types and toppings.

**Structure**
Coffee: The base component interface.
BasicCoffee: A concrete implementation of the Coffee interface.
CoffeeDecorator: An abstract decorator class implementing the Coffee interface.
MilkDecorator, CreamDecorator: Concrete decorators that add functionality.
