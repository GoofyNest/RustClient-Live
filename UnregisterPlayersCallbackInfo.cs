public struct UnregisterPlayersCallbackInfo : ICallbackInfo // TypeDefIndex: 8599
{
	[CompilerGeneratedAttribute] 
	private Result <ResultCode>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId[] <UnregisteredPlayers>k__BackingField; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId[] UnregisteredPlayers { get; set; }


	[CompilerGeneratedAttribute] 
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute] 
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId[] get_UnregisteredPlayers() { }

	[CompilerGeneratedAttribute] 
	public void set_UnregisteredPlayers(ProductUserId[] value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref UnregisterPlayersCallbackInfoInternal other) { }

}

