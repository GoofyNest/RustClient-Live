public sealed class SecurityPermission : CodeAccessPermission // TypeDefIndex: 916
{
// Namespace: System.Security.Permissions
[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
[Serializable]
public sealed class SecurityPermission : CodeAccessPermission // TypeDefIndex: 916
	// Fields
	private SecurityPermissionFlag flags; // 0x10

	// Methods

	// RVA: 0x17C05C0 Offset: 0x17BF9C0 VA: 0x1817C05C0
	public void .ctor(PermissionState state) { }

	// RVA: 0x17C04D0 Offset: 0x17BF8D0 VA: 0x1817C04D0 Slot: 10
	public bool IsUnrestricted() { }

	// RVA: 0x17C03D0 Offset: 0x17BF7D0 VA: 0x1817C03D0 Slot: 8
	public override bool IsSubsetOf(IPermission target) { }

	// RVA: 0x17C04E0 Offset: 0x17BF8E0 VA: 0x1817C04E0 Slot: 9
	public override SecurityElement ToXml() { }

	// RVA: 0x17C03C0 Offset: 0x17BF7C0 VA: 0x1817C03C0
	private bool IsEmpty() { }

	// RVA: 0x17C0320 Offset: 0x17BF720 VA: 0x1817C0320
	private SecurityPermission Cast(IPermission target) { }

}

