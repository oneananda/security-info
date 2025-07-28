// Insecure Design Example: Vulnerable Checkout Process

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


[HttpPost("checkout")]
public IActionResult Checkout(OrderRequest request)
{
    // ❌ Directly trusting discount input from user
    decimal discount = request.DiscountPercentage;

    var total = CalculateOrderTotal(request.Items);
    var finalAmount = total - (total * (discount / 100));

    // Proceed with order
    return Ok(new { Total = finalAmount });
}

// ❌ Attacker gets everything for free by modifying the request in Postman or DevTools.
