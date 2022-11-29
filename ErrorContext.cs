public class ErrorContext // TypeDefIndex: 6009
{
	[CompilerGeneratedAttribute] 
	private bool <Traced>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Exception <Error>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <OriginalObject>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <Member>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Path>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <Handled>k__BackingField; 

	internal bool Traced { get; set; }
	public Exception Error { get; set; }
	private object OriginalObject { set; }
	private object Member { set; }
	private string Path { set; }
	public bool Handled { get; }


	internal void .ctor(object originalObject, object member, string path, Exception error) { }

	[CompilerGeneratedAttribute] 
	internal bool get_Traced() { }

	[CompilerGeneratedAttribute] 
	internal void set_Traced(bool value) { }

	[CompilerGeneratedAttribute] 
	public Exception get_Error() { }

	[CompilerGeneratedAttribute] 
	private void set_Error(Exception value) { }

	[CompilerGeneratedAttribute] 
	private void set_OriginalObject(object value) { }

	[CompilerGeneratedAttribute] 
	private void set_Member(object value) { }

	[CompilerGeneratedAttribute] 
	private void set_Path(string value) { }

	[CompilerGeneratedAttribute] 
	public bool get_Handled() { }

}

