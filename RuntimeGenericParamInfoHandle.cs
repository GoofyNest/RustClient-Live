internal struct RuntimeGenericParamInfoHandle // TypeDefIndex: 7
{	// Fields
	private RuntimeStructs.GenericParamInfo* value; // 0x0

	// Properties
	internal Type[] Constraints { get; }
	internal GenericParameterAttributes Attributes { get; }

	// Methods

	// RVA: 0x1F66B0 Offset: 0x1F5AB0 VA: 0x1801F66B0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1F6890 Offset: 0x1F5C90 VA: 0x1801F6890
	internal Type[] get_Constraints() { }

	// RVA: 0x1F6870 Offset: 0x1F5C70 VA: 0x1801F6870
	internal GenericParameterAttributes get_Attributes() { }

	// RVA: 0x1F6860 Offset: 0x1F5C60 VA: 0x1801F6860
	private Type[] GetConstraints() { }

	// RVA: 0x1F6820 Offset: 0x1F5C20 VA: 0x1801F6820
	private int GetConstraintsCount() { }

}

