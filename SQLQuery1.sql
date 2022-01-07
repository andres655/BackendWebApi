create procedure Agregar_Book

@Id int, @Titulo varchar(50),@Descripcion varchar(50), @Autor varchar(50)
as 
begin
insert into Book(Id,Titulo,Descripcion,Autor) values (@Id,@Titulo,@Descripcion,@Autor)
end

go 

create procedure  Modificar_Book

@Id int, @Titulo varchar(50),@Descripcion varchar(50), @Autor varchar(50)
as 
begin
update Book set  Titulo=@Titulo,Descripcion=@Descripcion,Autor=@Autor where id =@Id
end

go 
create procedure obtener_Book
 @Id int
 as 
 begin 
 select * from Book where Id=@Id
 end

 go 
create procedure List_Book

 as 
 begin 
 select * from Book 
 end

 go 
create procedure Eliminar_Book
 @Id int
 as 
 begin 
 delete from Book where Id=@Id
 end

