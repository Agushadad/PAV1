DROP TABLE Proveedor

CREATE TABLE Proveedor (ID INT
					  CONSTRAINT ID NOT NULL,
					   Nombre VARCHAR(30)
					   CONSTRAINT Nombre NOT NULL,
					   Calle VARCHAR(30)
					   CONSTRAINT Calle NOT NULL,
					   Nro_Calle INT
					   CONSTRAINT Nro_Calle NOT NULL,
					   Barrio INT
					   CONSTRAINT Barrio NOT NULL,
					   Localidad INT
					   CONSTRAINT Localidad NOT NULL,
					   Telefono VARCHAR(30),
					   Razon_Social VARCHAR(80)
					   CONSTRAINT Razon_Social NOT NULL,
					   Estado INT
					   CONSTRAINT Estado NOT NULL,
					   CONSTRAINT id_Proveedor_pk PRIMARY KEY (ID),
					   CONSTRAINT barrio_Proveedor_fk FOREIGN KEY (Barrio) REFERENCES Barrio(ID),
					   CONSTRAINT localidad_Proveedor_fk FOREIGN KEY (Localidad) REFERENCES Localidad(ID),
					   CONSTRAINT estado_Proveedor_fk FOREIGN KEY (Estado) REFERENCES Estado(ID))

INSERT INTO Proveedor VALUES (1,'TerraFertil','Olmos',194,4,1,'4271421','Venta al x mayor de tierra',1),
							 (2,'AgroFy','Revolucion de mayo',300,3,2,'4277821','Venta al x mayor de fertilizantes',1),
							 (3,'Emporio de la maceta','Av Rafael Nuñez',500,5,3,'4271746','Venta al x mayor de macetas',1)