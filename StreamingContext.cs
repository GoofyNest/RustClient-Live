public struct StreamingContext // TypeDefIndex: 1062
{
	internal object m_additionalContext;
	internal StreamingContextStates m_state;

	public object Context { get; }
	public StreamingContextStates State { get; }


	public void .ctor(StreamingContextStates state) { }

	public void .ctor(StreamingContextStates state, object additional) { }

	public object get_Context() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public StreamingContextStates get_State() { }

}

