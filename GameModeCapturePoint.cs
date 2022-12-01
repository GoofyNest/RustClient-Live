public class GameModeCapturePoint : BaseEntity // TypeDefIndex: 11626
{
	public CapturePointTrigger captureTrigger;
	public float timeToCapture;
	public int scorePerSecond;
	public string scoreName;
	private float captureFraction;
	private int captureTeam;
	private int capturingTeam;
	public EntityRef capturingPlayer;
	public EntityRef capturedPlayer;
	public const BaseEntity.Flags Flag_Contested = 8192;
	public RustText capturePointText;
	public RustText captureOwnerName;
	public Image captureProgressImage;
	public GameObjectRef progressBeepEffect;
	public GameObjectRef progressCompleteEffect;
	public Transform computerPoint;


	public bool IsContested() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void PostNetworkUpdate() { }

	public void .ctor() { }

}

