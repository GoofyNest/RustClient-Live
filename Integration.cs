public class Integration : BaseIntegration // TypeDefIndex: 8229
{
	[CompilerGeneratedAttribute] 
	private Action OnManifestUpdated; 
	[CompilerGeneratedAttribute] 
	private Action OnServerMetadataUpdated; 
	private Auth _auth; 
	private IAuthTicket _steamTicket; 

	public override string PublicKey { get; }
	public override string Bucket { get; }
	public override string UserId { get; }
	public override string UserName { get; }
	public override Auth Auth { get; }
	public override string ServerAddress { get; }
	public override string ServerName { get; }


	public override string get_PublicKey() { }

	public override string get_Bucket() { }

	[CompilerGeneratedAttribute] 
	public void add_OnManifestUpdated(Action value) { }

	[CompilerGeneratedAttribute] 
	public void remove_OnManifestUpdated(Action value) { }

	public override void OnManifestFile(Manifest manifest) { }

	[CompilerGeneratedAttribute] 
	public void add_OnServerMetadataUpdated(Action value) { }

	[CompilerGeneratedAttribute] 
	public void remove_OnServerMetadataUpdated(Action value) { }

	public override void OnServerMetadata(Dictionary<IPEndPoint, int> metadata) { }

	public override string get_UserId() { }

	public override string get_UserName() { }

	public override Auth get_Auth() { }

	public override bool ShouldReportException(string message, string stackTrace, LogType type) { }

	public override string get_ServerAddress() { }

	public override string get_ServerName() { }

	public void .ctor() { }

}

