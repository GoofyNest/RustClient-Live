public class ClipperRegistry // TypeDefIndex: 4912
{	private static ClipperRegistry s_Instance; // 0x0
	private readonly IndexedSet<IClipper> m_Clippers; // 0x10

	public static ClipperRegistry instance { get; }


	protected void .ctor() { }

	public static ClipperRegistry get_instance() { }

	public void Cull() { }

	public static void Register(IClipper c) { }

	public static void Unregister(IClipper c) { }

}

