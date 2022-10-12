--Create Database TPQATARPAV
use tpqatarpav

-- Creacion de perfiles
create table perfil(
id int,
rol varchar(16),
borrado bit,
constraint id_pk primary key (id))

insert into perfil values(1,'administrador',0)
insert into perfil values(2,'tester',0)
insert into perfil values(3,'usuario',0)

-- Creacion de usuarios
Create table Usuario(
id int identity(1,1),
nombre varchar(15),
apellido varchar(15),
usuario varchar(16),
mail varchar(32),
contrasena varchar(15),
rol_id int,
borrado bit,
constraint user_pk Primary key (id),
CONSTRAINT fk_idPerfil FOREIGN KEY (rol_id) REFERENCES perfil (id))

Insert into Usuario values('Francisco', 'Ferraro','Franfe','Franfe@gmail.com','goku',1,0)

Insert into Usuario values('Ramiro','Somavilla','Ralfi','Ralfi@gmail.com','kobe',1,0)

Insert into Usuario values('Pedro','Arga�araz','Pedriskol','Pedriskol@gmail.com','messismo',1,0)

Insert into Usuario values('Lucas','Lopez','Luquitas','Luquitas@gmail.com','tester',2,0)

Insert into Usuario values('Roberto','Salamanca','Robert','Robert@gmail.com','user',3,0)

insert into Usuario values('Cristiano','Ronaldo','CR7','CR7@gmail.com','password',3,0)

select * from usuario


--Creacion y carga tabla tipo doc


Create table TipoDoc(
tipo_doc varchar(5),
descripcion varchar(15),
borrado bit,
constraint tipo_pk Primary Key(tipo_doc)
)

Insert into TipoDoc values('dni','DocArg',0)
Insert into TipoDoc values('id','DocUsa',0)
Insert into TipoDoc values('Pass','DocEsp',0)
Insert into TipoDoc values('doc','DocUy',0)
Insert into TipoDoc values('di','DocAlemania',0)
Insert into TipoDoc values('Nif','DocPortugal',0)
Insert into TipoDoc values('cpv','DocMex',0)
Insert into TipoDoc values('Ndi','DocInglaterra',0)
Insert into TipoDoc values('DA','DocAsia',0)
Insert into TipoDoc values('IDE','DocEuropa',0)
Insert into TipoDoc values('IdA','DocAfrica',0)
Insert into TipoDoc values('RDA','DocAmerica',0)
Insert into TipoDoc values('IDO','DocOcean�a',0)

select * from TipoDoc


--Creacion y carga tabla Ciudad


Create Table Ciudad(
nombre varchar(15),
region varchar(10),
borrado bit,
constraint pk_ciudad Primary Key (nombre)
)

Insert into Ciudad values(
'Doha','Centro',0)

Insert into Ciudad values(
'Al-Khor','Norte',0)

Insert into Ciudad values(
'Lusail','Sur',0)

Insert into Ciudad values(
'Al Rayyan','Este',0)

Insert into Ciudad values(
'Al-Wakrah','Oeste',0)

Select * from Ciudad



--Creacion tabla Estadio


Create table Estadio (
nombre varchar(32),
nombre_ciudad varchar(15),
capacidad int,
borrado bit,
constraint pk_estadio Primary Key (nombre),
CONSTRAINT fk_estadio_ciudad
   FOREIGN KEY (nombre_ciudad) REFERENCES Ciudad (nombre))

Insert into Estadio values (
'Al-Thumama','Doha',40000,0)
Insert into Estadio values (
'Internacional Khalifa','Doha',40000,0)
Insert into Estadio values (
'974 Ras Abu Aboud ','Doha',40000,0)
Insert into Estadio values (
'Ahmad Bin Ali','Al Rayyan',40000,0)
Insert into Estadio values (
'Qatar Foundation','Al Rayyan',40000,0)
Insert into Estadio values (
'Al Bayt','Al-Khor',60000,0)
Insert into Estadio values (
'Ic�nico de Lusail','Lusail',80000,0)
Insert into Estadio values (
'Al Janoub','Al-Wakrah',40000,0)

select * from Estadio

--Creacion tabla continente

Create table Continente(
id int,
Nombre varchar(32),
borrado bit,
constraint pk_Cont Primary key (id))

Insert into Continente Values(1,'America del sur',0)
Insert into Continente Values(2,'America del norte',0)
Insert into Continente Values(3,'Europa',0)
Insert into Continente Values(4,'Africa',0)
Insert into Continente Values(5,'Asia',0)
Insert into Continente Values(6,'Oceania',0)

Select * from Continente



--Creacion tabla Grupo


Create table Grupo(
id varchar(1),
primer_ubicado varchar(15),
segundo_ubicado varchar(15),
borrado bit,
constraint pk_grupo Primary Key (id),
constraint ck_id check(id in('A','B','C','D','E','F','G','H')))

Insert into Grupo values('A',null,null,0)
Insert into Grupo values('B',null,null,0)
Insert into Grupo values('C',null,null,0)
Insert into Grupo values('D',null,null,0)
Insert into Grupo values('E',null,null,0)
Insert into Grupo values('F',null,null,0)
Insert into Grupo values('G',null,null,0)
Insert into Grupo values('H',null,null,0)

Select * from Grupo


--Creacion tabla ronda


Create table Ronda(
id int,
descripcion varchar(20),
borrado bit,
constraint pk_ronda primary key (id))

Insert into Ronda values (1,'Fase de Grupo',0)
Insert into Ronda values (2,'Octavos de Final',0)
Insert into Ronda values (3,'Cuartos de Final',0)
Insert into Ronda values (4,'Semifinal',0)
Insert into Ronda values (5,'Final',0)

