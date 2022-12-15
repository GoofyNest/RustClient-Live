public struct LobbyUpdateReceivedCallbackInfo : ICallbackInfo // TypeDefIndex: 9208
{
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <LobbyId>k__BackingField;

	public object ClientData { get; set; }
	public Utf8String LobbyId { get; set; }


	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_LobbyId() { }

	[CompilerGeneratedAttribute]
	public void set_LobbyId(Utf8String value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref LobbyUpdateReceivedCallbackInfoInternal other) { }

}

