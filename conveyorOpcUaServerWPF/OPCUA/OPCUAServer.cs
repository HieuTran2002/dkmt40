using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ConveyorOpcUAServer;
using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;

namespace conveyorOpcUaServerWPF
{
    public class OPCUAServer
    {
        #region Constructor

        public OPCUAServer(string serverConfig)
        {
            m_application.ApplicationType = ApplicationType.Server;
            m_application.ConfigSectionName = "TriplHServer";
            m_serverConfig = serverConfig;
        }

        #endregion

        #region Server connection

        public TripleHServer tripleHServer = new TripleHServer();
        public bool Start()
        {
            try
            {
                // check if running as a service.
                if (!Environment.UserInteractive)
                {
                    m_application.StartAsService(new TripleHServer());
                    
                }

                // load the application configuration.
                m_application.LoadApplicationConfiguration(m_serverConfig, false).Wait();

                // check the application certificate.
                m_application.CheckApplicationInstanceCertificate(false, 0).Wait();

                // start the server.
                m_application.Start(tripleHServer).Wait();

                // run the application interactively.
                m_server = (StandardServer)m_application.Server;
                m_configuration = m_application.ApplicationConfiguration;

                

                return true;
            }
            catch (Exception e)
            {
                string text = "Exception: " + e.Message;
                if (e.InnerException != null)
                {
                    text += "\r\nInner exception: ";
                    text += e.InnerException.Message;
                }
                MessageBox.Show(text, m_application.ApplicationName);

                return false;
            }
        }
        public void Stop()
        {
            m_application.Stop();
        }

        #endregion

        #region Public field

        public StandardServer Server {
            get { return m_server; }
        }

        #endregion

        #region Private field

        private ApplicationInstance m_application =  new ApplicationInstance();
        private StandardServer m_server;
        private string m_serverConfig;
        private ApplicationConfiguration m_configuration;

        #endregion
    }
}
