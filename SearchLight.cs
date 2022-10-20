public class SearchLight : IOEntity // TypeDefIndex: 10149
{
	private Option __menuOption_StopUseLight; 
	private Option __menuOption_UseLight; 
	public GameObject pitchObject; 
	public GameObject yawObject; 
	public GameObject eyePoint; 
	public SoundPlayer turnLoop; 
	public bool needsBuildingPrivilegeToUse; 
	private Vector3 aimDir; 
	private bool wasMoving; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void ResetState() { }

	public override int ConsumptionAmount() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void Update() { }

	private void UpdateAimpoint() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void UseLight(BasePlayer player) { }

	public bool Menu_UseLight_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void StopUseLight(BasePlayer player) { }

	public bool Menu_StopUseLight_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

public static class SearchLight.SearchLightFlags // TypeDefIndex: 10150
{
	public const BaseEntity.Flags PlayerUsing = 2048;

}

