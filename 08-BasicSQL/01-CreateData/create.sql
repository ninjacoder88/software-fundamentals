CREATE TABLE dbo.Department
(
    DepartmentId INT NOT NULL IDENTITY(1,1),
    Name VARCHAR(50) NOT NULL
);
ALTER TABLE dbo.Department ADD CONSTRAINT PK_Department_DepartmentId PRIMARY KEY CLUSTERED (DepartmentId);

INSERT INTO dbo.Department VALUES ('Information Technology');
INSERT INTO dbo.Department VALUES ('Enterprise Infrastructure');
INSERT INTO dbo.Department VALUES ('Manufacturing Applications');
INSERT INTO dbo.Department VALUES ('Customer and Ordering Systems');
INSERT INTO dbo.Department VALUES ('Data Services');
INSERT INTO dbo.Department VALUES ('Gblobal Support Services');
INSERT INTO dbo.Department VALUES ('Enterprise Infrastructure');
INSERT INTO dbo.Department VALUES ('Enterprise Operations');
INSERT INTO dbo.Department VALUES ('Software Development - Manufacturing Processes');
INSERT INTO dbo.Department VALUES ('Software Development - Purification and QC');
INSERT INTO dbo.Department VALUES ('Software Development - SYB');
INSERT INTO dbo.Department VALUES ('Development Operations - Infrastructure');

CREATE TABLE dbo.DepartmentLink
(
    DepartmentLinkId INT NOT NULL IDENTITY(1,1),
    ParentDepartmentId INT NOT NULL,
    ChildDepartmentId INT NOT NULL,
);
ALTER TABLE dbo.DepartmentLink ADD CONSTRAINT PK_DepartmentLink_DepartmentLinkId PRIMARY KEY CLUSTERED (DepartmentLinkId);
ALTER TABLE dbo.DepartmentLink ADD CONSTRAINT FK_DepartmentLink_Department_ParentDepartmentId FOREIGN KEY (ParentDepartmentId) REFERENCES Department(DepartmentId);
ALTER TABLE dbo.DepartmentLink ADD CONSTRAINT FK_DepartmentLink_Department_ChildDepartmentId FOREIGN KEY (ChildDepartmentId) REFERENCES Department(DepartmentId);

INSERT INTO dbo.DepartmentLink VALUES (1, 2);
INSERT INTO dbo.DepartmentLink VALUES (1, 3);
INSERT INTO dbo.DepartmentLink VALUES (1, 4);
INSERT INTO dbo.DepartmentLink VALUES (2, 5);
INSERT INTO dbo.DepartmentLink VALUES (2, 6);
INSERT INTO dbo.DepartmentLink VALUES (2, 7);
INSERT INTO dbo.DepartmentLink VALUES (2, 8);
INSERT INTO dbo.DepartmentLink VALUES (3, 9);
INSERT INTO dbo.DepartmentLink VALUES (3, 10);
INSERT INTO dbo.DepartmentLink VALUES (3, 11);
INSERT INTO dbo.DepartmentLink VALUES (3, 12);

CREATE TABLE dbo.Associate
(
    AssociateId INT NOT NULL IDENTITY(1,1),
    Name VARCHAR(50) NOT NULL,
    LoginName VARCHAR(50) NOT NULL,
    DepartmentId INT NOT NULL,
    Title VARCHAR(50) NOT NULL,
);
ALTER TABLE dbo.Associate ADD CONSTRAINT PK_Associate_AssociateId PRIMARY KEY CLUSTERED (AssociateId);
ALTER TABLE dbo.Associate ADD CONSTRAINT FK_Associate_DepartmentId FOREIGN KEY (DepartmentId) REFERENCES Department (DepartmentId);

INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Jon Hall', 'jonhall', 1, 'VP & Chief Information Officer');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Rob Frees', 'rfrees', 2, 'Director of Enterprise Infrastructure');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Phil Parent', 'pparent', 3, 'Director of Manufacturing Applications');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Karl Zumdome', 'kzumdome', 4, 'Director of Customer & Ordering Systems');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Andrew Gould', 'agould', 5, 'Manager of Data Services');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Cory Blythe', 'cblythe', 5, 'Database Architect');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Jake Campbell', 'jcampbell', 5, 'Junior Database Administrator');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Matt Cherwin', 'mcherwin', 5, 'Database Administrator');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Mindy Thomas', 'mthomas1', 5, 'Database Administrator');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Ben Kuenster', 'bkuenster', 6, 'Manager of Global Support Services');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Aaron Etscheidt', 'aetscheidt', 6, 'Support Specialist');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Laura Kraemer', 'lkraemer', 6, 'Support Technician');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Tammy Peterson', 'tpeterson', 6, 'Support Technician');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Andy Klimesh', 'aklimesh', 6, 'Support Technician');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Justin Shay', 'jshay', 7, 'Manager of Enterprise Infrastructure');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Duane Alter', 'dalter', 7, 'Linux Systems Administrator');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('JP Marshall', 'jpmarshall', 7, 'Communications Systems Engineer');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Shawn Weldon', 'sweldon', 7, 'Network Engineer');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Zach Vogel', 'zvogel', 8, 'Manager of Enterprise Operations');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Nick Colvin', 'ncolvin', 8, 'Security Systems Administrator');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Chad Dotterer', 'cdotterer', 8, 'Systems Administrator');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Gordon Guy', 'gguy', 8, 'Systems Administrator');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Mark Schebel', 'mschebel', 9, 'Manager of Software Development');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Ethan Hendrickson', 'ehendrickson', 9, 'Applications Developer');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Narendra Maharjan', 'nmaharjan', 9, 'Senior Applications Developer');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Chris Pitzen', 'cpitzen', 9, 'Senior Applications Developer');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Eric Borman', 'eborman', 10, 'Manager of Software Development');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Mercury Cagley', 'mcagley', 10, 'Applications Developer');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Wally Hynds', 'whynds', 10, 'Senior Software Developer');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('TC Smith', 'tcsmith', 10, 'Senior Applications Developer');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Joe Volker', 'jvolker', 10, 'Senior Applications Developer');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Tommy Harris', 'tomharris', 11, 'Manager of Software Development - SYB');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Colin Benson', 'cbenson', 11, 'Software Developer');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Eric Bingham', 'ebingham', 11, 'Software Developer');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Michael Thompson', 'mthompson2', 11, 'Software Developer');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Ryan Wilson', 'rwilson', 11, 'Senior Software Developer');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Dan Rose', 'drose', 12, 'Manager of Developer Operations - Infrastructure');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Constantine Bristow', 'cbristow', 12, 'Senior Applications Developer');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Greg Mitch', 'gmithc', 12, 'Software Developer');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Rick Whitaker', 'rwhitaker', 12, 'Senior Applications Developer');
INSERT INTO dbo.Associate (Name, LoginName, DepartmentId, Title) VALUES ('Andrew Willhoit', 'awhillhoit', 12, 'Applications Developer');