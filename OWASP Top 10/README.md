### 🔟 OWASP Top 10 – Explained and Demonstrated

1. **Broken Access Control**
   Users are able to access resources or perform actions that should be restricted.
   *Demo:* A normal user accessing admin-only endpoints.
   *Fix:* Enforce proper role-based authorization checks on the server.

2. **Cryptographic Failures**
   Sensitive data (like passwords, credit card info) is exposed due to weak or missing encryption.
   *Demo:* Storing passwords in plain text or transmitting data over HTTP.
   *Fix:* Use HTTPS everywhere, encrypt sensitive data, and hash passwords with strong algorithms like bcrypt.

