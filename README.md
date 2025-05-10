#  Sudoku Solver in C#

This is a C# console application that solves a given Sudoku puzzle using **backtracking**. It takes a 9x9 grid as input, where empty cells are represented by `0`, and fills in the grid with the correct values according to Sudoku rules.

---

##  Example Input Puzzle

Here is a sample Sudoku puzzle (empty cells shown as blank):

![Sudoku Puzzle](https://github.com/user-attachments/assets/9d1fc84b-dc95-4138-9763-1f8f08d06eb8)


---

## 🧠 How It Works

This program uses **backtracking**, a depth-first search algorithm that:

1. Traverses the grid to find an empty cell.
2. Tries digits 1 through 9.
3. Validates each digit based on:
   - Row constraints
   - Column constraints
   - 3x3 subgrid constraints
4. Recursively fills the next cell.
5. If no digit is valid, it backtracks and tries a different number in the previous cell.

---

## 🧪 Sample Input (from Console)

```plaintext
5 3 0 0 7 0 0 0 0
6 0 0 1 9 5 0 0 0
0 9 8 0 0 0 0 6 0
8 0 0 0 6 0 0 0 3
4 0 0 8 0 3 0 0 1
7 0 0 0 2 0 0 0 6
0 6 0 0 0 0 2 8 0
0 0 0 4 1 9 0 0 5
0 0 0 0 8 0 0 7 9
