# Uninitialized Property Access in C#

This repository demonstrates a common coding error in C#: accessing a property before it's been initialized.  Uninitialized properties can lead to unexpected behavior or runtime exceptions. This example focuses on a simple case involving an integer property, but the issue extends to other data types and scenarios.

## The Bug

The `bug.cs` file contains code that attempts to access the `MyProperty` before a value is assigned. This can result in unexpected behavior, depending on the context.

## The Solution

The `bugSolution.cs` file provides a corrected version where the property is explicitly initialized before its value is used, eliminating the risk of unexpected results.