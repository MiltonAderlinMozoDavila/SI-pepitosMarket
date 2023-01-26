/* Activar Base de datos DBMarket*/
USE DBMarket
GO

/* CREAR TABLAS */

-- Crear tabla productos
CREATE TABLE Producto(
	CodigoProducto	tCodProducto	NOT NULL,
	Nombre			varchar(100)	NOT NULL,
	Descripcion		varchar(120)	NOT NULL,
	UnidadMedida	varchar(3)		NOT NULL,
	Precio			numeric(10,2)	NOT NULL,
	Stock			numeric(15,6)	NOT NULL,
	FechaCaducidad	date NOT NULL,

	PRIMARY KEY (CodigoProducto),
    --CodProveedor	varchar(12) NOT NULL,
    --FOREIGN KEY (CodProveedor) REFERENCES Proveedores(CodProveedor),
	)
	GO

-- Crear tabla persona
CREATE TABLE Persona (
    IDPersona		tIDPersona NOT NULL,
    Nombres VARCHAR(255),
    ApellidoPaterno VARCHAR(255)	NOT NULL,
	ApellidoMaterno VARCHAR(255)	NOT NULL,
	Edad	int,
	Sexo VARCHAR(1),
	PRIMARY KEY (IDPersona)
	);

-- Crear tabla Empleado
CREATE TABLE Empleado (
    IDEmpleado		tIDEmpleado NOT NULL,
    IDPersona		tIDPersona NOT NULL,
    Cargo VARCHAR(255) NOT NULL,
    Salario DECIMAL(10,2) NOT NULL,
	PRIMARY KEY (IDEmpleado),
    FOREIGN KEY (IDPersona) REFERENCES Persona(IDPersona)
);

-- Crear tabla cliente
CREATE TABLE Cliente (
    IDCliente		tIDCliente NOT NULL,
    IDPersona		tIDPersona NOT NULL,
    Fecha_registro DATE NOT NULL,
	PRIMARY KEY (IDCliente),
    FOREIGN KEY (IDPersona) REFERENCES Persona(IDPersona)
);
-- Crear tabla Comprobante
CREATE TABLE Comprobante (
    IDComprobante		tIDComprobante NOT NULL,
    FechaEmision DATE NOT NULL,
    ImporteTotal DECIMAL(10,2) NOT NULL,
	RUC VARCHAR (11) NOT NULL,
	PRIMARY KEY (IDComprobante)
	);



-- Crear tabla boleta
CREATE TABLE Boleta (
    IDBoleta		tIDBoleta NOT NULL,
    IDComprobante		tIDComprobante NOT NULL,
    TipoComprobante VARCHAR(255) NOT NULL,
    IDCliente tIDCliente NOT NULL,
	PRIMARY KEY (IDBoleta),
    FOREIGN KEY (IDComprobante) REFERENCES Comprobante(IDComprobante),
    FOREIGN KEY (IDCliente) REFERENCES Cliente(IDCliente),
);

-- Crear tabla factura
CREATE TABLE Factura (
    IDFactura		tIDFactura NOT NULL,
    IDComprobante		tIDComprobante NOT NULL,
    TipoComprobante VARCHAR(12) NOT NULL,
	IDEmpleado tIDEmpleado NOT NULL,
	IDCliente tIDCliente NOT NULL,
	PRIMARY KEY (IDFactura),
	FOREIGN KEY (IDComprobante) REFERENCES Comprobante(IDComprobante),
	FOREIGN KEY (IDEmpleado) REFERENCES Empleado(IDEmpleado),
	FOREIGN KEY (IDCliente) REFERENCES Cliente(IDCliente)
);

---	Crear tabla Venta
CREATE TABLE Venta (
    IDVenta tIDVenta NOT NULL,
    FechaVenta DATE NOT NULL,
	IDEmpleado tIDEmpleado NOT NULL,
	IDCaja tIDCaja NOT NULL,
    TotalVenta DECIMAL(10,2) NOT NULL,
    IDCliente tIDCliente NOT NULL,
	PRIMARY KEY (IDVenta),
    FOREIGN KEY (IDCliente) REFERENCES Cliente(IDCliente),
	FOREIGN KEY (IDCaja) REFERENCES Caja(IDCaja),
	FOREIGN KEY (IDEmpleado) REFERENCES Empleado(IDEmpleado),
);

-- Crear tabla Detalle Venta

CREATE TABLE DetalleVenta (
    ID_DetalleVenta tID_DetalleVenta PRIMARY KEY,
    IDVenta tIDVenta NOT NULL,
    CodigoProducto tCodProducto  NOT NULL,
    cantidad INT NOT NULL,
    precio_unitario DECIMAL(10,2) NOT NULL,
    precio_total DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (IDVenta) REFERENCES Venta(IDVenta),
	FOREIGN KEY (CodigoProducto) REFERENCES Producto(CodigoProducto)
);


CREATE TABLE Caja (
    IDCaja tIDCaja PRIMARY KEY,
    numero INT NOT NULL,
    ubicacion VARCHAR(255) NOT NULL
);
DROP TABLE Venta;
