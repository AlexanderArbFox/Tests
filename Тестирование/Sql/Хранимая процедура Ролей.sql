create proc roles
@ylog nvarchar(50),
@ypass nvarchar(50)
as
begin 
select * from Registration where [Login] = @ylog and Parol = @ypass
end