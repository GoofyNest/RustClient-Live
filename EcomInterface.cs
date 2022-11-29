public sealed class EcomInterface : Handle // TypeDefIndex: 9455
{
	public const int CatalogitemApiLatest = 1;
	public const int CatalogitemEntitlementendtimestampUndefined = -1;
	public const int CatalogofferApiLatest = 5;
	public const int CatalogofferEffectivedatetimestampUndefined = -1;
	public const int CatalogofferExpirationtimestampUndefined = -1;
	public const int CatalogofferReleasedatetimestampUndefined = -1;
	public const int CatalogreleaseApiLatest = 1;
	public const int CheckoutApiLatest = 1;
	public const int CheckoutMaxEntries = 10;
	public const int CheckoutentryApiLatest = 1;
	public const int CopyentitlementbyidApiLatest = 2;
	public const int CopyentitlementbyindexApiLatest = 1;
	public const int CopyentitlementbynameandindexApiLatest = 1;
	public const int CopyitembyidApiLatest = 1;
	public const int CopyitemimageinfobyindexApiLatest = 1;
	public const int CopyitemreleasebyindexApiLatest = 1;
	public const int CopylastredeemedentitlementbyindexApiLatest = 1;
	public const int CopyofferbyidApiLatest = 3;
	public const int CopyofferbyindexApiLatest = 3;
	public const int CopyofferimageinfobyindexApiLatest = 1;
	public const int CopyofferitembyindexApiLatest = 1;
	public const int CopytransactionbyidApiLatest = 1;
	public const int CopytransactionbyindexApiLatest = 1;
	public const int EntitlementApiLatest = 2;
	public const int EntitlementEndtimestampUndefined = -1;
	public const int EntitlementidMaxLength = 32;
	public const int GetentitlementsbynamecountApiLatest = 1;
	public const int GetentitlementscountApiLatest = 1;
	public const int GetitemimageinfocountApiLatest = 1;
	public const int GetitemreleasecountApiLatest = 1;
	public const int GetlastredeemedentitlementscountApiLatest = 1;
	public const int GetoffercountApiLatest = 1;
	public const int GetofferimageinfocountApiLatest = 1;
	public const int GetofferitemcountApiLatest = 1;
	public const int GettransactioncountApiLatest = 1;
	public const int ItemownershipApiLatest = 1;
	public const int KeyimageinfoApiLatest = 1;
	public const int QueryentitlementsApiLatest = 2;
	public const int QueryentitlementsMaxEntitlementIds = 32;
	public const int QueryoffersApiLatest = 1;
	public const int QueryownershipApiLatest = 2;
	public const int QueryownershipMaxCatalogIds = 50;
	public const int QueryownershiptokenApiLatest = 2;
	public const int QueryownershiptokenMaxCatalogitemIds = 32;
	public const int RedeementitlementsApiLatest = 2;
	public const int RedeementitlementsMaxIds = 32;
	public const int TransactionidMaximumLength = 64;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public void Checkout(ref CheckoutOptions options, object clientData, OnCheckoutCallback completionDelegate) { }

	public Result CopyEntitlementById(ref CopyEntitlementByIdOptions options, out Nullable<Entitlement> outEntitlement) { }

	public Result CopyEntitlementByIndex(ref CopyEntitlementByIndexOptions options, out Nullable<Entitlement> outEntitlement) { }

	public Result CopyEntitlementByNameAndIndex(ref CopyEntitlementByNameAndIndexOptions options, out Nullable<Entitlement> outEntitlement) { }

	public Result CopyItemById(ref CopyItemByIdOptions options, out Nullable<CatalogItem> outItem) { }

	public Result CopyItemImageInfoByIndex(ref CopyItemImageInfoByIndexOptions options, out Nullable<KeyImageInfo> outImageInfo) { }

	public Result CopyItemReleaseByIndex(ref CopyItemReleaseByIndexOptions options, out Nullable<CatalogRelease> outRelease) { }

	public Result CopyLastRedeemedEntitlementByIndex(ref CopyLastRedeemedEntitlementByIndexOptions options, out Utf8String outRedeemedEntitlementId) { }

	public Result CopyOfferById(ref CopyOfferByIdOptions options, out Nullable<CatalogOffer> outOffer) { }

	public Result CopyOfferByIndex(ref CopyOfferByIndexOptions options, out Nullable<CatalogOffer> outOffer) { }

	public Result CopyOfferImageInfoByIndex(ref CopyOfferImageInfoByIndexOptions options, out Nullable<KeyImageInfo> outImageInfo) { }

	public Result CopyOfferItemByIndex(ref CopyOfferItemByIndexOptions options, out Nullable<CatalogItem> outItem) { }

	public Result CopyTransactionById(ref CopyTransactionByIdOptions options, out Transaction outTransaction) { }

	public Result CopyTransactionByIndex(ref CopyTransactionByIndexOptions options, out Transaction outTransaction) { }

	public uint GetEntitlementsByNameCount(ref GetEntitlementsByNameCountOptions options) { }

	public uint GetEntitlementsCount(ref GetEntitlementsCountOptions options) { }

	public uint GetItemImageInfoCount(ref GetItemImageInfoCountOptions options) { }

	public uint GetItemReleaseCount(ref GetItemReleaseCountOptions options) { }

	public uint GetLastRedeemedEntitlementsCount(ref GetLastRedeemedEntitlementsCountOptions options) { }

	public uint GetOfferCount(ref GetOfferCountOptions options) { }

	public uint GetOfferImageInfoCount(ref GetOfferImageInfoCountOptions options) { }

	public uint GetOfferItemCount(ref GetOfferItemCountOptions options) { }

	public uint GetTransactionCount(ref GetTransactionCountOptions options) { }

	public void QueryEntitlements(ref QueryEntitlementsOptions options, object clientData, OnQueryEntitlementsCallback completionDelegate) { }

	public void QueryOffers(ref QueryOffersOptions options, object clientData, OnQueryOffersCallback completionDelegate) { }

	public void QueryOwnership(ref QueryOwnershipOptions options, object clientData, OnQueryOwnershipCallback completionDelegate) { }

	public void QueryOwnershipToken(ref QueryOwnershipTokenOptions options, object clientData, OnQueryOwnershipTokenCallback completionDelegate) { }

	public void RedeemEntitlements(ref RedeemEntitlementsOptions options, object clientData, OnRedeemEntitlementsCallback completionDelegate) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnCheckoutCallbackInternalImplementation(ref CheckoutCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnQueryEntitlementsCallbackInternalImplementation(ref QueryEntitlementsCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnQueryOffersCallbackInternalImplementation(ref QueryOffersCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnQueryOwnershipCallbackInternalImplementation(ref QueryOwnershipCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnQueryOwnershipTokenCallbackInternalImplementation(ref QueryOwnershipTokenCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnRedeemEntitlementsCallbackInternalImplementation(ref RedeemEntitlementsCallbackInfoInternal data) { }

}

