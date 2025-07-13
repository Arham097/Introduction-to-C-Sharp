# C# Programming Concepts - Comprehensive Learning Repository

This repository contains comprehensive examples and demonstrations of core C# programming concepts organized into separate projects. Each folder represents a specific topic with practical code examples.

## 📁 Repository Structure

### 🔤 **Basic Fundamentals**

- **DataTypes** - Basic data types (int, string, bool, double, float, char, var)
- **Operators** - Conditional operators and their usage
  - **Null Coalescing (`??`)** - Null checking and default value assignment
  - **Null Conditional (`?.`)** - Safe navigation operator
  - **Ternary Conditional (`?:`)** - Inline conditional expressions
- **Conditional** - If/else statements and switch cases
- **Loops** - While, do-while, for, foreach, and nested loops

### 🔧 **Functions & Methods**

- **Functions** - Method declaration, recursion, factorial calculation
  - Function calls and return values
  - Recursion examples (number generation, factorial)
  - `params` keyword for variable parameters
  - Optional parameters with default values
  - Function extensions for existing types

### 🏗️ **Object-Oriented Programming**

- **Class** - Class basics, constructors, inheritance, polymorphism
  - Static keyword and static classes
  - Inheritance with virtual/override methods
  - Abstract classes and methods
  - Static constructors for initialization
- **Properties** - Getters, setters, and property validation
- **Class Indexer** - Custom indexing for classes (array-like access)

### 📊 **Data Structures & Collections**

- **Arrays & Lists** - Basic array operations and List<T> methods
- **Multi-Dimensional Arrays** - 2D arrays and jagged arrays
- **Dictionary** - Key-value pair collections with enums
- **Other Collections** - Stack, Queue, HashSet, SortedSet, SortedList, Structs

### 🔀 **Advanced Type System**

- **Value vs Reference Types** - Memory allocation differences between value types (int, struct) and reference types (class, objects)
- **Nullable** - Nullable value types and null handling
- **Generics** - Generic classes and methods with type constraints
- **Enums** - Enumeration types for better code readability
- **Tuples** - Multiple return values and tuple manipulation
- **Records** - Immutable data types with built-in equality
- **Anonymous Types** - Dynamic object creation with non-destructive mutation

### 🔄 **Advanced Programming Concepts**

- **Interfaces** - Contract definition and multiple interface implementation
  - Type checking with `is` keyword
  - Type conversion with `as` keyword and casting
  - Switch type matching with pattern matching
- **Delegates** - Function pointers, Action, Func delegates
  - Multicast delegates (storing multiple methods)
  - Built-in delegate types (Action<T>, Func<T>)
- **Events** - Event-driven programming patterns
- **LINQ** - Language Integrated Query for data manipulation
  - Method syntax and query syntax
  - Filtering collections with Where clause

### 🔧 **Memory Management & Performance**

- **Data Boxing** - Value type to reference type conversion
- **Span** - Memory-efficient collection operations without allocation
- **ref, out, in Keywords** - Reference parameter passing
  - `out` - Multiple return values from methods
  - `ref` - Pass by reference for modification
  - `in` - Read-only reference for performance

### ⚡ **Concurrency & Asynchronous Programming**

- **Multithreading** - Thread creation, synchronization, and race conditions
  - Lock mechanisms for thread safety
  - Deadlock examples and prevention
  - Thread joining and coordination
- **Asynchronous Programming** - async/await patterns
  - Task-based asynchronous programming
  - Parallel task execution with Task.WhenAll
  - Non-blocking operations

### 🔍 **Reflection & Metadata**

- **Reflection** - Runtime type inspection and dynamic method invocation
  - Type information retrieval
  - Property and method enumeration
  - Dynamic object creation with Activator
  - Nested type discovery with BindingFlags

### 🛠️ **Language Features**

- **Constants & Readonly** - Compile-time vs runtime constants
- **Namespaces** - Code organization and namespace aliasing
- **Local Functions vs Lambda** - Function scope and lambda expressions
- **Exceptions** - Error handling and exception management
- **Preprocessor Directive** - Conditional compilation

## 🎯 **Key Learning Outcomes**

### **Core Programming Concepts**

- **Object-Oriented Design**: Classes, inheritance, polymorphism, encapsulation
- **Type System**: Value vs reference types, nullable types, generics
- **Memory Management**: Boxing/unboxing, span for efficient memory usage
- **Functional Programming**: Delegates, lambda expressions, LINQ

### **Advanced Features**

- **Concurrency**: Multithreading, async/await, task coordination
- **Reflection**: Runtime type inspection and dynamic programming
- **Performance**: Memory-efficient operations with Span<T> and ref parameters
- **Modern C# Features**: Records, pattern matching, null operators

### **Best Practices Demonstrated**

- **Thread Safety**: Lock mechanisms and race condition prevention
- **Error Handling**: Exception management and validation
- **Code Organization**: Namespaces, interfaces, and modular design
- **Performance Optimization**: Efficient memory usage and async patterns

## 🚀 **Getting Started**

Each folder contains a complete C# console application demonstrating the specific concept. To run any example:

1. Navigate to the desired folder
2. Open the `.csproj` file in Visual Studio or VS Code
3. Run the `Program.cs` file to see the concept in action

## 💡 **Usage Examples**

Each project includes practical examples showing:

- **Real-world scenarios** where the concept applies
- **Common pitfalls** and how to avoid them
- **Performance considerations** and best practices
- **Integration patterns** with other C# features

This repository serves as a comprehensive reference for C# developers at all levels, from beginners learning the basics to experienced developers exploring advanced features and patterns.
