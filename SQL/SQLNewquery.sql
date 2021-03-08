Create database ASG

CREATE TABLE ASGGuns(GunModel nvarchar(50), GunType nvarchar(50), VelocityFPS int, MagCapacity int, PoweredBY nvarchar(50));
Alter table ASGGuns add IDGunModel int not null IDenTITY(1,1) Primary Key

create table ShooterCollection(ShooterName nvarchar(50), DateCrated date, IDGunModelFK int, ); 
alter table ShooterCollection add FOREIGN KEY (IDGunModelFK) REFERENCES ASGGuns(IDGunModel);
alter table ShooterCollection add IDShooter int not null IDenTITY(1,1) Primary Key

create table Scores(ProgramMode nvarchar(50),MinTime decimal(9,2), AVGTime decimal(9,2), MaxTime decimal(9,2), IDShooterFK int); 
Alter table Scores
add IDScore int not null IDenTITY(1,1) Primary Key
alter table Scores
add FOREIGN KEY (IDShooterFK) REFERENCES ShooterCollection(IDShooter);

drop table ShooterCollection
drop table Scores
drop table ASGGuns
