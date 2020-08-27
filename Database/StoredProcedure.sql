USE DoAnCSDLNC
GO

--Stored Procedure tinh chiet khau theo so luong
CREATE PROCEDURE spGetQuantityDiscount
@quantity INT =NULL
AS
DECLARE @quantityDiscount INT
IF @quantity IS NULL
	SET @quantityDiscount = 0
ELSE
	BEGIN
		SELECT @quantityDiscount = Discount
		FROM dbo.tbQuantityDiscount
		WHERE @quantity >= MinQuantity AND @quantity <= MaxQuantity
		IF @quantityDiscount IS NULL
			SET @quantityDiscount = 0
		END
RETURN @quantityDiscount
GO

--Stored Procedure tinh tuoi theo DOB
CREATE PROCEDURE spCalculateAge
@dob DATE
AS
DECLARE @age INT,
		@year INT, @month INT, @day INT,
		@currentYear INT, @currentMonth INT, @currentDay INT
		SET @year = YEAR(@dob)
		SET @month = MONTH(@dob)
		SET @day = DAY(@dob)
		SET @currentYear = YEAR(GETDATE())
		SET @currentMonth = MONTH(GETDATE())
		SET @currentDay = DAY(GETDATE())
		IF @year = @currentYear SET @age = 0
			ELSE
			BEGIN
				SET @age = @currentYear - @year - 1
				IF (@currentMonth > @month) OR (@currentMonth = @month AND @currentDay >= @day)
					BEGIN
						SET @age = @age + 1
					END
            END
RETURN @age
GO


--Stored Procedure tinh chiet khau theo do tuoi
CREATE PROCEDURE spGetAgeDiscount
@DOB DATE =NULL
AS
DECLARE @ageDiscount INT
IF @DOB IS NULL
	SET @ageDiscount = 0
ELSE
	BEGIN
		DECLARE @age INT
		EXECUTE @age = dbo.spCalculateAge @dob = @DOB -- date
		SELECT @ageDiscount = Discount FROM dbo.tbAgeDiscount
		WHERE MinAge <= @age AND @age <= MaxAge
		IF @ageDiscount IS NULL
		SET @ageDiscount = 0
	END
RETURN @ageDiscount
GO

--Stored Procedure tinh ti le hoan coc
CREATE PROCEDURE spGetRefundRate
@contractID INT
AS
DECLARE @dayNumbers INT, @startDate DATE, @refundRate INT
SELECT @startDate = StartDate FROM dbo.tbContract INNER JOIN dbo.tbTour ON tbTour.TourID = tbContract.TourID
	WHERE ContractID = @contractID
		SET @dayNumbers = DATEDIFF(DAY, GETDATE(), @startDate)
		SELECT @refundRate = RefundRate FROM dbo.tbRefund
			WHERE MinDay <= @dayNumbers AND MaxDay >= @dayNumbers
			 IF	@refundRate IS NULL SET @refundRate = 0
RETURN @refundRate
GO
		

		