USE [AdventureWorksLT2019]
GO
/****** Object:  StoredProcedure [dbo].[addNewCustomerAddress]    Script Date: 2/17/2021 5:05:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[addNewCustomerAddress]
@addressType nvarchar(50)
as
begin
declare @customerID int,
@addressID int
set @customerID = (select top(1) [CustomerID] from SalesLT.Customer order by CustomerID desc)
set @addressID = (select top(1) [AddressID] from SalesLT.[Address] order by AddressID desc)
insert into SalesLT.CustomerAddress (CustomerID, AddressID, AddressType, ModifiedDate)
values (@customerID, @addressID, @addressType, GETDATE())
end
GO
USE [AdventureWorksLT2019]
GO
/****** Object:  StoredProcedure [dbo].[addNewCustomerAddressAddress]    Script Date: 2/17/2021 5:06:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[addNewCustomerAddressAddress]
@addressLine1 nvarchar(60),
@addressLine2 nvarchar(60),
@city nvarchar(30),
@stateProvince nvarchar(50),
@countryRegion nvarchar(50),
@postalCode nvarchar(15)
as
begin
insert into SalesLT.[Address] (AddressLine1, AddressLine2, City, StateProvince, CountryRegion, PostalCode,ModifiedDate)
values (@addressLine1, @addressLine2, @city, @stateProvince, @countryRegion, @postalCode, GETDATE())
end
GO
USE [AdventureWorksLT2019]
GO

/****** Object:  StoredProcedure [dbo].[addNewCustomerCustomer]    Script Date: 2/17/2021 5:06:21 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[addNewCustomerCustomer]
@Title nvarchar(8),
@firstName nvarchar(50),
@middleName nvarchar(50),
@lastName nvarchar(50),
@suffix nvarchar(10),
@companyName nvarchar(128),
@salesPerson nvarchar(256),
@emailAddress nvarchar(50),
@phone nvarchar(25)
as
begin
insert into SalesLT.Customer (NameStyle, Title, FirstName, MiddleName, LastName, Suffix, CompanyName, SalesPerson, EmailAddress, Phone, PasswordHash, PasswordSalt)
values (0, @Title, @firstName, @middleName, @lastName, @suffix, @companyName, @salesPerson, @emailAddress, @phone, 'PassHash', 'PassSalt')
end
GO
USE [AdventureWorksLT2019]
GO

/****** Object:  StoredProcedure [dbo].[CustomerSummary]    Script Date: 2/17/2021 5:06:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[CustomerSummary]
as
begin
select CustomerSummaryView.CustomerID, CustomerSummaryView.Title, CustomerSummaryView. FirstName, CustomerSummaryView.MiddleName, CustomerSummaryView.LastName, CustomerSummaryView.Suffix, CustomerSummaryView.CompanyName,
CustomerSummaryView.SalesPerson, CustomerSummaryView.EmailAddress, CustomerSummaryView.Phone, CustomerSummaryView.AddressType, CustomerSummaryView.AddressLine1, CustomerSummaryView.AddressLine2,
CustomerSummaryView.City, CustomerSummaryView.StateProvince, CustomerSummaryView.CountryRegion, CustomerSummaryView.PostalCode
from CustomerSummaryView
end
GO
USE [AdventureWorksLT2019]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCustomer]    Script Date: 2/17/2021 5:07:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[DeleteCustomer]
@ID int
as
begin
ALTER TABLE [SalesLT].[CustomerAddress]  WITH CHECK ADD CONSTRAINT [CascadeCustDeletes] FOREIGN KEY([CustomerID])
REFERENCES [SalesLT].[Customer] ([CustomerID])
ON DELETE CASCADE
delete from SalesLT.Customer where CustomerID=@ID;
delete from SalesLT.CustomerAddress where CustomerID=@ID;
delete from SalesLT.SalesOrderHeader where CustomerID=@ID;
ALTER TABLE [SalesLT].[CustomerAddress] DROP CONSTRAINT [CascadeCustDeletes] 
end
GO
USE [AdventureWorksLT2019]
GO
/****** Object:  StoredProcedure [dbo].[populateTextBoxes]    Script Date: 2/17/2021 5:07:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[populateTextBoxes]
@ID int
as
begin
select CustomerSummaryView.CustomerID, CustomerSummaryView.Title, CustomerSummaryView. FirstName, CustomerSummaryView.MiddleName, CustomerSummaryView.LastName, CustomerSummaryView.Suffix, CustomerSummaryView.CompanyName,
CustomerSummaryView.SalesPerson, CustomerSummaryView.EmailAddress, CustomerSummaryView.Phone, CustomerSummaryView.AddressType, CustomerSummaryView.AddressLine1, CustomerSummaryView.AddressLine2,
CustomerSummaryView.City, CustomerSummaryView.StateProvince, CustomerSummaryView.CountryRegion, CustomerSummaryView.PostalCode
from CustomerSummaryView
where CustomerID = @ID
end
GO
USE [AdventureWorksLT2019]
GO
/****** Object:  StoredProcedure [dbo].[ProductSummary]    Script Date: 2/17/2021 5:07:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[ProductSummary]
as
BEGIN
select ProductSummaryView.[Name], ProductSummaryView.ProductNumber, ProductSummaryView.Color, ProductSummaryView.StandardCost, ProductSummaryView.ListPrice, ProductSummaryView.Size,
ProductSummaryView.[Weight], ProductSummaryView.SellStartDate, ProductSummaryView.SellEndDate, ProductSummaryView.DiscontinuedDate, ProductSummaryView.ModifiedDate, ProductSummaryView.[Description],
ProductSummaryView.CategoryName, ProductSummaryView.ProductModelName
from [dbo].[ProductSummaryView]
where ProductSummaryView.Culture = 'en'
order by ProductSummaryView.[Name]
end
GO
USE [AdventureWorksLT2019]
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomers]    Script Date: 2/17/2021 5:07:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[UpdateCustomers]
@ID int,
@title nvarchar(8),
@firstname nvarchar(50),
@middlename nvarchar(50),
@lastname nvarchar(50),
@suffix nvarchar(10),
@companyname nvarchar(128),
@salesperson nvarchar(256),
@emailaddress nvarchar(50),
@phone nvarchar(25),
@addresstype nvarchar(50),
@addressline1 nvarchar(60),
@addressline2 nvarchar(60),
@city nvarchar(30),
@stateprovince nvarchar(50),
@countryregion nvarchar(50),
@postalcode nvarchar(15)
as
declare @addressID int
begin
update [SalesLT].[CustomerAddress] set [AddressType] = @addresstype
from SalesLT.CustomerAddress where [CustomerID] = @ID;
update [SalesLT].[Customer] set [Title] = @title,
                                [FirstName] = @firstname,
                                [MiddleName] = @middlename,
                                [LastName] = @lastname,
                                [Suffix] = @suffix,
                                [CompanyName] = @companyname,
                                [SalesPerson] = @salesperson,
                                [EmailAddress] = @emailaddress,
                                [Phone] = @phone
from SalesLT.Customer where [CustomerID] = @ID;
set @addressID = (select [AddressID] from SalesLT.CustomerAddress where [CustomerID] = @ID)
update [SalesLT].[Address] set [AddressLine1] = @addressline1,
                                [AddressLine2] = @addressline2,
                                [City] = @city,
                                [StateProvince] = @stateprovince,
                                [CountryRegion] = @countryregion,
                                [PostalCode] = @postalcode
from SalesLT.[Address] where [AddressID] = @addressID;

end
GO
USE [AdventureWorksLT2019]
GO

/****** Object:  View [dbo].[CustomerSummaryView]    Script Date: 2/17/2021 5:18:00 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[CustomerSummaryView]
AS
SELECT        SalesLT.Customer.CustomerID, SalesLT.Customer.Title, SalesLT.Customer.FirstName, SalesLT.Customer.MiddleName, SalesLT.Customer.LastName, SalesLT.Customer.Suffix, SalesLT.Customer.CompanyName, 
                         SalesLT.Customer.SalesPerson, SalesLT.Customer.EmailAddress, SalesLT.Customer.Phone, SalesLT.CustomerAddress.AddressType, SalesLT.Address.AddressLine1, SalesLT.Address.AddressLine2, SalesLT.Address.City, 
                         SalesLT.Address.StateProvince, SalesLT.Address.CountryRegion, SalesLT.Address.PostalCode
FROM            SalesLT.Customer LEFT OUTER JOIN
                         SalesLT.CustomerAddress ON SalesLT.Customer.CustomerID = SalesLT.CustomerAddress.CustomerID LEFT OUTER JOIN
                         SalesLT.Address ON SalesLT.CustomerAddress.AddressID = SalesLT.Address.AddressID
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Customer (SalesLT)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 334
               Right = 251
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CustomerAddress (SalesLT)"
            Begin Extent = 
               Top = 60
               Left = 323
               Bottom = 256
               Right = 501
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Address (SalesLT)"
            Begin Extent = 
               Top = 75
               Left = 616
               Bottom = 316
               Right = 817
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'CustomerSummaryView'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'CustomerSummaryView'
GO
USE [AdventureWorksLT2019]
GO
/****** Object:  View [dbo].[ProductSummaryView]    Script Date: 2/17/2021 5:20:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[ProductSummaryView]
AS
SELECT        SalesLT.Product.Name, SalesLT.Product.ProductNumber, SalesLT.Product.Color, SalesLT.Product.StandardCost, SalesLT.Product.ListPrice, SalesLT.Product.Size, SalesLT.Product.Weight, SalesLT.Product.SellStartDate, 
                         SalesLT.Product.SellEndDate, SalesLT.Product.DiscontinuedDate, SalesLT.Product.ModifiedDate, SalesLT.ProductDescription.Description, SalesLT.ProductModelProductDescription.Culture, 
                         SalesLT.ProductCategory.Name AS CategoryName, SalesLT.ProductModel.Name AS ProductModelName
FROM            SalesLT.Product INNER JOIN
                         SalesLT.ProductModel ON SalesLT.Product.ProductModelID = SalesLT.ProductModel.ProductModelID INNER JOIN
                         SalesLT.ProductModelProductDescription ON SalesLT.ProductModel.ProductModelID = SalesLT.ProductModelProductDescription.ProductModelID INNER JOIN
                         SalesLT.ProductDescription ON SalesLT.ProductModelProductDescription.ProductDescriptionID = SalesLT.ProductDescription.ProductDescriptionID INNER JOIN
                         SalesLT.ProductCategory ON SalesLT.Product.ProductCategoryID = SalesLT.ProductCategory.ProductCategoryID
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Product (SalesLT)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 339
               Right = 268
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "ProductModel (SalesLT)"
            Begin Extent = 
               Top = 206
               Left = 353
               Bottom = 336
               Right = 543
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "ProductModelProductDescription (SalesLT)"
            Begin Extent = 
               Top = 45
               Left = 680
               Bottom = 178
               Right = 882
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "ProductDescription (SalesLT)"
            Begin Extent = 
               Top = 73
               Left = 1016
               Bottom = 203
               Right = 1218
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ProductCategory (SalesLT)"
            Begin Extent = 
               Top = 19
               Left = 326
               Bottom = 149
               Right = 550
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3705
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
       ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ProductSummaryView'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'  GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 2670
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ProductSummaryView'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ProductSummaryView'
GO