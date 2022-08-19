internal class CADMessageBase // TypeDefIndex: 1227
{	// Fields
	protected object[] _args; // 0x10
	protected byte[] _serializedArgs; // 0x18
	protected int _propertyCount; // 0x20
	protected CADArgHolder _callContext; // 0x28
	internal byte[] serializedMethod; // 0x30

	// Methods

	// RVA: 0x146B340 Offset: 0x146A740 VA: 0x18146B340
	public void .ctor(IMethodMessage msg) { }

	// RVA: 0x14698C0 Offset: 0x1468CC0 VA: 0x1814698C0
	internal MethodBase GetMethod() { }

	// RVA: 0x1469990 Offset: 0x1468D90 VA: 0x181469990
	protected static Type[] GetSignature(MethodBase methodBase, bool load) { }

	// RVA: 0x146A030 Offset: 0x1469430 VA: 0x18146A030
	internal static int MarshalProperties(IDictionary dict, ref ArrayList args) { }

	// RVA: 0x146B1E0 Offset: 0x146A5E0 VA: 0x18146B1E0
	internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args) { }

	// RVA: 0x1469BB0 Offset: 0x1468FB0 VA: 0x181469BB0
	private static bool IsPossibleToIgnoreMarshal(object obj) { }

	// RVA: 0x1469D90 Offset: 0x1469190 VA: 0x181469D90
	protected object MarshalArgument(object arg, ref ArrayList args) { }

	// RVA: 0x146A690 Offset: 0x1469A90 VA: 0x18146A690
	protected object UnmarshalArgument(object arg, ArrayList args) { }

	// RVA: 0x1469F00 Offset: 0x1469300 VA: 0x181469F00
	internal object[] MarshalArguments(object[] arguments, ref ArrayList args) { }

	// RVA: 0x146B0B0 Offset: 0x146A4B0 VA: 0x18146B0B0
	internal object[] UnmarshalArguments(object[] arguments, ArrayList args) { }

	// RVA: 0x146A4F0 Offset: 0x14698F0 VA: 0x18146A4F0
	protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList) { }

	// RVA: 0x1469830 Offset: 0x1468C30 VA: 0x181469830
	internal LogicalCallContext GetLogicalCallContext(ArrayList args) { }

}

