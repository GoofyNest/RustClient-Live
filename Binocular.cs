public class Binocular : AttackEntity // TypeDefIndex: 9461
{	public float[] fovs; // 0x280
	public GameObjectRef fovChangeEffect; // 0x288
	public float smoothSpeed; // 0x290
	private bool vmVisible; // 0x294
	private bool isAiming; // 0x295
	private float timeAiming; // 0x298
	private int currentFovIndex; // 0x29C


	public bool IsAiming() { }

	public override void OnDeploy() { }

	public override void OnHolster() { }

	public void ClearOverlays() { }

	public override void OnFrame() { }

	public Vector3 GetScreenPos(Vector3 oldPos) { }

	public void SetViewmodelVisiblity(bool visible) { }

	public override void OnInput() { }

	public void .ctor() { }

}

