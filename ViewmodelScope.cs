public class ViewmodelScope : MonoBehaviour // TypeDefIndex: 8894
{	public float smoothSpeed; // 0x18
	public Material scopeMaterialOverride; // 0x20
	private bool wasVisible; // 0x28


	public void OnEnable() { }

	public void OnDisable() { }

	public void Update() { }

	public void UpdateScope() { }

	public Vector3 GetScreenPos(Vector3 oldPos) { }

	public void HideAttachments(Transform root, bool shouldShow) { }

	public void ShowVMParts<T>(Transform root, bool shouldShow) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F2630 Offset: 0x5F1A30 VA: 0x1805F2630
	|-ViewmodelScope.ShowVMParts<object>
	|-ViewmodelScope.ShowVMParts<MeshRenderer>
	|-ViewmodelScope.ShowVMParts<SkinnedMeshRenderer>
	*/

	public ProjectileWeaponMod GetScopeMod() { }

	public BaseProjectile GetLocalPlayerWeapon() { }

	public bool ShouldShow() { }

	public void .ctor() { }

}

private sealed class ViewmodelScope.<>c // TypeDefIndex: 8895
{	public static readonly ViewmodelScope.<>c <>9; // 0x0
	public static Func<ProjectileWeaponMod, bool> <>9__10_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <GetScopeMod>b__10_0(ProjectileWeaponMod x) { }

}

