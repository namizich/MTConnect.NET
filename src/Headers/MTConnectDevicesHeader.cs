﻿// Copyright (c) 2016 Feenux LLC, All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using System;
using System.Xml.Serialization;

namespace MTConnect.Headers
{
    /// <summary>
    /// Contains the Header information in an MTConnect Devices XML document
    /// </summary>
    public class MTConnectDevicesHeader
    {

        #region "Required"

        [XmlAttribute("assetBufferSize")]
        public long AssetBufferSize { get; set; }

        [XmlAttribute("assetCount")]
        public long AssetCount { get; set; }

        [XmlAttribute("bufferSize")]
        public long BufferSize { get; set; }

        [XmlAttribute("creationTime")]
        public DateTime CreationTime { get; set; }

        [XmlAttribute("instanceId")]
        public long InstanceId { get; set; }

        [XmlAttribute("sender")]
        public string Sender { get; set; }

        [XmlAttribute("version")]
        public string Version { get; set; }

        #endregion

        #region "Optional"

        [XmlAttribute("testIndicator")]
        public string TestIndicator { get; set; }

        #endregion
    }
}
