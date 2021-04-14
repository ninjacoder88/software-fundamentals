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

