public struct SendInviteCallbackInfo : ICallbackInfo // TypeDefIndex: 8542
{
	[CompilerGeneratedAttribute] 
	private Result <ResultCode>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }


	[CompilerGeneratedAttribute] 
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute] 
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref SendInviteCallbackInfoInternal other) { }

}

public struct SendInviteCallbackInfo : ICallbackInfo // TypeDefIndex: 9264
{
	[CompilerGeneratedAttribute] 
	private Result <ResultCode>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <LobbyId>k__BackingField; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String LobbyId { get; set; }


	[CompilerGeneratedAttribute] 
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute] 
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_LobbyId() { }

	[CompilerGeneratedAttribute] 
	public void set_LobbyId(Utf8String value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref SendInviteCallbackInfoInternal other) { }

}

public struct SendInviteCallbackInfo : ICallbackInfo // TypeDefIndex: 9413
{
	[CompilerGeneratedAttribute] 
	private Result <ResultCode>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EpicAccountId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EpicAccountId <TargetUserId>k__BackingField; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }


	[CompilerGeneratedAttribute] 
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute] 
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public EpicAccountId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGeneratedAttribute] 
	public EpicAccountId get_TargetUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_TargetUserId(EpicAccountId value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref SendInviteCallbackInfoInternal other) { }

}

