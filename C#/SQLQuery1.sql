create database SuperMarketSales
create table admin
(
id int not null primary key,
name varchar(50) not null,
password varchar(50) not null,
phone varchar(15) null
)
insert into admin(id,name,password,phone)
values('2001','郭靖','123','15888888888'),
      ('2002','张无忌','123','15999999999'),
      ('2003','令狐冲','123','15777777777'),
      ('2004','老赵','123','156666666666')
      
      create table users
(
id int not null primary key,
name varchar(50) not null,
password varchar(50) not null,
phone varchar(15) not null
)
insert into users(id,name,password,phone)
values('1001','老赵','123','13333333333'),
      ('1002','老千','123','13444444444'),
      ('1003','老孙','123','13555555555'),
      ('1004','老李','123','13666666666')
     
     create table gys
(
id varchar(50) not null primary key,
name varchar(50) not null,
address varchar(50) not null,
people varchar(20) not null,
phone varchar(15) not null
)
insert into gys(id,name,address,people,phone)
values('4001','薯片','陈家桥','陈明','14222222222'),
      ('4002','可乐','龙湖','陈兵','14333333333'),
      ('4003','辣条','西站','陈达','14444444444'),
      ('4004','凤爪','电子校','陈燕','14555555555')
       
        
      create table sp
(
id int not null primary key,
spname varchar(50) not null,
price varchar(15) not null,
gys varchar(50) not null
constraint fk_gys foreign key (gys) references gys(id) 
)
insert into sp(id,spname,price,gys)
values('3001','薯片','1','4001'),
      ('3002','可乐','1','4002'),
      ('3003','辣条','1','4003'),
      ('3004','凤爪','1','4003')
      
       create table xs
(
lsh int not null primary key,
syyid int  not null,
spid int  not null,
time datetime not null,
constraint fk_syyid foreign key(syyid)references users(id),
constraint fk_spid foreign key(spid)references sp(id),
)
insert into xs(lsh,syyid,spid,time )
values('5001','1001','3001','2019-04-23'),
      ('5002','1002','3002','2019-05-28'),
      ('5003','1003','3003','2019-06-24'),
      ('5004','1004','3004','2019-07-19')
     
   create table lr
(
lsh int not null primary key,
kgyid int  not null,
spid int  not null,
time datetime not null,
constraint fk_kgyid foreign key(kgyid)references admin(id),
constraint fk_wspid foreign key(spid)references sp(id),
)
insert into lr(lsh,kgyid,spid,time )
values('6001','2001','3001','2019-05-23'),
      ('6002','2002','3002','2019-06-28'),
      ('6003','2003','3003','2019-06-19'),
      ('6004','2004','3004','2019-07-23')    
      
      
  select*from admin;
  select*from users;
  select*from sp;
  select*from gys;
  select*from xs;
  select*from lr;