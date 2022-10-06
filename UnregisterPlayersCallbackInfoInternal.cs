internal struct UnregisterPlayersCallbackInfoInternal : ICallbackInfoInternal, IGettable<UnregisterPlayersCallbackInfo>, ISettable<UnregisterPlayersCallbackInfo>, IDisposable // TypeDefIndex: 8600
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_UnregisteredPlayers; 
	private uint m_UnregisteredPlayersCount; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId[] UnregisteredPlayers { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId[] get_UnregisteredPlayers() { }

	public void set_UnregisteredPlayers(ProductUserId[] value) { }

	public void Set(ref UnregisterPlayersCallbackInfo other) { }

	public void Set(ref Nullable<UnregisterPlayersCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out UnregisterPlayersCallbackInfo output) { }

}

