internal sealed class TypeInformation // TypeDefIndex: 1111
{	// Fields
	private string fullTypeName; // 0x10
	private string assemblyString; // 0x18
	private bool hasTypeForwardedFrom; // 0x20

	// Properties
	internal string FullTypeName { get; }
	internal string AssemblyString { get; }
	internal bool HasTypeForwardedFrom { get; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal string get_FullTypeName() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal string get_AssemblyString() { }

	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	internal bool get_HasTypeForwardedFrom() { }

	// RVA: 0xFF6C00 Offset: 0xFF6000 VA: 0x180FF6C00
	internal void .ctor(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom) { }

}

internal class TypeInformation // TypeDefIndex: 5941
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PrimitiveTypeCode <TypeCode>k__BackingField; // 0x18

	// Properties
	public Type Type { get; set; }
	public PrimitiveTypeCode TypeCode { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_Type(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public PrimitiveTypeCode get_TypeCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8E20 Offset: 0x7E8220 VA: 0x1807E8E20
	public void set_TypeCode(PrimitiveTypeCode value) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

