public abstract class CodeAccessPermission : IPermission, ISecurityEncodable // TypeDefIndex: 898
{

protected void .ctor() { }

	[ConditionalAttribute] 
public void Demand() { }

	[ComVisibleAttribute] 
public override bool Equals(object obj) { }

	[ComVisibleAttribute] 
public override int GetHashCode() { }

public abstract bool IsSubsetOf(IPermission target);

public override string ToString() { }

public abstract SecurityElement ToXml();

internal SecurityElement Element(int version) { }

internal static PermissionState CheckPermissionState(PermissionState state, bool allowUnrestricted) { }

internal static void ThrowInvalidPermission(IPermission target, Type expected) { }

private void System.Security.IPermission.Demand() { }

}

