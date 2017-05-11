# shopping-cart
Shopping Cart Problem presented during Vistaprint interview

My implementation and not meant to instruct. Next version I'll start experimenting with generics. Currently has an issue with rounding doubles so Total Price is off by a penny.

Shopping cart can have two type of items in it: Coupons and Products. There can be any number of different types of Products. Only three types of Coupons:
* Coupon All: Apply price reduction to all items in cart.
* Coupon Next: Reduce the next non coupon item by percent.
* Coupon Next Type: Reduce next cart item of a specific type by a percent.

Goal is to calculate total price of all items in the cart for checkout.
