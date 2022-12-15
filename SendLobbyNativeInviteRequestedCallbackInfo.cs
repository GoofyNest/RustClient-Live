public struct SendLobbyNativeInviteRequestedCallbackInfo : ICallbackInfo // TypeDefIndex: 9272
{
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private ulong <UiEventId>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <TargetNativeAccountType>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <TargetUserNativeAccountId>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <LobbyId>k__BackingField;

	public object ClientData { get; set; }
	public ulong UiEventId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String TargetNativeAccountType { get; set; }
	public Utf8String TargetUserNativeAccountId { get; set; }
	public Utf8String LobbyId { get; set; }


	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute]
	public ulong get_UiEventId() { }

	[CompilerGeneratedAttribute]
	public void set_UiEventId(ulong value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute]
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_TargetNativeAccountType() { }

	[CompilerGeneratedAttribute]
	public void set_TargetNativeAccountType(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_TargetUserNativeAccountId() { }

	[CompilerGeneratedAttribute]
	public void set_TargetUserNativeAccountId(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_LobbyId() { }

	[CompilerGeneratedAttribute]
	public void set_LobbyId(Utf8String value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref SendLobbyNativeInviteRequestedCallbackInfoInternal other) { }

}

