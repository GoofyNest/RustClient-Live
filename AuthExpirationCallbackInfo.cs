public struct AuthExpirationCallbackInfo : ICallbackInfo // TypeDefIndex: 9542
{
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 

	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }


	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(ProductUserId value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref AuthExpirationCallbackInfoInternal other) { }

}

