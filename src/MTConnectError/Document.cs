﻿// Copyright (c) 2016 Feenux LLC, All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace MTConnect.MTConnectError
{
    [XmlRoot("MTConnectError")]
    public class Document
    {
        public Document() { }

        public static Document Create(string xml)
        {
            try
            {
                var version = MTConnect.Version.Get(xml);

                var serializer = new XmlSerializer(typeof(Document));
                using (var textReader = new StringReader(Namespaces.Clear(xml)))
                using (var xmlReader = XmlReader.Create(textReader))
                {
                    var doc = (Document)serializer.Deserialize(xmlReader);
                    if (doc != null)
                    {
                        doc._version = version;
                        return doc;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        [XmlElement("Header")]
        public Headers.MTConnectErrorHeader Header { get; set; }

        [XmlArray("Errors")]
        public List<Error> Errors { get; set; }

        protected double _version;
        public double Version { get { return _version; } }

        [XmlIgnore]
        public object UserObject { get; set; }
    }
}