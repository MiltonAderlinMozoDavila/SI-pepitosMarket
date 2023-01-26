/* Activar Base de datos DBMarket*/
USE DBMarket
GO

/* Crear Tipos  */
CREATE TYPE tCodProducto FROM varchar(12) NOT NULL;
GO

CREATE TYPE tIDPersona FROM varchar(8) NOT NULL;
GO

CREATE TYPE tIDEmpleado FROM varchar(8) NOT NULL;
GO

CREATE TYPE tIDCliente FROM varchar(8) NOT NULL;
GO

CREATE TYPE tIDComprobante FROM varchar(8) NOT NULL;
GO

CREATE TYPE tIDBoleta FROM varchar(8) NOT NULL;
GO

CREATE TYPE tIDFactura FROM varchar(8) NOT NULL;
GO

CREATE TYPE tIDVenta FROM varchar(8) NOT NULL;
GO
CREATE TYPE tID_DetalleVenta FROM varchar(8) NOT NULL;
GO

CREATE TYPE tIDCaja FROM varchar(8) NOT NULL;
GO


