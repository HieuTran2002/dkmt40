using Opc.Ua;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TripleH;

namespace ConveyorOpcUAServer
{
    public class TripleHNodeManager : CustomNodeManager2
    {
        public TripleHNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        :
       base(server, configuration)
        {
            SystemContext.NodeIdFactory = this;

            // set one namespace for the type model and one names for dynamically created nodes.
            string[] namespaceUrls = new string[2];
            namespaceUrls[0] = TripleH.Namespaces.TripleH;
            namespaceUrls[1] = TripleH.Namespaces.TripleH + "/Instance";

            m_namespaceIndex = Server.NamespaceUris.GetIndexOrAppend(namespaceUrls[1]);

            SetNamespaces(namespaceUrls);

            // get the configuration for the node manager.
            m_configuration = configuration.ParseExtension<TripleHServerConfiguration>();

            // use suitable defaults if no configuration exists.
            if (m_configuration == null)
            {
                m_configuration = new TripleHServerConfiguration();
            }
            m_tripleHStates = new List<TripleHState>();

        }

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();
            predefinedNodes.LoadFromBinaryResource(context,
                "OPCUA/TripleH.PredefinedNodes.uanodes",
                typeof(TripleHNodeManager).GetTypeInfo().Assembly,
                true);

            return predefinedNodes;
        }

        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                LoadPredefinedNodes(SystemContext, externalReferences);

                // find the untyped Batch Plant 1 node that was created when the model was loaded.
                BaseObjectState passiveNode = (BaseObjectState)FindPredefinedNode(new NodeId(TripleH.Objects.TripleH1, NamespaceIndexes[0]), typeof(BaseObjectState));

                // convert the untyped node to a typed node that can be manipulated within the server.
                m_conveyor1 = new TripleHState(null);
                m_conveyor1.Create(SystemContext, passiveNode);

                // replaces the untyped predefined nodes with their strongly typed versions.
                AddPredefinedNode(SystemContext, m_conveyor1);

                m_conveyor1.StartProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStartProcess);
                m_conveyor1.StopProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStopProcess);

                m_simulationTimer = new System.Threading.Timer(DoSimulation, null, 1000, 1000);

            }
        }
        private void CreateBoiler(SystemContext context, int unitNumber)
        {
             TripleHState machine = new TripleHState(null);

            string name = Utils.Format("Boiler #{0}", unitNumber);

            machine.Create(
                context,
                null,
                new QualifiedName(name, m_namespaceIndex),
                null,
                true);

            NodeState folder = (NodeState)FindPredefinedNode(
                ExpandedNodeId.ToNodeId(TripleH.ObjectIds.TripleH1, Server.NamespaceUris),
                typeof(NodeState));

            folder.AddReference(Opc.Ua.ReferenceTypeIds.Organizes, false, machine.NodeId);
            machine.AddReference(Opc.Ua.ReferenceTypeIds.Organizes, true, folder.NodeId);

            string unitLabel = Utils.Format("{0}0", unitNumber);

            UpdateDisplayName(machine.Conveyor, "conveyor 2");
            UpdateDisplayName(machine.Conveyor.Motor1, "Motor 1 1");

            m_tripleHStates.Add(machine);

            AddPredefinedNode(context, machine);

            // Autostart boiler simulation state machine
            IList<Variant> inputArguments = new List<Variant>();
            IList<Variant> outputArguments = new List<Variant>();
            List<ServiceResult> errors = new List<ServiceResult>();
        }

        /// <summary>
        /// Updates the display name for an instance with the unit label name.
        /// </summary>
        /// <param name="instance">The instance to update.</param>
        /// <param name="label">The label to apply.</param>
        /// <remarks>This method assumes the DisplayName has the form NameX001 where X0 is the unit label placeholder.</remarks>
        private void UpdateDisplayName(BaseInstanceState instance, string unitLabel)
        {
            LocalizedText displayName = instance.DisplayName;

            if (displayName != null)
            {
                string text = displayName.Text;

                if (text != null)
                {
                    text = text.Replace("X0", unitLabel);
                }

                displayName = new LocalizedText(displayName.Locale, text);
            }

            instance.DisplayName = displayName;
        }

        public void DoSimulation(object state)
        {
        }

        private ServiceResult OnStartProcess(ISystemContext context, MethodState method, IList<object> inputArguments,
    IList<object> outputArguments)
        {

            return ServiceResult.Good;
        }

        private ServiceResult OnStopProcess(ISystemContext context, MethodState method, IList<object> inputArguments,
IList<object> outputArguments)
        {

            return ServiceResult.Good;
        }

        public TripleHState m_conveyor1;

        #region Private field
        private ushort m_namespaceIndex;
        private TripleHServerConfiguration m_configuration;
        private System.Threading.Timer m_simulationTimer;
        private List<TripleHState> m_tripleHStates;
        #endregion

    }
}
