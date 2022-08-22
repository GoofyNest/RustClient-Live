public class GestureConfig : ScriptableObject // TypeDefIndex: 10086
{	[ReadOnlyAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public uint gestureId; // 0x18
	public string gestureCommand; // 0x20
	public string convarName; // 0x28
	public Translate.Phrase gestureName; // 0x30
	public Sprite icon; // 0x38
	public int order; // 0x40
	public float duration; // 0x44
	public bool canCancel; // 0x48
	[HeaderAttribute] // RVA: 0xB3C60 Offset: 0xB3060 VA: 0x1800B3C60
	public GestureConfig.PlayerModelLayer playerModelLayer; // 0x4C
	public GestureConfig.MovementCapabilities movementMode; // 0x50
	public GestureConfig.AnimationType animationType; // 0x54
	public BasePlayer.CameraMode viewMode; // 0x58
	public bool useRootMotion; // 0x5C
	public GestureConfig.GestureActionType actionType; // 0x60
	public bool forceUnlock; // 0x64
	public SteamDLCItem dlcItem; // 0x68
	public SteamInventoryItem inventoryItem; // 0x70


	public bool IsOwnedBy(BasePlayer player) { }

	public bool CanBeUsedBy(BasePlayer player) { }

	public void .ctor() { }

}

public enum GestureConfig.PlayerModelLayer // TypeDefIndex: 10087
{	public int value__; // 0x0
	public const GestureConfig.PlayerModelLayer UpperBody = 3;
	public const GestureConfig.PlayerModelLayer FullBody = 4;

}

public enum GestureConfig.MovementCapabilities // TypeDefIndex: 10088
{	public int value__; // 0x0
	public const GestureConfig.MovementCapabilities FullMovement = 0;
	public const GestureConfig.MovementCapabilities NoMovement = 1;

}

public enum GestureConfig.AnimationType // TypeDefIndex: 10089
{	public int value__; // 0x0
	public const GestureConfig.AnimationType OneShot = 0;
	public const GestureConfig.AnimationType Loop = 1;

}

public enum GestureConfig.ViewMode // TypeDefIndex: 10090
{	public int value__; // 0x0
	public const GestureConfig.ViewMode FirstPerson = 0;
	public const GestureConfig.ViewMode ThirdPerson = 1;

}

public enum GestureConfig.GestureActionType // TypeDefIndex: 10091
{	public int value__; // 0x0
	public const GestureConfig.GestureActionType None = 0;
	public const GestureConfig.GestureActionType ShowNameTag = 1;
	public const GestureConfig.GestureActionType DanceAchievement = 2;

}

