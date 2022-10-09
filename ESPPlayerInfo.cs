public class ESPPlayerInfo : MonoBehaviour // TypeDefIndex: 13743
{
	public Vector3 WorldOffset; 
	public TextMeshProUGUI Text; 
	public TextMeshProUGUI Image; 
	public CanvasGroup group; 
	public Gradient gradientNormal; 
	public Gradient gradientTeam; 
	public Color TeamColor; 
	public Color AllyColor; 
	public Color EnemyColor; 
	public QueryVis visCheck; 
	[CompilerGeneratedAttribute] 
	private BasePlayer <Entity>k__BackingField; 
	[ClientVar] 
	[HelpAttribute] 
	public static float framebudgetms; 
	private bool inQueue; 
	public static ESPPlayerInfo.ESPWorkQueue workQueue; 
	private int numFramesVisible; 
	private float distanceFromCamera; 
	private TimeSince lastHealthUpdate; 

	public BasePlayer Entity { get; set; }


	[CompilerGeneratedAttribute] 
	public BasePlayer get_Entity() { }

	[CompilerGeneratedAttribute] 
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

public class ESPPlayerInfo.ESPWorkQueue : ObjectWorkQueue<ESPPlayerInfo> // TypeDefIndex: 13744
{

	protected override void RunJob(ESPPlayerInfo entity) { }

	protected override bool ShouldAdd(ESPPlayerInfo entity) { }

	public void .ctor() { }

}