Select * from ronda



--Creacion tabla Paises

Create table Pais(
nombre varchar(15),
id_continente int,
id_grupo varchar(1),
puntos int,
ranking_fifa int,
borrado bit,
constraint pk_pais Primary Key (nombre),
CONSTRAINT fk_pais_cont FOREIGN KEY (id_continente) REFERENCES Continente (id),
constraint fk_pais_grupo Foreign key (id_grupo) references grupo(id))

Insert into Pais values('Qatar',5,'A',0,48,0)
Insert into Pais values('Ecuador',1,'A',0,44,0)
Insert into Pais values('Senegal',4,'A',0,18,0)
Insert into Pais values('Paises Bajos',3,'A',0,8,0)
Insert into Pais values('Inglaterra',3,'B',0,5,0)
Insert into Pais values('Iran',5,'B',0,22,0)
Insert into Pais values('Estados unidos',2,'B',0,14,0)
Insert into Pais values('Gales',3,'B',0,19,0)
Insert into Pais values('Argentina',1,'C',0,3,0)
Insert into Pais values('Arabia Saudita',5,'C',0,53,0)
Insert into Pais values('Mexico',2,'C',0,12,0)
Insert into Pais values('Polonia',3,'C',0,26,0)
Insert into Pais values('Francia',3,'D',0,4,0)
Insert into Pais values('Australia',6,'D',0,39,0)
Insert into Pais values('Dinamarca',3,'D',0,10,0)
Insert into Pais values('Tunez',4,'D',0,30,0)
Insert into Pais values('Espana',3,'E',0,6,0)
Insert into Pais values('Costa Rica',2,'E',0,34,0)
Insert into Pais values('Alemania',3,'E',0,11,0)
Insert into Pais values('Japon',5,'E',0,24,0)
Insert into Pais values('Belgica',3,'F',0,2,0)
Insert into Pais values('Canada',2,'F',0,43,0)
Insert into Pais values('Marruecos',4,'F',0,23,0)
Insert into Pais values('Croacia',3,'F',0,15,0)
Insert into Pais values('Brasil',1,'G',0,1,0)
Insert into Pais values('Serbia',3,'G',0,25,0)
Insert into Pais values('Suiza',3,'G',0,16,0)
Insert into Pais values('Camerun',4,'G',0,38,0)
Insert into Pais values('Portugal',3,'H',0,9,0)
Insert into Pais values('Ghana',4,'H',0,60,0)
Insert into Pais values('Uruguay',1,'H',0,13,0)
Insert into Pais values('Corea del Sur',5,'H',0,28,0)

Select * from Pais order by id_grupo


--Creacion Tabla arbitros


Create Table Arbitro(
nombre varchar(15),
apellido varchar(15),
tipo_doc varchar(5),
nro_doc int,
pais varchar(15),
borrado bit
constraint pk_referee primary key (tipo_doc,nro_doc),
constraint fk_referee_nacionalidad Foreign key (pais) references pais(nombre),
constraint fk_tipo_doc_ref Foreign key (tipo_doc) references tipoDoc (tipo_doc))

Insert into Arbitro Values(
'Nestor','Pitana','Dni','30303030','Argentina',0)
Insert into Arbitro Values(
'John','Walker','Id','32451323','Estados Unidos',0)
Insert into Arbitro Values(
'Elvis','Johnson','Id','19133412','Estados Unidos',0)
Insert into Arbitro Values(
'Juan Pablo','Ramos','Pass','41231444','Espana',0)

Select * from Arbitro

--Creacion Tabla Jugadores

Create table Jugadores(
tipo_doc varchar(5),
nro_doc int,
nombre varchar(15),
apellido varchar(15),
pais varchar(15),
goles int,
asistencias int,
tarjetas_rojas int,
tarjetas_amarillas int,
borrado bit,
constraint pk_jugador primary key (tipo_doc,nro_doc),
constraint fk_tipo_doc_jg foreign key (tipo_doc) references tipoDoc(tipo_doc),
constraint fk_pais_jg foreign key (pais) references pais (nombre))

--Grupo A
--Qatar
Insert into jugadores values
('DA',11110000,'Saad','Alsheeb','Qatar',0,0,0,0,0)
Insert into jugadores values
('DA',11110001,'Homam','Ahmed','Qatar',0,0,0,0,0)
Insert into jugadores values
('DA',11110002,'Pedro','Miguel','Qatar',0,0,0,0,0)
Insert into jugadores values
('DA',11110003,'Karim','Boudiaf','Qatar',0,0,0,0,0)
Insert into jugadores values
('DA',11110004,'Mohammed','Muntari','Qatar',0,0,0,0,0)

--Ecuador
Insert into jugadores values
('RDA',11110005,'Alexander','Dominguez','Ecuador',0,0,0,0,0)
Insert into jugadores values
('RDA',11110006,'Piero','Hincapie','Ecuador',0,0,0,0,0)
Insert into jugadores values
('RDA',11110007,'Alan','Franco','Ecuador',0,0,0,0,0)
Insert into jugadores values
('RDA',11110008,'Angel','Mena','Ecuador',0,0,0,0,0)
Insert into jugadores values
('RDA',11110009,'Enner','Valencia','Ecuador',0,0,0,0,0)

--Senegal
Insert into jugadores values
('IdA',10110000,'Edouard','Mendy','Senegal',0,0,0,0,0)
Insert into jugadores values
('IdA',12110000,'Abdou','Diallo','Senegal',0,0,0,0,0)
Insert into jugadores values
('IdA',13110000,'Idrissa','Gueye','Senegal',0,0,0,0,0)
Insert into jugadores values
('IdA',14110000,'Ismalia','Sarr','Senegal',0,0,0,0,0)
Insert into jugadores values
('IdA',15110000,'Sadio','Mane','Senegal',0,0,0,0,0)

