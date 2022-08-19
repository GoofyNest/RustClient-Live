public class Deployer : HeldEntity // TypeDefIndex: 8564
{	// Fields
	private string placementError; // 0x1F8

	// Methods

	// RVA: 0x9B9F00 Offset: 0x9B9300 VA: 0x1809B9F00 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9B99C0 Offset: 0x9B8DC0 VA: 0x1809B99C0
	public ItemModDeployable GetModDeployable() { }

	// RVA: 0x9B97C0 Offset: 0x9B8BC0 VA: 0x1809B97C0
	public Deployable GetDeployable() { }

	// RVA: 0x9B9B80 Offset: 0x9B8F80 VA: 0x1809B9B80 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x9BA600 Offset: 0x9B9A00 VA: 0x1809BA600
	private void UpdateGuide() { }

	// RVA: 0x9BA3F0 Offset: 0x9B97F0 VA: 0x1809BA3F0
	private void UpdateGuide_Slot(BasePlayer player, Deployable deployable) { }

	// RVA: 0x9B9FF0 Offset: 0x9B93F0 VA: 0x1809B9FF0
	private void UpdateGuide_Regular(BasePlayer player, Deployable deployable) { }

	// RVA: 0x9B9C50 Offset: 0x9B9050 VA: 0x1809B9C50 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x9B9C30 Offset: 0x9B9030 VA: 0x1809B9C30 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x9B9C70 Offset: 0x9B9070 VA: 0x1809B9C70 Slot: 138
	public override void OnInput() { }

	// RVA: 0x9B98C0 Offset: 0x9B8CC0 VA: 0x1809B98C0
	public Quaternion GetDeployedRotation(Vector3 normal, Vector3 placeDir) { }

	// RVA: 0x9B9A50 Offset: 0x9B8E50 VA: 0x1809B9A50
	public bool IsPlacementAngleAcceptable(Vector3 pos, Quaternion rot) { }

	// RVA: 0x9B9290 Offset: 0x9B8690 VA: 0x1809B9290
	public bool CheckPlacement(Deployable deployable, Ray ray, float fDistance) { }

	// RVA: 0x9BA760 Offset: 0x9B9B60 VA: 0x1809BA760
	public void .ctor() { }

}

