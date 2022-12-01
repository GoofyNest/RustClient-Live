internal struct ModInfoInternal : IGettable<ModInfo>, ISettable<ModInfo>, IDisposable // TypeDefIndex: 9025
{
	private int m_ApiVersion;
	private int m_ModsCount;
	private IntPtr m_Mods;
	private ModEnumerationType m_Type;

	public ModIdentifier[] Mods { get; set; }
	public ModEnumerationType Type { get; set; }


	public ModIdentifier[] get_Mods() { }

	public void set_Mods(ModIdentifier[] value) { }

	public ModEnumerationType get_Type() { }

	public void set_Type(ModEnumerationType value) { }

	public void Set(ref ModInfo other) { }

	public void Set(ref Nullable<ModInfo> other) { }

	public void Dispose() { }

	public void Get(out ModInfo output) { }

}

