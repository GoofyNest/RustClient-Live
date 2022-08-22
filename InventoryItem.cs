public struct InventoryItem : IEquatable<InventoryItem> // TypeDefIndex: 5241
{	internal InventoryItemId _id; // 0x0
	internal InventoryDefId _def; // 0x8
	internal SteamItemFlags _flags; // 0xC
	internal ushort _quantity; // 0x10
	internal Dictionary<string, string> _properties; // 0x18

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

	[AsyncStateMachineAttribute] // RVA: 0x97BD0 Offset: 0x96FD0 VA: 0x180097BD0
	public Task<Nullable<InventoryResult>> ConsumeAsync(int amount = 1) { }

	[AsyncStateMachineAttribute] // RVA: 0x97DB0 Offset: 0x971B0 VA: 0x180097DB0
	public Task<Nullable<InventoryResult>> SplitStackAsync(int quantity = 1) { }

	[AsyncStateMachineAttribute] // RVA: 0x98040 Offset: 0x97440 VA: 0x180098040
	public Task<Nullable<InventoryResult>> AddAsync(InventoryItem add, int quantity = 1) { }

	internal static InventoryItem From(SteamItemDetails_t details) { }

	internal static Dictionary<string, string> GetProperties(SteamInventoryResult_t result, int index) { }

	public DateTime get_Acquired() { }

	public static bool op_Equality(InventoryItem a, InventoryItem b) { }

	public override bool Equals(object p) { }

	public override int GetHashCode() { }

	public bool Equals(InventoryItem p) { }

}

public struct InventoryItem.Amount // TypeDefIndex: 5242
{	public InventoryItem Item; // 0x0
	public int Quantity; // 0x20

}

private struct InventoryItem.<ConsumeAsync>d__21 : IAsyncStateMachine // TypeDefIndex: 5243
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public InventoryItem <>4__this; // 0x20
	public int amount; // 0x40
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x48


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct InventoryItem.<SplitStackAsync>d__22 : IAsyncStateMachine // TypeDefIndex: 5244
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public InventoryItem <>4__this; // 0x20
	public int quantity; // 0x40
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x48


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct InventoryItem.<AddAsync>d__23 : IAsyncStateMachine // TypeDefIndex: 5245
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public InventoryItem add; // 0x20
	public int quantity; // 0x40
	public InventoryItem <>4__this; // 0x48
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x68


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

