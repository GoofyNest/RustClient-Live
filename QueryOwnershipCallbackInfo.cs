public struct QueryOwnershipCallbackInfo : ICallbackInfo // TypeDefIndex: 9506
{
	[CompilerGeneratedAttribute]
	private Result <ResultCode>k__BackingField;
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private EpicAccountId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private ItemOwnership[] <ItemOwnership>k__BackingField;

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public ItemOwnership[] ItemOwnership { get; set; }


	[CompilerGeneratedAttribute]
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute]
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute]
	public EpicAccountId get_LocalUserId() { }

	[CompilerGeneratedAttribute]
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGeneratedAttribute]
	public ItemOwnership[] get_ItemOwnership() { }

	[CompilerGeneratedAttribute]
	public void set_ItemOwnership(ItemOwnership[] value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref QueryOwnershipCallbackInfoInternal other) { }

}

