public struct JoinLobbyAcceptedCallbackInfo : ICallbackInfo // TypeDefIndex: 9113
{
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private ulong <UiEventId>k__BackingField;

	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ulong UiEventId { get; set; }


	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute]
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public ulong get_UiEventId() { }

	[CompilerGeneratedAttribute]
	public void set_UiEventId(ulong value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref JoinLobbyAcceptedCallbackInfoInternal other) { }

}

