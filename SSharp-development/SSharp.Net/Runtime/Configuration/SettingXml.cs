﻿/*
 * Copyright © 2011, Petro Protsyk, Denys Vuika
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *  http://www.apache.org/licenses/LICENSE-2.0
 *  
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Xml.Serialization;

namespace Scripting.SSharp.Runtime.Configuration
{
  /// <summary>
  /// Represents single Setting Item node in script configuration
  /// </summary>
  public class SettingXml
  {
    /// <summary>
    /// Unique name of the item
    /// </summary>
    [XmlAttribute(ConfigSchema.Id)]
    public string Name { get; set; }

    /// <summary>
    /// String value
    /// </summary>
    [XmlAttribute(ConfigSchema.Value)]
    public string Value { get; set; }

    /// <summary>
    /// Type name of the converter
    /// </summary>
    [XmlAttribute(ConfigSchema.Converter)]
    public string Converter { get; set; }
  }
}