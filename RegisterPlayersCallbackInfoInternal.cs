internal struct RegisterPlayersCallbackInfoInternal : ICallbackInfoInternal, IGettable<RegisterPlayersCallbackInfo>, ISettable<RegisterPlayersCallbackInfo>, IDisposable // TypeDefIndex: 8491
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_RegisteredPlayers; 
	private uint m_RegisteredPlayersCount; 
	private IntPtr m_SanctionedPlayers; 
	private uint m_SanctionedPlayersCount; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId[] RegisteredPlayers { get; set; }
	public ProductUserId[] SanctionedPlayers { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId[] get_RegisteredPlayers() { }

	public void set_RegisteredPlayers(ProductUserId[] value) { }

	public ProductUserId[] get_SanctionedPlayers() { }

	public void set_SanctionedPlayers(ProductUserId[] value) { }

	public void Set(ref RegisterPlayersCallbackInfo other) { }

	public void Set(ref Nullable<RegisterPlayersCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out RegisterPlayersCallbackInfo output) { }

}

