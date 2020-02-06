﻿// -----------------------------------------------------------------
// <copyright>Copyright (C) 2020, David Ruiz.</copyright>
// Licensed under the Apache License, Version 2.0.
// You may not use this file except in compliance with the License:
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Software is distributed on an "AS IS", WITHOUT WARRANTIES
// OR CONDITIONS OF ANY KIND, either express or implied.
// -----------------------------------------------------------------

namespace AdventureWorks.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Microsoft.EntityFrameworkCore.Metadata;

    [DbContext(typeof(AdventureWorksContext))]
    partial class AdventureWorksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Address", b =>
            {
                b.Property<int>("AddressId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AddressID")
                    .HasColumnType("int")
                    .HasComment("Primary key for Address records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("AddressLine1")
                    .IsRequired()
                    .HasColumnType("nvarchar(60)")
                    .HasComment("First street address line.")
                    .HasMaxLength(60);

                b.Property<string>("AddressLine2")
                    .HasColumnType("nvarchar(60)")
                    .HasComment("Second street address line.")
                    .HasMaxLength(60);

                b.Property<string>("City")
                    .IsRequired()
                    .HasColumnType("nvarchar(30)")
                    .HasComment("Name of the city.")
                    .HasMaxLength(30);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("PostalCode")
                    .IsRequired()
                    .HasColumnType("nvarchar(15)")
                    .HasComment("Postal code for the street address.")
                    .HasMaxLength(15);

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.Property<int>("StateProvinceId")
                    .HasColumnName("StateProvinceID")
                    .HasColumnType("int")
                    .HasComment("Unique identification number for the state or province. Foreign key to StateProvince table.");

                b.HasKey("AddressId");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_Address_rowguid");

                b.HasIndex("StateProvinceId");

                b.HasIndex("AddressLine1", "AddressLine2", "City", "StateProvinceId", "PostalCode")
                    .IsUnique()
                    .HasFilter("[AddressLine2] IS NOT NULL");

                b.ToTable("Address", "Person");

                b.HasComment("Street address information for customers, employees, and vendors.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.AddressType", b =>
            {
                b.Property<int>("AddressTypeId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AddressTypeID")
                    .HasColumnType("int")
                    .HasComment("Primary key for AddressType records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Address type description. For example, Billing, Home, or Shipping.")
                    .HasMaxLength(50);

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.HasKey("AddressTypeId");

                b.HasIndex("Name")
                    .IsUnique()
                    .HasName("AK_AddressType_Name");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_AddressType_rowguid");

                b.ToTable("AddressType", "Person");

                b.HasComment("Types of addresses stored in the Address table. ");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.AwbuildVersion", b =>
            {
                b.Property<byte>("SystemInformationId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SystemInformationID")
                    .HasColumnType("tinyint")
                    .HasComment("Primary key for AWBuildVersion records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("DatabaseVersion")
                    .IsRequired()
                    .HasColumnName("Database Version")
                    .HasColumnType("nvarchar(25)")
                    .HasComment("Version number of the database in 9.yy.mm.dd.00 format.")
                    .HasMaxLength(25);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<DateTime>("VersionDate")
                    .HasColumnType("datetime")
                    .HasComment("Date and time the record was last updated.");

                b.HasKey("SystemInformationId")
                    .HasName("PK_AWBuildVersion_SystemInformationID");

                b.ToTable("AWBuildVersion");

                b.HasComment("Current version number of the AdventureWorks 2016 sample database. ");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.BillOfMaterials", b =>
            {
                b.Property<int>("BillOfMaterialsId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BillOfMaterialsID")
                    .HasColumnType("int")
                    .HasComment("Primary key for BillOfMaterials records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<short>("Bomlevel")
                    .HasColumnName("BOMLevel")
                    .HasColumnType("smallint")
                    .HasComment("Indicates the depth the component is from its parent (AssemblyID).");

                b.Property<int>("ComponentId")
                    .HasColumnName("ComponentID")
                    .HasColumnType("int")
                    .HasComment("Component identification number. Foreign key to Product.ProductID.");

                b.Property<DateTime?>("EndDate")
                    .HasColumnType("datetime")
                    .HasComment("Date the component stopped being used in the assembly item.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<decimal>("PerAssemblyQty")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((1.00))")
                    .HasComment("Quantity of the component needed to create the assembly.");

                b.Property<int?>("ProductAssemblyId")
                    .HasColumnName("ProductAssemblyID")
                    .HasColumnType("int")
                    .HasComment("Parent product identification number. Foreign key to Product.ProductID.");

                b.Property<DateTime>("StartDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date the component started being used in the assembly item.");

                b.Property<string>("UnitMeasureCode")
                    .IsRequired()
                    .HasColumnType("nchar(3)")
                    .IsFixedLength(true)
                    .HasComment("Standard code identifying the unit of measure for the quantity.")
                    .HasMaxLength(3);

                b.HasKey("BillOfMaterialsId")
                    .HasName("PK_BillOfMaterials_BillOfMaterialsID")
                    .HasAnnotation("SqlServer:Clustered", false);

                b.HasIndex("ComponentId");

                b.HasIndex("UnitMeasureCode");

                b.HasIndex("ProductAssemblyId", "ComponentId", "StartDate")
                    .IsUnique()
                    .HasName("AK_BillOfMaterials_ProductAssemblyID_ComponentID_StartDate")
                    .HasAnnotation("SqlServer:Clustered", true);

                b.ToTable("BillOfMaterials", "Production");

                b.HasComment("Items required to make bicycles and bicycle subassemblies. It identifies the heirarchical relationship between a parent product and its components.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.BusinessEntity", b =>
            {
                b.Property<int>("BusinessEntityId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .HasComment("Primary key for all customers, vendors, and employees.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.HasKey("BusinessEntityId");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_BusinessEntity_rowguid");

                b.ToTable("BusinessEntity", "Person");

                b.HasComment("Source of the ID that connects vendors, customers, and employees with address and contact information.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.BusinessEntityAddress", b =>
            {
                b.Property<int>("BusinessEntityId")
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .HasComment("Primary key. Foreign key to BusinessEntity.BusinessEntityID.");

                b.Property<int>("AddressId")
                    .HasColumnName("AddressID")
                    .HasColumnType("int")
                    .HasComment("Primary key. Foreign key to Address.AddressID.");

                b.Property<int>("AddressTypeId")
                    .HasColumnName("AddressTypeID")
                    .HasColumnType("int")
                    .HasComment("Primary key. Foreign key to AddressType.AddressTypeID.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.HasKey("BusinessEntityId", "AddressId", "AddressTypeId")
                    .HasName("PK_BusinessEntityAddress_BusinessEntityID_AddressID_AddressTypeID");

                b.HasIndex("AddressId");

                b.HasIndex("AddressTypeId");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_BusinessEntityAddress_rowguid");

                b.ToTable("BusinessEntityAddress", "Person");

                b.HasComment("Cross-reference table mapping customers, vendors, and employees to their addresses.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.BusinessEntityContact", b =>
            {
                b.Property<int>("BusinessEntityId")
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .HasComment("Primary key. Foreign key to BusinessEntity.BusinessEntityID.");

                b.Property<int>("PersonId")
                    .HasColumnName("PersonID")
                    .HasColumnType("int")
                    .HasComment("Primary key. Foreign key to Person.BusinessEntityID.");

                b.Property<int>("ContactTypeId")
                    .HasColumnName("ContactTypeID")
                    .HasColumnType("int")
                    .HasComment("Primary key.  Foreign key to ContactType.ContactTypeID.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.HasKey("BusinessEntityId", "PersonId", "ContactTypeId")
                    .HasName("PK_BusinessEntityContact_BusinessEntityID_PersonID_ContactTypeID");

                b.HasIndex("ContactTypeId");

                b.HasIndex("PersonId");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_BusinessEntityContact_rowguid");

                b.ToTable("BusinessEntityContact", "Person");

                b.HasComment("Cross-reference table mapping stores, vendors, and employees to people");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ContactType", b =>
            {
                b.Property<int>("ContactTypeId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ContactTypeID")
                    .HasColumnType("int")
                    .HasComment("Primary key for ContactType records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Contact type description.")
                    .HasMaxLength(50);

                b.HasKey("ContactTypeId");

                b.HasIndex("Name")
                    .IsUnique()
                    .HasName("AK_ContactType_Name");

                b.ToTable("ContactType", "Person");

                b.HasComment("Lookup table containing the types of business entity contacts.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.CountryRegion", b =>
            {
                b.Property<string>("CountryRegionCode")
                    .HasColumnType("nvarchar(3)")
                    .HasComment("ISO standard code for countries and regions.")
                    .HasMaxLength(3);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Country or region name.")
                    .HasMaxLength(50);

                b.HasKey("CountryRegionCode")
                    .HasName("PK_CountryRegion_CountryRegionCode");

                b.HasIndex("Name")
                    .IsUnique()
                    .HasName("AK_CountryRegion_Name");

                b.ToTable("CountryRegion", "Person");

                b.HasComment("Lookup table containing the ISO standard codes for countries and regions.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.CountryRegionCurrency", b =>
            {
                b.Property<string>("CountryRegionCode")
                    .HasColumnType("nvarchar(3)")
                    .HasComment("ISO code for countries and regions. Foreign key to CountryRegion.CountryRegionCode.")
                    .HasMaxLength(3);

                b.Property<string>("CurrencyCode")
                    .HasColumnType("nchar(3)")
                    .IsFixedLength(true)
                    .HasComment("ISO standard currency code. Foreign key to Currency.CurrencyCode.")
                    .HasMaxLength(3);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.HasKey("CountryRegionCode", "CurrencyCode")
                    .HasName("PK_CountryRegionCurrency_CountryRegionCode_CurrencyCode");

                b.HasIndex("CurrencyCode");

                b.ToTable("CountryRegionCurrency", "Sales");

                b.HasComment("Cross-reference table mapping ISO currency codes to a country or region.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.CreditCard", b =>
            {
                b.Property<int>("CreditCardId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CreditCardID")
                    .HasColumnType("int")
                    .HasComment("Primary key for CreditCard records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("CardNumber")
                    .IsRequired()
                    .HasColumnType("nvarchar(25)")
                    .HasComment("Credit card number.")
                    .HasMaxLength(25);

                b.Property<string>("CardType")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Credit card name.")
                    .HasMaxLength(50);

                b.Property<byte>("ExpMonth")
                    .HasColumnType("tinyint")
                    .HasComment("Credit card expiration month.");

                b.Property<short>("ExpYear")
                    .HasColumnType("smallint")
                    .HasComment("Credit card expiration year.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.HasKey("CreditCardId");

                b.HasIndex("CardNumber")
                    .IsUnique()
                    .HasName("AK_CreditCard_CardNumber");

                b.ToTable("CreditCard", "Sales");

                b.HasComment("Customer credit card information.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Culture", b =>
            {
                b.Property<string>("CultureId")
                    .HasColumnName("CultureID")
                    .HasColumnType("nchar(6)")
                    .IsFixedLength(true)
                    .HasComment("Primary key for Culture records.")
                    .HasMaxLength(6);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Culture description.")
                    .HasMaxLength(50);

                b.HasKey("CultureId");

                b.HasIndex("Name")
                    .IsUnique()
                    .HasName("AK_Culture_Name");

                b.ToTable("Culture", "Production");

                b.HasComment("Lookup table containing the languages in which some AdventureWorks data is stored.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Currency", b =>
            {
                b.Property<string>("CurrencyCode")
                    .HasColumnType("nchar(3)")
                    .IsFixedLength(true)
                    .HasComment("The ISO code for the Currency.")
                    .HasMaxLength(3);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Currency name.")
                    .HasMaxLength(50);

                b.HasKey("CurrencyCode")
                    .HasName("PK_Currency_CurrencyCode");

                b.HasIndex("Name")
                    .IsUnique()
                    .HasName("AK_Currency_Name");

                b.ToTable("Currency", "Sales");

                b.HasComment("Lookup table containing standard ISO currencies.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.CurrencyRate", b =>
            {
                b.Property<int>("CurrencyRateId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CurrencyRateID")
                    .HasColumnType("int")
                    .HasComment("Primary key for CurrencyRate records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<decimal>("AverageRate")
                    .HasColumnType("money")
                    .HasComment("Average exchange rate for the day.");

                b.Property<DateTime>("CurrencyRateDate")
                    .HasColumnType("datetime")
                    .HasComment("Date and time the exchange rate was obtained.");

                b.Property<decimal>("EndOfDayRate")
                    .HasColumnType("money")
                    .HasComment("Final exchange rate for the day.");

                b.Property<string>("FromCurrencyCode")
                    .IsRequired()
                    .HasColumnType("nchar(3)")
                    .IsFixedLength(true)
                    .HasComment("Exchange rate was converted from this currency code.")
                    .HasMaxLength(3);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("ToCurrencyCode")
                    .IsRequired()
                    .HasColumnType("nchar(3)")
                    .IsFixedLength(true)
                    .HasComment("Exchange rate was converted to this currency code.")
                    .HasMaxLength(3);

                b.HasKey("CurrencyRateId");

                b.HasIndex("FromCurrencyCode");

                b.HasIndex("ToCurrencyCode");

                b.HasIndex("CurrencyRateDate", "FromCurrencyCode", "ToCurrencyCode")
                    .IsUnique()
                    .HasName("AK_CurrencyRate_CurrencyRateDate_FromCurrencyCode_ToCurrencyCode");

                b.ToTable("CurrencyRate", "Sales");

                b.HasComment("Currency exchange rates.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Customer", b =>
            {
                b.Property<int>("CustomerId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CustomerID")
                    .HasColumnType("int")
                    .HasComment("Primary key.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("AccountNumber")
                    .IsRequired()
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnType("varchar(10)")
                    .HasComputedColumnSql("(isnull('AW'+[dbo].[ufnLeadingZeros]([CustomerID]),''))")
                    .HasComment("Unique number identifying the customer assigned by the accounting system.")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<int?>("PersonId")
                    .HasColumnName("PersonID")
                    .HasColumnType("int")
                    .HasComment("Foreign key to Person.BusinessEntityID");

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.Property<int?>("StoreId")
                    .HasColumnName("StoreID")
                    .HasColumnType("int")
                    .HasComment("Foreign key to Store.BusinessEntityID");

                b.Property<int?>("TerritoryId")
                    .HasColumnName("TerritoryID")
                    .HasColumnType("int")
                    .HasComment("ID of the territory in which the customer is located. Foreign key to SalesTerritory.SalesTerritoryID.");

                b.HasKey("CustomerId");

                b.HasIndex("AccountNumber")
                    .IsUnique()
                    .HasName("AK_Customer_AccountNumber");

                b.HasIndex("PersonId");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_Customer_rowguid");

                b.HasIndex("StoreId");

                b.HasIndex("TerritoryId");

                b.ToTable("Customer", "Sales");

                b.HasComment("Current customer information. Also see the Person and Store tables.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.DatabaseLog", b =>
            {
                b.Property<int>("DatabaseLogId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DatabaseLogID")
                    .HasColumnType("int")
                    .HasComment("Primary key for DatabaseLog records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("DatabaseUser")
                    .IsRequired()
                    .HasColumnType("nvarchar(128)")
                    .HasComment("The user who implemented the DDL change.")
                    .HasMaxLength(128);

                b.Property<string>("Event")
                    .IsRequired()
                    .HasColumnType("nvarchar(128)")
                    .HasComment("The type of DDL statement that was executed.")
                    .HasMaxLength(128);

                b.Property<string>("Object")
                    .HasColumnType("nvarchar(128)")
                    .HasComment("The object that was changed by the DDL statment.")
                    .HasMaxLength(128);

                b.Property<DateTime>("PostTime")
                    .HasColumnType("datetime")
                    .HasComment("The date and time the DDL change occurred.");

                b.Property<string>("Schema")
                    .HasColumnType("nvarchar(128)")
                    .HasComment("The schema to which the changed object belongs.")
                    .HasMaxLength(128);

                b.Property<string>("Tsql")
                    .IsRequired()
                    .HasColumnName("TSQL")
                    .HasColumnType("nvarchar(max)")
                    .HasComment("The exact Transact-SQL statement that was executed.");

                b.Property<string>("XmlEvent")
                    .IsRequired()
                    .HasColumnType("xml")
                    .HasComment("The raw XML data generated by database trigger.");

                b.HasKey("DatabaseLogId")
                    .HasName("PK_DatabaseLog_DatabaseLogID")
                    .HasAnnotation("SqlServer:Clustered", false);

                b.ToTable("DatabaseLog");

                b.HasComment("Audit table tracking all DDL changes made to the AdventureWorks database. Data is captured by the database trigger ddlDatabaseTriggerLog.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Department", b =>
            {
                b.Property<short>("DepartmentId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DepartmentID")
                    .HasColumnType("smallint")
                    .HasComment("Primary key for Department records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("GroupName")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Name of the group to which the department belongs.")
                    .HasMaxLength(50);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Name of the department.")
                    .HasMaxLength(50);

                b.HasKey("DepartmentId");

                b.HasIndex("Name")
                    .IsUnique()
                    .HasName("AK_Department_Name");

                b.ToTable("Department", "HumanResources");

                b.HasComment("Lookup table containing the departments within the Adventure Works Cycles company.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.EmailAddress", b =>
            {
                b.Property<int>("BusinessEntityId")
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .HasComment("Primary key. Person associated with this email address.  Foreign key to Person.BusinessEntityID");

                b.Property<int>("EmailAddressId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EmailAddressID")
                    .HasColumnType("int")
                    .HasComment("Primary key. ID of this email address.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("EmailAddress1")
                    .HasColumnName("EmailAddress")
                    .HasColumnType("nvarchar(50)")
                    .HasComment("E-mail address for the person.")
                    .HasMaxLength(50);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.HasKey("BusinessEntityId", "EmailAddressId")
                    .HasName("PK_EmailAddress_BusinessEntityID_EmailAddressID");

                b.HasIndex("EmailAddress1");

                b.ToTable("EmailAddress", "Person");

                b.HasComment("Where to send a person email.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Employee", b =>
            {
                b.Property<int>("BusinessEntityId")
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .HasComment("Primary key for Employee records.  Foreign key to BusinessEntity.BusinessEntityID.");

                b.Property<DateTime>("BirthDate")
                    .HasColumnType("date")
                    .HasComment("Date of birth.");

                b.Property<bool?>("CurrentFlag")
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bit")
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 = Inactive, 1 = Active");

                b.Property<string>("Gender")
                    .IsRequired()
                    .HasColumnType("nchar(1)")
                    .IsFixedLength(true)
                    .HasComment("M = Male, F = Female")
                    .HasMaxLength(1);

                b.Property<DateTime>("HireDate")
                    .HasColumnType("date")
                    .HasComment("Employee hired on this date.");

                b.Property<string>("JobTitle")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Work title such as Buyer or Sales Representative.")
                    .HasMaxLength(50);

                b.Property<string>("LoginId")
                    .IsRequired()
                    .HasColumnName("LoginID")
                    .HasColumnType("nvarchar(256)")
                    .HasComment("Network login.")
                    .HasMaxLength(256);

                b.Property<string>("MaritalStatus")
                    .IsRequired()
                    .HasColumnType("nchar(1)")
                    .IsFixedLength(true)
                    .HasComment("M = Married, S = Single")
                    .HasMaxLength(1);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("NationalIdnumber")
                    .IsRequired()
                    .HasColumnName("NationalIDNumber")
                    .HasColumnType("nvarchar(15)")
                    .HasComment("Unique national identification number such as a social security number.")
                    .HasMaxLength(15);

                b.Property<short?>("OrganizationLevel")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnType("smallint")
                    .HasComputedColumnSql("([OrganizationNode].[GetLevel]())")
                    .HasComment("The depth of the employee in the corporate hierarchy.");

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.Property<bool?>("SalariedFlag")
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bit")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Job classification. 0 = Hourly, not exempt from collective bargaining. 1 = Salaried, exempt from collective bargaining.");

                b.Property<short>("SickLeaveHours")
                    .HasColumnType("smallint")
                    .HasComment("Number of available sick leave hours.");

                b.Property<short>("VacationHours")
                    .HasColumnType("smallint")
                    .HasComment("Number of available vacation hours.");

                b.HasKey("BusinessEntityId")
                    .HasName("PK_Employee_BusinessEntityID");

                b.HasIndex("LoginId")
                    .IsUnique()
                    .HasName("AK_Employee_LoginID");

                b.HasIndex("NationalIdnumber")
                    .IsUnique()
                    .HasName("AK_Employee_NationalIDNumber");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_Employee_rowguid");

                b.ToTable("Employee", "HumanResources");

                b.HasComment("Employee information such as salary, department, and title.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.EmployeeDepartmentHistory", b =>
            {
                b.Property<int>("BusinessEntityId")
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .HasComment("Employee identification number. Foreign key to Employee.BusinessEntityID.");

                b.Property<DateTime>("StartDate")
                    .HasColumnType("date")
                    .HasComment("Date the employee started work in the department.");

                b.Property<short>("DepartmentId")
                    .HasColumnName("DepartmentID")
                    .HasColumnType("smallint")
                    .HasComment("Department in which the employee worked including currently. Foreign key to Department.DepartmentID.");

                b.Property<byte>("ShiftId")
                    .HasColumnName("ShiftID")
                    .HasColumnType("tinyint")
                    .HasComment("Identifies which 8-hour shift the employee works. Foreign key to Shift.Shift.ID.");

                b.Property<DateTime?>("EndDate")
                    .HasColumnType("date")
                    .HasComment("Date the employee left the department. NULL = Current department.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.HasKey("BusinessEntityId", "StartDate", "DepartmentId", "ShiftId")
                    .HasName("PK_EmployeeDepartmentHistory_BusinessEntityID_StartDate_DepartmentID");

                b.HasIndex("DepartmentId");

                b.HasIndex("ShiftId");

                b.ToTable("EmployeeDepartmentHistory", "HumanResources");

                b.HasComment("Employee department transfers.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.EmployeePayHistory", b =>
            {
                b.Property<int>("BusinessEntityId")
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .HasComment("Employee identification number. Foreign key to Employee.BusinessEntityID.");

                b.Property<DateTime>("RateChangeDate")
                    .HasColumnType("datetime")
                    .HasComment("Date the change in pay is effective");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<byte>("PayFrequency")
                    .HasColumnType("tinyint")
                    .HasComment("1 = Salary received monthly, 2 = Salary received biweekly");

                b.Property<decimal>("Rate")
                    .HasColumnType("money")
                    .HasComment("Salary hourly rate.");

                b.HasKey("BusinessEntityId", "RateChangeDate")
                    .HasName("PK_EmployeePayHistory_BusinessEntityID_RateChangeDate");

                b.ToTable("EmployeePayHistory", "HumanResources");

                b.HasComment("Employee pay history.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ErrorLog", b =>
            {
                b.Property<int>("ErrorLogId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ErrorLogID")
                    .HasColumnType("int")
                    .HasComment("Primary key for ErrorLog records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int?>("ErrorLine")
                    .HasColumnType("int")
                    .HasComment("The line number at which the error occurred.");

                b.Property<string>("ErrorMessage")
                    .IsRequired()
                    .HasColumnType("nvarchar(4000)")
                    .HasComment("The message text of the error that occurred.")
                    .HasMaxLength(4000);

                b.Property<int>("ErrorNumber")
                    .HasColumnType("int")
                    .HasComment("The error number of the error that occurred.");

                b.Property<string>("ErrorProcedure")
                    .HasColumnType("nvarchar(126)")
                    .HasComment("The name of the stored procedure or trigger where the error occurred.")
                    .HasMaxLength(126);

                b.Property<int?>("ErrorSeverity")
                    .HasColumnType("int")
                    .HasComment("The severity of the error that occurred.");

                b.Property<int?>("ErrorState")
                    .HasColumnType("int")
                    .HasComment("The state number of the error that occurred.");

                b.Property<DateTime>("ErrorTime")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The date and time at which the error occurred.");

                b.Property<string>("UserName")
                    .IsRequired()
                    .HasColumnType("nvarchar(128)")
                    .HasComment("The user who executed the batch in which the error occurred.")
                    .HasMaxLength(128);

                b.HasKey("ErrorLogId");

                b.ToTable("ErrorLog");

                b.HasComment("Audit table tracking errors in the the AdventureWorks database that are caught by the CATCH block of a TRY...CATCH construct. Data is inserted by stored procedure dbo.uspLogError when it is executed from inside the CATCH block of a TRY...CATCH construct.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Illustration", b =>
            {
                b.Property<int>("IllustrationId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IllustrationID")
                    .HasColumnType("int")
                    .HasComment("Primary key for Illustration records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Diagram")
                    .HasColumnType("xml")
                    .HasComment("Illustrations used in manufacturing instructions. Stored as XML.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.HasKey("IllustrationId");

                b.ToTable("Illustration", "Production");

                b.HasComment("Bicycle assembly diagrams.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.JobCandidate", b =>
            {
                b.Property<int>("JobCandidateId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("JobCandidateID")
                    .HasColumnType("int")
                    .HasComment("Primary key for JobCandidate records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int?>("BusinessEntityId")
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .HasComment("Employee identification number if applicant was hired. Foreign key to Employee.BusinessEntityID.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Resume")
                    .HasColumnType("xml")
                    .HasComment("Résumé in XML format.");

                b.HasKey("JobCandidateId");

                b.HasIndex("BusinessEntityId");

                b.ToTable("JobCandidate", "HumanResources");

                b.HasComment("Résumés submitted to Human Resources by job applicants.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Location", b =>
            {
                b.Property<short>("LocationId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LocationID")
                    .HasColumnType("smallint")
                    .HasComment("Primary key for Location records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<decimal>("Availability")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Work capacity (in hours) of the manufacturing location.");

                b.Property<decimal>("CostRate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Standard hourly cost of the manufacturing location.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Location description.")
                    .HasMaxLength(50);

                b.HasKey("LocationId");

                b.HasIndex("Name")
                    .IsUnique()
                    .HasName("AK_Location_Name");

                b.ToTable("Location", "Production");

                b.HasComment("Product inventory and manufacturing locations.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Password", b =>
            {
                b.Property<int>("BusinessEntityId")
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("PasswordHash")
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasComment("Password for the e-mail account.")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                b.Property<string>("PasswordSalt")
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasComment("Random value concatenated with the password string before the password is hashed.")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.HasKey("BusinessEntityId")
                    .HasName("PK_Password_BusinessEntityID");

                b.ToTable("Password", "Person");

                b.HasComment("One way hashed authentication information");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Person", b =>
            {
                b.Property<int>("BusinessEntityId")
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .HasComment("Primary key for Person records.");

                b.Property<string>("AdditionalContactInfo")
                    .HasColumnType("xml")
                    .HasComment("Additional contact information about the person stored in xml format. ");

                b.Property<string>("Demographics")
                    .HasColumnType("xml")
                    .HasComment("Personal information such as hobbies, and income collected from online shoppers. Used for sales analysis.");

                b.Property<int>("EmailPromotion")
                    .HasColumnType("int")
                    .HasComment("0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners. ");

                b.Property<string>("FirstName")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("First name of the person.")
                    .HasMaxLength(50);

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Last name of the person.")
                    .HasMaxLength(50);

                b.Property<string>("MiddleName")
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Middle name or middle initial of the person.")
                    .HasMaxLength(50);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<bool>("NameStyle")
                    .HasColumnType("bit")
                    .HasComment("0 = The data in FirstName and LastName are stored in western style (first name, last name) order.  1 = Eastern style (last name, first name) order.");

                b.Property<string>("PersonType")
                    .IsRequired()
                    .HasColumnType("nchar(2)")
                    .IsFixedLength(true)
                    .HasComment("Primary type of person: SC = Store Contact, IN = Individual (retail) customer, SP = Sales person, EM = Employee (non-sales), VC = Vendor contact, GC = General contact")
                    .HasMaxLength(2);

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.Property<string>("Suffix")
                    .HasColumnType("nvarchar(10)")
                    .HasComment("Surname suffix. For example, Sr. or Jr.")
                    .HasMaxLength(10);

                b.Property<string>("Title")
                    .HasColumnType("nvarchar(8)")
                    .HasComment("A courtesy title. For example, Mr. or Ms.")
                    .HasMaxLength(8);

                b.HasKey("BusinessEntityId")
                    .HasName("PK_Person_BusinessEntityID");

                b.HasIndex("AdditionalContactInfo")
                    .HasName("PXML_Person_AddContact");

                b.HasIndex("Demographics")
                    .HasName("XMLVALUE_Person_Demographics");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_Person_rowguid");

                b.HasIndex("LastName", "FirstName", "MiddleName");

                b.ToTable("Person", "Person");

                b.HasComment("Human beings involved with AdventureWorks: employees, customer contacts, and vendor contacts.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.PersonCreditCard", b =>
            {
                b.Property<int>("BusinessEntityId")
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .HasComment("Business entity identification number. Foreign key to Person.BusinessEntityID.");

                b.Property<int>("CreditCardId")
                    .HasColumnName("CreditCardID")
                    .HasColumnType("int")
                    .HasComment("Credit card identification number. Foreign key to CreditCard.CreditCardID.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.HasKey("BusinessEntityId", "CreditCardId")
                    .HasName("PK_PersonCreditCard_BusinessEntityID_CreditCardID");

                b.HasIndex("CreditCardId");

                b.ToTable("PersonCreditCard", "Sales");

                b.HasComment("Cross-reference table mapping people to their credit card information in the CreditCard table. ");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.PersonPhone", b =>
            {
                b.Property<int>("BusinessEntityId")
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .HasComment("Business entity identification number. Foreign key to Person.BusinessEntityID.");

                b.Property<string>("PhoneNumber")
                    .HasColumnType("nvarchar(25)")
                    .HasComment("Telephone number identification number.")
                    .HasMaxLength(25);

                b.Property<int>("PhoneNumberTypeId")
                    .HasColumnName("PhoneNumberTypeID")
                    .HasColumnType("int")
                    .HasComment("Kind of phone number. Foreign key to PhoneNumberType.PhoneNumberTypeID.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.HasKey("BusinessEntityId", "PhoneNumber", "PhoneNumberTypeId")
                    .HasName("PK_PersonPhone_BusinessEntityID_PhoneNumber_PhoneNumberTypeID");

                b.HasIndex("PhoneNumber");

                b.HasIndex("PhoneNumberTypeId");

                b.ToTable("PersonPhone", "Person");

                b.HasComment("Telephone number and type of a person.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.PhoneNumberType", b =>
            {
                b.Property<int>("PhoneNumberTypeId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PhoneNumberTypeID")
                    .HasColumnType("int")
                    .HasComment("Primary key for telephone number type records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Name of the telephone number type")
                    .HasMaxLength(50);

                b.HasKey("PhoneNumberTypeId");

                b.ToTable("PhoneNumberType", "Person");

                b.HasComment("Type of phone number of a person.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Product", b =>
            {
                b.Property<int>("ProductId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProductID")
                    .HasColumnType("int")
                    .HasComment("Primary key for Product records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Class")
                    .HasColumnType("nchar(2)")
                    .IsFixedLength(true)
                    .HasComment("H = High, M = Medium, L = Low")
                    .HasMaxLength(2);

                b.Property<string>("Color")
                    .HasColumnType("nvarchar(15)")
                    .HasComment("Product color.")
                    .HasMaxLength(15);

                b.Property<int>("DaysToManufacture")
                    .HasColumnType("int")
                    .HasComment("Number of days required to manufacture the product.");

                b.Property<DateTime?>("DiscontinuedDate")
                    .HasColumnType("datetime")
                    .HasComment("Date the product was discontinued.");

                b.Property<bool?>("FinishedGoodsFlag")
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bit")
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 = Product is not a salable item. 1 = Product is salable.");

                b.Property<decimal>("ListPrice")
                    .HasColumnType("money")
                    .HasComment("Selling price.");

                b.Property<bool?>("MakeFlag")
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bit")
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 = Product is purchased, 1 = Product is manufactured in-house.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Name of the product.")
                    .HasMaxLength(50);

                b.Property<string>("ProductLine")
                    .HasColumnType("nchar(2)")
                    .IsFixedLength(true)
                    .HasComment("R = Road, M = Mountain, T = Touring, S = Standard")
                    .HasMaxLength(2);

                b.Property<int?>("ProductModelId")
                    .HasColumnName("ProductModelID")
                    .HasColumnType("int")
                    .HasComment("Product is a member of this product model. Foreign key to ProductModel.ProductModelID.");

                b.Property<string>("ProductNumber")
                    .IsRequired()
                    .HasColumnType("nvarchar(25)")
                    .HasComment("Unique product identification number.")
                    .HasMaxLength(25);

                b.Property<int?>("ProductSubcategoryId")
                    .HasColumnName("ProductSubcategoryID")
                    .HasColumnType("int")
                    .HasComment("Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID. ");

                b.Property<short>("ReorderPoint")
                    .HasColumnType("smallint")
                    .HasComment("Inventory level that triggers a purchase order or work order. ");

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.Property<short>("SafetyStockLevel")
                    .HasColumnType("smallint")
                    .HasComment("Minimum inventory quantity. ");

                b.Property<DateTime?>("SellEndDate")
                    .HasColumnType("datetime")
                    .HasComment("Date the product was no longer available for sale.");

                b.Property<DateTime>("SellStartDate")
                    .HasColumnType("datetime")
                    .HasComment("Date the product was available for sale.");

                b.Property<string>("Size")
                    .HasColumnType("nvarchar(5)")
                    .HasComment("Product size.")
                    .HasMaxLength(5);

                b.Property<string>("SizeUnitMeasureCode")
                    .HasColumnType("nchar(3)")
                    .IsFixedLength(true)
                    .HasComment("Unit of measure for Size column.")
                    .HasMaxLength(3);

                b.Property<decimal>("StandardCost")
                    .HasColumnType("money")
                    .HasComment("Standard cost of the product.");

                b.Property<string>("Style")
                    .HasColumnType("nchar(2)")
                    .IsFixedLength(true)
                    .HasComment("W = Womens, M = Mens, U = Universal")
                    .HasMaxLength(2);

                b.Property<decimal?>("Weight")
                    .HasColumnType("decimal(8, 2)")
                    .HasComment("Product weight.");

                b.Property<string>("WeightUnitMeasureCode")
                    .HasColumnType("nchar(3)")
                    .IsFixedLength(true)
                    .HasComment("Unit of measure for Weight column.")
                    .HasMaxLength(3);

                b.HasKey("ProductId");

                b.HasIndex("Name")
                    .IsUnique()
                    .HasName("AK_Product_Name");

                b.HasIndex("ProductModelId");

                b.HasIndex("ProductNumber")
                    .IsUnique()
                    .HasName("AK_Product_ProductNumber");

                b.HasIndex("ProductSubcategoryId");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_Product_rowguid");

                b.HasIndex("SizeUnitMeasureCode");

                b.HasIndex("WeightUnitMeasureCode");

                b.ToTable("Product", "Production");

                b.HasComment("Products sold or used in the manfacturing of sold products.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductCategory", b =>
            {
                b.Property<int>("ProductCategoryId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProductCategoryID")
                    .HasColumnType("int")
                    .HasComment("Primary key for ProductCategory records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Category description.")
                    .HasMaxLength(50);

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.HasKey("ProductCategoryId");

                b.HasIndex("Name")
                    .IsUnique()
                    .HasName("AK_ProductCategory_Name");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_ProductCategory_rowguid");

                b.ToTable("ProductCategory", "Production");

                b.HasComment("High-level product categorization.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductCostHistory", b =>
            {
                b.Property<int>("ProductId")
                    .HasColumnName("ProductID")
                    .HasColumnType("int")
                    .HasComment("Product identification number. Foreign key to Product.ProductID");

                b.Property<DateTime>("StartDate")
                    .HasColumnType("datetime")
                    .HasComment("Product cost start date.");

                b.Property<DateTime?>("EndDate")
                    .HasColumnType("datetime")
                    .HasComment("Product cost end date.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<decimal>("StandardCost")
                    .HasColumnType("money")
                    .HasComment("Standard cost of the product.");

                b.HasKey("ProductId", "StartDate")
                    .HasName("PK_ProductCostHistory_ProductID_StartDate");

                b.ToTable("ProductCostHistory", "Production");

                b.HasComment("Changes in the cost of a product over time.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductDescription", b =>
            {
                b.Property<int>("ProductDescriptionId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProductDescriptionID")
                    .HasColumnType("int")
                    .HasComment("Primary key for ProductDescription records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("nvarchar(400)")
                    .HasComment("Description of the product.")
                    .HasMaxLength(400);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.HasKey("ProductDescriptionId");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_ProductDescription_rowguid");

                b.ToTable("ProductDescription", "Production");

                b.HasComment("Product descriptions in several languages.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductInventory", b =>
            {
                b.Property<int>("ProductId")
                    .HasColumnName("ProductID")
                    .HasColumnType("int")
                    .HasComment("Product identification number. Foreign key to Product.ProductID.");

                b.Property<short>("LocationId")
                    .HasColumnName("LocationID")
                    .HasColumnType("smallint")
                    .HasComment("Inventory location identification number. Foreign key to Location.LocationID. ");

                b.Property<byte>("Bin")
                    .HasColumnType("tinyint")
                    .HasComment("Storage container on a shelf in an inventory location.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<short>("Quantity")
                    .HasColumnType("smallint")
                    .HasComment("Quantity of products in the inventory location.");

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.Property<string>("Shelf")
                    .IsRequired()
                    .HasColumnType("nvarchar(10)")
                    .HasComment("Storage compartment within an inventory location.")
                    .HasMaxLength(10);

                b.HasKey("ProductId", "LocationId")
                    .HasName("PK_ProductInventory_ProductID_LocationID");

                b.HasIndex("LocationId");

                b.ToTable("ProductInventory", "Production");

                b.HasComment("Product inventory information.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductListPriceHistory", b =>
            {
                b.Property<int>("ProductId")
                    .HasColumnName("ProductID")
                    .HasColumnType("int")
                    .HasComment("Product identification number. Foreign key to Product.ProductID");

                b.Property<DateTime>("StartDate")
                    .HasColumnType("datetime")
                    .HasComment("List price start date.");

                b.Property<DateTime?>("EndDate")
                    .HasColumnType("datetime")
                    .HasComment("List price end date");

                b.Property<decimal>("ListPrice")
                    .HasColumnType("money")
                    .HasComment("Product list price.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.HasKey("ProductId", "StartDate")
                    .HasName("PK_ProductListPriceHistory_ProductID_StartDate");

                b.ToTable("ProductListPriceHistory", "Production");

                b.HasComment("Changes in the list price of a product over time.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductModel", b =>
            {
                b.Property<int>("ProductModelId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProductModelID")
                    .HasColumnType("int")
                    .HasComment("Primary key for ProductModel records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("CatalogDescription")
                    .HasColumnType("xml")
                    .HasComment("Detailed product catalog information in xml format.");

                b.Property<string>("Instructions")
                    .HasColumnType("xml")
                    .HasComment("Manufacturing instructions in xml format.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Product model description.")
                    .HasMaxLength(50);

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.HasKey("ProductModelId");

                b.HasIndex("CatalogDescription")
                    .HasName("PXML_ProductModel_CatalogDescription");

                b.HasIndex("Instructions")
                    .HasName("PXML_ProductModel_Instructions");

                b.HasIndex("Name")
                    .IsUnique()
                    .HasName("AK_ProductModel_Name");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_ProductModel_rowguid");

                b.ToTable("ProductModel", "Production");

                b.HasComment("Product model classification.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductModelIllustration", b =>
            {
                b.Property<int>("ProductModelId")
                    .HasColumnName("ProductModelID")
                    .HasColumnType("int")
                    .HasComment("Primary key. Foreign key to ProductModel.ProductModelID.");

                b.Property<int>("IllustrationId")
                    .HasColumnName("IllustrationID")
                    .HasColumnType("int")
                    .HasComment("Primary key. Foreign key to Illustration.IllustrationID.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.HasKey("ProductModelId", "IllustrationId")
                    .HasName("PK_ProductModelIllustration_ProductModelID_IllustrationID");

                b.HasIndex("IllustrationId");

                b.ToTable("ProductModelIllustration", "Production");

                b.HasComment("Cross-reference table mapping product models and illustrations.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductModelProductDescriptionCulture", b =>
            {
                b.Property<int>("ProductModelId")
                    .HasColumnName("ProductModelID")
                    .HasColumnType("int")
                    .HasComment("Primary key. Foreign key to ProductModel.ProductModelID.");

                b.Property<int>("ProductDescriptionId")
                    .HasColumnName("ProductDescriptionID")
                    .HasColumnType("int")
                    .HasComment("Primary key. Foreign key to ProductDescription.ProductDescriptionID.");

                b.Property<string>("CultureId")
                    .HasColumnName("CultureID")
                    .HasColumnType("nchar(6)")
                    .IsFixedLength(true)
                    .HasComment("Culture identification number. Foreign key to Culture.CultureID.")
                    .HasMaxLength(6);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.HasKey("ProductModelId", "ProductDescriptionId", "CultureId")
                    .HasName("PK_ProductModelProductDescriptionCulture_ProductModelID_ProductDescriptionID_CultureID");

                b.HasIndex("CultureId");

                b.HasIndex("ProductDescriptionId");

                b.ToTable("ProductModelProductDescriptionCulture", "Production");

                b.HasComment("Cross-reference table mapping product descriptions and the language the description is written in.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductPhoto", b =>
            {
                b.Property<int>("ProductPhotoId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProductPhotoID")
                    .HasColumnType("int")
                    .HasComment("Primary key for ProductPhoto records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<byte[]>("LargePhoto")
                    .HasColumnType("varbinary(max)")
                    .HasComment("Large image of the product.");

                b.Property<string>("LargePhotoFileName")
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Large image file name.")
                    .HasMaxLength(50);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<byte[]>("ThumbNailPhoto")
                    .HasColumnType("varbinary(max)")
                    .HasComment("Small image of the product.");

                b.Property<string>("ThumbnailPhotoFileName")
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Small image file name.")
                    .HasMaxLength(50);

                b.HasKey("ProductPhotoId");

                b.ToTable("ProductPhoto", "Production");

                b.HasComment("Product images.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductProductPhoto", b =>
            {
                b.Property<int>("ProductId")
                    .HasColumnName("ProductID")
                    .HasColumnType("int")
                    .HasComment("Product identification number. Foreign key to Product.ProductID.");

                b.Property<int>("ProductPhotoId")
                    .HasColumnName("ProductPhotoID")
                    .HasColumnType("int")
                    .HasComment("Product photo identification number. Foreign key to ProductPhoto.ProductPhotoID.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<bool>("Primary")
                    .HasColumnType("bit")
                    .HasComment("0 = Photo is not the principal image. 1 = Photo is the principal image.");

                b.HasKey("ProductId", "ProductPhotoId")
                    .HasName("PK_ProductProductPhoto_ProductID_ProductPhotoID")
                    .HasAnnotation("SqlServer:Clustered", false);

                b.HasIndex("ProductPhotoId");

                b.ToTable("ProductProductPhoto", "Production");

                b.HasComment("Cross-reference table mapping products and product photos.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductReview", b =>
            {
                b.Property<int>("ProductReviewId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProductReviewID")
                    .HasColumnType("int")
                    .HasComment("Primary key for ProductReview records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Comments")
                    .HasColumnType("nvarchar(3850)")
                    .HasComment("Reviewer's comments")
                    .HasMaxLength(3850);

                b.Property<string>("EmailAddress")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Reviewer's e-mail address.")
                    .HasMaxLength(50);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<int>("ProductId")
                    .HasColumnName("ProductID")
                    .HasColumnType("int")
                    .HasComment("Product identification number. Foreign key to Product.ProductID.");

                b.Property<int>("Rating")
                    .HasColumnType("int")
                    .HasComment("Product rating given by the reviewer. Scale is 1 to 5 with 5 as the highest rating.");

                b.Property<DateTime>("ReviewDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date review was submitted.");

                b.Property<string>("ReviewerName")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Name of the reviewer.")
                    .HasMaxLength(50);

                b.HasKey("ProductReviewId");

                b.HasIndex("ProductId");

                b.HasIndex("Comments", "ProductId", "ReviewerName")
                    .HasName("IX_ProductReview_ProductID_Name");

                b.ToTable("ProductReview", "Production");

                b.HasComment("Customer reviews of products they have purchased.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductSubcategory", b =>
            {
                b.Property<int>("ProductSubcategoryId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProductSubcategoryID")
                    .HasColumnType("int")
                    .HasComment("Primary key for ProductSubcategory records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Subcategory description.")
                    .HasMaxLength(50);

                b.Property<int>("ProductCategoryId")
                    .HasColumnName("ProductCategoryID")
                    .HasColumnType("int")
                    .HasComment("Product category identification number. Foreign key to ProductCategory.ProductCategoryID.");

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.HasKey("ProductSubcategoryId");

                b.HasIndex("Name")
                    .IsUnique()
                    .HasName("AK_ProductSubcategory_Name");

                b.HasIndex("ProductCategoryId");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_ProductSubcategory_rowguid");

                b.ToTable("ProductSubcategory", "Production");

                b.HasComment("Product subcategories. See ProductCategory table.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductVendor", b =>
            {
                b.Property<int>("ProductId")
                    .HasColumnName("ProductID")
                    .HasColumnType("int")
                    .HasComment("Primary key. Foreign key to Product.ProductID.");

                b.Property<int>("BusinessEntityId")
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .HasComment("Primary key. Foreign key to Vendor.BusinessEntityID.");

                b.Property<int>("AverageLeadTime")
                    .HasColumnType("int")
                    .HasComment("The average span of time (in days) between placing an order with the vendor and receiving the purchased product.");

                b.Property<decimal?>("LastReceiptCost")
                    .HasColumnType("money")
                    .HasComment("The selling price when last purchased.");

                b.Property<DateTime?>("LastReceiptDate")
                    .HasColumnType("datetime")
                    .HasComment("Date the product was last received by the vendor.");

                b.Property<int>("MaxOrderQty")
                    .HasColumnType("int")
                    .HasComment("The minimum quantity that should be ordered.");

                b.Property<int>("MinOrderQty")
                    .HasColumnType("int")
                    .HasComment("The maximum quantity that should be ordered.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<int?>("OnOrderQty")
                    .HasColumnType("int")
                    .HasComment("The quantity currently on order.");

                b.Property<decimal>("StandardPrice")
                    .HasColumnType("money")
                    .HasComment("The vendor's usual selling price.");

                b.Property<string>("UnitMeasureCode")
                    .IsRequired()
                    .HasColumnType("nchar(3)")
                    .IsFixedLength(true)
                    .HasComment("The product's unit of measure.")
                    .HasMaxLength(3);

                b.HasKey("ProductId", "BusinessEntityId")
                    .HasName("PK_ProductVendor_ProductID_BusinessEntityID");

                b.HasIndex("BusinessEntityId");

                b.HasIndex("UnitMeasureCode");

                b.ToTable("ProductVendor", "Purchasing");

                b.HasComment("Cross-reference table mapping vendors with the products they supply.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.PurchaseOrderDetail", b =>
            {
                b.Property<int>("PurchaseOrderId")
                    .HasColumnName("PurchaseOrderID")
                    .HasColumnType("int")
                    .HasComment("Primary key. Foreign key to PurchaseOrderHeader.PurchaseOrderID.");

                b.Property<int>("PurchaseOrderDetailId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PurchaseOrderDetailID")
                    .HasColumnType("int")
                    .HasComment("Primary key. One line number per purchased product.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("DueDate")
                    .HasColumnType("datetime")
                    .HasComment("Date the product is expected to be received.");

                b.Property<decimal>("LineTotal")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnType("money")
                    .HasComputedColumnSql("(isnull([OrderQty]*[UnitPrice],(0.00)))")
                    .HasComment("Per product subtotal. Computed as OrderQty * UnitPrice.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<short>("OrderQty")
                    .HasColumnType("smallint")
                    .HasComment("Quantity ordered.");

                b.Property<int>("ProductId")
                    .HasColumnName("ProductID")
                    .HasColumnType("int")
                    .HasComment("Product identification number. Foreign key to Product.ProductID.");

                b.Property<decimal>("ReceivedQty")
                    .HasColumnType("decimal(8, 2)")
                    .HasComment("Quantity actually received from the vendor.");

                b.Property<decimal>("RejectedQty")
                    .HasColumnType("decimal(8, 2)")
                    .HasComment("Quantity rejected during inspection.");

                b.Property<decimal>("StockedQty")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnType("decimal(9, 2)")
                    .HasComputedColumnSql("(isnull([ReceivedQty]-[RejectedQty],(0.00)))")
                    .HasComment("Quantity accepted into inventory. Computed as ReceivedQty - RejectedQty.");

                b.Property<decimal>("UnitPrice")
                    .HasColumnType("money")
                    .HasComment("Vendor's selling price of a single product.");

                b.HasKey("PurchaseOrderId", "PurchaseOrderDetailId")
                    .HasName("PK_PurchaseOrderDetail_PurchaseOrderID_PurchaseOrderDetailID");

                b.HasIndex("ProductId");

                b.ToTable("PurchaseOrderDetail", "Purchasing");

                b.HasComment("Individual products associated with a specific purchase order. See PurchaseOrderHeader.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.PurchaseOrderHeader", b =>
            {
                b.Property<int>("PurchaseOrderId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PurchaseOrderID")
                    .HasColumnType("int")
                    .HasComment("Primary key.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("EmployeeId")
                    .HasColumnName("EmployeeID")
                    .HasColumnType("int")
                    .HasComment("Employee who created the purchase order. Foreign key to Employee.BusinessEntityID.");

                b.Property<decimal>("Freight")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Shipping cost.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<DateTime>("OrderDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Purchase order creation date.");

                b.Property<byte>("RevisionNumber")
                    .HasColumnType("tinyint")
                    .HasComment("Incremental number to track changes to the purchase order over time.");

                b.Property<DateTime?>("ShipDate")
                    .HasColumnType("datetime")
                    .HasComment("Estimated shipment date from the vendor.");

                b.Property<int>("ShipMethodId")
                    .HasColumnName("ShipMethodID")
                    .HasColumnType("int")
                    .HasComment("Shipping method. Foreign key to ShipMethod.ShipMethodID.");

                b.Property<byte>("Status")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("tinyint")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Order current status. 1 = Pending; 2 = Approved; 3 = Rejected; 4 = Complete");

                b.Property<decimal>("SubTotal")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID.");

                b.Property<decimal>("TaxAmt")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Tax amount.");

                b.Property<decimal>("TotalDue")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnType("money")
                    .HasComputedColumnSql("(isnull(([SubTotal]+[TaxAmt])+[Freight],(0)))")
                    .HasComment("Total due to vendor. Computed as Subtotal + TaxAmt + Freight.");

                b.Property<int>("VendorId")
                    .HasColumnName("VendorID")
                    .HasColumnType("int")
                    .HasComment("Vendor with whom the purchase order is placed. Foreign key to Vendor.BusinessEntityID.");

                b.HasKey("PurchaseOrderId")
                    .HasName("PK_PurchaseOrderHeader_PurchaseOrderID");

                b.HasIndex("EmployeeId");

                b.HasIndex("ShipMethodId");

                b.HasIndex("VendorId");

                b.ToTable("PurchaseOrderHeader", "Purchasing");

                b.HasComment("General purchase order information. See PurchaseOrderDetail.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.SalesOrderDetail", b =>
            {
                b.Property<int>("SalesOrderId")
                    .HasColumnName("SalesOrderID")
                    .HasColumnType("int")
                    .HasComment("Primary key. Foreign key to SalesOrderHeader.SalesOrderID.");

                b.Property<int>("SalesOrderDetailId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SalesOrderDetailID")
                    .HasColumnType("int")
                    .HasComment("Primary key. One incremental unique number per product sold.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("CarrierTrackingNumber")
                    .HasColumnType("nvarchar(25)")
                    .HasComment("Shipment tracking number supplied by the shipper.")
                    .HasMaxLength(25);

                b.Property<decimal>("LineTotal")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnType("numeric(38, 6)")
                    .HasComputedColumnSql("(isnull(([UnitPrice]*((1.0)-[UnitPriceDiscount]))*[OrderQty],(0.0)))")
                    .HasComment("Per product subtotal. Computed as UnitPrice * (1 - UnitPriceDiscount) * OrderQty.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<short>("OrderQty")
                    .HasColumnType("smallint")
                    .HasComment("Quantity ordered per product.");

                b.Property<int>("ProductId")
                    .HasColumnName("ProductID")
                    .HasColumnType("int")
                    .HasComment("Product sold to customer. Foreign key to Product.ProductID.");

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.Property<int>("SpecialOfferId")
                    .HasColumnName("SpecialOfferID")
                    .HasColumnType("int")
                    .HasComment("Promotional code. Foreign key to SpecialOffer.SpecialOfferID.");

                b.Property<decimal>("UnitPrice")
                    .HasColumnType("money")
                    .HasComment("Selling price of a single product.");

                b.Property<decimal>("UnitPriceDiscount")
                    .HasColumnType("money")
                    .HasComment("Discount amount.");

                b.HasKey("SalesOrderId", "SalesOrderDetailId")
                    .HasName("PK_SalesOrderDetail_SalesOrderID_SalesOrderDetailID");

                b.HasIndex("ProductId");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_SalesOrderDetail_rowguid");

                b.HasIndex("SpecialOfferId", "ProductId");

                b.ToTable("SalesOrderDetail", "Sales");

                b.HasComment("Individual products associated with a specific sales order. See SalesOrderHeader.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.SalesOrderHeader", b =>
            {
                b.Property<int>("SalesOrderId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SalesOrderID")
                    .HasColumnType("int")
                    .HasComment("Primary key.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("AccountNumber")
                    .HasColumnType("nvarchar(15)")
                    .HasComment("Financial accounting number reference.")
                    .HasMaxLength(15);

                b.Property<int>("BillToAddressId")
                    .HasColumnName("BillToAddressID")
                    .HasColumnType("int")
                    .HasComment("Customer billing address. Foreign key to Address.AddressID.");

                b.Property<string>("Comment")
                    .HasColumnType("nvarchar(128)")
                    .HasComment("Sales representative comments.")
                    .HasMaxLength(128);

                b.Property<string>("CreditCardApprovalCode")
                    .HasColumnType("varchar(15)")
                    .HasComment("Approval code provided by the credit card company.")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                b.Property<int?>("CreditCardId")
                    .HasColumnName("CreditCardID")
                    .HasColumnType("int")
                    .HasComment("Credit card identification number. Foreign key to CreditCard.CreditCardID.");

                b.Property<int?>("CurrencyRateId")
                    .HasColumnName("CurrencyRateID")
                    .HasColumnType("int")
                    .HasComment("Currency exchange rate used. Foreign key to CurrencyRate.CurrencyRateID.");

                b.Property<int>("CustomerId")
                    .HasColumnName("CustomerID")
                    .HasColumnType("int")
                    .HasComment("Customer identification number. Foreign key to Customer.BusinessEntityID.");

                b.Property<DateTime>("DueDate")
                    .HasColumnType("datetime")
                    .HasComment("Date the order is due to the customer.");

                b.Property<decimal>("Freight")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Shipping cost.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<bool?>("OnlineOrderFlag")
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bit")
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 = Order placed by sales person. 1 = Order placed online by customer.");

                b.Property<DateTime>("OrderDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Dates the sales order was created.");

                b.Property<string>("PurchaseOrderNumber")
                    .HasColumnType("nvarchar(25)")
                    .HasComment("Customer purchase order number reference. ")
                    .HasMaxLength(25);

                b.Property<byte>("RevisionNumber")
                    .HasColumnType("tinyint")
                    .HasComment("Incremental number to track changes to the sales order over time.");

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.Property<string>("SalesOrderNumber")
                    .IsRequired()
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnType("nvarchar(25)")
                    .HasComputedColumnSql("(isnull(N'SO'+CONVERT([nvarchar](23),[SalesOrderID]),N'*** ERROR ***'))")
                    .HasComment("Unique sales order identification number.")
                    .HasMaxLength(25);

                b.Property<int?>("SalesPersonId")
                    .HasColumnName("SalesPersonID")
                    .HasColumnType("int")
                    .HasComment("Sales person who created the sales order. Foreign key to SalesPerson.BusinessEntityID.");

                b.Property<DateTime?>("ShipDate")
                    .HasColumnType("datetime")
                    .HasComment("Date the order was shipped to the customer.");

                b.Property<int>("ShipMethodId")
                    .HasColumnName("ShipMethodID")
                    .HasColumnType("int")
                    .HasComment("Shipping method. Foreign key to ShipMethod.ShipMethodID.");

                b.Property<int>("ShipToAddressId")
                    .HasColumnName("ShipToAddressID")
                    .HasColumnType("int")
                    .HasComment("Customer shipping address. Foreign key to Address.AddressID.");

                b.Property<byte>("Status")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("tinyint")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Order current status. 1 = In process; 2 = Approved; 3 = Backordered; 4 = Rejected; 5 = Shipped; 6 = Cancelled");

                b.Property<decimal>("SubTotal")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Sales subtotal. Computed as SUM(SalesOrderDetail.LineTotal)for the appropriate SalesOrderID.");

                b.Property<decimal>("TaxAmt")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Tax amount.");

                b.Property<int?>("TerritoryId")
                    .HasColumnName("TerritoryID")
                    .HasColumnType("int")
                    .HasComment("Territory in which the sale was made. Foreign key to SalesTerritory.SalesTerritoryID.");

                b.Property<decimal>("TotalDue")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnType("money")
                    .HasComputedColumnSql("(isnull(([SubTotal]+[TaxAmt])+[Freight],(0)))")
                    .HasComment("Total due from customer. Computed as Subtotal + TaxAmt + Freight.");

                b.HasKey("SalesOrderId")
                    .HasName("PK_SalesOrderHeader_SalesOrderID");

                b.HasIndex("BillToAddressId");

                b.HasIndex("CreditCardId");

                b.HasIndex("CurrencyRateId");

                b.HasIndex("CustomerId");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_SalesOrderHeader_rowguid");

                b.HasIndex("SalesOrderNumber")
                    .IsUnique()
                    .HasName("AK_SalesOrderHeader_SalesOrderNumber");

                b.HasIndex("SalesPersonId");

                b.HasIndex("ShipMethodId");

                b.HasIndex("ShipToAddressId");

                b.HasIndex("TerritoryId");

                b.ToTable("SalesOrderHeader", "Sales");

                b.HasComment("General sales order information.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.SalesOrderHeaderSalesReason", b =>
            {
                b.Property<int>("SalesOrderId")
                    .HasColumnName("SalesOrderID")
                    .HasColumnType("int")
                    .HasComment("Primary key. Foreign key to SalesOrderHeader.SalesOrderID.");

                b.Property<int>("SalesReasonId")
                    .HasColumnName("SalesReasonID")
                    .HasColumnType("int")
                    .HasComment("Primary key. Foreign key to SalesReason.SalesReasonID.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.HasKey("SalesOrderId", "SalesReasonId")
                    .HasName("PK_SalesOrderHeaderSalesReason_SalesOrderID_SalesReasonID");

                b.HasIndex("SalesReasonId");

                b.ToTable("SalesOrderHeaderSalesReason", "Sales");

                b.HasComment("Cross-reference table mapping sales orders to sales reason codes.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.SalesPerson", b =>
            {
                b.Property<int>("BusinessEntityId")
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .HasComment("Primary key for SalesPerson records. Foreign key to Employee.BusinessEntityID");

                b.Property<decimal>("Bonus")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Bonus due if quota is met.");

                b.Property<decimal>("CommissionPct")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Commision percent received per sale.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.Property<decimal>("SalesLastYear")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Sales total of previous year.");

                b.Property<decimal?>("SalesQuota")
                    .HasColumnType("money")
                    .HasComment("Projected yearly sales.");

                b.Property<decimal>("SalesYtd")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SalesYTD")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Sales total year to date.");

                b.Property<int?>("TerritoryId")
                    .HasColumnName("TerritoryID")
                    .HasColumnType("int")
                    .HasComment("Territory currently assigned to. Foreign key to SalesTerritory.SalesTerritoryID.");

                b.HasKey("BusinessEntityId")
                    .HasName("PK_SalesPerson_BusinessEntityID");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_SalesPerson_rowguid");

                b.HasIndex("TerritoryId");

                b.ToTable("SalesPerson", "Sales");

                b.HasComment("Sales representative current information.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.SalesPersonQuotaHistory", b =>
            {
                b.Property<int>("BusinessEntityId")
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .HasComment("Sales person identification number. Foreign key to SalesPerson.BusinessEntityID.");

                b.Property<DateTime>("QuotaDate")
                    .HasColumnType("datetime")
                    .HasComment("Sales quota date.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.Property<decimal>("SalesQuota")
                    .HasColumnType("money")
                    .HasComment("Sales quota amount.");

                b.HasKey("BusinessEntityId", "QuotaDate")
                    .HasName("PK_SalesPersonQuotaHistory_BusinessEntityID_QuotaDate");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_SalesPersonQuotaHistory_rowguid");

                b.ToTable("SalesPersonQuotaHistory", "Sales");

                b.HasComment("Sales performance tracking.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.SalesReason", b =>
            {
                b.Property<int>("SalesReasonId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SalesReasonID")
                    .HasColumnType("int")
                    .HasComment("Primary key for SalesReason records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Sales reason description.")
                    .HasMaxLength(50);

                b.Property<string>("ReasonType")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Category the sales reason belongs to.")
                    .HasMaxLength(50);

                b.HasKey("SalesReasonId");

                b.ToTable("SalesReason", "Sales");

                b.HasComment("Lookup table of customer purchase reasons.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.SalesTaxRate", b =>
            {
                b.Property<int>("SalesTaxRateId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SalesTaxRateID")
                    .HasColumnType("int")
                    .HasComment("Primary key for SalesTaxRate records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Tax rate description.")
                    .HasMaxLength(50);

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.Property<int>("StateProvinceId")
                    .HasColumnName("StateProvinceID")
                    .HasColumnType("int")
                    .HasComment("State, province, or country/region the sales tax applies to.");

                b.Property<decimal>("TaxRate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Tax rate amount.");

                b.Property<byte>("TaxType")
                    .HasColumnType("tinyint")
                    .HasComment("1 = Tax applied to retail transactions, 2 = Tax applied to wholesale transactions, 3 = Tax applied to all sales (retail and wholesale) transactions.");

                b.HasKey("SalesTaxRateId");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_SalesTaxRate_rowguid");

                b.HasIndex("StateProvinceId", "TaxType")
                    .IsUnique()
                    .HasName("AK_SalesTaxRate_StateProvinceID_TaxType");

                b.ToTable("SalesTaxRate", "Sales");

                b.HasComment("Tax rate lookup table.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.SalesTerritory", b =>
            {
                b.Property<int>("TerritoryId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TerritoryID")
                    .HasColumnType("int")
                    .HasComment("Primary key for SalesTerritory records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<decimal>("CostLastYear")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Business costs in the territory the previous year.");

                b.Property<decimal>("CostYtd")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CostYTD")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Business costs in the territory year to date.");

                b.Property<string>("CountryRegionCode")
                    .IsRequired()
                    .HasColumnType("nvarchar(3)")
                    .HasComment("ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode. ")
                    .HasMaxLength(3);

                b.Property<string>("Group")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Geographic area to which the sales territory belong.")
                    .HasMaxLength(50);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Sales territory description")
                    .HasMaxLength(50);

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.Property<decimal>("SalesLastYear")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Sales in the territory the previous year.");

                b.Property<decimal>("SalesYtd")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SalesYTD")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Sales in the territory year to date.");

                b.HasKey("TerritoryId")
                    .HasName("PK_SalesTerritory_TerritoryID");

                b.HasIndex("CountryRegionCode");

                b.HasIndex("Name")
                    .IsUnique()
                    .HasName("AK_SalesTerritory_Name");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_SalesTerritory_rowguid");

                b.ToTable("SalesTerritory", "Sales");

                b.HasComment("Sales territory lookup table.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.SalesTerritoryHistory", b =>
            {
                b.Property<int>("BusinessEntityId")
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .HasComment("Primary key. The sales rep.  Foreign key to SalesPerson.BusinessEntityID.");

                b.Property<DateTime>("StartDate")
                    .HasColumnType("datetime")
                    .HasComment("Primary key. Date the sales representive started work in the territory.");

                b.Property<int>("TerritoryId")
                    .HasColumnName("TerritoryID")
                    .HasColumnType("int")
                    .HasComment("Primary key. Territory identification number. Foreign key to SalesTerritory.SalesTerritoryID.");

                b.Property<DateTime?>("EndDate")
                    .HasColumnType("datetime")
                    .HasComment("Date the sales representative left work in the territory.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.HasKey("BusinessEntityId", "StartDate", "TerritoryId")
                    .HasName("PK_SalesTerritoryHistory_BusinessEntityID_StartDate_TerritoryID");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_SalesTerritoryHistory_rowguid");

                b.HasIndex("TerritoryId");

                b.ToTable("SalesTerritoryHistory", "Sales");

                b.HasComment("Sales representative transfers to other sales territories.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ScrapReason", b =>
            {
                b.Property<short>("ScrapReasonId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ScrapReasonID")
                    .HasColumnType("smallint")
                    .HasComment("Primary key for ScrapReason records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Failure description.")
                    .HasMaxLength(50);

                b.HasKey("ScrapReasonId");

                b.HasIndex("Name")
                    .IsUnique()
                    .HasName("AK_ScrapReason_Name");

                b.ToTable("ScrapReason", "Production");

                b.HasComment("Manufacturing failure reasons lookup table.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Shift", b =>
            {
                b.Property<byte>("ShiftId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ShiftID")
                    .HasColumnType("tinyint")
                    .HasComment("Primary key for Shift records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<TimeSpan>("EndTime")
                    .HasColumnType("time")
                    .HasComment("Shift end time.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Shift description.")
                    .HasMaxLength(50);

                b.Property<TimeSpan>("StartTime")
                    .HasColumnType("time")
                    .HasComment("Shift start time.");

                b.HasKey("ShiftId");

                b.HasIndex("Name")
                    .IsUnique()
                    .HasName("AK_Shift_Name");

                b.HasIndex("StartTime", "EndTime")
                    .IsUnique()
                    .HasName("AK_Shift_StartTime_EndTime");

                b.ToTable("Shift", "HumanResources");

                b.HasComment("Work shift lookup table.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ShipMethod", b =>
            {
                b.Property<int>("ShipMethodId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ShipMethodID")
                    .HasColumnType("int")
                    .HasComment("Primary key for ShipMethod records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Shipping company name.")
                    .HasMaxLength(50);

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.Property<decimal>("ShipBase")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Minimum shipping charge.");

                b.Property<decimal>("ShipRate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Shipping charge per pound.");

                b.HasKey("ShipMethodId");

                b.HasIndex("Name")
                    .IsUnique()
                    .HasName("AK_ShipMethod_Name");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_ShipMethod_rowguid");

                b.ToTable("ShipMethod", "Purchasing");

                b.HasComment("Shipping company lookup table.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ShoppingCartItem", b =>
            {
                b.Property<int>("ShoppingCartItemId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ShoppingCartItemID")
                    .HasColumnType("int")
                    .HasComment("Primary key for ShoppingCartItem records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("DateCreated")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date the time the record was created.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<int>("ProductId")
                    .HasColumnName("ProductID")
                    .HasColumnType("int")
                    .HasComment("Product ordered. Foreign key to Product.ProductID.");

                b.Property<int>("Quantity")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Product quantity ordered.");

                b.Property<string>("ShoppingCartId")
                    .IsRequired()
                    .HasColumnName("ShoppingCartID")
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Shopping cart identification number.")
                    .HasMaxLength(50);

                b.HasKey("ShoppingCartItemId");

                b.HasIndex("ProductId");

                b.HasIndex("ShoppingCartId", "ProductId");

                b.ToTable("ShoppingCartItem", "Sales");

                b.HasComment("Contains online customer orders until the order is submitted or cancelled.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.SpecialOffer", b =>
            {
                b.Property<int>("SpecialOfferId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SpecialOfferID")
                    .HasColumnType("int")
                    .HasComment("Primary key for SpecialOffer records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Category")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Group the discount applies to such as Reseller or Customer.")
                    .HasMaxLength(50);

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("nvarchar(255)")
                    .HasComment("Discount description.")
                    .HasMaxLength(255);

                b.Property<decimal>("DiscountPct")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("Discount precentage.");

                b.Property<DateTime>("EndDate")
                    .HasColumnType("datetime")
                    .HasComment("Discount end date.");

                b.Property<int?>("MaxQty")
                    .HasColumnType("int")
                    .HasComment("Maximum discount percent allowed.");

                b.Property<int>("MinQty")
                    .HasColumnType("int")
                    .HasComment("Minimum discount percent allowed.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.Property<DateTime>("StartDate")
                    .HasColumnType("datetime")
                    .HasComment("Discount start date.");

                b.Property<string>("Type")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Discount type category.")
                    .HasMaxLength(50);

                b.HasKey("SpecialOfferId");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_SpecialOffer_rowguid");

                b.ToTable("SpecialOffer", "Sales");

                b.HasComment("Sale discounts lookup table.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.SpecialOfferProduct", b =>
            {
                b.Property<int>("SpecialOfferId")
                    .HasColumnName("SpecialOfferID")
                    .HasColumnType("int")
                    .HasComment("Primary key for SpecialOfferProduct records.");

                b.Property<int>("ProductId")
                    .HasColumnName("ProductID")
                    .HasColumnType("int")
                    .HasComment("Product identification number. Foreign key to Product.ProductID.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.HasKey("SpecialOfferId", "ProductId")
                    .HasName("PK_SpecialOfferProduct_SpecialOfferID_ProductID");

                b.HasIndex("ProductId");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_SpecialOfferProduct_rowguid");

                b.ToTable("SpecialOfferProduct", "Sales");

                b.HasComment("Cross-reference table mapping products to special offer discounts.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.StateProvince", b =>
            {
                b.Property<int>("StateProvinceId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("StateProvinceID")
                    .HasColumnType("int")
                    .HasComment("Primary key for StateProvince records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("CountryRegionCode")
                    .IsRequired()
                    .HasColumnType("nvarchar(3)")
                    .HasComment("ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode. ")
                    .HasMaxLength(3);

                b.Property<bool?>("IsOnlyStateProvinceFlag")
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bit")
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 = StateProvinceCode exists. 1 = StateProvinceCode unavailable, using CountryRegionCode.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("State or province description.")
                    .HasMaxLength(50);

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.Property<string>("StateProvinceCode")
                    .IsRequired()
                    .HasColumnType("nchar(3)")
                    .IsFixedLength(true)
                    .HasComment("ISO standard state or province code.")
                    .HasMaxLength(3);

                b.Property<int>("TerritoryId")
                    .HasColumnName("TerritoryID")
                    .HasColumnType("int")
                    .HasComment("ID of the territory in which the state or province is located. Foreign key to SalesTerritory.SalesTerritoryID.");

                b.HasKey("StateProvinceId");

                b.HasIndex("CountryRegionCode");

                b.HasIndex("Name")
                    .IsUnique()
                    .HasName("AK_StateProvince_Name");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_StateProvince_rowguid");

                b.HasIndex("TerritoryId");

                b.HasIndex("StateProvinceCode", "CountryRegionCode")
                    .IsUnique()
                    .HasName("AK_StateProvince_StateProvinceCode_CountryRegionCode");

                b.ToTable("StateProvince", "Person");

                b.HasComment("State and province lookup table.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Store", b =>
            {
                b.Property<int>("BusinessEntityId")
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .HasComment("Primary key. Foreign key to Customer.BusinessEntityID.");

                b.Property<string>("Demographics")
                    .HasColumnType("xml")
                    .HasComment("Demographic informationg about the store such as the number of employees, annual sales and store type.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Name of the store.")
                    .HasMaxLength(50);

                b.Property<Guid>("Rowguid")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");

                b.Property<int?>("SalesPersonId")
                    .HasColumnName("SalesPersonID")
                    .HasColumnType("int")
                    .HasComment("ID of the sales person assigned to the customer. Foreign key to SalesPerson.BusinessEntityID.");

                b.HasKey("BusinessEntityId")
                    .HasName("PK_Store_BusinessEntityID");

                b.HasIndex("Demographics")
                    .HasName("PXML_Store_Demographics");

                b.HasIndex("Rowguid")
                    .IsUnique()
                    .HasName("AK_Store_rowguid");

                b.HasIndex("SalesPersonId");

                b.ToTable("Store", "Sales");

                b.HasComment("Customers (resellers) of Adventure Works products.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.TransactionHistory", b =>
            {
                b.Property<int>("TransactionId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TransactionID")
                    .HasColumnType("int")
                    .HasComment("Primary key for TransactionHistory records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<decimal>("ActualCost")
                    .HasColumnType("money")
                    .HasComment("Product cost.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<int>("ProductId")
                    .HasColumnName("ProductID")
                    .HasColumnType("int")
                    .HasComment("Product identification number. Foreign key to Product.ProductID.");

                b.Property<int>("Quantity")
                    .HasColumnType("int")
                    .HasComment("Product quantity.");

                b.Property<int>("ReferenceOrderId")
                    .HasColumnName("ReferenceOrderID")
                    .HasColumnType("int")
                    .HasComment("Purchase order, sales order, or work order identification number.");

                b.Property<int>("ReferenceOrderLineId")
                    .HasColumnName("ReferenceOrderLineID")
                    .HasColumnType("int")
                    .HasComment("Line number associated with the purchase order, sales order, or work order.");

                b.Property<DateTime>("TransactionDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time of the transaction.");

                b.Property<string>("TransactionType")
                    .IsRequired()
                    .HasColumnType("nchar(1)")
                    .IsFixedLength(true)
                    .HasComment("W = WorkOrder, S = SalesOrder, P = PurchaseOrder")
                    .HasMaxLength(1);

                b.HasKey("TransactionId")
                    .HasName("PK_TransactionHistory_TransactionID");

                b.HasIndex("ProductId");

                b.HasIndex("ReferenceOrderId", "ReferenceOrderLineId");

                b.ToTable("TransactionHistory", "Production");

                b.HasComment("Record of each purchase order, sales order, or work order transaction year to date.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.TransactionHistoryArchive", b =>
            {
                b.Property<int>("TransactionId")
                    .HasColumnName("TransactionID")
                    .HasColumnType("int")
                    .HasComment("Primary key for TransactionHistoryArchive records.");

                b.Property<decimal>("ActualCost")
                    .HasColumnType("money")
                    .HasComment("Product cost.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<int>("ProductId")
                    .HasColumnName("ProductID")
                    .HasColumnType("int")
                    .HasComment("Product identification number. Foreign key to Product.ProductID.");

                b.Property<int>("Quantity")
                    .HasColumnType("int")
                    .HasComment("Product quantity.");

                b.Property<int>("ReferenceOrderId")
                    .HasColumnName("ReferenceOrderID")
                    .HasColumnType("int")
                    .HasComment("Purchase order, sales order, or work order identification number.");

                b.Property<int>("ReferenceOrderLineId")
                    .HasColumnName("ReferenceOrderLineID")
                    .HasColumnType("int")
                    .HasComment("Line number associated with the purchase order, sales order, or work order.");

                b.Property<DateTime>("TransactionDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time of the transaction.");

                b.Property<string>("TransactionType")
                    .IsRequired()
                    .HasColumnType("nchar(1)")
                    .IsFixedLength(true)
                    .HasComment("W = Work Order, S = Sales Order, P = Purchase Order")
                    .HasMaxLength(1);

                b.HasKey("TransactionId")
                    .HasName("PK_TransactionHistoryArchive_TransactionID");

                b.HasIndex("ProductId");

                b.HasIndex("ReferenceOrderId", "ReferenceOrderLineId");

                b.ToTable("TransactionHistoryArchive", "Production");

                b.HasComment("Transactions for previous years.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.UnitMeasure", b =>
            {
                b.Property<string>("UnitMeasureCode")
                    .HasColumnType("nchar(3)")
                    .IsFixedLength(true)
                    .HasComment("Primary key.")
                    .HasMaxLength(3);

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Unit of measure description.")
                    .HasMaxLength(50);

                b.HasKey("UnitMeasureCode")
                    .HasName("PK_UnitMeasure_UnitMeasureCode");

                b.HasIndex("Name")
                    .IsUnique()
                    .HasName("AK_UnitMeasure_Name");

                b.ToTable("UnitMeasure", "Production");

                b.HasComment("Unit of measure lookup table.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Vendor", b =>
            {
                b.Property<int>("BusinessEntityId")
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .HasComment("Primary key for Vendor records.  Foreign key to BusinessEntity.BusinessEntityID");

                b.Property<string>("AccountNumber")
                    .IsRequired()
                    .HasColumnType("nvarchar(15)")
                    .HasComment("Vendor account (identification) number.")
                    .HasMaxLength(15);

                b.Property<bool?>("ActiveFlag")
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bit")
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 = Vendor no longer used. 1 = Vendor is actively used.");

                b.Property<byte>("CreditRating")
                    .HasColumnType("tinyint")
                    .HasComment("1 = Superior, 2 = Excellent, 3 = Above average, 4 = Average, 5 = Below average");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(50)")
                    .HasComment("Company name.")
                    .HasMaxLength(50);

                b.Property<bool?>("PreferredVendorStatus")
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bit")
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 = Do not use if another vendor is available. 1 = Preferred over other vendors supplying the same product.");

                b.Property<string>("PurchasingWebServiceUrl")
                    .HasColumnName("PurchasingWebServiceURL")
                    .HasColumnType("nvarchar(1024)")
                    .HasComment("Vendor URL.")
                    .HasMaxLength(1024);

                b.HasKey("BusinessEntityId")
                    .HasName("PK_Vendor_BusinessEntityID");

                b.HasIndex("AccountNumber")
                    .IsUnique()
                    .HasName("AK_Vendor_AccountNumber");

                b.ToTable("Vendor", "Purchasing");

                b.HasComment("Companies from whom Adventure Works Cycles purchases parts or other goods.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.WorkOrder", b =>
            {
                b.Property<int>("WorkOrderId")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("WorkOrderID")
                    .HasColumnType("int")
                    .HasComment("Primary key for WorkOrder records.")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("DueDate")
                    .HasColumnType("datetime")
                    .HasComment("Work order due date.");

                b.Property<DateTime?>("EndDate")
                    .HasColumnType("datetime")
                    .HasComment("Work order end date.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<int>("OrderQty")
                    .HasColumnType("int")
                    .HasComment("Product quantity to build.");

                b.Property<int>("ProductId")
                    .HasColumnName("ProductID")
                    .HasColumnType("int")
                    .HasComment("Product identification number. Foreign key to Product.ProductID.");

                b.Property<short?>("ScrapReasonId")
                    .HasColumnName("ScrapReasonID")
                    .HasColumnType("smallint")
                    .HasComment("Reason for inspection failure.");

                b.Property<short>("ScrappedQty")
                    .HasColumnType("smallint")
                    .HasComment("Quantity that failed inspection.");

                b.Property<DateTime>("StartDate")
                    .HasColumnType("datetime")
                    .HasComment("Work order start date.");

                b.Property<int>("StockedQty")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnType("int")
                    .HasComputedColumnSql("(isnull([OrderQty]-[ScrappedQty],(0)))")
                    .HasComment("Quantity built and put in inventory.");

                b.HasKey("WorkOrderId");

                b.HasIndex("ProductId");

                b.HasIndex("ScrapReasonId");

                b.ToTable("WorkOrder", "Production");

                b.HasComment("Manufacturing work orders.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.WorkOrderRouting", b =>
            {
                b.Property<int>("WorkOrderId")
                    .HasColumnName("WorkOrderID")
                    .HasColumnType("int")
                    .HasComment("Primary key. Foreign key to WorkOrder.WorkOrderID.");

                b.Property<int>("ProductId")
                    .HasColumnName("ProductID")
                    .HasColumnType("int")
                    .HasComment("Primary key. Foreign key to Product.ProductID.");

                b.Property<short>("OperationSequence")
                    .HasColumnType("smallint")
                    .HasComment("Primary key. Indicates the manufacturing process sequence.");

                b.Property<decimal?>("ActualCost")
                    .HasColumnType("money")
                    .HasComment("Actual manufacturing cost.");

                b.Property<DateTime?>("ActualEndDate")
                    .HasColumnType("datetime")
                    .HasComment("Actual end date.");

                b.Property<decimal?>("ActualResourceHrs")
                    .HasColumnType("decimal(9, 4)")
                    .HasComment("Number of manufacturing hours used.");

                b.Property<DateTime?>("ActualStartDate")
                    .HasColumnType("datetime")
                    .HasComment("Actual start date.");

                b.Property<short>("LocationId")
                    .HasColumnName("LocationID")
                    .HasColumnType("smallint")
                    .HasComment("Manufacturing location where the part is processed. Foreign key to Location.LocationID.");

                b.Property<DateTime>("ModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                b.Property<decimal>("PlannedCost")
                    .HasColumnType("money")
                    .HasComment("Estimated manufacturing cost.");

                b.Property<DateTime>("ScheduledEndDate")
                    .HasColumnType("datetime")
                    .HasComment("Planned manufacturing end date.");

                b.Property<DateTime>("ScheduledStartDate")
                    .HasColumnType("datetime")
                    .HasComment("Planned manufacturing start date.");

                b.HasKey("WorkOrderId", "ProductId", "OperationSequence")
                    .HasName("PK_WorkOrderRouting_WorkOrderID_ProductID_OperationSequence");

                b.HasIndex("LocationId");

                b.HasIndex("ProductId");

                b.ToTable("WorkOrderRouting", "Production");

                b.HasComment("Work order details.");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Address", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.StateProvince", "StateProvince")
                    .WithMany("Address")
                    .HasForeignKey("StateProvinceId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.BillOfMaterials", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Product", "Component")
                    .WithMany("BillOfMaterialsComponent")
                    .HasForeignKey("ComponentId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.Product", "ProductAssembly")
                    .WithMany("BillOfMaterialsProductAssembly")
                    .HasForeignKey("ProductAssemblyId");

                b.HasOne("Demo.Data.Multiprovider.Dom.UnitMeasure", "UnitMeasureCodeNavigation")
                    .WithMany("BillOfMaterials")
                    .HasForeignKey("UnitMeasureCode")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.BusinessEntityAddress", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Address", "Address")
                    .WithMany("BusinessEntityAddress")
                    .HasForeignKey("AddressId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.AddressType", "AddressType")
                    .WithMany("BusinessEntityAddress")
                    .HasForeignKey("AddressTypeId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.BusinessEntity", "BusinessEntity")
                    .WithMany("BusinessEntityAddress")
                    .HasForeignKey("BusinessEntityId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.BusinessEntityContact", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.BusinessEntity", "BusinessEntity")
                    .WithMany("BusinessEntityContact")
                    .HasForeignKey("BusinessEntityId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.ContactType", "ContactType")
                    .WithMany("BusinessEntityContact")
                    .HasForeignKey("ContactTypeId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.Person", "Person")
                    .WithMany("BusinessEntityContact")
                    .HasForeignKey("PersonId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.CountryRegionCurrency", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.CountryRegion", "CountryRegionCodeNavigation")
                    .WithMany("CountryRegionCurrency")
                    .HasForeignKey("CountryRegionCode")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.Currency", "CurrencyCodeNavigation")
                    .WithMany("CountryRegionCurrency")
                    .HasForeignKey("CurrencyCode")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.CurrencyRate", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Currency", "FromCurrencyCodeNavigation")
                    .WithMany("CurrencyRateFromCurrencyCodeNavigation")
                    .HasForeignKey("FromCurrencyCode")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.Currency", "ToCurrencyCodeNavigation")
                    .WithMany("CurrencyRateToCurrencyCodeNavigation")
                    .HasForeignKey("ToCurrencyCode")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Customer", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Person", "Person")
                    .WithMany("Customer")
                    .HasForeignKey("PersonId");

                b.HasOne("Demo.Data.Multiprovider.Dom.Store", "Store")
                    .WithMany("Customer")
                    .HasForeignKey("StoreId");

                b.HasOne("Demo.Data.Multiprovider.Dom.SalesTerritory", "Territory")
                    .WithMany("Customer")
                    .HasForeignKey("TerritoryId");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.EmailAddress", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Person", "BusinessEntity")
                    .WithMany("EmailAddress")
                    .HasForeignKey("BusinessEntityId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Employee", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Person", "BusinessEntity")
                    .WithOne("Employee")
                    .HasForeignKey("Demo.Data.Multiprovider.Dom.Employee", "BusinessEntityId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.EmployeeDepartmentHistory", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Employee", "BusinessEntity")
                    .WithMany("EmployeeDepartmentHistory")
                    .HasForeignKey("BusinessEntityId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.Department", "Department")
                    .WithMany("EmployeeDepartmentHistory")
                    .HasForeignKey("DepartmentId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.Shift", "Shift")
                    .WithMany("EmployeeDepartmentHistory")
                    .HasForeignKey("ShiftId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.EmployeePayHistory", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Employee", "BusinessEntity")
                    .WithMany("EmployeePayHistory")
                    .HasForeignKey("BusinessEntityId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.JobCandidate", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Employee", "BusinessEntity")
                    .WithMany("JobCandidate")
                    .HasForeignKey("BusinessEntityId");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Password", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Person", "BusinessEntity")
                    .WithOne("Password")
                    .HasForeignKey("Demo.Data.Multiprovider.Dom.Password", "BusinessEntityId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Person", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.BusinessEntity", "BusinessEntity")
                    .WithOne("Person")
                    .HasForeignKey("Demo.Data.Multiprovider.Dom.Person", "BusinessEntityId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.PersonCreditCard", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Person", "BusinessEntity")
                    .WithMany("PersonCreditCard")
                    .HasForeignKey("BusinessEntityId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.CreditCard", "CreditCard")
                    .WithMany("PersonCreditCard")
                    .HasForeignKey("CreditCardId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.PersonPhone", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Person", "BusinessEntity")
                    .WithMany("PersonPhone")
                    .HasForeignKey("BusinessEntityId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.PhoneNumberType", "PhoneNumberType")
                    .WithMany("PersonPhone")
                    .HasForeignKey("PhoneNumberTypeId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Product", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.ProductModel", "ProductModel")
                    .WithMany("Product")
                    .HasForeignKey("ProductModelId");

                b.HasOne("Demo.Data.Multiprovider.Dom.ProductSubcategory", "ProductSubcategory")
                    .WithMany("Product")
                    .HasForeignKey("ProductSubcategoryId");

                b.HasOne("Demo.Data.Multiprovider.Dom.UnitMeasure", "SizeUnitMeasureCodeNavigation")
                    .WithMany("ProductSizeUnitMeasureCodeNavigation")
                    .HasForeignKey("SizeUnitMeasureCode");

                b.HasOne("Demo.Data.Multiprovider.Dom.UnitMeasure", "WeightUnitMeasureCodeNavigation")
                    .WithMany("ProductWeightUnitMeasureCodeNavigation")
                    .HasForeignKey("WeightUnitMeasureCode");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductCostHistory", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Product", "Product")
                    .WithMany("ProductCostHistory")
                    .HasForeignKey("ProductId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductInventory", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Location", "Location")
                    .WithMany("ProductInventory")
                    .HasForeignKey("LocationId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.Product", "Product")
                    .WithMany("ProductInventory")
                    .HasForeignKey("ProductId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductListPriceHistory", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Product", "Product")
                    .WithMany("ProductListPriceHistory")
                    .HasForeignKey("ProductId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductModelIllustration", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Illustration", "Illustration")
                    .WithMany("ProductModelIllustration")
                    .HasForeignKey("IllustrationId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.ProductModel", "ProductModel")
                    .WithMany("ProductModelIllustration")
                    .HasForeignKey("ProductModelId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductModelProductDescriptionCulture", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Culture", "Culture")
                    .WithMany("ProductModelProductDescriptionCulture")
                    .HasForeignKey("CultureId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.ProductDescription", "ProductDescription")
                    .WithMany("ProductModelProductDescriptionCulture")
                    .HasForeignKey("ProductDescriptionId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.ProductModel", "ProductModel")
                    .WithMany("ProductModelProductDescriptionCulture")
                    .HasForeignKey("ProductModelId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductProductPhoto", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Product", "Product")
                    .WithMany("ProductProductPhoto")
                    .HasForeignKey("ProductId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.ProductPhoto", "ProductPhoto")
                    .WithMany("ProductProductPhoto")
                    .HasForeignKey("ProductPhotoId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductReview", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Product", "Product")
                    .WithMany("ProductReview")
                    .HasForeignKey("ProductId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductSubcategory", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.ProductCategory", "ProductCategory")
                    .WithMany("ProductSubcategory")
                    .HasForeignKey("ProductCategoryId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ProductVendor", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Vendor", "BusinessEntity")
                    .WithMany("ProductVendor")
                    .HasForeignKey("BusinessEntityId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.Product", "Product")
                    .WithMany("ProductVendor")
                    .HasForeignKey("ProductId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.UnitMeasure", "UnitMeasureCodeNavigation")
                    .WithMany("ProductVendor")
                    .HasForeignKey("UnitMeasureCode")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.PurchaseOrderDetail", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Product", "Product")
                    .WithMany("PurchaseOrderDetail")
                    .HasForeignKey("ProductId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.PurchaseOrderHeader", "PurchaseOrder")
                    .WithMany("PurchaseOrderDetail")
                    .HasForeignKey("PurchaseOrderId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.PurchaseOrderHeader", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Employee", "Employee")
                    .WithMany("PurchaseOrderHeader")
                    .HasForeignKey("EmployeeId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.ShipMethod", "ShipMethod")
                    .WithMany("PurchaseOrderHeader")
                    .HasForeignKey("ShipMethodId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.Vendor", "Vendor")
                    .WithMany("PurchaseOrderHeader")
                    .HasForeignKey("VendorId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.SalesOrderDetail", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.SalesOrderHeader", "SalesOrder")
                    .WithMany("SalesOrderDetail")
                    .HasForeignKey("SalesOrderId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.SpecialOfferProduct", "SpecialOfferProduct")
                    .WithMany("SalesOrderDetail")
                    .HasForeignKey("SpecialOfferId", "ProductId")
                    .HasConstraintName("FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.SalesOrderHeader", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Address", "BillToAddress")
                    .WithMany("SalesOrderHeaderBillToAddress")
                    .HasForeignKey("BillToAddressId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.CreditCard", "CreditCard")
                    .WithMany("SalesOrderHeader")
                    .HasForeignKey("CreditCardId");

                b.HasOne("Demo.Data.Multiprovider.Dom.CurrencyRate", "CurrencyRate")
                    .WithMany("SalesOrderHeader")
                    .HasForeignKey("CurrencyRateId");

                b.HasOne("Demo.Data.Multiprovider.Dom.Customer", "Customer")
                    .WithMany("SalesOrderHeader")
                    .HasForeignKey("CustomerId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.SalesPerson", "SalesPerson")
                    .WithMany("SalesOrderHeader")
                    .HasForeignKey("SalesPersonId");

                b.HasOne("Demo.Data.Multiprovider.Dom.ShipMethod", "ShipMethod")
                    .WithMany("SalesOrderHeader")
                    .HasForeignKey("ShipMethodId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.Address", "ShipToAddress")
                    .WithMany("SalesOrderHeaderShipToAddress")
                    .HasForeignKey("ShipToAddressId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.SalesTerritory", "Territory")
                    .WithMany("SalesOrderHeader")
                    .HasForeignKey("TerritoryId");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.SalesOrderHeaderSalesReason", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.SalesOrderHeader", "SalesOrder")
                    .WithMany("SalesOrderHeaderSalesReason")
                    .HasForeignKey("SalesOrderId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.SalesReason", "SalesReason")
                    .WithMany("SalesOrderHeaderSalesReason")
                    .HasForeignKey("SalesReasonId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.SalesPerson", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Employee", "BusinessEntity")
                    .WithOne("SalesPerson")
                    .HasForeignKey("Demo.Data.Multiprovider.Dom.SalesPerson", "BusinessEntityId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.SalesTerritory", "Territory")
                    .WithMany("SalesPerson")
                    .HasForeignKey("TerritoryId");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.SalesPersonQuotaHistory", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.SalesPerson", "BusinessEntity")
                    .WithMany("SalesPersonQuotaHistory")
                    .HasForeignKey("BusinessEntityId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.SalesTaxRate", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.StateProvince", "StateProvince")
                    .WithMany("SalesTaxRate")
                    .HasForeignKey("StateProvinceId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.SalesTerritory", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.CountryRegion", "CountryRegionCodeNavigation")
                    .WithMany("SalesTerritory")
                    .HasForeignKey("CountryRegionCode")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.SalesTerritoryHistory", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.SalesPerson", "BusinessEntity")
                    .WithMany("SalesTerritoryHistory")
                    .HasForeignKey("BusinessEntityId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.SalesTerritory", "Territory")
                    .WithMany("SalesTerritoryHistory")
                    .HasForeignKey("TerritoryId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.ShoppingCartItem", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Product", "Product")
                    .WithMany("ShoppingCartItem")
                    .HasForeignKey("ProductId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.SpecialOfferProduct", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Product", "Product")
                    .WithMany("SpecialOfferProduct")
                    .HasForeignKey("ProductId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.SpecialOffer", "SpecialOffer")
                    .WithMany("SpecialOfferProduct")
                    .HasForeignKey("SpecialOfferId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.StateProvince", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.CountryRegion", "CountryRegionCodeNavigation")
                    .WithMany("StateProvince")
                    .HasForeignKey("CountryRegionCode")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.SalesTerritory", "Territory")
                    .WithMany("StateProvince")
                    .HasForeignKey("TerritoryId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Store", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.BusinessEntity", "BusinessEntity")
                    .WithOne("Store")
                    .HasForeignKey("Demo.Data.Multiprovider.Dom.Store", "BusinessEntityId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.SalesPerson", "SalesPerson")
                    .WithMany("Store")
                    .HasForeignKey("SalesPersonId");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.TransactionHistory", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Product", "Product")
                    .WithMany("TransactionHistory")
                    .HasForeignKey("ProductId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.Vendor", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.BusinessEntity", "BusinessEntity")
                    .WithOne("Vendor")
                    .HasForeignKey("Demo.Data.Multiprovider.Dom.Vendor", "BusinessEntityId")
                    .IsRequired();
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.WorkOrder", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Product", "Product")
                    .WithMany("WorkOrder")
                    .HasForeignKey("ProductId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.ScrapReason", "ScrapReason")
                    .WithMany("WorkOrder")
                    .HasForeignKey("ScrapReasonId");
            });

            modelBuilder.Entity("Demo.Data.Multiprovider.Dom.WorkOrderRouting", b =>
            {
                b.HasOne("Demo.Data.Multiprovider.Dom.Location", "Location")
                    .WithMany("WorkOrderRouting")
                    .HasForeignKey("LocationId")
                    .IsRequired();

                b.HasOne("Demo.Data.Multiprovider.Dom.WorkOrder", "WorkOrder")
                    .WithMany("WorkOrderRouting")
                    .HasForeignKey("WorkOrderId")
                    .IsRequired();
            });
#pragma warning restore 612, 618
        }
    }
}