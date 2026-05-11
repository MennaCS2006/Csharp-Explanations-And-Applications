# **📦 02 - Data Types and Variables** 


### *In this folder covers the basics of handling data, variables, and input/output methods in C#*.
---


## 1. Comments :

→ Comments can be used to explain C# code, and to make it more readable.

→ It can also be used to prevent execution when testing your code.

→ Single-line comments start with two forward slashes (//).

→ Multi-line comments start with /* and ends with */.

## 2. Variables & Constants :

→ Variables are containers for storing data values.

→ In fact, variables are memory locations used for holding values.

→ To create a variable, you must specify the type and assign it a value:  
**`type variableName = value;`**

→ All C# variables must be identified with unique names.

→ These unique names are called identifiers.
 
→ Identifiers can be short names (like x and y) or more descriptive names (age, sum, totalVolume).

→ **The general rules for constructing names for variables (unique identifiers) are**: 

1. Names can contain letters, digits and the underscore character (_).
2. Names must begin with a letter.
3. Names can start with a lowercase or uppercase letter and it cannot contain whitespace.
4. Names are case sensitive ("myVar" and "myvar" are different variables).
5. Reserved words (like C# keywords, such as int or double) cannot be used as names.

→ You can add the const keyword if you don't want others to overwrite existing values (this will declare the variable as "constant", which means unchangeable and read-only).

→ You cannot declare a constant variable without assigning the value. If you do, an error will occur.

## 3. Data Types :

→ It is important to use the correct data type for the corresponding variable; to avoid errors, to save time and memory.

→ The most common data types are: 
1. `int`:  Stores whole numbers, positive or negative without decimals can store whole numbers from - 2147483648 to 2147483647 (4 bytes).
2. `long`: This is used when int is not large enough to store the value and can store whole numbers from 9223372036854775808 to 9223372036854775807 (8 bytes)، Note that you should end the value with an `L`.
3. `float`: represents numbers with a fractional part, containing one or more decimals and can store fractional numbers from 3.4e−038 to 3.4e+038 (4 bytes)، Note that you should end the value with an `F`.
4. `double`: can store fractional numbers from 1.7e−308 to 1.7e+308 (8 bytes).
5. `bool`: is declared with the bool keyword and can only take the values (`true` or `false`) (1 bit).
6. `char`: is used to store a single character and must be surrounded by single quotes `' '` (2 bytes).
7. `string`: is used to store a sequence of characters (text) and string values must be surrounded by double quotes `" "` (2 bytes per character).


## 4. I/O Statements :

→ **Output** :
1. `Console.WriteLine()` is used to display output and move to a new line after printing. 
2. `Console.Write()` prints text on the same line but does not move to a new line.

→ **Input** :
1. `Console.ReadLine()` reads input from the keyboard.
2. `Console.ReadLine()` always returns to a string.

→ **Converting string to data types** :

1. converting string → int : `int.Parse()`
2. converting string → Long : `long.Parse()` 
3. converting string → short : `short.Parse()` 
4. Convert string → double : `double.Parse()` 
5. converting string → float : `float.Parse()` 
6. converting string → bool : `bool.Parse()` 
7. converting string → char : `char.Parse()` 

→ **Print Special Characters** : 
1. `\n` means new line : `Console.WriteLine("Hello\nWorld");` 
2. `\t` creates a tab space : `Console.WriteLine("Name:\tAli");`