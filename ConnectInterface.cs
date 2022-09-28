public sealed class ConnectInterface : Handle // TypeDefIndex: 9510
{
	public const int AddnotifyauthexpirationApiLatest = 1;
	public const int AddnotifyloginstatuschangedApiLatest = 1;
	public const int CopyidtokenApiLatest = 1;
	public const int CopyproductuserexternalaccountbyaccountidApiLatest = 1;
	public const int CopyproductuserexternalaccountbyaccounttypeApiLatest = 1;
	public const int CopyproductuserexternalaccountbyindexApiLatest = 1;
	public const int CopyproductuserinfoApiLatest = 1;
	public const int CreatedeviceidApiLatest = 1;
	public const int CreatedeviceidDevicemodelMaxLength = 64;
	public const int CreateuserApiLatest = 1;
	public const int CredentialsApiLatest = 1;
	public const int DeletedeviceidApiLatest = 1;
	public const int ExternalAccountIdMaxLength = 256;
	public const int ExternalaccountinfoApiLatest = 1;
	public const int GetexternalaccountmappingApiLatest = 1;
	public const int GetexternalaccountmappingsApiLatest = 1;
	public const int GetproductuserexternalaccountcountApiLatest = 1;
	public const int GetproductuseridmappingApiLatest = 1;
	public const int IdtokenApiLatest = 1;
	public const int LinkaccountApiLatest = 1;
	public const int LoginApiLatest = 2;
	public const int OnauthexpirationcallbackApiLatest = 1;
	public const int QueryexternalaccountmappingsApiLatest = 1;
	public const int QueryexternalaccountmappingsMaxAccountIds = 128;
	public const int QueryproductuseridmappingsApiLatest = 2;
	public const int TimeUndefined = -1;
	public const int TransferdeviceidaccountApiLatest = 1;
	public const int UnlinkaccountApiLatest = 1;
	public const int UserlogininfoApiLatest = 1;
	public const int UserlogininfoDisplaynameMaxLength = 32;
	public const int VerifyidtokenApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public ulong AddNotifyAuthExpiration(ref AddNotifyAuthExpirationOptions options, object clientData, OnAuthExpirationCallback notification) { }

	public ulong AddNotifyLoginStatusChanged(ref AddNotifyLoginStatusChangedOptions options, object clientData, OnLoginStatusChangedCallback notification) { }

	public Result CopyIdToken(ref CopyIdTokenOptions options, out Nullable<IdToken> outIdToken) { }

	public Result CopyProductUserExternalAccountByAccountId(ref CopyProductUserExternalAccountByAccountIdOptions options, out Nullable<ExternalAccountInfo> outExternalAccountInfo) { }

	public Result CopyProductUserExternalAccountByAccountType(ref CopyProductUserExternalAccountByAccountTypeOptions options, out Nullable<ExternalAccountInfo> outExternalAccountInfo) { }

	public Result CopyProductUserExternalAccountByIndex(ref CopyProductUserExternalAccountByIndexOptions options, out Nullable<ExternalAccountInfo> outExternalAccountInfo) { }

	public Result CopyProductUserInfo(ref CopyProductUserInfoOptions options, out Nullable<ExternalAccountInfo> outExternalAccountInfo) { }

	public void CreateDeviceId(ref CreateDeviceIdOptions options, object clientData, OnCreateDeviceIdCallback completionDelegate) { }

	public void CreateUser(ref CreateUserOptions options, object clientData, OnCreateUserCallback completionDelegate) { }

	public void DeleteDeviceId(ref DeleteDeviceIdOptions options, object clientData, OnDeleteDeviceIdCallback completionDelegate) { }

	public ProductUserId GetExternalAccountMapping(ref GetExternalAccountMappingsOptions options) { }

	public ProductUserId GetLoggedInUserByIndex(int index) { }

	public int GetLoggedInUsersCount() { }

	public LoginStatus GetLoginStatus(ProductUserId localUserId) { }

	public uint GetProductUserExternalAccountCount(ref GetProductUserExternalAccountCountOptions options) { }

	public Result GetProductUserIdMapping(ref GetProductUserIdMappingOptions options, out Utf8String outBuffer) { }

	public void LinkAccount(ref LinkAccountOptions options, object clientData, OnLinkAccountCallback completionDelegate) { }

	public void Login(ref LoginOptions options, object clientData, OnLoginCallback completionDelegate) { }

	public void QueryExternalAccountMappings(ref QueryExternalAccountMappingsOptions options, object clientData, OnQueryExternalAccountMappingsCallback completionDelegate) { }

	public void QueryProductUserIdMappings(ref QueryProductUserIdMappingsOptions options, object clientData, OnQueryProductUserIdMappingsCallback completionDelegate) { }

	public void RemoveNotifyAuthExpiration(ulong inId) { }

	public void RemoveNotifyLoginStatusChanged(ulong inId) { }

	public void TransferDeviceIdAccount(ref TransferDeviceIdAccountOptions options, object clientData, OnTransferDeviceIdAccountCallback completionDelegate) { }

	public void UnlinkAccount(ref UnlinkAccountOptions options, object clientData, OnUnlinkAccountCallback completionDelegate) { }

	public void VerifyIdToken(ref VerifyIdTokenOptions options, object clientData, OnVerifyIdTokenCallback completionDelegate) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnAuthExpirationCallbackInternalImplementation(ref AuthExpirationCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnCreateDeviceIdCallbackInternalImplementation(ref CreateDeviceIdCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnCreateUserCallbackInternalImplementation(ref CreateUserCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnDeleteDeviceIdCallbackInternalImplementation(ref DeleteDeviceIdCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnLinkAccountCallbackInternalImplementation(ref LinkAccountCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnLoginCallbackInternalImplementation(ref LoginCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnLoginStatusChangedCallbackInternalImplementation(ref LoginStatusChangedCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnQueryExternalAccountMappingsCallbackInternalImplementation(ref QueryExternalAccountMappingsCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnQueryProductUserIdMappingsCallbackInternalImplementation(ref QueryProductUserIdMappingsCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnTransferDeviceIdAccountCallbackInternalImplementation(ref TransferDeviceIdAccountCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnUnlinkAccountCallbackInternalImplementation(ref UnlinkAccountCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnVerifyIdTokenCallbackInternalImplementation(ref VerifyIdTokenCallbackInfoInternal data) { }

}

