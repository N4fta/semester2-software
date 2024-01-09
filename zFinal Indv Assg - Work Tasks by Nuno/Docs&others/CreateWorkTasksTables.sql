create table Departments(
department nvarchar(50) not null,
department_id tinyint not null,
constraint PK_Departments primary key(department_id)
);

create table Employees(
id int not null,
ssn nvarchar(50) null,
first_name nvarchar(50) null,
last_name nvarchar(50) null,
gender nvarchar(50) null,
street_name nvarchar(50) null,
street_number int null,
zipcode nvarchar(50) null,
city nvarchar(50) null,
email nvarchar(50) not null,
department_id tinyint null,
[password] nvarchar(50) null default '12345',
[admin] bit null default 0,

constraint PK_Employees primary key(id),
constraint FK_Employees_Departments foreign key(department_id)
	references Departments(department_id)
);

insert into Departments(department_id, department)
values (0, 'All'), (1, 'Open'), (2, 'InProgress'), (3, 'Completed'), (4, 'Blocked'), (5, 'Cancelled');

create table Statuses(
[status] nvarchar(50) not null,
status_id tinyint not null,
constraint PK_Statuses primary key(status_id)
);

create table Tasks(
id int not null,
title nvarchar(100) not null,
status_id tinyint not null,
deadline nvarchar(50) null,
[description] nvarchar(1200) null,

constraint PK_Tasks primary key(id),
constraint FK_Tasks_Statuses foreign key(status_id)
	references Statuses(status_id)
);

create table Tasks_Departments(
task_id int not null,
department_id tinyint not null,
constraint FK_Tasks_Department foreign key(task_id)
	references Tasks(id),
constraint FK_Department_Tasks foreign key(department_id)
	references Departments(department_id)
);

create table Tasks_Employees(
task_id int not null,
employees_id int not null,
constraint FK_Tasks_Employees foreign key(task_id)
	references Tasks(id),
constraint FK_Employees_Tasks foreign key(employees_id)
	references Employees(id)
);
