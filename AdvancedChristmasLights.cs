public class AdvancedChristmasLights : IOEntity // TypeDefIndex: 8301
{	// Fields
	private Option __menuOption_Menu_Lightmode_Chasing; // 0x288
	private Option __menuOption_Menu_Lightmode_Fade; // 0x2E0
	private Option __menuOption_Menu_Lightmode_Flashing; // 0x338
	private Option __menuOption_Menu_Lightmode_SlowGlow; // 0x390
	private Option __menuOption_Menu_Lightmode_SteadyOn; // 0x3E8
	public GameObjectRef bulbPrefab; // 0x440
	public LineRenderer lineRenderer; // 0x448
	public List<AdvancedChristmasLights.pointEntry> points; // 0x450
	public List<BaseBulb> bulbs; // 0x458
	public float bulbSpacing; // 0x460
	public float wireThickness; // 0x464
	public Transform wireEmission; // 0x468
	public AdvancedChristmasLights.AnimationType animationStyle; // 0x470
	public RendererLOD _lod; // 0x478
	[TooltipAttribute] // RVA: 0xACAC0 Offset: 0xABEC0 VA: 0x1800ACAC0
	public float lengthToPowerRatio; // 0x480
	private bool finalized; // 0x484
	private int lengthUsed; // 0x488
	private int oldAnimationStyle; // 0x48C
	private int oldPointCount; // 0x490

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xA9B470 Offset: 0xA9A870 VA: 0x180A9B470 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA9D370 Offset: 0xA9C770 VA: 0x180A9D370 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA9C450 Offset: 0xA9B850 VA: 0x180A9C450 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA9B410 Offset: 0xA9A810 VA: 0x180A9B410
	public void ClearPoints() { }

	// RVA: 0xA9B460 Offset: 0xA9A860 VA: 0x180A9B460
	public void FinishEditing() { }

	// RVA: 0xA9BF80 Offset: 0xA9B380 VA: 0x180A9BF80
	public bool IsFinalized() { }

	// RVA: 0xA9B320 Offset: 0xA9A720 VA: 0x180A9B320
	public void AddPoint(Vector3 newPoint, Vector3 newNormal) { }

	// RVA: 0x70CC90 Offset: 0x70C090 VA: 0x18070CC90 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0xA9BFA0 Offset: 0xA9B3A0 VA: 0x180A9BFA0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA9C540 Offset: 0xA9B940 VA: 0x180A9C540 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0xA9D130 Offset: 0xA9C530 VA: 0x180A9D130
	public void UpdateBulbs() { }

	// RVA: 0xA9D000 Offset: 0xA9C400 VA: 0x180A9D000 Slot: 159
	public virtual void SetBulbsOn(bool wantsOn) { }

	// RVA: 0xA9D250 Offset: 0xA9C650 VA: 0x180A9D250
	public void UpdateCulling() { }

	// RVA: 0xA9C600 Offset: 0xA9BA00 VA: 0x180A9C600
	public void RegenerateLights() { }

	[BaseEntity.Menu] // RVA: 0xACB60 Offset: 0xABF60 VA: 0x1800ACB60
	[BaseEntity.Menu.Description] // RVA: 0xACB60 Offset: 0xABF60 VA: 0x1800ACB60
	[BaseEntity.Menu.Icon] // RVA: 0xACB60 Offset: 0xABF60 VA: 0x1800ACB60
	[BaseEntity.Menu.ShowIf] // RVA: 0xACB60 Offset: 0xABF60 VA: 0x1800ACB60
	// RVA: 0xA9C3F0 Offset: 0xA9B7F0 VA: 0x180A9C3F0
	public void Menu_Lightmode_SteadyOn(BasePlayer player) { }

	// RVA: 0xA9C3E0 Offset: 0xA9B7E0 VA: 0x180A9C3E0
	public bool Menu_Lightmode_SteadyOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xACE70 Offset: 0xAC270 VA: 0x1800ACE70
	[BaseEntity.Menu.Description] // RVA: 0xACE70 Offset: 0xAC270 VA: 0x1800ACE70
	[BaseEntity.Menu.Icon] // RVA: 0xACE70 Offset: 0xAC270 VA: 0x1800ACE70
	[BaseEntity.Menu.ShowIf] // RVA: 0xACE70 Offset: 0xAC270 VA: 0x1800ACE70
	// RVA: 0xA9C340 Offset: 0xA9B740 VA: 0x180A9C340
	public void Menu_Lightmode_Flashing(BasePlayer player) { }

	// RVA: 0xA9C330 Offset: 0xA9B730 VA: 0x180A9C330
	public bool Menu_Lightmode_Flashing_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAE690 Offset: 0xADA90 VA: 0x1800AE690
	[BaseEntity.Menu.Description] // RVA: 0xAE690 Offset: 0xADA90 VA: 0x1800AE690
	[BaseEntity.Menu.Icon] // RVA: 0xAE690 Offset: 0xADA90 VA: 0x1800AE690
	[BaseEntity.Menu.ShowIf] // RVA: 0xAE690 Offset: 0xADA90 VA: 0x1800AE690
	// RVA: 0xA9C280 Offset: 0xA9B680 VA: 0x180A9C280
	public void Menu_Lightmode_Chasing(BasePlayer player) { }

	// RVA: 0xA9C270 Offset: 0xA9B670 VA: 0x180A9C270
	public bool Menu_Lightmode_Chasing_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAFCA0 Offset: 0xAF0A0 VA: 0x1800AFCA0
	[BaseEntity.Menu.Description] // RVA: 0xAFCA0 Offset: 0xAF0A0 VA: 0x1800AFCA0
	[BaseEntity.Menu.Icon] // RVA: 0xAFCA0 Offset: 0xAF0A0 VA: 0x1800AFCA0
	[BaseEntity.Menu.ShowIf] // RVA: 0xAFCA0 Offset: 0xAF0A0 VA: 0x1800AFCA0
	// RVA: 0xA9C2E0 Offset: 0xA9B6E0 VA: 0x180A9C2E0
	public void Menu_Lightmode_Fade(BasePlayer player) { }

	// RVA: 0xA9C2D0 Offset: 0xA9B6D0 VA: 0x180A9C2D0
	public bool Menu_Lightmode_Fade_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAFEC0 Offset: 0xAF2C0 VA: 0x1800AFEC0
	[BaseEntity.Menu.Description] // RVA: 0xAFEC0 Offset: 0xAF2C0 VA: 0x1800AFEC0
	[BaseEntity.Menu.Icon] // RVA: 0xAFEC0 Offset: 0xAF2C0 VA: 0x1800AFEC0
	[BaseEntity.Menu.ShowIf] // RVA: 0xAFEC0 Offset: 0xAF2C0 VA: 0x1800AFEC0
	// RVA: 0xA9C390 Offset: 0xA9B790 VA: 0x180A9C390
	public void Menu_Lightmode_SlowGlow(BasePlayer player) { }

	// RVA: 0xA9C440 Offset: 0xA9B840 VA: 0x180A9C440
	public bool Menu_Lightmode_slowglow_ShowIf(BasePlayer player) { }

	// RVA: 0xA9BF90 Offset: 0xA9B390 VA: 0x180A9BF90
	public bool IsStyle(AdvancedChristmasLights.AnimationType testType) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	public bool CanPlayerManipulate(BasePlayer player) { }

	// RVA: 0xA9D280 Offset: 0xA9C680 VA: 0x180A9D280
	public void .ctor() { }

}

public struct AdvancedChristmasLights.pointEntry // TypeDefIndex: 8302
{	// Fields
	public Vector3 point; // 0x0
	public Vector3 normal; // 0xC

}

public enum AdvancedChristmasLights.AnimationType // TypeDefIndex: 8303
{	// Fields
	public int value__; // 0x0
	public const AdvancedChristmasLights.AnimationType ON = 1;
	public const AdvancedChristmasLights.AnimationType FLASHING = 2;
	public const AdvancedChristmasLights.AnimationType CHASING = 3;
	public const AdvancedChristmasLights.AnimationType FADE = 4;
	public const AdvancedChristmasLights.AnimationType SLOWGLOW = 6;

}

