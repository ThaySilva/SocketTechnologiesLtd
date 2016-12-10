USE [stldb1]
GO

INSERT INTO [dbo].[Customer]
           ([custFirstName]
           ,[custLastName]
           ,[custCompanyName]
           ,[custPhoneNum]
           ,[custAddress]
           ,[custAddLine2]
           ,[custCounty])
     VALUES
           ('Maggie', 'Gillis', 'Cork Cyber Computing Ltd', '7665', 'Cork Business Park', 'Model Farm Rd', ' Cork')
GO

INSERT INTO [dbo].[Customer]
           ([custFirstName]
           ,[custLastName]
           ,[custCompanyName]
           ,[custPhoneNum]
           ,[custAddress]
           ,[custAddLine2]
           ,[custCounty])
     VALUES
		('Donna', 'Hegarty', 'Brakken Engineering Ltd', '9843', 'Smithstown Industrial Estate', 'Shannon', 'Clare')

GO

INSERT INTO [dbo].[Customer]
           ([custFirstName]
           ,[custLastName]
           ,[custCompanyName]
           ,[custPhoneNum]
           ,[custAddress]
           ,[custAddLine2]
           ,[custCounty])
     VALUES
		('Derek', 'Hyde', 'LGB Eletronics', '2345', 'Monkstown', 'Blackrock', 'Dublin')
GO