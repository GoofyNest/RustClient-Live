public class BaseArcadeGame : BaseMonoBehaviour // TypeDefIndex: 8762
{
	public static List<BaseArcadeGame> globalActiveGames; 
	public Camera cameraToRender; 
	public RenderTexture renderTexture; 
	public Texture2D distantTexture; 
	public Transform center; 
	public int frameRate; 
	public Dictionary<uint, ArcadeEntity> activeArcadeEntities; 
	public Sprite[] spriteManifest; 
	public ArcadeEntity[] entityManifest; 
	public bool clientside; 
	public bool clientsideInput; 
	public const int spriteIndexInvisible = 1555;
	public GameObject arcadeEntityPrefab; 
	public BaseArcadeMachine ownerMachine; 
	public static int gameOffsetIndex; 
	private bool isAuthorative; 
	public Canvas canvas; 
	private float lastFrameRate; 
	private uint lastEntityID; 
	private bool currentGameVisibility; 
	private float lastSnapshotTime; 


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

