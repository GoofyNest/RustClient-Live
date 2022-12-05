public class ViewmodelScope : MonoBehaviour // TypeDefIndex: 10626
{
	public float smoothSpeed;
	public Material scopeMaterialOverride;
	private bool wasVisible;


	public void OnEnable() { }

	public void OnDisable() { }

	public void Update() { }

	public void UpdateScope() { }

	public Vector3 GetScreenPos(Vector3 oldPos) { }

	public void HideAttachments(Transform root, bool shouldShow) { }

	public void ShowVMParts<T>(Transform root, bool shouldShow) { }
	/* GenericInstMethod :
	|
	|-ViewmodelScope.ShowVMParts<object>
	|-ViewmodelScope.ShowVMParts<MeshRenderer>
	|-ViewmodelScope.ShowVMParts<SkinnedMeshRenderer>
	*/

	public ProjectileWeaponMod GetScopeMod() { }

	public BaseProjectile GetLocalPlayerWeapon() { }

	public bool ShouldShow() { }

	public void .ctor() { }

}

private sealed class ViewmodelScope.<>c // TypeDefIndex: 10627
{
	public static readonly ViewmodelScope.<>c <>9;
	public static Func<ProjectileWeaponMod, bool> <>9__10_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <GetScopeMod>

}

