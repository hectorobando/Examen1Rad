/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [idusuario]
      ,[contrasena]
      ,[NombreCompleto]
      ,[nivelacceso]
      ,[fecharegistro]
      ,[activo]
  FROM [ExamenRad].[dbo].[Usuarios]