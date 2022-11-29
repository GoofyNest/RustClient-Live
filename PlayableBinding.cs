public struct PlayableBinding // TypeDefIndex: 3870
{
	private string m_StreamName; 
	private Object m_SourceObject; 
	private Type m_SourceBindingType; 
	private PlayableBinding.CreateOutputMethod m_CreateOutputMethod; 
	public static readonly PlayableBinding[] None; 
	public static readonly double DefaultDuration; 


	private static void .cctor() { }

}

internal sealed class PlayableBinding.CreateOutputMethod : MulticastDelegate // TypeDefIndex: 3871
{

	public void .ctor(object object, IntPtr method) { }

	public virtual PlayableOutput Invoke(PlayableGraph graph, string name) { }

	public virtual IAsyncResult BeginInvoke(PlayableGraph graph, string name, AsyncCallback callback, object object) { }

	public virtual PlayableOutput EndInvoke(IAsyncResult result) { }

}

