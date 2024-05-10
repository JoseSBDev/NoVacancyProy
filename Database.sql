drop database Hotel;
create database Hotel;
use Hotel;

-- Creación de la tabla Rol
CREATE TABLE Rol (
    id_rol INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50)
);

-- Creación de la tabla Usuario
CREATE TABLE Usuario (
    id_usuario INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50),
    email VARCHAR(100),
    contrasena VARCHAR(100),
    id_rol INT,
    FOREIGN KEY (id_rol) REFERENCES Rol(id_rol)
);

-- Creación de la tabla Habitación
CREATE TABLE Habitacion (
    id_habitacion INT AUTO_INCREMENT PRIMARY KEY,
    numero_habitacion INT,
    tipo VARCHAR(50),
    estado VARCHAR(50),
    precio DOUBLE
);

-- Creación de la tabla Cliente
CREATE TABLE Cliente (
    id_cliente INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100),
    telefono VARCHAR(20),
    email VARCHAR(100) unique
);

-- Creación de la tabla Reserva
CREATE TABLE Reserva (
    id_reserva INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT,
    id_habitacion INT,
    fecha_inicio DATE,
    fecha_fin DATE,
    precio_reserva DECIMAL(10,2),
    id_revision INT DEFAULT(0),
    FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente),
    FOREIGN KEY (id_habitacion) REFERENCES Habitacion(id_habitacion)
);

-- Creación de la tabla Factura
CREATE TABLE Factura (
    id_factura INT AUTO_INCREMENT PRIMARY KEY,
    id_reserva INT,
    total DECIMAL(10,2),
    fecha_emision DATE,
    FOREIGN KEY (id_reserva) REFERENCES Reserva(id_reserva)
);

-- Creación de la tabla Producto
CREATE TABLE Producto (
    id_producto INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100),
    precio DECIMAL(10,2)
);

-- Creación de la tabla Inventario
CREATE TABLE Inventario (
    id_inventario INT AUTO_INCREMENT PRIMARY KEY,
    id_producto INT,
    cantidad INT,
    stock_minimo INT,
    FOREIGN KEY (id_producto) REFERENCES Producto(id_producto)
);

-- Creación de la tabla Limpieza
CREATE TABLE Limpieza (
    id_limpieza INT AUTO_INCREMENT PRIMARY KEY,
    id_habitacion INT,
    fecha DATE,
    descripcion VARCHAR(255),
    estado VARCHAR(50),
    FOREIGN KEY (id_habitacion) REFERENCES Habitacion(id_habitacion)
);

-- Creación de la tabla Mantenimiento
CREATE TABLE Mantenimiento (
    id_mantenimiento INT AUTO_INCREMENT PRIMARY KEY,
    id_habitacion INT,
    descripcion VARCHAR(255),
    fecha DATE,
    estado VARCHAR(50) default 'En espera',
    FOREIGN KEY (id_habitacion) REFERENCES Habitacion(id_habitacion)
);

-- Creación de la tabla ProductosDeLaReserva
CREATE TABLE ProductosDeLaReserva (
    id_producto_de_reserva INT AUTO_INCREMENT PRIMARY KEY,
    id_reserva INT,
    id_producto INT,
    cantidad INT,
    FOREIGN KEY (id_reserva) REFERENCES Reserva(id_reserva),
    FOREIGN KEY (id_producto) REFERENCES Producto(id_producto)
);