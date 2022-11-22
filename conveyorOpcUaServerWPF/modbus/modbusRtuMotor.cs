using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Timers;
using Modbus.Data;
using System.Windows;

namespace modbusMotor
{

    public class modbusRtuMotor
    {

        #region Constructor   

        public modbusRtuMotor(int interval, SerialPort port, int idMotor)
        {
            m_port = port;
            driver = new modbusRtuDriver(port);
            driver.start();
            id = idMotor;

            timer = new System.Timers.Timer();
            timer.Interval = interval;
                
            timer.Elapsed += checkValue;
            timer.Start();
            
        }


        #endregion

        #region Write data

        public bool WriteMotor(int value, motorProperty property, int id)
        {
            bool result = false ;
            driver.write(Convert.ToByte(id), motorAddress[((int)property)], (UInt16)value, ModbusDataType.HoldingRegister);
            return result;
        }

        #endregion

        #region Read data
        public void getValue()
        {
            //ushort[] datas = await driver.readMotor(1, Modbus.Data.ModbusDataType.HoldingRegister, motorAddress);

            ushort[] datas = driver.readMotor(1, Modbus.Data.ModbusDataType.HoldingRegister, motorAddress);
            if (motorData != datas)
            {
                motorData = datas;
                if(motorMonitor != null)
                {
                    motorMonitor.Invoke(motorData);
                }
                direction = (motorData[0] == 75 || motorData[0] == 11) ? motorDirection.CW : motorDirection.CCW;
            }
        }



        #endregion

        #region Value change event handler

        public delegate void motorMonitorEventHandler(ushort[] data);

        public motorMonitorEventHandler motorMonitor;
        private void checkValue(object? sender, ElapsedEventArgs e)
        {
            timer.Stop();
            if (driver.port.IsOpen)
            {
                getValue();
            }
            timer.Start();
        }


        #endregion

        #region Connection control
        public void stopMotor()
        {
            driver.stop();
        }
        public void startMotor()
        {
            driver.start();

        }
        #endregion

        #region private 
        private SerialPort m_port;
        // Setup timer
        private System.Timers.Timer timer;   

        // Setup modbus driver
        private  modbusRtuDriver driver;

        private int id;

        private static ushort directionAddress = 8;
        private static ushort setSpeedAddress = 13;
        private static ushort outputCurrentAddress = 202;
        private static ushort outputSpeedAddress = 201;
        private static ushort outputVoltageAddress = 214;
        private static ushort motorTorqueAddress = 207;
        
        private motorDirection direction = motorDirection.CW;

        private static ushort setSpeed = 0;
        private static ushort outputSpeed = 0;
        private static ushort direction2 = 0;
        private static ushort outputVoltage = 0;
        private static ushort outputCurrent = 0;
        private static ushort motorTorque = 0;

        private static ushort[] motorData = { direction2,
                                    setSpeed,
                                    outputSpeed,
                                    outputCurrent,
                                    outputVoltage,
                                    motorTorque };
        
        private ushort[] motorAddress = { 
            directionAddress,
            setSpeedAddress ,
            outputSpeedAddress,
            outputCurrentAddress,
            outputVoltageAddress,
            motorTorqueAddress };

        private ushort[] testAddress = { 7,8,9,10,11,333 };

        #endregion

        #region public fields

        public bool isRunning;

        public enum motorDirection
        {
            CW,
            CCW
        }

        public enum motorProperty
        {
            direction = 0,
            setSpeed = 1, 
            outputSpeed = 2,
            outputCurrent = 3,
            outputVoltage = 4,
            Torque = 5
        }

        #endregion

    }

}
