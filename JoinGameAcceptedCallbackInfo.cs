public struct JoinGameAcceptedCallbackInfo : ICallbackInfo // TypeDefIndex: 8789
{
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <JoinInfo>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EpicAccountId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EpicAccountId <TargetUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <UiEventId>k__BackingField; 

	public object ClientData { get; set; }
	public Utf8String JoinInfo { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }
	public ulong UiEventId { get; set; }


	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_JoinInfo() { }

	[CompilerGeneratedAttribute] 
	public void set_JoinInfo(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public EpicAccountId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGeneratedAttribute] 
	public EpicAccountId get_TargetUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_TargetUserId(EpicAccountId value) { }

	[CompilerGeneratedAttribute] 
	public ulong get_UiEventId() { }

	[CompilerGeneratedAttribute] 
	public void set_UiEventId(ulong value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref JoinGameAcceptedCallbackInfoInternal other) { }

}

