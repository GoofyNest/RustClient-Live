public struct PresenceChangedCallbackInfo : ICallbackInfo // TypeDefIndex: 8831
{
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EpicAccountId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EpicAccountId <PresenceUserId>k__BackingField; 

	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId PresenceUserId { get; set; }


	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public EpicAccountId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGeneratedAttribute] 
	public EpicAccountId get_PresenceUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_PresenceUserId(EpicAccountId value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref PresenceChangedCallbackInfoInternal other) { }

}

