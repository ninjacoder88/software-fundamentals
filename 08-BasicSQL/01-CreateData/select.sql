/*get all rows and all columns from department*/
SELECT *
FROM dbo.Department AS d

/*get all department names from department, order them by name*/
SELECT Name
FROM dbo.Department AS d
ORDER BY d.Name

/*get all rows and all columns from department link*/
SELECT *
FROM dbo.DepartmentLink AS dl

/*get all rows and all columns from department link, joining to department for each value*/
SELECT *
FROM dbo.DepartmentLink AS dl
JOIN dbo.Department AS pd ON dl.ParentDepartmentId = pd.DepartmentId
JOIN dbo.Department AS cd ON dl.ChildDepartmentId = cd.DepartmentId

/*get the child department name where the parent is 1*/
SELECT cd.Name
FROM dbo.DepartmentLink AS dl
JOIN dbo.Department AS pd ON dl.ParentDepartmentId = pd.DepartmentId
JOIN dbo.Department AS cd ON dl.ChildDepartmentId = cd.DepartmentId
WHERE pd.DepartmentId = 1

/*get all associates whose title has developer*/
SELECT *
FROM dbo.Associate AS a
WHERE a.Title LIKE '%Developer%'


SELECT a.Title, COUNT(a.Name)
FROM dbo.Associate AS a
WHERE a.Title LIKE '%Developer%'
GROUP BY a.Title
HAVING COUNT(a.Name) > 1

SELECT *, RANK() OVER (PARTITION BY a.Title ORDER BY a.Name)
FROM dbo.Associate AS a
WHERE a.Title LIKE '%Develop%'