--Create Database Qatar2022


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
contraseña varchar(15),
rol_id int,
borrado bit,
constraint user_pk Primary key (id),
CONSTRAINT fk_idPerfil FOREIGN KEY (rol_id) REFERENCES perfil (id))

Insert into Usuario values('Franfe','losguerrerosZ',1,0)

Insert into Usuario values('Ralfi','kobe',1,0)

Insert into Usuario values('Pedriskol','messismo',1,0)

Insert into Usuario values('Luquitas','tester',2,0)

Insert into Usuario values('Robert','user',3,0)

insert into Usuario values('CR7','password',3,0)

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
'Icónico de Lusail','Lusail',80000,0)
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
Insert into Pais values('España',3,'E',0,6,0)
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
'Juan Pablo','Ramos','Pass','41231444','España',0)

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
('RDA',11110006,'Piero','Hincapié','Ecuador',0,0,0,0,0)
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
('IdA',15110000,'Sadio','Mané','Senegal',0,0,0,0,0)

--Paises Bajos
Insert into jugadores values
('RDE',16110000,'Jasper','Cillessen','Paises Bajos',0,0,0,0,0)
Insert into jugadores values
('RDE',17110000,'Virgil','Van Dijk','Paises Bajos',0,0,0,0,0)
Insert into jugadores values
('RDE',18110000,'Frenkie','De Jong','Paises Bajos',0,0,0,0,0)
Insert into jugadores values
('RDE',19110000,'Georginio','Wijnaldum','Paises Bajos',0,0,0,0,0)
Insert into jugadores values
('RDE',11010000,'Memphis','Depay','Paises Bajos',0,0,0,0,0)

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
('id',16710120,'Sergiño','Dest','Estados Unidos',0,0,0,0,0)
Insert into jugadores values
('id',16710130,'Andre','Yedlin','Estados Unidos',0,0,0,0,0)
Insert into jugadores values
('id',16710140,'Tyler','Adams','Estados Unidos',0,0,0,0,0)
Insert into jugadores values
('id',16710150,'Christian','Pulisic','Estados Unidos',0,0,0,0,0)

--Gales
Insert into jugadores values
('RDE',16810001,'Danny','Ward','Gales',0,0,0,0,0)
Insert into jugadores values
('RDE',16810002,'Ben','Davies','Gales',0,0,0,0,0)
Insert into jugadores values
('RDE',16810003,'Joe','Allen','Gales',0,0,0,0,0)
Insert into jugadores values
('RDE',16810004,'Aaron','Ramsey','Gales',0,0,0,0,0)
Insert into jugadores values
('RDE',16810005,'Gareth','Bale','Gales',0,0,0,0,0)

--Grupo C
--Argentina
Insert into jugadores values
('Dni',33016244,'Emiliano','Martinez','Argentina',0,0,0,0,0)
Insert into jugadores values
('Dni',30017292,'Marcos','Acuña','Argentina',0,0,0,0,0)
Insert into jugadores values
('Dni',29816224,'Nahuel','Molina','Argentina',0,0,0,0,0)
Insert into jugadores values
('Dni',35916284,'Nicolás','Otamendi','Argentina',0,0,0,0,0)
Insert into jugadores values
('Dni',37516545,'Cristian','Romero','Argentina',0,0,0,0,0)
Insert into jugadores values
('Dni',37013264,'Rodirgo','De Paul','Argentina',0,0,0,0,0)
Insert into jugadores values
('Dni',38007540,'Lisandro','Martinez','Argentina',0,0,0,0,0)
Insert into jugadores values
('Dni',31896241,'Ángel','Di María','Argentina',0,0,0,0,0)
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
('cpv',30207050,'Nestor','Araújo','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',33247456,'Jesús','Gallardo','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',35547876,'César','Montes','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',37167756,'Héctor','Montero','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',39247252,'Luis','Romo','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',35217555,'Edson','Álvarez','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',32244856,'Jesús','Corona','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',30200846,'Andrés','Guardado','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',39544656,'Héctor','Herrera','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',29247850,'Rogelio','Funes Mori','Mexico',0,0,0,0,0)
Insert into jugadores values
('cpv',37124776,'Raúl','Gimenez','Mexico',0,0,0,0,0)
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
('RDE',16910001,'Hugo','Lloris','Francia',0,0,0,0,0)
Insert into jugadores values
('RDE',16950001,'Maestro','Kimpembe','Francia',0,0,0,0,0)
Insert into jugadores values
('RDE',16960001,'Ngolo','Kanté','Francia',0,0,0,0,0)
Insert into jugadores values
('RDE',16970001,'Kylian','Mbappe','Francia',0,0,0,0,0)
Insert into jugadores values
('RDE',16980001,'Karim','Benzema','Francia',0,0,0,0,0)

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
('RDE',1880001,'Kasper','Schmeichel','Dinamarca',0,0,0,0,0)
Insert into jugadores values
('RDE',1880002,'Simon','Kjaer','Dinamarca',0,0,0,0,0)
Insert into jugadores values
('RDE',1880003,'Thomas','Delaney','Dinamarca',0,0,0,0,0)
Insert into jugadores values
('RDE',1880004,'Chistian','Eriksen','Dinamarca',0,0,0,0,0)
Insert into jugadores values
('RDE',1880005,'Kasper','Dolberg','Dinamarca',0,0,0,0,0)

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
--España
Insert into jugadores values
('Pass',20490001,'Unai','Simon','España',0,0,0,0,0)
Insert into jugadores values
('Pass',20490002,'Jordi','Alba','España',0,0,0,0,0)
Insert into jugadores values
('Pass',20490003,'Marcos','Llorente','España',0,0,0,0,0)
Insert into jugadores values
('Pass',20490004,'Ansu','Fati','España',0,0,0,0,0)
Insert into jugadores values
('Pass',20490005,'Alvaro','Morata','España',0,0,0,0,0)

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

