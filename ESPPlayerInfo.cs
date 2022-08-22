public class ESPPlayerInfo : MonoBehaviour // TypeDefIndex: 12002
{	public Vector3 WorldOffset; // 0x18
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

	public BasePlayer Entity { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public BasePlayer get_Entity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Entity(BasePlayer value) { }

	public void Clear() { }

	internal void Init(BasePlayer entity) { }

	private void UpdateText(BasePlayer entity) { }

	private void SetColor(Color color) { }

	private void Update() { }

	private void LateQueuedUpdate() { }

	public Vector3 GetVisCheckPosition() { }

	public void VisCheckPosition() { }

	public bool IsTeamMember() { }

	public void SetTextEnabled(bool wantsOn) { }

	private bool IsAlly() { }

	private bool IsEnemy() { }

	private void UpdateColor() { }

	private void Position() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class ESPPlayerInfo.ESPWorkQueue : ObjectWorkQueue<ESPPlayerInfo> // TypeDefIndex: 12003
{
	protected override void RunJob(ESPPlayerInfo entity) { }

	protected override bool ShouldAdd(ESPPlayerInfo entity) { }

	public void .ctor() { }

}

