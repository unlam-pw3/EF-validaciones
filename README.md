# Ejemplo de EF DataFirst y validaciones

En este ejemplo podrán ver como se pueden extender las clases generadas por EF para  agregar validaciones utilizando Data Annotations.

Puntos Importantes:

- Ver las 2 clases que están dentro de la carpeta Models:
1) La clase Cliente es partial y tiene el mismo namespace que la clase autogenerada por EF.
2) La clase ClienteMetadata contiene las validaciones configuradas sobre el modelo.


Les dejo un link en inglés donde se explica el tema:

https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/database-first-development/enhancing-data-validation
