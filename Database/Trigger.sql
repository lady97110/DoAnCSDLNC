USE DoAnCSDLNC
GO

--Trigger thay doi thong tin chiet khau so luong, QuantityDiscount
CREATE TRIGGER trgAddUpdateQuantityDiscount
ON dbo.tbQuantityDiscount
FOR INSERT, UPDATE
AS
BEGIN
DECLARE @discountID INT, @minQuantity INT, @maxQuantity INT, @duplicatedMin INT, @duplicatedMax INT
SELECT @discountID =Inserted.DiscountID, @minQuantity = Inserted.MinQuantity, @maxQuantity = Inserted.MaxQuantity
	FROM Inserted
	SELECT @duplicatedMin = COUNT(*)
	FROM dbo.tbQuantityDiscount WHERE @minQuantity >= MinQuantity AND @minQuantity <= MaxQuantity AND @discountID != DiscountID
	SELECT @duplicatedMax = COUNT(*)
	FROM dbo.tbQuantityDiscount WHERE @maxQuantity >= MinQuantity AND @maxQuantity <= MaxQuantity AND @discountID != DiscountID
	IF @duplicatedMin > 0 OR @duplicatedMax > 0
	ROLLBACK TRAN
END
GO


 --Trigger thay doi thong tin chiet khau do tuoi, AgeDiscount
 CREATE TRIGGER trgAddUpdateAgeDiscount
 ON dbo.tbAgeDiscount
 FOR INSERT, UPDATE
 AS
 BEGIN
	DECLARE @discountID INT, @minAge INT, @maxAge INT, @duplicateMin INT, @duplicatedMax INT
    SELECT @discountID = Inserted.DiscountID, @minAge = Inserted.MinAge, @maxAge = Inserted.MaxAge
		FROM Inserted
		SELECT @duplicateMin = COUNT(*)
		FROM dbo.tbAgeDiscount
		WHERE @minAge >= MinAge AND @minAge <= MaxAge AND @discountID != DiscountID
		SELECT @duplicatedMax =COUNT(*)
		FROM dbo.tbAgeDiscount
		WHERE @maxAge >= MinAge AND @maxAge <= MaxAge AND @discountID != DiscountID
		IF @duplicateMin > 0 OR @duplicatedMax > 0
		ROLLBACK TRAN
END
GO


--Trigger thay doi thong tin ve ti le hoan coc, Refund
CREATE TRIGGER trgAddUpdateRefund
ON dbo.tbRefund
FOR INSERT, UPDATE
AS 
BEGIN
	DECLARE @refundID INT, @minDay INT, @maxDay INT, @duplicatedMin INT, @duplicateMax INT
	SELECT @refundID = Inserted.RefundID, @minDay = Inserted.MinDay, @maxDay = Inserted.MaxDay
	FROM Inserted
	SELECT @duplicatedMin = COUNT(*)
	FROM dbo.tbRefund
	WHERE @minDay >= MinDay AND @minDay <= MaxDay AND @refundID != RefundID
	SELECT @duplicateMax = COUNT(*)
	FROM dbo.tbRefund
	WHERE @maxDay >= MinDay AND @maxDay <= MaxDay AND @refundID != RefundID
	IF @duplicatedMin > 0 OR @duplicateMax > 0
	ROLLBACK TRAN
END
GO


------------------Quan ly Tour---------------------------
--Trigger them moi Tour
CREATE TRIGGER trgAddTour
ON dbo.tbTour
FOR INSERT
AS
BEGIN
	DECLARE @totalSeat INT, @emptySeat INT
	SELECT @totalSeat = Inserted.TotalSeat, @emptySeat = Inserted.EmptySeat
	FROM Inserted
	IF @totalSeat != @emptySeat
	ROLLBACK TRAN
END
GO 

--Xoa Tour
CREATE TRIGGER trgDeleteTour
ON dbo.tbTour
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @tourID INT
	SELECT @tourID = Deleted.TourID FROM Deleted
	DELETE FROM dbo.tbContract WHERE TourID = @tourID
	DELETE FROM dbo.tbTour WHERE TourID = @tourID
END
GO

--Xoa khach hang
CREATE TRIGGER trgDeleteCustomer
ON dbo.tbCustomer
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @customerID INT
	SELECT @customerID = Deleted.CustomerID FROM Deleted
	DELETE dbo.tbContract WHERE CustomerID = @customerID
	DELETE dbo.tbCustomer WHERE CustomerID = @customerID
