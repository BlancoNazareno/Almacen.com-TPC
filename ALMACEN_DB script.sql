
create table MARCA(
ID varchar(10) not null primary key,
Descripcion varchar(50) not null,
)

create table PROVEEDOR(
ID varchar(10) not null primary key,
Descripcion varchar(50) not null,
CUIT varchar(15) null check (not CUIT like '%[^0-9]%'),
Telefono varchar(20) null check (not Telefono like '%[^0-9]%'),
Mail varchar(100) null,
)

create table PRODUCTO(
ID varchar(10) not null primary key,
Descripcion varchar(50) not null,
ID_Marca varchar(10) not null foreign key references MARCA(ID),
ID_Proveedor varchar(10) not null foreign key references PROVEEDOR(ID),
Precio_Compra money not null check (Precio_Compra > 0),
Precio_Venta money not null check (Precio_Venta > 0  and  Precio_Venta > Precio_Compra),
Stock_Minimo int not null check (Stock_Minimo >= 0),
)

create table VENDEDOR(
ID varchar(10) not null primary key,
Nombre_Apellido varchar(100) not null,
DNI varchar(10) null Check (not DNI like '%[^0-9]%'),
Telefono varchar(20) null check (not Telefono like '%[^0-9]%'),
Nivel_Permiso tinyint not null,
)

create table CLIENTE(
ID varchar(10) not null primary key,
Nombre_Apellido varchar(100) not null,
DNI varchar(10) null Check (not DNI like '%[^0-9]%'),
Telefono varchar(20) null check (not Telefono like '%[^0-9]%'),
)

create table STOCK(
ID_Producto varchar(10) not null primary key foreign key references PRODUCTO(ID),
Cantidad_Stock int not null check (Cantidad_Stock >= 0),
)

create table MOVIMIENTO_MERCADERIA(
ID int identity(001,1) not null primary key,
ID_Vendedor varchar(10) not null foreign key references VENDEDOR(ID),
ID_Producto varchar(10) not null foreign key references PRODUCTO(ID),
Cantidad_Producto int not null check(Cantidad_Producto > 0),
Fecha date not null check(Fecha<=getdate()) default(getdate()),
Observacion varchar(100) null,
Sentido_Movimiento bit not null, 
)

create table VENTA(
ID int identity(001,1) not null primary key,
ID_Vendedor varchar(10) not null foreign key references VENDEDOR(ID),
ID_Cliente varchar(10) not null foreign key references CLIENTE(ID),
ID_Producto varchar(10) not null foreign key references PRODUCTO(ID),
Cantidad_Producto int not null check(Cantidad_Producto > 0),
Monto_Facturado money not null check(Monto_Facturado > 0),
Monto_Ganancia money not null check(Monto_Ganancia > 0),
Fecha date not null check(Fecha<=getdate()) default(getdate()),
Observacion varchar(100) null,
Sentido_Movimiento bit not null,
)

create table CAJA(
ID int identity(001,1) not null primary key,
Monto_Facturado money not null check(Monto_Facturado > 0),
Monto_Ganancia money not null check(Monto_Ganancia > 0),
)

create table CAJA_HISTORICO(
ID int identity(001,1) not null primary key,
Monto_Facturado money not null check(Monto_Facturado > 0),
Monto_Ganancia money not null check(Monto_Ganancia > 0),
Fecha date not null check(Fecha<=getdate()) default(getdate()),
)