public class RecommendedAsConfigurableAttribute : Attribute // TypeDefIndex: 2739
{	// Fields
	private bool recommendedAsConfigurable; // 0x10
	public static readonly RecommendedAsConfigurableAttribute No; // 0x0
	public static readonly RecommendedAsConfigurableAttribute Yes; // 0x8
	public static readonly RecommendedAsConfigurableAttribute Default; // 0x10

	// Properties
	public bool RecommendedAsConfigurable { get; }

	// Methods

	// RVA: 0xFD7A30 Offset: 0xFD6E30 VA: 0x180FD7A30
	public void .ctor(bool recommendedAsConfigurable) { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_RecommendedAsConfigurable() { }

	// RVA: 0x15ADDB0 Offset: 0x15AD1B0 VA: 0x1815ADDB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x159ADA0 Offset: 0x159A1A0 VA: 0x18159ADA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15ADE50 Offset: 0x15AD250 VA: 0x1815ADE50 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15ADE60 Offset: 0x15AD260 VA: 0x1815ADE60
	private static void .cctor() { }

}

