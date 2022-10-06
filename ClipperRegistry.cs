public class ClipperRegistry // TypeDefIndex: 4916
{
	private static ClipperRegistry s_Instance; 
	private readonly IndexedSet<IClipper> m_Clippers; 

	public static ClipperRegistry instance { get; }


	protected void .ctor() { }

	public static ClipperRegistry get_instance() { }

	public void Cull() { }

	public static void Register(IClipper c) { }

	public static void Unregister(IClipper c) { }

}

