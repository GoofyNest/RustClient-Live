public class ToolboxItemAttribute : Attribute // TypeDefIndex: 2776
{	// Fields
	private string toolboxItemTypeName; // 0x10
	public static readonly ToolboxItemAttribute Default; // 0x0
	public static readonly ToolboxItemAttribute None; // 0x8

	// Properties
	public string ToolboxItemTypeName { get; }

	// Methods

	// RVA: 0x1730A40 Offset: 0x172FE40 VA: 0x181730A40 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1730C70 Offset: 0x1730070 VA: 0x181730C70
	public void .ctor(bool defaultType) { }

	// RVA: 0x1730BE0 Offset: 0x172FFE0 VA: 0x181730BE0
	public void .ctor(string toolboxItemTypeName) { }

	// RVA: 0x1730CD0 Offset: 0x17300D0 VA: 0x181730CD0
	public string get_ToolboxItemTypeName() { }

	// RVA: 0x17308E0 Offset: 0x172FCE0 VA: 0x1817308E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1730A10 Offset: 0x172FE10 VA: 0x181730A10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1730AB0 Offset: 0x172FEB0 VA: 0x181730AB0
	private static void .cctor() { }

}

