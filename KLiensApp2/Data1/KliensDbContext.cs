using System;
using System.Collections.Generic;
using KliensApp.Models;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Data;

public partial class KliensDbContext : DbContext
{
    public KliensDbContext()
    {
    }

    public KliensDbContext(DbContextOptions<KliensDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AnonymousUsers> AnonymousUsers { get; set; }

    public virtual DbSet<AspnetApplications> AspnetApplications { get; set; }

    public virtual DbSet<AspnetMembership> AspnetMembership { get; set; }

    public virtual DbSet<AspnetSchemaVersions> AspnetSchemaVersions { get; set; }

    public virtual DbSet<AspnetUsers> AspnetUsers { get; set; }

    public virtual DbSet<Assemblies> Assemblies { get; set; }

    public virtual DbSet<AuthCookies> AuthCookies { get; set; }

    public virtual DbSet<Authentication> Authentication { get; set; }

    public virtual DbSet<CkeSettings> CkeSettings { get; set; }

    public virtual DbSet<ContentItems> ContentItems { get; set; }

    public virtual DbSet<ContentItemsMetaData> ContentItemsMetaData { get; set; }

    public virtual DbSet<ContentItemsTags> ContentItemsTags { get; set; }

    public virtual DbSet<ContentTypes> ContentTypes { get; set; }

    public virtual DbSet<ContentWorkflowActions> ContentWorkflowActions { get; set; }

    public virtual DbSet<ContentWorkflowLogs> ContentWorkflowLogs { get; set; }

    public virtual DbSet<ContentWorkflowSources> ContentWorkflowSources { get; set; }

    public virtual DbSet<ContentWorkflowStatePermission> ContentWorkflowStatePermission { get; set; }

    public virtual DbSet<ContentWorkflowStates> ContentWorkflowStates { get; set; }

    public virtual DbSet<ContentWorkflows> ContentWorkflows { get; set; }

    public virtual DbSet<CoreMessagingMessageAttachments> CoreMessagingMessageAttachments { get; set; }

    public virtual DbSet<CoreMessagingMessageRecipients> CoreMessagingMessageRecipients { get; set; }

    public virtual DbSet<CoreMessagingMessages> CoreMessagingMessages { get; set; }

    public virtual DbSet<CoreMessagingNotificationTypeActions> CoreMessagingNotificationTypeActions { get; set; }

    public virtual DbSet<CoreMessagingNotificationTypes> CoreMessagingNotificationTypes { get; set; }

    public virtual DbSet<CoreMessagingSubscriptionTypes> CoreMessagingSubscriptionTypes { get; set; }

    public virtual DbSet<CoreMessagingSubscriptions> CoreMessagingSubscriptions { get; set; }

    public virtual DbSet<CoreMessagingUserPreferences> CoreMessagingUserPreferences { get; set; }

    public virtual DbSet<DesktopModulePermission> DesktopModulePermission { get; set; }

    public virtual DbSet<DesktopModules> DesktopModules { get; set; }

    public virtual DbSet<DnnbcehelloWorldItems> DnnbcehelloWorldItems { get; set; }

    public virtual DbSet<EventLog> EventLog { get; set; }

    public virtual DbSet<EventLogConfig> EventLogConfig { get; set; }

    public virtual DbSet<EventLogTypes> EventLogTypes { get; set; }

    public virtual DbSet<EventQueue> EventQueue { get; set; }

    public virtual DbSet<ExceptionEvents> ExceptionEvents { get; set; }

    public virtual DbSet<Exceptions> Exceptions { get; set; }

    public virtual DbSet<ExportImportCheckpoints> ExportImportCheckpoints { get; set; }

    public virtual DbSet<ExportImportJobLogs> ExportImportJobLogs { get; set; }

    public virtual DbSet<ExportImportJobs> ExportImportJobs { get; set; }

    public virtual DbSet<ExportImportSettings> ExportImportSettings { get; set; }

    public virtual DbSet<ExtensionUrlProviderConfiguration> ExtensionUrlProviderConfiguration { get; set; }

    public virtual DbSet<ExtensionUrlProviderSetting> ExtensionUrlProviderSetting { get; set; }

    public virtual DbSet<ExtensionUrlProviderTab> ExtensionUrlProviderTab { get; set; }

    public virtual DbSet<ExtensionUrlProviders> ExtensionUrlProviders { get; set; }

    public virtual DbSet<FileVersions> FileVersions { get; set; }

    public virtual DbSet<Files> Files { get; set; }

    public virtual DbSet<FolderMappings> FolderMappings { get; set; }

    public virtual DbSet<FolderMappingsSettings> FolderMappingsSettings { get; set; }

    public virtual DbSet<FolderPermission> FolderPermission { get; set; }

    public virtual DbSet<Folders> Folders { get; set; }

    public virtual DbSet<HccAddress> HccAddress { get; set; }

    public virtual DbSet<HccAffiliate> HccAffiliate { get; set; }

    public virtual DbSet<HccAffiliatePayments> HccAffiliatePayments { get; set; }

    public virtual DbSet<HccAffiliateReferral> HccAffiliateReferral { get; set; }

    public virtual DbSet<HccAnalyticsEvents> HccAnalyticsEvents { get; set; }

    public virtual DbSet<HccApiKeys> HccApiKeys { get; set; }

    public virtual DbSet<HccAudit> HccAudit { get; set; }

    public virtual DbSet<HccAuthTokens> HccAuthTokens { get; set; }

    public virtual DbSet<HccBundledProducts> HccBundledProducts { get; set; }

    public virtual DbSet<HccCatalogRoles> HccCatalogRoles { get; set; }

    public virtual DbSet<HccCategory> HccCategory { get; set; }

    public virtual DbSet<HccCategoryTranslations> HccCategoryTranslations { get; set; }

    public virtual DbSet<HccCategoryXproperty> HccCategoryXproperty { get; set; }

    public virtual DbSet<HccContentBlock> HccContentBlock { get; set; }

    public virtual DbSet<HccContentBlockTranslations> HccContentBlockTranslations { get; set; }

    public virtual DbSet<HccContentColumn> HccContentColumn { get; set; }

    public virtual DbSet<HccCountries> HccCountries { get; set; }

    public virtual DbSet<HccCountryTranslations> HccCountryTranslations { get; set; }

    public virtual DbSet<HccCustomUrl> HccCustomUrl { get; set; }

    public virtual DbSet<HccFraud> HccFraud { get; set; }

    public virtual DbSet<HccGiftCard> HccGiftCard { get; set; }

    public virtual DbSet<HccHtmlTemplateTranslations> HccHtmlTemplateTranslations { get; set; }

    public virtual DbSet<HccHtmlTemplates> HccHtmlTemplates { get; set; }

    public virtual DbSet<HccLineItem> HccLineItem { get; set; }

    public virtual DbSet<HccMailingList> HccMailingList { get; set; }

    public virtual DbSet<HccMailingListMember> HccMailingListMember { get; set; }

    public virtual DbSet<HccManufacturer> HccManufacturer { get; set; }

    public virtual DbSet<HccMembershipProductType> HccMembershipProductType { get; set; }

    public virtual DbSet<HccNews> HccNews { get; set; }

    public virtual DbSet<HccOrder> HccOrder { get; set; }

    public virtual DbSet<HccOrderCoupon> HccOrderCoupon { get; set; }

    public virtual DbSet<HccOrderNote> HccOrderNote { get; set; }

    public virtual DbSet<HccOrderPackage> HccOrderPackage { get; set; }

    public virtual DbSet<HccOrderTransactions> HccOrderTransactions { get; set; }

    public virtual DbSet<HccPriceGroup> HccPriceGroup { get; set; }

    public virtual DbSet<HccProduct> HccProduct { get; set; }

    public virtual DbSet<HccProductFile> HccProductFile { get; set; }

    public virtual DbSet<HccProductFileXproduct> HccProductFileXproduct { get; set; }

    public virtual DbSet<HccProductImage> HccProductImage { get; set; }

    public virtual DbSet<HccProductInventory> HccProductInventory { get; set; }

    public virtual DbSet<HccProductOptionItemTranslations> HccProductOptionItemTranslations { get; set; }

    public virtual DbSet<HccProductOptionTranslations> HccProductOptionTranslations { get; set; }

    public virtual DbSet<HccProductOptions> HccProductOptions { get; set; }

    public virtual DbSet<HccProductOptionsItems> HccProductOptionsItems { get; set; }

    public virtual DbSet<HccProductProperty> HccProductProperty { get; set; }

    public virtual DbSet<HccProductPropertyChoice> HccProductPropertyChoice { get; set; }

    public virtual DbSet<HccProductPropertyChoiceTranslations> HccProductPropertyChoiceTranslations { get; set; }

    public virtual DbSet<HccProductPropertyTranslations> HccProductPropertyTranslations { get; set; }

    public virtual DbSet<HccProductPropertyValue> HccProductPropertyValue { get; set; }

    public virtual DbSet<HccProductPropertyValueTranslations> HccProductPropertyValueTranslations { get; set; }

    public virtual DbSet<HccProductRelationships> HccProductRelationships { get; set; }

    public virtual DbSet<HccProductReview> HccProductReview { get; set; }

    public virtual DbSet<HccProductTranslations> HccProductTranslations { get; set; }

    public virtual DbSet<HccProductType> HccProductType { get; set; }

    public virtual DbSet<HccProductTypeTranslations> HccProductTypeTranslations { get; set; }

    public virtual DbSet<HccProductTypeXproductProperty> HccProductTypeXproductProperty { get; set; }

    public virtual DbSet<HccProductVolumeDiscounts> HccProductVolumeDiscounts { get; set; }

    public virtual DbSet<HccProductXcategory> HccProductXcategory { get; set; }

    public virtual DbSet<HccProductXoption> HccProductXoption { get; set; }

    public virtual DbSet<HccPromotionTranslations> HccPromotionTranslations { get; set; }

    public virtual DbSet<HccPromotions> HccPromotions { get; set; }

    public virtual DbSet<HccQueuedTasks> HccQueuedTasks { get; set; }

    public virtual DbSet<HccRegionTranslations> HccRegionTranslations { get; set; }

    public virtual DbSet<HccRegions> HccRegions { get; set; }

    public virtual DbSet<HccRewardsPoints> HccRewardsPoints { get; set; }

    public virtual DbSet<HccRma> HccRma { get; set; }

    public virtual DbSet<HccRmaitem> HccRmaitem { get; set; }

    public virtual DbSet<HccSearchLexicon> HccSearchLexicon { get; set; }

    public virtual DbSet<HccSearchObjectWords> HccSearchObjectWords { get; set; }

    public virtual DbSet<HccSearchObjects> HccSearchObjects { get; set; }

    public virtual DbSet<HccSearchQuery> HccSearchQuery { get; set; }

    public virtual DbSet<HccShippingMethod> HccShippingMethod { get; set; }

    public virtual DbSet<HccShippingMethodTranslations> HccShippingMethodTranslations { get; set; }

    public virtual DbSet<HccShippingZones> HccShippingZones { get; set; }

    public virtual DbSet<HccStoreDomains> HccStoreDomains { get; set; }

    public virtual DbSet<HccStoreSettings> HccStoreSettings { get; set; }

    public virtual DbSet<HccStoreSettingsTranslations> HccStoreSettingsTranslations { get; set; }

    public virtual DbSet<HccStores> HccStores { get; set; }

    public virtual DbSet<HccStoresXusers> HccStoresXusers { get; set; }

    public virtual DbSet<HccTaxSchedules> HccTaxSchedules { get; set; }

    public virtual DbSet<HccTaxes> HccTaxes { get; set; }

    public virtual DbSet<HccUser> HccUser { get; set; }

    public virtual DbSet<HccUserAccounts> HccUserAccounts { get; set; }

    public virtual DbSet<HccUserQuestions> HccUserQuestions { get; set; }

    public virtual DbSet<HccUserXcontact> HccUserXcontact { get; set; }

    public virtual DbSet<HccUsgeoData> HccUsgeoData { get; set; }

    public virtual DbSet<HccVariants> HccVariants { get; set; }

    public virtual DbSet<HccVendor> HccVendor { get; set; }

    public virtual DbSet<HccWishListItems> HccWishListItems { get; set; }

    public virtual DbSet<HostSettings> HostSettings { get; set; }

    public virtual DbSet<HtmlText> HtmlText { get; set; }

    public virtual DbSet<HtmlTextLog> HtmlTextLog { get; set; }

    public virtual DbSet<HtmlTextUsers> HtmlTextUsers { get; set; }

    public virtual DbSet<Ipfilter> Ipfilter { get; set; }

    public virtual DbSet<JavaScriptLibraries> JavaScriptLibraries { get; set; }

    public virtual DbSet<Journal> Journal { get; set; }

    public virtual DbSet<JournalAccess> JournalAccess { get; set; }

    public virtual DbSet<JournalComments> JournalComments { get; set; }

    public virtual DbSet<JournalData> JournalData { get; set; }

    public virtual DbSet<JournalSecurity> JournalSecurity { get; set; }

    public virtual DbSet<JournalTypeFilters> JournalTypeFilters { get; set; }

    public virtual DbSet<JournalTypes> JournalTypes { get; set; }

    public virtual DbSet<LanguagePacks> LanguagePacks { get; set; }

    public virtual DbSet<Languages> Languages { get; set; }

    public virtual DbSet<Lists> Lists { get; set; }

    public virtual DbSet<MessagingMessages> MessagingMessages { get; set; }

    public virtual DbSet<MetaData> MetaData { get; set; }

    public virtual DbSet<MobilePreviewProfiles> MobilePreviewProfiles { get; set; }

    public virtual DbSet<MobileRedirectionRules> MobileRedirectionRules { get; set; }

    public virtual DbSet<MobileRedirections> MobileRedirections { get; set; }

    public virtual DbSet<ModuleControls> ModuleControls { get; set; }

    public virtual DbSet<ModuleDefinitions> ModuleDefinitions { get; set; }

    public virtual DbSet<ModulePermission> ModulePermission { get; set; }

    public virtual DbSet<ModuleSettings> ModuleSettings { get; set; }

    public virtual DbSet<Modules> Modules { get; set; }

    public virtual DbSet<OrderedProducts> OrderedProducts { get; set; }

    public virtual DbSet<OutputCache> OutputCache { get; set; }

    public virtual DbSet<PackageDependencies> PackageDependencies { get; set; }

    public virtual DbSet<PackageTypes> PackageTypes { get; set; }

    public virtual DbSet<Packages> Packages { get; set; }

    public virtual DbSet<PasswordHistory> PasswordHistory { get; set; }

    public virtual DbSet<Permission> Permission { get; set; }

    public virtual DbSet<PersonaBarExtensions> PersonaBarExtensions { get; set; }

    public virtual DbSet<PersonaBarMenu> PersonaBarMenu { get; set; }

    public virtual DbSet<PersonaBarMenuDefaultPermissions> PersonaBarMenuDefaultPermissions { get; set; }

    public virtual DbSet<PersonaBarMenuPermission> PersonaBarMenuPermission { get; set; }

    public virtual DbSet<PersonaBarPermission> PersonaBarPermission { get; set; }

    public virtual DbSet<PortalAlias> PortalAlias { get; set; }

    public virtual DbSet<PortalDesktopModules> PortalDesktopModules { get; set; }

    public virtual DbSet<PortalGroups> PortalGroups { get; set; }

    public virtual DbSet<PortalLanguages> PortalLanguages { get; set; }

    public virtual DbSet<PortalLocalization> PortalLocalization { get; set; }

    public virtual DbSet<PortalPermission> PortalPermission { get; set; }

    public virtual DbSet<PortalSettings> PortalSettings { get; set; }

    public virtual DbSet<Portals> Portals { get; set; }

    public virtual DbSet<ProductsToOrder> ProductsToOrder { get; set; }

    public virtual DbSet<Profile> Profile { get; set; }

    public virtual DbSet<ProfilePropertyDefinition> ProfilePropertyDefinition { get; set; }

    public virtual DbSet<RedirectMessages> RedirectMessages { get; set; }

    public virtual DbSet<RelationshipTypes> RelationshipTypes { get; set; }

    public virtual DbSet<Relationships> Relationships { get; set; }

    public virtual DbSet<RoleGroups> RoleGroups { get; set; }

    public virtual DbSet<RoleSettings> RoleSettings { get; set; }

    public virtual DbSet<Roles> Roles { get; set; }

    public virtual DbSet<Schedule> Schedule { get; set; }

    public virtual DbSet<ScheduleHistory> ScheduleHistory { get; set; }

    public virtual DbSet<ScheduleItemSettings> ScheduleItemSettings { get; set; }

    public virtual DbSet<SearchCommonWords> SearchCommonWords { get; set; }

    public virtual DbSet<SearchDeletedItems> SearchDeletedItems { get; set; }

    public virtual DbSet<SearchIndexer> SearchIndexer { get; set; }

    public virtual DbSet<SearchStopWords> SearchStopWords { get; set; }

    public virtual DbSet<SearchTypes> SearchTypes { get; set; }

    public virtual DbSet<SiteLog> SiteLog { get; set; }

    public virtual DbSet<SkinControls> SkinControls { get; set; }

    public virtual DbSet<SkinPackages> SkinPackages { get; set; }

    public virtual DbSet<Skins> Skins { get; set; }

    public virtual DbSet<Sqlqueries> Sqlqueries { get; set; }

    public virtual DbSet<SynonymsGroups> SynonymsGroups { get; set; }

    public virtual DbSet<SystemMessages> SystemMessages { get; set; }

    public virtual DbSet<TabAliasSkins> TabAliasSkins { get; set; }

    public virtual DbSet<TabModuleSettings> TabModuleSettings { get; set; }

    public virtual DbSet<TabModules> TabModules { get; set; }

    public virtual DbSet<TabPermission> TabPermission { get; set; }

    public virtual DbSet<TabSettings> TabSettings { get; set; }

    public virtual DbSet<TabUrls> TabUrls { get; set; }

    public virtual DbSet<TabVersionDetails> TabVersionDetails { get; set; }

    public virtual DbSet<TabVersions> TabVersions { get; set; }

    public virtual DbSet<Tabs> Tabs { get; set; }

    public virtual DbSet<TaxonomyScopeTypes> TaxonomyScopeTypes { get; set; }

    public virtual DbSet<TaxonomyTerms> TaxonomyTerms { get; set; }

    public virtual DbSet<TaxonomyVocabularies> TaxonomyVocabularies { get; set; }

    public virtual DbSet<TaxonomyVocabularyTypes> TaxonomyVocabularyTypes { get; set; }

    public virtual DbSet<UrlLog> UrlLog { get; set; }

    public virtual DbSet<UrlTracking> UrlTracking { get; set; }

    public virtual DbSet<Urls> Urls { get; set; }

    public virtual DbSet<UserAuthentication> UserAuthentication { get; set; }

    public virtual DbSet<UserPortals> UserPortals { get; set; }

    public virtual DbSet<UserProfile> UserProfile { get; set; }

    public virtual DbSet<UserRelationshipPreferences> UserRelationshipPreferences { get; set; }

    public virtual DbSet<UserRelationships> UserRelationships { get; set; }

    public virtual DbSet<UserRoles> UserRoles { get; set; }

    public virtual DbSet<Users> Users { get; set; }

    public virtual DbSet<UsersOnline> UsersOnline { get; set; }

    public virtual DbSet<KliensApp.Models.Version> Version { get; set; }

    public virtual DbSet<VwAspnetApplications> VwAspnetApplications { get; set; }

    public virtual DbSet<VwAspnetMembershipUsers> VwAspnetMembershipUsers { get; set; }

    public virtual DbSet<VwAspnetUsers> VwAspnetUsers { get; set; }

    public virtual DbSet<VwContentWorkflowStatePermissions> VwContentWorkflowStatePermissions { get; set; }

    public virtual DbSet<VwContentWorkflowUsage> VwContentWorkflowUsage { get; set; }

    public virtual DbSet<VwCoreMessagingMessages> VwCoreMessagingMessages { get; set; }

    public virtual DbSet<VwDesktopModulePermissions> VwDesktopModulePermissions { get; set; }

    public virtual DbSet<VwDesktopModules> VwDesktopModules { get; set; }

    public virtual DbSet<VwEventLog> VwEventLog { get; set; }

    public virtual DbSet<VwExtensionUrlProviders> VwExtensionUrlProviders { get; set; }

    public virtual DbSet<VwFiles> VwFiles { get; set; }

    public virtual DbSet<VwFolderPermissions> VwFolderPermissions { get; set; }

    public virtual DbSet<VwLists> VwLists { get; set; }

    public virtual DbSet<VwMasterPortals> VwMasterPortals { get; set; }

    public virtual DbSet<VwMessagesForDispatch> VwMessagesForDispatch { get; set; }

    public virtual DbSet<VwModulePermissions> VwModulePermissions { get; set; }

    public virtual DbSet<VwModules> VwModules { get; set; }

    public virtual DbSet<VwPersonaBarMenuPermissions> VwPersonaBarMenuPermissions { get; set; }

    public virtual DbSet<VwPortalPermissions> VwPortalPermissions { get; set; }

    public virtual DbSet<VwPortals> VwPortals { get; set; }

    public virtual DbSet<VwPortalsDefaultLanguage> VwPortalsDefaultLanguage { get; set; }

    public virtual DbSet<VwProfile> VwProfile { get; set; }

    public virtual DbSet<VwPublishedFiles> VwPublishedFiles { get; set; }

    public virtual DbSet<VwTabModules> VwTabModules { get; set; }

    public virtual DbSet<VwTabPermissions> VwTabPermissions { get; set; }

    public virtual DbSet<VwTabs> VwTabs { get; set; }

    public virtual DbSet<VwUserRoles> VwUserRoles { get; set; }

    public virtual DbSet<VwUsers> VwUsers { get; set; }

    public virtual DbSet<WebServers> WebServers { get; set; }

    public virtual DbSet<WnsInjInjection> WnsInjInjection { get; set; }

    public virtual DbSet<Workflow> Workflow { get; set; }

    public virtual DbSet<WorkflowStates> WorkflowStates { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=rendfejl1018.northeurope.cloudapp.azure.com;Initial Catalog=VertikalData;User ID=VertikalUser;Password=MosoMaci@1018;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnonymousUsers>(entity =>
        {
            entity.Property(e => e.UserId).IsFixedLength();
            entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LastActiveDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Portal).WithMany(p => p.AnonymousUsers).HasConstraintName("FK_AnonymousUsers_Portals");
        });

        modelBuilder.Entity<AspnetApplications>(entity =>
        {
            entity.HasKey(e => e.ApplicationId)
                .HasName("PK__aspnet_A__C93A4C98C97F349C")
                .IsClustered(false);

            entity.HasIndex(e => e.LoweredApplicationName, "aspnet_Applications_Index").IsClustered();

            entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<AspnetMembership>(entity =>
        {
            entity.HasKey(e => e.UserId)
                .HasName("PK__aspnet_M__1788CC4DACA21E02")
                .IsClustered(false);

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail }, "aspnet_Membership_index").IsClustered();

            entity.Property(e => e.UserId).ValueGeneratedNever();

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetMembership)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Me__Appli__2C09769E");

            entity.HasOne(d => d.User).WithOne(p => p.AspnetMembership)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Me__UserI__2CFD9AD7");
        });

