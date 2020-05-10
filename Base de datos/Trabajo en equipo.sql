
create database if not exists trabajo;
use trabajo;

create table empleado (
cedula int(9) not null,
pNom varchar(25) not null,
sNom varchar(25),
pApe varchar (25) not null,
sApe varchar (25) not null,
sueldoTotal int not null,
primary key (cedula)
) engine = innodb;

create table administrativo (
cedula int(9) not null,
incentivo int not null,
constraint fk_emp_Administrativo foreign key (cedula) references empleado (cedula)
) engine = innodb;

create table operario (
cedula int(9) not null,
cantHoras tinyint not null,
precioHora int not null,
constraint fk_emp_Operario foreign key (cedula) references empleado (cedula)
) engine = innodb;

create table gerente (
cedula int(9) not null,
nivel tinyint not null,
constraint fk_emp_Gerente foreign key (cedula) references empleado (cedula)
) engine = innodb;