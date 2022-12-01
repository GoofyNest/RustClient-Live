public struct InventoryItem : IEquatable<InventoryItem> // TypeDefIndex: 5247
{
	internal InventoryItemId _id;
	internal InventoryDefId _def;
	internal SteamItemFlags _flags;
	internal ushort _quantity;
	internal Dictionary<string, string> _properties;

	public InventoryItemId Id { get; }
	public InventoryDefId DefId { get; }
	public int Quantity { get; }
	public InventoryDef Def { get; }
	public Dictionary<string, string> Properties { get; }
	public DateTime Acquired { get; }


	public InventoryItemId get_Id() { }

	public InventoryDefId get_DefId() { }

	public int get_Quantity() { }

	public InventoryDef get_Def() { }

	public Dictionary<string, string> get_Properties() { }

	[AsyncStateMachineAttribute]
	public Task<Nullable<InventoryResult>> ConsumeAsync(int amount = 1) { }

	[AsyncStateMachineAttribute]
	public Task<Nullable<InventoryResult>> SplitStackAsync(int quantity = 1) { }

	[AsyncStateMachineAttribute]
	public Task<Nullable<InventoryResult>> AddAsync(InventoryItem add, int quantity = 1) { }

	internal static InventoryItem From(SteamItemDetails_t details) { }

	internal static Dictionary<string, string> GetProperties(SteamInventoryResult_t result, int index) { }

	public DateTime get_Acquired() { }

	public static bool op_Equality(InventoryItem a, InventoryItem b) { }

	public override bool Equals(object p) { }

	public override int GetHashCode() { }

	public bool Equals(InventoryItem p) { }

}

public struct InventoryItem.Amount // TypeDefIndex: 5248
{
	public InventoryItem Item;
	public int Quantity;

}

private struct InventoryItem.<ConsumeAsync>d__21 : IAsyncStateMachine // TypeDefIndex: 5249
{
	public int <>1__state;
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder;
	public InventoryItem <>4__this;
	public int amount;
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct InventoryItem.<SplitStackAsync>d__22 : IAsyncStateMachine // TypeDefIndex: 5250
{
	public int <>1__state;
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder;
	public InventoryItem <>4__this;
	public int quantity;
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct InventoryItem.<AddAsync>d__23 : IAsyncStateMachine // TypeDefIndex: 5251
{
	public int <>1__state;
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder;
	public InventoryItem add;
	public int quantity;
	public InventoryItem <>4__this;
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

