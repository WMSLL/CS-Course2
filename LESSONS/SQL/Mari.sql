

Select  sum(total),YEAR
From (
Select  (1- isnull(Discount,0))*sum(l.count*p.price) total,YEAR(Orderdate) [YEAR]
From  [Order] o  join orderline l on l.orderid=o.id
                 join product p on p.id=l.productid
                 Group by  isnull(Discount,0),YEAR(Orderdate) 
 )  t
Group by YEAR