public class BaseArcadeGame : BaseMonoBehaviour // TypeDefIndex: 8762
{	public static List<BaseArcadeGame> globalActiveGames; // 0x0
	public Camera cameraToRender; // 0x18
	public RenderTexture renderTexture; // 0x20
	public Texture2D distantTexture; // 0x28
	public Transform center; // 0x30
	public int frameRate; // 0x38
	public Dictionary<uint, ArcadeEntity> activeArcadeEntities; // 0x40
	public Sprite[] spriteManifest; // 0x48
	public ArcadeEntity[] entityManifest; // 0x50
	public bool clientside; // 0x58
	public bool clientsideInput; // 0x59
	public const int spriteIndexInvisible = 1555;
	public GameObject arcadeEntityPrefab; // 0x60
	public BaseArcadeMachine ownerMachine; // 0x68
	public static int gameOffsetIndex; // 0x8
	private bool isAuthorative; // 0x70
	public Canvas canvas; // 0x78
	private float lastFrameRate; // 0x80
	private uint lastEntityID; // 0x84
	private bool currentGameVisibility; // 0x88
	private float lastSnapshotTime; // 0x8C


	public void SendArcadeEntityMessage(ArcadeEntity ent, string msg) { }

	public virtual void OnNoHost() { }

	public bool IsGameAuthorative() { }

	public void SetGameAuthorative(bool wants) { }

	public Sprite GetSprite(uint index) { }

	public uint GetSpriteIndex(Sprite sprite) { }

	public ArcadeEntityController CreateEntityViaController(ArcadeEntityController controllerPrefab, Vector3 pos, Vector3 heading) { }

	public float ClampMouseDelta(float delta) { }

	public void RenderGame() { }

	public void OnDisable() { }

	public ArcadeEntity GetByID(uint id) { }

	public int GetArcadeEntityManifestIndex(ArcadeEntity source) { }

	public void RegisterArcadeEntity(ArcadeEntity ent, bool onHost = False, uint idOverride = 0) { }

	public ArcadeEntity CreateArcadeEntity(ArcadeEntity source, bool onHost = False, uint idOverride = 0) { }

	public ArcadeEntity CreateArcadeEntity(uint prefabIndex, bool onHost = False, uint idOverride = 0) { }

	public void DestroyEntity(uint entityID) { }

	public void Retire(ArcadeEntity toRetire) { }

	public void OnGameVisibilityChanged(bool isVisible) { }

	public virtual void Initialize() { }

	public void Shutdown() { }

	public virtual void MenuAction(string message) { }

	public virtual void PlayerInput(InputState inputState, BasePlayer player, int playerIndex = 0, bool clientside = False) { }

	public ArcadeGame SaveSnapshot(bool force = True) { }

	public ArcadeEntity GetArcadeEntityFromCollider(Collider hitCol) { }

	public virtual void UpdateGameFromSnapshot(ArcadeGame game) { }

	public void .ctor() { }

	private static void .cctor() { }

}

