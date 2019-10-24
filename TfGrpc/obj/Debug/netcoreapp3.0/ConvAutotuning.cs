// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tensorflow/core/protobuf/conv_autotuning.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow {

  /// <summary>Holder for reflection information generated from tensorflow/core/protobuf/conv_autotuning.proto</summary>
  public static partial class ConvAutotuningReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/core/protobuf/conv_autotuning.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConvAutotuningReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci50ZW5zb3JmbG93L2NvcmUvcHJvdG9idWYvY29udl9hdXRvdHVuaW5nLnBy",
            "b3RvEgp0ZW5zb3JmbG93GiR0ZW5zb3JmbG93L3N0cmVhbV9leGVjdXRvci9k",
            "bm4ucHJvdG8inQQKEENvbnZvbHV0aW9uUHJvdG8SMgoEa2luZBgBIAEoDjIk",
            "LnN0cmVhbV9leGVjdXRvci5kbm4uQ29udm9sdXRpb25LaW5kEjkKBWlucHV0",
            "GAIgASgLMiouc3RyZWFtX2V4ZWN1dG9yLmRubi5UZW5zb3JEZXNjcmlwdG9y",
            "UHJvdG8SOgoGZmlsdGVyGAMgASgLMiouc3RyZWFtX2V4ZWN1dG9yLmRubi5U",
            "ZW5zb3JEZXNjcmlwdG9yUHJvdG8SOgoGb3V0cHV0GAQgASgLMiouc3RyZWFt",
            "X2V4ZWN1dG9yLmRubi5UZW5zb3JEZXNjcmlwdG9yUHJvdG8SQgoJY29udl9k",
            "ZXNjGAUgASgLMi8uc3RyZWFtX2V4ZWN1dG9yLmRubi5Db252b2x1dGlvbkRl",
            "c2NyaXB0b3JQcm90bxISCgpjb252X3NjYWxlGAYgASgBEhgKEHNpZGVfdmFs",
            "dWVfc2NhbGUYByABKAESNwoKYWN0aXZhdGlvbhgIIAEoDjIjLnN0cmVhbV9l",
            "eGVjdXRvci5kbm4uQWN0aXZhdGlvbk1vZGUSFQoNaW5wdXRfYWRkcmVzcxgJ",
            "IAEoAxIWCg5maWx0ZXJfYWRkcmVzcxgKIAEoAxIWCg5vdXRwdXRfYWRkcmVz",
            "cxgLIAEoAxIUCgxiaWFzX2FkZHJlc3MYDCABKAMSGgoSc2lkZV9pbnB1dF9h",
            "ZGRyZXNzGA0gASgDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::StreamExecutor.Dnn.DnnReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.ConvolutionProto), global::Tensorflow.ConvolutionProto.Parser, new[]{ "Kind", "Input", "Filter", "Output", "ConvDesc", "ConvScale", "SideValueScale", "Activation", "InputAddress", "FilterAddress", "OutputAddress", "BiasAddress", "SideInputAddress" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A convolution. Currently it's only used for logging. In the future, we may
  /// want to use it in the API as well.
  /// </summary>
  public sealed partial class ConvolutionProto : pb::IMessage<ConvolutionProto> {
    private static readonly pb::MessageParser<ConvolutionProto> _parser = new pb::MessageParser<ConvolutionProto>(() => new ConvolutionProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ConvolutionProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.ConvAutotuningReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConvolutionProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConvolutionProto(ConvolutionProto other) : this() {
      kind_ = other.kind_;
      input_ = other.input_ != null ? other.input_.Clone() : null;
      filter_ = other.filter_ != null ? other.filter_.Clone() : null;
      output_ = other.output_ != null ? other.output_.Clone() : null;
      convDesc_ = other.convDesc_ != null ? other.convDesc_.Clone() : null;
      convScale_ = other.convScale_;
      sideValueScale_ = other.sideValueScale_;
      activation_ = other.activation_;
      inputAddress_ = other.inputAddress_;
      filterAddress_ = other.filterAddress_;
      outputAddress_ = other.outputAddress_;
      biasAddress_ = other.biasAddress_;
      sideInputAddress_ = other.sideInputAddress_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConvolutionProto Clone() {
      return new ConvolutionProto(this);
    }

    /// <summary>Field number for the "kind" field.</summary>
    public const int KindFieldNumber = 1;
    private global::StreamExecutor.Dnn.ConvolutionKind kind_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::StreamExecutor.Dnn.ConvolutionKind Kind {
      get { return kind_; }
      set {
        kind_ = value;
      }
    }

    /// <summary>Field number for the "input" field.</summary>
    public const int InputFieldNumber = 2;
    private global::StreamExecutor.Dnn.TensorDescriptorProto input_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::StreamExecutor.Dnn.TensorDescriptorProto Input {
      get { return input_; }
      set {
        input_ = value;
      }
    }

    /// <summary>Field number for the "filter" field.</summary>
    public const int FilterFieldNumber = 3;
    private global::StreamExecutor.Dnn.TensorDescriptorProto filter_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::StreamExecutor.Dnn.TensorDescriptorProto Filter {
      get { return filter_; }
      set {
        filter_ = value;
      }
    }

    /// <summary>Field number for the "output" field.</summary>
    public const int OutputFieldNumber = 4;
    private global::StreamExecutor.Dnn.TensorDescriptorProto output_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::StreamExecutor.Dnn.TensorDescriptorProto Output {
      get { return output_; }
      set {
        output_ = value;
      }
    }

    /// <summary>Field number for the "conv_desc" field.</summary>
    public const int ConvDescFieldNumber = 5;
    private global::StreamExecutor.Dnn.ConvolutionDescriptorProto convDesc_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::StreamExecutor.Dnn.ConvolutionDescriptorProto ConvDesc {
      get { return convDesc_; }
      set {
        convDesc_ = value;
      }
    }

    /// <summary>Field number for the "conv_scale" field.</summary>
    public const int ConvScaleFieldNumber = 6;
    private double convScale_;
    /// <summary>
    /// result = conv_scale * conv(...) + side_value_scale * side_value.
    /// side_value is an arbitrary buffer if activation is not none. Otherwise, it
    /// has to be the result buffer (using its old values).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double ConvScale {
      get { return convScale_; }
      set {
        convScale_ = value;
      }
    }

    /// <summary>Field number for the "side_value_scale" field.</summary>
    public const int SideValueScaleFieldNumber = 7;
    private double sideValueScale_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double SideValueScale {
      get { return sideValueScale_; }
      set {
        sideValueScale_ = value;
      }
    }

    /// <summary>Field number for the "activation" field.</summary>
    public const int ActivationFieldNumber = 8;
    private global::StreamExecutor.Dnn.ActivationMode activation_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::StreamExecutor.Dnn.ActivationMode Activation {
      get { return activation_; }
      set {
        activation_ = value;
      }
    }

    /// <summary>Field number for the "input_address" field.</summary>
    public const int InputAddressFieldNumber = 9;
    private long inputAddress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long InputAddress {
      get { return inputAddress_; }
      set {
        inputAddress_ = value;
      }
    }

    /// <summary>Field number for the "filter_address" field.</summary>
    public const int FilterAddressFieldNumber = 10;
    private long filterAddress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long FilterAddress {
      get { return filterAddress_; }
      set {
        filterAddress_ = value;
      }
    }

    /// <summary>Field number for the "output_address" field.</summary>
    public const int OutputAddressFieldNumber = 11;
    private long outputAddress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long OutputAddress {
      get { return outputAddress_; }
      set {
        outputAddress_ = value;
      }
    }

    /// <summary>Field number for the "bias_address" field.</summary>
    public const int BiasAddressFieldNumber = 12;
    private long biasAddress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long BiasAddress {
      get { return biasAddress_; }
      set {
        biasAddress_ = value;
      }
    }

    /// <summary>Field number for the "side_input_address" field.</summary>
    public const int SideInputAddressFieldNumber = 13;
    private long sideInputAddress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long SideInputAddress {
      get { return sideInputAddress_; }
      set {
        sideInputAddress_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ConvolutionProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ConvolutionProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Kind != other.Kind) return false;
      if (!object.Equals(Input, other.Input)) return false;
      if (!object.Equals(Filter, other.Filter)) return false;
      if (!object.Equals(Output, other.Output)) return false;
      if (!object.Equals(ConvDesc, other.ConvDesc)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ConvScale, other.ConvScale)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(SideValueScale, other.SideValueScale)) return false;
      if (Activation != other.Activation) return false;
      if (InputAddress != other.InputAddress) return false;
      if (FilterAddress != other.FilterAddress) return false;
      if (OutputAddress != other.OutputAddress) return false;
      if (BiasAddress != other.BiasAddress) return false;
      if (SideInputAddress != other.SideInputAddress) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Kind != 0) hash ^= Kind.GetHashCode();
      if (input_ != null) hash ^= Input.GetHashCode();
      if (filter_ != null) hash ^= Filter.GetHashCode();
      if (output_ != null) hash ^= Output.GetHashCode();
      if (convDesc_ != null) hash ^= ConvDesc.GetHashCode();
      if (ConvScale != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ConvScale);
      if (SideValueScale != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(SideValueScale);
      if (Activation != 0) hash ^= Activation.GetHashCode();
      if (InputAddress != 0L) hash ^= InputAddress.GetHashCode();
      if (FilterAddress != 0L) hash ^= FilterAddress.GetHashCode();
      if (OutputAddress != 0L) hash ^= OutputAddress.GetHashCode();
      if (BiasAddress != 0L) hash ^= BiasAddress.GetHashCode();
      if (SideInputAddress != 0L) hash ^= SideInputAddress.GetHashCode();
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
      if (Kind != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Kind);
      }
      if (input_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Input);
      }
      if (filter_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Filter);
      }
      if (output_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Output);
      }
      if (convDesc_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ConvDesc);
      }
      if (ConvScale != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(ConvScale);
      }
      if (SideValueScale != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(SideValueScale);
      }
      if (Activation != 0) {
        output.WriteRawTag(64);
        output.WriteEnum((int) Activation);
      }
      if (InputAddress != 0L) {
        output.WriteRawTag(72);
        output.WriteInt64(InputAddress);
      }
      if (FilterAddress != 0L) {
        output.WriteRawTag(80);
        output.WriteInt64(FilterAddress);
      }
      if (OutputAddress != 0L) {
        output.WriteRawTag(88);
        output.WriteInt64(OutputAddress);
      }
      if (BiasAddress != 0L) {
        output.WriteRawTag(96);
        output.WriteInt64(BiasAddress);
      }
      if (SideInputAddress != 0L) {
        output.WriteRawTag(104);
        output.WriteInt64(SideInputAddress);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Kind != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Kind);
      }
      if (input_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Input);
      }
      if (filter_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Filter);
      }
      if (output_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Output);
      }
      if (convDesc_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ConvDesc);
      }
      if (ConvScale != 0D) {
        size += 1 + 8;
      }
      if (SideValueScale != 0D) {
        size += 1 + 8;
      }
      if (Activation != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Activation);
      }
      if (InputAddress != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(InputAddress);
      }
      if (FilterAddress != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(FilterAddress);
      }
      if (OutputAddress != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(OutputAddress);
      }
      if (BiasAddress != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BiasAddress);
      }
      if (SideInputAddress != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(SideInputAddress);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ConvolutionProto other) {
      if (other == null) {
        return;
      }
      if (other.Kind != 0) {
        Kind = other.Kind;
      }
      if (other.input_ != null) {
        if (input_ == null) {
          Input = new global::StreamExecutor.Dnn.TensorDescriptorProto();
        }
        Input.MergeFrom(other.Input);
      }
      if (other.filter_ != null) {
        if (filter_ == null) {
          Filter = new global::StreamExecutor.Dnn.TensorDescriptorProto();
        }
        Filter.MergeFrom(other.Filter);
      }
      if (other.output_ != null) {
        if (output_ == null) {
          Output = new global::StreamExecutor.Dnn.TensorDescriptorProto();
        }
        Output.MergeFrom(other.Output);
      }
      if (other.convDesc_ != null) {
        if (convDesc_ == null) {
          ConvDesc = new global::StreamExecutor.Dnn.ConvolutionDescriptorProto();
        }
        ConvDesc.MergeFrom(other.ConvDesc);
      }
      if (other.ConvScale != 0D) {
        ConvScale = other.ConvScale;
      }
      if (other.SideValueScale != 0D) {
        SideValueScale = other.SideValueScale;
      }
      if (other.Activation != 0) {
        Activation = other.Activation;
      }
      if (other.InputAddress != 0L) {
        InputAddress = other.InputAddress;
      }
      if (other.FilterAddress != 0L) {
        FilterAddress = other.FilterAddress;
      }
      if (other.OutputAddress != 0L) {
        OutputAddress = other.OutputAddress;
      }
      if (other.BiasAddress != 0L) {
        BiasAddress = other.BiasAddress;
      }
      if (other.SideInputAddress != 0L) {
        SideInputAddress = other.SideInputAddress;
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
          case 8: {
            Kind = (global::StreamExecutor.Dnn.ConvolutionKind) input.ReadEnum();
            break;
          }
          case 18: {
            if (input_ == null) {
              Input = new global::StreamExecutor.Dnn.TensorDescriptorProto();
            }
            input.ReadMessage(Input);
            break;
          }
          case 26: {
            if (filter_ == null) {
              Filter = new global::StreamExecutor.Dnn.TensorDescriptorProto();
            }
            input.ReadMessage(Filter);
            break;
          }
          case 34: {
            if (output_ == null) {
              Output = new global::StreamExecutor.Dnn.TensorDescriptorProto();
            }
            input.ReadMessage(Output);
            break;
          }
          case 42: {
            if (convDesc_ == null) {
              ConvDesc = new global::StreamExecutor.Dnn.ConvolutionDescriptorProto();
            }
            input.ReadMessage(ConvDesc);
            break;
          }
          case 49: {
            ConvScale = input.ReadDouble();
            break;
          }
          case 57: {
            SideValueScale = input.ReadDouble();
            break;
          }
          case 64: {
            Activation = (global::StreamExecutor.Dnn.ActivationMode) input.ReadEnum();
            break;
          }
          case 72: {
            InputAddress = input.ReadInt64();
            break;
          }
          case 80: {
            FilterAddress = input.ReadInt64();
            break;
          }
          case 88: {
            OutputAddress = input.ReadInt64();
            break;
          }
          case 96: {
            BiasAddress = input.ReadInt64();
            break;
          }
          case 104: {
            SideInputAddress = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
