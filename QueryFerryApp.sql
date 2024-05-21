-- Active: 1716153619165@@roundhouse.proxy.rlwy.net@55464@railway


--Usuario--------------------------------------------------------------------------------
CREATE TABLE Users (
    id_user INT AUTO_INCREMENT PRIMARY KEY,
    NombreUser VARCHAR(20),
    Contraseña VARCHAR(20),
    RolUser VARCHAR(20),
    Fecharegistro DATETIME,
    Estado BIT
);

DELIMITER //

CREATE PROCEDURE InsertarUsuario(
    IN p_NombreUser VARCHAR(20),
    IN p_Contraseña VARCHAR(20),
    IN p_RolUser VARCHAR(20),
    IN p_Fecharegistro DATETIME
)
BEGIN
    INSERT INTO Users(NombreUser, Contraseña, RolUser, Fecharegistro, Estado)
    VALUES (p_NombreUser, p_Contraseña, p_RolUser, p_Fecharegistro, 1);
END //

CREATE PROCEDURE CambiarEstadoUsuario(
    IN p_id_user INT,
    IN p_Estado BIT
)
BEGIN
    UPDATE Users
    SET Estado = p_Estado
    WHERE id_user = p_id_user;
END //

CREATE PROCEDURE MostrarUsuario(
    IN p_id_user INT
)
BEGIN
    SELECT * FROM Users
    WHERE id_user = p_id_user;
END //

CREATE PROCEDURE ModificarUsuario(
    IN p_id_user INT,
    IN p_NombreUser VARCHAR(20),
    IN p_Contraseña VARCHAR(20),
    IN p_RolUser VARCHAR(20),
    IN p_Fecharegistro DATETIME,
    IN p_Estado BIT
)
BEGIN
    UPDATE Users
    SET NombreUser = p_NombreUser,
        Contraseña = p_Contraseña,
        RolUser = p_RolUser,
        Fecharegistro = p_Fecharegistro,
        Estado = p_Estado
    WHERE id_user = p_id_user;
END //

DELIMITER ;

--Proveedor-----------------------------------------------------------------------------------------------
CREATE TABLE Proveedor (
    Id_proveedor INT AUTO_INCREMENT PRIMARY KEY,
    RazonSocial VARCHAR(20),
    Telefono1 VARCHAR(20),
    Telefono2 VARCHAR(20),
    Correo VARCHAR(50),
    Estado BIT,
    Nota TEXT
);

DELIMITER //

CREATE PROCEDURE InsertarProveedor(
    IN p_RazonSocial VARCHAR(20),
    IN p_Telefono1 VARCHAR(20),
    IN p_Telefono2 VARCHAR(20),
    IN p_Correo VARCHAR(50),
    IN p_Nota TEXT
)
BEGIN
    INSERT INTO Proveedor(RazonSocial, Telefono1, Telefono2, Correo, Estado, Nota)
    VALUES (p_RazonSocial, p_Telefono1, p_Telefono2, p_Correo, 1, p_Nota);
END //

CREATE PROCEDURE CambiarEstadoProveedor(
    IN p_Id_proveedor INT,
    IN p_Estado BIT
)
BEGIN
    UPDATE Proveedor
    SET Estado = p_Estado
    WHERE Id_proveedor = p_Id_proveedor;
END //

CREATE PROCEDURE MostrarProveedor(
    IN p_Id_proveedor INT
)
BEGIN
    SELECT * FROM Proveedor
    WHERE Id_proveedor = p_Id_proveedor;
END //

DELIMITER ;


--Stoc------------------------------------------------------------------------------------------------------

CREATE TABLE Stoc (
    id_Producto INT AUTO_INCREMENT PRIMARY KEY,
    id_proveedor INT,
    NombreProducto VARCHAR(20),
    Categoria VARCHAR(20),
    Descripcion VARCHAR(20),
    existencias INT,
    existenciasmin INT,
    ValorCompra_unitario DOUBLE,
    ValorVenta_unitario DOUBLE,
    Imagen VARCHAR(255),
    Estado BIT,
    FOREIGN KEY (id_proveedor) REFERENCES Proveedor(Id_proveedor)
);

DELIMITER //

CREATE PROCEDURE InsertarProducto(
    IN p_id_proveedor INT,
    IN p_NombreProducto VARCHAR(20),
    IN p_Categoria VARCHAR(20),
    IN p_Descripcion VARCHAR(20),
    IN p_existencias INT,
    IN p_existenciasmin INT,
    IN p_ValorCompra_unitario DOUBLE,
    IN p_ValorVenta_unitario DOUBLE,
    IN p_Imagen VARCHAR(255)
)
BEGIN
    INSERT INTO Stoc(id_proveedor, NombreProducto, Categoria, Descripcion, existencias, existenciasmin, ValorCompra_unitario, ValorVenta_unitario, Imagen, Estado)
    VALUES (p_id_proveedor, p_NombreProducto, p_Categoria, p_Descripcion, p_existencias, p_existenciasmin, p_ValorCompra_unitario, p_ValorVenta_unitario, p_Imagen, 1);
