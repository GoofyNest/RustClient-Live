internal struct SetPortRangeOptionsInternal : ISettable<SetPortRangeOptions>, IDisposable // TypeDefIndex: 8995
{
	private int m_ApiVersion; 
	private ushort m_Port; 
	private ushort m_MaxAdditionalPortsToTry; 

	public ushort Port { set; }
	public ushort MaxAdditionalPortsToTry { set; }


	public void set_Port(ushort value) { }

	public void set_MaxAdditionalPortsToTry(ushort value) { }

	public void Set(ref SetPortRangeOptions other) { }

	public void Set(ref Nullable<SetPortRangeOptions> other) { }

	public void Dispose() { }

}

