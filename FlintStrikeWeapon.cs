public class FlintStrikeWeapon : BaseProjectile // TypeDefIndex: 11173
{
	public float successFraction; 
	public RecoilProperties strikeRecoil; 
	private bool _didSparkThisFrame; 
	private bool _isStriking; 
	private int strikes; 
	private TimeSince lastSpectatorAttack; 


	public override RecoilProperties GetRecoil() { }

	public override void DoAttack() { }

	public override void OnFrame() { }

	public override void OnViewmodelEvent(string name) { }

	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	public void .ctor() { }

}

