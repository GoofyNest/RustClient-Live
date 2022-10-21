public sealed class KWSInterface : Handle // TypeDefIndex: 9325
{
	public const int AddnotifypermissionsupdatereceivedApiLatest = 1;
	public const int CopypermissionbyindexApiLatest = 1;
	public const int CreateuserApiLatest = 1;
	public const int GetpermissionbykeyApiLatest = 1;
	public const int GetpermissionscountApiLatest = 1;
	public const int MaxPermissionLength = 32;
	public const int MaxPermissions = 16;
	public const int PermissionstatusApiLatest = 1;
	public const int QueryagegateApiLatest = 1;
	public const int QuerypermissionsApiLatest = 1;
	public const int RequestpermissionsApiLatest = 1;
	public const int UpdateparentemailApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public ulong AddNotifyPermissionsUpdateReceived(ref AddNotifyPermissionsUpdateReceivedOptions options, object clientData, OnPermissionsUpdateReceivedCallback notificationFn) { }

	public Result CopyPermissionByIndex(ref CopyPermissionByIndexOptions options, out Nullable<PermissionStatus> outPermission) { }

	public void CreateUser(ref CreateUserOptions options, object clientData, OnCreateUserCallback completionDelegate) { }

	public Result GetPermissionByKey(ref GetPermissionByKeyOptions options, out KWSPermissionStatus outPermission) { }

	public int GetPermissionsCount(ref GetPermissionsCountOptions options) { }

	public void QueryAgeGate(ref QueryAgeGateOptions options, object clientData, OnQueryAgeGateCallback completionDelegate) { }

	public void QueryPermissions(ref QueryPermissionsOptions options, object clientData, OnQueryPermissionsCallback completionDelegate) { }

	public void RemoveNotifyPermissionsUpdateReceived(ulong inId) { }

	public void RequestPermissions(ref RequestPermissionsOptions options, object clientData, OnRequestPermissionsCallback completionDelegate) { }

	public void UpdateParentEmail(ref UpdateParentEmailOptions options, object clientData, OnUpdateParentEmailCallback completionDelegate) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnCreateUserCallbackInternalImplementation(ref CreateUserCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnPermissionsUpdateReceivedCallbackInternalImplementation(ref PermissionsUpdateReceivedCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnQueryAgeGateCallbackInternalImplementation(ref QueryAgeGateCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnQueryPermissionsCallbackInternalImplementation(ref QueryPermissionsCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnRequestPermissionsCallbackInternalImplementation(ref RequestPermissionsCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnUpdateParentEmailCallbackInternalImplementation(ref UpdateParentEmailCallbackInfoInternal data) { }

}

