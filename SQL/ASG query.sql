Create database ASG
CREATE TABLE Bronie_ASG(Model_Broni nvarchar(50), Typ nvarchar(50), FPS int, Pojemnoœæ_magazynka int, Napêd nvarchar(50));
Alter table Bronie_ASG
add Id int not null IDenTITY(1,1) Primary Key
create table Walhalla(Nazwa_Strzelca nvarchar(50), Model_Broni nvarchar(50), Typ nvarchar(50), Data_utworzenia date, minmalny_czas decimal(9,2), sredni_czas decimal(9,2)); 
Alter table Walhalla
add Id int not null IDenTITY(1,1) Primary Key

select Nazwa_Strzelca, model_broni, Typ, minmalny_czas, sredni_czas,Data_utworzenia from Walhalla order by sredni_czas

drop table walhalla

select * from Walhalla

select * from Bronie_ASG

Insert INTO Bronie_ASG VALUES('CZ-47','pistolet','333','2000','pneumatuczny');
Insert INTO Bronie_ASG VALUES('M4A1','karabin automatyczny','420','3000','elektryczny'); 
Insert INTO Bronie_ASG VALUES('Dragonov','karabin snajperski','600','3000','sprê¿yna'); 
Insert INTO Bronie_ASG VALUES('AWP','karabin snajperski','600','3000','sprê¿yna'); 
Insert INTO Bronie_ASG VALUES('SR36 KV gen. III ','karabin automatyczny','430','2500','elektryczny'); 
 SR36 KV [SRC] gen.III - 1 szt



Insert INTO Walhalla VALUES('Mirek','beretta','pistolet','2017-02-11','4.2','3.5');
Insert INTO Walhalla VALUES('Chewbacca','kusza enegetyczna','kusza','2017-02-11','3.1','2.2'); 
Insert INTO Walhalla VALUES('Hayha','Dragonov','karabin snajperski','2017-02-13 ','1.8','2.7'); 
Insert INTO Walhalla VALUES('Harrison','AWM','karabin snajperski','2017-02-15','1.6','5.1'); 
Insert INTO Walhalla VALUES('Donald','Colt M1911','pistolet','2017-02-15','3.3','7.1');
Insert INTO Walhalla VALUES('Alibaba','AK-47','karabin automatyczny','2017-02-15','3.3','7.1');
Insert INTO Walhalla VALUES('Kenedy','Carcano Mod. 91','karabin powtarzalny','2017-11-22','4.3','5.1');
Insert INTO Walhalla VALUES('Adolf','Walther','pistolet','2017-03-30','2.3','3.1');
Insert INTO Walhalla VALUES('Rambo','M60 ','karabin maszynowy','2017-07-06','3.8','4.1');
Insert INTO Walhalla VALUES('Terminator','M134 Minigun ','karabin maszynowy','2017-07-30','2.5','3.1');




select model_broni from bronie_ASG
select typ, FPS from bronie_ASG where model_broni='AK'

select typ from bronie_ASG where id = 1


//do testow
CREATE TABLE Bron(Modek_Broni nvarchar(50))
Insert INTO bron VALUES('ash');


delete from Bronie_ASG where model_broni='fghj2';
"drop table Bronie_ASG"
//do testow