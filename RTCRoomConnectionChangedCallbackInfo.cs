public struct RTCRoomConnectionChangedCallbackInfo : ICallbackInfo // TypeDefIndex: 9260
{
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <LobbyId>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <IsConnected>k__BackingField;
	[CompilerGeneratedAttribute]
	private Result <DisconnectReason>k__BackingField;

	public object ClientData { get; set; }
	public Utf8String LobbyId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public bool IsConnected { get; set; }
	public Result DisconnectReason { get; set; }


	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_LobbyId() { }

	[CompilerGeneratedAttribute]
	public void set_LobbyId(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute]
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public bool get_IsConnected() { }

	[CompilerGeneratedAttribute]
	public void set_IsConnected(bool value) { }

	[CompilerGeneratedAttribute]
	public Result get_DisconnectReason() { }

	[CompilerGeneratedAttribute]
	public void set_DisconnectReason(Result value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref RTCRoomConnectionChangedCallbackInfoInternal other) { }

}

