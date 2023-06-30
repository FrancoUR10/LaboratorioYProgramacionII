/****** Script para el comando SelectTopNRows de SSMS  ******/

INSERT INTO usuarios (correo,clave,nombre,edad) VALUES ('martin_mail','2121','Martin','18')

SELECT * FROM usuarios

SELECT * FROM usuarios WHERE correo = 'pedro_correos'

UPDATE usuarios SET nombre = 'Pedrito', clave = '555' WHERE correo = 'pedro_correos'

DELETE FROM usuarios WHERE correo = 'martin_mail'

/*Metodo agregar statico recibe tipo usuario y retorna un bool si pudo o no pudo agregarlo*/
/*Metodo de instancia traer si no recibe parametros va a retornar una lista de usuarios o null*/
/*Sobrecarga: String correo | Traera un usuario o null si no existe*/
/*Metodos Modificar y Eliminar de instancia, retornan un booleano si se pudo modificar/Eliminar o no*/
/*Metodo ExecuteReader() Metodo ExecuteNonQuery() retorna la cantidad de filas afectadas en una consulta*/
/*Archivo .udl para conectarse a la base de datos*/
/*Desajuntar una base de datos | Posicionarnos en la base*/