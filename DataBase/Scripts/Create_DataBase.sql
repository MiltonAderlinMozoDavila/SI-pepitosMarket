--- crear data base 
create DATABASE DBMarket -- creates the almacenes de DataBase
on

(NAME = DBMarket, --- Primary data file
FILENAME = 'W:\SI-pepitosMarket\DataBase\Data\DBMarket.mdf',
SIZE = 5MB,
FILEGROWTH = 1MB
)

LOG ON
(NAME = DBMarket_log,  --- log file
FILENAME = 'W:\SI-pepitosMarket\DataBase\Data\DBMarket.ldf',
SIZE = 5MB,
FILEGROWTH = 1MB
)
go
 