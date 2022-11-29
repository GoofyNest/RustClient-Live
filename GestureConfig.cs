public class GestureConfig : ScriptableObject // TypeDefIndex: 11832
{
	[ReadOnlyAttribute] 
	public uint gestureId; 
	public string gestureCommand; 
	public string convarName; 
	public Translate.Phrase gestureName; 
	public Sprite icon; 
	public int order; 
	public float duration; 
	public bool canCancel; 
	[HeaderAttribute] 
	public GestureConfig.PlayerModelLayer playerModelLayer; 
	public GestureConfig.MovementCapabilities movementMode; 
	public GestureConfig.AnimationType animationType; 
	public BasePlayer.CameraMode viewMode; 
	public bool useRootMotion; 
	public GestureConfig.GestureActionType actionType; 
	public bool forceUnlock; 
	public SteamDLCItem dlcItem; 
	public SteamInventoryItem inventoryItem; 


	public bool IsOwnedBy(BasePlayer player) { }

	public bool CanBeUsedBy(BasePlayer player) { }

	public void .ctor() { }

}

public enum GestureConfig.PlayerModelLayer // TypeDefIndex: 11833
{
	public int value__; 
	public const GestureConfig.PlayerModelLayer UpperBody = 3;
	public const GestureConfig.PlayerModelLayer FullBody = 4;

}

public enum GestureConfig.MovementCapabilities // TypeDefIndex: 11834
{
	public int value__; 
	public const GestureConfig.MovementCapabilities FullMovement = 0;
	public const GestureConfig.MovementCapabilities NoMovement = 1;

}

public enum GestureConfig.AnimationType // TypeDefIndex: 11835
{
	public int value__; 
	public const GestureConfig.AnimationType OneShot = 0;
	public const GestureConfig.AnimationType Loop = 1;

}

public enum GestureConfig.ViewMode // TypeDefIndex: 11836
{
	public int value__; 
	public const GestureConfig.ViewMode FirstPerson = 0;
	public const GestureConfig.ViewMode ThirdPerson = 1;

}

public enum GestureConfig.GestureActionType // TypeDefIndex: 11837
{
	public int value__; 
	public const GestureConfig.GestureActionType None = 0;
	public const GestureConfig.GestureActionType ShowNameTag = 1;
	public const GestureConfig.GestureActionType DanceAchievement = 2;

}

