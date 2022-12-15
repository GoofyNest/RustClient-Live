public struct RegisterPlayersCallbackInfo : ICallbackInfo // TypeDefIndex: 8538
{
	[CompilerGeneratedAttribute]
	private Result <ResultCode>k__BackingField;
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId[] <RegisteredPlayers>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId[] <SanctionedPlayers>k__BackingField;

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId[] RegisteredPlayers { get; set; }
	public ProductUserId[] SanctionedPlayers { get; set; }


	[CompilerGeneratedAttribute]
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute]
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId[] get_RegisteredPlayers() { }

	[CompilerGeneratedAttribute]
	public void set_RegisteredPlayers(ProductUserId[] value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId[] get_SanctionedPlayers() { }

	[CompilerGeneratedAttribute]
	public void set_SanctionedPlayers(ProductUserId[] value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref RegisterPlayersCallbackInfoInternal other) { }

}

