internal class CompiledIdentityConstraint // TypeDefIndex: 2143
{
	internal XmlQualifiedName name; 
	private CompiledIdentityConstraint.ConstraintRole role; 
	private Asttree selector; 
	private Asttree[] fields; 
	internal XmlQualifiedName refer; 
	public static readonly CompiledIdentityConstraint Empty; 

public CompiledIdentityConstraint.ConstraintRole Role { get; }
public Asttree Selector { get; }
public Asttree[] Fields { get; }


public CompiledIdentityConstraint.ConstraintRole get_Role() { }

public Asttree get_Selector() { }

public Asttree[] get_Fields() { }

private void .ctor() { }

public void .ctor(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr) { }

private static void .cctor() { }

}

public enum CompiledIdentityConstraint.ConstraintRole // TypeDefIndex: 2144
{
	public int value__; 
public const CompiledIdentityConstraint.ConstraintRole Unique = 0;
public const CompiledIdentityConstraint.ConstraintRole Key = 1;
public const CompiledIdentityConstraint.ConstraintRole Keyref = 2;

}

