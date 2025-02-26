# Computer-Science-Challenge
## 📌 Introduction
This repository has been created to **solve problems from the LeetCode platform** in order to practice and test my skills in **problem-solving and algorithmic reasoning** using **C#**.

Each solution includes an **analysis of time and space complexity** to better understand the performance of the implemented algorithms.

LeetCode Profile: https://leetcode.com/u/vpadillahoyos/

---

## **📊 Time & Space Complexity Table**
Below is a summary of the **problems solved**, their **time complexity**, and **space complexity**.

| # | Problem Name | Time Complexity | Space Complexity |
|----|----------------------------|----------------|----------------|
| **78** | Subsets | O(n⋅2ⁿ) | O(n⋅2ⁿ) |
| **13** | Roman to Integer | O(n) | O(1) |
| **151** | Reverse Words in a String | O(n) | O(n) |
| **206** | Reverse Linked List | O(n) | O(1) |
| **92** | Reverse Linked List II | O(n) | O(1) |
| **48** | Rotate Image | O(n²) | O(1) |
| **32** | Longest Valid Parentheses | O(n) | O(n) |

---
# 1. Subsets (LeetCode #78)
Given an integer array `nums` of unique elements, return **all possible subsets**.

- The solution **must not contain duplicate subsets**.
- The order of the subsets **does not matter**.

---

### 🔹 Approach
To solve this problem, I implemented the **formula for calculating the total number of subsets** based on the number of elements (`n`) in the list:

`Total Subsets = 2^n`

Then, I used **two loops**:
1. **The outer loop (`listposition`)** represents the total number of subsets stored in `IList<IList<int>>`.
2. **The inner loop (`i`)** calculates the elements of each subset by iterating through `nums.Length`.

The **bitwise AND (`&`) operation** checks whether the corresponding bit in `listposition` is set (`1`). If so, the element at that position is **added** to the subset.

During the implementation, I used **ChatGPT** to understand and apply the logic of **bitwise AND (`&`)** to determine whether an element should be included in the subset.

