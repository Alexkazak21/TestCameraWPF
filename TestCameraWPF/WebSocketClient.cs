using System;
using System.Text;
using System.Net.Security;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;
using TestCameraWPF.Machine;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Security.Policy;


namespace TestCameraWPF;

public class WebSocketClient
{
    private CamerasSourceModel _camerasSourceModel;
    private ClientWebSocket _clientWebSocket;

    public WebSocketClient(CamerasSourceModel camerasSourceModel)
    {
        _camerasSourceModel = camerasSourceModel;
    }

    public async Task ConnectToServer(string serverUri)
    {
        using (_clientWebSocket = new ClientWebSocket())
        {
            // Bypass SSL certificate validation
            _clientWebSocket.Options.RemoteCertificateValidationCallback =
                (sender, certificate, chain, sslPolicyErrors) => true;

            try
            {
                await _clientWebSocket.ConnectAsync(new Uri(serverUri), CancellationToken.None);

                // Receive messages from the server
                byte[] receiveBuffer = new byte[1024 * 4];
                while (_clientWebSocket.State == WebSocketState.Open)
                {
                    WebSocketReceiveResult result = await _clientWebSocket.ReceiveAsync(new ArraySegment<byte>(receiveBuffer), CancellationToken.None);
                    if (result.MessageType == WebSocketMessageType.Text)
                    {
                        string receivedMessage = Encoding.UTF8.GetString(receiveBuffer, 0, result.Count);
                        var machineStateInfo = JsonConvert.DeserializeObject<MachineStateDTO>(receivedMessage);
                        _camerasSourceModel.MachineState = machineStateInfo!;
                        _camerasSourceModel.PlatformImageSource = machineStateInfo.GetPlatformImage();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Close the WebSocket connection
            await _clientWebSocket.CloseAsync(WebSocketCloseStatus.NormalClosure,
                                             "Closing connection",
                                             CancellationToken.None);
        } 
    }

    

    public enum EPlatformOperationStatus
    {
        DOWN_DONE,
        DOWN_IN_PROGRESS,
        UP_DONE,
        UP_IN_PROGRESS,
        UNDEFINED
    }
}
