-- MySQL Workbench Forward Engineering

/* SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0; */
/* SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0; */
/* SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES'; */

-- -----------------------------------------------------
-- Schema stldb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema stldb
-- -----------------------------------------------------

USE [stldb] ;

-- -----------------------------------------------------
-- Table `stldb`.`User`
-- -----------------------------------------------------
CREATE TABLE Users (
  [user_ID] INT NOT NULL IDENTITY,
  [userName] VARCHAR(15) NOT NULL,
  [password] VARCHAR(15) NOT NULL,
  PRIMARY KEY ([user_ID]))
;


-- -----------------------------------------------------
-- Table `stldb`.`Department`
-- -----------------------------------------------------
CREATE TABLE Department (
  [department_ID] INT NOT NULL IDENTITY,
  [departmentName] VARCHAR(15) NOT NULL,
  PRIMARY KEY ([department_ID]))
;


-- -----------------------------------------------------
-- Table `stldb`.`Employee`
-- -----------------------------------------------------
CREATE TABLE Employee (
  [employee_ID] INT NOT NULL IDENTITY,
  [empFirstName] VARCHAR(15) NOT NULL,
  [empLastName] VARCHAR(15) NOT NULL,
  [empPhoneNum] VARCHAR(15) NOT NULL,
  [department_ID] INT NOT NULL,
  [User_user_ID] INT NOT NULL,
  PRIMARY KEY ([employee_ID], [department_ID], [User_user_ID])
 ,
  CONSTRAINT [department_ID]
    FOREIGN KEY ([department_ID])
    REFERENCES Department ([department_ID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Employee_User1]
    FOREIGN KEY ([User_user_ID])
    REFERENCES Users ([user_ID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [department_ID_idx] ON Employee ([department_ID] ASC);
CREATE INDEX [fk_Employee_User1_idx] ON Employee ([User_user_ID] ASC);


-- -----------------------------------------------------
-- Table `stldb`.`Customer`
-- -----------------------------------------------------
CREATE TABLE Customer (
  [customer_ID] INT NOT NULL IDENTITY,
  [custFirstName] VARCHAR(15) NOT NULL,
  [custLastName] VARCHAR(15) NOT NULL,
  [custCompanyName] VARCHAR(15) NOT NULL,
  [custPhoneNum] VARCHAR(15) NOT NULL,
  [custAddress] VARCHAR(45) NOT NULL,
  PRIMARY KEY ([customer_ID]))
;


-- -----------------------------------------------------
-- Table `stldb`.`STLProduct`
-- -----------------------------------------------------
CREATE TABLE STLProduct (
  [STLProduct_ID] INT NOT NULL IDENTITY,
  [productName] VARCHAR(20) NOT NULL,
  [manufacturingInstructions] VARCHAR(max) NOT NULL,
  PRIMARY KEY ([STLProduct_ID]))
;


-- -----------------------------------------------------
-- Table `stldb`.`WorkOrder`
-- -----------------------------------------------------
CREATE TABLE WorkOrder (
  [WorkOrder_ID] INT NOT NULL IDENTITY,
  [dateRequired] DATETIME2(0) NOT NULL,
  [TotalPrice] VARCHAR(45) NULL,
  [Customer_customer_ID] INT NOT NULL,
  PRIMARY KEY ([WorkOrder_ID])
 ,
  CONSTRAINT [fk_WorkOrder_Customer1]
    FOREIGN KEY ([Customer_customer_ID])
    REFERENCES Customer ([customer_ID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [fk_WorkOrder_Customer1_idx] ON WorkOrder ([Customer_customer_ID] ASC);


-- -----------------------------------------------------
-- Table `stldb`.`ProductMaterial`
-- -----------------------------------------------------
CREATE TABLE ProductMaterial (
  [quantity] INT NOT NULL,
  [STLProduct_STLProduct_ID] INT NOT NULL,
  PRIMARY KEY ([STLProduct_STLProduct_ID]),
  CONSTRAINT [fk_ProductMaterial_STLProduct1]
    FOREIGN KEY ([STLProduct_STLProduct_ID])
    REFERENCES STLProduct ([STLProduct_ID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;


-- -----------------------------------------------------
-- Table `stldb`.`RawMaterial`
-- -----------------------------------------------------
CREATE TABLE RawMaterial (
  [RawMaterial_ID] INT NOT NULL IDENTITY,
  [materialName] VARCHAR(45) NOT NULL,
  [description] VARCHAR(45) NOT NULL,
  [ProductMaterial_STLProduct_STLProduct_ID] INT NOT NULL,
  PRIMARY KEY ([RawMaterial_ID], [ProductMaterial_STLProduct_STLProduct_ID])
 ,
  CONSTRAINT [fk_RawMaterial_ProductMaterial1]
    FOREIGN KEY ([ProductMaterial_STLProduct_STLProduct_ID])
    REFERENCES ProductMaterial ([STLProduct_STLProduct_ID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [fk_RawMaterial_ProductMaterial1_idx] ON RawMaterial ([ProductMaterial_STLProduct_STLProduct_ID] ASC);


-- -----------------------------------------------------
-- Table `stldb`.`PMRP`
-- -----------------------------------------------------
CREATE TABLE PMRP (
  [PMRP_ID] INT NOT NULL,
  [DateRequired] DATETIME2(0) NOT NULL,
  PRIMARY KEY ([PMRP_ID]))
;


-- -----------------------------------------------------
-- Table `stldb`.`Lot`
-- -----------------------------------------------------
CREATE TABLE Lot (
  [Lot_ID] INT NOT NULL,
  [Quantity] INT NOT NULL,
  [Description] VARCHAR(45) NOT NULL,
  [DateRequired] DATETIME2(0) NOT NULL,
  [STLProduct_STLProduct_ID] INT NOT NULL,
  [WorkOrder_WorkOrder_ID] INT NOT NULL,
  [WorkOrder_Customer_customer_ID] INT NOT NULL,
  [PMRP_PMRP_ID] INT NOT NULL,
  PRIMARY KEY ([Lot_ID], [STLProduct_STLProduct_ID])
 ,
  CONSTRAINT [fk_Lot_WorkOrder1]
    FOREIGN KEY ([WorkOrder_WorkOrder_ID])
    REFERENCES WorkOrder ([WorkOrder_ID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Lot_PMRP1]
    FOREIGN KEY ([PMRP_PMRP_ID])
    REFERENCES PMRP ([PMRP_ID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [fk_Lot_WorkOrder1_idx] ON Lot ([WorkOrder_WorkOrder_ID] ASC, [WorkOrder_Customer_customer_ID] ASC);
CREATE INDEX [fk_Lot_PMRP1_idx] ON Lot ([PMRP_PMRP_ID] ASC);


-- -----------------------------------------------------
-- Table `stldb`.`LotTraveller`
-- -----------------------------------------------------
CREATE TABLE LotTraveller (
  [LotTraveller_ID] INT NOT NULL,
  [ProductionProcess] VARCHAR(45) NOT NULL,
  [Lot_Lot_ID] INT NOT NULL,
  [Lot_STLProduct_STLProduct_ID] INT NOT NULL,
  PRIMARY KEY ([LotTraveller_ID], [Lot_Lot_ID], [Lot_STLProduct_STLProduct_ID])
 ,
  CONSTRAINT [fk_LotTraveller_Lot1]
    FOREIGN KEY ([Lot_Lot_ID] , [Lot_STLProduct_STLProduct_ID])
    REFERENCES Lot ([Lot_ID] , [STLProduct_STLProduct_ID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [fk_LotTraveller_Lot1_idx] ON LotTraveller ([Lot_Lot_ID] ASC, [Lot_STLProduct_STLProduct_ID] ASC);


-- -----------------------------------------------------
-- Table `stldb`.`STL_LineItem`
-- -----------------------------------------------------
CREATE TABLE STL_LineItem (
  [STLLineItem_ID] INT NOT NULL,
  [Quantity] INT NOT NULL,
  [UnitPrice] DECIMAL(2) NOT NULL,
  [LinePrice] DECIMAL(2) NOT NULL,
  [VAT] DECIMAL(2) NOT NULL,
  PRIMARY KEY ([STLLineItem_ID]))
;


-- -----------------------------------------------------
-- Table `stldb`.`TechnicalEnquiry`
-- -----------------------------------------------------
CREATE TABLE TechnicalEnquiry (
  [TechnicalEnquiry_ID] INT NOT NULL,
  [EnquiryText] VARCHAR(max) NOT NULL,
  [Responded] SMALLINT NOT NULL,
  [Accepted] SMALLINT NOT NULL,
  [DateCreated] DATETIME2(0) NOT NULL,
  [Customer_customer_ID] INT NOT NULL,
  PRIMARY KEY ([TechnicalEnquiry_ID])
 ,
  CONSTRAINT [fk_TechnicalEnquiry_Customer1]
    FOREIGN KEY ([Customer_customer_ID])
    REFERENCES Customer ([customer_ID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [fk_TechnicalEnquiry_Customer1_idx] ON TechnicalEnquiry ([Customer_customer_ID] ASC);


-- -----------------------------------------------------
-- Table `stldb`.`ReportType`
-- -----------------------------------------------------
CREATE TABLE ReportType (
  [ReportType_ID] INT NOT NULL,
  [ReportName] VARCHAR(45) NOT NULL,
  PRIMARY KEY ([ReportType_ID]))
;


-- -----------------------------------------------------
-- Table `stldb`.`Report`
-- -----------------------------------------------------
CREATE TABLE Report (
  [ReportID] INT NOT NULL,
  [pathAddress] VARCHAR(45) NOT NULL,
  [dateCreated] DATETIME2(0) NOT NULL,
  [ReportType_ID] INT NOT NULL,
  PRIMARY KEY ([ReportID], [ReportType_ID])
 ,
  CONSTRAINT [fk_Report_ReportType1]
    FOREIGN KEY ([ReportType_ID])
    REFERENCES ReportType ([ReportType_ID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [fk_Report_ReportType1_idx] ON Report ([ReportType_ID] ASC);


-- -----------------------------------------------------
-- Table `stldb`.`WorkOrder_has_STLProduct`
-- -----------------------------------------------------
CREATE TABLE WorkOrder_has_STLProduct (
  [WorkOrder_WorkOrder_ID] INT NOT NULL,
  [STLProduct_STLProduct_ID] INT NOT NULL,
  PRIMARY KEY ([WorkOrder_WorkOrder_ID], [STLProduct_STLProduct_ID])
 ,
  CONSTRAINT [fk_WorkOrder_has_STLProduct_WorkOrder1]
    FOREIGN KEY ([WorkOrder_WorkOrder_ID])
    REFERENCES WorkOrder ([WorkOrder_ID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_WorkOrder_has_STLProduct_STLProduct1]
    FOREIGN KEY ([STLProduct_STLProduct_ID])
    REFERENCES STLProduct ([STLProduct_ID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [fk_WorkOrder_has_STLProduct_STLProduct1_idx] ON WorkOrder_has_STLProduct ([STLProduct_STLProduct_ID] ASC);
CREATE INDEX [fk_WorkOrder_has_STLProduct_WorkOrder1_idx] ON WorkOrder_has_STLProduct ([WorkOrder_WorkOrder_ID] ASC);


-- -----------------------------------------------------
-- Table `stldb`.`WorkOrder_has_STL_LineItem`
-- -----------------------------------------------------
CREATE TABLE WorkOrder_has_STL_LineItem (
  [WorkOrder_WorkOrder_ID] INT NOT NULL,
  [STL_LineItem_STLLineItem_ID] INT NOT NULL,
  PRIMARY KEY ([WorkOrder_WorkOrder_ID], [STL_LineItem_STLLineItem_ID])
 ,
  CONSTRAINT [fk_WorkOrder_has_STL_LineItem_WorkOrder1]
    FOREIGN KEY ([WorkOrder_WorkOrder_ID])
    REFERENCES WorkOrder ([WorkOrder_ID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_WorkOrder_has_STL_LineItem_STL_LineItem1]
    FOREIGN KEY ([STL_LineItem_STLLineItem_ID])
    REFERENCES STL_LineItem ([STLLineItem_ID])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [fk_WorkOrder_has_STL_LineItem_STL_LineItem1_idx] ON WorkOrder_has_STL_LineItem ([STL_LineItem_STLLineItem_ID] ASC);
CREATE INDEX [fk_WorkOrder_has_STL_LineItem_WorkOrder1_idx] ON WorkOrder_has_STL_LineItem ([WorkOrder_WorkOrder_ID] ASC);


/* SET SQL_MODE=@OLD_SQL_MODE; */
/* SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS; */
/* SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS; */
