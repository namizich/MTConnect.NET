﻿// Copyright (c) 2016 Feenux LLC, All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using System.Xml.Serialization;

namespace MTConnect.MTConnectAssets
{
    public class Asset
    {
        [XmlAttribute("assetId")]
        public string AssetId { get; set; }
    }
}
