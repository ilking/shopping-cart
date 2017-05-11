using System;

namespace ShoppingCart
{
  public class CouponNext : Coupon
  {
    public CouponNext(int percent) : base(percent)
    {
    }
    
    public override CouponType Type()
    {
      return CouponType.CouponNext;
    }
    
  }
}