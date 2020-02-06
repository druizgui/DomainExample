﻿// -----------------------------------------------------------------
// <copyright>Copyright (C) 2020, David Ruiz.</copyright>
// Licensed under the Apache License, Version 2.0.
// You may not use this file except in compliance with the License:
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Software is distributed on an "AS IS", WITHOUT WARRANTIES
// OR CONDITIONS OF ANY KIND, either express or implied.
// -----------------------------------------------------------------

namespace AdventureWorks.Dom
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Product", Schema = "Production")]
    public partial class Product
    {
        [Key] [Column("ProductID")] public int ProductId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        [Required] [StringLength(25)] public string ProductNumber { get; set; }

        [Required] public bool? MakeFlag { get; set; }

        [Required] public bool? FinishedGoodsFlag { get; set; }

        [StringLength(15)] public string Color { get; set; }

        public short SafetyStockLevel { get; set; }
        public short ReorderPoint { get; set; }

        [Column(TypeName = "money")] public decimal StandardCost { get; set; }

        [Column(TypeName = "money")] public decimal ListPrice { get; set; }

        [StringLength(5)] public string Size { get; set; }

        [StringLength(3)] public string SizeUnitMeasureCode { get; set; }

        [StringLength(3)] public string WeightUnitMeasureCode { get; set; }

        [Column(TypeName = "decimal(8, 2)")] public decimal? Weight { get; set; }

        public int DaysToManufacture { get; set; }

        [StringLength(2)] public string ProductLine { get; set; }

        [StringLength(2)] public string Class { get; set; }

        [StringLength(2)] public string Style { get; set; }

        [Column("ProductSubcategoryID")] public int? ProductSubcategoryId { get; set; }

        [Column("ProductModelID")] public int? ProductModelId { get; set; }

        [Column(TypeName = "datetime")] public DateTime SellStartDate { get; set; }

        [Column(TypeName = "datetime")] public DateTime? SellEndDate { get; set; }

        [Column(TypeName = "datetime")] public DateTime? DiscontinuedDate { get; set; }

        [Column("rowguid")] public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(ProductModelId))]
        [InverseProperty("Product")]
        public virtual ProductModel ProductModel { get; set; }

        [ForeignKey(nameof(ProductSubcategoryId))]
        [InverseProperty("Product")]
        public virtual ProductSubcategory ProductSubcategory { get; set; }

        [ForeignKey(nameof(SizeUnitMeasureCode))]
        [InverseProperty(nameof(UnitMeasure.ProductSizeUnitMeasureCodeNavigation))]
        public virtual UnitMeasure SizeUnitMeasureCodeNavigation { get; set; }

        [ForeignKey(nameof(WeightUnitMeasureCode))]
        [InverseProperty(nameof(UnitMeasure.ProductWeightUnitMeasureCodeNavigation))]
        public virtual UnitMeasure WeightUnitMeasureCodeNavigation { get; set; }

        [InverseProperty(nameof(BillOfMaterials.Component))]
        public virtual ICollection<BillOfMaterials> BillOfMaterialsComponent { get; set; }

        [InverseProperty(nameof(BillOfMaterials.ProductAssembly))]
        public virtual ICollection<BillOfMaterials> BillOfMaterialsProductAssembly { get; set; }

        [InverseProperty("Product")] public virtual ICollection<ProductCostHistory> ProductCostHistory { get; set; }

        [InverseProperty("Product")] public virtual ICollection<ProductInventory> ProductInventory { get; set; }

        [InverseProperty("Product")] public virtual ICollection<ProductListPriceHistory> ProductListPriceHistory { get; set; }

        [InverseProperty("Product")] public virtual ICollection<ProductProductPhoto> ProductProductPhoto { get; set; }

        [InverseProperty("Product")] public virtual ICollection<ProductReview> ProductReview { get; set; }

        [InverseProperty("Product")] public virtual ICollection<ProductVendor> ProductVendor { get; set; }

        [InverseProperty("Product")] public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }

        [InverseProperty("Product")] public virtual ICollection<ShoppingCartItem> ShoppingCartItem { get; set; }

        [InverseProperty("Product")] public virtual ICollection<SpecialOfferProduct> SpecialOfferProduct { get; set; }

        [InverseProperty("Product")] public virtual ICollection<TransactionHistory> TransactionHistory { get; set; }

        [InverseProperty("Product")] public virtual ICollection<WorkOrder> WorkOrder { get; set; }

        public Product()
        {
            BillOfMaterialsComponent = new HashSet<BillOfMaterials>();
            BillOfMaterialsProductAssembly = new HashSet<BillOfMaterials>();
            ProductCostHistory = new HashSet<ProductCostHistory>();
            ProductInventory = new HashSet<ProductInventory>();
            ProductListPriceHistory = new HashSet<ProductListPriceHistory>();
            ProductProductPhoto = new HashSet<ProductProductPhoto>();
            ProductReview = new HashSet<ProductReview>();
            ProductVendor = new HashSet<ProductVendor>();
            PurchaseOrderDetail = new HashSet<PurchaseOrderDetail>();
            ShoppingCartItem = new HashSet<ShoppingCartItem>();
            SpecialOfferProduct = new HashSet<SpecialOfferProduct>();
            TransactionHistory = new HashSet<TransactionHistory>();
            WorkOrder = new HashSet<WorkOrder>();
        }
    }
}