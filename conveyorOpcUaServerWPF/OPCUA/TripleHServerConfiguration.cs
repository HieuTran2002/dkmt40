using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleH;

using System.Runtime.Serialization;
using Opc.Ua;

namespace ConveyorOpcUAServer
{
    [DataContract(Namespace = TripleH.Namespaces.TripleH)]
    public class TripleHServerConfiguration
    {
        public TripleHServerConfiguration()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes the object during deserialization.
        /// </summary>
        [OnDeserializing()]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
        }
    }
}
