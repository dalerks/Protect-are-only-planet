select Tag,
Parent,
[Export!1!],
[Order!2!],
[Order!2!OrderID!ELEMENT],
[Order!2!OrderDate!ELEMENT],
[Order!2!ShipAddress1!ELEMENT],
[Order!2!ShipAddress2!ELEMENT],
[Order!2!ShipCity!ELEMENT],
[Order!2!ShipCompanyName!ELEMENT],
[Order!2!ShipCountry!ELEMENT],
[Order!2!ShipFirstName!ELEMENT],
[Order!2!ShipLastName!ELEMENT],
[Order!2!ShipResidential!ELEMENT],
[Order!2!ShipPostalCode!ELEMENT],
[Order!2!ShipState!ELEMENT],
[OrderDetails!3!],
[OrderDetails!3!OrderDetailID!ELEMENT],
[OrderDetails!3!OrderID!ELEMENT],
[OrderDetails!3!ProductCode!ELEMENT],
[OrderDetails!3!ProductID!ELEMENT],
[OrderDetails!3!ProductName!ELEMENT],
[OrderDetails!3!Quantity!ELEMENT]
from
(
Select 1 as Tag,
Null as Parent,
0 as sort,
Null as 'Export!1!',
Null as 'Order!2!',
Null as 'Order!2!OrderID!ELEMENT',
Null as 'Order!2!OrderDate!ELEMENT',
Null as 'Order!2!ShipAddress1!ELEMENT',
Null as 'Order!2!ShipAddress2!ELEMENT',
Null as 'Order!2!ShipCity!ELEMENT',
Null as 'Order!2!ShipCompanyName!ELEMENT',
Null as 'Order!2!ShipCountry!ELEMENT',
Null as 'Order!2!ShipFirstName!ELEMENT',
Null as 'Order!2!ShipLastName!ELEMENT',
Null as 'Order!2!ShipResidential!ELEMENT',
Null as 'Order!2!ShipPostalCode!ELEMENT',
Null as 'Order!2!ShipState!ELEMENT',
Null as 'OrderDetails!3!',
Null as 'OrderDetails!3!OrderDetailID!ELEMENT',
Null as 'OrderDetails!3!OrderID!ELEMENT',
Null as 'OrderDetails!3!ProductCode!ELEMENT',
Null as 'OrderDetails!3!ProductID!ELEMENT',
Null as 'OrderDetails!3!ProductName!ELEMENT',
Null as 'OrderDetails!3!Quantity!ELEMENT'

union all 
select
2 as Tag,
1 as Parent,orderNumber as sort,Null,
Null,
orderNumber,OrderDate,rtrim(ShipAddress1),rtrim(ShipAddress2),rtrim(ShipCity),rtrim(ShipCompanyName),rtrim(ShipCountry),
rtrim(ShipFirstName),rtrim(ShipLastName),ShipResidential,rtrim(ShipPostalCode),ShipState,Null,Null,
null,null,null,null,null
from Orders
union all
select 
3 as Tag,
2 as Parent,OrderID as sort,null,null,null,null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,Null,
OrderDetailID,OrderID,RTRIM(ProductCode),ProductID,RTRIM(ProductName),Quantity
from Order_Details inner join GIFT on  GIFT.SKU = Order_Details.ProductCode
) A
order by sort
FOR XML EXPLICIT 