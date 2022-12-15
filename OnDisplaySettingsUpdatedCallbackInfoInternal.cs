internal struct OnDisplaySettingsUpdatedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnDisplaySettingsUpdatedCallbackInfo>, ISettable<OnDisplaySettingsUpdatedCallbackInfo>, IDisposable // TypeDefIndex: 8355
{
	private IntPtr m_ClientData;
	private int m_IsVisible;
	private int m_IsExclusiveInput;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public bool IsVisible { get; set; }
	public bool IsExclusiveInput { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public bool get_IsVisible() { }

	public void set_IsVisible(bool value) { }

	public bool get_IsExclusiveInput() { }

	public void set_IsExclusiveInput(bool value) { }

	public void Set(ref OnDisplaySettingsUpdatedCallbackInfo other) { }

	public void Set(ref Nullable<OnDisplaySettingsUpdatedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out OnDisplaySettingsUpdatedCallbackInfo output) { }

}

