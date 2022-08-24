public sealed class BrowsableAttribute : Attribute // TypeDefIndex: 2670
{
	public static readonly BrowsableAttribute Yes; 
	public static readonly BrowsableAttribute No; 
	public static readonly BrowsableAttribute Default; 
	private bool browsable; 

public bool Browsable { get; }


public void .ctor(bool browsable) { }

public bool get_Browsable() { }

public override bool Equals(object obj) { }

public override int GetHashCode() { }

public override bool IsDefaultAttribute() { }

private static void .cctor() { }

}

