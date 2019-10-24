// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tensorflow/compiler/xla/service/hlo_profile_printer_data.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Xla {

  /// <summary>Holder for reflection information generated from tensorflow/compiler/xla/service/hlo_profile_printer_data.proto</summary>
  public static partial class HloProfilePrinterDataReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/compiler/xla/service/hlo_profile_printer_data.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HloProfilePrinterDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj50ZW5zb3JmbG93L2NvbXBpbGVyL3hsYS9zZXJ2aWNlL2hsb19wcm9maWxl",
            "X3ByaW50ZXJfZGF0YS5wcm90bxIDeGxhIuUEChVIbG9Qcm9maWxlUHJpbnRl",
            "ckRhdGESSAoRY29tcHV0YXRpb25faW5mb3MYASADKAsyLS54bGEuSGxvUHJv",
            "ZmlsZVByaW50ZXJEYXRhLkhsb0NvbXB1dGF0aW9uSW5mbxIdChVwcm9maWxl",
            "X2NvdW50ZXJzX3NpemUYAiABKAMSQwoNZXh0cmFfbWV0cmljcxgDIAMoCzIs",
            "LnhsYS5IbG9Qcm9maWxlUHJpbnRlckRhdGEuRXh0cmFNZXRyaWNzRW50cnkS",
            "GQoRZW50cnlfY29tcHV0YXRpb24YBCABKAkaxwEKEkhsb0luc3RydWN0aW9u",
            "SW5mbxIRCglsb25nX25hbWUYASABKAkSEgoKc2hvcnRfbmFtZRgCIAEoCRIQ",
            "CghjYXRlZ29yeRgDIAEoCRISCgpmbG9wX2NvdW50GAQgASgCEhwKFHRyYW5z",
            "Y2VuZGVudGFsX2NvdW50GAUgASgCEhYKDmJ5dGVzX2FjY2Vzc2VkGAYgASgC",
            "EhcKD29wdGltYWxfc2Vjb25kcxgHIAEoAhIVCg1wcm9maWxlX2luZGV4GAgg",
            "ASgDGoMBChJIbG9Db21wdXRhdGlvbkluZm8SDAoEbmFtZRgBIAEoCRIVCg1w",
            "cm9maWxlX2luZGV4GAIgASgDEkgKEWluc3RydWN0aW9uX2luZm9zGAMgAygL",
            "Mi0ueGxhLkhsb1Byb2ZpbGVQcmludGVyRGF0YS5IbG9JbnN0cnVjdGlvbklu",
            "Zm8aMwoRRXh0cmFNZXRyaWNzRW50cnkSCwoDa2V5GAEgASgJEg0KBXZhbHVl",
            "GAIgASgDOgI4AUID+AEBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Xla.HloProfilePrinterData), global::Xla.HloProfilePrinterData.Parser, new[]{ "ComputationInfos", "ProfileCountersSize", "ExtraMetrics", "EntryComputation" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Xla.HloProfilePrinterData.Types.HloInstructionInfo), global::Xla.HloProfilePrinterData.Types.HloInstructionInfo.Parser, new[]{ "LongName", "ShortName", "Category", "FlopCount", "TranscendentalCount", "BytesAccessed", "OptimalSeconds", "ProfileIndex" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Xla.HloProfilePrinterData.Types.HloComputationInfo), global::Xla.HloProfilePrinterData.Types.HloComputationInfo.Parser, new[]{ "Name", "ProfileIndex", "InstructionInfos" }, null, null, null),
            null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Describes how to pretty-print a profile counter array gathered for a specific
  /// HloModule.
  /// </summary>
  public sealed partial class HloProfilePrinterData : pb::IMessage<HloProfilePrinterData> {
    private static readonly pb::MessageParser<HloProfilePrinterData> _parser = new pb::MessageParser<HloProfilePrinterData>(() => new HloProfilePrinterData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HloProfilePrinterData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Xla.HloProfilePrinterDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HloProfilePrinterData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HloProfilePrinterData(HloProfilePrinterData other) : this() {
      computationInfos_ = other.computationInfos_.Clone();
      profileCountersSize_ = other.profileCountersSize_;
      extraMetrics_ = other.extraMetrics_.Clone();
      entryComputation_ = other.entryComputation_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HloProfilePrinterData Clone() {
      return new HloProfilePrinterData(this);
    }

    /// <summary>Field number for the "computation_infos" field.</summary>
    public const int ComputationInfosFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Xla.HloProfilePrinterData.Types.HloComputationInfo> _repeated_computationInfos_codec
        = pb::FieldCodec.ForMessage(10, global::Xla.HloProfilePrinterData.Types.HloComputationInfo.Parser);
    private readonly pbc::RepeatedField<global::Xla.HloProfilePrinterData.Types.HloComputationInfo> computationInfos_ = new pbc::RepeatedField<global::Xla.HloProfilePrinterData.Types.HloComputationInfo>();
    /// <summary>
    /// HloComputationInfos for every HloComputation in the HloModule.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Xla.HloProfilePrinterData.Types.HloComputationInfo> ComputationInfos {
      get { return computationInfos_; }
    }

    /// <summary>Field number for the "profile_counters_size" field.</summary>
    public const int ProfileCountersSizeFieldNumber = 2;
    private long profileCountersSize_;
    /// <summary>
    /// The size of the profile counters array we will pretty-print.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ProfileCountersSize {
      get { return profileCountersSize_; }
      set {
        profileCountersSize_ = value;
      }
    }

    /// <summary>Field number for the "extra_metrics" field.</summary>
    public const int ExtraMetricsFieldNumber = 3;
    private static readonly pbc::MapField<string, long>.Codec _map_extraMetrics_codec
        = new pbc::MapField<string, long>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForInt64(16), 26);
    private readonly pbc::MapField<string, long> extraMetrics_ = new pbc::MapField<string, long>();
    /// <summary>
    /// Maps extra metric name to the index into the profile counters array.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, long> ExtraMetrics {
      get { return extraMetrics_; }
    }

    /// <summary>Field number for the "entry_computation" field.</summary>
    public const int EntryComputationFieldNumber = 4;
    private string entryComputation_ = "";
    /// <summary>
    /// Name of the entry computation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EntryComputation {
      get { return entryComputation_; }
      set {
        entryComputation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HloProfilePrinterData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HloProfilePrinterData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!computationInfos_.Equals(other.computationInfos_)) return false;
      if (ProfileCountersSize != other.ProfileCountersSize) return false;
      if (!ExtraMetrics.Equals(other.ExtraMetrics)) return false;
      if (EntryComputation != other.EntryComputation) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= computationInfos_.GetHashCode();
      if (ProfileCountersSize != 0L) hash ^= ProfileCountersSize.GetHashCode();
      hash ^= ExtraMetrics.GetHashCode();
      if (EntryComputation.Length != 0) hash ^= EntryComputation.GetHashCode();
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
      computationInfos_.WriteTo(output, _repeated_computationInfos_codec);
      if (ProfileCountersSize != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(ProfileCountersSize);
      }
      extraMetrics_.WriteTo(output, _map_extraMetrics_codec);
      if (EntryComputation.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(EntryComputation);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += computationInfos_.CalculateSize(_repeated_computationInfos_codec);
      if (ProfileCountersSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ProfileCountersSize);
      }
      size += extraMetrics_.CalculateSize(_map_extraMetrics_codec);
      if (EntryComputation.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EntryComputation);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HloProfilePrinterData other) {
      if (other == null) {
        return;
      }
      computationInfos_.Add(other.computationInfos_);
      if (other.ProfileCountersSize != 0L) {
        ProfileCountersSize = other.ProfileCountersSize;
      }
      extraMetrics_.Add(other.extraMetrics_);
      if (other.EntryComputation.Length != 0) {
        EntryComputation = other.EntryComputation;
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
            computationInfos_.AddEntriesFrom(input, _repeated_computationInfos_codec);
            break;
          }
          case 16: {
            ProfileCountersSize = input.ReadInt64();
            break;
          }
          case 26: {
            extraMetrics_.AddEntriesFrom(input, _map_extraMetrics_codec);
            break;
          }
          case 34: {
            EntryComputation = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the HloProfilePrinterData message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Pretty-printer information about an HloInstruction.
      /// </summary>
      public sealed partial class HloInstructionInfo : pb::IMessage<HloInstructionInfo> {
        private static readonly pb::MessageParser<HloInstructionInfo> _parser = new pb::MessageParser<HloInstructionInfo>(() => new HloInstructionInfo());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<HloInstructionInfo> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Xla.HloProfilePrinterData.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public HloInstructionInfo() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public HloInstructionInfo(HloInstructionInfo other) : this() {
          longName_ = other.longName_;
          shortName_ = other.shortName_;
          category_ = other.category_;
          flopCount_ = other.flopCount_;
          transcendentalCount_ = other.transcendentalCount_;
          bytesAccessed_ = other.bytesAccessed_;
          optimalSeconds_ = other.optimalSeconds_;
          profileIndex_ = other.profileIndex_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public HloInstructionInfo Clone() {
          return new HloInstructionInfo(this);
        }

        /// <summary>Field number for the "long_name" field.</summary>
        public const int LongNameFieldNumber = 1;
        private string longName_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string LongName {
          get { return longName_; }
          set {
            longName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "short_name" field.</summary>
        public const int ShortNameFieldNumber = 2;
        private string shortName_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string ShortName {
          get { return shortName_; }
          set {
            shortName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "category" field.</summary>
        public const int CategoryFieldNumber = 3;
        private string category_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Category {
          get { return category_; }
          set {
            category_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "flop_count" field.</summary>
        public const int FlopCountFieldNumber = 4;
        private float flopCount_;
        /// <summary>
        /// Metrics computed by HloCostAnalysis.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public float FlopCount {
          get { return flopCount_; }
          set {
            flopCount_ = value;
          }
        }

        /// <summary>Field number for the "transcendental_count" field.</summary>
        public const int TranscendentalCountFieldNumber = 5;
        private float transcendentalCount_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public float TranscendentalCount {
          get { return transcendentalCount_; }
          set {
            transcendentalCount_ = value;
          }
        }

        /// <summary>Field number for the "bytes_accessed" field.</summary>
        public const int BytesAccessedFieldNumber = 6;
        private float bytesAccessed_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public float BytesAccessed {
          get { return bytesAccessed_; }
          set {
            bytesAccessed_ = value;
          }
        }

        /// <summary>Field number for the "optimal_seconds" field.</summary>
        public const int OptimalSecondsFieldNumber = 7;
        private float optimalSeconds_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public float OptimalSeconds {
          get { return optimalSeconds_; }
          set {
            optimalSeconds_ = value;
          }
        }

        /// <summary>Field number for the "profile_index" field.</summary>
        public const int ProfileIndexFieldNumber = 8;
        private long profileIndex_;
        /// <summary>
        /// The index into the profile counters array for the HloInstruction
        /// corresponding to this HloInstructionInfo.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long ProfileIndex {
          get { return profileIndex_; }
          set {
            profileIndex_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as HloInstructionInfo);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(HloInstructionInfo other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (LongName != other.LongName) return false;
          if (ShortName != other.ShortName) return false;
          if (Category != other.Category) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FlopCount, other.FlopCount)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TranscendentalCount, other.TranscendentalCount)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BytesAccessed, other.BytesAccessed)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(OptimalSeconds, other.OptimalSeconds)) return false;
          if (ProfileIndex != other.ProfileIndex) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (LongName.Length != 0) hash ^= LongName.GetHashCode();
          if (ShortName.Length != 0) hash ^= ShortName.GetHashCode();
          if (Category.Length != 0) hash ^= Category.GetHashCode();
          if (FlopCount != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FlopCount);
          if (TranscendentalCount != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TranscendentalCount);
          if (BytesAccessed != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BytesAccessed);
          if (OptimalSeconds != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(OptimalSeconds);
          if (ProfileIndex != 0L) hash ^= ProfileIndex.GetHashCode();
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
          if (LongName.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(LongName);
          }
          if (ShortName.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(ShortName);
          }
          if (Category.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(Category);
          }
          if (FlopCount != 0F) {
            output.WriteRawTag(37);
            output.WriteFloat(FlopCount);
          }
          if (TranscendentalCount != 0F) {
            output.WriteRawTag(45);
            output.WriteFloat(TranscendentalCount);
          }
          if (BytesAccessed != 0F) {
            output.WriteRawTag(53);
            output.WriteFloat(BytesAccessed);
          }
          if (OptimalSeconds != 0F) {
            output.WriteRawTag(61);
            output.WriteFloat(OptimalSeconds);
          }
          if (ProfileIndex != 0L) {
            output.WriteRawTag(64);
            output.WriteInt64(ProfileIndex);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (LongName.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(LongName);
          }
          if (ShortName.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(ShortName);
          }
          if (Category.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Category);
          }
          if (FlopCount != 0F) {
            size += 1 + 4;
          }
          if (TranscendentalCount != 0F) {
            size += 1 + 4;
          }
          if (BytesAccessed != 0F) {
            size += 1 + 4;
          }
          if (OptimalSeconds != 0F) {
            size += 1 + 4;
          }
          if (ProfileIndex != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(ProfileIndex);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(HloInstructionInfo other) {
          if (other == null) {
            return;
          }
          if (other.LongName.Length != 0) {
            LongName = other.LongName;
          }
          if (other.ShortName.Length != 0) {
            ShortName = other.ShortName;
          }
          if (other.Category.Length != 0) {
            Category = other.Category;
          }
          if (other.FlopCount != 0F) {
            FlopCount = other.FlopCount;
          }
          if (other.TranscendentalCount != 0F) {
            TranscendentalCount = other.TranscendentalCount;
          }
          if (other.BytesAccessed != 0F) {
            BytesAccessed = other.BytesAccessed;
          }
          if (other.OptimalSeconds != 0F) {
            OptimalSeconds = other.OptimalSeconds;
          }
          if (other.ProfileIndex != 0L) {
            ProfileIndex = other.ProfileIndex;
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
                LongName = input.ReadString();
                break;
              }
              case 18: {
                ShortName = input.ReadString();
                break;
              }
              case 26: {
                Category = input.ReadString();
                break;
              }
              case 37: {
                FlopCount = input.ReadFloat();
                break;
              }
              case 45: {
                TranscendentalCount = input.ReadFloat();
                break;
              }
              case 53: {
                BytesAccessed = input.ReadFloat();
                break;
              }
              case 61: {
                OptimalSeconds = input.ReadFloat();
                break;
              }
              case 64: {
                ProfileIndex = input.ReadInt64();
                break;
              }
            }
          }
        }

      }

      /// <summary>
      /// Pretty-printer information about an HloComputation.
      /// </summary>
      public sealed partial class HloComputationInfo : pb::IMessage<HloComputationInfo> {
        private static readonly pb::MessageParser<HloComputationInfo> _parser = new pb::MessageParser<HloComputationInfo>(() => new HloComputationInfo());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<HloComputationInfo> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Xla.HloProfilePrinterData.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public HloComputationInfo() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public HloComputationInfo(HloComputationInfo other) : this() {
          name_ = other.name_;
          profileIndex_ = other.profileIndex_;
          instructionInfos_ = other.instructionInfos_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public HloComputationInfo Clone() {
          return new HloComputationInfo(this);
        }

        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 1;
        private string name_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Name {
          get { return name_; }
          set {
            name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "profile_index" field.</summary>
        public const int ProfileIndexFieldNumber = 2;
        private long profileIndex_;
        /// <summary>
        /// The index into the profile counters array for the HloComputation
        /// corresponding to this HloComputationInfo.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long ProfileIndex {
          get { return profileIndex_; }
          set {
            profileIndex_ = value;
          }
        }

        /// <summary>Field number for the "instruction_infos" field.</summary>
        public const int InstructionInfosFieldNumber = 3;
        private static readonly pb::FieldCodec<global::Xla.HloProfilePrinterData.Types.HloInstructionInfo> _repeated_instructionInfos_codec
            = pb::FieldCodec.ForMessage(26, global::Xla.HloProfilePrinterData.Types.HloInstructionInfo.Parser);
        private readonly pbc::RepeatedField<global::Xla.HloProfilePrinterData.Types.HloInstructionInfo> instructionInfos_ = new pbc::RepeatedField<global::Xla.HloProfilePrinterData.Types.HloInstructionInfo>();
        /// <summary>
        /// HloInstructionInfos for every HloInstruction in the HloComputation for
        /// corresponding to this HloComputattionInfo.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::Xla.HloProfilePrinterData.Types.HloInstructionInfo> InstructionInfos {
          get { return instructionInfos_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as HloComputationInfo);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(HloComputationInfo other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Name != other.Name) return false;
          if (ProfileIndex != other.ProfileIndex) return false;
          if(!instructionInfos_.Equals(other.instructionInfos_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Name.Length != 0) hash ^= Name.GetHashCode();
          if (ProfileIndex != 0L) hash ^= ProfileIndex.GetHashCode();
          hash ^= instructionInfos_.GetHashCode();
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
          if (ProfileIndex != 0L) {
            output.WriteRawTag(16);
            output.WriteInt64(ProfileIndex);
          }
          instructionInfos_.WriteTo(output, _repeated_instructionInfos_codec);
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
          if (ProfileIndex != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(ProfileIndex);
          }
          size += instructionInfos_.CalculateSize(_repeated_instructionInfos_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(HloComputationInfo other) {
          if (other == null) {
            return;
          }
          if (other.Name.Length != 0) {
            Name = other.Name;
          }
          if (other.ProfileIndex != 0L) {
            ProfileIndex = other.ProfileIndex;
          }
          instructionInfos_.Add(other.instructionInfos_);
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
                ProfileIndex = input.ReadInt64();
                break;
              }
              case 26: {
                instructionInfos_.AddEntriesFrom(input, _repeated_instructionInfos_codec);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
