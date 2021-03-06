﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RaghavFirstAngular
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RaghavNopCommerceEntities : DbContext
    {
        public RaghavNopCommerceEntities()
            : base("name=RaghavNopCommerceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AclRecord> AclRecords { get; set; }
        public virtual DbSet<ActivityLog> ActivityLogs { get; set; }
        public virtual DbSet<ActivityLogType> ActivityLogTypes { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AddressAttribute> AddressAttributes { get; set; }
        public virtual DbSet<AddressAttributeValue> AddressAttributeValues { get; set; }
        public virtual DbSet<Affiliate> Affiliates { get; set; }
        public virtual DbSet<BackInStockSubscription> BackInStockSubscriptions { get; set; }
        public virtual DbSet<BlogComment> BlogComments { get; set; }
        public virtual DbSet<BlogPost> BlogPosts { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryTemplate> CategoryTemplates { get; set; }
        public virtual DbSet<CheckoutAttribute> CheckoutAttributes { get; set; }
        public virtual DbSet<CheckoutAttributeValue> CheckoutAttributeValues { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CrossSellProduct> CrossSellProducts { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAttribute> CustomerAttributes { get; set; }
        public virtual DbSet<CustomerAttributeValue> CustomerAttributeValues { get; set; }
        public virtual DbSet<CustomerPassword> CustomerPasswords { get; set; }
        public virtual DbSet<CustomerRole> CustomerRoles { get; set; }
        public virtual DbSet<DeliveryDate> DeliveryDates { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<DiscountRequirement> DiscountRequirements { get; set; }
        public virtual DbSet<DiscountUsageHistory> DiscountUsageHistories { get; set; }
        public virtual DbSet<Download> Downloads { get; set; }
        public virtual DbSet<EmailAccount> EmailAccounts { get; set; }
        public virtual DbSet<ExternalAuthenticationRecord> ExternalAuthenticationRecords { get; set; }
        public virtual DbSet<Forums_Forum> Forums_Forum { get; set; }
        public virtual DbSet<Forums_Group> Forums_Group { get; set; }
        public virtual DbSet<Forums_Post> Forums_Post { get; set; }
        public virtual DbSet<Forums_PostVote> Forums_PostVote { get; set; }
        public virtual DbSet<Forums_PrivateMessage> Forums_PrivateMessage { get; set; }
        public virtual DbSet<Forums_Subscription> Forums_Subscription { get; set; }
        public virtual DbSet<Forums_Topic> Forums_Topic { get; set; }
        public virtual DbSet<GenericAttribute> GenericAttributes { get; set; }
        public virtual DbSet<GiftCard> GiftCards { get; set; }
        public virtual DbSet<GiftCardUsageHistory> GiftCardUsageHistories { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<LocaleStringResource> LocaleStringResources { get; set; }
        public virtual DbSet<LocalizedProperty> LocalizedProperties { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<ManufacturerTemplate> ManufacturerTemplates { get; set; }
        public virtual DbSet<MeasureDimension> MeasureDimensions { get; set; }
        public virtual DbSet<MeasureWeight> MeasureWeights { get; set; }
        public virtual DbSet<MessageTemplate> MessageTemplates { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsComment> NewsComments { get; set; }
        public virtual DbSet<NewsLetterSubscription> NewsLetterSubscriptions { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<OrderNote> OrderNotes { get; set; }
        public virtual DbSet<PermissionRecord> PermissionRecords { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Poll> Polls { get; set; }
        public virtual DbSet<PollAnswer> PollAnswers { get; set; }
        public virtual DbSet<PollVotingRecord> PollVotingRecords { get; set; }
        public virtual DbSet<PredefinedProductAttributeValue> PredefinedProductAttributeValues { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product_Category_Mapping> Product_Category_Mapping { get; set; }
        public virtual DbSet<Product_Manufacturer_Mapping> Product_Manufacturer_Mapping { get; set; }
        public virtual DbSet<Product_Picture_Mapping> Product_Picture_Mapping { get; set; }
        public virtual DbSet<Product_ProductAttribute_Mapping> Product_ProductAttribute_Mapping { get; set; }
        public virtual DbSet<Product_SpecificationAttribute_Mapping> Product_SpecificationAttribute_Mapping { get; set; }
        public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }
        public virtual DbSet<ProductAttributeCombination> ProductAttributeCombinations { get; set; }
        public virtual DbSet<ProductAttributeValue> ProductAttributeValues { get; set; }
        public virtual DbSet<ProductAvailabilityRange> ProductAvailabilityRanges { get; set; }
        public virtual DbSet<ProductReview> ProductReviews { get; set; }
        public virtual DbSet<ProductReviewHelpfulness> ProductReviewHelpfulnesses { get; set; }
        public virtual DbSet<ProductTag> ProductTags { get; set; }
        public virtual DbSet<ProductTemplate> ProductTemplates { get; set; }
        public virtual DbSet<ProductWarehouseInventory> ProductWarehouseInventories { get; set; }
        public virtual DbSet<QueuedEmail> QueuedEmails { get; set; }
        public virtual DbSet<RecurringPayment> RecurringPayments { get; set; }
        public virtual DbSet<RecurringPaymentHistory> RecurringPaymentHistories { get; set; }
        public virtual DbSet<RelatedProduct> RelatedProducts { get; set; }
        public virtual DbSet<ReturnRequest> ReturnRequests { get; set; }
        public virtual DbSet<ReturnRequestAction> ReturnRequestActions { get; set; }
        public virtual DbSet<ReturnRequestReason> ReturnRequestReasons { get; set; }
        public virtual DbSet<RewardPointsHistory> RewardPointsHistories { get; set; }
        public virtual DbSet<ScheduleTask> ScheduleTasks { get; set; }
        public virtual DbSet<SearchTerm> SearchTerms { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }
        public virtual DbSet<ShipmentItem> ShipmentItems { get; set; }
        public virtual DbSet<ShippingMethod> ShippingMethods { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public virtual DbSet<SpecificationAttribute> SpecificationAttributes { get; set; }
        public virtual DbSet<SpecificationAttributeOption> SpecificationAttributeOptions { get; set; }
        public virtual DbSet<StateProvince> StateProvinces { get; set; }
        public virtual DbSet<StockQuantityHistory> StockQuantityHistories { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<StoreMapping> StoreMappings { get; set; }
        public virtual DbSet<TaxCategory> TaxCategories { get; set; }
        public virtual DbSet<TierPrice> TierPrices { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<TopicTemplate> TopicTemplates { get; set; }
        public virtual DbSet<UrlRecord> UrlRecords { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<VendorNote> VendorNotes { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
    
        [DbFunction("RaghavNopCommerceEntities", "nop_splitstring_to_table")]
        public virtual IQueryable<nop_splitstring_to_table_Result> nop_splitstring_to_table(string @string, string delimiter)
        {
            var stringParameter = @string != null ?
                new ObjectParameter("string", @string) :
                new ObjectParameter("string", typeof(string));
    
            var delimiterParameter = delimiter != null ?
                new ObjectParameter("delimiter", delimiter) :
                new ObjectParameter("delimiter", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<nop_splitstring_to_table_Result>("[RaghavNopCommerceEntities].[nop_splitstring_to_table](@string, @delimiter)", stringParameter, delimiterParameter);
        }
    
        public virtual int CategoryLoadAllPaged(Nullable<bool> showHidden, string name, Nullable<int> storeId, string customerRoleIds, Nullable<int> pageIndex, Nullable<int> pageSize, ObjectParameter totalRecords)
        {
            var showHiddenParameter = showHidden.HasValue ?
                new ObjectParameter("ShowHidden", showHidden) :
                new ObjectParameter("ShowHidden", typeof(bool));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var storeIdParameter = storeId.HasValue ?
                new ObjectParameter("StoreId", storeId) :
                new ObjectParameter("StoreId", typeof(int));
    
            var customerRoleIdsParameter = customerRoleIds != null ?
                new ObjectParameter("CustomerRoleIds", customerRoleIds) :
                new ObjectParameter("CustomerRoleIds", typeof(string));
    
            var pageIndexParameter = pageIndex.HasValue ?
                new ObjectParameter("PageIndex", pageIndex) :
                new ObjectParameter("PageIndex", typeof(int));
    
            var pageSizeParameter = pageSize.HasValue ?
                new ObjectParameter("PageSize", pageSize) :
                new ObjectParameter("PageSize", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CategoryLoadAllPaged", showHiddenParameter, nameParameter, storeIdParameter, customerRoleIdsParameter, pageIndexParameter, pageSizeParameter, totalRecords);
        }
    
        public virtual int DeleteGuests(Nullable<bool> onlyWithoutShoppingCart, Nullable<System.DateTime> createdFromUtc, Nullable<System.DateTime> createdToUtc, ObjectParameter totalRecordsDeleted)
        {
            var onlyWithoutShoppingCartParameter = onlyWithoutShoppingCart.HasValue ?
                new ObjectParameter("OnlyWithoutShoppingCart", onlyWithoutShoppingCart) :
                new ObjectParameter("OnlyWithoutShoppingCart", typeof(bool));
    
            var createdFromUtcParameter = createdFromUtc.HasValue ?
                new ObjectParameter("CreatedFromUtc", createdFromUtc) :
                new ObjectParameter("CreatedFromUtc", typeof(System.DateTime));
    
            var createdToUtcParameter = createdToUtc.HasValue ?
                new ObjectParameter("CreatedToUtc", createdToUtc) :
                new ObjectParameter("CreatedToUtc", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteGuests", onlyWithoutShoppingCartParameter, createdFromUtcParameter, createdToUtcParameter, totalRecordsDeleted);
        }
    
        public virtual int FullText_Disable()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("FullText_Disable");
        }
    
        public virtual int FullText_Enable()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("FullText_Enable");
        }
    
        public virtual ObjectResult<Nullable<int>> FullText_IsSupported()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("FullText_IsSupported");
        }
    
        public virtual int LanguagePackImport(Nullable<int> languageId, string xmlPackage, Nullable<bool> updateExistingResources)
        {
            var languageIdParameter = languageId.HasValue ?
                new ObjectParameter("LanguageId", languageId) :
                new ObjectParameter("LanguageId", typeof(int));
    
            var xmlPackageParameter = xmlPackage != null ?
                new ObjectParameter("XmlPackage", xmlPackage) :
                new ObjectParameter("XmlPackage", typeof(string));
    
            var updateExistingResourcesParameter = updateExistingResources.HasValue ?
                new ObjectParameter("UpdateExistingResources", updateExistingResources) :
                new ObjectParameter("UpdateExistingResources", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("LanguagePackImport", languageIdParameter, xmlPackageParameter, updateExistingResourcesParameter);
        }
    
        public virtual int ProductLoadAllPaged(string categoryIds, Nullable<int> manufacturerId, Nullable<int> storeId, Nullable<int> vendorId, Nullable<int> warehouseId, Nullable<int> productTypeId, Nullable<bool> visibleIndividuallyOnly, Nullable<bool> markedAsNewOnly, Nullable<int> productTagId, Nullable<bool> featuredProducts, Nullable<decimal> priceMin, Nullable<decimal> priceMax, string keywords, Nullable<bool> searchDescriptions, Nullable<bool> searchManufacturerPartNumber, Nullable<bool> searchSku, Nullable<bool> searchProductTags, Nullable<bool> useFullTextSearch, Nullable<int> fullTextMode, string filteredSpecs, Nullable<int> languageId, Nullable<int> orderBy, string allowedCustomerRoleIds, Nullable<int> pageIndex, Nullable<int> pageSize, Nullable<bool> showHidden, Nullable<bool> overridePublished, Nullable<bool> loadFilterableSpecificationAttributeOptionIds, ObjectParameter filterableSpecificationAttributeOptionIds, ObjectParameter totalRecords)
        {
            var categoryIdsParameter = categoryIds != null ?
                new ObjectParameter("CategoryIds", categoryIds) :
                new ObjectParameter("CategoryIds", typeof(string));
    
            var manufacturerIdParameter = manufacturerId.HasValue ?
                new ObjectParameter("ManufacturerId", manufacturerId) :
                new ObjectParameter("ManufacturerId", typeof(int));
    
            var storeIdParameter = storeId.HasValue ?
                new ObjectParameter("StoreId", storeId) :
                new ObjectParameter("StoreId", typeof(int));
    
            var vendorIdParameter = vendorId.HasValue ?
                new ObjectParameter("VendorId", vendorId) :
                new ObjectParameter("VendorId", typeof(int));
    
            var warehouseIdParameter = warehouseId.HasValue ?
                new ObjectParameter("WarehouseId", warehouseId) :
                new ObjectParameter("WarehouseId", typeof(int));
    
            var productTypeIdParameter = productTypeId.HasValue ?
                new ObjectParameter("ProductTypeId", productTypeId) :
                new ObjectParameter("ProductTypeId", typeof(int));
    
            var visibleIndividuallyOnlyParameter = visibleIndividuallyOnly.HasValue ?
                new ObjectParameter("VisibleIndividuallyOnly", visibleIndividuallyOnly) :
                new ObjectParameter("VisibleIndividuallyOnly", typeof(bool));
    
            var markedAsNewOnlyParameter = markedAsNewOnly.HasValue ?
                new ObjectParameter("MarkedAsNewOnly", markedAsNewOnly) :
                new ObjectParameter("MarkedAsNewOnly", typeof(bool));
    
            var productTagIdParameter = productTagId.HasValue ?
                new ObjectParameter("ProductTagId", productTagId) :
                new ObjectParameter("ProductTagId", typeof(int));
    
            var featuredProductsParameter = featuredProducts.HasValue ?
                new ObjectParameter("FeaturedProducts", featuredProducts) :
                new ObjectParameter("FeaturedProducts", typeof(bool));
    
            var priceMinParameter = priceMin.HasValue ?
                new ObjectParameter("PriceMin", priceMin) :
                new ObjectParameter("PriceMin", typeof(decimal));
    
            var priceMaxParameter = priceMax.HasValue ?
                new ObjectParameter("PriceMax", priceMax) :
                new ObjectParameter("PriceMax", typeof(decimal));
    
            var keywordsParameter = keywords != null ?
                new ObjectParameter("Keywords", keywords) :
                new ObjectParameter("Keywords", typeof(string));
    
            var searchDescriptionsParameter = searchDescriptions.HasValue ?
                new ObjectParameter("SearchDescriptions", searchDescriptions) :
                new ObjectParameter("SearchDescriptions", typeof(bool));
    
            var searchManufacturerPartNumberParameter = searchManufacturerPartNumber.HasValue ?
                new ObjectParameter("SearchManufacturerPartNumber", searchManufacturerPartNumber) :
                new ObjectParameter("SearchManufacturerPartNumber", typeof(bool));
    
            var searchSkuParameter = searchSku.HasValue ?
                new ObjectParameter("SearchSku", searchSku) :
                new ObjectParameter("SearchSku", typeof(bool));
    
            var searchProductTagsParameter = searchProductTags.HasValue ?
                new ObjectParameter("SearchProductTags", searchProductTags) :
                new ObjectParameter("SearchProductTags", typeof(bool));
    
            var useFullTextSearchParameter = useFullTextSearch.HasValue ?
                new ObjectParameter("UseFullTextSearch", useFullTextSearch) :
                new ObjectParameter("UseFullTextSearch", typeof(bool));
    
            var fullTextModeParameter = fullTextMode.HasValue ?
                new ObjectParameter("FullTextMode", fullTextMode) :
                new ObjectParameter("FullTextMode", typeof(int));
    
            var filteredSpecsParameter = filteredSpecs != null ?
                new ObjectParameter("FilteredSpecs", filteredSpecs) :
                new ObjectParameter("FilteredSpecs", typeof(string));
    
            var languageIdParameter = languageId.HasValue ?
                new ObjectParameter("LanguageId", languageId) :
                new ObjectParameter("LanguageId", typeof(int));
    
            var orderByParameter = orderBy.HasValue ?
                new ObjectParameter("OrderBy", orderBy) :
                new ObjectParameter("OrderBy", typeof(int));
    
            var allowedCustomerRoleIdsParameter = allowedCustomerRoleIds != null ?
                new ObjectParameter("AllowedCustomerRoleIds", allowedCustomerRoleIds) :
                new ObjectParameter("AllowedCustomerRoleIds", typeof(string));
    
            var pageIndexParameter = pageIndex.HasValue ?
                new ObjectParameter("PageIndex", pageIndex) :
                new ObjectParameter("PageIndex", typeof(int));
    
            var pageSizeParameter = pageSize.HasValue ?
                new ObjectParameter("PageSize", pageSize) :
                new ObjectParameter("PageSize", typeof(int));
    
            var showHiddenParameter = showHidden.HasValue ?
                new ObjectParameter("ShowHidden", showHidden) :
                new ObjectParameter("ShowHidden", typeof(bool));
    
            var overridePublishedParameter = overridePublished.HasValue ?
                new ObjectParameter("OverridePublished", overridePublished) :
                new ObjectParameter("OverridePublished", typeof(bool));
    
            var loadFilterableSpecificationAttributeOptionIdsParameter = loadFilterableSpecificationAttributeOptionIds.HasValue ?
                new ObjectParameter("LoadFilterableSpecificationAttributeOptionIds", loadFilterableSpecificationAttributeOptionIds) :
                new ObjectParameter("LoadFilterableSpecificationAttributeOptionIds", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProductLoadAllPaged", categoryIdsParameter, manufacturerIdParameter, storeIdParameter, vendorIdParameter, warehouseIdParameter, productTypeIdParameter, visibleIndividuallyOnlyParameter, markedAsNewOnlyParameter, productTagIdParameter, featuredProductsParameter, priceMinParameter, priceMaxParameter, keywordsParameter, searchDescriptionsParameter, searchManufacturerPartNumberParameter, searchSkuParameter, searchProductTagsParameter, useFullTextSearchParameter, fullTextModeParameter, filteredSpecsParameter, languageIdParameter, orderByParameter, allowedCustomerRoleIdsParameter, pageIndexParameter, pageSizeParameter, showHiddenParameter, overridePublishedParameter, loadFilterableSpecificationAttributeOptionIdsParameter, filterableSpecificationAttributeOptionIds, totalRecords);
        }
    
        public virtual ObjectResult<ProductTagCountLoadAll_Result> ProductTagCountLoadAll(Nullable<int> storeId)
        {
            var storeIdParameter = storeId.HasValue ?
                new ObjectParameter("StoreId", storeId) :
                new ObjectParameter("StoreId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProductTagCountLoadAll_Result>("ProductTagCountLoadAll", storeIdParameter);
        }
    }
}
