CREATE TABLE DepartureBoard (
             FlightNumber      NVARCHAR(25) ,
             CountryDeparture  NVARCHAR(50) ,
             CityDeparture     NVARCHAR(100) ,
             CountryArrival    NVARCHAR(50) ,
             CityArrival       NVARCHAR(100) ,
             DateTimeDeparture DATETIMEOFFSET ,
             DateTimeArrival   DATETIMEOFFSET ,
             FlightTime        TIME ,
             AirlineCompany    NVARCHAR(100) ,
             AircraftModel     NVARCHAR(50)
                            );

INSERT INTO DepartureBoard ( FlightNumber , CountryDeparture , CityDeparture , CountryArrival , CityArrival , DateTimeDeparture , DateTimeArrival , FlightTime , AirlineCompany , AircraftModel
                           )
VALUES ( N'ИЖ-3301' , N'Россия' , N'Ижевск' , N'Россия' , N'Москва' , '2020-06-16 09:15:45.1538544 +03:00' , '2020-06-16 11:15:45.1538544 +04:00' , '02:00' , N'IZH-AIRLINE' , N'Як-42'
       );

INSERT INTO DepartureBoard ( FlightNumber , CountryDeparture , CityDeparture , CountryArrival , CityArrival , DateTimeDeparture , DateTimeArrival , FlightTime , AirlineCompany , AircraftModel
                           )
VALUES ( N'ИЖ-3303' , N'Россия' , N'Ижевск' , N'Россия' , N'Москва' , '2020-06-16 09:15:45.1538544 +03:00' , '2020-06-16 11:00:45.1538544 +04:00' , '01:45' , N'IZH-AIRLINE' , N'Як-42'
       );

SELECT *
FROM DepartureBoard;

DROP TABLE DepartureBoard;