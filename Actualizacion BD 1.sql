DROP TABLE Empleado

CREATE TABLE Empleado (ID INT
					  CONSTRAINT ID NOT NULL,
					   Nombre VARCHAR(30)
					   CONSTRAINT Nombre NOT NULL,
					   Apellido VARCHAR(30)
					   CONSTRAINT Apellido NOT NULL,
					   Telefono VARCHAR(30),
					   Calle VARCHAR(30)
					   CONSTRAINT Calle NOT NULL,
					   Nro_Calle INT
					   CONSTRAINT Nro_Calle NOT NULL,
					   Barrio INT
					   CONSTRAINT Barrio NOT NULL,
					   Localidad INT
					   CONSTRAINT Localidad NOT NULL,
					   Contraseña VARCHAR(30)
					   CONSTRAINT Contraseña NOT NULL,
					   Estado INT
					   CONSTRAINT Estado NOT NULL,
					   CONSTRAINT id_empleado_pk PRIMARY KEY (ID),
					   CONSTRAINT barrio_empleado_fk FOREIGN KEY (Barrio) REFERENCES Barrio(ID),
					   CONSTRAINT localidad_empleado_fk FOREIGN KEY (Localidad) REFERENCES Localidad(ID),
					   CONSTRAINT estado_empleado_fk FOREIGN KEY (Estado) REFERENCES Estado(ID))

INSERT INTO Empleado VALUES (1,'Agustin','Hadad','3512495352','Vigo',2190,3,1,'123',1),
							(2,'Facundo','Chiarini','3515467890','Maipu',194,4,3,'321',1),
							(3,'Gio','Marandino','3515352351','Nuñez',2190,2,2,'456',1)