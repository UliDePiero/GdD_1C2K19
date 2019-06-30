create function PENSAMIENTO_LINEAL.diasFuera (@anio numeric(5), @semestre varchar(8), @fechabaja DateTime, @fechaalta DateTime)
returns numeric(10)
as
begin
	declare @retorno numeric(10)
	declare @cambioDeSemestre DateTime

	set @retorno = DATEDIFF(day, @fechabaja, @fechaalta)
	set @cambioDeSemestre = DATEFROMPARTS(@anio, 6, 30)

	if (@semestre = '<= 6' AND (@fechaalta > @cambioDeSemestre))
		set @retorno = DATEDIFF(day, @fechabaja, @cambioDeSemestre)
	else if (@semestre = '> 6' and (@fechabaja < @cambioDeSemestre))
		set @retorno = DATEDIFF(day, @cambioDeSemestre, @fechaalta)

	return @retorno
end