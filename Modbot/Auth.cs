using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace Modbot
{
    class Auth
    {

    }

    [DataContract(Namespace = "urn:Curse.FriendsService:v1")]
    public class AuthenticationToken
    {
        [DataMember]
        public int UserID { get; set; }

        [DataMember]
        public string Token { get; set; }

        [DataMember]
        public string ApiKey { get; set; }
    }

    public class AuthTokenExtension : IEndpointBehavior, IClientMessageInspector
    {
        private AuthenticationToken Token { get; set; }

        public AuthTokenExtension(AuthenticationToken token)
        {
            Token = token;
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            MessageHeader header = MessageHeader.CreateHeader("AuthenticationToken", "urn:Curse.FriendsService:v1", Token);
            request.Headers.Add(header);
            return null;
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            clientRuntime.MessageInspectors.Add(this);
        }

        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {
        }

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
        }

        public void Validate(ServiceEndpoint endpoint)
        {
        }
    }
}
