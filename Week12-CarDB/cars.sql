-- Setting NOCOUNT ON suppresses completion messages for each INSERT
SET NOCOUNT ON

-- Set date format to year, month, day
SET DATEFORMAT ymd;

-- Make the master database the current database
USE master

-- If database co859 exists, drop it
IF EXISTS (SELECT * FROM sysdatabases WHERE name = 'dotnet')
  DROP DATABASE dotnet;
GO

-- Create the co859 database
CREATE DATABASE dotnet;
GO

use dotnet;
GO

-- Used for COMP-10204 Week#12 Exercise.
-- Create the database in MS-SQL EXPRESS
-- Created/Tested in August 2019 by M. Yendt (Mohawk College)
CREATE TABLE CARS (id INTEGER IDENTITY (1,1),
 make VARCHAR(20) NOT NULL,
 model varchar(20) not null,
 modelyear varchar(20) not null);
ALTER TABLE CARS ADD CONSTRAINT cars_primary_key PRIMARY KEY (id);
CREATE TABLE MILEAGE (id INTEGER IDENTITY (1,1),
 startkm INTEGER NOT NULL,
 endkm INTEGER not null,
 gasused REAL not null,
 car_id INTEGER not null);
ALTER TABLE MILEAGE ADD CONSTRAINT mileage_primary_key PRIMARY KEY (id);
ALTER TABLE MILEAGE ADD FOREIGN KEY (CAR_ID) REFERENCES CARS(ID);

INSERT INTO CARS (make, model, modelyear) VALUES ('Honda', 'Civic', '2004');
INSERT INTO CARS (make, model, modelyear) VALUES ('Mazda', 'MX5', '2010');
INSERT INTO CARS (make, model, modelyear) VALUES ('Lexus', 'ES350', '2012');
INSERT INTO MILEAGE (CAR_ID, startkm, endkm, gasused) VALUES (1, 100172,100491,25);
INSERT INTO MILEAGE (CAR_ID, startkm, endkm, gasused) VALUES (2, 22222, 22567, 31.1);
INSERT INTO MILEAGE (CAR_ID, startkm, endkm, gasused) VALUES (1, 100491,101001,32);
INSERT INTO MILEAGE (CAR_ID, startkm, endkm, gasused) VALUES (3, 96000, 96456, 44);
INSERT INTO MILEAGE (CAR_ID, startkm, endkm, gasused) VALUES (1, 101001,101591,34.5);
INSERT INTO MILEAGE (CAR_ID, startkm, endkm, gasused) VALUES (2, 22567,23005,33);
INSERT INTO MILEAGE (CAR_ID, startkm, endkm, gasused) VALUES (2, 23005,23576,41);
INSERT INTO MILEAGE (CAR_ID, startkm, endkm, gasused) VALUES (1, 101591,102102,33.1);
INSERT INTO MILEAGE (CAR_ID, startkm, endkm, gasused) VALUES (1, 102102,102654,35.3);
INSERT INTO MILEAGE (CAR_ID, startkm, endkm, gasused) VALUES (3, 96456,97023,52.3);
INSERT INTO MILEAGE (CAR_ID, startkm, endkm, gasused) VALUES (1, 102654,103132,29.3);
INSERT INTO MILEAGE (CAR_ID, startkm, endkm, gasused) VALUES (3, 97545,98009,47.8);
INSERT INTO MILEAGE (CAR_ID, startkm, endkm, gasused) VALUES (2, 23576,23888,25.4);
INSERT INTO MILEAGE (CAR_ID, startkm, endkm, gasused) VALUES (1, 103400,104007,37.6);
INSERT INTO MILEAGE (CAR_ID, startkm, endkm, gasused) VALUES (2, 23888,24565,25);

SELECT * FROM CARS;
SELECT * FROM MILEAGE;