CREATE DATABASE Vivero

/* Creacion de tablas */

CREATE TABLE TipoDoc (ID INT,
						Descripcion VARCHAR(20),
						CONSTRAINT id_tipoDoc_pk PRIMARY KEY(ID))

CREATE TABLE TipoPlanta (ID INT,
						Nombre VARCHAR(30),
						Descripcion VARCHAR(30),
						CONSTRAINT id_tipoPlanta_pk PRIMARY KEY (ID))

CREATE TABLE TipoProducto (ID INT,
							Nombre VARCHAR(30),
							Descripcion VARCHAR(30),
							CONSTRAINT id_tipoProducto_pk PRIMARY KEY (ID))

CREATE TABLE Plantas(Codigo INT, 
					NombreCientifico VARCHAR(20), 
					NombreComun VARCHAR(20), 
					Tipo VARCHAR(20), 
					Precio DECIMAL, 
					Stock INT,
					CONSTRAINT id_planta_nombre_pk PRIMARY KEY (Codigo, NombreCientifico))

CREATE TABLE Producto(Codigo INT, 
					Nombre VARCHAR(20), 
					Tipo VARCHAR(20), 
					Stock INT, 
					Costo DECIMAL, 
					Precio DECIMAL,
					Composicion VARCHAR(40),
					CONSTRAINT id_Producto_pk PRIMARY KEY (Codigo))

CREATE TABLE Barrio (ID INT,
					Nombre VARCHAR(30),
					CONSTRAINT id_barrio_pc PRIMARY KEY (ID))

CREATE TABLE Localidad (ID INT,
						Nombre varchar(30),
						CONSTRAINT id_Localidad_pc PRIMARY KEY (ID))

CREATE TABLE Proveedor (ID INT,
						Nombre VARCHAR (20),
						Calle VARCHAR(20),
						Nro_Calle INT,
						Barrio INT,
						Localidad INT,
						Telefono VARCHAR(30),
						Razon_Social VARCHAR(50),
						CONSTRAINT id_proveedor_pk PRIMARY KEY(ID),
						CONSTRAINT barrio_fk FOREIGN KEY (Barrio) REFERENCES Barrio(ID))

CREATE TABLE Cliente	(TipoDoc INT,
						NroDoc VARCHAR(30),
						Nombre VARCHAR(30),
						Apellido VARCHAR(30),
						Calle VARCHAR(30),
						NroCalle INT,
						Barrio INT,
						Localidad INT,
						Telefono VARCHAR(30),
						Email VARCHAR(30),
						CONSTRAINT id_cliente_pk PRIMARY KEY (TipoDoc, NroDoc),
						CONSTRAINT tipoDoc_fk FOREIGN KEY (TipoDoc) REFERENCES TipoDoc(ID),
						CONSTRAINT id_barrio_fk FOREIGN KEY (Barrio) REFERENCES Barrio(ID),
						CONSTRAINT id_localidad_fk FOREIGN KEY (Localidad) REFERENCES Localidad(ID))

CREATE TABLE Empleado (ID INT,
					   Nombre VARCHAR(30),
					   Apellido VARCHAR(30),
					   Telefono VARCHAR(30),
					   Calle VARCHAR(30),
					   Nro_Calle INT,
					   Barrio INT,
					   Localidad INT,
					   Contraseña VARCHAR(30),
					   CONSTRAINT id_empleado_pk PRIMARY KEY (ID),
					   CONSTRAINT barrio_empleado_fk FOREIGN KEY (Barrio) REFERENCES Barrio(ID),
					   CONSTRAINT localidad_empleado_fk FOREIGN KEY (Localidad) REFERENCES Localidad(ID))

CREATE TABLE Factura (Tipo_Factura VARCHAR(15),
					  Nro_Factura INT,
					  TipoDoc INT,
					  NroDoc VARCHAR(30),
					  Fecha DATE,
					  Id_Empleado INT,
					  CONSTRAINT id_factura_pk PRIMARY KEY (Tipo_Factura, Nro_Factura),
					  CONSTRAINT doc_factura_fk FOREIGN KEY (TipoDoc, NroDoc) REFERENCES Cliente(TipoDoc, NroDoc))

CREATE TABLE Puntos (TipoDoc INT,
					NroDoc VARCHAR(30),
					Nro_Factura INT,
					Tipo_Factura VARCHAR(15),
					Cantidad INT,
					Fecha DATE,
					CONSTRAINT id_puntos_pk PRIMARY KEY (TipoDoc, NroDoc, Nro_Factura,Tipo_Factura),
					CONSTRAINT doc_puntos_fk FOREIGN KEY (TipoDoc, NroDoc) REFERENCES Cliente(TipoDoc, NroDoc),
					CONSTRAINT puntos_factura_fk FOREIGN KEY (Tipo_Factura, Nro_Factura) REFERENCES Factura(Tipo_Factura, Nro_Factura))

CREATE TABLE Composicion (Cod_Prod_Compuesto INT,
						  Cod_Prod_Componente INT,
						  Cant_Compuesto INT,
						  Cant_Componente INT,
						  CONSTRAINT cod_prod_comp_compuesto_pk PRIMARY KEY (Cod_Prod_Compuesto, Cod_Prod_Componente),
						  CONSTRAINT cod_prod_comp_fk FOREIGN KEY (Cod_Prod_Compuesto) REFERENCES Producto (Codigo),
						  CONSTRAINT cod_prod_Componente_fk FOREIGN KEY (Cod_Prod_Componente) REFERENCES Producto (Codigo))

CREATE TABLE Catalogo (ID INT,
						Id_Planta INT,
						NombreCientifico VARCHAR(20),
						Puntos_Necesarios INT,
						CONSTRAINT id_Catalogo_pk PRIMARY KEY (ID, Id_Planta, NombreCientifico),
						CONSTRAINT id_planta_catalogo_fk FOREIGN KEY (Id_Planta, NombreCientifico) REFERENCES Plantas(Codigo,NombreCientifico))

CREATE TABLE DetalleFactura (Tipo_Factura VARCHAR(15),
							 Nro_Factura INT,
							 Cantidad INT,
							 Precio DECIMAL,
							 CONSTRAINT detalle_Factura_pk PRIMARY KEY (Tipo_Factura, Nro_Factura),
							 CONSTRAINT detalle_Factira_fk FOREIGN KEY (Tipo_Factura, Nro_Factura) REFERENCES Factura(Tipo_Factura, Nro_Factura))

CREATE TABLE Canje (ID INT,
					TipoDoc INT,
					NroDoc VARCHAR(30),
					Id_Catalogo INT,
					Id_Planta INT,
					NombreCientifico VARCHAR(20),
					Fecha DATE,
					Puntos_a_Restar INT,
					CONSTRAINT canje_pk PRIMARY KEY (ID, TipoDoc, NroDoc, Id_Catalogo, Id_Planta, NombreCientifico,Fecha),
					CONSTRAINT canje_cliente_fk FOREIGN KEY (TipoDoc, NroDoc) REFERENCES Cliente(TipoDoc, NroDoc),
					CONSTRAINT canje_productos_fk FOREIGN KEY (Id_Catalogo, Id_Planta, NombreCientifico) REFERENCES Catalogo(ID, Id_Planta, NombreCientifico)) 
					    

