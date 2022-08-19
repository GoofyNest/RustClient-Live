public struct StreamingContext // TypeDefIndex: 1062
{	// Fields
	internal object m_additionalContext; // 0x0
	internal StreamingContextStates m_state; // 0x8

	// Properties
	public object Context { get; }
	public StreamingContextStates State { get; }

	// Methods

	// RVA: 0x1DFB30 Offset: 0x1DEF30 VA: 0x1801DFB30
	public void .ctor(StreamingContextStates state) { }

	// RVA: 0x14C720 Offset: 0x14BB20 VA: 0x18014C720
	public void .ctor(StreamingContextStates state, object additional) { }

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public object get_Context() { }

	// RVA: 0x1DFA80 Offset: 0x1DEE80 VA: 0x1801DFA80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x122CA0 Offset: 0x1220A0 VA: 0x180122CA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x122CA0 Offset: 0x1220A0 VA: 0x180122CA0
	public StreamingContextStates get_State() { }

}

