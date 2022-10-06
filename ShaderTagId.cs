public struct ShaderTagId : IEquatable<ShaderTagId> // TypeDefIndex: 3855
{
	public static readonly ShaderTagId none; 
	private int m_Id; 

	internal int id { get; set; }
	public string name { get; }


	public void .ctor(string name) { }

	internal int get_id() { }

	internal void set_id(int value) { }

	public string get_name() { }

	public override bool Equals(object obj) { }

	public bool Equals(ShaderTagId other) { }

	public override int GetHashCode() { }

	private static void .cctor() { }

}

