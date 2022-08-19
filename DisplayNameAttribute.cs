public class DisplayNameAttribute : Attribute // TypeDefIndex: 2696
{	// Fields
	public static readonly DisplayNameAttribute Default; // 0x0
	private string _displayName; // 0x10

	// Properties
	public virtual string DisplayName { get; }
	protected string DisplayNameValue { get; }

	// Methods

	// RVA: 0x159C6D0 Offset: 0x159BAD0 VA: 0x18159C6D0
	public void .ctor() { }

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string displayName) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 7
	public virtual string get_DisplayName() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	protected string get_DisplayNameValue() { }

	// RVA: 0x159C4F0 Offset: 0x159B8F0 VA: 0x18159C4F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x159B690 Offset: 0x159AA90 VA: 0x18159B690 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x159C5C0 Offset: 0x159B9C0 VA: 0x18159C5C0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x159C630 Offset: 0x159BA30 VA: 0x18159C630
	private static void .cctor() { }

}

public sealed class DisplayNameAttribute : Attribute // TypeDefIndex: 11745
{	// Fields
	public readonly string displayName; // 0x10

	// Methods

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string displayName) { }

}

