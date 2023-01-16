# Rent-a-car-service-managment-system
Car renting system for hire vehicles, short time renting and long time renting with C# and SQL

# Renter car service managment system
Rent a car service managment system with C#

## Key system and user requirements

1. Should be able to calculate vehicle rent seperately for long time rent and short time rent.
2. Should be able to calculate hire charge without recording to database.
3. Should be able to login, record rent details, delete and update only for authorized company employee who are having login username and password.
4. Long time vehicle renting and short duration rent details should be able to record in the database as well as remove form it.
5. in the Long time renting with or without driver, the system should be able to calculate rent charge for time based packages as well as the charges for vehicle and driver also calculated through the system.  
6. System should be able to add new vehicle to company collection and its details are also able to record, update and remove from database. 
7. The system is consist from GUIs and all the operations will be done through button clicking. 
8. Each interfaces for data recording or processing should contain a search option through the NIC of customer. 

## Prerequisites
1. Install Microsoft Visual Studio Community version. 
2. Install Microsoft SQL server and Server managment studio.

## Languages and Technologies used
1. C#/.NET framework/SQL

## Steps to run the project in your machine
1. Navigate to the folder
2. Open the flash drive in a new Windows exploree.
3. Copy the project folder and paste it into your flash driver.
4. Install the visual studio in the new computer 
5. In the shared components, tools and SDKs sections, choose or create a folder.
6. Paste the content into selected folder and run the application as usual.  
    
### SOFTWARES USED
  - Install the visual studio, .NET framework and its necessasy libraries and tool kits. 

## GETTING INTO THE PROJECT:
This system is consisted form Welcome interface, Login interface, Home interface, and etc. The welcome interface has presented in following image.This interface is to start the system tasks. 

'Login' login  interface allow user to login to the system for make changes on it. 

‘Home’ interface is helped users to navigate to other interfaces and make changes on it. 

The ‘Home’ page consists of 5 sections:
1. Hire
2. Short rent
3. Long rent
4. Return rented vehicle
5. Add new vehicle

### Hire:
This interface allow user to insert Start vehicle (Km) reading, end reading, vehicle type, vehicle brand, rented date, pickup place and dropped place. The total charge and displacement will be calculated the system and presented when clicking calculate button. 

![image](https://github.com/kaveesh222/Rent-a-car-service-managment-system/blob/main/Ayubo/images/04.png)

### Short renting:
The short renting interface allow user to insert, customer Fulname, NIC, Email, Rented date, Telephone number, Start km reading, vehicle type and brand. So the calculation part of this interface is located in the return vehicle inteface and it will be connected through the NIC as PK. 

![image](https://github.com/kaveesh222/Rent-a-car-service-managment-system/blob/main/Ayubo/images/05.png)

### Long tour:
The long renting interface allow user to insert, customer Fulname, NIC, Email, Rented date, Telephone number, vehicle type and brand. So the calculation part of this interface is located in the return vehicle inteface and it will be connected through the NIC as PK. 

![image](https://github.com/kaveesh222/Rent-a-car-service-managment-system/blob/main/Ayubo/images/06.png)

### Return vehicle
this is the major calculation interface in the system. This interface is also contained different calculations for both long rent and short rent calculations. When the user need to select the tour type first and search the customer NIC in the related search text box. If the customer has taken a vehicle for rent it will be presented all the necassary informationn about the customer and journey. then user can be calculate the total cost that user should pay by inserting required details such as return date for long tours as well as the end kilometer reading for short tour. Any body cannot make changes of the data in this interface through updating. 
In the Long tour, the calculation is automatically done as days, months and weeks for customer convenience. 

![image](https://github.com/kaveesh222/Rent-a-car-service-managment-system/blob/main/Ayubo/images/07.png)

### Login interface
the login interface is the security barrier in this system. So user can enter given username and password for login to the system. Then the system will automatically directed the user to the home interface. `username`: abc, `password`: 123

![image](https://github.com/kaveesh222/Rent-a-car-service-managment-system/blob/main/Ayubo/images/02.png)


