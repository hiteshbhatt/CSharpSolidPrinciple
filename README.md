# SOLID Principles – Object-Oriented Design Theory

SOLID is a collection of **five design principles** that help developers create **maintainable, scalable, and flexible** object-oriented software.

Introduced by **Robert C. Martin (Uncle Bob)**, SOLID is a foundational concept for clean architecture and professional software development.

---

## 📌 What is SOLID?

SOLID is an acronym representing five principles:

| Letter | Principle |
|------|----------|
| **S** | Single Responsibility Principle |
| **O** | Open/Closed Principle |
| **L** | Liskov Substitution Principle |
| **I** | Interface Segregation Principle |
| **D** | Dependency Inversion Principle |

---

## 1️⃣ Single Responsibility Principle (SRP)

**Definition:**  
A class should have **only one reason to change**.

**Explanation:**  
Each class should focus on a **single responsibility or concern**.  
If a class handles multiple responsibilities, it becomes harder to maintain and test.

**Why it matters:**
- Easier to understand
- Easier to modify
- Reduces unintended side effects

---

## 2️⃣ Open/Closed Principle (OCP)

**Definition:**  
Software entities should be **open for extension but closed for modification**.

**Explanation:**  
New functionality should be added **without changing existing code**.  
This is commonly achieved through abstraction and polymorphism.

**Why it matters:**
- Prevents breaking existing features
- Improves scalability
- Encourages reusable design

---

## 3️⃣ Liskov Substitution Principle (LSP)

**Definition:**  
Subclasses must be substitutable for their base classes without affecting correctness.

**Explanation:**  
If a subclass changes expected behavior, it breaks polymorphism and violates LSP.

**Key idea:**
> A child class should behave like its parent class.

---

## 4️⃣ Interface Segregation Principle (ISP)

**Definition:**  
Clients should not be forced to depend on interfaces they do not use.

**Explanation:**  
Large interfaces should be split into **smaller, more specific interfaces** so that implementing classes only depend on what they need.

**Why it matters:**
- Reduces coupling
- Improves flexibility
- Simplifies implementation

---

## 5️⃣ Dependency Inversion Principle (DIP)

**Definition:**  
High-level modules should not depend on low-level modules.  
Both should depend on **abstractions**.

**Explanation:**  
Business logic should depend on interfaces, not concrete implementations.  
Dependency Injection is a common way to achieve this.

**Why it matters:**
- Enables loose coupling
- Improves testability
- Supports clean architecture

---

## ✅ Benefits of SOLID Principles

- Clean and readable code
- Easy maintenance
- Better testability
- Reduced technical debt
- Scalable architecture

---

## 🧠 When to Use SOLID?

- Object-Oriented applications
- Medium to large-scale systems
- Long-term projects
- When maintainability is important

---

## 📚 References

- Robert C. Martin – *Clean Architecture*
- Robert C. Martin – *Agile Software Development*
- https://solidprinciples.com

---

## ⭐ Conclusion

SOLID principles are **guidelines, not strict rules**.  
Use them where they add value and improve design quality.

> “Clean code always looks like it was written by someone who cares.”  
> — Robert C. Martin