--Paises Bajos
Insert into jugadores values
('IDE',16110000,'Jasper','Cillessen','Paises Bajos',0,0,0,0,0)
Insert into jugadores values
('IDE',17110000,'Virgil','Van Dijk','Paises Bajos',0,0,0,0,0)
Insert into jugadores values
('IDE',18110000,'Frenkie','De Jong','Paises Bajos',0,0,0,0,0)
Insert into jugadores values
('IDE',19110000,'Georginio','Wijnaldum','Paises Bajos',0,0,0,0,0)
Insert into jugadores values
('IDE',11010000,'Memphis','Depay','Paises Bajos',0,0,0,0,0)

--Grupo B
--Inglaterra
Insert into jugadores values
('Ndi',11210000,'Jordan','Pickford','Inglaterra',0,0,0,0,0)
Insert into jugadores values
('Ndi',16310000,'Harry','Maguire','Inglaterra',0,0,0,0,0)
Insert into jugadores values
('Ndi',16410000,'Kyle','Walker','Inglaterra',0,0,0,0,0)
Insert into jugadores values
('Ndi',16510000,'Phil','Foden','Inglaterra',0,0,0,0,0)
Insert into jugadores values
('Ndi',16610000,'Harry','Kane','Inglaterra',0,0,0,0,0)

--Iran
Insert into jugadores values
('DA',16710000,'Amir','Abedzadeh','Iran',0,0,0,0,0)
Insert into jugadores values
('DA',16810000,'Majid','Hosseini','Iran',0,0,0,0,0)
Insert into jugadores values
('DA',16910000,'Vahid','Amiri','Iran',0,0,0,0,0)
Insert into jugadores values
('DA',1410000,'Sardar','Azmoun','Iran',0,0,0,0,0)
Insert into jugadores values
('DA',14210000,'Mehdi','Taremi','Iran',0,0,0,0,0)

--EEUU
Insert into jugadores values
('id',16700110,'Matt','Turner','Estados Unidos',0,0,0,0,0)
Insert into jugadores values
('id',16710120,'Sergino','Dest','Estados Unidos',0,0,0,0,0)
Insert into jugadores values
('id',16710130,'Andre','Yedlin','Estados Unidos',0,0,0,0,0)
Insert into jugadores values
('id',16710140,'Tyler','Adams','Estados Unidos',0,0,0,0,0)
Insert into jugadores values
('id',16710150,'Christian','Pulisic','Estados Unidos',0,0,0,0,0)

--Gales
Insert into jugadores values
('IDE',16810001,'Danny','Ward','Gales',0,0,0,0,0)
Insert into jugadores values
('IDE',16810002,'Ben','Davies','Gales',0,0,0,0,0)
Insert into jugadores values
('IDE',16810003,'Joe','Allen','Gales',0,0,0,0,0)
Insert into jugadores values
('IDE',16810004,'Aaron','Ramsey','Gales',0,0,0,0,0)
Insert into jugadores values
('IDE',16810005,'Gareth','Bale','Gales',0,0,0,0,0)

--Grupo C
--Argentina
Insert into jugadores values
('Dni',33016244,'Emiliano','Martinez','Argentina',0,0,0,0,0)
Insert into jugadores values
('Dni',30017292,'Marcos','Acuna','Argentina',0,0,0,0,0)
Insert into jugadores values
('Dni',29816224,'Nahuel','Molina','Argentina',0,0,0,0,0)
Insert into jugadores values
('Dni',35916284,'Nicolas','Otamendi','Argentina',0,0,0,0,0)
Insert into jugadores values
('Dni',37516545,'Cristian','Romero','Argentina',0,0,0,0,0)
Insert into jugadores values
('Dni',37013264,'Rodirgo','De Paul','Argentina',0,0,0,0,0)
Insert into jugadores values
('Dni',38007540,'Lisandro','Martinez','Argentina',0,0,0,0,0)
Insert into jugadores values
('Dni',31896241,'Angel','Di Maria','Argentina',0,0,0,0,0)
Insert into jugadores values
('Dni',38046546,'Giovani','Lo Celso','Argentina',0,0,0,0,0)
Insert into jugadores values
('Dni',40011241,'Leandro','Paredes','Argentina',0,0,0,0,0)
Insert into jugadores values
('Dni',39015234,'Lautaro','Martinez','Argentina',0,0,0,0,0)
Insert into jugadores values
('Dni',34077541,'Julian','Alvarez','Argentina',0,0,0,0,0)
Insert into jugadores values
('Dni',40077540,'Paulo','Dybala','Argentina',0,0,0,0,0)
Insert into jugadores values
('Dni',33016240,'Lionel','Messi','Argentina',0,0,0,0,0)

