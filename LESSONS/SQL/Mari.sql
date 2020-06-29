

Select sum(Count*p.price)
From customer c join [Order] o on o.customerid=c.id
                join orderline l on l.orderid=o.id
                join product p on p.id=l.productid
where c.name=N'Мария'