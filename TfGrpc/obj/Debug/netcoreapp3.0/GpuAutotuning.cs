// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tensorflow/compiler/xla/service/gpu/gpu_autotuning.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Xla.Gpu {

  /// <summary>Holder for reflection information generated from tensorflow/compiler/xla/service/gpu/gpu_autotuning.proto</summary>
  public static partial class GpuAutotuningReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/compiler/xla/service/gpu/gpu_autotuning.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GpuAutotuningReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjh0ZW5zb3JmbG93L2NvbXBpbGVyL3hsYS9zZXJ2aWNlL2dwdS9ncHVfYXV0",
            "b3R1bmluZy5wcm90bxIHeGxhLmdwdRopdGVuc29yZmxvdy9jb21waWxlci94",
            "bGEvc2VydmljZS9obG8ucHJvdG8aJnRlbnNvcmZsb3cvY29tcGlsZXIveGxh",
            "L3hsYV9kYXRhLnByb3RvGil0ZW5zb3JmbG93L2NvcmUvcHJvdG9idWYvYXV0",
            "b3R1bmluZy5wcm90byKfAQoSQ29udkluc3RydWN0aW9uTG9nEi0KC2luc3Ry",
            "dWN0aW9uGAEgASgLMhgueGxhLkhsb0luc3RydWN0aW9uUHJvdG8SJwoOb3Bl",
            "cmFuZF9zaGFwZXMYAiADKAsyDy54bGEuU2hhcGVQcm90bxIWCg5yZXN1bHRf",
            "YWRkcmVzcxgDIAEoBBIZChFvcGVyYW5kX2FkZHJlc3NlcxgEIAMoBCI2ChRC",
            "bGFja2xpc3RlZEFsZ29yaXRobRIKCgJpZBgBIAEoAxISCgp0ZW5zb3Jfb3Bz",
            "GAIgASgIIsYBChdBbGdvcml0aG1CbGFja2xpc3RFbnRyeRILCgNobG8YASAB",
            "KAkSKQoCY2MYAiABKAsyHS50ZW5zb3JmbG93LkNvbXB1dGVDYXBhYmlsaXR5",
            "Ei8KDWN1ZG5uX3ZlcnNpb24YAyABKAsyGC50ZW5zb3JmbG93LkN1ZG5uVmVy",
            "c2lvbhIUCgxibGFzX3ZlcnNpb24YBSABKAkSLAoFYWxnb3MYBCADKAsyHS54",
            "bGEuZ3B1LkJsYWNrbGlzdGVkQWxnb3JpdGhtIkcKEkFsZ29yaXRobUJsYWNr",
            "bGlzdBIxCgdlbnRyaWVzGAEgAygLMiAueGxhLmdwdS5BbGdvcml0aG1CbGFj",
            "a2xpc3RFbnRyeWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Xla.HloReflection.Descriptor, global::Xla.XlaDataReflection.Descriptor, global::Tensorflow.AutotuningReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Xla.Gpu.ConvInstructionLog), global::Xla.Gpu.ConvInstructionLog.Parser, new[]{ "Instruction", "OperandShapes", "ResultAddress", "OperandAddresses" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Xla.Gpu.BlacklistedAlgorithm), global::Xla.Gpu.BlacklistedAlgorithm.Parser, new[]{ "Id", "TensorOps" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Xla.Gpu.AlgorithmBlacklistEntry), global::Xla.Gpu.AlgorithmBlacklistEntry.Parser, new[]{ "Hlo", "Cc", "CudnnVersion", "BlasVersion", "Algos" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Xla.Gpu.AlgorithmBlacklist), global::Xla.Gpu.AlgorithmBlacklist.Parser, new[]{ "Entries" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ConvInstructionLog : pb::IMessage<ConvInstructionLog> {
    private static readonly pb::MessageParser<ConvInstructionLog> _parser = new pb::MessageParser<ConvInstructionLog>(() => new ConvInstructionLog());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ConvInstructionLog> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Xla.Gpu.GpuAutotuningReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConvInstructionLog() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConvInstructionLog(ConvInstructionLog other) : this() {
      instruction_ = other.instruction_ != null ? other.instruction_.Clone() : null;
      operandShapes_ = other.operandShapes_.Clone();
      resultAddress_ = other.resultAddress_;
      operandAddresses_ = other.operandAddresses_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConvInstructionLog Clone() {
      return new ConvInstructionLog(this);
    }

    /// <summary>Field number for the "instruction" field.</summary>
    public const int InstructionFieldNumber = 1;
    private global::Xla.HloInstructionProto instruction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Xla.HloInstructionProto Instruction {
      get { return instruction_; }
      set {
        instruction_ = value;
      }
    }

    /// <summary>Field number for the "operand_shapes" field.</summary>
    public const int OperandShapesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Xla.ShapeProto> _repeated_operandShapes_codec
        = pb::FieldCodec.ForMessage(18, global::Xla.ShapeProto.Parser);
    private readonly pbc::RepeatedField<global::Xla.ShapeProto> operandShapes_ = new pbc::RepeatedField<global::Xla.ShapeProto>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Xla.ShapeProto> OperandShapes {
      get { return operandShapes_; }
    }

    /// <summary>Field number for the "result_address" field.</summary>
    public const int ResultAddressFieldNumber = 3;
    private ulong resultAddress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong ResultAddress {
      get { return resultAddress_; }
      set {
        resultAddress_ = value;
      }
    }

    /// <summary>Field number for the "operand_addresses" field.</summary>
    public const int OperandAddressesFieldNumber = 4;
    private static readonly pb::FieldCodec<ulong> _repeated_operandAddresses_codec
        = pb::FieldCodec.ForUInt64(34);
    private readonly pbc::RepeatedField<ulong> operandAddresses_ = new pbc::RepeatedField<ulong>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<ulong> OperandAddresses {
      get { return operandAddresses_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ConvInstructionLog);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ConvInstructionLog other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Instruction, other.Instruction)) return false;
      if(!operandShapes_.Equals(other.operandShapes_)) return false;
      if (ResultAddress != other.ResultAddress) return false;
      if(!operandAddresses_.Equals(other.operandAddresses_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (instruction_ != null) hash ^= Instruction.GetHashCode();
      hash ^= operandShapes_.GetHashCode();
      if (ResultAddress != 0UL) hash ^= ResultAddress.GetHashCode();
      hash ^= operandAddresses_.GetHashCode();
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
      if (instruction_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Instruction);
      }
      operandShapes_.WriteTo(output, _repeated_operandShapes_codec);
      if (ResultAddress != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(ResultAddress);
      }
      operandAddresses_.WriteTo(output, _repeated_operandAddresses_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (instruction_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Instruction);
      }
      size += operandShapes_.CalculateSize(_repeated_operandShapes_codec);
      if (ResultAddress != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ResultAddress);
      }
      size += operandAddresses_.CalculateSize(_repeated_operandAddresses_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ConvInstructionLog other) {
      if (other == null) {
        return;
      }
      if (other.instruction_ != null) {
        if (instruction_ == null) {
          Instruction = new global::Xla.HloInstructionProto();
        }
        Instruction.MergeFrom(other.Instruction);
      }
      operandShapes_.Add(other.operandShapes_);
      if (other.ResultAddress != 0UL) {
        ResultAddress = other.ResultAddress;
      }
      operandAddresses_.Add(other.operandAddresses_);
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
            if (instruction_ == null) {
              Instruction = new global::Xla.HloInstructionProto();
            }
            input.ReadMessage(Instruction);
            break;
          }
          case 18: {
            operandShapes_.AddEntriesFrom(input, _repeated_operandShapes_codec);
            break;
          }
          case 24: {
            ResultAddress = input.ReadUInt64();
            break;
          }
          case 34:
          case 32: {
            operandAddresses_.AddEntriesFrom(input, _repeated_operandAddresses_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class BlacklistedAlgorithm : pb::IMessage<BlacklistedAlgorithm> {
    private static readonly pb::MessageParser<BlacklistedAlgorithm> _parser = new pb::MessageParser<BlacklistedAlgorithm>(() => new BlacklistedAlgorithm());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BlacklistedAlgorithm> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Xla.Gpu.GpuAutotuningReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BlacklistedAlgorithm() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BlacklistedAlgorithm(BlacklistedAlgorithm other) : this() {
      id_ = other.id_;
      tensorOps_ = other.tensorOps_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BlacklistedAlgorithm Clone() {
      return new BlacklistedAlgorithm(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private long id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "tensor_ops" field.</summary>
    public const int TensorOpsFieldNumber = 2;
    private bool tensorOps_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool TensorOps {
      get { return tensorOps_; }
      set {
        tensorOps_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BlacklistedAlgorithm);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BlacklistedAlgorithm other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (TensorOps != other.TensorOps) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0L) hash ^= Id.GetHashCode();
      if (TensorOps != false) hash ^= TensorOps.GetHashCode();
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
      if (Id != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Id);
      }
      if (TensorOps != false) {
        output.WriteRawTag(16);
        output.WriteBool(TensorOps);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (TensorOps != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BlacklistedAlgorithm other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      if (other.TensorOps != false) {
        TensorOps = other.TensorOps;
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
            Id = input.ReadInt64();
            break;
          }
          case 16: {
            TensorOps = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class AlgorithmBlacklistEntry : pb::IMessage<AlgorithmBlacklistEntry> {
    private static readonly pb::MessageParser<AlgorithmBlacklistEntry> _parser = new pb::MessageParser<AlgorithmBlacklistEntry>(() => new AlgorithmBlacklistEntry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AlgorithmBlacklistEntry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Xla.Gpu.GpuAutotuningReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AlgorithmBlacklistEntry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AlgorithmBlacklistEntry(AlgorithmBlacklistEntry other) : this() {
      hlo_ = other.hlo_;
      cc_ = other.cc_ != null ? other.cc_.Clone() : null;
      cudnnVersion_ = other.cudnnVersion_ != null ? other.cudnnVersion_.Clone() : null;
      blasVersion_ = other.blasVersion_;
      algos_ = other.algos_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AlgorithmBlacklistEntry Clone() {
      return new AlgorithmBlacklistEntry(this);
    }

    /// <summary>Field number for the "hlo" field.</summary>
    public const int HloFieldNumber = 1;
    private string hlo_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Hlo {
      get { return hlo_; }
      set {
        hlo_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cc" field.</summary>
    public const int CcFieldNumber = 2;
    private global::Tensorflow.ComputeCapability cc_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.ComputeCapability Cc {
      get { return cc_; }
      set {
        cc_ = value;
      }
    }

    /// <summary>Field number for the "cudnn_version" field.</summary>
    public const int CudnnVersionFieldNumber = 3;
    private global::Tensorflow.CudnnVersion cudnnVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.CudnnVersion CudnnVersion {
      get { return cudnnVersion_; }
      set {
        cudnnVersion_ = value;
      }
    }

    /// <summary>Field number for the "blas_version" field.</summary>
    public const int BlasVersionFieldNumber = 5;
    private string blasVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BlasVersion {
      get { return blasVersion_; }
      set {
        blasVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "algos" field.</summary>
    public const int AlgosFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Xla.Gpu.BlacklistedAlgorithm> _repeated_algos_codec
        = pb::FieldCodec.ForMessage(34, global::Xla.Gpu.BlacklistedAlgorithm.Parser);
    private readonly pbc::RepeatedField<global::Xla.Gpu.BlacklistedAlgorithm> algos_ = new pbc::RepeatedField<global::Xla.Gpu.BlacklistedAlgorithm>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Xla.Gpu.BlacklistedAlgorithm> Algos {
      get { return algos_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AlgorithmBlacklistEntry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AlgorithmBlacklistEntry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Hlo != other.Hlo) return false;
      if (!object.Equals(Cc, other.Cc)) return false;
      if (!object.Equals(CudnnVersion, other.CudnnVersion)) return false;
      if (BlasVersion != other.BlasVersion) return false;
      if(!algos_.Equals(other.algos_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Hlo.Length != 0) hash ^= Hlo.GetHashCode();
      if (cc_ != null) hash ^= Cc.GetHashCode();
      if (cudnnVersion_ != null) hash ^= CudnnVersion.GetHashCode();
      if (BlasVersion.Length != 0) hash ^= BlasVersion.GetHashCode();
      hash ^= algos_.GetHashCode();
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
      if (Hlo.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Hlo);
      }
      if (cc_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Cc);
      }
      if (cudnnVersion_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CudnnVersion);
      }
      algos_.WriteTo(output, _repeated_algos_codec);
      if (BlasVersion.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(BlasVersion);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Hlo.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Hlo);
      }
      if (cc_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Cc);
      }
      if (cudnnVersion_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CudnnVersion);
      }
      if (BlasVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BlasVersion);
      }
      size += algos_.CalculateSize(_repeated_algos_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AlgorithmBlacklistEntry other) {
      if (other == null) {
        return;
      }
      if (other.Hlo.Length != 0) {
        Hlo = other.Hlo;
      }
      if (other.cc_ != null) {
        if (cc_ == null) {
          Cc = new global::Tensorflow.ComputeCapability();
        }
        Cc.MergeFrom(other.Cc);
      }
      if (other.cudnnVersion_ != null) {
        if (cudnnVersion_ == null) {
          CudnnVersion = new global::Tensorflow.CudnnVersion();
        }
        CudnnVersion.MergeFrom(other.CudnnVersion);
      }
      if (other.BlasVersion.Length != 0) {
        BlasVersion = other.BlasVersion;
      }
      algos_.Add(other.algos_);
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
            Hlo = input.ReadString();
            break;
          }
          case 18: {
            if (cc_ == null) {
              Cc = new global::Tensorflow.ComputeCapability();
            }
            input.ReadMessage(Cc);
            break;
          }
          case 26: {
            if (cudnnVersion_ == null) {
              CudnnVersion = new global::Tensorflow.CudnnVersion();
            }
            input.ReadMessage(CudnnVersion);
            break;
          }
          case 34: {
            algos_.AddEntriesFrom(input, _repeated_algos_codec);
            break;
          }
          case 42: {
            BlasVersion = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class AlgorithmBlacklist : pb::IMessage<AlgorithmBlacklist> {
    private static readonly pb::MessageParser<AlgorithmBlacklist> _parser = new pb::MessageParser<AlgorithmBlacklist>(() => new AlgorithmBlacklist());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AlgorithmBlacklist> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Xla.Gpu.GpuAutotuningReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AlgorithmBlacklist() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AlgorithmBlacklist(AlgorithmBlacklist other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AlgorithmBlacklist Clone() {
      return new AlgorithmBlacklist(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Xla.Gpu.AlgorithmBlacklistEntry> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::Xla.Gpu.AlgorithmBlacklistEntry.Parser);
    private readonly pbc::RepeatedField<global::Xla.Gpu.AlgorithmBlacklistEntry> entries_ = new pbc::RepeatedField<global::Xla.Gpu.AlgorithmBlacklistEntry>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Xla.Gpu.AlgorithmBlacklistEntry> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AlgorithmBlacklist);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AlgorithmBlacklist other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!entries_.Equals(other.entries_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= entries_.GetHashCode();
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
      entries_.WriteTo(output, _repeated_entries_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += entries_.CalculateSize(_repeated_entries_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AlgorithmBlacklist other) {
      if (other == null) {
        return;
      }
      entries_.Add(other.entries_);
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
            entries_.AddEntriesFrom(input, _repeated_entries_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code