--Arabia Saudita
Insert into jugadores values
('DA',24413044,'Malli','Al-Chupi','Arabia Saudita',0,0,0,0,0)
Insert into jugadores values
('DA',20103040,'Mohamed','Al-Owais','Arabia Saudita',0,0,0,0,0)
Insert into jugadores values
('DA',21113141,'Abdulelah','Al-Amri','Arabia Saudita',0,0,0,0,0)
Insert into jugadores values
('DA',24133241,'Sultan','Al-Ghannam','Arabia Saudita',0,0,0,0,0)
Insert into jugadores values
('DA',22427544,'Yasser','Al-Shahrani','Arabia Saudita',0,0,0,0,0)
Insert into jugadores values
('DA',27443740,'Hassan','Al-Tambakti','Arabia Saudita',0,0,0,0,0)
Insert into jugadores values
('DA',25103447,'Abdullah','Madu','Arabia Saudita',0,0,0,0,0)
Insert into jugadores values
('DA',21437090,'Salman','Al-Faraj','Arabia Saudita',0,0,0,0,0)
Insert into jugadores values
('DA',29103740,'Abdulelah','Al-Malki','Arabia Saudita',0,0,0,0,0)
Insert into jugadores values
('DA',27173064,'Mohamed','Kanmo','Arabia Saudita',0,0,0,0,0)
Insert into jugadores values
('DA',22143046,'Salem','Al-Dawsari','Arabia Saudita',0,0,0,0,0)
Insert into jugadores values
('DA',24633000,'Khalid','Al-Ghannam','Arabia Saudita',0,0,0,0,0)
Insert into jugadores values
('DA',27773040,'Haroune','Camara','Arabia Saudita',0,0,0,0,0)
Insert into jugadores values
('DA',28183848,'Muteb','Al-Mufarrij','Arabia Saudita',0,0,0,0,0)
Insert into jugadores values
('DA',20773340,'Ahmed','Al-Culibemawchev','Arabia Saudita',0,0,0,0,0)

--Mexico
Insert into jugadores values
('cpv',31247856,'Guillermo','Ochoa','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',30207050,'Nestor','Araujo','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',33247456,'Jesus','Gallardo','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',35547876,'Cesar','Montes','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',37167756,'Hector','Montero','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',39247252,'Luis','Romo','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',35217555,'Edson','Alvarez','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',32244856,'Jesus','Corona','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',30200846,'Andres','Guardado','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',39544656,'Hector','Herrera','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',29247850,'Rogelio','Funes Mori','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',37124776,'Raul','Gimenez','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',36246312,'Hirving','Lozano','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',36622866,'Diego','Lainez','Mexico',0,0,0,0,0)

--Polonia
Insert into jugadores values
('IDE',23469376,'Wojciech','Szczesny','Polonia',0,0,0,0,0)
Insert into jugadores values
('IDE',24097596,'Lukasz','Skorupski','Polonia',0,0,0,0,0)
Insert into jugadores values
('IDE',23000336,'Jan','Bednarek','Polonia',0,0,0,0,0)
Insert into jugadores values
('IDE',29457844,'Bartosz','Bereszynski','Polonia',0,0,0,0,0)
Insert into jugadores values
('IDE',27666662,'Matty','Cash','Polonia',0,0,0,0,0)
Insert into jugadores values
('IDE',20000456,'Kamil','Glik','Polonia',0,0,0,0,0)
Insert into jugadores values
('IDE',23469752,'Tymoteusz','Puchacs','Polonia',0,0,0,0,0)
Insert into jugadores values
('IDE',20258963,'Maciej','Rybus','Polonia',0,0,0,0,0)
Insert into jugadores values
('IDE',29669572,'Jakub','Moder','Polonia',0,0,0,0,0)
Insert into jugadores values
('IDE',29044697,'Piotr','Zielinski','Polonia',0,0,0,0,0)
Insert into jugadores values
('IDE',20033116,'Robert','Lewandowski','Polonia',0,0,0,0,0)
Insert into jugadores values
('IDE',27531598,'Arkadiusz','Milik','Polonia',0,0,0,0,0)
Insert into jugadores values
('IDE',23469632,'Krzysztof','Piatek','Polonia',0,0,0,0,0)
Insert into jugadores values
('IDE',20669876,'Karol','Swiderski','Polonia',0,0,0,0,0)

--Grupo D
--Francia
Insert into jugadores values
('IDE',16910001,'Hugo','Lloris','Francia',0,0,0,0,0)
Insert into jugadores values
('IDE',16950001,'Maestro','Kimpembe','Francia',0,0,0,0,0)
Insert into jugadores values
('IDE',16960001,'Ngolo','Kante','Francia',0,0,0,0,0)
Insert into jugadores values
('IDE',16970001,'Kylian','Mbappe','Francia',0,0,0,0,0)
Insert into jugadores values
('IDE',16980001,'Karim','Benzema','Francia',0,0,0,0,0)

--Australia
Insert into jugadores values
('IDO',17770001,'Mathew','Ryan','Australia',0,0,0,0,0)
Insert into jugadores values
('IDO',17770002,'Rhyan','Grant','Australia',0,0,0,0,0)
Insert into jugadores values
('IDO',17770003,'James','Jeggo','Australia',0,0,0,0,0)
Insert into jugadores values
('IDO',17770004,'Martin','Boyle','Australia',0,0,0,0,0)
Insert into jugadores values
('IDO',17770005,'Craig','Goodwin','Australia',0,0,0,0,0)

--Dinamarca
Insert into jugadores values
('IDE',1880001,'Kasper','Schmeichel','Dinamarca',0,0,0,0,0)
Insert into jugadores values
('IDE',1880002,'Simon','Kjaer','Dinamarca',0,0,0,0,0)
Insert into jugadores values
('IDE',1880003,'Thomas','Delaney','Dinamarca',0,0,0,0,0)
Insert into jugadores values
('IDE',1880004,'Chistian','Eriksen','Dinamarca',0,0,0,0,0)
Insert into jugadores values
('IDE',1880005,'Kasper','Dolberg','Dinamarca',0,0,0,0,0)

--Tunez
Insert into jugadores values
('IdA',1909001,'Bechir','Ben Said','Tunez',0,0,0,0,0)
Insert into jugadores values
('IdA',1909002,'Bilel','Ifa','Tunez',0,0,0,0,0)
Insert into jugadores values
('IdA',1909003,'Yassine','Meriah','Tunez',0,0,0,0,0)
Insert into jugadores values
('IdA',1909004,'Wahbi','Khazri','Tunez',0,0,0,0,0)
Insert into jugadores values
('IdA',1909005,'Naim','Sliti','Tunez',0,0,0,0,0)

