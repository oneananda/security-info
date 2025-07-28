### 🔟 OWASP Top 10 – Explained and Demonstrated

1. **Broken Access Control**
   Users are able to access resources or perform actions that should be restricted.
   *Demo:* A normal user accessing admin-only endpoints.
   *Fix:* Enforce proper role-based authorization checks on the server.

2. **Cryptographic Failures**
   Sensitive data (like passwords, credit card info) is exposed due to weak or missing encryption.
   *Demo:* Storing passwords in plain text or transmitting data over HTTP.
   *Fix:* Use HTTPS everywhere, encrypt sensitive data, and hash passwords with strong algorithms like bcrypt.

3. **Injection (SQL Injection)**
    Malicious input can alter backend queries or commands, leading to data leaks or full control.
    Demo: A login form vulnerable to SQL injection.
    Fix: Use parameterized queries and ORM tools to sanitize input.        
4. **Insecure Design**
    The application design itself is insecure—e.g., missing logic to enforce business rules.
    Demo: Users repeatedly abusing a discount feature.
    Fix: Apply secure design principles and perform threat modeling early.