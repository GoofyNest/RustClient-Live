public abstract class CodeAccessPermission : IPermission, ISecurityEncodable // TypeDefIndex: 898
{	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	[ConditionalAttribute] // RVA: 0xC1040 Offset: 0xC0440 VA: 0x1800C1040
	// RVA: 0x16F33A0 Offset: 0x16F27A0 VA: 0x1816F33A0 Slot: 7
	public void Demand() { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x16F3560 Offset: 0x16F2960 VA: 0x1816F3560 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0xCC95C0 Offset: 0xCC89C0 VA: 0x180CC95C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool IsSubsetOf(IPermission target);

	// RVA: 0x16F3720 Offset: 0x16F2B20 VA: 0x1816F3720 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SecurityElement ToXml();

	// RVA: 0x16F3420 Offset: 0x16F2820 VA: 0x1816F3420
	internal SecurityElement Element(int version) { }

	// RVA: 0x16F32F0 Offset: 0x16F26F0 VA: 0x1816F32F0
	internal static PermissionState CheckPermissionState(PermissionState state, bool allowUnrestricted) { }

	// RVA: 0x16F3680 Offset: 0x16F2A80 VA: 0x1816F3680
	internal static void ThrowInvalidPermission(IPermission target, Type expected) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	private void System.Security.IPermission.Demand() { }

}