--Japón
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
--Bélgica
Insert into jugadores values
('RDE',56785301,'Tibu','Couttois','Belgica',0,0,0,0,0)
Insert into jugadores values
('RDE',56785302,'Thomas','Meunier','Belgica',0,0,0,0,0)
Insert into jugadores values
('RDE',56785303,'Kevin','De Bruyne','Belgica',0,0,0,0,0)
Insert into jugadores values
('RDE',56785304,'Eden','Hazard','Belgica',0,0,0,0,0)
Insert into jugadores values
('RDE',56785305,'Romelu','Lukaku','Belgica',0,0,0,0,0)

--Canada
Insert into jugadores values
('di',36885809,'Milan','Borjan','Canada',0,0,0,0,0)
Insert into jugadores values
('di',36885809,'Alphonso','Davies','Canada',0,0,0,0,0)
Insert into jugadores values
('di',36885809,'Doniel','Henry','Canada',0,0,0,0,0)
Insert into jugadores values
('di',36885809,'Samuel','Piette','Canada',0,0,0,0,0)
Insert into jugadores values
('di',36885809,'Cyle','Larin','Canada',0,0,0,0,0)

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
('RDE',20835500,'Dominik','Livakovic','Croacia',0,0,0,0,0)
Insert into jugadores values
('RDE',20835501,'Dejan','Lovren','Croacia',0,0,0,0,0)
Insert into jugadores values
('RDE',20835502,'Luka','Modric','Croacia',0,0,0,0,0)
Insert into jugadores values
('RDE',20835503,'Ivan','Perisic','Croacia',0,0,0,0,0)
Insert into jugadores values
('RDE',20835504,'Mario','Manduzukic','Croacia',0,0,0,0,0)

--Grupo G
--Brasil
Insert into jugadores values
('RDA',33225500,'Alisson','Moraes','Brasil',0,0,0,0,0)
Insert into jugadores values
('RDA',33225500,'Eder','Militao','Brasil',0,0,0,0,0)
Insert into jugadores values
('RDA',33225500,'Lucas','Paquetá','Brasil',0,0,0,0,0)
Insert into jugadores values
('RDA',33225500,'Neymar','Jr','Brasil',0,0,0,0,0)
Insert into jugadores values
('RDA',33225500,'Grabriel','Jesus','Brasil',0,0,0,0,0)

--Serbia
Insert into jugadores values
('RDE',18293745,'Predrag','Rajkovic','Serbia',0,0,0,0,0)
Insert into jugadores values
('RDE',18293746,'Nikola','Milenkovic','Serbia',0,0,0,0,0)
Insert into jugadores values
('RDE',18293747,'Sasa','Lukic','Serbia',0,0,0,0,0)
Insert into jugadores values
('RDE',18293748,'Luka','Jovic','Serbia',0,0,0,0,0)
Insert into jugadores values
('RDE',18293749,'Milinkovic','Savic','Serbia',0,0,0,0,0)

--Suiza
Insert into jugadores values
('RDE',34679122,'Yann','Sommer','Suiza',0,0,0,0,0)
Insert into jugadores values
('RDE',34679123,'Manuel','Akanji','Suiza',0,0,0,0,0)
Insert into jugadores values
('RDE',34679124,'Xherdan','Shaqiri','Suiza',0,0,0,0,0)
Insert into jugadores values
('RDE',34679125,'Grant','Xhaka','Suiza',0,0,0,0,0)
Insert into jugadores values
('RDE',34679126,'Haris','Seferovic','Suiza',0,0,0,0,0)

