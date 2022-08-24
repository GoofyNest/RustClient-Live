public sealed class SecurityPermission : CodeAccessPermission // TypeDefIndex: 916
{

[ComVisibleAttribute] 
[Serializable]
public sealed class SecurityPermission : CodeAccessPermission 
	private SecurityPermissionFlag flags; 


	public void .ctor(PermissionState state) { }

	public bool IsUnrestricted() { }

	public override bool IsSubsetOf(IPermission target) { }

	public override SecurityElement ToXml() { }

	private bool IsEmpty() { }

	private SecurityPermission Cast(IPermission target) { }

}

