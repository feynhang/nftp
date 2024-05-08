using System.Net;
using System.Net.Sockets;

namespace Nftp;

public class FtpClient
{
	public FtpClient(string host, int port)
	{
		_client = new(new IPEndPoint(IPAddress.Parse(host), port));
		_writer = new StreamWriter(_client.GetStream());
		_reader = new StreamReader(_client.GetStream());
	}
	private TcpClient _client;
	private TextWriter _writer;
	private TextReader _reader;

	public FtpResponse? Send(FtpCommand command)
	{
		_writer.WriteLine(command.ToString());
		var resp = _reader.ReadLine();
		if (string.IsNullOrEmpty(resp))
		{
			return null;
		}
		return new FtpResponse(resp);
	}
}
