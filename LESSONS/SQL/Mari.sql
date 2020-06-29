

 Select  id,name,sum(total)
 From (
Select  c.id,c.name,(1- isnull(Discount,0))*sum(l.count*p.price) total
From customer c join [Order] o on o.customerid=c.id
                join orderline l on l.orderid=o.id
                join product p on p.id=l.productid
                Group by  c.id,c.name,isnull(Discount,0)
 )  t

 Group by id,name