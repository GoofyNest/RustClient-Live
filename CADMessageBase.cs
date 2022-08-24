internal class CADMessageBase // TypeDefIndex: 1227
{
	protected object[] _args; 
	protected byte[] _serializedArgs; 
	protected int _propertyCount; 
	protected CADArgHolder _callContext; 
	internal byte[] serializedMethod; 


	public void .ctor(IMethodMessage msg) { }

	internal MethodBase GetMethod() { }

	protected static Type[] GetSignature(MethodBase methodBase, bool load) { }

	internal static int MarshalProperties(IDictionary dict, ref ArrayList args) { }

	internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args) { }

	private static bool IsPossibleToIgnoreMarshal(object obj) { }

	protected object MarshalArgument(object arg, ref ArrayList args) { }

	protected object UnmarshalArgument(object arg, ArrayList args) { }

	internal object[] MarshalArguments(object[] arguments, ref ArrayList args) { }

	internal object[] UnmarshalArguments(object[] arguments, ArrayList args) { }

	protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList) { }

	internal LogicalCallContext GetLogicalCallContext(ArrayList args) { }

}