--Grupo E
--Espa�a
Insert into jugadores values
('Pass',20490001,'Unai','Simon','Espana',0,0,0,0,0)
Insert into jugadores values
('Pass',20490002,'Jordi','Alba','Espana',0,0,0,0,0)
Insert into jugadores values
('Pass',20490003,'Marcos','Llorente','Espana',0,0,0,0,0)
Insert into jugadores values
('Pass',20490004,'Ansu','Fati','Espana',0,0,0,0,0)
Insert into jugadores values
('Pass',20490005,'Alvaro','Morata','Espana',0,0,0,0,0)

--Costa Rica
Insert into jugadores values
('RDA',30490001,'Keylor','Navas','Costa Rica',0,0,0,0,0)
Insert into jugadores values
('RDA',30490002,'Oscar','Duarte','Costa Rica',0,0,0,0,0)
Insert into jugadores values
('RDA',30490003,'Kendall','Watson','Costa Rica',0,0,0,0,0)
Insert into jugadores values
('RDA',30490004,'Celso','Borges','Costa Rica',0,0,0,0,0)
Insert into jugadores values
('RDA',30490005,'Joel','Campbell','Costa Rica',0,0,0,0,0)

--Alemania
Insert into jugadores values
('di',40012001,'Manuel','Neuer','Alemania',0,0,0,0,0)
Insert into jugadores values
('di',40012002,'Antonio','Rudiger','Alemania',0,0,0,0,0)
Insert into jugadores values
('di',40012003,'Kai','Havertz','Alemania',0,0,0,0,0)
Insert into jugadores values
('di',40012004,'Thomas','Muller','Alemania',0,0,0,0,0)
Insert into jugadores values
('di',40012005,'Timo','Werner','Alemania',0,0,0,0,0)

--Jap�n
Insert into jugadores values
('DA',10055509,'Shuichi','Gonda','Japon',0,0,0,0,0)
Insert into jugadores values
('DA',10055508,'Yuto','Nagatomo','Japon',0,0,0,0,0)
Insert into jugadores values
('DA',10055507,'Hidemasa','Morita','Japon',0,0,0,0,0)
Insert into jugadores values
('DA',10055506,'Junya','Yito','Japon',0,0,0,0,0)
Insert into jugadores values
('DA',10055505,'Hwan','Honda','Japon',0,0,0,0,0)

--Grupo F
--B�lgica
Insert into jugadores values
('IDE',56785301,'Tibu','Couttois','Belgica',0,0,0,0,0)
Insert into jugadores values
('IDE',56785302,'Thomas','Meunier','Belgica',0,0,0,0,0)
Insert into jugadores values
('IDE',56785303,'Kevin','De Bruyne','Belgica',0,0,0,0,0)
Insert into jugadores values
('IDE',56785304,'Eden','Hazard','Belgica',0,0,0,0,0)
Insert into jugadores values
('IDE',56785305,'Romelu','Lukaku','Belgica',0,0,0,0,0)

--Canada
Insert into jugadores values
('id',36885809,'Milan','Borjan','Canada',0,0,0,0,0)
Insert into jugadores values
('id',36885854,'Alphonso','Davies','Canada',0,0,0,0,0)
Insert into jugadores values
('id',36885833,'Doniel','Henry','Canada',0,0,0,0,0)
Insert into jugadores values
('id',36885822,'Samuel','Piette','Canada',0,0,0,0,0)
Insert into jugadores values
('id',36885811,'Cyle','Larin','Canada',0,0,0,0,0)

--Marruecos
Insert into jugadores values
('IdA',29632599,'Yassine','Bounou','Marruecos',0,0,0,0,0)
Insert into jugadores values
('IdA',29632598,'Achraf','Hakimi','Marruecos',0,0,0,0,0)
Insert into jugadores values
('IdA',29632597,'Aymen','Barkok','Marruecos',0,0,0,0,0)
Insert into jugadores values
('IdA',29632596,'Youssef','Ennessiry','Marruecos',0,0,0,0,0)
Insert into jugadores values
('IdA',29632595,'Sofiane','Boufal','Marruecos',0,0,0,0,0)

--Croacia
Insert into jugadores values
('IDE',20835500,'Dominik','Livakovic','Croacia',0,0,0,0,0)
Insert into jugadores values
('IDE',20835501,'Dejan','Lovren','Croacia',0,0,0,0,0)
Insert into jugadores values
('IDE',20835502,'Luka','Modric','Croacia',0,0,0,0,0)
Insert into jugadores values
('IDE',20835503,'Ivan','Perisic','Croacia',0,0,0,0,0)
Insert into jugadores values
('IDE',20835504,'Mario','Manduzukic','Croacia',0,0,0,0,0)

--Grupo G
--Brasil
Insert into jugadores values
('RDA',33225500,'Alisson','Moraes','Brasil',0,0,0,0,0)
Insert into jugadores values
('RDA',33225501,'Eder','Militao','Brasil',0,0,0,0,0)
Insert into jugadores values
('RDA',33225502,'Lucas','Paqueta','Brasil',0,0,0,0,0)
Insert into jugadores values
('RDA',33225503,'Neymar','Jr','Brasil',0,0,0,0,0)
Insert into jugadores values
('RDA',33225504,'Grabriel','Jesus','Brasil',0,0,0,0,0)

