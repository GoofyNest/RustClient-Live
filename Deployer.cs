public class Deployer : HeldEntity // TypeDefIndex: 8567
{
	private string placementError; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public ItemModDeployable GetModDeployable() { }

	public Deployable GetDeployable() { }

	public override void OnDeploy() { }

	private void UpdateGuide() { }

	private void UpdateGuide_Slot(BasePlayer player, Deployable deployable) { }

	private void UpdateGuide_Regular(BasePlayer player, Deployable deployable) { }

	public override void OnHolstered() { }

	public override void OnFrame() { }

	public override void OnInput() { }

	public Quaternion GetDeployedRotation(Vector3 normal, Vector3 placeDir) { }

	public bool IsPlacementAngleAcceptable(Vector3 pos, Quaternion rot) { }

	public bool CheckPlacement(Deployable deployable, Ray ray, float fDistance) { }

	public void .ctor() { }

}

