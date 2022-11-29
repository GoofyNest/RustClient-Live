public sealed class AuthInterface : Handle // TypeDefIndex: 9649
{
	public const int AccountfeaturerestrictedinfoApiLatest = 1;
	public const int AddnotifyloginstatuschangedApiLatest = 1;
	public const int CopyidtokenApiLatest = 1;
	public const int CopyuserauthtokenApiLatest = 1;
	public const int CredentialsApiLatest = 3;
	public const int DeletepersistentauthApiLatest = 2;
	public const int IdtokenApiLatest = 1;
	public const int LinkaccountApiLatest = 1;
	public const int LoginApiLatest = 2;
	public const int LogoutApiLatest = 1;
	public const int PingrantinfoApiLatest = 2;
	public const int QueryidtokenApiLatest = 1;
	public const int TokenApiLatest = 2;
	public const int VerifyidtokenApiLatest = 1;
	public const int VerifyuserauthApiLatest = 1;
	public const int IosCredentialssystemauthcredentialsoptionsApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public ulong AddNotifyLoginStatusChanged(ref AddNotifyLoginStatusChangedOptions options, object clientData, OnLoginStatusChangedCallback notification) { }

	public Result CopyIdToken(ref CopyIdTokenOptions options, out Nullable<IdToken> outIdToken) { }

	public Result CopyUserAuthToken(ref CopyUserAuthTokenOptions options, EpicAccountId localUserId, out Nullable<Token> outUserAuthToken) { }

	public void DeletePersistentAuth(ref DeletePersistentAuthOptions options, object clientData, OnDeletePersistentAuthCallback completionDelegate) { }

	public EpicAccountId GetLoggedInAccountByIndex(int index) { }

	public int GetLoggedInAccountsCount() { }

	public LoginStatus GetLoginStatus(EpicAccountId localUserId) { }

	public EpicAccountId GetMergedAccountByIndex(EpicAccountId localUserId, uint index) { }

	public uint GetMergedAccountsCount(EpicAccountId localUserId) { }

	public Result GetSelectedAccountId(EpicAccountId localUserId, out EpicAccountId outSelectedAccountId) { }

	public void LinkAccount(ref LinkAccountOptions options, object clientData, OnLinkAccountCallback completionDelegate) { }

	public void Login(ref LoginOptions options, object clientData, OnLoginCallback completionDelegate) { }

	public void Logout(ref LogoutOptions options, object clientData, OnLogoutCallback completionDelegate) { }

	public void QueryIdToken(ref QueryIdTokenOptions options, object clientData, OnQueryIdTokenCallback completionDelegate) { }

	public void RemoveNotifyLoginStatusChanged(ulong inId) { }

	public void VerifyIdToken(ref VerifyIdTokenOptions options, object clientData, OnVerifyIdTokenCallback completionDelegate) { }

	public void VerifyUserAuth(ref VerifyUserAuthOptions options, object clientData, OnVerifyUserAuthCallback completionDelegate) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnDeletePersistentAuthCallbackInternalImplementation(ref DeletePersistentAuthCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnLinkAccountCallbackInternalImplementation(ref LinkAccountCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnLoginCallbackInternalImplementation(ref LoginCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnLoginStatusChangedCallbackInternalImplementation(ref LoginStatusChangedCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnLogoutCallbackInternalImplementation(ref LogoutCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnQueryIdTokenCallbackInternalImplementation(ref QueryIdTokenCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnVerifyIdTokenCallbackInternalImplementation(ref VerifyIdTokenCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnVerifyUserAuthCallbackInternalImplementation(ref VerifyUserAuthCallbackInfoInternal data) { }

	public void Login(ref IOSLoginOptions options, object clientData, OnLoginCallback completionDelegate) { }

}

