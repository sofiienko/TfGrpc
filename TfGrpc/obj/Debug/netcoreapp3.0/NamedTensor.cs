// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tensorflow/core/protobuf/named_tensor.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow {

  /// <summary>Holder for reflection information generated from tensorflow/core/protobuf/named_tensor.proto</summary>
  public static partial class NamedTensorReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/core/protobuf/named_tensor.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NamedTensorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cit0ZW5zb3JmbG93L2NvcmUvcHJvdG9idWYvbmFtZWRfdGVuc29yLnByb3Rv",
            "Egp0ZW5zb3JmbG93GiZ0ZW5zb3JmbG93L2NvcmUvZnJhbWV3b3JrL3RlbnNv",
            "ci5wcm90byJJChBOYW1lZFRlbnNvclByb3RvEgwKBG5hbWUYASABKAkSJwoG",
            "dGVuc29yGAIgASgLMhcudGVuc29yZmxvdy5UZW5zb3JQcm90b0JwChhvcmcu",
            "dGVuc29yZmxvdy5mcmFtZXdvcmtCEU5hbWVkVGVuc29yUHJvdG9zUAFaPGdp",
            "dGh1Yi5jb20vdGVuc29yZmxvdy90ZW5zb3JmbG93L3RlbnNvcmZsb3cvZ28v",
            "Y29yZS9wcm90b2J1ZvgBAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Tensorflow.TensorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.NamedTensorProto), global::Tensorflow.NamedTensorProto.Parser, new[]{ "Name", "Tensor" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A pair of tensor name and tensor values.
  /// </summary>
  public sealed partial class NamedTensorProto : pb::IMessage<NamedTensorProto> {
    private static readonly pb::MessageParser<NamedTensorProto> _parser = new pb::MessageParser<NamedTensorProto>(() => new NamedTensorProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NamedTensorProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.NamedTensorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NamedTensorProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NamedTensorProto(NamedTensorProto other) : this() {
      name_ = other.name_;
      tensor_ = other.tensor_ != null ? other.tensor_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NamedTensorProto Clone() {
      return new NamedTensorProto(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Name of the tensor.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tensor" field.</summary>
    public const int TensorFieldNumber = 2;
    private global::Tensorflow.TensorProto tensor_;
    /// <summary>
    /// The client can populate a TensorProto using a tensorflow::Tensor`, or
    /// directly using the protobuf field accessors.
    ///
    /// The client specifies whether the returned tensor values should be
    /// filled tensor fields (float_val, int_val, etc.) or encoded in a
    /// compact form in tensor.tensor_content.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.TensorProto Tensor {
      get { return tensor_; }
      set {
        tensor_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NamedTensorProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NamedTensorProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(Tensor, other.Tensor)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (tensor_ != null) hash ^= Tensor.GetHashCode();
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
      if (tensor_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Tensor);
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
      if (tensor_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Tensor);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(NamedTensorProto other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.tensor_ != null) {
        if (tensor_ == null) {
          Tensor = new global::Tensorflow.TensorProto();
        }
        Tensor.MergeFrom(other.Tensor);
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
            if (tensor_ == null) {
              Tensor = new global::Tensorflow.TensorProto();
            }
            input.ReadMessage(Tensor);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code