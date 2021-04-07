CREATE TABLE dbo.Department
(
    DepartmentId INT NOT NULL IDENTITY(1,1),
    Name VARCHAR(50) NOT NULL
);
ALTER TABLE dbo.Department ADD CONSTRAINT PK_Department_DepartmentId PRIMARY KEY CLUSTERED (DepartmentId);

INSERT INTO dbo.Department ('Information Technology');
INSERT INTO dbo.Department ('Enterprise Infrastructure');
INSERT INTO dbo.Department ('Manufacturing Applications');
INSERT INTO dbo.Department ('Customer and Ordering Systems');
INSERT INTO dbo.Department ('Data Services');
INSERT INTO dbo.Department ('Gblobal Support Services');
INSERT INTO dbo.Department ('Enterprise Infrastructure');
INSERT INTO dbo.Department ('Enterprise Operations');

INSERT INTO dbo.Department ('Software Development - ');
INSERT INTO dbo.Department ('Software Development - ');
INSERT INTO dbo.Department ('Software Development - SYB');
INSERT INTO dbo.Department ('Development Operations - Infrastructure');

SELECT *
FROM dbo.Department AS d

SELECT Name
FROM dbo.Department AS d
ORDER BY d.Name


CREATE TABLE dbo.DepartmentLink
(
    DepartmentLinkId INT NOT NULL IDENTITY(1,1),
    ParentDepartmentId INT NOT NULL,
    ChildDepartmentId INT NOT NULL,
);
ALTER TABLE dbo.DepartmentLink ADD CONSTRAINT PK_DepartmentLink_DepartmentLinkId PRIMARY KEY CLUSTERED (DepartmentLinkId);
ALTER TABLE dbo.DepartmentLink ADD CONSTRAINT FK_DepartmentLink_Department_ParentDepartmentId FOREIGN KEY (ParentDepartmentId) REFERENCES Department(DepartmentId);
ALTER TABLE dbo.DepartmentLink ADD CONSTRAINT FK_DepartmentLink_Department_ChildDepartmentId FOREIGN KEY (ChildDepartmentId) REFERENCES Department(DepartmentId);

INSERT INTO dbo.DepartmentLink (1, 2);
INSERT INTO dbo.DepartmentLink (1, 3);
INSERT INTO dbo.DepartmentLink (1, 4);
INSERT INTO dbo.DepartmentLink (2, 5);
INSERT INTO dbo.DepartmentLink (2, 6);
INSERT INTO dbo.DepartmentLink (2, 7);
INSERT INTO dbo.DepartmentLink (2, 8);

SELECT *
FROM dbo.DepartmentLink AS dl

SELECT *
FROM dbo.DepartmentLink AS dl
JOIN dbo.Department AS pd ON dl.ParentDepartmentId = pd.DepartmentId
JOIN dbo.Department AS cd ON dl.ChildDepartmentId = cd.DepartmentId


CREATE TABLE dbo.Associate
(
    AssociateId INT NOT NULL IDENTITY(1,1),
    Name VARCHAR(50) NOT NULL,
    LoginName VARCHAR(50) NOT NULL,
    DepartmentId INT NOT NULL,
);
ALTER TABLE dbo.Associate ADD CONSTRAINT PK_Associate_AssociateId PRIMARY KEY CLUSTERED (AssociateId);
ALTER TABLE dbo.Associate ADD CONSTRAINT FK_Associate_DepartmentId FOREIGN KEY (DepartmentId) REFERENCES Department (DepartmentId);

INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('Jon Hall', 'jonhall', 1);
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('Rob Frees', 'rfrees', 2);
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('Phil Parent', 'pparent', 3);
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('Karl Zumdome', 'kzumdome', 4);
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('Andrew Gould', 'agould', 5);
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('Cory Blythe', 'cblythe', 5);
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('Jake Campbell', 'jcampbell', 5);
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('Matt Cherwin', 'mcherwin', 5);
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('Mindy Thomas', 'mthomas1', 5);
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('Ben Kuenster', 'bkuenster', 6);
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('Aaron Etscheidt', 'aetscheidt', 6);
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('Laura Kraemer', 'lkraemer', 6);
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('Tammy Peterson', 'tpeterson', 6);
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('Andy Klimesh', 'aklimesh', 6);
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('Justin Shay', 'jshay', 7);
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('Duane Alter', 'dalter', 7);
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('JP Marshall', 'jpmarshall', 7);
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('Shawn Weldon', 'sweldon', 7);
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('Zach Vogel', 'zvogel', 8);
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('Nick Colvin', 'ncolvin', 8);
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('Chad Dotterer', 'cdotterer', 8);
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('Gordon Guy', 'gguy', 8);

INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('', '', );
INSERT INTO dbo.Associate (Name, EmailAddress) VALUES ('', '', );