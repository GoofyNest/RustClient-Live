public class Binocular : AttackEntity // TypeDefIndex: 9461
{
	public float[] fovs; 
	public GameObjectRef fovChangeEffect; 
	public float smoothSpeed; 
	private bool vmVisible; 
	private bool isAiming; 
	private float timeAiming; 
	private int currentFovIndex; 


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

