public class ESPPlayerInfo : MonoBehaviour // TypeDefIndex: 12002
{	// Fields
	public Vector3 WorldOffset; // 0x18
	public TextMeshProUGUI Text; // 0x28
	public TextMeshProUGUI Image; // 0x30
	public CanvasGroup group; // 0x38
	public Gradient gradientNormal; // 0x40
	public Gradient gradientTeam; // 0x48
	public Color TeamColor; // 0x50
	public Color AllyColor; // 0x60
	public Color EnemyColor; // 0x70
	public QueryVis visCheck; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BasePlayer <Entity>k__BackingField; // 0x88
	[ClientVar] // RVA: 0xCB980 Offset: 0xCAD80 VA: 0x1800CB980
	[HelpAttribute] // RVA: 0xCB980 Offset: 0xCAD80 VA: 0x1800CB980
	public static float framebudgetms; // 0x0
	private bool inQueue; // 0x90
	public static ESPPlayerInfo.ESPWorkQueue workQueue; // 0x8
	private int numFramesVisible; // 0x94
	private float distanceFromCamera; // 0x98
	private TimeSince lastHealthUpdate; // 0x9C

	// Properties
	public BasePlayer Entity { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0
	public BasePlayer get_Entity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC60 Offset: 0x58D060 VA: 0x18058DC60
	public void set_Entity(BasePlayer value) { }

	// RVA: 0x7819F0 Offset: 0x780DF0 VA: 0x1807819F0
	public void Clear() { }

	// RVA: 0x781CD0 Offset: 0x7810D0 VA: 0x180781CD0
	internal void Init(BasePlayer entity) { }

	// RVA: 0x783980 Offset: 0x782D80 VA: 0x180783980
	private void UpdateText(BasePlayer entity) { }

	// RVA: 0x7827A0 Offset: 0x781BA0 VA: 0x1807827A0
	private void SetColor(Color color) { }

	// RVA: 0x783B70 Offset: 0x782F70 VA: 0x180783B70
	private void Update() { }

	// RVA: 0x782260 Offset: 0x781660 VA: 0x180782260
	private void LateQueuedUpdate() { }

	// RVA: 0x781B00 Offset: 0x780F00 VA: 0x180781B00
	public Vector3 GetVisCheckPosition() { }

	// RVA: 0x783C40 Offset: 0x783040 VA: 0x180783C40
	public void VisCheckPosition() { }

	// RVA: 0x782030 Offset: 0x781430 VA: 0x180782030
	public bool IsTeamMember() { }

	// RVA: 0x7828B0 Offset: 0x781CB0 VA: 0x1807828B0
	public void SetTextEnabled(bool wantsOn) { }

	// RVA: 0x781E10 Offset: 0x781210 VA: 0x180781E10
	private bool IsAlly() { }

	// RVA: 0x781F10 Offset: 0x781310 VA: 0x180781F10
	private bool IsEnemy() { }

	// RVA: 0x7828D0 Offset: 0x781CD0 VA: 0x1807828D0
	private void UpdateColor() { }

	// RVA: 0x782350 Offset: 0x781750 VA: 0x180782350
	private void Position() { }

	// RVA: 0x783D90 Offset: 0x783190 VA: 0x180783D90
	public void .ctor() { }

	// RVA: 0x783D00 Offset: 0x783100 VA: 0x180783D00
	private static void .cctor() { }

}

public class ESPPlayerInfo.ESPWorkQueue : ObjectWorkQueue<ESPPlayerInfo> // TypeDefIndex: 12003
{	// Methods

	// RVA: 0x783DD0 Offset: 0x7831D0 VA: 0x180783DD0 Slot: 6
	protected override void RunJob(ESPPlayerInfo entity) { }

	// RVA: 0x783EE0 Offset: 0x7832E0 VA: 0x180783EE0 Slot: 5
	protected override bool ShouldAdd(ESPPlayerInfo entity) { }

	// RVA: 0x783F80 Offset: 0x783380 VA: 0x180783F80
	public void .ctor() { }

}

