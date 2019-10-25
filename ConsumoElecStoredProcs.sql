CREATE PROC AGREGAR_USUARIO
@NOMBRE VARCHAR(100),
@APELLIDO VARCHAR(100),
@CORREO VARCHAR(100),
@DIRECCION VARCHAR(150)
AS
	INSERT INTO Usuario (nombre, apellido, correo, direccion)
	VALUES (@NOMBRE, @APELLIDO, @CORREO, @DIRECCION)
GO

CREATE PROC REGISTRAR_LECTURA
@FECHA DATE,
@CONSUMO DECIMAL(18, 0),
@IDUSUARIO INT
AS
	INSERT INTO Lectura (fecha, consumo, idUsuario)
	VALUES (@FECHA, @CONSUMO, @IDUSUARIO)
GO


CREATE PROC BUSCAR_USUARIOS
AS
	SELECT * FROM Usuario
GO

CREATE PROC BUSCAR_LECTURAS
AS
	SELECT * FROM Lectura
GO

CREATE PROC ELIMINAR_USUARIO
@ID INT
AS
DELETE FROM Usuario WHERE idUsuario=@ID
GO

CREATE PROC ELIMINAR_LECTURA
@ID INT
AS
DELETE FROM Lectura WHERE idLectura=@ID
GO

CREATE PROC MODIFICAR_USUARIO
@nombre varchar(100),
@apellido varchar(100),
@correo varchar(100),
@direccion varchar(150),
@id int
AS
  UPDATE Usuario SET nombre=@nombre, apellido=@apellido, correo=@correo, direccion=@direccion
  WHERE idUsuario = @id
GO

CREATE PROC MODIFICAR_LECTURA
@fecha date,
@consumo decimal(18,0),
@idUsuario int,
@id int
AS
  UPDATE Lectura SET fecha=@fecha, consumo=@consumo, idUsuario=@idUsuario
  WHERE idUsuario = @id
GO