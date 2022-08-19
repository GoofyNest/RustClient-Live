public sealed class ReadOnlyAttribute : Attribute // TypeDefIndex: 2738
{	// Fields
	private bool isReadOnly; // 0x10
	public static readonly ReadOnlyAttribute Yes; // 0x0
	public static readonly ReadOnlyAttribute No; // 0x8
	public static readonly ReadOnlyAttribute Default; // 0x10

	// Properties
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0xFD7A30 Offset: 0xFD6E30 VA: 0x180FD7A30
	public void .ctor(bool isReadOnly) { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_IsReadOnly() { }

	// RVA: 0x15ADBF0 Offset: 0x15ACFF0 VA: 0x1815ADBF0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x159ADA0 Offset: 0x159A1A0 VA: 0x18159ADA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15ADC70 Offset: 0x15AD070 VA: 0x1815ADC70 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15ADCF0 Offset: 0x15AD0F0 VA: 0x1815ADCF0
	private static void .cctor() { }

}

public sealed class ReadOnlyAttribute : Attribute // TypeDefIndex: 3315
{	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

public class ReadOnlyAttribute : PropertyAttribute // TypeDefIndex: 8019
{	// Methods

	// RVA: 0x531100 Offset: 0x530500 VA: 0x180531100
	public void .ctor() { }

}