END //

CREATE PROCEDURE MostrarProductos()
BEGIN
    SELECT s.id_Producto, p.RazonSocial as Proveedor, s.NombreProducto, s.Categoria, s.Descripcion, s.existencias, s.existenciasmin, s.ValorCompra_unitario, s.ValorVenta_unitario, s.Imagen
    FROM Stoc s
    JOIN Proveedor p ON s.id_proveedor = p.Id_proveedor;
END //

DELIMITER ;


--Promociones------------------------------------------------------------------------------------------------

CREATE TABLE Promociones (
    id_promocion INT AUTO_INCREMENT PRIMARY KEY,
    NombrePromocion VARCHAR(20),
    Condicionespromocion TEXT,
    ValorDescuento DOUBLE,
    Disponible BIT
);

DELIMITER //

CREATE PROCEDURE InsertarPromocion(
    IN p_NombrePromocion VARCHAR(20),
    IN p_Condicionespromocion TEXT,
    IN p_ValorDescuento DOUBLE,
    IN p_Disponible BIT
)
BEGIN
    INSERT INTO Promociones(NombrePromocion, Condicionespromocion, ValorDescuento, Disponible)
    VALUES (p_NombrePromocion, p_Condicionespromocion, p_ValorDescuento, p_Disponible);
END //

CREATE PROCEDURE CambiarDisponibilidadPromocion(
    IN p_id_promocion INT,
    IN p_Disponible BIT
)
BEGIN
    UPDATE Promociones
    SET Disponible = p_Disponible
    WHERE id_promocion = p_id_promocion;
END //

CREATE PROCEDURE MostrarPromocion(
    IN p_id_promocion INT
)
BEGIN
    SELECT * FROM Promociones
    WHERE id_promocion = p_id_promocion;
END //

DELIMITER ;


--Venta------------------------------------------------------------------------------------------------
CREATE TABLE Venta (
    id_Venta INT AUTO_INCREMENT PRIMARY KEY,
    id_user INT,
    Fecharegistro DATETIME,
    Productos TEXT,
    ValorVenta DOUBLE,
    id_promocion INT,
    ValorFinal DOUBLE,
    Nota TEXT,
    Estado BIT,
    FOREIGN KEY (id_user) REFERENCES Users(id_user),
    FOREIGN KEY (id_promocion) REFERENCES Promociones(id_promocion)
);

DELIMITER //

CREATE PROCEDURE InsertarVenta(
    IN p_id_user INT,
    IN p_Fecharegistro DATETIME,
    IN p_Productos TEXT,
    IN p_ValorVenta DOUBLE,
    IN p_id_promocion INT,
    IN p_ValorFinal DOUBLE,
    IN p_Nota TEXT
)
BEGIN
    INSERT INTO Venta(id_user, Fecharegistro, Productos, ValorVenta, id_promocion, ValorFinal, Nota, Estado)
    VALUES (p_id_user, p_Fecharegistro, p_Productos, p_ValorVenta, p_id_promocion, p_ValorFinal, p_Nota, 1);
END //

CREATE PROCEDURE CambiarEstadoVenta(
    IN p_id_venta INT,
    IN p_Estado BIT,
    IN p_Nota TEXT
)
BEGIN
    UPDATE Venta
    SET Estado = p_Estado,
        Nota = p_Nota
    WHERE id_Venta = p_id_venta;
END //

CREATE PROCEDURE MostrarVentas()
BEGIN
    SELECT v.id_Venta, u.NombreUser as Usuario, v.Fecharegistro, v.Productos, v.ValorVenta, p.NombrePromocion as Promocion, v.ValorFinal, v.Nota
    FROM Venta v
    JOIN Users u ON v.id_user = u.id_user
    JOIN Promociones p ON v.id_promocion = p.id_promocion;
END //

DELIMITER ;

--Compra-----------------------------------------------------------------------------------------------------

CREATE TABLE Compra (
    id_Compra INT AUTO_INCREMENT PRIMARY KEY,
    id_user INT,
    id_proveedor INT,
    descripcion TEXT,
    valorCompra DOUBLE,
    Fecharegistro DATETIME,
    Nota TEXT,
    Estado BIT,
    FOREIGN KEY (id_user) REFERENCES Users(id_user),
    FOREIGN KEY (id_proveedor) REFERENCES Proveedor(Id_proveedor)
);

