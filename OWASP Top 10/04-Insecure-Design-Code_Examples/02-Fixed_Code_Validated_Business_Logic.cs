// Fixed Code (Validated Business Logic)

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


[HttpPost("checkout")]
[Authorize]
public IActionResult Checkout(OrderRequest request)
{
    var user = GetCurrentUser(); // Authenticated user
    var eligibleDiscount = GetUserEligibleDiscount(user);

    // ✅ Use only server-calculated discount
    var total = CalculateOrderTotal(request.Items);
    var finalAmount = total - (total * (eligibleDiscount / 100));

    return Ok(new { Total = finalAmount });
}

private int GetUserEligibleDiscount(User user)
{
    if (user.IsPremiumMember)
        return 10;
    return 0;
}