<details>
  <summary>Diagram</summary>
  
  ![image 1](https://github.com/user-attachments/assets/01f412c8-6828-4b34-88b3-4a451a4e5172)
  ![image 2](https://github.com/user-attachments/assets/87f47917-97cf-41e6-96a8-82e8039f9271)

</details>

# 2. Roman to Integer (LeetCode #13)
Given a **Roman numeral**, convert it into an **integer**.  
Certain numerals use **subtraction rules** (e.g., `IV = 4`, `IX = 9`).  
Ensure proper handling of both **addition and subtraction cases**.

### 🔹 Approach
To solve this problem, I used a **dictionary** to store the **Roman numeral values** for quick lookup.

Then, I **traverse the string in reverse order**, ensuring that:
- If a numeral **is smaller than the previous one**, it is **subtracted** (e.g., `IV` → `5 - 1 = 4`).
- Otherwise, it is **added**.

<details>
  <summary>Diagram</summary>

  ![image](https://github.com/user-attachments/assets/c72efa88-f9d8-42fa-b53e-11830dbf5bf2)
  ![image](https://github.com/user-attachments/assets/04aa4aff-e996-43a9-9525-346a4afe27fb)

</details>

# 3. Reverse Words in a String (LeetCode #151)

### 📌 Problem Statement
Given a string `s`, reverse the **order of the words** while maintaining a **single space between them**.  
- Words are **separated by at least one space**.  
- The output should **remove leading, trailing, and extra spaces**.  

---

### 🔹 Approach
To solve this problem, I used **regular expressions (`Regex.Replace`)** to replace **all extra spaces** with a **single space**, ensuring a clean sentence structure.

Steps:
1. **Remove extra spaces**: Use `Regex.Replace` to replace multiple spaces with **one space**.
2. **Trim leading and trailing spaces**: Use `Trim()` to clean the sentence.
3. **Split into words**: Use `Split(" ")` to convert the sentence into an **array of words**.
4. **Reverse the array**: Reverse the order of the words.
5. **Join back into a string**: Use `string.Join(" ", words)` to concatenate the words with a **single space**.

---

<details>
  <summary>Diagram</summary>

  ![image](https://github.com/user-attachments/assets/d10d8135-13bd-4154-97e2-88d63b9fcd79)
  ![image](https://github.com/user-attachments/assets/47dc0010-79a0-4c68-bd4c-f38ac1119edf)

</details>

# 4. Reverse Linked List (LeetCode #206)

### 📌 Problem Statement
Given the `head` of a **singly linked list**, reverse the list and return the **new head** of the reversed list.  
The input list should be modified **in-place**, without creating a new list.

---

### 🔹 Approach
To reverse the linked list **iteratively**, I used **three pointers (`prevNode`, `currentHead`, and `nextNode`)** to keep track of the traversal and modify the `next` pointers.

Steps:
1. **Initialize pointers**:
   - `prevNode = null` (tracks the previous node).
   - `currentHead = head` (tracks the current node).
   - `nextNode = null` (used to store the next node temporarily).
2. **Traverse the list**:
   - Store `currentHead.next` in `nextNode` (preserve the next node).
   - Reverse the `next` pointer of `currentHead` to point to `prevNode`.
   - Move `prevNode` forward to `currentHead`.
   - Move `currentHead` forward to `nextNode`.
3. **Return `prevNode` as the new head** (since `currentHead` becomes `null` at the end).

<details>
  <summary>Diagram</summary>

  ![image](https://github.com/user-attachments/assets/d56495ca-3503-4878-afdf-085e55cb9169)
  ![image](https://github.com/user-attachments/assets/9e3030ef-ca79-4c1b-8a78-402e27c107d6)

</details>

# 5. Reverse Linked List II (LeetCode #92)

### 📌 Problem Statement
Given the `head` of a **singly linked list** and two integers `left` and `right` (`left <= right`),  
reverse the nodes **only between these positions** and return the modified list.

---

### 🔹 Approach
This problem was initially **confusing**, as reversing only a portion of the linked list is more complex than reversing the entire list.  
With the help of **ChatGPT**, I understood that since `left <= right` is always true, we can safely reverse the specified portion of the list.

To implement the solution, I created **four variables**:
1. **`modelList`** → A dummy node to simplify edge cases (e.g., `left = 1`).
2. **`prevLeft`** → Tracks the node **before** the `left` position.
3. **`startNode`** → The first node in the segment to be reversed.
4. **`nextNode`** → The node that will be moved to the front of the reversed segment.

The key idea is to **iteratively reposition nodes** within the given range (`left` to `right`) without affecting the rest of the list.

---
<details>
  <summary>Diagram</summary>

  ![image](https://github.com/user-attachments/assets/de52f5e6-5f7e-42c5-b8a7-45eab832077c)
  ![image](https://github.com/user-attachments/assets/212c079a-d901-445f-bcc0-4979bf9aa63b)

</details>

# 6. Rotate Image (LeetCode #48)

### 📌 Problem Statement
Given an `n x n` 2D matrix, rotate the image **90 degrees clockwise** in-place.  
- You must **modify the matrix directly**, without using an additional matrix.  
- The solution should handle **square matrices (`n x n`)**.

---

### 🔹 Approach
Initially, understanding how to **rotate the `n x n` matrix** was challenging.  
I realized that the key was to **move elements layer by layer** while **using a temporary variable** to store values without overwriting others.

To solve this problem, I used a **four-way swapping technique**, similar to rotating a **square from left-right and top-bottom**.

### 🔹 Key Steps in the Code:
1. **Define boundaries** (`left`, `right`, `top`, `bottom`).
2. **Iterate over the matrix layer by layer**.
3. **Store `top-left` in a temporary variable (`temp`)**.
4. **Move values in four steps**:
   - Move `bottom-left` → `top-left`
   - Move `bottom-right` → `bottom-left`
   - Move `top-right` → `bottom-right`
   - Move `temp` (`top-left`) → `top-right`
5. **Continue until the entire matrix is rotated**.

---

<details>
  <summary>Diagram</summary>

  ![image](https://github.com/user-attachments/assets/ccef5950-9b2d-4266-b3a6-36696f81f1e6)
  ![image](https://github.com/user-attachments/assets/502fded1-008b-45ca-a7fc-b6ee024c5c34)

</details>

# 7. Longest Valid Parentheses (LeetCode #32)

### 📌 Problem Statement
Given a string containing only the characters `'('` and `')'`, return the **length of the longest valid (well-formed) parentheses substring**.

- The parentheses must be **consecutive**, meaning that a valid sequence cannot contain unmatched or misplaced parentheses.
- Example:
  - **Input:** `s = "(()"` → **Output:** `2` (`"()"`).
  - **Input:** `s = ")()())"` → **Output:** `4` (`"()()"`).

---

### 🔹 Approach
To solve this problem, it was essential to understand that **valid parentheses must be consecutive** and **not scattered** within the string. This became clear after analyzing the example cases, where only continuous sequences of matching `()` were counted.

To implement the solution:
1. I used a **stack (`Stack<int> indexValid`)** to store **the positions of open parentheses `'('`**.
2. I maintained a **variable `indexInvalid`** to track **the last invalid `')'` encountered**.
3. **For each character** in `s`:
   - If it is `'('`, **push its index into the stack**.
   - If it is `')'`:
     - If a `'('` is available in the stack, **pop it**, calculate the length of the valid substring, and update `sum` if it's the longest.
     - If the stack is empty, **update `indexInvalid`** (tracks last unmatched `')'`).
4. Finally, return `sum`, which holds the **maximum valid substring length**.

Implemente ayuda de chatgpt para recordar el concepto de la estructura de base de dato: stack.

---

<details>
  <summary>Diagram</summary>

  ![image](https://github.com/user-attachments/assets/38672c85-c185-4fd6-83a9-19cf5ad1974e)
  ![image](https://github.com/user-attachments/assets/0de2fe23-8b6d-402b-a85d-e985cda43ce3)

</details>
