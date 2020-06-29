Select*
From [Order]
where discount=(Select max(discount)From [Order] where YEAR(OrderDate)=2016
)
Select*
From [Order]
where OrderDate=(Select min(OrderDate)From [Order] where YEAR(OrderDate)=2019
)


Select o.customerid,c.name
From [Order] o join customer c on c.id=o.customerid
where discount=(Select max(discount)From [Order] where YEAR(OrderDate)=2016
)


Select o.customerid,c.name
From [Order] o join customer c on c.id=o.customerid
where OrderDate=(Select min(OrderDate)From [Order] where YEAR(OrderDate)=2019
)
