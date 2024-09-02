USE ManaosMarketSof;

CREATE TABLE Empleado(
	idEmpleado VARCHAR(6) NOT NULL PRIMARY KEY,
	nombres VARCHAR(50) NOT NULL,
	apellPaterno VARCHAR(50) NOT NULL,
	apellMaterno VARCHAR(50) NOT NULL,
	DNI VARCHAR(8) NOT NULL,
	genero CHAR(1) NOT NULL,
	fechaNacimiento DATE NOT NULL,
	telefono CHAR(9) NOT NULL,
	direccion VARCHAR(50) NOT NULL,
	correo VARCHAR(50) NOT NULL,
	vigente BIT NOT NULL,
 );

 CREATE TABLE Asistencia(
	idAsistencia SMALLINT NOT NULL PRIMARY KEY,
	estado BIT NOT NULL,
	fecha DATE NOT NULL,
	horaLlegada TIME NOT NULL,
	horaSalida TIME NOT NULL,
	idEmpleado VARCHAR(6) NOT NULL FOREIGN KEY
 );

 SELECT * FROM Usuario;

 INSERT INTO Usuario VALUES('Linder Casas Martinez','adminLinder','123456');


 select * from Area;
 INSERT INTO Area VALUES('RRHH','El area de Recursos Humanos es ',1);