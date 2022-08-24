public sealed class StateChangedEventArgs : EventArgs // TypeDefIndex: 7145
{
	[CompilerGeneratedAttribute] 
	private string <Message>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private StateChangeType <Type>k__BackingField; 

	public string Message { get; set; }
	public StateChangeType Type { get; set; }


	internal void .ctor(StateChangeType stateChangeType, string message) { }

	[CompilerGeneratedAttribute] 
	public string get_Message() { }

	[CompilerGeneratedAttribute] 
	private void set_Message(string value) { }

	[CompilerGeneratedAttribute] 
	public StateChangeType get_Type() { }

	[CompilerGeneratedAttribute] 
	private void set_Type(StateChangeType value) { }

	public override string ToString() { }

}

