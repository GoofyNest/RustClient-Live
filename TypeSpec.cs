internal class TypeSpec // TypeDefIndex: 414
{
	private TypeIdentifier name;
	private string assembly_name;
	private List<TypeIdentifier> nested;
	private List<TypeSpec> generic_params;
	private List<ModifierSpec> modifier_spec;
	private bool is_byref;
	private string display_fullname;

	internal bool HasModifiers { get; }
	internal string DisplayFullName { get; }


	internal bool get_HasModifiers() { }

	private string GetDisplayFullName(TypeSpec.DisplayNameFormat flags) { }

	private StringBuilder GetModifierString(StringBuilder sb) { }

	internal string get_DisplayFullName() { }

	internal static TypeSpec Parse(string typeName) { }

	internal static string UnescapeInternalName(string displayName) { }

	internal Type Resolve(Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase) { }

	private void AddName(string type_name) { }

	private void AddModifier(ModifierSpec md) { }

	private static void SkipSpace(string name, ref int pos) { }

	private static void BoundCheck(int idx, string s) { }

	private static TypeIdentifier ParsedTypeIdentifier(string displayName) { }

	private static TypeSpec Parse(string name, ref int p, bool is_recurse, bool allow_aqn) { }

	public void .ctor() { }

}

internal enum TypeSpec.DisplayNameFormat // TypeDefIndex: 415
{
	public int value__;
	public const TypeSpec.DisplayNameFormat Default = 0;
	public const TypeSpec.DisplayNameFormat WANT_ASSEMBLY = 1;
	public const TypeSpec.DisplayNameFormat NO_MODIFIERS = 2;

}

