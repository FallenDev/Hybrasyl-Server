// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 6.0.22.0. www.xsd2code.com
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace Hybrasyl.Xml
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Xml;
using System.IO;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4161.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="http://www.hybrasyl.com/XML/Hybrasyl/2020-02")]
[XmlRootAttribute(Namespace="http://www.hybrasyl.com/XML/Hybrasyl/2020-02", IsNullable=false)]
public partial class Map
{
    #region Private fields
    private string _name;
    private string _description;
    private MapFlags _flags;
    private List<Warp> _warps;
    private List<Reactor> _reactors;
    private SpawnGroup _spawnGroup;
    private List<MapNpc> _npcs;
    private List<MapSign> _signs;
    private ushort _id;
    private byte _music;
    private byte _x;
    private byte _y;
    private bool _isEnabled;
    private bool _allowCasting;
    private static XmlSerializer _serializerXml;
    #endregion
    
    public Map()
    {
        _signs = new List<MapSign>();
        _npcs = new List<MapNpc>();
        _spawnGroup = new SpawnGroup();
        _reactors = new List<Reactor>();
        _warps = new List<Warp>();
        _music = ((byte)(0));
        _isEnabled = true;
        _allowCasting = true;
    }
    
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
    
    public string Description
    {
        get
        {
            return _description;
        }
        set
        {
            _description = value;
        }
    }
    
    public MapFlags Flags
    {
        get
        {
            return _flags;
        }
        set
        {
            _flags = value;
        }
    }
    
    [XmlArrayItemAttribute(IsNullable=false)]
    public List<Warp> Warps
    {
        get
        {
            return _warps;
        }
        set
        {
            _warps = value;
        }
    }
    
    [XmlArrayItemAttribute(IsNullable=false)]
    public List<Reactor> Reactors
    {
        get
        {
            return _reactors;
        }
        set
        {
            _reactors = value;
        }
    }
    
    public SpawnGroup SpawnGroup
    {
        get
        {
            return _spawnGroup;
        }
        set
        {
            _spawnGroup = value;
        }
    }
    
    [XmlArrayItemAttribute("Npc", IsNullable=false)]
    public List<MapNpc> Npcs
    {
        get
        {
            return _npcs;
        }
        set
        {
            _npcs = value;
        }
    }
    
    [XmlArrayItemAttribute("Sign", IsNullable=false)]
    public List<MapSign> Signs
    {
        get
        {
            return _signs;
        }
        set
        {
            _signs = value;
        }
    }
    
    [XmlAttribute]
    public ushort Id
    {
        get
        {
            return _id;
        }
        set
        {
            _id = value;
        }
    }
    
    [XmlAttribute]
    [DefaultValue(typeof(byte), "0")]
    public byte Music
    {
        get
        {
            return _music;
        }
        set
        {
            _music = value;
        }
    }
    
    [XmlAttribute]
    public byte X
    {
        get
        {
            return _x;
        }
        set
        {
            _x = value;
        }
    }
    
    [XmlAttribute]
    public byte Y
    {
        get
        {
            return _y;
        }
        set
        {
            _y = value;
        }
    }
    
    [XmlAttribute]
    [DefaultValue(true)]
    public bool IsEnabled
    {
        get
        {
            return _isEnabled;
        }
        set
        {
            _isEnabled = value;
        }
    }
    
    [XmlAttribute]
    [DefaultValue(true)]
    public bool AllowCasting
    {
        get
        {
            return _allowCasting;
        }
        set
        {
            _allowCasting = value;
        }
    }
    
    private static XmlSerializer SerializerXml
    {
        get
        {
            if ((_serializerXml == null))
            {
                _serializerXml = new XmlSerializerFactory().CreateSerializer(typeof(Map));
            }
            return _serializerXml;
        }
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serialize Map object
    /// </summary>
    /// <returns>XML value</returns>
    public virtual string Serialize()
    {
        StreamReader streamReader = null;
        MemoryStream memoryStream = null;
        try
        {
            memoryStream = new MemoryStream();
            System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
            xmlWriterSettings.Indent = true;
            xmlWriterSettings.IndentChars = "  ";
            System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
            SerializerXml.Serialize(xmlWriter, this);
            memoryStream.Seek(0, SeekOrigin.Begin);
            streamReader = new StreamReader(memoryStream);
            return streamReader.ReadToEnd();
        }
        finally
        {
            if ((streamReader != null))
            {
                streamReader.Dispose();
            }
            if ((memoryStream != null))
            {
                memoryStream.Dispose();
            }
        }
    }
    
    /// <summary>
    /// Deserializes Map object
    /// </summary>
    /// <param name="input">string to deserialize</param>
    /// <param name="obj">Output Map object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out Map obj, out Exception exception)
    {
        exception = null;
        obj = default(Map);
        try
        {
            obj = Deserialize(input);
            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool Deserialize(string input, out Map obj)
    {
        Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public static Map Deserialize(string input)
    {
        StringReader stringReader = null;
        try
        {
            stringReader = new StringReader(input);
            return ((Map)(SerializerXml.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static Map Deserialize(Stream s)
    {
        return ((Map)(SerializerXml.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current Map object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out Exception exception)
    {
        exception = null;
        try
        {
            SaveToFile(fileName);
            return true;
        }
        catch (Exception e)
        {
            exception = e;
            return false;
        }
    }
    
    public virtual void SaveToFile(string fileName)
    {
        StreamWriter streamWriter = null;
        try
        {
            string dataString = Serialize();
            FileInfo outputFile = new FileInfo(fileName);
            streamWriter = outputFile.CreateText();
            streamWriter.WriteLine(dataString);
            streamWriter.Close();
        }
        finally
        {
            if ((streamWriter != null))
            {
                streamWriter.Dispose();
            }
        }
    }
    
    /// <summary>
    /// Deserializes xml markup from file into an Map object
    /// </summary>
    /// <param name="fileName">File to load and deserialize</param>
    /// <param name="obj">Output Map object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out Map obj, out Exception exception)
    {
        exception = null;
        obj = default(Map);
        try
        {
            obj = LoadFromFile(fileName);
            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool LoadFromFile(string fileName, out Map obj)
    {
        Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static Map LoadFromFile(string fileName)
    {
        FileStream file = null;
        StreamReader sr = null;
        try
        {
            file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            sr = new StreamReader(file);
            string dataString = sr.ReadToEnd();
            sr.Close();
            file.Close();
            return Deserialize(dataString);
        }
        finally
        {
            if ((file != null))
            {
                file.Dispose();
            }
            if ((sr != null))
            {
                sr.Dispose();
            }
        }
    }
}
}
#pragma warning restore
