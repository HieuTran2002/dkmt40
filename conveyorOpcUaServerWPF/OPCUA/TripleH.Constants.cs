/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace TripleH
{
    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint TripleHType_StartProcess = 226;

        /// <remarks />
        public const uint TripleHType_StopProcess = 227;

        /// <remarks />
        public const uint TripleH1_StartProcess = 304;

        /// <remarks />
        public const uint TripleH1_StopProcess = 305;
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint ConveyorType_Motor1 = 76;

        /// <remarks />
        public const uint ConveyorType_Motor2 = 113;

        /// <remarks />
        public const uint TripleHType_Conveyor = 151;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor1 = 152;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor2 = 189;

        /// <remarks />
        public const uint TripleH1 = 228;

        /// <remarks />
        public const uint TripleH1_Conveyor = 229;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor1 = 230;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor2 = 267;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint GenericMotorType = 1;

        /// <remarks />
        public const uint ThreePharesMotor = 38;

        /// <remarks />
        public const uint ConveyorType = 75;

        /// <remarks />
        public const uint TripleHType = 150;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint GenericMotorType_Direction = 2;

        /// <remarks />
        public const uint GenericMotorType_Direction_EURange = 6;

        /// <remarks />
        public const uint GenericMotorType_setSpeed = 8;

        /// <remarks />
        public const uint GenericMotorType_setSpeed_EURange = 12;

        /// <remarks />
        public const uint GenericMotorType_outputSpeed = 14;

        /// <remarks />
        public const uint GenericMotorType_outputSpeed_EURange = 18;

        /// <remarks />
        public const uint GenericMotorType_outputCurrent = 20;

        /// <remarks />
        public const uint GenericMotorType_outputCurrent_EURange = 24;

        /// <remarks />
        public const uint GenericMotorType_outputVoltage = 26;

        /// <remarks />
        public const uint GenericMotorType_outputVoltage_EURange = 30;

        /// <remarks />
        public const uint GenericMotorType_Torque = 32;

        /// <remarks />
        public const uint GenericMotorType_Torque_EURange = 36;

        /// <remarks />
        public const uint ThreePharesMotor_Direction_EURange = 43;

        /// <remarks />
        public const uint ThreePharesMotor_setSpeed_EURange = 49;

        /// <remarks />
        public const uint ThreePharesMotor_outputSpeed_EURange = 55;

        /// <remarks />
        public const uint ThreePharesMotor_outputCurrent_EURange = 61;

        /// <remarks />
        public const uint ThreePharesMotor_outputVoltage_EURange = 67;

        /// <remarks />
        public const uint ThreePharesMotor_Torque_EURange = 73;

        /// <remarks />
        public const uint ConveyorType_Motor1_Direction = 77;

        /// <remarks />
        public const uint ConveyorType_Motor1_Direction_EURange = 81;

        /// <remarks />
        public const uint ConveyorType_Motor1_setSpeed = 83;

        /// <remarks />
        public const uint ConveyorType_Motor1_setSpeed_EURange = 87;

        /// <remarks />
        public const uint ConveyorType_Motor1_outputSpeed = 89;

        /// <remarks />
        public const uint ConveyorType_Motor1_outputSpeed_EURange = 93;

        /// <remarks />
        public const uint ConveyorType_Motor1_outputCurrent = 95;

        /// <remarks />
        public const uint ConveyorType_Motor1_outputCurrent_EURange = 99;

        /// <remarks />
        public const uint ConveyorType_Motor1_outputVoltage = 101;

        /// <remarks />
        public const uint ConveyorType_Motor1_outputVoltage_EURange = 105;

        /// <remarks />
        public const uint ConveyorType_Motor1_Torque = 107;

        /// <remarks />
        public const uint ConveyorType_Motor1_Torque_EURange = 111;

        /// <remarks />
        public const uint ConveyorType_Motor2_Direction = 114;

        /// <remarks />
        public const uint ConveyorType_Motor2_Direction_EURange = 118;

        /// <remarks />
        public const uint ConveyorType_Motor2_setSpeed = 120;

        /// <remarks />
        public const uint ConveyorType_Motor2_setSpeed_EURange = 124;

        /// <remarks />
        public const uint ConveyorType_Motor2_outputSpeed = 126;

        /// <remarks />
        public const uint ConveyorType_Motor2_outputSpeed_EURange = 130;

        /// <remarks />
        public const uint ConveyorType_Motor2_outputCurrent = 132;

        /// <remarks />
        public const uint ConveyorType_Motor2_outputCurrent_EURange = 136;

        /// <remarks />
        public const uint ConveyorType_Motor2_outputVoltage = 138;

        /// <remarks />
        public const uint ConveyorType_Motor2_outputVoltage_EURange = 142;

        /// <remarks />
        public const uint ConveyorType_Motor2_Torque = 144;

        /// <remarks />
        public const uint ConveyorType_Motor2_Torque_EURange = 148;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor1_Direction = 153;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor1_Direction_EURange = 157;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor1_setSpeed = 159;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor1_setSpeed_EURange = 163;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor1_outputSpeed = 165;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor1_outputSpeed_EURange = 169;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor1_outputCurrent = 171;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor1_outputCurrent_EURange = 175;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor1_outputVoltage = 177;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor1_outputVoltage_EURange = 181;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor1_Torque = 183;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor1_Torque_EURange = 187;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor2_Direction = 190;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor2_Direction_EURange = 194;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor2_setSpeed = 196;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor2_setSpeed_EURange = 200;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor2_outputSpeed = 202;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor2_outputSpeed_EURange = 206;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor2_outputCurrent = 208;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor2_outputCurrent_EURange = 212;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor2_outputVoltage = 214;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor2_outputVoltage_EURange = 218;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor2_Torque = 220;

        /// <remarks />
        public const uint TripleHType_Conveyor_Motor2_Torque_EURange = 224;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor1_Direction = 231;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor1_Direction_EURange = 235;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor1_setSpeed = 237;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor1_setSpeed_EURange = 241;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor1_outputSpeed = 243;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor1_outputSpeed_EURange = 247;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor1_outputCurrent = 249;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor1_outputCurrent_EURange = 253;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor1_outputVoltage = 255;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor1_outputVoltage_EURange = 259;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor1_Torque = 261;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor1_Torque_EURange = 265;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor2_Direction = 268;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor2_Direction_EURange = 272;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor2_setSpeed = 274;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor2_setSpeed_EURange = 278;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor2_outputSpeed = 280;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor2_outputSpeed_EURange = 284;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor2_outputCurrent = 286;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor2_outputCurrent_EURange = 290;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor2_outputVoltage = 292;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor2_outputVoltage_EURange = 296;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor2_Torque = 298;

        /// <remarks />
        public const uint TripleH1_Conveyor_Motor2_Torque_EURange = 302;
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_StartProcess = new ExpandedNodeId(TripleH.Methods.TripleHType_StartProcess, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_StopProcess = new ExpandedNodeId(TripleH.Methods.TripleHType_StopProcess, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_StartProcess = new ExpandedNodeId(TripleH.Methods.TripleH1_StartProcess, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_StopProcess = new ExpandedNodeId(TripleH.Methods.TripleH1_StopProcess, TripleH.Namespaces.TripleH);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor1 = new ExpandedNodeId(TripleH.Objects.ConveyorType_Motor1, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor2 = new ExpandedNodeId(TripleH.Objects.ConveyorType_Motor2, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor = new ExpandedNodeId(TripleH.Objects.TripleHType_Conveyor, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor1 = new ExpandedNodeId(TripleH.Objects.TripleHType_Conveyor_Motor1, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor2 = new ExpandedNodeId(TripleH.Objects.TripleHType_Conveyor_Motor2, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1 = new ExpandedNodeId(TripleH.Objects.TripleH1, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor = new ExpandedNodeId(TripleH.Objects.TripleH1_Conveyor, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor1 = new ExpandedNodeId(TripleH.Objects.TripleH1_Conveyor_Motor1, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor2 = new ExpandedNodeId(TripleH.Objects.TripleH1_Conveyor_Motor2, TripleH.Namespaces.TripleH);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType = new ExpandedNodeId(TripleH.ObjectTypes.GenericMotorType, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ThreePharesMotor = new ExpandedNodeId(TripleH.ObjectTypes.ThreePharesMotor, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType = new ExpandedNodeId(TripleH.ObjectTypes.ConveyorType, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType = new ExpandedNodeId(TripleH.ObjectTypes.TripleHType, TripleH.Namespaces.TripleH);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_Direction = new ExpandedNodeId(TripleH.Variables.GenericMotorType_Direction, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_Direction_EURange = new ExpandedNodeId(TripleH.Variables.GenericMotorType_Direction_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_setSpeed = new ExpandedNodeId(TripleH.Variables.GenericMotorType_setSpeed, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_setSpeed_EURange = new ExpandedNodeId(TripleH.Variables.GenericMotorType_setSpeed_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_outputSpeed = new ExpandedNodeId(TripleH.Variables.GenericMotorType_outputSpeed, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_outputSpeed_EURange = new ExpandedNodeId(TripleH.Variables.GenericMotorType_outputSpeed_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_outputCurrent = new ExpandedNodeId(TripleH.Variables.GenericMotorType_outputCurrent, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_outputCurrent_EURange = new ExpandedNodeId(TripleH.Variables.GenericMotorType_outputCurrent_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_outputVoltage = new ExpandedNodeId(TripleH.Variables.GenericMotorType_outputVoltage, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_outputVoltage_EURange = new ExpandedNodeId(TripleH.Variables.GenericMotorType_outputVoltage_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_Torque = new ExpandedNodeId(TripleH.Variables.GenericMotorType_Torque, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_Torque_EURange = new ExpandedNodeId(TripleH.Variables.GenericMotorType_Torque_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ThreePharesMotor_Direction_EURange = new ExpandedNodeId(TripleH.Variables.ThreePharesMotor_Direction_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ThreePharesMotor_setSpeed_EURange = new ExpandedNodeId(TripleH.Variables.ThreePharesMotor_setSpeed_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ThreePharesMotor_outputSpeed_EURange = new ExpandedNodeId(TripleH.Variables.ThreePharesMotor_outputSpeed_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ThreePharesMotor_outputCurrent_EURange = new ExpandedNodeId(TripleH.Variables.ThreePharesMotor_outputCurrent_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ThreePharesMotor_outputVoltage_EURange = new ExpandedNodeId(TripleH.Variables.ThreePharesMotor_outputVoltage_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ThreePharesMotor_Torque_EURange = new ExpandedNodeId(TripleH.Variables.ThreePharesMotor_Torque_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor1_Direction = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor1_Direction, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor1_Direction_EURange = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor1_Direction_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor1_setSpeed = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor1_setSpeed, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor1_setSpeed_EURange = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor1_setSpeed_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor1_outputSpeed = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor1_outputSpeed, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor1_outputSpeed_EURange = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor1_outputSpeed_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor1_outputCurrent = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor1_outputCurrent, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor1_outputCurrent_EURange = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor1_outputCurrent_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor1_outputVoltage = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor1_outputVoltage, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor1_outputVoltage_EURange = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor1_outputVoltage_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor1_Torque = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor1_Torque, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor1_Torque_EURange = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor1_Torque_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor2_Direction = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor2_Direction, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor2_Direction_EURange = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor2_Direction_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor2_setSpeed = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor2_setSpeed, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor2_setSpeed_EURange = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor2_setSpeed_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor2_outputSpeed = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor2_outputSpeed, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor2_outputSpeed_EURange = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor2_outputSpeed_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor2_outputCurrent = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor2_outputCurrent, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor2_outputCurrent_EURange = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor2_outputCurrent_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor2_outputVoltage = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor2_outputVoltage, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor2_outputVoltage_EURange = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor2_outputVoltage_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor2_Torque = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor2_Torque, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_Motor2_Torque_EURange = new ExpandedNodeId(TripleH.Variables.ConveyorType_Motor2_Torque_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor1_Direction = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor1_Direction, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor1_Direction_EURange = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor1_Direction_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor1_setSpeed = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor1_setSpeed, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor1_setSpeed_EURange = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor1_setSpeed_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor1_outputSpeed = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor1_outputSpeed, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor1_outputSpeed_EURange = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor1_outputSpeed_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor1_outputCurrent = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor1_outputCurrent, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor1_outputCurrent_EURange = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor1_outputCurrent_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor1_outputVoltage = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor1_outputVoltage, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor1_outputVoltage_EURange = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor1_outputVoltage_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor1_Torque = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor1_Torque, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor1_Torque_EURange = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor1_Torque_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor2_Direction = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor2_Direction, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor2_Direction_EURange = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor2_Direction_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor2_setSpeed = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor2_setSpeed, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor2_setSpeed_EURange = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor2_setSpeed_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor2_outputSpeed = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor2_outputSpeed, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor2_outputSpeed_EURange = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor2_outputSpeed_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor2_outputCurrent = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor2_outputCurrent, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor2_outputCurrent_EURange = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor2_outputCurrent_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor2_outputVoltage = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor2_outputVoltage, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor2_outputVoltage_EURange = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor2_outputVoltage_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor2_Torque = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor2_Torque, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleHType_Conveyor_Motor2_Torque_EURange = new ExpandedNodeId(TripleH.Variables.TripleHType_Conveyor_Motor2_Torque_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor1_Direction = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor1_Direction, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor1_Direction_EURange = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor1_Direction_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor1_setSpeed = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor1_setSpeed, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor1_setSpeed_EURange = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor1_setSpeed_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor1_outputSpeed = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor1_outputSpeed, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor1_outputSpeed_EURange = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor1_outputSpeed_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor1_outputCurrent = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor1_outputCurrent, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor1_outputCurrent_EURange = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor1_outputCurrent_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor1_outputVoltage = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor1_outputVoltage, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor1_outputVoltage_EURange = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor1_outputVoltage_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor1_Torque = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor1_Torque, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor1_Torque_EURange = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor1_Torque_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor2_Direction = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor2_Direction, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor2_Direction_EURange = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor2_Direction_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor2_setSpeed = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor2_setSpeed, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor2_setSpeed_EURange = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor2_setSpeed_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor2_outputSpeed = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor2_outputSpeed, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor2_outputSpeed_EURange = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor2_outputSpeed_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor2_outputCurrent = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor2_outputCurrent, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor2_outputCurrent_EURange = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor2_outputCurrent_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor2_outputVoltage = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor2_outputVoltage, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor2_outputVoltage_EURange = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor2_outputVoltage_EURange, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor2_Torque = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor2_Torque, TripleH.Namespaces.TripleH);

        /// <remarks />
        public static readonly ExpandedNodeId TripleH1_Conveyor_Motor2_Torque_EURange = new ExpandedNodeId(TripleH.Variables.TripleH1_Conveyor_Motor2_Torque_EURange, TripleH.Namespaces.TripleH);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string Conveyor = "Conveyor01";

        /// <remarks />
        public const string ConveyorType = "ConveyorType";

        /// <remarks />
        public const string Direction = "Direction";

        /// <remarks />
        public const string GenericMotorType = "GenericMotorType";

        /// <remarks />
        public const string Motor1 = "Motor01";

        /// <remarks />
        public const string Motor2 = "Motor02";

        /// <remarks />
        public const string outputCurrent = "outputCurrent";

        /// <remarks />
        public const string outputSpeed = "outputSpeed";

        /// <remarks />
        public const string outputVoltage = "outputVoltage";

        /// <remarks />
        public const string setSpeed = "setSpeed";

        /// <remarks />
        public const string StartProcess = "StartProcess";

        /// <remarks />
        public const string StopProcess = "StopProcess";

        /// <remarks />
        public const string ThreePharesMotor = "ThreePharesMotor";

        /// <remarks />
        public const string Torque = "Torque";

        /// <remarks />
        public const string TripleH1 = "Triple-H Server";

        /// <remarks />
        public const string TripleHType = "TripleHType";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the TripleH namespace (.NET code namespace is 'TripleH').
        /// </summary>
        public const string TripleH = "http://opcfoundation.org/TripleH";
    }
    #endregion
}