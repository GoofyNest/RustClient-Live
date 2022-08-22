public sealed class DesignerSerializationVisibilityAttribute : Attribute // TypeDefIndex: 2695
{	public static readonly DesignerSerializationVisibilityAttribute Content; // 0x0
	public static readonly DesignerSerializationVisibilityAttribute Hidden; // 0x8
	public static readonly DesignerSerializationVisibilityAttribute Visible; // 0x10
	public static readonly DesignerSerializationVisibilityAttribute Default; // 0x18
	private DesignerSerializationVisibility visibility; // 0x10

	public DesignerSerializationVisibility Visibility { get; }


	public void .ctor(DesignerSerializationVisibility visibility) { }

	public DesignerSerializationVisibility get_Visibility() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override bool IsDefaultAttribute() { }

	private static void .cctor() { }

}

