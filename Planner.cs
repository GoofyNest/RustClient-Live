public class Planner : HeldEntity // TypeDefIndex: 8615
{	// Fields
	private Vector3 rotationOffset; // 0x1F8
	private bool hasAppliedStartingRotation; // 0x204
	public Construction currentConstruction; // 0x208
	internal Planner.Guide guide; // 0x210
	public BaseEntity[] buildableList; // 0x218

	// Properties
	public bool isTypeDeployable { get; }

	// Methods

	// RVA: 0x8E0740 Offset: 0x8DFB40 VA: 0x1808E0740 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8E0C40 Offset: 0x8E0040 VA: 0x1808E0C40 Slot: 27
	public override void ResetState() { }

	// RVA: 0x8E0490 Offset: 0x8DF890 VA: 0x1808E0490 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x8E0100 Offset: 0x8DF500 VA: 0x1808E0100 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x8E04B0 Offset: 0x8DF8B0 VA: 0x1808E04B0 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x8E04D0 Offset: 0x8DF8D0 VA: 0x1808E04D0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x8E0830 Offset: 0x8DFC30 VA: 0x1808E0830
	private void OpenComponentMenu() { }

	// RVA: 0x8E0D80 Offset: 0x8E0180 VA: 0x1808E0D80
	private void SwitchConstruction(Construction c) { }

	// RVA: 0x8DEB80 Offset: 0x8DDF80 VA: 0x1808DEB80
	private void DoBuild() { }

	// RVA: 0x8E0CC0 Offset: 0x8E00C0 VA: 0x1808E0CC0
	private void SetDefaultPlan() { }

	// RVA: 0x8E0080 Offset: 0x8DF480 VA: 0x1808E0080 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x8E0E10 Offset: 0x8E0210 VA: 0x1808E0E10
	private void UpdateGuide() { }

	// RVA: 0x8DEA70 Offset: 0x8DDE70 VA: 0x1808DEA70
	private void CloseGuide() { }

	// RVA: 0x8DF250 Offset: 0x8DE650 VA: 0x1808DF250
	internal void FillPlacement(ref Construction.Target target, Construction component) { }

	// RVA: 0x8DFA20 Offset: 0x8DEE20 VA: 0x1808DFA20
	internal void FindTerrainPlacement(ref Construction.Target target, Construction component) { }

	// RVA: 0x8DF330 Offset: 0x8DE730 VA: 0x1808DF330
	internal bool FindAppropriateHandle(ref Construction.Target target, Construction component) { }

	// RVA: 0x8DFFF0 Offset: 0x8DF3F0 VA: 0x1808DFFF0
	public ItemModDeployable GetModDeployable() { }

	// RVA: 0x8DFF50 Offset: 0x8DF350 VA: 0x1808DFF50
	public Deployable GetDeployable() { }

	// RVA: 0x8E1110 Offset: 0x8E0510 VA: 0x1808E1110
	public bool get_isTypeDeployable() { }

	// RVA: 0x8E1040 Offset: 0x8E0440 VA: 0x1808E1040
	public void .ctor() { }

}

public class Planner.Guide // TypeDefIndex: 8616
{	// Fields
	public GameObject guideObject; // 0x10
	public Construction.Target lastPlacement; // 0x18
	private Construction component; // 0x80
	private Material goodMat; // 0x88
	private Material neutralMat; // 0x90
	private Material badMat; // 0x98
	private bool wasTransparent; // 0xA0
	private Planner.Guide.PlacementState lastPlacementState; // 0xA4

	// Methods

	// RVA: 0x8C9F50 Offset: 0x8C9350 VA: 0x1808C9F50
	public bool IsValid() { }

	// RVA: 0x8CA150 Offset: 0x8C9550 VA: 0x1808CA150
	private void UpdateComponent(Construction c) { }

	// RVA: 0x8CA390 Offset: 0x8C9790 VA: 0x1808CA390
	public void Update(ref Construction.Target placement, Construction currentComponent) { }

	// RVA: 0x8C9CD0 Offset: 0x8C90D0 VA: 0x1808C9CD0
	public void BecomeValid() { }

	// RVA: 0x8C9C80 Offset: 0x8C9080 VA: 0x1808C9C80
	public void BecomeNeutral() { }

	// RVA: 0x8C9C30 Offset: 0x8C9030 VA: 0x1808C9C30
	public void BecomeInvalid(bool force = False) { }

	// RVA: 0x8CA060 Offset: 0x8C9460 VA: 0x1808CA060
	public void Shutdown() { }

	// RVA: 0x8C9E20 Offset: 0x8C9220 VA: 0x1808C9E20
	private Material CacheMaterialInstance(Material asset, ref Material inst) { }

	// RVA: 0x8C9FB0 Offset: 0x8C93B0 VA: 0x1808C9FB0
	private void ReleaseMaterialInstance(ref Material mat) { }

	// RVA: 0x8C9DA0 Offset: 0x8C91A0 VA: 0x1808C9DA0
	private Material CacheGoodMaterial() { }

	// RVA: 0x8C9ED0 Offset: 0x8C92D0 VA: 0x1808C9ED0
	private Material CacheNeutralMaterial() { }

	// RVA: 0x8C9D20 Offset: 0x8C9120 VA: 0x1808C9D20
	private Material CacheBadMaterial() { }

	// RVA: 0x8CA2F0 Offset: 0x8C96F0 VA: 0x1808CA2F0
	private void UpdateGuideTransparency(bool transparent) { }

	// RVA: 0x8CAFC0 Offset: 0x8CA3C0 VA: 0x1808CAFC0
	public void .ctor() { }

}

private enum Planner.Guide.PlacementState // TypeDefIndex: 8617
{	// Fields
	public int value__; // 0x0
	public const Planner.Guide.PlacementState Invalid = 0;
	public const Planner.Guide.PlacementState Neutral = 1;
	public const Planner.Guide.PlacementState Valid = 2;

}

private sealed class Planner.<>c__DisplayClass9_0 // TypeDefIndex: 8618
{	// Fields
	public Construction construction; // 0x10
	public Planner <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x8E4D90 Offset: 0x8E4190 VA: 0x1808E4D90
	internal void <OpenComponentMenu>b__0(BasePlayer ply) { }

}