--Camerún
Insert into jugadores values
('RDA',22583140,'André','Onana','Camerun',0,0,0,0,0)
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
('Nif',32106091,'José','Fonte','Portugal',0,0,0,0,0)
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
('doc', 55488866,'Martín','Cáceres','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 57890023,'José','Gimenez','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 60852364,'Diego','Godín','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 50135468,'Mathis','Olivera','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 57854126,'Matías','Viña','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 58886523,'Rodrigo','Bentancur','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 50456895,'Nicolás','De La Cruz','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 55002098,'Lucas','Torreira','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 53433193,'Federico','Valverde','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 52422292,'Edinson','Cavani','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 51412191,'Luis','Suarez','Uruguay',0,0,0,0,0)
Insert into jugadores values
('doc', 50402090,'Darwin','Nuñez','Uruguay',0,0,0,0,0)

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

Select * from jugadores

Create table Partido(
id int,
pais_1 varchar(15),
goles_p1 int,
pais_2 varchar(15),
goles_p2 int,
tipo_doc_arb varchar(5),
nro_doc_arb int,
fecha datetime,
Ronda int,
Ganador varchar(15),
borrado bit,
constraint pk_partido primary key (id),
constraint ck_id_part check((id) between 1 and 64),
constraint fk_arb_pais foreign key(tipo_doc_arb,nro_doc_arb) references arbitro(tipo_doc,nro_doc),
constraint fk_pais1 foreign key (pais_1) references pais(nombre),
constraint fk_pais2 foreign key (pais_2) references pais(nombre),
constraint fk_ganador foreign key (ganador) references pais(nombre))

