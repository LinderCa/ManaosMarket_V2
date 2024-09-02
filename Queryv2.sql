USE ManaosMarketSof;
SELECT A.idArea,A.nombre,A.descripcion 
FROM Area A
WHERE A.vigente=1;

SELECT A.idArea, A.nombre,A.descripcion,A.vigente
FROM Area A
WHERE A.nombre LIKE 'v%';

UPDATE Area 
SET nombre='',descripcion='',vigente=1
WHERE idArea=1

SELECT * FROM Area;
SELECT * FROM Usuario;
SELECT * FROM Asistencia;