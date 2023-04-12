use Test
select * from tbTaiKhoan
insert into tbTaiKhoan
values('root','123');
delete  from tbTaiKhoan
where TaiKhoan='root' and MatKhau='123'
drop table DieuTraDS
select * from DieuTraDS where MaCD='CD01'
insert into DieuTraDS
values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')

update DieuTraDS set MaPhuong='P02',TenCD='An',CMND='123456',GioiTinh='Nam',NamSinh='1988',SoDienThoai='0867' where MaCD='CD02'