--Serbia
Insert into jugadores values
('IDE',18293745,'Predrag','Rajkovic','Serbia',0,0,0,0,0)
Insert into jugadores values
('IDE',18293746,'Nikola','Milenkovic','Serbia',0,0,0,0,0)
Insert into jugadores values
('IDE',18293747,'Sasa','Lukic','Serbia',0,0,0,0,0)
Insert into jugadores values
('IDE',18293748,'Luka','Jovic','Serbia',0,0,0,0,0)
Insert into jugadores values
('IDE',18293749,'Milinkovic','Savic','Serbia',0,0,0,0,0)

--Suiza
Insert into jugadores values
('IDE',34679122,'Yann','Sommer','Suiza',0,0,0,0,0)
Insert into jugadores values
('IDE',34679123,'Manuel','Akanji','Suiza',0,0,0,0,0)
Insert into jugadores values
('IDE',34679124,'Xherdan','Shaqiri','Suiza',0,0,0,0,0)
Insert into jugadores values
('IDE',34679125,'Grant','Xhaka','Suiza',0,0,0,0,0)
Insert into jugadores values
('IDE',34679126,'Haris','Seferovic','Suiza',0,0,0,0,0)

--Camer�n
Insert into jugadores values
('RDA',22583140,'Andre','Onana','Camerun',0,0,0,0,0)
Insert into jugadores values
('RDA',22583141,'Devis','Epassy','Camerun',0,0,0,0,0)
Insert into jugadores values
('RDA',22583142,'Pierre','Kunde','Camerun',0,0,0,0,0)
Insert into jugadores values
('RDA',22583143,'Vincent','Aboubakar','Camerun',0,0,0,0,0)
Insert into jugadores values
('RDA',22583144,'Samuel','Etoo','Camerun',0,0,0,0,0)

--Grupo H
--Portugal
Insert into jugadores values
('Nif',30106085,'Rui','Patricio','Portugal',0,0,0,0,0)
Insert into jugadores values
('Nif',31106064,'Joao','Cancelo','Portugal',0,0,0,0,0)
Insert into jugadores values
('Nif',32106091,'Jos�','Fonte','Portugal',0,0,0,0,0)
Insert into jugadores values
('Nif',33106088,'Nuno','Mendes','Portugal',0,0,0,0,0)
Insert into jugadores values
('Nif',34106066,'Raphael','Guerreiro','Portugal',0,0,0,0,0)
Insert into jugadores values
('Nif',35106033,'Ruben','Dias','Portugal',0,0,0,0,0)
Insert into jugadores values
('Nif',36106022,'Bernardo','Silva','Portugal',0,0,0,0,0)
Insert into jugadores values
('Nif',37106082,'Bruno','Fernandes','Portugal',0,0,0,0,0)
Insert into jugadores values
('Nif',38106083,'Danilo','Pereira','Portugal',0,0,0,0,0)
Insert into jugadores values
('Nif',39106087,'Renato','Sanches','Portugal',0,0,0,0,0)
Insert into jugadores values
('Nif',30116089,'Diogo','Jota','Portugal',0,0,0,0,0)
Insert into jugadores values
('Nif',37777777,'Cristiano','Ronaldo','Portugal',0,0,0,0,0)
Insert into jugadores values
('Nif',30116084,'Ruben','Neves','Portugal',0,0,0,0,0)
Insert into jugadores values
('Nif',30004456,'Gonzalo','Guedes','Portugal',0,0,0,0,0)

--Ghana
Insert into jugadores values
('IdA', 10201020,'Joe','Wollacott','Ghana',0,0,0,0,0)
Insert into jugadores values
('IdA', 11211127,'Daniel','Amartey','Ghana',0,0,0,0,0)
Insert into jugadores values
('IdA', 11231425,'Alexander','Djiku','Ghana',0,0,0,0,0)
Insert into jugadores values
('IdA', 15241322,'Gideon','Mensah','Ghana',0,0,0,0,0)
Insert into jugadores values
('IdA', 19291827,'Andy','Yiadom','Ghana',0,0,0,0,0)
Insert into jugadores values
('IdA', 18281828,'Iddrisu','Baba','Ghana',0,0,0,0,0)
Insert into jugadores values
('IdA', 17271727,'Mohammedd','Kudus','Ghana',0,0,0,0,0)
Insert into jugadores values
('IdA', 17271726,'Thomas','Partey','Ghana',0,0,0,0,0)
Insert into jugadores values
('IdA', 16251625,'Mubarak','Wakaso','Ghana',0,0,0,0,0)
Insert into jugadores values
('IdA', 15251525,'Felix','Gyan','Ghana',0,0,0,0,0)
Insert into jugadores values
('IdA', 14241020,'Andre','Ayew','Ghana',0,0,0,0,0)
Insert into jugadores values
('IdA', 13303023,'Jordan','Ayew','Ghana',0,0,0,0,0)
Insert into jugadores values
('IdA', 12221222,'Issahuku','Fatawu','Ghana',0,0,0,0,0)
Insert into jugadores values
('IdA', 11211121,'Kamaldeen','Essien','Ghana',0,0,0,0,0)
Insert into jugadores values
('IdA', 12233301,'Wachu','Wassabrava','Ghana',0,0,0,0,0)