END
GO

----------------Xu ly nghiep vu hop dong------------------
--Them hop dong va tinh chiet khau
CREATE TRIGGER trgAddContract
ON dbo.tbContract
FOR INSERT
AS
BEGIN
	DECLARE @quantity INT, @tourID INT, @contractID INT, @endDate DATE, @startDate DATE
	SELECT @tourID = Inserted.TourID, @quantity = Inserted.Quantity, @contractID = Inserted.ContractID, @endDate = dbo.tbTour.EndDate, @startDate = dbo.tbTour.StartDate
	FROM Inserted INNER JOIN dbo.tbTour ON tbTour.TourID = Inserted.TourID
	DECLARE @emptySeat INT
	SELECT @emptySeat = dbo.tbTour.EmptySeat
	FROM dbo.tbTour
	WHERE TourID = @tourID
	IF @emptySeat < @quantity
		ROLLBACK TRAN
	ELSE
		BEGIN
			UPDATE dbo.tbTour
			SET EmptySeat = EmptySeat - @quantity
			WHERE TourID = @tourID
			DECLARE @quantityDiscount INT
			EXEC @quantityDiscount = dbo.spGetQuantityDiscount @quantity = @quantity -- int
			UPDATE dbo.tbContract SET QuantityDiscount = @quantityDiscount,
			TerminationDate = DATEADD(DAY, 2, @endDate),
			DraftDate = GETDATE(),
			StartTime = @startDate
			WHERE ContractID = @contractID
			END
END
GO


--Chinh sua va huy hop dong, tinh chiet khau sau khi cap nhat
CREATE TRIGGER trgUpdateContract
ON dbo.tbContract
FOR UPDATE
AS
BEGIN
DECLARE @oldQuantity INT, @tourID INT, @contractID INT, @newQuantity INT, @emptySeat INT, @state INT
SELECT @contractID = Inserted.ContractID, @newQuantity = Inserted.Quantity, @oldQuantity = Deleted.Quantity,
@emptySeat = dbo.tbTour.EmptySeat, @tourID = Inserted.TourID, @state = Inserted.State
FROM (Inserted INNER JOIN Deleted ON Deleted.ContractID = Inserted.ContractID) INNER JOIN dbo.tbTour ON tbTour.TourID = Inserted.TourID
IF @state = 2
	BEGIN
		UPDATE dbo.tbTour
			SET EmptySeat = @emptySeat + @oldQuantity
			WHERE TourID = @tourID
			DECLARE @refundedRate INT
			EXEC @refundedRate = dbo.spGetRefundRate @contractID = @contractID -- int
			INSERT INTO dbo.tbRefundContract
			        ( ContractID ,
			          RefundedDate ,
			          RefundedRate
			        )
			VALUES  ( @contractID , -- ContractID - int
			          GETDATE() , -- RefundedDate - date
			          @refundedRate  -- RefundedRate - int
			        )
	END
IF @state = 0
	BEGIN
		IF (@emptySeat + @oldQuantity - @newQuantity) < 0 OR @newQuantity = 0
			ROLLBACK TRAN
		ELSE
			IF @oldQuantity != @newQuantity
				BEGIN
					DECLARE @quantityDiscount INT
					EXEC @quantityDiscount = dbo.spGetQuantityDiscount @quantity = @newQuantity -- int
					UPDATE dbo.tbContract SET QuantityDiscount = @quantityDiscount
					WHERE ContractID = @contractID
					UPDATE dbo.tbTour SET EmptySeat = @emptySeat + @oldQuantity - @newQuantity
					WHERE TourID = @tourID
				END
			DELETE FROM dbo.tbMember WHERE dbo.tbMember.ContractID = @contractID
	END
END
GO

--Xoa hop dong
CREATE TRIGGER trgDeleteContract
ON dbo.tbContract
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @contractID INT
	SELECT @contractID = Deleted.ContractID FROM Deleted
	DELETE FROM dbo.tbMember WHERE ContractID = @contractID
	DELETE FROM dbo.tbRefundContract WHERE ContractID = @contractID
	DELETE FROM dbo.tbAccident WHERE ContractID = @contractID
	DELETE FROM dbo.tbContract WHERE ContractID = @contractID
END

					

			
			