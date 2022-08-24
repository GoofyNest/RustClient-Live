internal class CADMethodReturnMessage : CADMessageBase // TypeDefIndex: 1229
{
	private object _returnValue; 
	private CADArgHolder _exception; 
	private Type[] _sig; 

internal int PropertiesCount { get; }


internal static CADMethodReturnMessage Create(IMessage callMsg) { }

internal void .ctor(IMethodReturnMessage retMsg) { }

internal ArrayList GetArguments() { }

internal object[] GetArgs(ArrayList args) { }

internal object GetReturnValue(ArrayList args) { }

internal Exception GetException(ArrayList args) { }

internal int get_PropertiesCount() { }

}

