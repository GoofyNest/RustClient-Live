public struct OnMessageToServerCallbackInfo : ICallbackInfo // TypeDefIndex: 9827
{
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ArraySegment<byte> <MessageData>k__BackingField; 

	public object ClientData { get; set; }
	public ArraySegment<byte> MessageData { get; set; }


	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public ArraySegment<byte> get_MessageData() { }

	[CompilerGeneratedAttribute] 
	public void set_MessageData(ArraySegment<byte> value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref OnMessageToServerCallbackInfoInternal other) { }

}

