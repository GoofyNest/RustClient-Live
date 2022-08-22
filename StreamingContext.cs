public struct StreamingContext // TypeDefIndex: 1062
{	internal object m_additionalContext; // 0x0
	internal StreamingContextStates m_state; // 0x8

	public object Context { get; }
	public StreamingContextStates State { get; }


	public void .ctor(StreamingContextStates state) { }

	public void .ctor(StreamingContextStates state, object additional) { }

	public object get_Context() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public StreamingContextStates get_State() { }

}

