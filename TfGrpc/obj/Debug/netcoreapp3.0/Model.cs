// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tensorflow_serving/apis/model.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow.Serving {

  /// <summary>Holder for reflection information generated from tensorflow_serving/apis/model.proto</summary>
  public static partial class ModelReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow_serving/apis/model.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ModelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiN0ZW5zb3JmbG93X3NlcnZpbmcvYXBpcy9tb2RlbC5wcm90bxISdGVuc29y",
            "Zmxvdy5zZXJ2aW5nGh5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8i",
            "jAEKCU1vZGVsU3BlYxIMCgRuYW1lGAEgASgJEi4KB3ZlcnNpb24YAiABKAsy",
            "Gy5nb29nbGUucHJvdG9idWYuSW50NjRWYWx1ZUgAEhcKDXZlcnNpb25fbGFi",
            "ZWwYBCABKAlIABIWCg5zaWduYXR1cmVfbmFtZRgDIAEoCUIQCg52ZXJzaW9u",
            "X2Nob2ljZUID+AEBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Serving.ModelSpec), global::Tensorflow.Serving.ModelSpec.Parser, new[]{ "Name", "Version", "VersionLabel", "SignatureName" }, new[]{ "VersionChoice" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Metadata for an inference request such as the model name and version.
  /// </summary>
  public sealed partial class ModelSpec : pb::IMessage<ModelSpec> {
    private static readonly pb::MessageParser<ModelSpec> _parser = new pb::MessageParser<ModelSpec>(() => new ModelSpec());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ModelSpec> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Serving.ModelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ModelSpec() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ModelSpec(ModelSpec other) : this() {
      name_ = other.name_;
      signatureName_ = other.signatureName_;
      switch (other.VersionChoiceCase) {
        case VersionChoiceOneofCase.Version:
          Version = other.Version;
          break;
        case VersionChoiceOneofCase.VersionLabel:
          VersionLabel = other.VersionLabel;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ModelSpec Clone() {
      return new ModelSpec(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Required servable name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 2;
    private static readonly pb::FieldCodec<long?> _oneof_version_codec = pb::FieldCodec.ForStructWrapper<long>(18);
    /// <summary>
    /// Use this specific version number.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Version {
      get { return versionChoiceCase_ == VersionChoiceOneofCase.Version ? (long?) versionChoice_ : (long?) null; }
      set {
        versionChoice_ = value;
        versionChoiceCase_ = value == null ? VersionChoiceOneofCase.None : VersionChoiceOneofCase.Version;
      }
    }

    /// <summary>Field number for the "version_label" field.</summary>
    public const int VersionLabelFieldNumber = 4;
    /// <summary>
    /// Use the version associated with the given label.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string VersionLabel {
      get { return versionChoiceCase_ == VersionChoiceOneofCase.VersionLabel ? (string) versionChoice_ : ""; }
      set {
        versionChoice_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        versionChoiceCase_ = VersionChoiceOneofCase.VersionLabel;
      }
    }

    /// <summary>Field number for the "signature_name" field.</summary>
    public const int SignatureNameFieldNumber = 3;
    private string signatureName_ = "";
    /// <summary>
    /// A named signature to evaluate. If unspecified, the default signature will
    /// be used.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SignatureName {
      get { return signatureName_; }
      set {
        signatureName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private object versionChoice_;
    /// <summary>Enum of possible cases for the "version_choice" oneof.</summary>
    public enum VersionChoiceOneofCase {
      None = 0,
      Version = 2,
      VersionLabel = 4,
    }
    private VersionChoiceOneofCase versionChoiceCase_ = VersionChoiceOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionChoiceOneofCase VersionChoiceCase {
      get { return versionChoiceCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearVersionChoice() {
      versionChoiceCase_ = VersionChoiceOneofCase.None;
      versionChoice_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ModelSpec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ModelSpec other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Version != other.Version) return false;
      if (VersionLabel != other.VersionLabel) return false;
      if (SignatureName != other.SignatureName) return false;
      if (VersionChoiceCase != other.VersionChoiceCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (versionChoiceCase_ == VersionChoiceOneofCase.Version) hash ^= Version.GetHashCode();
      if (versionChoiceCase_ == VersionChoiceOneofCase.VersionLabel) hash ^= VersionLabel.GetHashCode();
      if (SignatureName.Length != 0) hash ^= SignatureName.GetHashCode();
      hash ^= (int) versionChoiceCase_;
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
      if (versionChoiceCase_ == VersionChoiceOneofCase.Version) {
        _oneof_version_codec.WriteTagAndValue(output, (long?) versionChoice_);
      }
      if (SignatureName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SignatureName);
      }
      if (versionChoiceCase_ == VersionChoiceOneofCase.VersionLabel) {
        output.WriteRawTag(34);
        output.WriteString(VersionLabel);
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
      if (versionChoiceCase_ == VersionChoiceOneofCase.Version) {
        size += _oneof_version_codec.CalculateSizeWithTag(Version);
      }
      if (versionChoiceCase_ == VersionChoiceOneofCase.VersionLabel) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(VersionLabel);
      }
      if (SignatureName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SignatureName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ModelSpec other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.SignatureName.Length != 0) {
        SignatureName = other.SignatureName;
      }
      switch (other.VersionChoiceCase) {
        case VersionChoiceOneofCase.Version:
          Version = other.Version;
          break;
        case VersionChoiceOneofCase.VersionLabel:
          VersionLabel = other.VersionLabel;
          break;
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
            Version = _oneof_version_codec.Read(input);
            break;
          }
          case 26: {
            SignatureName = input.ReadString();
            break;
          }
          case 34: {
            VersionLabel = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
