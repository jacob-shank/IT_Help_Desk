DELETE FROM Assignment;

DELETE FROM Ticket;

DELETE FROM U_ser;

INSERT INTO U_ser (Username, Password, UserType, Email) VALUES ('admin','1234','A','gugulhelpdesk@gmail.com');
INSERT INTO U_ser (Username, Password, UserType, Email) VALUES ('rayhan','1234','I','rayhan@gmail.com');
INSERT INTO U_ser (Username, Password, UserType, Email) VALUES ('jonathon','1234','I','jonathon@gmail.com');
INSERT INTO U_ser (Username, Password, UserType, Email) VALUES ('lucas','1234','I','lucas@gmail.com');
INSERT INTO U_ser (Username, Password, UserType, Email) VALUES ('catherine','1234','R','catherine@gmail.com');
INSERT INTO U_ser (Username, Password, UserType, Email) VALUES ('jan','1234','P','jan@gmail.com');
INSERT INTO U_ser (Username, Password, UserType, Email) VALUES ('joe','1234','P','joe@gmail.com');
INSERT INTO U_ser (Username, Password, UserType, Email) VALUES ('jacob','1234','P','jshank@butler.edu');

INSERT INTO Ticket (Subject, Description, Status, UserCreated, Priority) VALUES ('Computer Networking Issues','My computer is having trouble connecting to the network in the office. I have tried rebooting and unplugging the LAN cable, but it did not work. Please Hurry!','O','jan','U');
INSERT INTO Ticket (Subject, Description, Status, UserCreated, Priority) VALUES ('Onedrive not connecting to computer','Onedrive often takes a long time to connect to my computer, or takes many tries, not sure what to do. Please help when you can!','O','jacob','L');
INSERT INTO Ticket (Subject, Description, Status, UserCreated, Priority) VALUES ('Work Lap-Top broken','My work issued laptop does not turn on. Not sure if it is charging. I do not currently have a need to work at home, but I may need to soon.','C','joe','M');
INSERT INTO Ticket (Subject, Description, Status, UserCreated, Priority) VALUES ('Need new mouse at desk','My mouse cable has worked itself loose from the front of the mouse. It finally stopped working this morning, I need a new moue fast!','C','jacob','H');

SELECT TicketNum FROM Ticket WHERE Priority = 'M';
SELECT TicketNum FROM Ticket WHERE Priority = 'H';
SELECT TicketNum FROM Ticket WHERE Priority = 'L';
SELECT TicketNum FROM Ticket WHERE Priority = 'U';

INSERT INTO Assignment (Username, TicketNum) VALUES ('rayhan', (SELECT TicketNum FROM Ticket WHERE Priority = 'M'));
INSERT INTO Assignment (Username, TicketNum) VALUES ('jonathon', (SELECT TicketNum FROM Ticket WHERE Priority = 'H'));
INSERT INTO Assignment (Username, TicketNum) VALUES ('lucas', (SELECT TicketNum FROM Ticket WHERE Priority = 'L'));
INSERT INTO Assignment (Username, TicketNum) VALUES ('rayhan', (SELECT TicketNum FROM Ticket WHERE Priority = 'U'));