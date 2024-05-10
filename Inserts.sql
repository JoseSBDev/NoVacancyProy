use Hotel;

INSERT INTO Habitacion (numero_habitacion, tipo, estado, precio) VALUES 
(104, 'Individual', 'Disponible', 50.00),
(105, 'Doble', 'Disponible', 80.00),
(106, 'Suite', 'Disponible', 120.00),
(107, 'Familiar', 'Disponible', 100.00),
(108, 'Individual', 'Disponible', 50.00),
(109, 'Doble', 'Disponible', 80.00),
(110, 'Suite', 'Disponible', 120.00),
(111, 'Familiar', 'Disponible', 100.00),
(112, 'Individual', 'Disponible', 50.00),
(113, 'Doble', 'Disponible', 80.00);

INSERT INTO Producto (nombre, precio) VALUES 
('Cepillo de dientes', 3.00),
('Champú', 6.50),
('Gel de ducha', 4.75),
('Pasta de dientes', 2.75),
('Zapatillas', 8.00),
('Cerveza', 3.50),
('Refresco', 2.00),
('Snacks', 4.25),
('Chocolates', 1.50),
('Revistas', 2.25),
('Botella de vino', 12.00),
('Paraguas', 10.00),
('Caja de pañuelos', 2.50),
('Cargador de teléfono', 15.00),
('Kit de costura', 5.00);

INSERT INTO Cliente (nombre, telefono, email) VALUES 
('Laura Martínez', '654987321', 'laura@asd.com'),
('Carlos Rodríguez', '321654987', 'carlos@asd.com'),
('Ana López', '987321654', 'ana@asd.com'),
('Pedro Sánchez', '789456123', 'pedro@asd.com'),
('Sofía García', '456123789', 'sofia@asd.com');

INSERT INTO Inventario (id_producto, cantidad, stock_minimo) VALUES 
(1, 75, 20),    -- Cepillo de dientes
(2, 100, 30),   -- Champú
(3, 50, 15),    -- Gel de ducha
(4, 80, 25),    -- Pasta de dientes
(5, 40, 10),    -- Zapatillas
(6, 60, 20),    -- Cerveza
(7, 100, 30),   -- Refresco
(8, 70, 25),    -- Snacks
(9, 30, 10),    -- Chocolates
(10, 20, 5),   -- Revistas
(11, 25, 8),   -- Botella de vino
(12, 15, 5),   -- Paraguas
(13, 50, 15),   -- Caja de pañuelos
(14, 10, 3),   -- Cargador de teléfono
(15, 40, 12);   -- Kit de costura

INSERT INTO hotel.rol(id_rol, nombre) VALUES 
(1, 'Administrador'),
(2, 'Gerencia'),
(3, 'Recepcion'),
(4, 'Limpieza'),
(5, 'Mantenimiento');

INSERT INTO hotel.usuario(nombre, email, contrasena, id_rol) VALUES 
('IT', 'IT@hotelimperium.com', 'admin', 1),
('Gerencia', 'gerencia@hotelimperium.com', 'admin', 2),
('Repecion', 'recepcion@hotelimperium.com', 'admin', 3),
('Limpieza', 'limpieza@hotelimperium.com', 'admin', 4),
('Mantenimiento', 'mantenimiento@hotelimperium.com', 'admin', 5);

INSERT INTO Reserva (id_cliente, id_habitacion, fecha_inicio, fecha_fin, precio_reserva) VALUES
(1, 1, '2024-05-01', '2024-05-08', 350.00), 
(2, 2, '2024-06-15', '2024-06-22', 560.00), 
(3, 3, '2024-07-10', '2024-07-17', 840.00), 
(4, 4, '2024-08-03', '2024-08-10', 600.00), 
(5, 5, '2024-09-22', '2024-09-29', 300.00), 
(1, 6, '2024-10-11', '2024-10-18', 480.00), 
(2, 7, '2024-11-04', '2024-11-11', 720.00), 
(3, 8, '2024-12-15', '2024-12-22', 600.00), 
(4, 9, '2024-05-03', '2024-05-10', 300.00), 
(5, 10, '2024-06-17', '2024-06-24', 480.00), 
(1, 1, '2024-07-08', '2024-07-15', 840.00),
(2, 2, '2024-08-21', '2024-08-28', 600.00),
(3, 3, '2024-09-02', '2024-09-09', 300.00), 
(4, 4, '2024-10-30', '2024-11-06', 480.00),
(5, 5, '2024-11-17', '2024-11-24', 720.00), 
(1, 6, '2024-12-08', '2024-12-15', 600.00),
(2, 7, '2024-05-15', '2024-05-22', 300.00), 
(3, 8, '2024-06-01', '2024-06-08', 480.00), 
(4, 9, '2024-07-12', '2024-07-19', 720.00), 
(5, 10, '2024-08-09', '2024-08-16', 600.00);


INSERT INTO Mantenimiento (id_habitacion, descripcion, fecha, estado) VALUES 
(1, 'Gotea la cisterna', '2024-04-15', 'Completada'), 
(2, 'Cambio de bombilla', '2024-04-16', 'En espera'), 
(3, 'Pomo del servicio no funciona', '2024-04-17', 'En espera'), 
(4, 'Revisión de aire acondicionado, huele mal y gotea', '2024-04-18', 'En espera'), 
(5, 'Arreglar desconchón de la pared', '2024-04-19', 'En progreso');

INSERT INTO Limpieza (id_habitacion, fecha, descripcion, estado) VALUES
(1, '2024-04-15', 'Limpieza completa', 'Completada'),
(2, '2024-04-15', 'Limpieza de baño', 'En espera'),
(3, '2024-04-15', 'Limpieza de suelos', 'En espera'),
(4, '2024-04-15', 'Limpieza de ventanas', 'En espera'),
(5, '2024-04-15', 'Limpieza de muebles', 'En progreso');
