public struct InventoryResult : IDisposable // TypeDefIndex: 5250
{	internal SteamInventoryResult_t _id; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Expired>k__BackingField; // 0x4

	internal bool Expired { set; }
	public int ItemCount { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_Expired(bool value) { }

	internal void .ctor(SteamInventoryResult_t id, bool expired) { }

	public int get_ItemCount() { }

	public bool BelongsTo(SteamId steamId) { }

	public InventoryItem[] GetItems(bool includeProperties = False) { }

	public void Dispose() { }

	[AsyncStateMachineAttribute] // RVA: 0x98AE0 Offset: 0x97EE0 VA: 0x180098AE0
	internal static Task<Nullable<InventoryResult>> GetAsync(SteamInventoryResult_t sresult) { }

	public byte[] Serialize() { }

}

private struct InventoryResult.<GetAsync>d__11 : IAsyncStateMachine // TypeDefIndex: 5251
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public SteamInventoryResult_t sresult; // 0x20
	private Result <_result>5__2; // 0x24
	private TaskAwaiter <>u__1; // 0x28


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

