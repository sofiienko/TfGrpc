// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tensorflow/core/protobuf/trace_events.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow.Profiler {

  /// <summary>Holder for reflection information generated from tensorflow/core/protobuf/trace_events.proto</summary>
  public static partial class TraceEventsReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/core/protobuf/trace_events.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TraceEventsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cit0ZW5zb3JmbG93L2NvcmUvcHJvdG9idWYvdHJhY2VfZXZlbnRzLnByb3Rv",
            "EhN0ZW5zb3JmbG93LnByb2ZpbGVyIsUBCgVUcmFjZRI4CgdkZXZpY2VzGAEg",
            "AygLMicudGVuc29yZmxvdy5wcm9maWxlci5UcmFjZS5EZXZpY2VzRW50cnkS",
            "NQoMdHJhY2VfZXZlbnRzGAQgAygLMh8udGVuc29yZmxvdy5wcm9maWxlci5U",
            "cmFjZUV2ZW50GksKDERldmljZXNFbnRyeRILCgNrZXkYASABKA0SKgoFdmFs",
            "dWUYAiABKAsyGy50ZW5zb3JmbG93LnByb2ZpbGVyLkRldmljZToCOAEiuQEK",
            "BkRldmljZRIMCgRuYW1lGAEgASgJEhEKCWRldmljZV9pZBgCIAEoDRI9Cgly",
            "ZXNvdXJjZXMYAyADKAsyKi50ZW5zb3JmbG93LnByb2ZpbGVyLkRldmljZS5S",
            "ZXNvdXJjZXNFbnRyeRpPCg5SZXNvdXJjZXNFbnRyeRILCgNrZXkYASABKA0S",
            "LAoFdmFsdWUYAiABKAsyHS50ZW5zb3JmbG93LnByb2ZpbGVyLlJlc291cmNl",
            "OgI4ASItCghSZXNvdXJjZRIMCgRuYW1lGAEgASgJEhMKC3Jlc291cmNlX2lk",
            "GAIgASgNItMBCgpUcmFjZUV2ZW50EhEKCWRldmljZV9pZBgBIAEoDRITCgty",
            "ZXNvdXJjZV9pZBgCIAEoDRIMCgRuYW1lGAMgASgJEhQKDHRpbWVzdGFtcF9w",
            "cxgJIAEoBBITCgtkdXJhdGlvbl9wcxgKIAEoBBI3CgRhcmdzGAsgAygLMiku",
            "dGVuc29yZmxvdy5wcm9maWxlci5UcmFjZUV2ZW50LkFyZ3NFbnRyeRorCglB",
            "cmdzRW50cnkSCwoDa2V5GAEgASgJEg0KBXZhbHVlGAIgASgJOgI4AUIyChhv",
            "cmcudGVuc29yZmxvdy5mcmFtZXdvcmtCEVRyYWNlRXZlbnRzUHJvdG9zUAH4",
            "AQFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Profiler.Trace), global::Tensorflow.Profiler.Trace.Parser, new[]{ "Devices", "TraceEvents" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Profiler.Device), global::Tensorflow.Profiler.Device.Parser, new[]{ "Name", "DeviceId", "Resources" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Profiler.Resource), global::Tensorflow.Profiler.Resource.Parser, new[]{ "Name", "ResourceId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Profiler.TraceEvent), global::Tensorflow.Profiler.TraceEvent.Parser, new[]{ "DeviceId", "ResourceId", "Name", "TimestampPs", "DurationPs", "Args" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A 'Trace' contains metadata for the individual traces of a system.
  /// </summary>
  public sealed partial class Trace : pb::IMessage<Trace> {
    private static readonly pb::MessageParser<Trace> _parser = new pb::MessageParser<Trace>(() => new Trace());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Trace> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Profiler.TraceEventsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Trace() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Trace(Trace other) : this() {
      devices_ = other.devices_.Clone();
      traceEvents_ = other.traceEvents_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Trace Clone() {
      return new Trace(this);
    }

    /// <summary>Field number for the "devices" field.</summary>
    public const int DevicesFieldNumber = 1;
    private static readonly pbc::MapField<uint, global::Tensorflow.Profiler.Device>.Codec _map_devices_codec
        = new pbc::MapField<uint, global::Tensorflow.Profiler.Device>.Codec(pb::FieldCodec.ForUInt32(8), pb::FieldCodec.ForMessage(18, global::Tensorflow.Profiler.Device.Parser), 10);
    private readonly pbc::MapField<uint, global::Tensorflow.Profiler.Device> devices_ = new pbc::MapField<uint, global::Tensorflow.Profiler.Device>();
    /// <summary>
    /// The devices that this trace has information about. Maps from device_id to
    /// more data about the specific device.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<uint, global::Tensorflow.Profiler.Device> Devices {
      get { return devices_; }
    }

    /// <summary>Field number for the "trace_events" field.</summary>
    public const int TraceEventsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Tensorflow.Profiler.TraceEvent> _repeated_traceEvents_codec
        = pb::FieldCodec.ForMessage(34, global::Tensorflow.Profiler.TraceEvent.Parser);
    private readonly pbc::RepeatedField<global::Tensorflow.Profiler.TraceEvent> traceEvents_ = new pbc::RepeatedField<global::Tensorflow.Profiler.TraceEvent>();
    /// <summary>
    /// All trace events capturing in the profiling period.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Tensorflow.Profiler.TraceEvent> TraceEvents {
      get { return traceEvents_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Trace);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Trace other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Devices.Equals(other.Devices)) return false;
      if(!traceEvents_.Equals(other.traceEvents_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Devices.GetHashCode();
      hash ^= traceEvents_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      devices_.WriteTo(output, _map_devices_codec);
      traceEvents_.WriteTo(output, _repeated_traceEvents_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += devices_.CalculateSize(_map_devices_codec);
      size += traceEvents_.CalculateSize(_repeated_traceEvents_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Trace other) {
      if (other == null) {
        return;
      }
      devices_.Add(other.devices_);
      traceEvents_.Add(other.traceEvents_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            devices_.AddEntriesFrom(input, _map_devices_codec);
            break;
          }
          case 34: {
            traceEvents_.AddEntriesFrom(input, _repeated_traceEvents_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A 'device' is a physical entity in the system and is comprised of several
  /// resources.
  /// </summary>
  public sealed partial class Device : pb::IMessage<Device> {
    private static readonly pb::MessageParser<Device> _parser = new pb::MessageParser<Device>(() => new Device());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Device> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Profiler.TraceEventsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Device() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Device(Device other) : this() {
      name_ = other.name_;
      deviceId_ = other.deviceId_;
      resources_ = other.resources_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Device Clone() {
      return new Device(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The name of the device.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "device_id" field.</summary>
    public const int DeviceIdFieldNumber = 2;
    private uint deviceId_;
    /// <summary>
    /// The id of this device, unique in a single trace.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint DeviceId {
      get { return deviceId_; }
      set {
        deviceId_ = value;
      }
    }

    /// <summary>Field number for the "resources" field.</summary>
    public const int ResourcesFieldNumber = 3;
    private static readonly pbc::MapField<uint, global::Tensorflow.Profiler.Resource>.Codec _map_resources_codec
        = new pbc::MapField<uint, global::Tensorflow.Profiler.Resource>.Codec(pb::FieldCodec.ForUInt32(8), pb::FieldCodec.ForMessage(18, global::Tensorflow.Profiler.Resource.Parser), 26);
    private readonly pbc::MapField<uint, global::Tensorflow.Profiler.Resource> resources_ = new pbc::MapField<uint, global::Tensorflow.Profiler.Resource>();
    /// <summary>
    /// The resources on this device, keyed by resource_id;
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<uint, global::Tensorflow.Profiler.Resource> Resources {
      get { return resources_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Device);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Device other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DeviceId != other.DeviceId) return false;
      if (!Resources.Equals(other.Resources)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DeviceId != 0) hash ^= DeviceId.GetHashCode();
      hash ^= Resources.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DeviceId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DeviceId);
      }
      resources_.WriteTo(output, _map_resources_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (DeviceId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DeviceId);
      }
      size += resources_.CalculateSize(_map_resources_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Device other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DeviceId != 0) {
        DeviceId = other.DeviceId;
      }
      resources_.Add(other.resources_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            DeviceId = input.ReadUInt32();
            break;
          }
          case 26: {
            resources_.AddEntriesFrom(input, _map_resources_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A 'resource' generally is a specific computation component on a device. These
  /// can range from threads on CPUs to specific arithmetic units on hardware
  /// devices.
  /// </summary>
  public sealed partial class Resource : pb::IMessage<Resource> {
    private static readonly pb::MessageParser<Resource> _parser = new pb::MessageParser<Resource>(() => new Resource());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Resource> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Profiler.TraceEventsReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Resource() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Resource(Resource other) : this() {
      name_ = other.name_;
      resourceId_ = other.resourceId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Resource Clone() {
      return new Resource(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The name of the resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "resource_id" field.</summary>
    public const int ResourceIdFieldNumber = 2;
    private uint resourceId_;
    /// <summary>
    /// The id of the resource. Unique within a device.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint ResourceId {
      get { return resourceId_; }
      set {
        resourceId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Resource);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Resource other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (ResourceId != other.ResourceId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (ResourceId != 0) hash ^= ResourceId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (ResourceId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ResourceId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (ResourceId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ResourceId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Resource other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.ResourceId != 0) {
        ResourceId = other.ResourceId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            ResourceId = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class TraceEvent : pb::IMessage<TraceEvent> {
    private static readonly pb::MessageParser<TraceEvent> _parser = new pb::MessageParser<TraceEvent>(() => new TraceEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TraceEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Profiler.TraceEventsReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TraceEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TraceEvent(TraceEvent other) : this() {
      deviceId_ = other.deviceId_;
      resourceId_ = other.resourceId_;
      name_ = other.name_;
      timestampPs_ = other.timestampPs_;
      durationPs_ = other.durationPs_;
      args_ = other.args_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TraceEvent Clone() {
      return new TraceEvent(this);
    }

    /// <summary>Field number for the "device_id" field.</summary>
    public const int DeviceIdFieldNumber = 1;
    private uint deviceId_;
    /// <summary>
    /// The id of the device that this event occurred on. The full dataset should
    /// have this device present in the Trace object.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint DeviceId {
      get { return deviceId_; }
      set {
        deviceId_ = value;
      }
    }

    /// <summary>Field number for the "resource_id" field.</summary>
    public const int ResourceIdFieldNumber = 2;
    private uint resourceId_;
    /// <summary>
    /// The id of the resource that this event occurred on. The full dataset should
    /// have this resource present in the Device object of the Trace object. A
    /// resource_id is unique on a specific device, but not necessarily within the
    /// trace.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint ResourceId {
      get { return resourceId_; }
      set {
        resourceId_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    /// <summary>
    /// The name of this trace event.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "timestamp_ps" field.</summary>
    public const int TimestampPsFieldNumber = 9;
    private ulong timestampPs_;
    /// <summary>
    /// The timestamp that this event occurred at (in picos since tracing started).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong TimestampPs {
      get { return timestampPs_; }
      set {
        timestampPs_ = value;
      }
    }

    /// <summary>Field number for the "duration_ps" field.</summary>
    public const int DurationPsFieldNumber = 10;
    private ulong durationPs_;
    /// <summary>
    /// The duration of the event in picoseconds if applicable.
    /// Events without duration are called instant events.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong DurationPs {
      get { return durationPs_; }
      set {
        durationPs_ = value;
      }
    }

    /// <summary>Field number for the "args" field.</summary>
    public const int ArgsFieldNumber = 11;
    private static readonly pbc::MapField<string, string>.Codec _map_args_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 90);
    private readonly pbc::MapField<string, string> args_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Extra arguments that will be displayed in trace view.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Args {
      get { return args_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TraceEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TraceEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DeviceId != other.DeviceId) return false;
      if (ResourceId != other.ResourceId) return false;
      if (Name != other.Name) return false;
      if (TimestampPs != other.TimestampPs) return false;
      if (DurationPs != other.DurationPs) return false;
      if (!Args.Equals(other.Args)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DeviceId != 0) hash ^= DeviceId.GetHashCode();
      if (ResourceId != 0) hash ^= ResourceId.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (TimestampPs != 0UL) hash ^= TimestampPs.GetHashCode();
      if (DurationPs != 0UL) hash ^= DurationPs.GetHashCode();
      hash ^= Args.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (DeviceId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(DeviceId);
      }
      if (ResourceId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ResourceId);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (TimestampPs != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(TimestampPs);
      }
      if (DurationPs != 0UL) {
        output.WriteRawTag(80);
        output.WriteUInt64(DurationPs);
      }
      args_.WriteTo(output, _map_args_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DeviceId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DeviceId);
      }
      if (ResourceId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ResourceId);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (TimestampPs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TimestampPs);
      }
      if (DurationPs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(DurationPs);
      }
      size += args_.CalculateSize(_map_args_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TraceEvent other) {
      if (other == null) {
        return;
      }
      if (other.DeviceId != 0) {
        DeviceId = other.DeviceId;
      }
      if (other.ResourceId != 0) {
        ResourceId = other.ResourceId;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.TimestampPs != 0UL) {
        TimestampPs = other.TimestampPs;
      }
      if (other.DurationPs != 0UL) {
        DurationPs = other.DurationPs;
      }
      args_.Add(other.args_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            DeviceId = input.ReadUInt32();
            break;
          }
          case 16: {
            ResourceId = input.ReadUInt32();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 72: {
            TimestampPs = input.ReadUInt64();
            break;
          }
          case 80: {
            DurationPs = input.ReadUInt64();
            break;
          }
          case 90: {
            args_.AddEntriesFrom(input, _map_args_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code