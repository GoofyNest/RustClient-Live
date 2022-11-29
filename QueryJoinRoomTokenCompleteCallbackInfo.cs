public struct QueryJoinRoomTokenCompleteCallbackInfo : ICallbackInfo // TypeDefIndex: 8748
{
	[CompilerGeneratedAttribute] 
	private Result <ResultCode>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <RoomName>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <ClientBaseUrl>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <QueryId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <TokenCount>k__BackingField; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String RoomName { get; set; }
	public Utf8String ClientBaseUrl { get; set; }
	public uint QueryId { get; set; }
	public uint TokenCount { get; set; }


	[CompilerGeneratedAttribute] 
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute] 
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_RoomName() { }

	[CompilerGeneratedAttribute] 
	public void set_RoomName(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_ClientBaseUrl() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientBaseUrl(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public uint get_QueryId() { }

	[CompilerGeneratedAttribute] 
	public void set_QueryId(uint value) { }

	[CompilerGeneratedAttribute] 
	public uint get_TokenCount() { }

	[CompilerGeneratedAttribute] 
	public void set_TokenCount(uint value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref QueryJoinRoomTokenCompleteCallbackInfoInternal other) { }

}

