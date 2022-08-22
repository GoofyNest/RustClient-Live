public class Planner : HeldEntity // TypeDefIndex: 8615
{	private Vector3 rotationOffset; // 0x1F8
	private bool hasAppliedStartingRotation; // 0x204
	public Construction currentConstruction; // 0x208
	internal Planner.Guide guide; // 0x210
	public BaseEntity[] buildableList; // 0x218

	public bool isTypeDeployable { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void ResetState() { }

	public override void OnFrame() { }

	public override void OnDeploy() { }

	public override void OnHolstered() { }

	public override void OnInput() { }

	private void OpenComponentMenu() { }

	private void SwitchConstruction(Construction c) { }

	private void DoBuild() { }

	private void SetDefaultPlan() { }

	public override bool NeedsCrosshair() { }

	private void UpdateGuide() { }

	private void CloseGuide() { }

	internal void FillPlacement(ref Construction.Target target, Construction component) { }

	internal void FindTerrainPlacement(ref Construction.Target target, Construction component) { }

	internal bool FindAppropriateHandle(ref Construction.Target target, Construction component) { }

	public ItemModDeployable GetModDeployable() { }

	public Deployable GetDeployable() { }

	public bool get_isTypeDeployable() { }

	public void .ctor() { }

}

public class Planner.Guide // TypeDefIndex: 8616
{	public GameObject guideObject; // 0x10
	public Construction.Target lastPlacement; // 0x18
	private Construction component; // 0x80
	private Material goodMat; // 0x88
	private Material neutralMat; // 0x90
	private Material badMat; // 0x98
	private bool wasTransparent; // 0xA0
	private Planner.Guide.PlacementState lastPlacementState; // 0xA4


	public bool IsValid() { }

	private void UpdateComponent(Construction c) { }

	public void Update(ref Construction.Target placement, Construction currentComponent) { }

	public void BecomeValid() { }

	public void BecomeNeutral() { }

	public void BecomeInvalid(bool force = False) { }

	public void Shutdown() { }

	private Material CacheMaterialInstance(Material asset, ref Material inst) { }

	private void ReleaseMaterialInstance(ref Material mat) { }

	private Material CacheGoodMaterial() { }

	private Material CacheNeutralMaterial() { }

	private Material CacheBadMaterial() { }

	private void UpdateGuideTransparency(bool transparent) { }

	public void .ctor() { }

}

private enum Planner.Guide.PlacementState // TypeDefIndex: 8617
{	public int value__; // 0x0
	public const Planner.Guide.PlacementState Invalid = 0;
	public const Planner.Guide.PlacementState Neutral = 1;
	public const Planner.Guide.PlacementState Valid = 2;

}

private sealed class Planner.<>c__DisplayClass9_0 // TypeDefIndex: 8618
{	public Construction construction; // 0x10
	public Planner <>4__this; // 0x18


	public void .ctor() { }

	internal void <OpenComponentMenu>b__0(BasePlayer ply) { }

}

