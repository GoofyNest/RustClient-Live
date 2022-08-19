public class BaseArcadeGame : BaseMonoBehaviour // TypeDefIndex: 8762
{	// Fields
	public static List<BaseArcadeGame> globalActiveGames; // 0x0
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

	// Methods

	// RVA: 0x7EAC30 Offset: 0x7EA030 VA: 0x1807EAC30
	public void SendArcadeEntityMessage(ArcadeEntity ent, string msg) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	public virtual void OnNoHost() { }

	// RVA: 0x7EA4F0 Offset: 0x7E98F0 VA: 0x1807EA4F0
	public bool IsGameAuthorative() { }

	// RVA: 0x7EAD10 Offset: 0x7EA110 VA: 0x1807EAD10
	public void SetGameAuthorative(bool wants) { }

	// RVA: 0x7EA2A0 Offset: 0x7E96A0 VA: 0x1807EA2A0
	public Sprite GetSprite(uint index) { }

	// RVA: 0x7EA1B0 Offset: 0x7E95B0 VA: 0x1807EA1B0
	public uint GetSpriteIndex(Sprite sprite) { }

	// RVA: 0x7E9C40 Offset: 0x7E9040 VA: 0x1807E9C40
	public ArcadeEntityController CreateEntityViaController(ArcadeEntityController controllerPrefab, Vector3 pos, Vector3 heading) { }

	// RVA: 0x7E94E0 Offset: 0x7E88E0 VA: 0x1807E94E0
	public float ClampMouseDelta(float delta) { }

	// RVA: 0x7EA830 Offset: 0x7E9C30 VA: 0x1807EA830
	public void RenderGame() { }

	// RVA: 0x7EA560 Offset: 0x7E9960 VA: 0x1807EA560
	public void OnDisable() { }

	// RVA: 0x7EA130 Offset: 0x7E9530 VA: 0x1807EA130
	public ArcadeEntity GetByID(uint id) { }

	// RVA: 0x7EA010 Offset: 0x7E9410 VA: 0x1807EA010
	public int GetArcadeEntityManifestIndex(ArcadeEntity source) { }

	// RVA: 0x7EA790 Offset: 0x7E9B90 VA: 0x1807EA790
	public void RegisterArcadeEntity(ArcadeEntity ent, bool onHost = False, uint idOverride = 0) { }

	// RVA: 0x7E9AB0 Offset: 0x7E8EB0 VA: 0x1807E9AB0
	public ArcadeEntity CreateArcadeEntity(ArcadeEntity source, bool onHost = False, uint idOverride = 0) { }

	// RVA: 0x7E9550 Offset: 0x7E8950 VA: 0x1807E9550
	public ArcadeEntity CreateArcadeEntity(uint prefabIndex, bool onHost = False, uint idOverride = 0) { }

	// RVA: 0x7E9DF0 Offset: 0x7E91F0 VA: 0x1807E9DF0
	public void DestroyEntity(uint entityID) { }

	// RVA: 0x7EA990 Offset: 0x7E9D90 VA: 0x1807EA990
	public void Retire(ArcadeEntity toRetire) { }

	// RVA: 0x7EA6C0 Offset: 0x7E9AC0 VA: 0x1807EA6C0
	public void OnGameVisibilityChanged(bool isVisible) { }

	// RVA: 0x7EA2E0 Offset: 0x7E96E0 VA: 0x1807EA2E0 Slot: 7
	public virtual void Initialize() { }

	// RVA: 0x7EA560 Offset: 0x7E9960 VA: 0x1807EA560
	public void Shutdown() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	public virtual void MenuAction(string message) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	public virtual void PlayerInput(InputState inputState, BasePlayer player, int playerIndex = 0, bool clientside = False) { }

	// RVA: 0x7EAA30 Offset: 0x7E9E30 VA: 0x1807EAA30
	public ArcadeGame SaveSnapshot(bool force = True) { }

	// RVA: 0x7E9F90 Offset: 0x7E9390 VA: 0x1807E9F90
	public ArcadeEntity GetArcadeEntityFromCollider(Collider hitCol) { }

	// RVA: 0x7EAE30 Offset: 0x7EA230 VA: 0x1807EAE30 Slot: 10
	public virtual void UpdateGameFromSnapshot(ArcadeGame game) { }

	// RVA: 0x7EB120 Offset: 0x7EA520 VA: 0x1807EB120
	public void .ctor() { }

	// RVA: 0x7EB0A0 Offset: 0x7EA4A0 VA: 0x1807EB0A0
	private static void .cctor() { }

}

