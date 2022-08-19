internal class TypeSpec // TypeDefIndex: 414
{	// Fields
	private TypeIdentifier name; // 0x10
	private string assembly_name; // 0x18
	private List<TypeIdentifier> nested; // 0x20
	private List<TypeSpec> generic_params; // 0x28
	private List<ModifierSpec> modifier_spec; // 0x30
	private bool is_byref; // 0x38
	private string display_fullname; // 0x40

	// Properties
	internal bool HasModifiers { get; }
	internal string DisplayFullName { get; }

	// Methods

	// RVA: 0x129FF10 Offset: 0x129F310 VA: 0x18129FF10
	internal bool get_HasModifiers() { }

	// RVA: 0x2138DE0 Offset: 0x21381E0 VA: 0x182138DE0
	private string GetDisplayFullName(TypeSpec.DisplayNameFormat flags) { }

	// RVA: 0x2139220 Offset: 0x2138620 VA: 0x182139220
	private StringBuilder GetModifierString(StringBuilder sb) { }

	// RVA: 0x213AC10 Offset: 0x213A010 VA: 0x18213AC10
	internal string get_DisplayFullName() { }

	// RVA: 0x2139400 Offset: 0x2138800 VA: 0x182139400
	internal static TypeSpec Parse(string typeName) { }

	// RVA: 0x213AB30 Offset: 0x2139F30 VA: 0x18213AB30
	internal static string UnescapeInternalName(string displayName) { }

	// RVA: 0x213A230 Offset: 0x2139630 VA: 0x18213A230
	internal Type Resolve(Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x2138C80 Offset: 0x2138080 VA: 0x182138C80
	private void AddName(string type_name) { }

	// RVA: 0x2138BE0 Offset: 0x2137FE0 VA: 0x182138BE0
	private void AddModifier(ModifierSpec md) { }

	// RVA: 0x213AA80 Offset: 0x2139E80 VA: 0x18213AA80
	private static void SkipSpace(string name, ref int pos) { }

	// RVA: 0x2138D60 Offset: 0x2138160 VA: 0x182138D60
	private static void BoundCheck(int idx, string s) { }

	// RVA: 0x21380D0 Offset: 0x21374D0 VA: 0x1821380D0
	private static TypeIdentifier ParsedTypeIdentifier(string displayName) { }

	// RVA: 0x21394C0 Offset: 0x21388C0 VA: 0x1821394C0
	private static TypeSpec Parse(string name, ref int p, bool is_recurse, bool allow_aqn) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

internal enum TypeSpec.DisplayNameFormat // TypeDefIndex: 415
{	// Fields
	public int value__; // 0x0
	public const TypeSpec.DisplayNameFormat Default = 0;
	public const TypeSpec.DisplayNameFormat WANT_ASSEMBLY = 1;
	public const TypeSpec.DisplayNameFormat NO_MODIFIERS = 2;

}

