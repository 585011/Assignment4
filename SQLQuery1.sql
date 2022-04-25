DROP TABLE IF EXISTS Customers, Rooms, Bookings, Services;

CREATE TABLE Customers (
	username varchar(20) NOT NULL PRIMARY KEY,
	pass varchar(20) NOT NULL,
	firstname varchar(20) NOT NULL,
	lastname varchar(20) NOT NULL
);

CREATE TABLE Rooms (
	roomID int IDENTITY(1,1) PRIMARY KEY,
	beds int NOT NULL,
	size int NOT NULL
);

CREATE TABLE Bookings (
	bookingID int IDENTITY(1,1) PRIMARY KEY,
	roomID int FOREIGN KEY REFERENCES Rooms(roomID),
	username varchar(20) FOREIGN KEY REFERENCES Customers(username),
	bookingfrom datetime NOT NULL,
	bookingto datetime NOT NULL,
	checkedin datetime,
	checkedout datetime
);

CREATE TABLE Tasks (
	serviceID int IDENTITY(1,1) PRIMARY KEY,
	roomID int FOREIGN KEY REFERENCES Rooms(roomID), 
	task varchar(20) NOT NULL,
	stat varchar(11) NOT NULL,
	deskcomment varchar(100),
	servicecomment varchar(100)
);

INSERT INTO Customers (username, pass, firstname, lastname)
VALUES 	('Vebb', 		'pass', 'Vebjørn', 		'Vårdal'),
		('Alek', 		'pass', 'Alexander', 	'Øen'),
		('Einstein', 	'pass',	'Øystein', 		'Kvilhaugsvik');
		
INSERT INTO Rooms (beds, size)
VALUES 	(1, 10),(1, 10),(1, 10),
		(2, 10),(2, 10),(2, 10),
		(3, 10),(3, 10),(3, 10),
		(1, 20),(1, 20),(1, 20),
		(2, 20),(2, 20),(2, 20),
		(3, 20),(3, 20),(3, 20),
		(1, 30),(1, 30),(1, 30),
		(2, 30),(2, 30),(2, 30),
		(3, 30),(3, 30),(3, 30);
		
INSERT INTO Bookings (roomID, username, bookingfrom, bookingto, checkedin)
VALUES 	(3, 	'Einstein', '2022-04-05 12:00:00', '2023-04-05 12:00:00', '2022-04-05 13:33:00'),
		(7, 	'Vebb', 		'2022-04-10 12:00:00', '2022-04-11 12:00:00', NULL),
		(21, 	'Alek', 			'2023-05-11 12:00:00', '2023-05-13 12:00:00', NULL);

INSERT INTO Tasks (roomID, task, stat, deskcomment)
VALUES 	(7, 	'Cleaning', 	'New', 			'Checked out'),
		(21, 	'Cleaning', 	'New', 			'Checked out'),
		(1, 	'Maintenance', 	'New', 			'Clogged toilet'),
		(3, 	'Roomservice', 	'In progress', 	'Lobster');