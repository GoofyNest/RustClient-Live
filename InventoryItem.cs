public struct InventoryItem : IEquatable<InventoryItem> // TypeDefIndex: 5241
{	// Fields
	internal InventoryItemId _id; // 0x0
	internal InventoryDefId _def; // 0x8
	internal SteamItemFlags _flags; // 0xC
	internal ushort _quantity; // 0x10
	internal Dictionary<string, string> _properties; // 0x18

	// Properties
	public InventoryItemId Id { get; }
	public InventoryDefId DefId { get; }
	public int Quantity { get; }
	public InventoryDef Def { get; }
	public Dictionary<string, string> Properties { get; }
	public DateTime Acquired { get; }

	// Methods

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public InventoryItemId get_Id() { }

	// RVA: 0x122CA0 Offset: 0x1220A0 VA: 0x180122CA0
	public InventoryDefId get_DefId() { }

	// RVA: 0x10A9B0 Offset: 0x109DB0 VA: 0x18010A9B0
	public int get_Quantity() { }

	// RVA: 0x122CB0 Offset: 0x1220B0 VA: 0x180122CB0
	public InventoryDef get_Def() { }

	// RVA: 0xF3DE0 Offset: 0xF31E0 VA: 0x1800F3DE0
	public Dictionary<string, string> get_Properties() { }

	[AsyncStateMachineAttribute] // RVA: 0x97BD0 Offset: 0x96FD0 VA: 0x180097BD0
	// RVA: 0x1229B0 Offset: 0x121DB0 VA: 0x1801229B0
	public Task<Nullable<InventoryResult>> ConsumeAsync(int amount = 1) { }

	[AsyncStateMachineAttribute] // RVA: 0x97DB0 Offset: 0x971B0 VA: 0x180097DB0
	// RVA: 0x122B80 Offset: 0x121F80 VA: 0x180122B80
	public Task<Nullable<InventoryResult>> SplitStackAsync(int quantity = 1) { }

	[AsyncStateMachineAttribute] // RVA: 0x98040 Offset: 0x97440 VA: 0x180098040
	// RVA: 0x122880 Offset: 0x121C80 VA: 0x180122880
	public Task<Nullable<InventoryResult>> AddAsync(InventoryItem add, int quantity = 1) { }

	// RVA: 0xDDC4C0 Offset: 0xDDB8C0 VA: 0x180DDC4C0
	internal static InventoryItem From(SteamItemDetails_t details) { }

	// RVA: 0xDDC530 Offset: 0xDDB930 VA: 0x180DDC530
	internal static Dictionary<string, string> GetProperties(SteamInventoryResult_t result, int index) { }

	// RVA: 0x122C90 Offset: 0x122090 VA: 0x180122C90
	public DateTime get_Acquired() { }

	// RVA: 0xDDCAE0 Offset: 0xDDBEE0 VA: 0x180DDCAE0
	public static bool op_Equality(InventoryItem a, InventoryItem b) { }

	// RVA: 0x122AC0 Offset: 0x121EC0 VA: 0x180122AC0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x122B70 Offset: 0x121F70 VA: 0x180122B70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x122B40 Offset: 0x121F40 VA: 0x180122B40 Slot: 4
	public bool Equals(InventoryItem p) { }

}

public struct InventoryItem.Amount // TypeDefIndex: 5242
{	// Fields
	public InventoryItem Item; // 0x0
	public int Quantity; // 0x20

}

private struct InventoryItem.<ConsumeAsync>d__21 : IAsyncStateMachine // TypeDefIndex: 5243
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public InventoryItem <>4__this; // 0x20
	public int amount; // 0x40
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x48

	// Methods

	// RVA: 0x1230D0 Offset: 0x1224D0 VA: 0x1801230D0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1230E0 Offset: 0x1224E0 VA: 0x1801230E0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct InventoryItem.<SplitStackAsync>d__22 : IAsyncStateMachine // TypeDefIndex: 5244
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public InventoryItem <>4__this; // 0x20
	public int quantity; // 0x40
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x48

	// Methods

	// RVA: 0x123620 Offset: 0x122A20 VA: 0x180123620 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x123630 Offset: 0x122A30 VA: 0x180123630 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct InventoryItem.<AddAsync>d__23 : IAsyncStateMachine // TypeDefIndex: 5245
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public InventoryItem add; // 0x20
	public int quantity; // 0x40
	public InventoryItem <>4__this; // 0x48
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x68

	// Methods

	// RVA: 0x123060 Offset: 0x122460 VA: 0x180123060 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x123070 Offset: 0x122470 VA: 0x180123070 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

