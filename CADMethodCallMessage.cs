internal class CADMethodCallMessage : CADMessageBase // TypeDefIndex: 1228
{	private string _uri; // 0x38

	internal string Uri { get; }
	internal int PropertiesCount { get; }


	internal string get_Uri() { }

	internal static CADMethodCallMessage Create(IMessage callMsg) { }

	internal void .ctor(IMethodCallMessage callMsg) { }

	internal ArrayList GetArguments() { }

	internal object[] GetArgs(ArrayList args) { }

	internal int get_PropertiesCount() { }

}

