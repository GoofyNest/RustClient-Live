public struct InventoryResult : IDisposable // TypeDefIndex: 5250
{	// Fields
	internal SteamInventoryResult_t _id; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Expired>k__BackingField; // 0x4

	// Properties
	internal bool Expired { set; }
	public int ItemCount { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x123040 Offset: 0x122440 VA: 0x180123040
	internal void set_Expired(bool value) { }

	// RVA: 0xFD030 Offset: 0xFC430 VA: 0x1800FD030
	internal void .ctor(SteamInventoryResult_t id, bool expired) { }

	// RVA: 0x122FE0 Offset: 0x1223E0 VA: 0x180122FE0
	public int get_ItemCount() { }

	// RVA: 0x122E60 Offset: 0x122260 VA: 0x180122E60
	public bool BelongsTo(SteamId steamId) { }

	// RVA: 0x122EE0 Offset: 0x1222E0 VA: 0x180122EE0
	public InventoryItem[] GetItems(bool includeProperties = False) { }

	// RVA: 0x122EA0 Offset: 0x1222A0 VA: 0x180122EA0 Slot: 4
	public void Dispose() { }

	[AsyncStateMachineAttribute] // RVA: 0x98AE0 Offset: 0x97EE0 VA: 0x180098AE0
	// RVA: 0xDDD010 Offset: 0xDDC410 VA: 0x180DDD010
	internal static Task<Nullable<InventoryResult>> GetAsync(SteamInventoryResult_t sresult) { }

	// RVA: 0x122EF0 Offset: 0x1222F0 VA: 0x180122EF0
	public byte[] Serialize() { }

}

private struct InventoryResult.<GetAsync>d__11 : IAsyncStateMachine // TypeDefIndex: 5251
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public SteamInventoryResult_t sresult; // 0x20
	private Result <_result>5__2; // 0x24
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x123250 Offset: 0x122650 VA: 0x180123250 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x123260 Offset: 0x122660 VA: 0x180123260 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

