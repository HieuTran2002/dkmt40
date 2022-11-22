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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace TripleH
{
    #region GenericMotorState Class
    #if (!OPCUA_EXCLUDE_GenericMotorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericMotorState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public GenericMotorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TripleH.ObjectTypes.GenericMotorType, TripleH.Namespaces.TripleH, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVHJpcGxlSP////8EYIACAQAAAAEAGAAAAEdl" +
           "bmVyaWNNb3RvclR5cGVJbnN0YW5jZQEBAQABAQEAAQAAAP////8GAAAAFWCJCgIAAAABAAkAAABEaXJl" +
           "Y3Rpb24BAQIAAC8BAEAJAgAAAAAb/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAQYA" +
           "AC4ARAYAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEACAAAAHNldFNwZWVkAQEIAAAvAQBACQgA" +
           "AAAAG/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEMAAAuAEQMAAAAAQB0A/////8B" +
           "Af////8AAAAAFWCJCgIAAAABAAsAAABvdXRwdXRTcGVlZAEBDgAALwEAQAkOAAAAABv/////AwP/////" +
           "AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBEgAALgBEEgAAAAEAdAP/////AQH/////AAAAABVgiQoC" +
           "AAAAAQANAAAAb3V0cHV0Q3VycmVudAEBFAAALwEAQAkUAAAAABv/////AwP/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBGAAALgBEGAAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQANAAAAb3V0" +
           "cHV0Vm9sdGFnZQEBGgAALwEAQAkaAAAAABv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5n" +
           "ZQEBHgAALgBEHgAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAGAAAAVG9ycXVlAQEgAAAvAQBA" +
           "CSAAAAAAG/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEkAAAuAEQkAAAAAQB0A///" +
           "//8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState Direction
        {
            get
            {
                return m_direction;
            }

            set
            {
                if (!Object.ReferenceEquals(m_direction, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_direction = value;
            }
        }

        /// <remarks />
        public AnalogItemState setSpeed
        {
            get
            {
                return m_setSpeed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setSpeed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setSpeed = value;
            }
        }

        /// <remarks />
        public AnalogItemState outputSpeed
        {
            get
            {
                return m_outputSpeed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_outputSpeed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_outputSpeed = value;
            }
        }

        /// <remarks />
        public AnalogItemState outputCurrent
        {
            get
            {
                return m_outputCurrent;
            }

            set
            {
                if (!Object.ReferenceEquals(m_outputCurrent, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_outputCurrent = value;
            }
        }

        /// <remarks />
        public AnalogItemState outputVoltage
        {
            get
            {
                return m_outputVoltage;
            }

            set
            {
                if (!Object.ReferenceEquals(m_outputVoltage, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_outputVoltage = value;
            }
        }

        /// <remarks />
        public AnalogItemState Torque
        {
            get
            {
                return m_torque;
            }

            set
            {
                if (!Object.ReferenceEquals(m_torque, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_torque = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_direction != null)
            {
                children.Add(m_direction);
            }

            if (m_setSpeed != null)
            {
                children.Add(m_setSpeed);
            }

            if (m_outputSpeed != null)
            {
                children.Add(m_outputSpeed);
            }

            if (m_outputCurrent != null)
            {
                children.Add(m_outputCurrent);
            }

            if (m_outputVoltage != null)
            {
                children.Add(m_outputVoltage);
            }

            if (m_torque != null)
            {
                children.Add(m_torque);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case TripleH.BrowseNames.Direction:
                {
                    if (createOrReplace)
                    {
                        if (Direction == null)
                        {
                            if (replacement == null)
                            {
                                Direction = new AnalogItemState(this);
                            }
                            else
                            {
                                Direction = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = Direction;
                    break;
                }

                case TripleH.BrowseNames.setSpeed:
                {
                    if (createOrReplace)
                    {
                        if (setSpeed == null)
                        {
                            if (replacement == null)
                            {
                                setSpeed = new AnalogItemState(this);
                            }
                            else
                            {
                                setSpeed = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = setSpeed;
                    break;
                }

                case TripleH.BrowseNames.outputSpeed:
                {
                    if (createOrReplace)
                    {
                        if (outputSpeed == null)
                        {
                            if (replacement == null)
                            {
                                outputSpeed = new AnalogItemState(this);
                            }
                            else
                            {
                                outputSpeed = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = outputSpeed;
                    break;
                }

                case TripleH.BrowseNames.outputCurrent:
                {
                    if (createOrReplace)
                    {
                        if (outputCurrent == null)
                        {
                            if (replacement == null)
                            {
                                outputCurrent = new AnalogItemState(this);
                            }
                            else
                            {
                                outputCurrent = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = outputCurrent;
                    break;
                }

                case TripleH.BrowseNames.outputVoltage:
                {
                    if (createOrReplace)
                    {
                        if (outputVoltage == null)
                        {
                            if (replacement == null)
                            {
                                outputVoltage = new AnalogItemState(this);
                            }
                            else
                            {
                                outputVoltage = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = outputVoltage;
                    break;
                }

                case TripleH.BrowseNames.Torque:
                {
                    if (createOrReplace)
                    {
                        if (Torque == null)
                        {
                            if (replacement == null)
                            {
                                Torque = new AnalogItemState(this);
                            }
                            else
                            {
                                Torque = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = Torque;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState m_direction;
        private AnalogItemState m_setSpeed;
        private AnalogItemState m_outputSpeed;
        private AnalogItemState m_outputCurrent;
        private AnalogItemState m_outputVoltage;
        private AnalogItemState m_torque;
        #endregion
    }
    #endif
    #endregion

    #region ThreePharesMotorState Class
    #if (!OPCUA_EXCLUDE_ThreePharesMotorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ThreePharesMotorState : GenericMotorState
    {
        #region Constructors
        /// <remarks />
        public ThreePharesMotorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TripleH.ObjectTypes.ThreePharesMotor, TripleH.Namespaces.TripleH, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVHJpcGxlSP////8EYIACAQAAAAEAGAAAAFRo" +
           "cmVlUGhhcmVzTW90b3JJbnN0YW5jZQEBJgABASYAJgAAAP////8GAAAAFWCJCgIAAAABAAkAAABEaXJl" +
           "Y3Rpb24BAScAAC8BAEAJJwAAAAAb/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBASsA" +
           "AC4ARCsAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEACAAAAHNldFNwZWVkAQEtAAAvAQBACS0A" +
           "AAAAG/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQExAAAuAEQxAAAAAQB0A/////8B" +
           "Af////8AAAAAFWCJCgIAAAABAAsAAABvdXRwdXRTcGVlZAEBMwAALwEAQAkzAAAAABv/////AwP/////" +
           "AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBNwAALgBENwAAAAEAdAP/////AQH/////AAAAABVgiQoC" +
           "AAAAAQANAAAAb3V0cHV0Q3VycmVudAEBOQAALwEAQAk5AAAAABv/////AwP/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBPQAALgBEPQAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQANAAAAb3V0" +
           "cHV0Vm9sdGFnZQEBPwAALwEAQAk/AAAAABv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5n" +
           "ZQEBQwAALgBEQwAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAGAAAAVG9ycXVlAQFFAAAvAQBA" +
           "CUUAAAAAG/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFJAAAuAERJAAAAAQB0A///" +
           "//8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ConveyorState Class
    #if (!OPCUA_EXCLUDE_ConveyorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConveyorState : FolderState
    {
        #region Constructors
        /// <remarks />
        public ConveyorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TripleH.ObjectTypes.ConveyorType, TripleH.Namespaces.TripleH, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVHJpcGxlSP////8EYIACAQAAAAEAFAAAAENv" +
           "bnZleW9yVHlwZUluc3RhbmNlAQFLAAEBSwBLAAAAAgAAAAAwAAEBTAAAMAABAXEAAgAAAIRgwAoBAAAA" +
           "BgAAAE1vdG9yMQEABwAAAE1vdG9yMDEBAUwAAC8BASYATAAAAAEBAAAAADABAQFLAAYAAAAVYIkKAgAA" +
           "AAEACQAAAERpcmVjdGlvbgEBTQAALwEAQAlNAAAAABv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEBUQAALgBEUQAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAIAAAAc2V0U3BlZWQB" +
           "AVMAAC8BAEAJUwAAAAAb/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAVcAAC4ARFcA" +
           "AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAG91dHB1dFNwZWVkAQFZAAAvAQBACVkAAAAA" +
           "G/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFdAAAuAERdAAAAAQB0A/////8BAf//" +
           "//8AAAAAFWCJCgIAAAABAA0AAABvdXRwdXRDdXJyZW50AQFfAAAvAQBACV8AAAAAG/////8DA/////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFjAAAuAERjAAAAAQB0A/////8BAf////8AAAAAFWCJCgIA" +
           "AAABAA0AAABvdXRwdXRWb2x0YWdlAQFlAAAvAQBACWUAAAAAG/////8DA/////8BAAAAFWCJCgIAAAAA" +
           "AAcAAABFVVJhbmdlAQFpAAAuAERpAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAYAAABUb3Jx" +
           "dWUBAWsAAC8BAEAJawAAAAAb/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAW8AAC4A" +
           "RG8AAAABAHQD/////wEB/////wAAAACEYMAKAQAAAAYAAABNb3RvcjIBAAcAAABNb3RvcjAyAQFxAAAv" +
           "AQEmAHEAAAABAQAAAAAwAQEBSwAGAAAAFWCJCgIAAAABAAkAAABEaXJlY3Rpb24BAXIAAC8BAEAJcgAA" +
           "AAAb/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAXYAAC4ARHYAAAABAHQD/////wEB" +
           "/////wAAAAAVYIkKAgAAAAEACAAAAHNldFNwZWVkAQF4AAAvAQBACXgAAAAAG/////8DA/////8BAAAA" +
           "FWCJCgIAAAAAAAcAAABFVVJhbmdlAQF8AAAuAER8AAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAAB" +
           "AAsAAABvdXRwdXRTcGVlZAEBfgAALwEAQAl+AAAAABv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEBggAALgBEggAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQANAAAAb3V0cHV0Q3Vy" +
           "cmVudAEBhAAALwEAQAmEAAAAABv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBiAAA" +
           "LgBEiAAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQANAAAAb3V0cHV0Vm9sdGFnZQEBigAALwEA" +
           "QAmKAAAAABv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBjgAALgBEjgAAAAEAdAP/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAGAAAAVG9ycXVlAQGQAAAvAQBACZAAAAAAG/////8DA/////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGUAAAuAESUAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public ThreePharesMotorState Motor1
        {
            get
            {
                return m_motor1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motor1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motor1 = value;
            }
        }

        /// <remarks />
        public ThreePharesMotorState Motor2
        {
            get
            {
                return m_motor2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_motor2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_motor2 = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_motor1 != null)
            {
                children.Add(m_motor1);
            }

            if (m_motor2 != null)
            {
                children.Add(m_motor2);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case TripleH.BrowseNames.Motor1:
                {
                    if (createOrReplace)
                    {
                        if (Motor1 == null)
                        {
                            if (replacement == null)
                            {
                                Motor1 = new ThreePharesMotorState(this);
                            }
                            else
                            {
                                Motor1 = (ThreePharesMotorState)replacement;
                            }
                        }
                    }

                    instance = Motor1;
                    break;
                }

                case TripleH.BrowseNames.Motor2:
                {
                    if (createOrReplace)
                    {
                        if (Motor2 == null)
                        {
                            if (replacement == null)
                            {
                                Motor2 = new ThreePharesMotorState(this);
                            }
                            else
                            {
                                Motor2 = (ThreePharesMotorState)replacement;
                            }
                        }
                    }

                    instance = Motor2;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private ThreePharesMotorState m_motor1;
        private ThreePharesMotorState m_motor2;
        #endregion
    }
    #endif
    #endregion

    #region TripleHState Class
    #if (!OPCUA_EXCLUDE_TripleHState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TripleHState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public TripleHState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TripleH.ObjectTypes.TripleHType, TripleH.Namespaces.TripleH, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACAAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVHJpcGxlSP////+EYIACAQAAAAEAEwAAAFRy" +
           "aXBsZUhUeXBlSW5zdGFuY2UBAZYAAQGWAJYAAAABAQAAAAAwAAEBlwADAAAAhGDACgEAAAAIAAAAQ29u" +
           "dmV5b3IBAAoAAABDb252ZXlvcjAxAQGXAAAvAQFLAJcAAAABAwAAAAAwAQEBlgAAMAABAZgAADAAAQG9" +
           "AAIAAACEYMAKAQAAAAYAAABNb3RvcjEBAAcAAABNb3RvcjAxAQGYAAAvAQEmAJgAAAABAQAAAAAwAQEB" +
           "lwAGAAAAFWCJCgIAAAABAAkAAABEaXJlY3Rpb24BAZkAAC8BAEAJmQAAAAAb/////wMD/////wEAAAAV" +
           "YIkKAgAAAAAABwAAAEVVUmFuZ2UBAZ0AAC4ARJ0AAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "CAAAAHNldFNwZWVkAQGfAAAvAQBACZ8AAAAAG/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJh" +
           "bmdlAQGjAAAuAESjAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAsAAABvdXRwdXRTcGVlZAEB" +
           "pQAALwEAQAmlAAAAABv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBqQAALgBEqQAA" +
           "AAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQANAAAAb3V0cHV0Q3VycmVudAEBqwAALwEAQAmrAAAA" +
           "ABv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBrwAALgBErwAAAAEAdAP/////AQH/" +
           "////AAAAABVgiQoCAAAAAQANAAAAb3V0cHV0Vm9sdGFnZQEBsQAALwEAQAmxAAAAABv/////AwP/////" +
           "AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBtQAALgBEtQAAAAEAdAP/////AQH/////AAAAABVgiQoC" +
           "AAAAAQAGAAAAVG9ycXVlAQG3AAAvAQBACbcAAAAAG/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABF" +
           "VVJhbmdlAQG7AAAuAES7AAAAAQB0A/////8BAf////8AAAAAhGDACgEAAAAGAAAATW90b3IyAQAHAAAA" +
           "TW90b3IwMgEBvQAALwEBJgC9AAAAAQEAAAAAMAEBAZcABgAAABVgiQoCAAAAAQAJAAAARGlyZWN0aW9u" +
           "AQG+AAAvAQBACb4AAAAAG/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHCAAAuAETC" +
           "AAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAgAAABzZXRTcGVlZAEBxAAALwEAQAnEAAAAABv/" +
           "////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEByAAALgBEyAAAAAEAdAP/////AQH/////" +
           "AAAAABVgiQoCAAAAAQALAAAAb3V0cHV0U3BlZWQBAcoAAC8BAEAJygAAAAAb/////wMD/////wEAAAAV" +
           "YIkKAgAAAAAABwAAAEVVUmFuZ2UBAc4AAC4ARM4AAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "DQAAAG91dHB1dEN1cnJlbnQBAdAAAC8BAEAJ0AAAAAAb/////wMD/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAdQAAC4ARNQAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEADQAAAG91dHB1dFZv" +
           "bHRhZ2UBAdYAAC8BAEAJ1gAAAAAb/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAdoA" +
           "AC4ARNoAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABgAAAFRvcnF1ZQEB3AAALwEAQAncAAAA" +
           "ABv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB4AAALgBE4AAAAAEAdAP/////AQH/" +
           "////AAAAAARhggoEAAAAAQAMAAAAU3RhcnRQcm9jZXNzAQHiAAAvAQHiAOIAAAABAf////8AAAAABGGC" +
           "CgQAAAABAAsAAABTdG9wUHJvY2VzcwEB4wAALwEB4wDjAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public ConveyorState Conveyor
        {
            get
            {
                return m_conveyor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_conveyor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_conveyor = value;
            }
        }

        /// <remarks />
        public MethodState StartProcess
        {
            get
            {
                return m_startProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startProcessMethod = value;
            }
        }

        /// <remarks />
        public MethodState StopProcess
        {
            get
            {
                return m_stopProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopProcessMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_conveyor != null)
            {
                children.Add(m_conveyor);
            }

            if (m_startProcessMethod != null)
            {
                children.Add(m_startProcessMethod);
            }

            if (m_stopProcessMethod != null)
            {
                children.Add(m_stopProcessMethod);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case TripleH.BrowseNames.Conveyor:
                {
                    if (createOrReplace)
                    {
                        if (Conveyor == null)
                        {
                            if (replacement == null)
                            {
                                Conveyor = new ConveyorState(this);
                            }
                            else
                            {
                                Conveyor = (ConveyorState)replacement;
                            }
                        }
                    }

                    instance = Conveyor;
                    break;
                }

                case TripleH.BrowseNames.StartProcess:
                {
                    if (createOrReplace)
                    {
                        if (StartProcess == null)
                        {
                            if (replacement == null)
                            {
                                StartProcess = new MethodState(this);
                            }
                            else
                            {
                                StartProcess = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StartProcess;
                    break;
                }

                case TripleH.BrowseNames.StopProcess:
                {
                    if (createOrReplace)
                    {
                        if (StopProcess == null)
                        {
                            if (replacement == null)
                            {
                                StopProcess = new MethodState(this);
                            }
                            else
                            {
                                StopProcess = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StopProcess;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private ConveyorState m_conveyor;
        private MethodState m_startProcessMethod;
        private MethodState m_stopProcessMethod;
        #endregion
    }
    #endif
    #endregion
}