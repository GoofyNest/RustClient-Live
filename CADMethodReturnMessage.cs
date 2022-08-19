internal class CADMethodReturnMessage : CADMessageBase // TypeDefIndex: 1229
{	// Fields
	private object _returnValue; // 0x38
	private CADArgHolder _exception; // 0x40
	private Type[] _sig; // 0x48

	// Properties
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x146C0F0 Offset: 0x146B4F0 VA: 0x18146C0F0
	internal static CADMethodReturnMessage Create(IMessage callMsg) { }

	// RVA: 0x146C310 Offset: 0x146B710 VA: 0x18146C310
	internal void .ctor(IMethodReturnMessage retMsg) { }

	// RVA: 0x146C170 Offset: 0x146B570 VA: 0x18146C170
	internal ArrayList GetArguments() { }

	// RVA: 0x146B560 Offset: 0x146A960 VA: 0x18146B560
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x146C300 Offset: 0x146B700 VA: 0x18146C300
	internal object GetReturnValue(ArrayList args) { }

	// RVA: 0x146C250 Offset: 0x146B650 VA: 0x18146C250
	internal Exception GetException(ArrayList args) { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	internal int get_PropertiesCount() { }

}

