internal class CompiledIdentityConstraint // TypeDefIndex: 2143
{	// Fields
	internal XmlQualifiedName name; // 0x10
	private CompiledIdentityConstraint.ConstraintRole role; // 0x18
	private Asttree selector; // 0x20
	private Asttree[] fields; // 0x28
	internal XmlQualifiedName refer; // 0x30
	public static readonly CompiledIdentityConstraint Empty; // 0x0

	// Properties
	public CompiledIdentityConstraint.ConstraintRole Role { get; }
	public Asttree Selector { get; }
	public Asttree[] Fields { get; }

	// Methods

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public CompiledIdentityConstraint.ConstraintRole get_Role() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public Asttree get_Selector() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public Asttree[] get_Fields() { }

	// RVA: 0xF429E0 Offset: 0xF41DE0 VA: 0x180F429E0
	private void .ctor() { }

	// RVA: 0xF42A70 Offset: 0xF41E70 VA: 0x180F42A70
	public void .ctor(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr) { }

	// RVA: 0xF42910 Offset: 0xF41D10 VA: 0x180F42910
	private static void .cctor() { }

}

public enum CompiledIdentityConstraint.ConstraintRole // TypeDefIndex: 2144
{	// Fields
	public int value__; // 0x0
	public const CompiledIdentityConstraint.ConstraintRole Unique = 0;
	public const CompiledIdentityConstraint.ConstraintRole Key = 1;
	public const CompiledIdentityConstraint.ConstraintRole Keyref = 2;

}

