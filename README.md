# Reusable String Builder Utility for Unity

## Introduction

The Reusable StringBuilder, provided by `com.Klazapp.Utility`, is a Unity-specific tool designed to optimize string manipulations by reusing a single instance of `StringBuilder`. This utility reduces the overhead associated with frequent creation and disposal of `StringBuilder` instances, particularly beneficial in performance-critical applications such as gaming.

## Features

- **Efficient String Building:** Utilizes a single, reusable instance of `StringBuilder` to minimize garbage collection and improve performance during frequent string manipulations.
- **Easy-to-Use API:** Offers a simple method `StringBuilderReuse` that clears the current contents and appends new strings efficiently.
- **Thread-Safe Operations:** Enhanced with `MethodImpl` attributes to ensure aggressive inlining and potentially optimize performance.

## Dependencies

This utility requires Unity as it extends from MonoSingletonGlobal, ensuring that the instance is globally accessible within your Unity project.

## Compatibility

The Reusable StringBuilder is designed to be compatible with any Unity project. It does not depend on specific rendering pipelines or Unity versions, making it versatile for any development environment.

| Compatibility     | URP | BRP | HDRP |
|-------------------|-----|-----|------|
| Compatible        | ✔️   | ✔️   | ✔️    |

## Installation

1. Download the Reusable StringBuilder script from the [GitHub repository](https://github.com/klazapp/Unity-Reusable-StringBuilder-Public.git) or via the Unity Package Manager.
2. Add the script to your Unity project to integrate efficient string building capabilities.

## Usage

Add the `ReusableStringBuilder` to a global manager object in your scene or keep it accessible through the singleton pattern. Use the `StringBuilderReuse` method to combine strings efficiently:

```csharp
string result = ReusableStringBuilder.Instance.StringBuilderReuse("Hello, ", "World!");
```

## To-Do List (Future Features)

- [ ] Enhance thread safety for multi-threaded use cases.
- [ ] Expand API to include more complex string manipulation methods.

## License

This utility is released under the MIT License, allowing free use, modification, and distribution within your projects.
