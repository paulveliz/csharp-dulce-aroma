CREATE TABLE cEmpleadoNivel(
    id int primary key identity(1,1),
    descripcion varchar(10) not null
)
CREATE TABLE cEmpleadoEstatus(
    id int primary key identity(1,1),
    descripcion varchar(10) not null
)

CREATE TABLE Empleados(
    id int primary key identity(1,1),
    nombre_completo varchar(100) not null,
    nombre_usuario varchar(25) not null,
    pass varchar(18) not null,
    idNivel int not null,
    idEstatus int not null,
    FOREIGN KEY (idnivel) REFERENCES cEmpleadoNivel(id),
    FOREIGN KEY (idestatus) REFERENCES cEmpleadoEstatus(id)
)

--- Turnos implementados
CREATE TABLE cTurnoEstatus(
    id int primary key identity(1,1),
    descripcion varchar(10) not null
)

CREATE TABLE Turnos(
    id int primary key identity(1,1),
    idEmpleado int not null,
    fecha date not null,
    hora  time(7) not null,
    idEstatus int not null,
    FOREIGN KEY (idEstatus) REFERENCES cTurnoEstatus(id),
    FOREIGN KEY (idEmpleado) REFERENCES Empleados(id)
)

CREATE TABLE cVentaEstatus(
    id int primary key identity(1,1),
    descripcion varchar(10) not null
)

CREATE TABLE Ventas(
    id int primary key identity(1,1),
    idTurno int not null, -- added 08/02
    idEmpleado int not null,
    fecha date not null,
    hora  time(7) not null,
    importe  numeric(10,2) not null,
    idEstatus int not null,
    FOREIGN KEY (idEstatus) REFERENCES cVentaEstatus(id),
    FOREIGN KEY (idTurno) REFERENCES Turnos(id),
    FOREIGN KEY (idEmpleado) REFERENCES Empleados(id)
)

CREATE TABLE cProveedorEstatus(
    id int primary key identity(1,1),
    descripcion varchar(10) not null
)

CREATE TABLE Proveedores(
    id int primary key identity(1,1),
    nombre varchar(35) not null,
    idEstatus int not null,
    FOREIGN KEY (idEstatus) REFERENCES cProveedorEstatus(id)
)

CREATE TABLE cProductoEstatus(
    id int primary key identity(1,1),
    descripcion varchar(10) not null
)

CREATE TABLE Productos(
    id int primary key identity(1,1),
    nombre varchar(50) not null,
    codigo varchar(50) not null,
    precio numeric(7,2) not null,
    costo numeric(7,2) not null,
    existencias int not null,
    fecha date not null,
    hora  time(7) not null,
    idProveedor int not null,
    idEstatus int not null,
    FOREIGN KEY (idEstatus) REFERENCES cProductoEstatus(id),
    FOREIGN KEY (idProveedor) REFERENCES Proveedores(id)
)

CREATE TABLE Detalle_Ventas(
    id int primary key identity(1,1),
    idVenta int not null,
    idProducto int not null,
    cantidad int not null,
    precio numeric(7,2) not null,
    costo numeric(7,2) not null,
    importe numeric(10,2) not null,
    FOREIGN KEY (idVenta) REFERENCES Ventas(id),
    FOREIGN KEY (idProducto) REFERENCES Productos(id)
)

CREATE TABLE cEntradaEstatus(
    id int primary key identity(1,1),
    descripcion varchar(10) not null
)

CREATE TABLE Entradas(
    id int primary key identity(1,1),
    idEmpleado int not null,
    fecha date not null,
    hora  time(7) not null,
    importe  numeric(10,2) not null,
    idProveedor int not null,
    idEstatus int not null,
    FOREIGN KEY (idEstatus) REFERENCES cEntradaEstatus(id),
    FOREIGN KEY (idProveedor) REFERENCES Proveedores(id)
    FOREIGN KEY (idEmpleado) REFERENCES Empleados(id)
)

CREATE TABLE Detalle_Entradas(
    id int primary key identity(1,1),
    idEntrada int not null,
    idProducto int not null,
    cantidad int not null,
    precio numeric(7,2) not null,
    costo numeric(7,2) not null,
    importe numeric(10,2) not null,
    FOREIGN KEY (idEntrada) REFERENCES Entradas(id),
    FOREIGN KEY (idProducto) REFERENCES Productos(id)
)