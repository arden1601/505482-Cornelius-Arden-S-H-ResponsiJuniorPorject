CREATE TABLE departemen ( 
	id_dep SERIAL PRIMARY KEY,
	nama_dep varchar(30)
);

CREATE SEQUENCE emp_id START 001;
create table karyawan(
	id_karyawan char(6) default 'EMP' || nextval('emp_id') primary key,
	nama varchar(30),
	id_dep int,
	foreign key (id_dep) references departemen (id_dep)
	 
);

insert into departemen values 
	(1, 'HR'),
	(2, 'Finance'),
	(3, 'Engineer'),
	(4, 'Developer'),
	(5, 'Product M');
