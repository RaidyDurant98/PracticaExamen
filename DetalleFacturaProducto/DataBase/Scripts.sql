create table Facturas(
FacturaId int identity(1,1) primary key,
Fecha date,
Producto varchar(100),
ProductoId int,
Costo float,
Precio float,
Importe float
);

create table Productos(
ProductoId int identity(1,1) primary key,
Descripcion varchar(100),
Costo float,
Precio Float,
);

create table FacturasProductos(
FacturaProductoId int identity(1,1) primary key,
FacturaId int,
ProductoId int
);