--Uruguay
Insert into jugadores values
('doc', 50430145,'Fernando','Muslera','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 51234567,'Ronald','Araujo','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 55488866,'Martin','Caceres','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 57890023,'Jose','Gimenez','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 60852364,'Diego','Godin','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 50135468,'Mathis','Olivera','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 57854126,'Matias','Vina','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 58886523,'Rodrigo','Bentancur','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 50456895,'Nicolas','De La Cruz','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 55002098,'Lucas','Torreira','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 53433193,'Federico','Valverde','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 52422292,'Edinson','Cavani','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 51412191,'Luis','Suarez','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 50402090,'Darwin','Nunez','Uruguay',0,0,0,0,0)

--Corea Del Sur
Insert into jugadores values
('DA', 65432198,'Seung','Kim','Corea Del Sur',0,0,0,0,0)
Insert into jugadores values
('DA', 60402090,'Hyeon','Woojo','Corea Del Sur',0,0,0,0,0)
Insert into jugadores values
('DA', 64412491,'Chul','Hong','Corea Del Sur',0,0,0,0,0)
Insert into jugadores values
('DA', 65771468,'Tae','Kim','Corea Del Sur',0,0,0,0,0)
Insert into jugadores values
('DA', 65656565,'Min','Kim','Corea Del Sur',0,0,0,0,0)
Insert into jugadores values
('DA', 67852146,'Young','Lee','Corea Del Sur',0,0,0,0,0)
Insert into jugadores values
('DA', 63562123,'Inboem','Hwang','Corea Del Sur',0,0,0,0,0)
Insert into jugadores values
('DA', 69999666,'Wooyoung','Jung','Corea Del Sur',0,0,0,0,0)
Insert into jugadores values
('DA', 62224445,'Jaesung','Lee','Corea Del Sur',0,0,0,0,0)
Insert into jugadores values
('DA', 69632587,'Seung','Hopaik','Corea Del Sur',0,0,0,0,0)
Insert into jugadores values
('DA', 60005554,'Gue','Cho','Corea Del Sur',0,0,0,0,0)
Insert into jugadores values
('DA', 69632500,'Heung Mee','Son','Corea Del Sur',0,0,0,0,0)
Insert into jugadores values
('DA', 60101010,'Ui','Wanga','Corea Del Sur',0,0,0,0,0)
Insert into jugadores values
('DA', 69764310,'Chui','Mulang','Corea Del Sur',0,0,0,0,0)

Select * from jugadores WHERE pais ='Argentina'

Create table Partido(
id int identity(1,1),
pais_1 varchar(15),
goles_p1 int,
pais_2 varchar(15),
goles_p2 int,
tipo_doc_arb varchar(5),
nro_doc_arb int,
fecha datetime,
Ronda int,
Grupo varchar(5),
Ganador varchar(15),
estadio varchar(32),
borrado bit,
constraint pk_partido primary key (id),
constraint ck_id_part check((id) between 1 and 64),
constraint fk_arb_pais foreign key(tipo_doc_arb,nro_doc_arb) references arbitro(tipo_doc,nro_doc),
constraint fk_pais1 foreign key (pais_1) references pais(nombre),
constraint fk_pais2 foreign key (pais_2) references pais(nombre),
constraint fk_partido_estadio foreign key (estadio) references estadio(nombre))


Insert into partido values
('Qatar',0,'Ecuador',0,'Dni','30303030', convert(date,'20/11/22', 3),1,'A',null,'Al-Thumama',0)
Insert into partido values
('Inglaterra',0,'Iran',0,'Id','32451323',convert(date,'21/11/22', 3),1,'B',null,'Al Janoub',0)
Insert into partido values
('Senegal',0,'Paises Bajos',0,'Pass','41231444',convert(date,'21/11/22', 3),1,'A',null,'Ic�nico de Lusail',0)
Insert into partido values
('Estados Unidos',0,'Gales',0,'Id','32451323',convert(date,'21/11/22', 3),1,'B',null,'Qatar Foundation',0)
-- A LOS DE ABAJO LES FALTA EL GRUPO DESPUES DEL IDRONDA
Insert into partido values
('Argentina',null,'Arabia Saudita',null,'Id','32451323',convert(date,'22/11/22', 3),1,'C',null,'Al-Thumama',0)
Insert into partido values
('Dinamarca',null,'Tunez',null,'Pass','41231444',convert(date,'22/11/22', 3),1,'D',null,'Al Janoub',0)
Insert into partido values
('Mexico',null,'Polonia',null,'Id','32451323',convert(date,'22/11/22', 3),1,'C',null,'Ic�nico de Lusail',0)
Insert into partido values
('Francia',null,'Australia',null,'Id','32451323',convert(date,'22/11/22', 3),1,'D',null,'Qatar Foundation',0)
Insert into partido values
('Marruecos',null,'Croacia',null,'Dni','30303030',convert(date,'23/11/22', 3),1,'F',null,'Al Bayt',0)
Insert into partido values
('Alemania',null,'Japon',null,'Id','32451323',convert(date,'23/11/22', 3),1,'E',null,'Al-Thumama',0)
Insert into partido values
('Espana',null,'Costa Rica',null,'Pass','41231444',convert(date,'23/11/22', 3),1,'E',null,'Al Janoub',0)
Insert into partido values
('Belgica',null,'Canada',null,'Id','32451323',convert(date,'23/11/22', 3),1,'F',null,'Ic�nico de Lusail',0)
Insert into partido values
('Suiza',null,'Camerun',null,'Id','32451323',convert(date,'24/11/22', 3),1,'G',null,'Qatar Foundation',0)
Insert into partido values
('Uruguay',null,'Corea del Sur',null,'Dni','30303030',convert(date,'24/11/22', 3),1,'H',null,'Al Bayt',0)
Insert into partido values
('Portugal',null,'Ghana',null,'Id','32451323',convert(date,'24/11/22', 3),1,'H',null,'Al-Thumama',0)
Insert into partido values
('Brasil',null,'Serbia',null,'Id','32451323',convert(date,'24/11/22', 3),1,'G',null,'Al Janoub',0)
--Fecha 2 fase de grupos
Insert into partido values
('Gales',null,'Iran',null,'Pass','41231444',convert(date,'25/11/22', 3),1,'B',null,null,0)
Insert into partido values
('Qatar',null,'Senegal',null,'Id','32451323',convert(date,'25/11/22', 3),1,'A',null,null,0)
Insert into partido values
('Paises Bajos',null,'Ecuador',null,'Id','32451323',convert(date,'25/11/22', 3),1,'A',null,null,0)
Insert into partido values
('Inglaterra',null,'Estados Unidos',null,'Id','32451323',convert(date,'25/11/22', 3),1,'B',null,null,0)
Insert into partido values
('Tunez',null,'Australia',null,'Pass','41231444',convert(date,'26/11/22', 3),1,'D',null,null,0)
Insert into partido values
('Polonia',null,'Arabia Saudita',null,'Id','32451323',convert(date,'26/11/22', 3),1,'C',null,null,0)
Insert into partido values
('Francia',null,'Dinamarca',null,'Dni','30303030',convert(date,'26/11/22', 3),1,'D',null,null,0)
Insert into partido values
('Argentina',null,'Mexico',null,'Id','32451323',convert(date,'26/11/22', 3),1,'C',null,null,0)
Insert into partido values
('Japon',null,'Costa Rica',null,'Pass','41231444',convert(date,'27/11/22', 3),1,'E',null,null,0)
Insert into partido values
('Belgica',null,'Marruecos',null,'Id','32451323',convert(date,'27/11/22', 3),1,'F',null,null,0)
Insert into partido values
('Croacia',null,'Canada',null,'Dni','30303030',convert(date,'27/11/22', 3),1,'F',null,null,0)
Insert into partido values
('Espana',null,'Alemania',null,'Id','32451323',convert(date,'27/11/22', 3),1,'E',null,null,0)
Insert into partido values
('Camerun',null,'Serbia',null,'Id','32451323',convert(date,'28/11/22', 3),1,'G',null,null,0)
Insert into partido values
('Corea del Sur',null,'Ghana',null,'Pass','41231444',convert(date,'28/11/22', 3),1,'H',null,null,0)
Insert into partido values
('Brasil',null,'Suiza',null,'Id','32451323',convert(date,'28/11/22', 3),1,'G',null,null,0)
Insert into partido values
('Portugal',null,'Uruguay',null,'Pass','41231444',convert(date,'28/11/22', 3),1,'H',null,null,0)
--Fecha 3 fase de grupos
Insert into partido values
('Paises Bajos',null,'Qatar',null,'Pass','41231444',convert(date,'29/11/22', 3),1,'A',null,null,0)
Insert into partido values
('Ecuador',null,'Senegal',null,'Id','32451323',convert(date,'29/11/22', 3),1,'A',null,null,0)
Insert into partido values
('Gales',null,'Inglaterra',null,'Dni','30303030',convert(date,'29/11/22', 3),1,'B',null,null,0)
Insert into partido values
('Iran',null,'Estados Unidos',null,'Id','32451323',convert(date,'29/11/22', 3),1,'B',null,null,0)
Insert into partido values
('Tunez',null,'Francia',null,'Pass','41231444',convert(date,'30/11/22', 3),1,'D',null,null,0)
Insert into partido values
('Australia',null,'Dinamarca',null,'Dni','30303030',convert(date,'30/11/22', 3),1,'D',null,null,0)
Insert into partido values
('Polonia',null,'Argentina',null,'Id','32451323',convert(date,'30/11/22', 3),1,'C',null,null,0)
Insert into partido values
('Arabia Saudita',null,'Mexico',null,'Id','32451323',convert(date,'30/11/22', 3),1,'C',null,null,0)
Insert into partido values
('Croacia',null,'Belgica',null,'Pass','41231444',convert(date,'1/12/22', 3),1,'F',null,null,0)
Insert into partido values
('Canada',null,'Marruecos',null,'Id','32451323',convert(date,'1/12/22', 3),1,'F',null,null,0)
Insert into partido values
('Japon',null,'Espana',null,'Id','32451323',convert(date,'1/12/22', 3),1,'E',null,null,0)
Insert into partido values
('Costa Rica',null,'Alemania',null,'Dni','30303030',convert(date,'1/12/22', 3),1,'E',null,null,0)
Insert into partido values
('Corea del Sur',null,'Portugal',null,'Id','32451323',convert(date,'2/12/22', 3),1,'H',null,null,0)
Insert into partido values
('Ghana',null,'Uruguay',null,'Pass','41231444',convert(date,'2/12/22', 3),1,'H',null,null,0)
Insert into partido values
('Camerun',null,'Brasil',null,'Id','32451323',convert(date,'2/12/22', 3),1,'G',null,null,0)
Insert into partido values
('Serbia',null,'Suiza',null,'Dni','30303030',convert(date,'2/12/22', 3),1,'G',null,null,0)

update Partido
set goles_p2= 0
update Partido
set goles_p1= 0


Create Table EventoPartido(
id_evento int identity(1,1),
id_partido int,
minuto int,
tipo_doc_jg varchar(5),
nro_doc_jg int,
evento varchar(32),
borrado bit,
constraint pk_evento Primary Key (id_evento),
constraint fk_id_evento_partido foreign key (id_partido) references partido (id),
constraint fk_jg_evento foreign key (tipo_doc_jg,nro_doc_jg) references jugadores (tipo_doc,nro_doc),
constraint ck_evento check(evento in('Gol','Asistencia','Tarjeta Amarilla','Tarjeta Roja')))

--Insert into EventoPartido Values(5,90,'Dni',33016240,'Gol',0)


--Select e.id_partido,e.minuto,e.evento,jg.nombre,jg.apellido from eventoPartido e join jugadores jg on(jg.tipo_doc=e.tipo_doc_jg and jg.nro_doc=e.nro_doc_jg)