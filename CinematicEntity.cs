public class CinematicEntity : BaseEntity // TypeDefIndex: 9274
{
private const BaseEntity.Flags HideMesh = 128;
	public GameObject[] DisableObjects; 
	private static List<CinematicEntity> clientList; 
	public static Nullable<bool> demoOverride; 


public override void ClientOnEnable() { }

	[ClientVar] 
public static void DemoHideObjects(ConsoleSystem.Arg args) { }

	[ClientVar] 
public static void RemoveDemoOverride() { }

public override void DestroyShared() { }

public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

private void ToggleObjects(bool state) { }

public void .ctor() { }

private static void .cctor() { }

}