        modelBuilder.Entity<AspnetSchemaVersions>(entity =>
        {
            entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion }).HasName("PK__aspnet_S__5A1E6BC141387646");
        });

        modelBuilder.Entity<AspnetUsers>(entity =>
        {
            entity.HasKey(e => e.UserId)
                .HasName("PK__aspnet_U__1788CC4D6B20501A")
                .IsClustered(false);

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName }, "aspnet_Users_Index")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.MobileAlias).HasDefaultValueSql("(NULL)");

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Us__Appli__1BD30ED5");
        });

        modelBuilder.Entity<Assemblies>(entity =>
        {
            entity.HasKey(e => e.AssemblyId).HasName("PK_PackageAssemblies");

            entity.HasOne(d => d.Package).WithMany(p => p.Assemblies)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PackageAssemblies_PackageAssemblies");
        });

        modelBuilder.Entity<Authentication>(entity =>
        {
            entity.Property(e => e.PackageId).HasDefaultValue(-1);

            entity.HasOne(d => d.Package).WithMany(p => p.Authentication).HasConstraintName("FK_Authentication_Packages");
        });

        modelBuilder.Entity<ContentItems>(entity =>
        {
            entity.HasOne(d => d.ContentType).WithMany(p => p.ContentItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContentItems_ContentTypes");

            entity.HasOne(d => d.State).WithMany(p => p.ContentItems)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_ContentItems_ContentWorkflowStates");
        });

        modelBuilder.Entity<ContentItemsMetaData>(entity =>
        {
            entity.HasKey(e => e.ContentItemMetaDataId).HasName("PK_Content_MetaData");

            entity.HasOne(d => d.ContentItem).WithMany(p => p.ContentItemsMetaData).HasConstraintName("FK_ContentItems_MetaData_ContentItems");

            entity.HasOne(d => d.MetaData).WithMany(p => p.ContentItemsMetaData).HasConstraintName("FK_ContentItems_MetaDataMetaData");
        });

        modelBuilder.Entity<ContentItemsTags>(entity =>
        {
            entity.HasOne(d => d.ContentItem).WithMany(p => p.ContentItemsTags).HasConstraintName("FK_ContentItems_Tags_ContentItems");

            entity.HasOne(d => d.Term).WithMany(p => p.ContentItemsTags).HasConstraintName("FK_ContentItems_Tags_Taxonomy_Terms");
        });

        modelBuilder.Entity<ContentWorkflowActions>(entity =>
        {
            entity.HasOne(d => d.ContentType).WithMany(p => p.ContentWorkflowActions).HasConstraintName("FK_ContentWorkflowActions_ContentTypes");
        });

        modelBuilder.Entity<ContentWorkflowLogs>(entity =>
        {
            entity.Property(e => e.Type).HasDefaultValue(-1);

            entity.HasOne(d => d.ContentItem).WithMany(p => p.ContentWorkflowLogs).HasConstraintName("FK_ContentWorkflowLogs_ContentItems");

            entity.HasOne(d => d.Workflow).WithMany(p => p.ContentWorkflowLogs).HasConstraintName("FK_ContentWorkflowLogs_ContentWorkflows");
        });

        modelBuilder.Entity<ContentWorkflowSources>(entity =>
        {
            entity.HasOne(d => d.Workflow).WithMany(p => p.ContentWorkflowSources).HasConstraintName("FK_ContentWorkflowSources_ContentWorkflows");
        });

        modelBuilder.Entity<ContentWorkflowStatePermission>(entity =>
        {
            entity.HasOne(d => d.Permission).WithMany(p => p.ContentWorkflowStatePermission).HasConstraintName("FK_ContentWorkflowStatePermission_Permission");

            entity.HasOne(d => d.State).WithMany(p => p.ContentWorkflowStatePermission).HasConstraintName("FK_ContentWorkflowStatePermission_ContentWorkflowStates");

            entity.HasOne(d => d.User).WithMany(p => p.ContentWorkflowStatePermission)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ContentWorkflowStatePermission_Users");
        });

        modelBuilder.Entity<ContentWorkflowStates>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.OnCompleteMessageBody).HasDefaultValue("");
            entity.Property(e => e.OnCompleteMessageSubject).HasDefaultValue("");
            entity.Property(e => e.OnDiscardMessageBody).HasDefaultValue("");
            entity.Property(e => e.OnDiscardMessageSubject).HasDefaultValue("");
            entity.Property(e => e.SendNotification).HasDefaultValue(true);
            entity.Property(e => e.SendNotificationToAdministrators).HasDefaultValue(true);

            entity.HasOne(d => d.Workflow).WithMany(p => p.ContentWorkflowStates).HasConstraintName("FK_ContentWorkflowStates_ContentWorkflows");
        });

        modelBuilder.Entity<ContentWorkflows>(entity =>
        {
            entity.Property(e => e.StartAfterCreating).HasDefaultValue(true);
            entity.Property(e => e.StartAfterEditing).HasDefaultValue(true);
            entity.Property(e => e.WorkflowKey).HasDefaultValue("");
        });

        modelBuilder.Entity<CoreMessagingMessageAttachments>(entity =>
        {
            entity.HasOne(d => d.Message).WithMany(p => p.CoreMessagingMessageAttachments).HasConstraintName("FK_CoreMessaging_MessageAttachments_CoreMessaging_Messages");
        });

        modelBuilder.Entity<CoreMessagingMessageRecipients>(entity =>
        {
            entity.HasIndex(e => new { e.EmailSchedulerInstance, e.UserId, e.RecipientId }, "IX_CoreMessaging_MessageRecipients_ForDispatch")
                .IsUnique()
                .HasFilter("([EmailSent]=(0) AND [Read]=(0) AND [Archived]=(0))");

            entity.HasOne(d => d.Message).WithMany(p => p.CoreMessagingMessageRecipients).HasConstraintName("FK_CoreMessaging_MessageRecipients_CoreMessaging_Messages");
        });

        modelBuilder.Entity<CoreMessagingMessages>(entity =>
        {
            entity.HasOne(d => d.NotificationType).WithMany(p => p.CoreMessagingMessages)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CoreMessaging_Messages_CoreMessaging_NotificationTypes");
        });

        modelBuilder.Entity<CoreMessagingNotificationTypeActions>(entity =>
        {
            entity.HasOne(d => d.NotificationType).WithMany(p => p.CoreMessagingNotificationTypeActions).HasConstraintName("FK_CoreMessaging_NotificationTypeActions_CoreMessaging_NotificationTypes");
        });

        modelBuilder.Entity<CoreMessagingNotificationTypes>(entity =>
        {
            entity.HasOne(d => d.DesktopModule).WithMany(p => p.CoreMessagingNotificationTypes)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CoreMessaging_NotificationTypes_DesktopModules");
        });

        modelBuilder.Entity<CoreMessagingSubscriptions>(entity =>
        {
            entity.HasOne(d => d.Module).WithMany(p => p.CoreMessagingSubscriptions)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CoreMessaging_Subscriptions_Modules");

            entity.HasOne(d => d.Portal).WithMany(p => p.CoreMessagingSubscriptions)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CoreMessaging_Subscriptions_Portals");

            entity.HasOne(d => d.SubscriptionType).WithMany(p => p.CoreMessagingSubscriptions).HasConstraintName("FK_CoreMessaging_Subscriptions_Subscriptions_Type");

            entity.HasOne(d => d.User).WithMany(p => p.CoreMessagingSubscriptions).HasConstraintName("FK_CoreMessaging_Subscriptions_Users");
        });

        modelBuilder.Entity<DesktopModulePermission>(entity =>
        {
            entity.HasIndex(e => new { e.RoleId, e.PortalDesktopModuleId, e.PermissionId }, "IX_DesktopModulePermission_Roles")
                .IsUnique()
                .HasFilter("([RoleID] IS NOT NULL)");

            entity.HasIndex(e => new { e.UserId, e.PortalDesktopModuleId, e.PermissionId }, "IX_DesktopModulePermission_Users")
                .IsUnique()
                .HasFilter("([UserID] IS NOT NULL)");

            entity.HasOne(d => d.Permission).WithMany(p => p.DesktopModulePermission).HasConstraintName("FK_DesktopModulePermission_Permission");

            entity.HasOne(d => d.PortalDesktopModule).WithMany(p => p.DesktopModulePermission).HasConstraintName("FK_DesktopModulePermission_PortalDesktopModules");

            entity.HasOne(d => d.Role).WithMany(p => p.DesktopModulePermission).HasConstraintName("FK_DesktopModulePermission_Roles");

            entity.HasOne(d => d.User).WithMany(p => p.DesktopModulePermission)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_DesktopModulePermission_Users");
        });

        modelBuilder.Entity<DesktopModules>(entity =>
        {
            entity.Property(e => e.ContentItemId).HasDefaultValue(-1);
            entity.Property(e => e.PackageId).HasDefaultValue(-1);

            entity.HasOne(d => d.Package).WithMany(p => p.DesktopModules).HasConstraintName("FK_DesktopModules_Packages");
        });

        modelBuilder.Entity<EventLog>(entity =>
        {
            entity.HasKey(e => e.LogEventId).HasName("PK_EventLogMaster");

            entity.HasOne(d => d.LogConfig).WithMany(p => p.EventLog).HasConstraintName("FK_EventLog_EventLogConfig");

            entity.HasOne(d => d.LogTypeKeyNavigation).WithMany(p => p.EventLog)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventLog_EventLogTypes");
        });

        modelBuilder.Entity<EventLogConfig>(entity =>
        {
            entity.HasOne(d => d.LogTypeKeyNavigation).WithMany(p => p.EventLogConfig).HasConstraintName("FK_EventLogConfig_EventLogTypes");
        });

        modelBuilder.Entity<ExceptionEvents>(entity =>
        {
            entity.Property(e => e.LogEventId).ValueGeneratedNever();

            entity.HasOne(d => d.LogEvent).WithOne(p => p.ExceptionEvents).HasConstraintName("FK_ExceptionEvents_LogEventId");
        });

        modelBuilder.Entity<ExportImportCheckpoints>(entity =>
        {
            entity.Property(e => e.Completed).HasDefaultValue(false);

            entity.HasOne(d => d.Job).WithMany(p => p.ExportImportCheckpoints).HasConstraintName("FK_ExportImportCheckpoints_JobId");
        });

        modelBuilder.Entity<ExportImportJobLogs>(entity =>
        {
            entity.Property(e => e.CreatedOnDate).HasDefaultValueSql("(getutcdate())");

            entity.HasOne(d => d.Job).WithMany(p => p.ExportImportJobLogs).HasConstraintName("FK_ExportImportJobLogs_JobId");
        });

        modelBuilder.Entity<ExportImportJobs>(entity =>
        {
            entity.Property(e => e.CreatedOnDate).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.LastModifiedOnDate).HasDefaultValueSql("(getutcdate())");
        });

        modelBuilder.Entity<FileVersions>(entity =>
        {
            entity.HasOne(d => d.File).WithMany(p => p.FileVersions).HasConstraintName("FK_FileVersions_Files");
        });

        modelBuilder.Entity<Files>(entity =>
        {
            entity.HasKey(e => e.FileId).HasName("PK_File");

            entity.HasIndex(e => e.ContentItemId, "IX_Files_ContentID").HasFilter("([ContentItemId] IS NOT NULL)");

            entity.HasIndex(e => e.FileId, "IX_Files_FileID").HasFilter("([ContentItemId] IS NOT NULL)");

            entity.Property(e => e.Folder).HasComputedColumnSql("([dbo].[GetFileFolderFunc]([FolderID]))", false);
            entity.Property(e => e.HasBeenPublished).HasDefaultValue(true);
            entity.Property(e => e.LastModificationTime).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.PublishedVersion).HasDefaultValue(1);
            entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.VersionGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.ContentItem).WithMany(p => p.Files).HasConstraintName("FK_Files_ContentItems");

            entity.HasOne(d => d.FolderNavigation).WithMany(p => p.Files).HasConstraintName("FK_Files_Folders");

            entity.HasOne(d => d.Portal).WithMany(p => p.Files).HasConstraintName("FK_Files_Portals");
        });

        modelBuilder.Entity<FolderMappings>(entity =>
        {
            entity.HasOne(d => d.Portal).WithMany(p => p.FolderMappings)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FolderMappings_Portals");
        });

        modelBuilder.Entity<FolderMappingsSettings>(entity =>
        {
            entity.HasOne(d => d.FolderMapping).WithMany(p => p.FolderMappingsSettings).HasConstraintName("FK_FolderMappingsSettings_FolderMappings");
        });

        modelBuilder.Entity<FolderPermission>(entity =>
        {
            entity.HasIndex(e => new { e.RoleId, e.FolderId, e.PermissionId }, "IX_FolderPermission_Roles")
                .IsUnique()
                .HasFilter("([RoleID] IS NOT NULL)");

            entity.HasIndex(e => new { e.UserId, e.FolderId, e.PermissionId }, "IX_FolderPermission_Users")
                .IsUnique()
                .HasFilter("([UserID] IS NOT NULL)");

            entity.HasOne(d => d.Folder).WithMany(p => p.FolderPermission).HasConstraintName("FK_FolderPermission_Folders");

            entity.HasOne(d => d.Permission).WithMany(p => p.FolderPermission).HasConstraintName("FK_FolderPermission_Permission");

            entity.HasOne(d => d.Role).WithMany(p => p.FolderPermission).HasConstraintName("FK_FolderPermission_Roles");

            entity.HasOne(d => d.User).WithMany(p => p.FolderPermission)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FolderPermission_Users");
        });

        modelBuilder.Entity<Folders>(entity =>
        {
            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.VersionGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.FolderMapping).WithMany(p => p.Folders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Folders_FolderMappings");

            entity.HasOne(d => d.Portal).WithMany(p => p.Folders)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Folders_Portals");

            entity.HasOne(d => d.Workflow).WithMany(p => p.Folders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Folders_ContentWorkflows");
        });

        modelBuilder.Entity<HccAddress>(entity =>
        {
            entity.HasKey(e => e.Bvin).IsClustered(false);

            entity.HasIndex(e => e.Id, "IX_hcc_Address")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HccAffiliatePayments>(entity =>
        {
            entity.HasOne(d => d.Affiliate).WithMany(p => p.HccAffiliatePayments).HasConstraintName("FK_hcc_AffiliatePayments_hcc_Affiliate");
        });

        modelBuilder.Entity<HccAffiliateReferral>(entity =>
        {
            entity.Property(e => e.TimeOfReferralUtc).HasDefaultValueSql("('20130101')");

            entity.HasOne(d => d.Affiliate).WithMany(p => p.HccAffiliateReferral).HasConstraintName("FK_hcc_AffiliateReferral_hcc_Affiliate");
        });

        modelBuilder.Entity<HccAudit>(entity =>
        {
            entity.Property(e => e.UserId).HasDefaultValue("");
            entity.Property(e => e.UserIdText).HasDefaultValue("");
        });

        modelBuilder.Entity<HccAuthTokens>(entity =>
        {
            entity.HasOne(d => d.User).WithMany(p => p.HccAuthTokens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_AuthTokens_hcc_UserAccounts");
        });

        modelBuilder.Entity<HccBundledProducts>(entity =>
        {
            entity.HasOne(d => d.Product).WithMany(p => p.HccBundledProducts).HasConstraintName("FK_hcc_BundledProducts_hcc_Product");
        });

        modelBuilder.Entity<HccCatalogRoles>(entity =>
        {
            entity.HasOne(d => d.Category).WithMany(p => p.HccCatalogRoles)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_hcc_CatalogRoles_hcc_Category");

            entity.HasOne(d => d.Product).WithMany(p => p.HccCatalogRoles)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_hcc_CatalogRoles_hcc_Product");

            entity.HasOne(d => d.ProductType).WithMany(p => p.HccCatalogRoles)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_hcc_CatalogRoles_hcc_ProductType");
        });

        modelBuilder.Entity<HccCategory>(entity =>
        {
            entity.Property(e => e.Bvin).ValueGeneratedNever();
            entity.Property(e => e.ShowTitle).HasDefaultValue(1);
            entity.Property(e => e.StoreId).HasDefaultValue(1L);
        });

        modelBuilder.Entity<HccCategoryTranslations>(entity =>
        {
            entity.HasOne(d => d.Category).WithMany(p => p.HccCategoryTranslations).HasConstraintName("FK_hcc_CategoryTranslations_hcc_Category");
        });

        modelBuilder.Entity<HccContentBlock>(entity =>
        {
            entity.Property(e => e.Bvin).ValueGeneratedNever();
            entity.Property(e => e.SerializedLists).HasDefaultValue("");
            entity.Property(e => e.SerializedSettings).HasDefaultValue("");

            entity.HasOne(d => d.Column).WithMany(p => p.HccContentBlock).HasConstraintName("FK_hcc_ContentBlock_hcc_ContentColumn");
        });

        modelBuilder.Entity<HccContentBlockTranslations>(entity =>
        {
            entity.HasOne(d => d.ContentBlock).WithMany(p => p.HccContentBlockTranslations).HasConstraintName("FK_hcc_ContentBlockTranslations_hcc_ContentBlock");
        });

        modelBuilder.Entity<HccContentColumn>(entity =>
        {
            entity.Property(e => e.Bvin).ValueGeneratedNever();
        });

        modelBuilder.Entity<HccCountries>(entity =>
        {
            entity.Property(e => e.CountryId).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<HccCountryTranslations>(entity =>
        {
            entity.HasOne(d => d.Country).WithMany(p => p.HccCountryTranslations).HasConstraintName("FK_hcc_CountryTranslations_hcc_Countries");
        });

        modelBuilder.Entity<HccCustomUrl>(entity =>
        {
            entity.Property(e => e.IsPermanentRedirect).HasDefaultValue(true);
        });

        modelBuilder.Entity<HccHtmlTemplateTranslations>(entity =>
        {
            entity.HasOne(d => d.HtmlTemplate).WithMany(p => p.HccHtmlTemplateTranslations).HasConstraintName("FK_hcc_HtmlTemplateTranslations_hcc_HtmlTemplates");
        });

        modelBuilder.Entity<HccLineItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hcc_LineItem_Id");

            entity.Property(e => e.CustomProperties).HasDefaultValue("");
            entity.Property(e => e.DiscountDetails).HasDefaultValue("");
            entity.Property(e => e.IsNonShipping).HasDefaultValueSql("('')");
            entity.Property(e => e.SelectionData).HasDefaultValue("");
            entity.Property(e => e.ShipFromAddress).HasDefaultValue("");
            entity.Property(e => e.ShipFromMode).HasDefaultValue(1);
            entity.Property(e => e.ShipFromNotificationId).HasDefaultValue("");
            entity.Property(e => e.ShippingCharge).HasDefaultValue(1);
            entity.Property(e => e.StatusCode).HasDefaultValue("");
            entity.Property(e => e.StatusName).HasDefaultValue("");
            entity.Property(e => e.TaxScheduleId).HasDefaultValueSql("('')");
            entity.Property(e => e.VariantId).HasDefaultValue("");

            entity.HasOne(d => d.OrderBvinNavigation).WithMany(p => p.HccLineItem).HasConstraintName("FK_hcc_LineItem_hcc_LineItem");
        });

        modelBuilder.Entity<HccMailingList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hcc_MailingList_1");

            entity.Property(e => e.LastUpdatedUtc).HasDefaultValueSql("('20130101')");
            entity.Property(e => e.Name).HasDefaultValue("");
        });

        modelBuilder.Entity<HccMailingListMember>(entity =>
        {
            entity.Property(e => e.FirstName).HasDefaultValue("");
            entity.Property(e => e.LastName).HasDefaultValue("");
            entity.Property(e => e.LastUpdatedUtc).HasDefaultValueSql("('20130101')");

            entity.HasOne(d => d.List).WithMany(p => p.HccMailingListMember).HasConstraintName("FK_hcc_MailingListMember_hcc_MailingList");
        });

        modelBuilder.Entity<HccManufacturer>(entity =>
        {
            entity.Property(e => e.Bvin).ValueGeneratedNever();
        });

        modelBuilder.Entity<HccMembershipProductType>(entity =>
        {
            entity.Property(e => e.ProductTypeBvin).ValueGeneratedNever();

            entity.HasOne(d => d.ProductTypeBvinNavigation).WithOne(p => p.HccMembershipProductType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_MembershipProductType_hcc_ProductType");
        });

        modelBuilder.Entity<HccOrder>(entity =>
        {
            entity.HasKey(e => e.Bvin).IsClustered(false);

            entity.HasIndex(e => e.Id, "IX_hcc_Order")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Bvin).ValueGeneratedNever();
            entity.Property(e => e.CustomProperties).HasDefaultValue("");
            entity.Property(e => e.FraudScore).HasDefaultValue(-1m);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Instructions).HasDefaultValue("");
            entity.Property(e => e.OrderDiscountDetails).HasDefaultValue("");
            entity.Property(e => e.OrderNumber).HasDefaultValue("");
            entity.Property(e => e.ShippingAddress).HasDefaultValue("");
            entity.Property(e => e.ShippingDiscountDetails).HasDefaultValue("");
            entity.Property(e => e.ShippingMethodDisplayName).HasDefaultValue("");
            entity.Property(e => e.ShippingMethodId).HasDefaultValue("");
            entity.Property(e => e.ShippingProviderId).HasDefaultValue("");
            entity.Property(e => e.ShippingProviderServiceCode).HasDefaultValue("");
            entity.Property(e => e.StatusCode).HasDefaultValue("");
            entity.Property(e => e.StatusName).HasDefaultValue("");
            entity.Property(e => e.ThirdPartyOrderId).HasDefaultValue("");
            entity.Property(e => e.UserEmail).HasDefaultValue("");
        });

        modelBuilder.Entity<HccOrderCoupon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hcc_OrderCoupon_1");

            entity.Property(e => e.UserId).HasDefaultValue("");

            entity.HasOne(d => d.OrderBvinNavigation).WithMany(p => p.HccOrderCoupon).HasConstraintName("FK_hcc_OrderCoupon_hcc_Order");
        });

        modelBuilder.Entity<HccOrderNote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hcc_OrderNote_1");

            entity.HasOne(d => d.Order).WithMany(p => p.HccOrderNote).HasConstraintName("FK_hcc_OrderNote_hcc_Order");
        });

        modelBuilder.Entity<HccOrderPackage>(entity =>
        {
            entity.Property(e => e.CustomProperties).HasDefaultValue("n''");
            entity.Property(e => e.LastUpdatedUtc).HasDefaultValueSql("('20130101')");

            entity.HasOne(d => d.Order).WithMany(p => p.HccOrderPackage).HasConstraintName("FK_hcc_OrderPackage_hcc_Order");
        });

        modelBuilder.Entity<HccOrderTransactions>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AdditionalSettings).HasDefaultValue("");
            entity.Property(e => e.CheckNumber).HasDefaultValue("");
            entity.Property(e => e.CompanyAccountNumber).HasDefaultValue("");
            entity.Property(e => e.Messages).HasDefaultValue("");
            entity.Property(e => e.OrderNumber).HasDefaultValue("");
            entity.Property(e => e.PurchaseOrderNumber).HasDefaultValue("");

            entity.HasOne(d => d.Order).WithMany(p => p.HccOrderTransactions).HasConstraintName("FK_hcc_OrderTransactions_hcc_Order");

            entity.HasOne(d => d.Store).WithMany(p => p.HccOrderTransactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_OrderTransactions_hcc_Stores");
        });

        modelBuilder.Entity<HccProduct>(entity =>
        {
            entity.HasKey(e => e.Bvin).IsClustered(false);

            entity.HasIndex(e => e.Id, "IX_hcc_Product_id")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Bvin).ValueGeneratedNever();
            entity.Property(e => e.CustomProperties).HasDefaultValue("");
            entity.Property(e => e.GiftWrapPrice).HasDefaultValueSql("((0.00))");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IsAvailableForSale).HasDefaultValue(true);
            entity.Property(e => e.IsSearchable).HasDefaultValue(true);
            entity.Property(e => e.RewriteUrl).HasDefaultValue("");
            entity.Property(e => e.ShippingCharge).HasDefaultValue(1);
            entity.Property(e => e.StoreId).HasDefaultValue(1L);
            entity.Property(e => e.UpchargeAmount).HasDefaultValue(3m);
            entity.Property(e => e.UpchargeUnit).HasDefaultValue("1");

            entity.HasOne(d => d.Manufacturer).WithMany(p => p.HccProduct)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_hcc_Product_hcc_Manufacturer");

            entity.HasOne(d => d.ProductType).WithMany(p => p.HccProduct)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_hcc_Product_hcc_ProductType");

            entity.HasOne(d => d.Vendor).WithMany(p => p.HccProduct)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_hcc_Product_hcc_Vendor");
        });

        modelBuilder.Entity<HccProductFile>(entity =>
        {
            entity.Property(e => e.Bvin).ValueGeneratedNever();
        });

        modelBuilder.Entity<HccProductFileXproduct>(entity =>
        {
            entity.HasOne(d => d.ProductFile).WithMany(p => p.HccProductFileXproduct).HasConstraintName("FK_hcc_ProductFileXProduct_hcc_ProductFile");

            entity.HasOne(d => d.Product).WithMany(p => p.HccProductFileXproduct).HasConstraintName("FK_hcc_ProductFileXProduct_hcc_Product");
        });

        modelBuilder.Entity<HccProductImage>(entity =>
        {
            entity.Property(e => e.Bvin).ValueGeneratedNever();
            entity.Property(e => e.SortOrder).HasDefaultValue(-1);

            entity.HasOne(d => d.Product).WithMany(p => p.HccProductImage).HasConstraintName("FK_hcc_ProductImage_hcc_Product");
        });

        modelBuilder.Entity<HccProductInventory>(entity =>
        {
            entity.Property(e => e.QuantityAvailableForSale).HasComputedColumnSql("([QuantityOnHand]-[QuantityReserved])", true);
            entity.Property(e => e.StoreId).HasDefaultValue(1L);
            entity.Property(e => e.VariantId).HasDefaultValue("");

            entity.HasOne(d => d.ProductBvinNavigation).WithMany(p => p.HccProductInventory).HasConstraintName("FK_hcc_ProductInventory_hcc_Product");
        });

        modelBuilder.Entity<HccProductOptionItemTranslations>(entity =>
        {
            entity.HasOne(d => d.ProductOptionItem).WithMany(p => p.HccProductOptionItemTranslations).HasConstraintName("FK_hcc_ProductOptionItemTranslations_hcc_ProductOptionsItems");
        });

        modelBuilder.Entity<HccProductOptionTranslations>(entity =>
        {
            entity.HasOne(d => d.ProductOption).WithMany(p => p.HccProductOptionTranslations).HasConstraintName("FK_hcc_ProductOptionTranslations_hcc_ProductOptions");
        });

        modelBuilder.Entity<HccProductOptions>(entity =>
        {
            entity.Property(e => e.Bvin).ValueGeneratedNever();
        });

        modelBuilder.Entity<HccProductOptionsItems>(entity =>
        {
            entity.Property(e => e.Bvin).ValueGeneratedNever();

            entity.HasOne(d => d.OptionBvinNavigation).WithMany(p => p.HccProductOptionsItems).HasConstraintName("FK_hcc_ProductOptionsItems_hcc_ProductOptions");
        });

        modelBuilder.Entity<HccProductProperty>(entity =>
        {
            entity.Property(e => e.CultureCode).HasDefaultValue("en-US");
            entity.Property(e => e.DisplayOnSite).HasDefaultValue(1);
        });

        modelBuilder.Entity<HccProductPropertyChoice>(entity =>
        {
            entity.Property(e => e.SortOrder).HasDefaultValue(-1);

            entity.HasOne(d => d.Property).WithMany(p => p.HccProductPropertyChoice).HasConstraintName("FK_hcc_ProductPropertyChoice_hcc_ProductProperty");
        });

        modelBuilder.Entity<HccProductPropertyChoiceTranslations>(entity =>
        {
            entity.HasOne(d => d.ProductPropertyChoice).WithMany(p => p.HccProductPropertyChoiceTranslations).HasConstraintName("FK_hcc_ProductPropertyChoiceTranslations_hcc_ProductPropertyChoice");
        });

        modelBuilder.Entity<HccProductPropertyTranslations>(entity =>
        {
            entity.HasOne(d => d.ProductProperty).WithMany(p => p.HccProductPropertyTranslations).HasConstraintName("FK_hcc_ProductPropertyTranslations_hcc_ProductProperty");
        });

        modelBuilder.Entity<HccProductPropertyValue>(entity =>
        {
            entity.HasOne(d => d.ProductBvinNavigation).WithMany(p => p.HccProductPropertyValue).HasConstraintName("FK_hcc_ProductPropertyValue_hcc_Product");

            entity.HasOne(d => d.Property).WithMany(p => p.HccProductPropertyValue).HasConstraintName("FK_hcc_ProductPropertyValue_hcc_ProductProperty");
        });

        modelBuilder.Entity<HccProductPropertyValueTranslations>(entity =>
        {
            entity.HasOne(d => d.ProductPropertyValue).WithMany(p => p.HccProductPropertyValueTranslations).HasConstraintName("FK_hcc_ProductPropertyValueTranslations_hcc_ProductPropertyValue");
        });

        modelBuilder.Entity<HccProductRelationships>(entity =>
        {
            entity.HasOne(d => d.Product).WithMany(p => p.HccProductRelationships).HasConstraintName("FK_hcc_ProductRelationships_hcc_Product");
        });

        modelBuilder.Entity<HccProductReview>(entity =>
        {
            entity.HasKey(e => e.Bvin).IsClustered(false);

            entity.HasIndex(e => e.ProductId, "IX_hcc_ProductReview_ProductId").IsClustered();

            entity.Property(e => e.Bvin).ValueGeneratedNever();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Product).WithMany(p => p.HccProductReview).HasConstraintName("FK_hcc_ProductReview_hcc_Product");
        });

        modelBuilder.Entity<HccProductTranslations>(entity =>
        {
            entity.HasOne(d => d.Product).WithMany(p => p.HccProductTranslations).HasConstraintName("FK_hcc_ProductTranslations_hcc_Product");
        });

        modelBuilder.Entity<HccProductType>(entity =>
        {
            entity.Property(e => e.Bvin).ValueGeneratedNever();
        });

        modelBuilder.Entity<HccProductTypeTranslations>(entity =>
        {
            entity.Property(e => e.Culture).IsFixedLength();

            entity.HasOne(d => d.ProductType).WithMany(p => p.HccProductTypeTranslations).HasConstraintName("FK_hcc_ProductTypeTranslations_hcc_ProductType");
        });

        modelBuilder.Entity<HccProductTypeXproductProperty>(entity =>
        {
            entity.Property(e => e.SortOrder).HasDefaultValue(1);

            entity.HasOne(d => d.ProductTypeBvinNavigation).WithMany(p => p.HccProductTypeXproductProperty).HasConstraintName("FK_hcc_ProductTypeProperties_hcc_ProductType");

            entity.HasOne(d => d.Property).WithMany(p => p.HccProductTypeXproductProperty).HasConstraintName("FK_hcc_ProductTypeXProductProperty_hcc_ProductProperty");
        });

        modelBuilder.Entity<HccProductVolumeDiscounts>(entity =>
        {
            entity.Property(e => e.Bvin).ValueGeneratedNever();
            entity.Property(e => e.Qty).HasDefaultValue(1);

            entity.HasOne(d => d.Product).WithMany(p => p.HccProductVolumeDiscounts).HasConstraintName("FK_hcc_ProductVolumeDiscounts_hcc_Product");
        });

        modelBuilder.Entity<HccProductXcategory>(entity =>
        {
            entity.HasOne(d => d.Category).WithMany(p => p.HccProductXcategory).HasConstraintName("FK_hcc_ProductXCategory_hcc_Category");

            entity.HasOne(d => d.Product).WithMany(p => p.HccProductXcategory).HasConstraintName("FK_hcc_ProductXCategory_hcc_Product");
        });

        modelBuilder.Entity<HccProductXoption>(entity =>
        {
            entity.HasOne(d => d.OptionBvinNavigation).WithMany(p => p.HccProductXoption)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_ProductXOption_hcc_ProductOptions");

            entity.HasOne(d => d.ProductBvinNavigation).WithMany(p => p.HccProductXoption)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_ProductXOption_hcc_Product");
        });

        modelBuilder.Entity<HccPromotionTranslations>(entity =>
        {
            entity.HasOne(d => d.Promotion).WithMany(p => p.HccPromotionTranslations).HasConstraintName("FK_hcc_PromotionTranslations_hcc_Promotions");
        });

        modelBuilder.Entity<HccPromotions>(entity =>
        {
            entity.Property(e => e.ActionsXml).HasDefaultValue("");
            entity.Property(e => e.QualificationsXml).HasDefaultValue("");
        });

        modelBuilder.Entity<HccRegionTranslations>(entity =>
        {
            entity.HasOne(d => d.Region).WithMany(p => p.HccRegionTranslations).HasConstraintName("FK_hcc_RegionTranslations_hcc_Regions");
        });

        modelBuilder.Entity<HccRegions>(entity =>
        {
            entity.Property(e => e.RegionId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Country).WithMany(p => p.HccRegions).HasConstraintName("FK_hcc_Regions_hcc_Countries");
        });

        modelBuilder.Entity<HccRma>(entity =>
        {
            entity.Property(e => e.Bvin).ValueGeneratedNever();
            entity.Property(e => e.DateOfReturn).HasDefaultValue(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            entity.Property(e => e.Number).ValueGeneratedOnAdd();

            entity.HasOne(d => d.OrderBvinNavigation).WithMany(p => p.HccRma).HasConstraintName("FK_hcc_RMA_hcc_Order");
        });

        modelBuilder.Entity<HccRmaitem>(entity =>
        {
            entity.HasKey(e => e.Bvin).IsClustered(false);

            entity.HasIndex(e => e.Bvin, "IX_hcc_RMAItem")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Bvin).ValueGeneratedNever();
            entity.Property(e => e.ProductClass).HasDefaultValue("");

            entity.HasOne(d => d.RmabvinNavigation).WithMany(p => p.HccRmaitem).HasConstraintName("FK_hcc_RMAItem_hcc_RMA");
        });

        modelBuilder.Entity<HccSearchObjectWords>(entity =>
        {
            entity.HasOne(d => d.SearchObject).WithMany(p => p.HccSearchObjectWords).HasConstraintName("FK_hcc_SearchObjectWords_hcc_SearchObjects");

            entity.HasOne(d => d.Word).WithMany(p => p.HccSearchObjectWords)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_SearchObjectWords_hcc_SearchLexicon");
        });

        modelBuilder.Entity<HccSearchObjects>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hcc_SearchObject");

            entity.Property(e => e.LastIndexUtc).HasDefaultValueSql("(((1)/(1))/(1900))");
        });

        modelBuilder.Entity<HccShippingMethod>(entity =>
        {
            entity.Property(e => e.Bvin).ValueGeneratedNever();
            entity.Property(e => e.Settings).HasDefaultValue("");
        });

        modelBuilder.Entity<HccShippingMethodTranslations>(entity =>
        {
            entity.HasOne(d => d.ShippingMethod).WithMany(p => p.HccShippingMethodTranslations).HasConstraintName("FK_hcc_ShippingMethodTranslations_hcc_ShippingMethodTranslations");
        });

        modelBuilder.Entity<HccShippingZones>(entity =>
        {
            entity.Property(e => e.Areas).HasDefaultValue("");

            entity.HasOne(d => d.Store).WithMany(p => p.HccShippingZones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_ShippingZones_hcc_Stores");
        });

        modelBuilder.Entity<HccStoreSettings>(entity =>
        {
            entity.HasOne(d => d.Store).WithMany(p => p.HccStoreSettings).HasConstraintName("FK_hcc_StoreSettings_hcc_Stores");
        });

        modelBuilder.Entity<HccStoreSettingsTranslations>(entity =>
        {
            entity.HasOne(d => d.StoreSettings).WithMany(p => p.HccStoreSettingsTranslations).HasConstraintName("FK_hcc_StoreSettingsTranslations_hcc_StoreSettings");
        });

        modelBuilder.Entity<HccStores>(entity =>
        {
            entity.Property(e => e.CustomUrl).HasDefaultValue("");
        });

        modelBuilder.Entity<HccStoresXusers>(entity =>
        {
            entity.Property(e => e.AccessMode).HasDefaultValue(1);

            entity.HasOne(d => d.Store).WithMany(p => p.HccStoresXusers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_StoresXUsers_hcc_Stores");

            entity.HasOne(d => d.User).WithMany(p => p.HccStoresXusers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_StoresXUsers_hcc_UserAccounts");
        });

        modelBuilder.Entity<HccTaxSchedules>(entity =>
        {
            entity.HasOne(d => d.Store).WithMany(p => p.HccTaxSchedules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_TaxSchedules_hcc_Stores");
        });

        modelBuilder.Entity<HccTaxes>(entity =>
        {
            entity.HasOne(d => d.Store).WithMany(p => p.HccTaxes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_Taxes_hcc_Stores");

            entity.HasOne(d => d.TaxSchedule).WithMany(p => p.HccTaxes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_Taxes_hcc_TaxSchedules");
        });

        modelBuilder.Entity<HccUser>(entity =>
        {
            entity.Property(e => e.BillingAddress).HasDefaultValue("");
            entity.Property(e => e.Phones).HasDefaultValue("");
            entity.Property(e => e.ShippingAddress).HasDefaultValue("");
        });

        modelBuilder.Entity<HccUserAccounts>(entity =>
        {
            entity.Property(e => e.ResetKey).HasDefaultValue("");
            entity.Property(e => e.Salt).HasDefaultValue("");
            entity.Property(e => e.Statuscode).HasDefaultValue(1);
        });

        modelBuilder.Entity<HccUserXcontact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hcc_UserXAffiliate");

            entity.HasOne(d => d.User).WithMany(p => p.HccUserXcontact)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_UserXAffiliate_hcc_User");
        });

        modelBuilder.Entity<HccVariants>(entity =>
        {
            entity.HasKey(e => e.Bvin)
                .HasName("PK_hcc_Variant")
                .IsClustered(false);

            entity.HasIndex(e => new { e.ProductId, e.StoreId }, "IX_hcc_Variants_ProductIdClustered").IsClustered();

            entity.Property(e => e.Bvin).ValueGeneratedNever();
            entity.Property(e => e.CustomProperty).HasDefaultValue("");

            entity.HasOne(d => d.Product).WithMany(p => p.HccVariants).HasConstraintName("FK_hcc_Variants_hcc_Product");
        });

        modelBuilder.Entity<HccVendor>(entity =>
        {
            entity.Property(e => e.Bvin).ValueGeneratedNever();
        });

        modelBuilder.Entity<HccWishListItems>(entity =>
        {
            entity.Property(e => e.CustomerId).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.Product).WithMany(p => p.HccWishListItems).HasConstraintName("FK_hcc_WishListItems_hcc_Product");
        });

        modelBuilder.Entity<HtmlText>(entity =>
        {
            entity.HasOne(d => d.Module).WithMany(p => p.HtmlText).HasConstraintName("FK_HtmlText_Modules");

            entity.HasOne(d => d.State).WithMany(p => p.HtmlText).HasConstraintName("FK_HtmlText_WorkflowStates");
        });

        modelBuilder.Entity<HtmlTextLog>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.HtmlTextLog).HasConstraintName("FK_HtmlTextLog_HtmlText");

            entity.HasOne(d => d.State).WithMany(p => p.HtmlTextLog)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HtmlTextLog_WorkflowStates");
        });

        modelBuilder.Entity<HtmlTextUsers>(entity =>
        {
            entity.HasOne(d => d.Item).WithMany(p => p.HtmlTextUsers).HasConstraintName("FK_HtmlTextUsers_HtmlText");
        });

        modelBuilder.Entity<JavaScriptLibraries>(entity =>
        {
            entity.HasKey(e => e.JavaScriptLibraryId).HasName("PK_JavaScriptLIbraries");

            entity.HasOne(d => d.Package).WithMany(p => p.JavaScriptLibraries).HasConstraintName("FK_JavaScriptLibrariesPackages");
        });

        modelBuilder.Entity<Journal>(entity =>
        {
            entity.Property(e => e.GroupId).HasDefaultValue(-1);
            entity.Property(e => e.ProfileId).HasDefaultValue(-1);

            entity.HasOne(d => d.JournalType).WithMany(p => p.Journal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Journal_JournalTypes");
        });

        modelBuilder.Entity<JournalComments>(entity =>
        {
            entity.HasOne(d => d.Journal).WithMany(p => p.JournalComments).HasConstraintName("FK_JournalComments_Journal");
        });

        modelBuilder.Entity<JournalData>(entity =>
        {
            entity.HasOne(d => d.Journal).WithMany(p => p.JournalData).HasConstraintName("FK_Journal_Data_Journal");
        });

        modelBuilder.Entity<JournalTypes>(entity =>
        {
            entity.HasKey(e => e.JournalTypeId).HasName("PK_JournalTypes");

            entity.Property(e => e.JournalTypeId).ValueGeneratedNever();
            entity.Property(e => e.AppliesToGroup).HasDefaultValue(true);
            entity.Property(e => e.AppliesToProfile).HasDefaultValue(true);
            entity.Property(e => e.AppliesToStream).HasDefaultValue(true);
            entity.Property(e => e.EnableComments).HasDefaultValue(true);
            entity.Property(e => e.IsEnabled).HasDefaultValue(true);
            entity.Property(e => e.PortalId).HasDefaultValue(-1);
        });

        modelBuilder.Entity<LanguagePacks>(entity =>
        {
            entity.HasOne(d => d.Package).WithMany(p => p.LanguagePacks).HasConstraintName("FK_LanguagePacks_Packages");
        });

        modelBuilder.Entity<Lists>(entity =>
        {
            entity.Property(e => e.PortalId).HasDefaultValue(-1);
        });

        modelBuilder.Entity<MobilePreviewProfiles>(entity =>
        {
            entity.Property(e => e.CreatedOnDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LastModifiedOnDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Portal).WithMany(p => p.MobilePreviewProfiles).HasConstraintName("FK_Mobile_PreviewProfiles_Portals");
        });

        modelBuilder.Entity<MobileRedirectionRules>(entity =>
        {
            entity.HasOne(d => d.Redirection).WithMany(p => p.MobileRedirectionRules).HasConstraintName("FK_Mobile_RedirectionRules_Mobile_Redirections");
        });

        modelBuilder.Entity<MobileRedirections>(entity =>
        {
            entity.Property(e => e.CreatedOnDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LastModifiedOnDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Portal).WithMany(p => p.MobileRedirections).HasConstraintName("FK_Mobile_Redirections_Portals");
        });

        modelBuilder.Entity<ModuleControls>(entity =>
        {
            entity.HasOne(d => d.ModuleDef).WithMany(p => p.ModuleControls)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ModuleControls_ModuleDefinitions");
        });

        modelBuilder.Entity<ModuleDefinitions>(entity =>
        {
            entity.HasOne(d => d.DesktopModule).WithMany(p => p.ModuleDefinitions).HasConstraintName("FK_ModuleDefinitions_DesktopModules");
        });

        modelBuilder.Entity<ModulePermission>(entity =>
        {
            entity.HasIndex(e => new { e.RoleId, e.ModuleId, e.PermissionId, e.PortalId }, "IX_ModulePermission_Roles")
                .IsUnique()
                .HasFilter("([RoleID] IS NOT NULL)");

            entity.HasIndex(e => new { e.UserId, e.ModuleId, e.PermissionId, e.PortalId }, "IX_ModulePermission_Users")
                .IsUnique()
                .HasFilter("([UserID] IS NOT NULL)");

            entity.HasOne(d => d.Module).WithMany(p => p.ModulePermission).HasConstraintName("FK_ModulePermission_Modules");

            entity.HasOne(d => d.Permission).WithMany(p => p.ModulePermission).HasConstraintName("FK_ModulePermission_Permission");

            entity.HasOne(d => d.Role).WithMany(p => p.ModulePermission).HasConstraintName("FK_ModulePermission_Roles");

            entity.HasOne(d => d.User).WithMany(p => p.ModulePermission)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ModulePermission_Users");
        });

        modelBuilder.Entity<ModuleSettings>(entity =>
        {
            entity.HasOne(d => d.Module).WithMany(p => p.ModuleSettings).HasConstraintName("FK_ModuleSettings_Modules");
        });

        modelBuilder.Entity<Modules>(entity =>
        {
            entity.Property(e => e.CreatedOnDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IsShareable).HasDefaultValue(true);
            entity.Property(e => e.IsShareableViewOnly).HasDefaultValue(true);
            entity.Property(e => e.LastModifiedOnDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.ContentItem).WithMany(p => p.Modules).HasConstraintName("FK_Modules_ContentItems");

            entity.HasOne(d => d.ModuleDef).WithMany(p => p.Modules).HasConstraintName("FK_Modules_ModuleDefinitions");
        });

        modelBuilder.Entity<OrderedProducts>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__OrderedP__C3905BAFFDCBEB73");
        });

        modelBuilder.Entity<PackageDependencies>(entity =>
        {
            entity.HasOne(d => d.Package).WithMany(p => p.PackageDependencies).HasConstraintName("FK_PackageDependencies_Packages");
        });

        modelBuilder.Entity<PackageTypes>(entity =>
        {
            entity.HasKey(e => e.PackageType).HasName("PK_PackageTypes_1");
        });

        modelBuilder.Entity<Packages>(entity =>
        {
            entity.HasOne(d => d.PackageTypeNavigation).WithMany(p => p.Packages).HasConstraintName("FK_Packages_PackageTypes");
        });

        modelBuilder.Entity<PasswordHistory>(entity =>
        {
            entity.HasOne(d => d.User).WithMany(p => p.PasswordHistory).HasConstraintName("FK_PasswordHistory_Users");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.Property(e => e.ViewOrder).HasDefaultValue(9999);
        });

        modelBuilder.Entity<PersonaBarExtensions>(entity =>
        {
            entity.Property(e => e.Enabled).HasDefaultValue(true);

            entity.HasOne(d => d.Menu).WithMany(p => p.PersonaBarExtensions).HasConstraintName("FK_PersonaBarExtensions_MenuId");
        });

        modelBuilder.Entity<PersonaBarMenu>(entity =>
        {
            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasConstraintName("FK_PersonaBarMenu_ParentId");
        });

        modelBuilder.Entity<PersonaBarMenuDefaultPermissions>(entity =>
        {
            entity.HasOne(d => d.Menu).WithOne(p => p.PersonaBarMenuDefaultPermissions).HasConstraintName("FK_PersonaBarMenuDefaultPermissions_MenuId");
        });

        modelBuilder.Entity<PersonaBarMenuPermission>(entity =>
        {
            entity.HasOne(d => d.Menu).WithMany(p => p.PersonaBarMenuPermission).HasConstraintName("FK_PersonaBarMenuPermission_MenuId");

            entity.HasOne(d => d.Permission).WithMany(p => p.PersonaBarMenuPermission).HasConstraintName("FK_PersonaBarMenuPermission_Permission");

            entity.HasOne(d => d.Portal).WithMany(p => p.PersonaBarMenuPermission)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PersonaBarMenuPermission_Portals");

            entity.HasOne(d => d.Role).WithMany(p => p.PersonaBarMenuPermission).HasConstraintName("FK_PersonaBarMenuPermission_Roles");

            entity.HasOne(d => d.User).WithMany(p => p.PersonaBarMenuPermission)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PersonaBarMenuPermission_Users");
        });

        modelBuilder.Entity<PersonaBarPermission>(entity =>
        {
            entity.Property(e => e.ViewOrder).HasDefaultValue(9999);

            entity.HasOne(d => d.Menu).WithMany(p => p.PersonaBarPermission).HasConstraintName("FK_PersonaBarPermission_MenuId");
        });

        modelBuilder.Entity<PortalAlias>(entity =>
        {
            entity.HasOne(d => d.Portal).WithMany(p => p.PortalAlias).HasConstraintName("FK_PortalAlias_Portals");
        });

        modelBuilder.Entity<PortalDesktopModules>(entity =>
        {
            entity.HasOne(d => d.DesktopModule).WithMany(p => p.PortalDesktopModules).HasConstraintName("FK_PortalDesktopModules_DesktopModules");

            entity.HasOne(d => d.Portal).WithMany(p => p.PortalDesktopModules).HasConstraintName("FK_PortalDesktopModules_Portals");
        });

        modelBuilder.Entity<PortalGroups>(entity =>
        {
            entity.HasKey(e => e.PortalGroupId).HasName("PK_PortalGroup");
        });

        modelBuilder.Entity<PortalLanguages>(entity =>
        {
            entity.HasOne(d => d.Language).WithMany(p => p.PortalLanguages).HasConstraintName("FK_PortalLanguages_PortalLanguages");

            entity.HasOne(d => d.Portal).WithMany(p => p.PortalLanguages).HasConstraintName("FK_PortalLanguages_Portals");
        });

        modelBuilder.Entity<PortalLocalization>(entity =>
        {
            entity.HasOne(d => d.Portal).WithMany(p => p.PortalLocalization).HasConstraintName("FK_PortalLocalization_Portals");
        });

        modelBuilder.Entity<PortalPermission>(entity =>
        {
            entity.HasIndex(e => new { e.RoleId, e.PortalId, e.PermissionId }, "IX_PortalPermission_Roles")
                .IsUnique()
                .HasFilter("([RoleID] IS NOT NULL)");

            entity.HasIndex(e => new { e.UserId, e.PortalId, e.PermissionId }, "IX_PortalPermission_Users")
                .IsUnique()
                .HasFilter("([UserID] IS NOT NULL)");

            entity.HasOne(d => d.Permission).WithMany(p => p.PortalPermission)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PortalPermission_PermissionId");

            entity.HasOne(d => d.Portal).WithMany(p => p.PortalPermission).HasConstraintName("FK_PortalPermission_PortalId");

            entity.HasOne(d => d.Role).WithMany(p => p.PortalPermission).HasConstraintName("FK_PortalPermission_RoleId");

            entity.HasOne(d => d.User).WithMany(p => p.PortalPermission).HasConstraintName("FK_PortalPermission_UserId");
        });

        modelBuilder.Entity<PortalSettings>(entity =>
        {
            entity.HasKey(e => e.PortalSettingId).IsClustered(false);

            entity.HasIndex(e => new { e.PortalId, e.CultureCode, e.SettingName }, "IX_PortalSettings")
                .IsUnique()
                .IsClustered();

            entity.HasOne(d => d.Portal).WithMany(p => p.PortalSettings).HasConstraintName("FK_PortalSettings_Portals");
        });

        modelBuilder.Entity<Portals>(entity =>
        {
            entity.Property(e => e.Currency).IsFixedLength();
            entity.Property(e => e.DefaultLanguage).HasDefaultValue("en-US");
            entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.HomeDirectory).HasDefaultValue("");
            entity.Property(e => e.TimezoneOffset).HasDefaultValue(-8);
        });

        modelBuilder.Entity<ProductsToOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Products__3213E83FB851C137");
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.HasOne(d => d.Portal).WithMany(p => p.Profile).HasConstraintName("FK_Profile_Portals");

            entity.HasOne(d => d.User).WithMany(p => p.Profile).HasConstraintName("FK_Profile_Users");
        });

        modelBuilder.Entity<ProfilePropertyDefinition>(entity =>
        {
            entity.HasOne(d => d.Portal).WithMany(p => p.ProfilePropertyDefinition)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProfilePropertyDefinition_Portals");
        });

        modelBuilder.Entity<RedirectMessages>(entity =>
        {
            entity.Property(e => e.MessageId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreatedOnDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<RelationshipTypes>(entity =>
        {
            entity.Property(e => e.CreatedOnDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LastModifiedOnDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Relationships>(entity =>
        {
            entity.Property(e => e.CreatedOnDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LastModifiedOnDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Portal).WithMany(p => p.Relationships)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Relationships_Portals");

            entity.HasOne(d => d.RelationshipType).WithMany(p => p.Relationships).HasConstraintName("FK_Relationships_RelationshipTypes");

            entity.HasOne(d => d.User).WithMany(p => p.Relationships)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Relationships_Users");
        });

        modelBuilder.Entity<RoleGroups>(entity =>
        {
            entity.HasOne(d => d.Portal).WithMany(p => p.RoleGroups).HasConstraintName("FK_RoleGroups_Portals");
        });

        modelBuilder.Entity<RoleSettings>(entity =>
        {
            entity.Property(e => e.CreatedOnDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LastModifiedOnDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Roles>(entity =>
        {
            entity.Property(e => e.BillingFrequency).IsFixedLength();
            entity.Property(e => e.ServiceFee).HasDefaultValue(0m);
            entity.Property(e => e.Status).HasDefaultValue(1);
            entity.Property(e => e.TrialFrequency).IsFixedLength();

            entity.HasOne(d => d.Portal).WithMany(p => p.Roles)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Roles_Portals");

            entity.HasOne(d => d.RoleGroup).WithMany(p => p.Roles).HasConstraintName("FK_Roles_RoleGroups");
        });

        modelBuilder.Entity<ScheduleHistory>(entity =>
        {
            entity.HasOne(d => d.Schedule).WithMany(p => p.ScheduleHistory).HasConstraintName("FK_ScheduleHistory_Schedule");
        });

        modelBuilder.Entity<ScheduleItemSettings>(entity =>
        {
            entity.HasOne(d => d.Schedule).WithMany(p => p.ScheduleItemSettings).HasConstraintName("FK_ScheduleItemSettings_Schedule");
        });

        modelBuilder.Entity<SearchDeletedItems>(entity =>
        {
            entity.Property(e => e.DateCreated).HasDefaultValueSql("(getutcdate())");
        });

        modelBuilder.Entity<SearchIndexer>(entity =>
        {
            entity.Property(e => e.SearchIndexerAssemblyQualifiedName).IsFixedLength();
        });

        modelBuilder.Entity<SearchTypes>(entity =>
        {
            entity.Property(e => e.IsPrivate).HasDefaultValue(false);
        });

        modelBuilder.Entity<SiteLog>(entity =>
        {
            entity.HasOne(d => d.Portal).WithMany(p => p.SiteLog).HasConstraintName("FK_SiteLog_Portals");
        });

        modelBuilder.Entity<SkinControls>(entity =>
        {
            entity.Property(e => e.PackageId).HasDefaultValue(-1);

            entity.HasOne(d => d.Package).WithMany(p => p.SkinControls).HasConstraintName("FK_SkinControls_Packages");
        });

        modelBuilder.Entity<SkinPackages>(entity =>
        {
            entity.HasOne(d => d.Package).WithMany(p => p.SkinPackages).HasConstraintName("FK_SkinPackages_Packages");
        });

        modelBuilder.Entity<Skins>(entity =>
        {
            entity.HasOne(d => d.SkinPackage).WithMany(p => p.Skins).HasConstraintName("FK_Skins_SkinPackages");
        });

        modelBuilder.Entity<Sqlqueries>(entity =>
        {
            entity.HasKey(e => e.QueryId).HasName("PK_SavedQueries");
        });

        modelBuilder.Entity<SystemMessages>(entity =>
        {
            entity.HasOne(d => d.Portal).WithMany(p => p.SystemMessages)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SystemMessages_Portals");
        });

        modelBuilder.Entity<TabAliasSkins>(entity =>
        {
            entity.HasKey(e => e.TabAliasSkinId).HasName("PK_TabAliasSkin");
        });

        modelBuilder.Entity<TabModuleSettings>(entity =>
        {
            entity.HasOne(d => d.TabModule).WithMany(p => p.TabModuleSettings).HasConstraintName("FK_TabModuleSettings_TabModules");
        });

        modelBuilder.Entity<TabModules>(entity =>
        {
            entity.Property(e => e.CreatedOnDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.DisplayPrint).HasDefaultValue(true);
            entity.Property(e => e.DisplaySyndicate).HasDefaultValue(true);
            entity.Property(e => e.DisplayTitle).HasDefaultValue(true);
            entity.Property(e => e.LastModifiedOnDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LocalizedVersionGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.VersionGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Module).WithMany(p => p.TabModules).HasConstraintName("FK_TabModules_Modules");

            entity.HasOne(d => d.Tab).WithMany(p => p.TabModules).HasConstraintName("FK_TabModules_Tabs");
        });

        modelBuilder.Entity<TabPermission>(entity =>
        {
            entity.HasIndex(e => new { e.RoleId, e.TabId, e.PermissionId }, "IX_TabPermission_Roles")
                .IsUnique()
                .HasFilter("([RoleID] IS NOT NULL)");

            entity.HasIndex(e => new { e.UserId, e.TabId, e.PermissionId }, "IX_TabPermission_Users")
                .IsUnique()
                .HasFilter("([UserID] IS NOT NULL)");

            entity.HasOne(d => d.Permission).WithMany(p => p.TabPermission).HasConstraintName("FK_TabPermission_Permission");

            entity.HasOne(d => d.Role).WithMany(p => p.TabPermission).HasConstraintName("FK_TabPermission_Roles");

            entity.HasOne(d => d.Tab).WithMany(p => p.TabPermission).HasConstraintName("FK_TabPermission_Tabs");

            entity.HasOne(d => d.User).WithMany(p => p.TabPermission)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TabPermission_Users");
        });

        modelBuilder.Entity<TabSettings>(entity =>
        {
            entity.HasKey(e => new { e.TabId, e.SettingName }).IsClustered(false);

            entity.HasIndex(e => new { e.TabId, e.SettingName }, "IX_TabSettings_TabID_SettingName")
                .IsUnique()
                .IsClustered();

            entity.HasOne(d => d.Tab).WithMany(p => p.TabSettings).HasConstraintName("FK_TabSettings_Tabs");
        });

        modelBuilder.Entity<TabUrls>(entity =>
        {
            entity.HasKey(e => new { e.TabId, e.SeqNum }).HasName("PK_TabRedirect");

            entity.HasOne(d => d.Tab).WithMany(p => p.TabUrls).HasConstraintName("FK_TabUrls_Tabs");
        });

        modelBuilder.Entity<TabVersionDetails>(entity =>
        {
            entity.HasOne(d => d.TabVersion).WithMany(p => p.TabVersionDetails).HasConstraintName("FK_TabVersionDetails_TabVersionId");
        });

        modelBuilder.Entity<TabVersions>(entity =>
        {
            entity.HasOne(d => d.Tab).WithMany(p => p.TabVersions).HasConstraintName("FK_TabVersions_TabId");
        });

        modelBuilder.Entity<Tabs>(entity =>
        {
            entity.HasIndex(e => e.ContentItemId, "IX_Tabs_ContentID").HasFilter("([ContentItemId] IS NOT NULL)");

            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.LocalizedVersionGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.SiteMapPriority).HasDefaultValueSql("((0.5))");
            entity.Property(e => e.TabPath).HasDefaultValue("");
            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.VersionGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.ContentItem).WithMany(p => p.Tabs).HasConstraintName("FK_Tabs_ContentItems");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasConstraintName("FK_Tabs_Tabs");

            entity.HasOne(d => d.Portal).WithMany(p => p.Tabs)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Tabs_Portals");
        });

        modelBuilder.Entity<TaxonomyScopeTypes>(entity =>
        {
            entity.HasKey(e => e.ScopeTypeId).HasName("PK_ScopeTypes");
        });

        modelBuilder.Entity<TaxonomyTerms>(entity =>
        {
            entity.HasOne(d => d.ParentTerm).WithMany(p => p.InverseParentTerm).HasConstraintName("FK_Taxonomy_Terms_Taxonomy_Terms");

            entity.HasOne(d => d.Vocabulary).WithMany(p => p.TaxonomyTerms).HasConstraintName("FK_Taxonomy_Terms_Taxonomy_Vocabularies");
        });

        modelBuilder.Entity<TaxonomyVocabularies>(entity =>
        {
            entity.HasKey(e => e.VocabularyId).HasName("PK_Taxonomy_Vocabulary");

            entity.HasOne(d => d.ScopeType).WithMany(p => p.TaxonomyVocabularies).HasConstraintName("FK_Taxonomy_Vocabularies_Taxonomy_ScopeTypes");

            entity.HasOne(d => d.VocabularyType).WithMany(p => p.TaxonomyVocabularies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Taxonomy_Vocabularies_Taxonomy_VocabularyTypes");
        });

        modelBuilder.Entity<TaxonomyVocabularyTypes>(entity =>
        {
            entity.HasKey(e => e.VocabularyTypeId).HasName("PK_Taxonomy_VocabularyType");
        });

        modelBuilder.Entity<UrlLog>(entity =>
        {
            entity.HasOne(d => d.UrlTracking).WithMany(p => p.UrlLog).HasConstraintName("FK_UrlLog_UrlTracking");
        });

        modelBuilder.Entity<UrlTracking>(entity =>
        {
            entity.Property(e => e.TrackClicks).HasDefaultValue(true);
            entity.Property(e => e.UrlType).IsFixedLength();

            entity.HasOne(d => d.Portal).WithMany(p => p.UrlTracking)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_UrlTracking_Portals");
        });

        modelBuilder.Entity<Urls>(entity =>
        {
            entity.HasOne(d => d.Portal).WithMany(p => p.Urls)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Urls_Portals");
        });

        modelBuilder.Entity<UserAuthentication>(entity =>
        {
            entity.HasOne(d => d.User).WithMany(p => p.UserAuthentication).HasConstraintName("FK_UserAuthentication_Users");
        });

        modelBuilder.Entity<UserPortals>(entity =>
        {
            entity.Property(e => e.Authorised).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.UserPortalId).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Portal).WithMany(p => p.UserPortals).HasConstraintName("FK_UserPortals_Portals");

            entity.HasOne(d => d.User).WithMany(p => p.UserPortals).HasConstraintName("FK_UserPortals_Users");
        });

        modelBuilder.Entity<UserProfile>(entity =>
        {
            entity.HasOne(d => d.PropertyDefinition).WithMany(p => p.UserProfile).HasConstraintName("FK_UserProfile_ProfilePropertyDefinition");

            entity.HasOne(d => d.User).WithMany(p => p.UserProfile).HasConstraintName("FK_UserProfile_Users");
        });

        modelBuilder.Entity<UserRelationshipPreferences>(entity =>
        {
            entity.Property(e => e.PreferenceId).ValueGeneratedOnAdd();
            entity.Property(e => e.CreatedOnDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LastModifiedOnDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Relationship).WithMany(p => p.UserRelationshipPreferences).HasConstraintName("FK_UserRelationshipPreferences_Relationships");

            entity.HasOne(d => d.User).WithMany(p => p.UserRelationshipPreferences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRelationshipPreferences_Users");
        });

        modelBuilder.Entity<UserRelationships>(entity =>
        {
            entity.Property(e => e.CreatedOnDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LastModifiedOnDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.RelatedUser).WithMany(p => p.UserRelationshipsRelatedUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRelationships_Users_OnRelatedUser");

            entity.HasOne(d => d.Relationship).WithMany(p => p.UserRelationships).HasConstraintName("FK_UserRelationships_Relationships");

            entity.HasOne(d => d.User).WithMany(p => p.UserRelationshipsUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRelationships_Users");
        });

        modelBuilder.Entity<UserRoles>(entity =>
        {
            entity.Property(e => e.Status).HasDefaultValue(1);

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoles).HasConstraintName("FK_UserRoles_Roles");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoles).HasConstraintName("FK_UserRoles_Users");
        });

        modelBuilder.Entity<Users>(entity =>
        {
            entity.HasIndex(e => new { e.FirstName, e.IsSuperUser, e.IsDeleted }, "IX_Users_FirstName").HasFilter("([FirstName] IS NOT NULL AND [FirstName]<>N'')");

            entity.HasIndex(e => new { e.IsSuperUser, e.Username }, "IX_Users_IsSuperuser")
                .IsUnique()
                .IsDescending(true, false)
                .HasFilter("([IsSuperUser]=(1))");

            entity.HasIndex(e => new { e.LastName, e.IsSuperUser, e.IsDeleted }, "IX_Users_LastName").HasFilter("([LastName] IS NOT NULL AND [LastName]<>N'')");

            entity.Property(e => e.DisplayName).HasDefaultValue("");
        });

        modelBuilder.Entity<UsersOnline>(entity =>
        {
            entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LastActiveDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Portal).WithMany(p => p.UsersOnline).HasConstraintName("FK_UsersOnline_Portals");

            entity.HasOne(d => d.User).WithMany(p => p.UsersOnline).HasConstraintName("FK_UsersOnline_Users");
        });

        modelBuilder.Entity<VwAspnetApplications>(entity =>
        {
            entity.ToView("vw_aspnet_Applications");
        });

        modelBuilder.Entity<VwAspnetMembershipUsers>(entity =>
        {
            entity.ToView("vw_aspnet_MembershipUsers");
        });

        modelBuilder.Entity<VwAspnetUsers>(entity =>
        {
            entity.ToView("vw_aspnet_Users");
        });

        modelBuilder.Entity<VwContentWorkflowStatePermissions>(entity =>
        {
            entity.ToView("vw_ContentWorkflowStatePermissions");
        });

        modelBuilder.Entity<VwContentWorkflowUsage>(entity =>
        {
            entity.ToView("vw_ContentWorkflowUsage");
        });

        modelBuilder.Entity<VwCoreMessagingMessages>(entity =>
        {
            entity.ToView("vw_CoreMessaging_Messages");
        });

        modelBuilder.Entity<VwDesktopModulePermissions>(entity =>
        {
            entity.ToView("vw_DesktopModulePermissions");
        });

        modelBuilder.Entity<VwDesktopModules>(entity =>
        {
            entity.ToView("vw_DesktopModules");
        });

        modelBuilder.Entity<VwEventLog>(entity =>
        {
            entity.ToView("vw_EventLog");
        });

        modelBuilder.Entity<VwExtensionUrlProviders>(entity =>
        {
            entity.ToView("vw_ExtensionUrlProviders");
        });

        modelBuilder.Entity<VwFiles>(entity =>
        {
            entity.ToView("vw_Files");
        });

        modelBuilder.Entity<VwFolderPermissions>(entity =>
        {
            entity.ToView("vw_FolderPermissions");
        });

        modelBuilder.Entity<VwLists>(entity =>
        {
            entity.ToView("vw_Lists");
        });

        modelBuilder.Entity<VwMasterPortals>(entity =>
        {
            entity.ToView("vw_MasterPortals");
        });

        modelBuilder.Entity<VwMessagesForDispatch>(entity =>
        {
            entity.ToView("vw_MessagesForDispatch");
        });

        modelBuilder.Entity<VwModulePermissions>(entity =>
        {
            entity.ToView("vw_ModulePermissions");
        });

        modelBuilder.Entity<VwModules>(entity =>
        {
            entity.ToView("vw_Modules");
        });

        modelBuilder.Entity<VwPersonaBarMenuPermissions>(entity =>
        {
            entity.ToView("vw_PersonaBarMenuPermissions");
        });

        modelBuilder.Entity<VwPortalPermissions>(entity =>
        {
            entity.ToView("vw_PortalPermissions");
        });

        modelBuilder.Entity<VwPortals>(entity =>
        {
            entity.ToView("vw_Portals");

            entity.Property(e => e.Currency).IsFixedLength();
        });

        modelBuilder.Entity<VwPortalsDefaultLanguage>(entity =>
        {
            entity.ToView("vw_PortalsDefaultLanguage");

            entity.Property(e => e.Currency).IsFixedLength();
        });

        modelBuilder.Entity<VwProfile>(entity =>
        {
            entity.ToView("vw_Profile");
        });

        modelBuilder.Entity<VwPublishedFiles>(entity =>
        {
            entity.ToView("vw_PublishedFiles");
        });

        modelBuilder.Entity<VwTabModules>(entity =>
        {
            entity.ToView("vw_TabModules");
        });

        modelBuilder.Entity<VwTabPermissions>(entity =>
        {
            entity.ToView("vw_TabPermissions");
        });

        modelBuilder.Entity<VwTabs>(entity =>
        {
            entity.ToView("vw_Tabs");
        });

        modelBuilder.Entity<VwUserRoles>(entity =>
        {
            entity.ToView("vw_UserRoles");

            entity.Property(e => e.BillingFrequency).IsFixedLength();
            entity.Property(e => e.TrialFrequency).IsFixedLength();
        });

        modelBuilder.Entity<VwUsers>(entity =>
        {
            entity.ToView("vw_Users");
        });

        modelBuilder.Entity<WebServers>(entity =>
        {
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.IisappName).HasDefaultValue("");
        });

        modelBuilder.Entity<WnsInjInjection>(entity =>
        {
            entity.Property(e => e.InjectTop).HasDefaultValue(true);

            entity.HasOne(d => d.Module).WithMany(p => p.WnsInjInjection).HasConstraintName("FK_wns_inj_injection_moduleid");
        });

        modelBuilder.Entity<WorkflowStates>(entity =>
        {
            entity.HasOne(d => d.Workflow).WithMany(p => p.WorkflowStates).HasConstraintName("FK_WorkflowStates_Workflow");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
