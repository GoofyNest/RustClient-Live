public sealed class UserInfoInterface : Handle // TypeDefIndex: 8331
{
	public const int CopyexternaluserinfobyaccountidApiLatest = 1;
	public const int CopyexternaluserinfobyaccounttypeApiLatest = 1;
	public const int CopyexternaluserinfobyindexApiLatest = 1;
	public const int CopyuserinfoApiLatest = 3;
	public const int ExternaluserinfoApiLatest = 2;
	public const int GetexternaluserinfocountApiLatest = 1;
	public const int MaxDisplaynameCharacters = 16;
	public const int MaxDisplaynameUtf8Length = 64;
	public const int QueryuserinfoApiLatest = 1;
	public const int QueryuserinfobydisplaynameApiLatest = 1;
	public const int QueryuserinfobyexternalaccountApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public Result CopyExternalUserInfoByAccountId(ref CopyExternalUserInfoByAccountIdOptions options, out Nullable<ExternalUserInfo> outExternalUserInfo) { }

	public Result CopyExternalUserInfoByAccountType(ref CopyExternalUserInfoByAccountTypeOptions options, out Nullable<ExternalUserInfo> outExternalUserInfo) { }

	public Result CopyExternalUserInfoByIndex(ref CopyExternalUserInfoByIndexOptions options, out Nullable<ExternalUserInfo> outExternalUserInfo) { }

	public Result CopyUserInfo(ref CopyUserInfoOptions options, out Nullable<UserInfoData> outUserInfo) { }

	public uint GetExternalUserInfoCount(ref GetExternalUserInfoCountOptions options) { }

	public void QueryUserInfo(ref QueryUserInfoOptions options, object clientData, OnQueryUserInfoCallback completionDelegate) { }

	public void QueryUserInfoByDisplayName(ref QueryUserInfoByDisplayNameOptions options, object clientData, OnQueryUserInfoByDisplayNameCallback completionDelegate) { }

	public void QueryUserInfoByExternalAccount(ref QueryUserInfoByExternalAccountOptions options, object clientData, OnQueryUserInfoByExternalAccountCallback completionDelegate) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnQueryUserInfoByDisplayNameCallbackInternalImplementation(ref QueryUserInfoByDisplayNameCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnQueryUserInfoByExternalAccountCallbackInternalImplementation(ref QueryUserInfoByExternalAccountCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnQueryUserInfoCallbackInternalImplementation(ref QueryUserInfoCallbackInfoInternal data) { }

}

