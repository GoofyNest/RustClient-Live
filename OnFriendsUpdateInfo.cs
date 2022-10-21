public struct OnFriendsUpdateInfo : ICallbackInfo // TypeDefIndex: 9388
{
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EpicAccountId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EpicAccountId <TargetUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private FriendsStatus <PreviousStatus>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private FriendsStatus <CurrentStatus>k__BackingField; 

	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }
	public FriendsStatus PreviousStatus { get; set; }
	public FriendsStatus CurrentStatus { get; set; }


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

	[CompilerGeneratedAttribute] 
	public FriendsStatus get_PreviousStatus() { }

	[CompilerGeneratedAttribute] 
	public void set_PreviousStatus(FriendsStatus value) { }

	[CompilerGeneratedAttribute] 
	public FriendsStatus get_CurrentStatus() { }

	[CompilerGeneratedAttribute] 
	public void set_CurrentStatus(FriendsStatus value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref OnFriendsUpdateInfoInternal other) { }

}

