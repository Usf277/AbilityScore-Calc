# AbilityScore-Calc

A simple C# console application that calculates a DnD-like "ability score" based on customizable parameters such as a dice roll, a divisor, a value to add, and a minimum threshold.  

## 📌 Features

- Accepts user input with default fallback values
- Dynamically updates parameters during runtime
- Recalculates the ability score on each loop iteration
- Graceful input handling and exit option

## 🧮 Formula

The ability score is calculated as:


## 🖥️ Usage

Run the application in your terminal:


You'll be prompted to enter:

1. **Starting 4d6 roll**  
2. **Divide by**  
3. **Add Amount**  
4. **Minimum**

Or you can simply press Enter to use the default values.

After calculation, the program will output the score and prompt whether to quit or continue.

## 🔄 Loop Example

```text
starting 4d6 roll [14] 16
      Using value 16
Divide by [1.75] 2
      Using value 2
Add Amount [2] 1
      Using value 1
Minimum [3] 5
      Using value 5
Calculated ability score :9
Press Q To Quit , Any other key to Continue
