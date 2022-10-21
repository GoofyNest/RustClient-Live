public class LightListener : BaseEntity // TypeDefIndex: 11357
{
	public string onMessage; 
	public string offMessage; 
	[TooltipAttribute] 
	public LightGroupAtTime onLights; 
	[TooltipAttribute] 
	public LightGroupAtTime offLights; 


	public override void PostNetworkUpdate() { }

	public void SetLightsOn(bool wantsOn) { }

	public void .ctor() { }

}

