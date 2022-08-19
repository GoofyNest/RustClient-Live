public class ViewmodelScope : MonoBehaviour // TypeDefIndex: 8894
{	// Fields
	public float smoothSpeed; // 0x18
	public Material scopeMaterialOverride; // 0x20
	private bool wasVisible; // 0x28

	// Methods

	// RVA: 0x7DAA40 Offset: 0x7D9E40 VA: 0x1807DAA40
	public void OnEnable() { }

	// RVA: 0x7DA9B0 Offset: 0x7D9DB0 VA: 0x1807DA9B0
	public void OnDisable() { }

	// RVA: 0x7DAA40 Offset: 0x7D9E40 VA: 0x1807DAA40
	public void Update() { }

	// RVA: 0x7DAD20 Offset: 0x7DA120 VA: 0x1807DAD20
	public void UpdateScope() { }

	// RVA: 0x7DA390 Offset: 0x7D9790 VA: 0x1807DA390
	public Vector3 GetScreenPos(Vector3 oldPos) { }

	// RVA: 0x7DA900 Offset: 0x7D9D00 VA: 0x1807DA900
	public void HideAttachments(Transform root, bool shouldShow) { }

	// RVA: -1 Offset: -1
	public void ShowVMParts<T>(Transform root, bool shouldShow) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F2630 Offset: 0x5F1A30 VA: 0x1805F2630
	|-ViewmodelScope.ShowVMParts<object>
	|-ViewmodelScope.ShowVMParts<MeshRenderer>
	|-ViewmodelScope.ShowVMParts<SkinnedMeshRenderer>
	*/

	// RVA: 0x7DA210 Offset: 0x7D9610 VA: 0x1807DA210
	public ProjectileWeaponMod GetScopeMod() { }

	// RVA: 0x7DA040 Offset: 0x7D9440 VA: 0x1807DA040
	public BaseProjectile GetLocalPlayerWeapon() { }

	// RVA: 0x7DAA50 Offset: 0x7D9E50 VA: 0x1807DAA50
	public bool ShouldShow() { }

	// RVA: 0x7DB0F0 Offset: 0x7DA4F0 VA: 0x1807DB0F0
	public void .ctor() { }

}

private sealed class ViewmodelScope.<>c // TypeDefIndex: 8895
{	// Fields
	public static readonly ViewmodelScope.<>c <>9; // 0x0
	public static Func<ProjectileWeaponMod, bool> <>9__10_0; // 0x8

	// Methods

	// RVA: 0x7CFFC0 Offset: 0x7CF3C0 VA: 0x1807CFFC0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7CFDA0 Offset: 0x7CF1A0 VA: 0x1807CFDA0
	internal bool <GetScopeMod>b__10_0(ProjectileWeaponMod x) { }

}

