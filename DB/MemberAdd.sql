CREATE PROCEDURE [dbo].[MemberAdd]
	@mode nvarchar(10),
	@idMember int,
	@Name varchar(50),
	@Gender varchar(50), 
	@Height int,
	@Weight int,
	@Contact int,
	@Batch varchar(50),
	@Member varchar(50),
	@Workout varchar(50),
	@FeesMode varchar(50),
	@RecNo int


AS
	IF @mode = 'Add'
	BEGIN 
	INSERT INTO tbl_member 
	(Name, Gender, Height, Weight, Contact, Batch, Member, Workout, FeesMode, RecNo)
	VALUES 
	(@Name, @Gender, @Height, @Weight, @Contact, @Batch, @Member, @Workout, @FeesMode, @RecNo)
END