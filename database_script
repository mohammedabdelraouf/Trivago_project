drop table Admins cascade constraints;
drop table customers cascade constraints;
drop table hotels cascade constraints;
drop table rooms cascade constraints;
drop table reservation cascade constraints;
drop table Nationality cascade constraints;


CREATE TABLE Admins
  (adminid number(10) primary key, adminename varchar2(255), phonenumber number(15), gender varchar2(50) , Email varchar(255), Password number(10));

create table nationality
(nationalityname varchar(255) primary key, nationalitykey varchar(255));
 
create table Customers
  (CustomerId number(3) primary key, CustomerName varchar2(255) not NULL, Nationalityname varchar(255) References NATIONALITY, PhoneNumber number(15), Gender varchar2(50), Email varchar(255), Password number(10) , cridit number
);
   
CREATE TABLE Hotels
  (HotelName varchar2(255) primary key, HotelLocation varchar2(255), PhoneNumber number(15)); 
  
CREATE TABLE Rooms
  (roomnum number(10) primary key, price decimal(8,2), HotelName varchar2(255) References Hotels, adminid number(10) References Admins,
  roomtype varchar2(255) , reservation_number number);

CREATE TABLE Reservation
  (reservid number(10), roomnum number(10) References Rooms, customerid number(10)  References customers, StartDate date, EndDate date, Rates number(5) , Total_cost number);

 
insert into nationality values('Egypt', '+20');
insert into nationality values('USA', '+1');
insert into nationality values('UAE', '+998');
insert into nationality values('Saudi Arabia', '+966');
insert into nationality values('Palestine', '+970');
insert into nationality values('Amman', '+968');
insert into nationality values('Belgium', '+32');
insert into nationality values('Farance', '+33');
insert into nationality values('Italia', '+39'); 
