public sealed class DesignerSerializationVisibilityAttribute : Attribute // TypeDefIndex: 2695
{
	public static readonly DesignerSerializationVisibilityAttribute Content; 
	public static readonly DesignerSerializationVisibilityAttribute Hidden; 
	public static readonly DesignerSerializationVisibilityAttribute Visible; 
	public static readonly DesignerSerializationVisibilityAttribute Default; 
	private DesignerSerializationVisibility visibility; 

public DesignerSerializationVisibility Visibility { get; }


public void .ctor(DesignerSerializationVisibility visibility) { }

public DesignerSerializationVisibility get_Visibility() { }

public override bool Equals(object obj) { }

public override int GetHashCode() { }

public override bool IsDefaultAttribute() { }

private static void .cctor() { }

}