Insert into partido values
(1,'Qatar',null,'Ecuador',null,'Dni','30303030', convert(date,'20/11/22', 3),1,null,0)
Insert into partido values
(2,'Inglaterra',null,'Iran',null,'Id','32451323',convert(date,'21/11/22', 3),1,null,0)
Insert into partido values
(3,'Senegal',null,'Paises Bajos',null,'Pass','41231444',convert(date,'21/11/22', 3),1,null,0)
Insert into partido values
(4,'Estados Unidos',null,'Gales',null,'Id','32451323',convert(date,'21/11/22', 3),1,null,0)
Insert into partido values
(5,'Argentina',null,'Arabia Saudita',null,'Id','32451323',convert(date,'22/11/22', 3),1,null,0)
Insert into partido values
(6,'Dinamarca',null,'Tunez',null,'Pass','41231444',convert(date,'22/11/22', 3),1,null,0)
Insert into partido values
(7,'Mexico',null,'Polonia',null,'Id','32451323',convert(date,'22/11/22', 3),1,null,0)
Insert into partido values
(8,'Francia',null,'Australia',null,'Id','32451323',convert(date,'22/11/22', 3),1,null,0)
Insert into partido values
(9,'Marruecos',null,'Croacia',null,'Dni','30303030',convert(date,'23/11/22', 3),1,null,0)
Insert into partido values
(10,'Alemania',null,'Japon',null,'Id','32451323',convert(date,'23/11/22', 3),1,null,0)
Insert into partido values
(11,'España',null,'Costa Rica',null,'Pass','41231444',convert(date,'23/11/22', 3),1,null,0)
Insert into partido values
(12,'Belgica',null,'Canada',null,'Id','32451323',convert(date,'23/11/22', 3),1,null,0)
Insert into partido values
(13,'Suiza',null,'Camerun',null,'Id','32451323',convert(date,'24/11/22', 3),1,null,0)
Insert into partido values
(14,'Uruguay',null,'Corea del Sur',null,'Dni','30303030',convert(date,'24/11/22', 3),1,null,0)
Insert into partido values
(15,'Portugal',null,'Ghana',null,'Id','32451323',convert(date,'24/11/22', 3),1,null,0)
Insert into partido values
(16,'Brasil',null,'Serbia',null,'Id','32451323',convert(date,'24/11/22', 3),1,null,0)
Insert into partido values
--Fecha 2 fase de grupos
(17,'Gales',null,'Iran',null,'Pass','41231444',convert(date,'25/11/22', 3),1,null,0)
Insert into partido values
(18,'Qatar',null,'Senegal',null,'Id','32451323',convert(date,'25/11/22', 3),1,null,0)
Insert into partido values
(19,'Paises Bajos',null,'Ecuador',null,'Id','32451323',convert(date,'25/11/22', 3),1,null,0)
Insert into partido values
(20,'Inglaterra',null,'Estados Unidos',null,'Id','32451323',convert(date,'25/11/22', 3),1,null,0)
Insert into partido values
(21,'Tunez',null,'Australia',null,'Pass','41231444',convert(date,'26/11/22', 3),1,null,0)
Insert into partido values
(22,'Polonia',null,'Arabia Saudita',null,'Id','32451323',convert(date,'26/11/22', 3),1,null,0)
Insert into partido values
(23,'Francia',null,'Dinamarca',null,'Dni','30303030',convert(date,'26/11/22', 3),1,null,0)
Insert into partido values
(24,'Argentina',null,'Mexico',null,'Id','32451323',convert(date,'26/11/22', 3),1,null,0)
Insert into partido values
(25,'Japon',null,'Costa Rica',null,'Pass','41231444',convert(date,'27/11/22', 3),1,null,0)
Insert into partido values
(26,'Belgica',null,'Marruecos',null,'Id','32451323',convert(date,'27/11/22', 3),1,null,0)
Insert into partido values
(27,'Croacia',null,'Canada',null,'Dni','30303030',convert(date,'27/11/22', 3),1,null,0)
Insert into partido values
(28,'España',null,'Alemania',null,'Id','32451323',convert(date,'27/11/22', 3),1,null,0)
Insert into partido values
(29,'Camerun',null,'Serbia',null,'Id','32451323',convert(date,'28/11/22', 3),1,null,0)
Insert into partido values
(30,'Corea del Sur',null,'Ghana',null,'Pass','41231444',convert(date,'28/11/22', 3),1,null,0)
Insert into partido values
(31,'Brasil',null,'Suiza',null,'Id','32451323',convert(date,'28/11/22', 3),1,null,0)
Insert into partido values
(32,'Portugal',null,'Uruguay',null,'Pass','41231444',convert(date,'28/11/22', 3),1,null,0)
--Fecha 3 fase de grupos
Insert into partido values
(33,'Paises Bajos',null,'Qatar',null,'Pass','41231444',convert(date,'29/11/22', 3),1,null,0)
Insert into partido values
(34,'Ecuador',null,'Senegal',null,'Id','32451323',convert(date,'29/11/22', 3),1,null,0)
Insert into partido values
(35,'Gales',null,'Inglaterra',null,'Dni','30303030',convert(date,'29/11/22', 3),1,null,0)
Insert into partido values
(36,'Iran',null,'Estados Unidos',null,'Id','32451323',convert(date,'29/11/22', 3),1,null,0)
Insert into partido values
(37,'Tunez',null,'Francia',null,'Pass','41231444',convert(date,'30/11/22', 3),1,null,0)
Insert into partido values
(38,'Australia',null,'Dinamarca',null,'Dni','30303030',convert(date,'30/11/22', 3),1,null,0)
Insert into partido values
(39,'Polonia',null,'Argentina',null,'Id','32451323',convert(date,'30/11/22', 3),1,null,0)
Insert into partido values
(40,'Arabia Saudita',null,'Mexico',null,'Id','32451323',convert(date,'30/11/22', 3),1,null,0)
Insert into partido values
(41,'Croacia',null,'Belgica',null,'Pass','41231444',convert(date,'1/12/22', 3),1,null,0)
Insert into partido values
(42,'Canada',null,'Marruecos',null,'Id','32451323',convert(date,'1/12/22', 3),1,null,0)
Insert into partido values
(43,'Japon',null,'España',null,'Id','32451323',convert(date,'1/12/22', 3),1,null,0)
Insert into partido values
(44,'Costa Rica',null,'Alemania',null,'Dni','30303030',convert(date,'1/12/22', 3),1,null,0)
Insert into partido values
(45,'Corea del Sur',null,'Portugal',null,'Id','32451323',convert(date,'2/12/22', 3),1,null,0)
Insert into partido values
(46,'Ghana',null,'Uruguay',null,'Pass','41231444',convert(date,'2/12/22', 3),1,null,0)
Insert into partido values
(47,'Camerun',null,'Brasil',null,'Id','32451323',convert(date,'2/12/22', 3),1,null,0)
Insert into partido values
(48,'Serbia',null,'Suiza',null,'Dni','30303030',convert(date,'2/12/22', 3),1,null,0)

Create Table EventoPartido(
id_partido int,
minuto int,
tipo_doc_jg varchar(5),
nro_doc_jg int,
evento varchar(32),
borrado bit,
constraint pk_evento Primary Key (id_partido,minuto,tipo_doc_jg,nro_doc_jg),
constraint fk_id_evento_partido foreign key (id_partido) references partido (id),
constraint fk_jg_evento foreign key (tipo_doc_jg,nro_doc_jg) references jugadores (tipo_doc,nro_doc),
constraint ck_evento check(evento in('Gol','Asistencia','Tarjeta Amarilla','Tarjeta Roja')))

--Insert into EventoPartido Values(1,15,'Dni',33016240,'Gol',0)

--Select e.id_partido,e.minuto,e.evento,jg.nombre,jg.apellido from eventoPartido e join jugadores jg on(jg.tipo_doc=e.tipo_doc_jg and jg.nro_doc=e.nro_doc_jg)