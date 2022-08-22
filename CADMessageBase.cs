internal class CADMessageBase // TypeDefIndex: 1227
{	protected object[] _args; // 0x10
	protected byte[] _serializedArgs; // 0x18
	protected int _propertyCount; // 0x20
	protected CADArgHolder _callContext; // 0x28
	internal byte[] serializedMethod; // 0x30


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

