public class Planner : HeldEntity // TypeDefIndex: 10338
{
	private Vector3 rotationOffset;
	private bool hasAppliedStartingRotation;
	public Construction currentConstruction;
	internal Planner.Guide guide;
	public BaseEntity[] buildableList;

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

public class Planner.Guide // TypeDefIndex: 10339
{
	public GameObject guideObject;
	public Construction.Target lastPlacement;
	private Construction component;
	private Material goodMat;
	private Material neutralMat;
	private Material badMat;
	private bool wasTransparent;
	private Planner.Guide.PlacementState lastPlacementState;


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

private enum Planner.Guide.PlacementState // TypeDefIndex: 10340
{
	public int value__;
	public const Planner.Guide.PlacementState Invalid = 0;
	public const Planner.Guide.PlacementState Neutral = 1;
	public const Planner.Guide.PlacementState Valid = 2;

}

private sealed class Planner.<>c__DisplayClass9_0 // TypeDefIndex: 10341
{
	public Construction construction;
	public Planner <>4__this;


	public void .ctor() { }

	internal void <OpenComponentMenu>

}

private sealed class Planner.<>c // TypeDefIndex: 10342
{
	public static readonly Planner.<>c <>9;
	public static Func<EntityLink, bool> <>9__20_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <FindAppropriateHandle>

}

