public class AdvancedChristmasLights : IOEntity // TypeDefIndex: 9971
{
	private Option __menuOption_Menu_Lightmode_Chasing; 
	private Option __menuOption_Menu_Lightmode_Fade; 
	private Option __menuOption_Menu_Lightmode_Flashing; 
	private Option __menuOption_Menu_Lightmode_SlowGlow; 
	private Option __menuOption_Menu_Lightmode_SteadyOn; 
	public GameObjectRef bulbPrefab; 
	public LineRenderer lineRenderer; 
	public List<AdvancedChristmasLights.pointEntry> points; 
	public List<BaseBulb> bulbs; 
	public float bulbSpacing; 
	public float wireThickness; 
	public Transform wireEmission; 
	public AdvancedChristmasLights.AnimationType animationStyle; 
	public RendererLOD _lod; 
	[TooltipAttribute] 
	public float lengthToPowerRatio; 
	private bool finalized; 
	private int lengthUsed; 
	private int oldAnimationStyle; 
	private int oldPointCount; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void ClearPoints() { }

	public void FinishEditing() { }

	public bool IsFinalized() { }

	public void AddPoint(Vector3 newPoint, Vector3 newNormal) { }

	public override int ConsumptionAmount() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void PostNetworkUpdate() { }

	public void UpdateBulbs() { }

	public virtual void SetBulbsOn(bool wantsOn) { }

	public void UpdateCulling() { }

	public void RegenerateLights() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Lightmode_SteadyOn(BasePlayer player) { }

	public bool Menu_Lightmode_SteadyOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Lightmode_Flashing(BasePlayer player) { }

	public bool Menu_Lightmode_Flashing_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Lightmode_Chasing(BasePlayer player) { }

	public bool Menu_Lightmode_Chasing_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Lightmode_Fade(BasePlayer player) { }

	public bool Menu_Lightmode_Fade_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Lightmode_SlowGlow(BasePlayer player) { }

	public bool Menu_Lightmode_slowglow_ShowIf(BasePlayer player) { }

	public bool IsStyle(AdvancedChristmasLights.AnimationType testType) { }

	public bool CanPlayerManipulate(BasePlayer player) { }

	public void .ctor() { }

}

public struct AdvancedChristmasLights.pointEntry // TypeDefIndex: 9972
{
	public Vector3 point; 
	public Vector3 normal; 

}

public enum AdvancedChristmasLights.AnimationType // TypeDefIndex: 9973
{
	public int value__; 
	public const AdvancedChristmasLights.AnimationType ON = 1;
	public const AdvancedChristmasLights.AnimationType FLASHING = 2;
	public const AdvancedChristmasLights.AnimationType CHASING = 3;
	public const AdvancedChristmasLights.AnimationType FADE = 4;
	public const AdvancedChristmasLights.AnimationType SLOWGLOW = 6;

}

