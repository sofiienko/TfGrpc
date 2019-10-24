// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tensorflow/compiler/xla/service/hlo_execution_profile_data.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Xla {

  /// <summary>Holder for reflection information generated from tensorflow/compiler/xla/service/hlo_execution_profile_data.proto</summary>
  public static partial class HloExecutionProfileDataReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/compiler/xla/service/hlo_execution_profile_data.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HloExecutionProfileDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkB0ZW5zb3JmbG93L2NvbXBpbGVyL3hsYS9zZXJ2aWNlL2hsb19leGVjdXRp",
            "b25fcHJvZmlsZV9kYXRhLnByb3RvEgN4bGEaPnRlbnNvcmZsb3cvY29tcGls",
            "ZXIveGxhL3NlcnZpY2UvaGxvX3Byb2ZpbGVfcHJpbnRlcl9kYXRhLnByb3Rv",
            "ImUKF0hsb0V4ZWN1dGlvblByb2ZpbGVEYXRhEjAKDHByaW50ZXJfZGF0YRgB",
            "IAEoCzIaLnhsYS5IbG9Qcm9maWxlUHJpbnRlckRhdGESGAoQcHJvZmlsZV9j",
            "b3VudGVycxgCIAMoA0ID+AEBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Xla.HloProfilePrinterDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Xla.HloExecutionProfileData), global::Xla.HloExecutionProfileData.Parser, new[]{ "PrinterData", "ProfileCounters" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HloExecutionProfileData : pb::IMessage<HloExecutionProfileData> {
    private static readonly pb::MessageParser<HloExecutionProfileData> _parser = new pb::MessageParser<HloExecutionProfileData>(() => new HloExecutionProfileData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HloExecutionProfileData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Xla.HloExecutionProfileDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HloExecutionProfileData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HloExecutionProfileData(HloExecutionProfileData other) : this() {
      printerData_ = other.printerData_ != null ? other.printerData_.Clone() : null;
      profileCounters_ = other.profileCounters_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HloExecutionProfileData Clone() {
      return new HloExecutionProfileData(this);
    }

    /// <summary>Field number for the "printer_data" field.</summary>
    public const int PrinterDataFieldNumber = 1;
    private global::Xla.HloProfilePrinterData printerData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Xla.HloProfilePrinterData PrinterData {
      get { return printerData_; }
      set {
        printerData_ = value;
      }
    }

    /// <summary>Field number for the "profile_counters" field.</summary>
    public const int ProfileCountersFieldNumber = 2;
    private static readonly pb::FieldCodec<long> _repeated_profileCounters_codec
        = pb::FieldCodec.ForInt64(18);
    private readonly pbc::RepeatedField<long> profileCounters_ = new pbc::RepeatedField<long>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<long> ProfileCounters {
      get { return profileCounters_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HloExecutionProfileData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HloExecutionProfileData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PrinterData, other.PrinterData)) return false;
      if(!profileCounters_.Equals(other.profileCounters_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (printerData_ != null) hash ^= PrinterData.GetHashCode();
      hash ^= profileCounters_.GetHashCode();
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
      if (printerData_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PrinterData);
      }
      profileCounters_.WriteTo(output, _repeated_profileCounters_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (printerData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PrinterData);
      }
      size += profileCounters_.CalculateSize(_repeated_profileCounters_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HloExecutionProfileData other) {
      if (other == null) {
        return;
      }
      if (other.printerData_ != null) {
        if (printerData_ == null) {
          PrinterData = new global::Xla.HloProfilePrinterData();
        }
        PrinterData.MergeFrom(other.PrinterData);
      }
      profileCounters_.Add(other.profileCounters_);
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
            if (printerData_ == null) {
              PrinterData = new global::Xla.HloProfilePrinterData();
            }
            input.ReadMessage(PrinterData);
            break;
          }
          case 18:
          case 16: {
            profileCounters_.AddEntriesFrom(input, _repeated_profileCounters_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
