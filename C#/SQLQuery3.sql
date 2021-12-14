create database SupermarketAdmin


create table Cashier(
jobNumber varchar(50) not null primary key,
name varchar(20),
password varchar(20),
phone varchar(20)
)
insert into Cashier
values('1','С��','123','13420007330'),
('2','С��','123','13420007330'),
('3','С��','123','13420007330'),
('4','С��','123','13420007330');

create table Warehouser(
jobNumber varchar(50) not null primary key,
name varchar(20),
password varchar(20),
phone varchar(20)
)

insert into Warehouser
values('1','С��','123','13420007330'),
('2','С��','123','13420007330'),
('3','С��','123','13420007330'),
('4','С��','123','13420007330');


create table Manufacturer(
encode varchar(50) not null primary key,
name varchar(20),
site varchar(20),
linkman varchar(20),
phone varchar(20),
)
insert into Manufacturer
values('1','��Ӧ��1','����','����','13420007330'),
      ('2','��Ӧ��2','����','����','13420007330'),
      ('3','��Ӧ��3','�Ϻ�','����','13420007330'),
      ('4','��Ӧ��4','�Ĵ�','����','13420007330');


create table Commodity( 
id varchar(50) not null primary key,
name varchar(50),
price varchar(20),
supplierEncode varchar(50),
)

insert into Commodity
values('42432','����','100','1'),
      ('53543','����','100','1'),
      ('54634','����','100','2'),
      ('1245234','����','100','4'),
      ('425324','����','100','3');



create table CommodityOutList(
serialNumber varchar(50) not null primary key,
jobNumber varchar(50),
commodityId varchar(50),
time varchar(50), 
)
insert into CommodityOutList
values('124213421421','1','42432','8:12'),
      ('124124214244','2','54634','2:14'),
      ('124112444334','1','1245234','3:12'),
      ('124124142414','3','425324','5:18'),
      ('124124214412','4','1245234','9:19');

create table CommodityInputList(
serialNumber varchar(50) not null primary key,
jobNumber varchar(50),
commodityId varchar(50),
time varchar(50),
)
insert into CommodityInputList
values('124213421421','1','42432','8:12'),
      ('124124214244','2','54634','2:14'),
      ('124112444334','1','1245234','3:12'),
      ('124124142414','3','425324','5:18'),
      ('124124214412','4','1245234','9:19');


alter table Commodity
add constraint fk_supplier foreign key(supplierEncode) references
Manufacturer(encode)

alter table CommodityOutList
add constraint fk_CashierNumber foreign key(jobNumber) references
Cashier(jobNumber)
alter table CommodityOutList
add constraint fk_OutNumber foreign key(commodityId) references
Commodity(id)

alter table CommodityInputList
add constraint fk_WarehouserNumber foreign key(jobNumber) references
Warehouser(jobNumber)

alter table CommodityInputList
add constraint fk_InNumber foreign key(commodityId) references
Commodity(id)



alter table CommodityOutList
drop constraint fk_jobNumber



