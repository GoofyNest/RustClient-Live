public class GameModeCapturePoint : BaseEntity // TypeDefIndex: 9881
{	public CapturePointTrigger captureTrigger; // 0x168
	public float timeToCapture; // 0x170
	public int scorePerSecond; // 0x174
	public string scoreName; // 0x178
	private float captureFraction; // 0x180
	private int captureTeam; // 0x184
	private int capturingTeam; // 0x188
	public EntityRef capturingPlayer; // 0x190
	public EntityRef capturedPlayer; // 0x1A0
	public const BaseEntity.Flags Flag_Contested = 8192;
	public RustText capturePointText; // 0x1B0
	public RustText captureOwnerName; // 0x1B8
	public Image captureProgressImage; // 0x1C0
	public GameObjectRef progressBeepEffect; // 0x1C8
	public GameObjectRef progressCompleteEffect; // 0x1D0
	public Transform computerPoint; // 0x1D8


	public bool IsContested() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void PostNetworkUpdate() { }

	public void .ctor() { }

}

