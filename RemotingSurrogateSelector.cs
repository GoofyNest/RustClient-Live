public class RemotingSurrogateSelector : ISurrogateSelector // TypeDefIndex: 1257
{
	private static Type s_cachedTypeObjRef; 
	private static ObjRefSurrogate _objRefSurrogate; 
	private static RemotingSurrogate _objRemotingSurrogate; 
	private ISurrogateSelector _next; 


	public void .ctor() { }

	public virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout) { }

	private static void .cctor() { }

}

