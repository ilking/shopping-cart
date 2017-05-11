using System;

namespace ShoppingCart
{
  public class CouponAll : Coupon
  { 
    public CouponAll(int percent) : base(percent)
    {
    }
    
    public override CouponType Type()
    {
      return CouponType.CouponAll;
    }
  }
}