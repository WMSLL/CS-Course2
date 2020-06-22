Create table ReminderItemStorageSQL (
Id uniqueidentifier not null Primary Key
,Title nvarchar(256)not null
,Message nvarchar(1024)not null
,Alarm_Date_time datetime not null
,UserId int not null 
,STATUS int
,Date_time_stamp datetime default getdate()
,   FOREIGN KEY(UserId) REFERENCES UserProfile(ID)
,   FOREIGN KEY(STATUS) REFERENCES StatusMessage(ID)  )

Create table StatusMessage (ID int primary key identity,Status nvarchar(25)
,UserDef1 nvarchar(50),UserDef2 nvarchar(50)
,UserDef3 nvarchar(50),UserDef4 nvarchar(50) ,UserDef5 numeric(19,5),UserDef6 numeric(19,5) )

Create table UserProfile( ID int primary key identity,User_name nvarchar(50),UserDef1 nvarchar(50),UserDef2 nvarchar(50)
,UserDef3 nvarchar(50),UserDef4 nvarchar(50) ,UserDef5 numeric(19,5),UserDef6 numeric(19,5) )
