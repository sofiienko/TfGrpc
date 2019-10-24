// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tensorflow/core/protobuf/tpu/compilation_result.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow.Tpu {

  /// <summary>Holder for reflection information generated from tensorflow/core/protobuf/tpu/compilation_result.proto</summary>
  public static partial class CompilationResultReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/core/protobuf/tpu/compilation_result.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompilationResultReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjV0ZW5zb3JmbG93L2NvcmUvcHJvdG9idWYvdHB1L2NvbXBpbGF0aW9uX3Jl",
            "c3VsdC5wcm90bxIOdGVuc29yZmxvdy50cHUaKXRlbnNvcmZsb3cvY29tcGls",
            "ZXIveGxhL3NlcnZpY2UvaGxvLnByb3RvGip0ZW5zb3JmbG93L2NvcmUvcHJv",
            "dG9idWYvZXJyb3JfY29kZXMucHJvdG8ihgEKFkNvbXBpbGF0aW9uUmVzdWx0",
            "UHJvdG8SKwoLc3RhdHVzX2NvZGUYASABKA4yFi50ZW5zb3JmbG93LmVycm9y",
            "LkNvZGUSHAoUc3RhdHVzX2Vycm9yX21lc3NhZ2UYAiABKAkSIQoKaGxvX3By",
            "b3RvcxgDIAMoCzINLnhsYS5IbG9Qcm90b0ID+AEBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Xla.HloReflection.Descriptor, global::Tensorflow.Error.ErrorCodesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Tpu.CompilationResultProto), global::Tensorflow.Tpu.CompilationResultProto.Parser, new[]{ "StatusCode", "StatusErrorMessage", "HloProtos" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Describes the result of a TPU compilation.
  /// </summary>
  public sealed partial class CompilationResultProto : pb::IMessage<CompilationResultProto> {
    private static readonly pb::MessageParser<CompilationResultProto> _parser = new pb::MessageParser<CompilationResultProto>(() => new CompilationResultProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompilationResultProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Tpu.CompilationResultReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompilationResultProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompilationResultProto(CompilationResultProto other) : this() {
      statusCode_ = other.statusCode_;
      statusErrorMessage_ = other.statusErrorMessage_;
      hloProtos_ = other.hloProtos_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompilationResultProto Clone() {
      return new CompilationResultProto(this);
    }

    /// <summary>Field number for the "status_code" field.</summary>
    public const int StatusCodeFieldNumber = 1;
    private global::Tensorflow.Error.Code statusCode_ = 0;
    /// <summary>
    /// The error message, if any, returned during compilation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.Error.Code StatusCode {
      get { return statusCode_; }
      set {
        statusCode_ = value;
      }
    }

    /// <summary>Field number for the "status_error_message" field.</summary>
    public const int StatusErrorMessageFieldNumber = 2;
    private string statusErrorMessage_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string StatusErrorMessage {
      get { return statusErrorMessage_; }
      set {
        statusErrorMessage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hlo_protos" field.</summary>
    public const int HloProtosFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Xla.HloProto> _repeated_hloProtos_codec
        = pb::FieldCodec.ForMessage(26, global::Xla.HloProto.Parser);
    private readonly pbc::RepeatedField<global::Xla.HloProto> hloProtos_ = new pbc::RepeatedField<global::Xla.HloProto>();
    /// <summary>
    /// HLO proto.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Xla.HloProto> HloProtos {
      get { return hloProtos_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompilationResultProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompilationResultProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StatusCode != other.StatusCode) return false;
      if (StatusErrorMessage != other.StatusErrorMessage) return false;
      if(!hloProtos_.Equals(other.hloProtos_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (StatusCode != 0) hash ^= StatusCode.GetHashCode();
      if (StatusErrorMessage.Length != 0) hash ^= StatusErrorMessage.GetHashCode();
      hash ^= hloProtos_.GetHashCode();
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
      if (StatusCode != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) StatusCode);
      }
      if (StatusErrorMessage.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(StatusErrorMessage);
      }
      hloProtos_.WriteTo(output, _repeated_hloProtos_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (StatusCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) StatusCode);
      }
      if (StatusErrorMessage.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StatusErrorMessage);
      }
      size += hloProtos_.CalculateSize(_repeated_hloProtos_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompilationResultProto other) {
      if (other == null) {
        return;
      }
      if (other.StatusCode != 0) {
        StatusCode = other.StatusCode;
      }
      if (other.StatusErrorMessage.Length != 0) {
        StatusErrorMessage = other.StatusErrorMessage;
      }
      hloProtos_.Add(other.hloProtos_);
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
            StatusCode = (global::Tensorflow.Error.Code) input.ReadEnum();
            break;
          }
          case 18: {
            StatusErrorMessage = input.ReadString();
            break;
          }
          case 26: {
            hloProtos_.AddEntriesFrom(input, _repeated_hloProtos_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code