DELIMITER //

CREATE PROCEDURE InsertarCompra(
    IN p_id_user INT,
    IN p_id_proveedor INT,
    IN p_descripcion TEXT,
    IN p_valorCompra DOUBLE,
    IN p_Fecharegistro DATETIME,
    IN p_Nota TEXT
)
BEGIN
    INSERT INTO Compra(id_user, id_proveedor, descripcion, valorCompra, Fecharegistro, Nota, Estado)
    VALUES (p_id_user, p_id_proveedor, p_descripcion, p_valorCompra, p_Fecharegistro, p_Nota, 1);
END //

CREATE PROCEDURE CambiarEstadoCompra(
    IN p_id_compra INT,
    IN p_Estado BIT,
    IN p_Nota TEXT
)
BEGIN
    UPDATE Compra
    SET Estado = p_Estado,
        Nota = p_Nota
    WHERE id_Compra = p_id_compra;
END //

CREATE PROCEDURE MostrarCompras()
BEGIN
    SELECT c.id_Compra, u.NombreUser as Usuario, p.RazonSocial as Proveedor, c.descripcion, c.valorCompra, c.Fecharegistro, c.Nota
    FROM Compra c
    JOIN Users u ON c.id_user = u.id_user
    JOIN Proveedor p ON c.id_proveedor = p.Id_proveedor;
END //

DELIMITER ;


--Renta---------------------------------------------------------------------------------------------

CREATE TABLE Renta (
    id_Renta INT AUTO_INCREMENT PRIMARY KEY,
    id_proveedor INT,
    NombreRenta VARCHAR(20),
    Categoria VARCHAR(20),
    Descripcion VARCHAR(20),
    ValorxDia DOUBLE,
    ValorxHora DOUBLE,
    Imagen VARCHAR(255),
    Disponible BIT,
    Nota TEXT,
    FOREIGN KEY (id_proveedor) REFERENCES Proveedor(Id_proveedor)
);

DELIMITER //

CREATE PROCEDURE InsertarRenta(
    IN p_id_proveedor INT,
    IN p_NombreRenta VARCHAR(20),
    IN p_Categoria VARCHAR(20),
    IN p_Descripcion VARCHAR(20),
    IN p_ValorxDia DOUBLE,
    IN p_ValorxHora DOUBLE,
    IN p_Imagen VARCHAR(255),
    IN p_Disponible BIT,
    IN p_Nota TEXT
)
BEGIN
    INSERT INTO Renta(id_proveedor, NombreRenta, Categoria, Descripcion, ValorxDia, ValorxHora, Imagen, Disponible, Nota)
    VALUES (p_id_proveedor, p_NombreRenta, p_Categoria, p_Descripcion, p_ValorxDia, p_ValorxHora, p_Imagen, p_Disponible, p_Nota);
END //

CREATE PROCEDURE CambiarDisponibilidadRenta(
    IN p_id_renta INT,
    IN p_Disponible BIT,
    IN p_Nota TEXT
)
BEGIN
    UPDATE Renta
    SET Disponible = p_Disponible,
        Nota = p_Nota
    WHERE id_Renta = p_id_renta;
END //

CREATE PROCEDURE MostrarRentas()
BEGIN
    SELECT r.id_Renta, p.RazonSocial as Proveedor, r.NombreRenta, r.Categoria, r.Descripcion, r.ValorxDia, r.ValorxHora, r.Imagen, r.Disponible, r.Nota
    FROM Renta r
    JOIN Proveedor p ON r.id_proveedor = p.Id_proveedor;
END //

DELIMITER ;


--Cliente------------------------------------------------------------------------------------------------

CREATE TABLE Cliente(
    id_Cliente  int auto_increment primary key,
    NombreCliente varchar(20),
    Documento varchar(20),
    Domicilio varchar(20),
    Contraseña varchar(20),
    Id_user int,
    Fecharegistro datetime,
    Disponible BIT,
    Nota text,
    FOREIGN KEY (Id_user) REFERENCES Users(Id_user)
);

DELIMITER //

CREATE PROCEDURE InsertarCliente(
    IN p_NombreCliente VARCHAR(20),
    IN p_Documento VARCHAR(20),
    IN p_Domicilio VARCHAR(20),
    IN p_Contraseña VARCHAR(20),
    IN p_Id_user INT,
    IN p_Fecharegistro DATETIME,
    IN p_Nota TEXT
)
BEGIN
    INSERT INTO Cliente(NombreCliente, Documento, Domicilio, Contraseña, Id_user, Fecharegistro, Disponible, Nota)
    VALUES (p_NombreCliente, p_Documento, p_Domicilio, p_Contraseña, p_Id_user, p_Fecharegistro, 1, p_Nota);
