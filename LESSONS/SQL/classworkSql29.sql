Select Count(*)
From OrderLine

Select Count(distinct orderid)
From OrderLine

Select max(id)
From [order]


Select avg(Discount)
From [order]


Select max(orderDate),min(orderDate)
From [Order]



Select max(orderDate)
From [Order]
where  datename(YEAR,orderDate )='2018'


Select max(len(Name))
From product

--Select