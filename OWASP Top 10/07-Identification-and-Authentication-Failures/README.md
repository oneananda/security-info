# 🛡️ Mitigations

| Risk                  | Recommended Fix                             |
| --------------------- | ------------------------------------------- |
| Brute-force login     | Rate limiting, CAPTCHA, account lockouts    |
| Weak password storage | Use salted hashing (e.g., BCrypt)           |
| Session hijacking     | Secure cookies, SameSite, short expiry      |
| No MFA                | Add second factor (SMS, Email, App)         |
| Token abuse           | Use short-lived JWTs and support revocation |
| Account enumeration   | Use generic error messages                  |
