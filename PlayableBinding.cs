public struct PlayableBinding // TypeDefIndex: 3867
{	private string m_StreamName; // 0x0
	private Object m_SourceObject; // 0x8
	private Type m_SourceBindingType; // 0x10
	private PlayableBinding.CreateOutputMethod m_CreateOutputMethod; // 0x18
	public static readonly PlayableBinding[] None; // 0x0
	public static readonly double DefaultDuration; // 0x8


	private static void .cctor() { }

}

internal sealed class PlayableBinding.CreateOutputMethod : MulticastDelegate // TypeDefIndex: 3868
{
	public void .ctor(object object, IntPtr method) { }

	public virtual PlayableOutput Invoke(PlayableGraph graph, string name) { }

	public virtual IAsyncResult BeginInvoke(PlayableGraph graph, string name, AsyncCallback callback, object object) { }

	public virtual PlayableOutput EndInvoke(IAsyncResult result) { }

}

