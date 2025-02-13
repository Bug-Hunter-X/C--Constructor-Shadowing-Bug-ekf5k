# C# Constructor Shadowing Bug

This repository demonstrates a subtle but common bug in C# constructors where a local variable accidentally shadows a class member variable. This leads to the member variable not being initialized correctly.

## Bug Description
The `ExampleClass` constructor has a parameter named `value`. Because there is also a class member variable named `MyProperty`, the constructor assigns the `value` to a new local variable, instead of the class member variable `MyProperty`.  This can lead to unexpected behavior in the class, because `MyProperty` retains its default value (0 for integers).