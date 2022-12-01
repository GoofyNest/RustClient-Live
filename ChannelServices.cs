public sealed class ChannelServices // TypeDefIndex: 1187
{
	private static ArrayList registeredChannels;
	private static ArrayList delayedClientChannels;
	private static CrossContextChannel _crossContextSink;
	internal static string CrossContextUrl;
	private static IList oldStartModeTypes;

	internal static CrossContextChannel CrossContextChannel { get; }


	internal static CrossContextChannel get_CrossContextChannel() { }

	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri) { }

	[ObsoleteAttribute]
	public static void RegisterChannel(IChannel chnl) { }

	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	internal static void RegisterChannelConfig(ChannelData channel) { }

	private static object CreateProvider(ProviderData prov) { }

	public static IMessage SyncDispatchMessage(IMessage msg) { }

	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	private static bool IsLocalCall(IMessage callMsg) { }

	internal static object[] GetCurrentChannelInfo() { }

	private static void .cctor() { }

}