END //

CREATE PROCEDURE CambiarDisponibilidadCliente(
    IN p_id_cliente INT,
    IN p_Disponible BIT,
    IN p_Nota TEXT
)
BEGIN
    UPDATE Cliente
    SET Disponible = p_Disponible,
        Nota = p_Nota
    WHERE id_Cliente = p_id_cliente;
END //

CREATE PROCEDURE MostrarClientes()
BEGIN
    SELECT * FROM Cliente;
END //

DELIMITER ;

--Rentado----------------------------------------------------------------------------------------------

CREATE TABLE Rentado (
    id_Rentado INT AUTO_INCREMENT PRIMARY KEY,
    id_Cliente INT,
    NombreRenta VARCHAR(20),
    Descripcion VARCHAR(20),
    Estado BIT,
    Nota TEXT,
    TipoRenta VARCHAR(20),
    TiempoRenta INT,
    id_user INT,
    FOREIGN KEY (id_Cliente) REFERENCES Cliente(id_Cliente),
    FOREIGN KEY (id_user) REFERENCES Users(Id_user)
);

DELIMITER //

CREATE PROCEDURE InsertarRentado(
    IN p_id_Cliente INT,
    IN p_NombreRenta VARCHAR(20),
    IN p_Descripcion VARCHAR(20),
    IN p_Estado BIT,
    IN p_Nota TEXT,
    IN p_TipoRenta VARCHAR(20),
    IN p_TiempoRenta INT,
    IN p_id_user INT
)
BEGIN
    INSERT INTO Rentado(id_Cliente, NombreRenta, Descripcion, Estado, Nota, TipoRenta, TiempoRenta, id_user)
    VALUES (p_id_Cliente, p_NombreRenta, p_Descripcion, p_Estado, p_Nota, p_TipoRenta, p_TiempoRenta, p_id_user);
END //

CREATE PROCEDURE CambiarEstadoRentado(
    IN p_id_rentado INT,
    IN p_Estado BIT,
    IN p_Nota TEXT
)
BEGIN
    UPDATE Rentado
    SET Estado = p_Estado,
        Nota = p_Nota
    WHERE id_Rentado = p_id_rentado;
END //

CREATE PROCEDURE MostrarRentados()
BEGIN
    SELECT r.id_Rentado, c.NombreCliente, r.NombreRenta, r.Descripcion, r.Estado, r.Nota, r.TipoRenta, r.TiempoRenta, u.NombreUser
    FROM Rentado r
    JOIN Cliente c ON r.id_Cliente = c.id_Cliente
    JOIN Users u ON r.id_user = u.Id_user;
END //

DELIMITER ;


--Notificacion------------------------------------------------------------------------------------
CREATE TABLE Notificacion (
    IdNotificacion INT AUTO_INCREMENT PRIMARY KEY,
    Titulo TEXT,
    Texto TEXT,
    FechaRegistro DATETIME,
    Estado BIT
);

DELIMITER //

CREATE PROCEDURE InsertarNotificacion(
    IN p_Titulo TEXT,
    IN p_Texto TEXT,
    IN p_FechaRegistro DATETIME,
    IN p_Estado BIT
)
BEGIN
    INSERT INTO Notificacion(Titulo, Texto, FechaRegistro, Estado)
    VALUES (p_Titulo, p_Texto, p_FechaRegistro, p_Estado);
END //

CREATE PROCEDURE CambiarEstadoNotificacion(
    IN p_IdNotificacion INT,
    IN p_Estado BIT
)
BEGIN
    UPDATE Notificacion
    SET Estado = p_Estado
    WHERE IdNotificacion = p_IdNotificacion;
END //

CREATE PROCEDURE MostrarNotificaciones()
BEGIN
    SELECT * FROM Notificacion;
END //

DELIMITER ;


CALL InsertarUsuario('Juan', 'contraseña123', 'Admin', NOW());

CALL InsertarUsuario('Jhoan', 'contraseña123', 'Admin', NOW());

CALL InsertarProveedor('Proveedor A', '123456789', '987654321', 'proveedorA@mail.com', 'Nota proveedor A');
CALL InsertarProveedor('Proveedor B', '987654321', '123456789', 'proveedorB@mail.com', 'Nota proveedor B');

CALL InsertarProducto(1, 'Producto A', 'Categoria A', 'Descripción A', 100, 10, 50.5, 100, 'imagen_producto_A.jpg');
CALL InsertarProducto(2, 'Producto B', 'Categoria B', 'Descripción B', 50, 5, 75.25, 120.75, 'imagen_producto_B.jpg');

