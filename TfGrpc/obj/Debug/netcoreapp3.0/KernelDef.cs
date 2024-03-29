// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tensorflow/core/framework/kernel_def.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow {

  /// <summary>Holder for reflection information generated from tensorflow/core/framework/kernel_def.proto</summary>
  public static partial class KernelDefReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/core/framework/kernel_def.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KernelDefReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cip0ZW5zb3JmbG93L2NvcmUvZnJhbWV3b3JrL2tlcm5lbF9kZWYucHJvdG8S",
            "CnRlbnNvcmZsb3caKnRlbnNvcmZsb3cvY29yZS9mcmFtZXdvcmsvYXR0cl92",
            "YWx1ZS5wcm90byLvAQoJS2VybmVsRGVmEgoKAm9wGAEgASgJEhMKC2Rldmlj",
            "ZV90eXBlGAIgASgJEjgKCmNvbnN0cmFpbnQYAyADKAsyJC50ZW5zb3JmbG93",
            "Lktlcm5lbERlZi5BdHRyQ29uc3RyYWludBIXCg9ob3N0X21lbW9yeV9hcmcY",
            "BCADKAkSDQoFbGFiZWwYBSABKAkSEAoIcHJpb3JpdHkYBiABKAUaTQoOQXR0",
            "ckNvbnN0cmFpbnQSDAoEbmFtZRgBIAEoCRItCg5hbGxvd2VkX3ZhbHVlcxgC",
            "IAEoCzIVLnRlbnNvcmZsb3cuQXR0clZhbHVlIjMKCktlcm5lbExpc3QSJQoG",
            "a2VybmVsGAEgAygLMhUudGVuc29yZmxvdy5LZXJuZWxEZWZCbwoYb3JnLnRl",
            "bnNvcmZsb3cuZnJhbWV3b3JrQg9LZXJuZWxEZWZQcm90b3NQAVo9Z2l0aHVi",
            "LmNvbS90ZW5zb3JmbG93L3RlbnNvcmZsb3cvdGVuc29yZmxvdy9nby9jb3Jl",
            "L2ZyYW1ld29ya/gBAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Tensorflow.AttrValueReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.KernelDef), global::Tensorflow.KernelDef.Parser, new[]{ "Op", "DeviceType", "Constraint", "HostMemoryArg", "Label", "Priority" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.KernelDef.Types.AttrConstraint), global::Tensorflow.KernelDef.Types.AttrConstraint.Parser, new[]{ "Name", "AllowedValues" }, null, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.KernelList), global::Tensorflow.KernelList.Parser, new[]{ "Kernel" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class KernelDef : pb::IMessage<KernelDef> {
    private static readonly pb::MessageParser<KernelDef> _parser = new pb::MessageParser<KernelDef>(() => new KernelDef());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KernelDef> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.KernelDefReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KernelDef() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KernelDef(KernelDef other) : this() {
      op_ = other.op_;
      deviceType_ = other.deviceType_;
      constraint_ = other.constraint_.Clone();
      hostMemoryArg_ = other.hostMemoryArg_.Clone();
      label_ = other.label_;
      priority_ = other.priority_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KernelDef Clone() {
      return new KernelDef(this);
    }

    /// <summary>Field number for the "op" field.</summary>
    public const int OpFieldNumber = 1;
    private string op_ = "";
    /// <summary>
    /// Must match the name of an Op.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Op {
      get { return op_; }
      set {
        op_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "device_type" field.</summary>
    public const int DeviceTypeFieldNumber = 2;
    private string deviceType_ = "";
    /// <summary>
    /// Type of device this kernel runs on.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeviceType {
      get { return deviceType_; }
      set {
        deviceType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "constraint" field.</summary>
    public const int ConstraintFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Tensorflow.KernelDef.Types.AttrConstraint> _repeated_constraint_codec
        = pb::FieldCodec.ForMessage(26, global::Tensorflow.KernelDef.Types.AttrConstraint.Parser);
    private readonly pbc::RepeatedField<global::Tensorflow.KernelDef.Types.AttrConstraint> constraint_ = new pbc::RepeatedField<global::Tensorflow.KernelDef.Types.AttrConstraint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Tensorflow.KernelDef.Types.AttrConstraint> Constraint {
      get { return constraint_; }
    }

    /// <summary>Field number for the "host_memory_arg" field.</summary>
    public const int HostMemoryArgFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_hostMemoryArg_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> hostMemoryArg_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Names of the Op's input_/output_args that reside in host memory
    /// instead of device memory.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> HostMemoryArg {
      get { return hostMemoryArg_; }
    }

    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 5;
    private string label_ = "";
    /// <summary>
    /// This allows experimental kernels to be registered for an op that
    /// won't be used unless the user specifies a "_kernel" attr with
    /// value matching this.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Label {
      get { return label_; }
      set {
        label_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "priority" field.</summary>
    public const int PriorityFieldNumber = 6;
    private int priority_;
    /// <summary>
    /// Prioritization of kernel amongst different devices. By default we assume
    /// priority is 0. The higher the priority the better. By default (i.e. if
    /// this is not set), we prefer GPU kernels over CPU.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Priority {
      get { return priority_; }
      set {
        priority_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KernelDef);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KernelDef other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Op != other.Op) return false;
      if (DeviceType != other.DeviceType) return false;
      if(!constraint_.Equals(other.constraint_)) return false;
      if(!hostMemoryArg_.Equals(other.hostMemoryArg_)) return false;
      if (Label != other.Label) return false;
      if (Priority != other.Priority) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Op.Length != 0) hash ^= Op.GetHashCode();
      if (DeviceType.Length != 0) hash ^= DeviceType.GetHashCode();
      hash ^= constraint_.GetHashCode();
      hash ^= hostMemoryArg_.GetHashCode();
      if (Label.Length != 0) hash ^= Label.GetHashCode();
      if (Priority != 0) hash ^= Priority.GetHashCode();
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
      if (Op.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Op);
      }
      if (DeviceType.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DeviceType);
      }
      constraint_.WriteTo(output, _repeated_constraint_codec);
      hostMemoryArg_.WriteTo(output, _repeated_hostMemoryArg_codec);
      if (Label.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Label);
      }
      if (Priority != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Priority);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Op.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Op);
      }
      if (DeviceType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceType);
      }
      size += constraint_.CalculateSize(_repeated_constraint_codec);
      size += hostMemoryArg_.CalculateSize(_repeated_hostMemoryArg_codec);
      if (Label.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Label);
      }
      if (Priority != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Priority);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(KernelDef other) {
      if (other == null) {
        return;
      }
      if (other.Op.Length != 0) {
        Op = other.Op;
      }
      if (other.DeviceType.Length != 0) {
        DeviceType = other.DeviceType;
      }
      constraint_.Add(other.constraint_);
      hostMemoryArg_.Add(other.hostMemoryArg_);
      if (other.Label.Length != 0) {
        Label = other.Label;
      }
      if (other.Priority != 0) {
        Priority = other.Priority;
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
            Op = input.ReadString();
            break;
          }
          case 18: {
            DeviceType = input.ReadString();
            break;
          }
          case 26: {
            constraint_.AddEntriesFrom(input, _repeated_constraint_codec);
            break;
          }
          case 34: {
            hostMemoryArg_.AddEntriesFrom(input, _repeated_hostMemoryArg_codec);
            break;
          }
          case 42: {
            Label = input.ReadString();
            break;
          }
          case 48: {
            Priority = input.ReadInt32();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the KernelDef message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class AttrConstraint : pb::IMessage<AttrConstraint> {
        private static readonly pb::MessageParser<AttrConstraint> _parser = new pb::MessageParser<AttrConstraint>(() => new AttrConstraint());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<AttrConstraint> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Tensorflow.KernelDef.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public AttrConstraint() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public AttrConstraint(AttrConstraint other) : this() {
          name_ = other.name_;
          allowedValues_ = other.allowedValues_ != null ? other.allowedValues_.Clone() : null;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public AttrConstraint Clone() {
          return new AttrConstraint(this);
        }

        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";
        /// <summary>
        /// Name of an attr from the Op.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Name {
          get { return name_; }
          set {
            name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "allowed_values" field.</summary>
        public const int AllowedValuesFieldNumber = 2;
        private global::Tensorflow.AttrValue allowedValues_;
        /// <summary>
        /// A list of values that this kernel supports for this attr.
        /// Like OpDef.AttrDef.allowed_values, except for kernels instead of Ops.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Tensorflow.AttrValue AllowedValues {
          get { return allowedValues_; }
          set {
            allowedValues_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as AttrConstraint);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(AttrConstraint other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Name != other.Name) return false;
          if (!object.Equals(AllowedValues, other.AllowedValues)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Name.Length != 0) hash ^= Name.GetHashCode();
          if (allowedValues_ != null) hash ^= AllowedValues.GetHashCode();
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
          if (allowedValues_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(AllowedValues);
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
          if (allowedValues_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(AllowedValues);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(AttrConstraint other) {
          if (other == null) {
            return;
          }
          if (other.Name.Length != 0) {
            Name = other.Name;
          }
          if (other.allowedValues_ != null) {
            if (allowedValues_ == null) {
              AllowedValues = new global::Tensorflow.AttrValue();
            }
            AllowedValues.MergeFrom(other.AllowedValues);
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
              case 18: {
                if (allowedValues_ == null) {
                  AllowedValues = new global::Tensorflow.AttrValue();
                }
                input.ReadMessage(AllowedValues);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  /// <summary>
  /// A collection of KernelDefs
  /// </summary>
  public sealed partial class KernelList : pb::IMessage<KernelList> {
    private static readonly pb::MessageParser<KernelList> _parser = new pb::MessageParser<KernelList>(() => new KernelList());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KernelList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.KernelDefReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KernelList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KernelList(KernelList other) : this() {
      kernel_ = other.kernel_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KernelList Clone() {
      return new KernelList(this);
    }

    /// <summary>Field number for the "kernel" field.</summary>
    public const int KernelFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Tensorflow.KernelDef> _repeated_kernel_codec
        = pb::FieldCodec.ForMessage(10, global::Tensorflow.KernelDef.Parser);
    private readonly pbc::RepeatedField<global::Tensorflow.KernelDef> kernel_ = new pbc::RepeatedField<global::Tensorflow.KernelDef>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Tensorflow.KernelDef> Kernel {
      get { return kernel_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KernelList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KernelList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!kernel_.Equals(other.kernel_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= kernel_.GetHashCode();
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
      kernel_.WriteTo(output, _repeated_kernel_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += kernel_.CalculateSize(_repeated_kernel_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(KernelList other) {
      if (other == null) {
        return;
      }
      kernel_.Add(other.kernel_);
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
            kernel_.AddEntriesFrom(input, _repeated_kernel_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
