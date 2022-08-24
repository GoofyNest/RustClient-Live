public class WheelSwitch : IOEntity // TypeDefIndex: 8487
{
	private Option __menuOption_Menu_Turn; 
	public Transform wheelObj; 
	public float rotateSpeed; 
	public BaseEntity.Flags BeingRotated; 
	public BaseEntity.Flags RotatingLeft; 
	public BaseEntity.Flags RotatingRight; 
	public float rotateProgress; 
	public Animator animator; 
	public float kineticEnergyPerSec; 
	private BasePlayer rotatorPlayer; 
	private float animProgress; 

public override bool HasMenuOptions { get; }


public override void GetMenuOptions(List<Option> list) { }

public override bool get_HasMenuOptions() { }

public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

public override void OnUseStopped(BasePlayer player) { }

public override void PostNetworkUpdate() { }

public void Update() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
public void Menu_Turn(BasePlayer player) { }

public bool Menu_Turn_ShowIf(BasePlayer player) { }

public bool IsBeingRotated() { }

public override void Load(BaseNetworkable.LoadInfo info) { }

public void .ctor() { }

}

