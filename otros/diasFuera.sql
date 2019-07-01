create function PENSAMIENTO_LINEAL.diasFuera (@anio numeric(5), @semestre numeric(2), @fechabaja dateTime, @fechaalta dateTime)
returns numeric(5)
as
begin
	declare @resultado numeric(5)
	
	declare @fechalimite1 dateTime
	declare @fechalimite2 dateTime
	declare @fechalimite3 dateTime
	set @fechalimite1 = DATEFROMPARTS(@anio, 1, 1)
	set @fechalimite2 = DATEFROMPARTS(@anio, 6, 30)
	set @fechalimite3 = DATEFROMPARTS(@anio, 12, 31)

	if(@semestre = 1)
	begin
		if(@fechabaja < @fechalimite1)
			set @fechabaja = @fechalimite1
		if(@fechaalta > @fechalimite2)
			set @fechaalta = @fechalimite2
		if(@fechabaja > @fechalimite2 or @fechaalta < @fechalimite1)
			set @fechabaja = @fechaalta
	end
	else
	begin
		if(@fechabaja < @fechalimite2)
			set @fechabaja = @fechalimite2
		if(@fechaalta > @fechalimite3)
			set @fechaalta = @fechalimite3
		if(@fechabaja > @fechalimite3 or @fechaalta < @fechalimite2)
			set @fechabaja = @fechaalta
	end

	set @resultado = DATEDIFF(day, @fechabaja, @fechaalta)
	return @resultado
end