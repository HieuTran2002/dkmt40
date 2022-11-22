using modbusMotor;
using Opc.Ua;
using System;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace conveyorOpcUaServerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Contructor

        public MainWindow()
        {
            InitializeComponent();

            maxTB.Text = "2000";
            minTB.Text = "0";
            speedSlider.Maximum = 2000;
            speedSlider.Minimum = 0;
        }

        #endregion Contructor

        #region Method

        private void monitor(ushort[] data)
        {
            if (isConnected)
            {
                server.tripleHServer.nodeManager.m_conveyor1.Conveyor.Motor1.Direction.Value = data[0];
                server.tripleHServer.nodeManager.m_conveyor1.Conveyor.Motor1.setSpeed.Value = data[1];
                server.tripleHServer.nodeManager.m_conveyor1.Conveyor.Motor1.outputSpeed.Value = data[2];
                server.tripleHServer.nodeManager.m_conveyor1.Conveyor.Motor1.outputCurrent.Value = data[3];
                server.tripleHServer.nodeManager.m_conveyor1.Conveyor.Motor1.outputVoltage.Value = data[4];
                server.tripleHServer.nodeManager.m_conveyor1.Conveyor.Motor1.Torque.Value = data[5];
            }
        }

        private void getPortInfo()
        {
            try
            {
                if (!m_port.IsOpen)
                {
                    m_port.PortName = portComboBox.Text;

                    m_port.BaudRate = Convert.ToInt32(baudComboBox.Text);

                    m_port.Parity = (parityComboBox.SelectedIndex == 0) ? Parity.None :
                                    (parityComboBox.SelectedIndex == 1) ? Parity.Even :
                                    (parityComboBox.SelectedIndex == 2) ? Parity.Odd :
                                    Parity.None;

                    m_port.DataBits = Convert.ToInt16(bitsComboBox.Text);

                    m_port.StopBits = (bitStopComboBox.SelectedIndex == 0) ? StopBits.None :
                                      (bitStopComboBox.SelectedIndex == 1) ? StopBits.One :
                                      (bitStopComboBox.SelectedIndex == 2) ? StopBits.Two :
                                      StopBits.One;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setMaxminSpeed()
        {
            try
            {
                if (maxTB.Text.Length > 0 && minTB.Text.Length > 0)
                {
                    if (Convert.ToInt16(maxTB.Text) <= Convert.ToInt16(minTB.Text))
                    {
                        minTB.Text = maxTB.Text;
                    }
                    if (motor != null)
                    {
                        speedSlider.Maximum = Convert.ToInt16(maxTB.Text);
                        speedSlider.Minimum = Convert.ToInt16(minTB.Text);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion Method

        #region Event handler

        private async void startServerBTN_Click(object sender, RoutedEventArgs e)
        {
            if (!isConnected)
            {
                try
                {
                    bool result = await Task.Run(() => server.Start());
                    setOnWriteValueEvent();
                    if (result)
                    {
                        isConnected = true;
                        startServerBTN.Content = "Stop Server";
                        statusText.Text = "Walking";
                        tcpText.Text = server.Server.GetEndpoints()[0].EndpointUrl;
                    }
                    else
                    {
                        isConnected = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    await Task.Run(() => server.Stop());
                    isConnected = false;
                    startServerBTN.Content = "Start Server";
                    statusText.Text = "Not Walking";
                    tcpText.Text = "Server is downed";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void copyBTN_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetDataObject(tcpText.Text);
        }

        private void setOnWriteValueEvent()
        {
            server.tripleHServer.nodeManager.m_conveyor1.Conveyor.Motor1.setSpeed.OnWriteValue += OnWrite;
        }

        private ServiceResult OnWrite(ISystemContext context, NodeState node, NumericRange indexRange, QualifiedName dataEncoding, ref object value, ref StatusCode statusCode, ref DateTime timestamp)
        {
            try
            {
                if (m_port.IsOpen)
                {
                    bool isGood = motor.WriteMotor(Convert.ToInt32(value), modbusRtuMotor.motorProperty.setSpeed, 1);
                }
                else
                {
                    Dispatcher.BeginInvoke(delegate () { MessageBox.Show("Port isn't openned yet"); });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ServiceResult.Good;
        }

        private void portComboBox_DropDownOpened(object sender, EventArgs e)
        {
            portComboBox.Items.Clear();

            foreach (string comPort in SerialPort.GetPortNames())
            {
                portComboBox.Items.Add(comPort);
            }
        }

        private void decimalTextBoxPreview(object sender, TextCompositionEventArgs e)
        {
            bool approvedDecimalPoint = false;

            if (e.Text == ".")
            {
                if (!((TextBox)sender).Text.Contains("."))
                    approvedDecimalPoint = true;
            }

            if (!(char.IsDigit(e.Text, e.Text.Length - 1) || approvedDecimalPoint))
                e.Handled = true;
        }

        private void minMaxChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void startStopBTN(object sender, RoutedEventArgs e)
        {
            getPortInfo();
            try
            {
                if (motor == null)
                {
                    motor = new modbusRtuMotor(500, m_port, 1);
                    motor.motorMonitor += new modbusRtuMotor.motorMonitorEventHandler(monitor);
                    onOffMotorBTN.Content = "Stop Motor";
                    statusMotorLB.Text = "Walking";
                }
                else if (!m_port.IsOpen)
                {
                    motor.startMotor();
                    onOffMotorBTN.Content = "Stop Motor";
                    statusMotorLB.Text = "Walking";
                }
                else
                {
                    motor.stopMotor();
                    statusMotorLB.Text = "Not walking anymore";
                    onOffMotorBTN.Content = "Start Motor";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dragCompleted(object sender, RoutedEventArgs e)
        {
            try
            {
                motor.WriteMotor((int)speedSlider.Value, modbusRtuMotor.motorProperty.setSpeed, Convert.ToInt16(idTB.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void directionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (m_port.IsOpen)
            {
                int value = (directionComboBox.SelectedIndex == 0) ? 4 : 2;
                motor.WriteMotor(value, modbusRtuMotor.motorProperty.direction, Convert.ToInt16(idTB.Text));
            }
        }

        #endregion Event handler

        #region Public feild

        public OPCUAServer server = new OPCUAServer("OPCUA/Server.Config.xml");
        public bool isConnected = false;

        public SerialPort port
        {
            get { return m_port; }
            set {; }
        }

        #endregion Public feild

        #region Private field

        private SerialPort m_port = new SerialPort();
        private modbusRtuMotor motor;

        #endregion Private field

        private void minmaxTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                setMaxminSpeed();
            }
        }


        private void window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(!(e.Source is TextBox) && e.Source != null)
            {
                try
                {
                    TabControl whoeverSentThisEvent =  e.Source as TabControl;
                    whoeverSentThisEvent.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void setValueLostValue(object sender, RoutedEventArgs e)
        {
            setMaxminSpeed();

        }
    }
}