public struct InventoryResult : IDisposable // TypeDefIndex: 5250
{
	internal SteamInventoryResult_t _id; 
	[CompilerGeneratedAttribute] 
	private bool <Expired>k__BackingField; 

internal bool Expired { set; }
public int ItemCount { get; }


	[CompilerGeneratedAttribute] 
internal void set_Expired(bool value) { }

internal void .ctor(SteamInventoryResult_t id, bool expired) { }

public int get_ItemCount() { }

public bool BelongsTo(SteamId steamId) { }

public InventoryItem[] GetItems(bool includeProperties = False) { }

public void Dispose() { }

	[AsyncStateMachineAttribute] 
internal static Task<Nullable<InventoryResult>> GetAsync(SteamInventoryResult_t sresult) { }

public byte[] Serialize() { }

}

private struct InventoryResult.<GetAsync>d__11 : IAsyncStateMachine // TypeDefIndex: 5251
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; 
	public SteamInventoryResult_t sresult; 
	private Result <_result>5__2; 
	private TaskAwaiter <>u__1; 


private void MoveNext() { }

	[DebuggerHiddenAttribute] 
private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

