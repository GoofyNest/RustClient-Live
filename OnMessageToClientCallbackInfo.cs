public struct OnMessageToClientCallbackInfo : ICallbackInfo // TypeDefIndex: 9793
{
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private IntPtr <ClientHandle>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ArraySegment<byte> <MessageData>k__BackingField; 

	public object ClientData { get; set; }
	public IntPtr ClientHandle { get; set; }
	public ArraySegment<byte> MessageData { get; set; }


	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public IntPtr get_ClientHandle() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientHandle(IntPtr value) { }

	[CompilerGeneratedAttribute] 
	public ArraySegment<byte> get_MessageData() { }

	[CompilerGeneratedAttribute] 
	public void set_MessageData(ArraySegment<byte> value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref OnMessageToClientCallbackInfoInternal other) { }

}

