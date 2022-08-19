internal class ContextLevelActivator : IActivator // TypeDefIndex: 1205
{	// Fields
	private IActivator m_NextActivator; // 0x10

	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(IActivator next) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0xFDF640 Offset: 0xFDEA40 VA: 0x180FDF640 Slot: 5
	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }

}

