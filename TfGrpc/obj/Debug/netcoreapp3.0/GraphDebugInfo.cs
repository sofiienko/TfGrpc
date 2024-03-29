// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tensorflow/core/protobuf/graph_debug_info.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow {

  /// <summary>Holder for reflection information generated from tensorflow/core/protobuf/graph_debug_info.proto</summary>
  public static partial class GraphDebugInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/core/protobuf/graph_debug_info.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GraphDebugInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci90ZW5zb3JmbG93L2NvcmUvcHJvdG9idWYvZ3JhcGhfZGVidWdfaW5mby5w",
            "cm90bxIKdGVuc29yZmxvdyLVAgoOR3JhcGhEZWJ1Z0luZm8SDQoFZmlsZXMY",
            "ASADKAkSNgoGdHJhY2VzGAIgAygLMiYudGVuc29yZmxvdy5HcmFwaERlYnVn",
            "SW5mby5UcmFjZXNFbnRyeRpYCgtGaWxlTGluZUNvbBISCgpmaWxlX2luZGV4",
            "GAEgASgFEgwKBGxpbmUYAiABKAUSCwoDY29sGAMgASgFEgwKBGZ1bmMYBCAB",
            "KAkSDAoEY29kZRgFIAEoCRpMCgpTdGFja1RyYWNlEj4KDmZpbGVfbGluZV9j",
            "b2xzGAEgAygLMiYudGVuc29yZmxvdy5HcmFwaERlYnVnSW5mby5GaWxlTGlu",
            "ZUNvbBpUCgtUcmFjZXNFbnRyeRILCgNrZXkYASABKAkSNAoFdmFsdWUYAiAB",
            "KAsyJS50ZW5zb3JmbG93LkdyYXBoRGVidWdJbmZvLlN0YWNrVHJhY2U6AjgB",
            "QjUKGG9yZy50ZW5zb3JmbG93LmZyYW1ld29ya0IUR3JhcGhEZWJ1Z0luZm9Q",
            "cm90b3NQAfgBAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.GraphDebugInfo), global::Tensorflow.GraphDebugInfo.Parser, new[]{ "Files", "Traces" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.GraphDebugInfo.Types.FileLineCol), global::Tensorflow.GraphDebugInfo.Types.FileLineCol.Parser, new[]{ "FileIndex", "Line", "Col", "Func", "Code" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.GraphDebugInfo.Types.StackTrace), global::Tensorflow.GraphDebugInfo.Types.StackTrace.Parser, new[]{ "FileLineCols" }, null, null, null),
            null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GraphDebugInfo : pb::IMessage<GraphDebugInfo> {
    private static readonly pb::MessageParser<GraphDebugInfo> _parser = new pb::MessageParser<GraphDebugInfo>(() => new GraphDebugInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GraphDebugInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.GraphDebugInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GraphDebugInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GraphDebugInfo(GraphDebugInfo other) : this() {
      files_ = other.files_.Clone();
      traces_ = other.traces_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GraphDebugInfo Clone() {
      return new GraphDebugInfo(this);
    }

    /// <summary>Field number for the "files" field.</summary>
    public const int FilesFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_files_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> files_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// This stores all the source code file names and can be indexed by the
    /// `file_index`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Files {
      get { return files_; }
    }

    /// <summary>Field number for the "traces" field.</summary>
    public const int TracesFieldNumber = 2;
    private static readonly pbc::MapField<string, global::Tensorflow.GraphDebugInfo.Types.StackTrace>.Codec _map_traces_codec
        = new pbc::MapField<string, global::Tensorflow.GraphDebugInfo.Types.StackTrace>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::Tensorflow.GraphDebugInfo.Types.StackTrace.Parser), 18);
    private readonly pbc::MapField<string, global::Tensorflow.GraphDebugInfo.Types.StackTrace> traces_ = new pbc::MapField<string, global::Tensorflow.GraphDebugInfo.Types.StackTrace>();
    /// <summary>
    /// This maps a node name to a stack trace in the source code.
    /// The map key is a mangling of the containing function and op name with
    /// syntax:
    ///   op.name '@' func_name
    /// For ops in the top-level graph, the func_name is the empty string.
    /// Note that op names are restricted to a small number of characters which
    /// exclude '@', making it impossible to collide keys of this form. Function
    /// names accept a much wider set of characters.
    /// It would be preferable to avoid mangling and use a tuple key of (op.name,
    /// func_name), but this is not supported with protocol buffers.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::Tensorflow.GraphDebugInfo.Types.StackTrace> Traces {
      get { return traces_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GraphDebugInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GraphDebugInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!files_.Equals(other.files_)) return false;
      if (!Traces.Equals(other.Traces)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= files_.GetHashCode();
      hash ^= Traces.GetHashCode();
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
      files_.WriteTo(output, _repeated_files_codec);
      traces_.WriteTo(output, _map_traces_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += files_.CalculateSize(_repeated_files_codec);
      size += traces_.CalculateSize(_map_traces_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GraphDebugInfo other) {
      if (other == null) {
        return;
      }
      files_.Add(other.files_);
      traces_.Add(other.traces_);
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
            files_.AddEntriesFrom(input, _repeated_files_codec);
            break;
          }
          case 18: {
            traces_.AddEntriesFrom(input, _map_traces_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the GraphDebugInfo message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// This represents a file/line location in the source code.
      /// </summary>
      public sealed partial class FileLineCol : pb::IMessage<FileLineCol> {
        private static readonly pb::MessageParser<FileLineCol> _parser = new pb::MessageParser<FileLineCol>(() => new FileLineCol());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<FileLineCol> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Tensorflow.GraphDebugInfo.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public FileLineCol() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public FileLineCol(FileLineCol other) : this() {
          fileIndex_ = other.fileIndex_;
          line_ = other.line_;
          col_ = other.col_;
          func_ = other.func_;
          code_ = other.code_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public FileLineCol Clone() {
          return new FileLineCol(this);
        }

        /// <summary>Field number for the "file_index" field.</summary>
        public const int FileIndexFieldNumber = 1;
        private int fileIndex_;
        /// <summary>
        /// File name index, which can be used to retrieve the file name string from
        /// `files`. The value should be between 0 and (len(files)-1)
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int FileIndex {
          get { return fileIndex_; }
          set {
            fileIndex_ = value;
          }
        }

        /// <summary>Field number for the "line" field.</summary>
        public const int LineFieldNumber = 2;
        private int line_;
        /// <summary>
        /// Line number in the file.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int Line {
          get { return line_; }
          set {
            line_ = value;
          }
        }

        /// <summary>Field number for the "col" field.</summary>
        public const int ColFieldNumber = 3;
        private int col_;
        /// <summary>
        /// Col number in the file line.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int Col {
          get { return col_; }
          set {
            col_ = value;
          }
        }

        /// <summary>Field number for the "func" field.</summary>
        public const int FuncFieldNumber = 4;
        private string func_ = "";
        /// <summary>
        /// Name of function contains the file line.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Func {
          get { return func_; }
          set {
            func_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "code" field.</summary>
        public const int CodeFieldNumber = 5;
        private string code_ = "";
        /// <summary>
        /// Source code contained in this file line.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Code {
          get { return code_; }
          set {
            code_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as FileLineCol);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(FileLineCol other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (FileIndex != other.FileIndex) return false;
          if (Line != other.Line) return false;
          if (Col != other.Col) return false;
          if (Func != other.Func) return false;
          if (Code != other.Code) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (FileIndex != 0) hash ^= FileIndex.GetHashCode();
          if (Line != 0) hash ^= Line.GetHashCode();
          if (Col != 0) hash ^= Col.GetHashCode();
          if (Func.Length != 0) hash ^= Func.GetHashCode();
          if (Code.Length != 0) hash ^= Code.GetHashCode();
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
          if (FileIndex != 0) {
            output.WriteRawTag(8);
            output.WriteInt32(FileIndex);
          }
          if (Line != 0) {
            output.WriteRawTag(16);
            output.WriteInt32(Line);
          }
          if (Col != 0) {
            output.WriteRawTag(24);
            output.WriteInt32(Col);
          }
          if (Func.Length != 0) {
            output.WriteRawTag(34);
            output.WriteString(Func);
          }
          if (Code.Length != 0) {
            output.WriteRawTag(42);
            output.WriteString(Code);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (FileIndex != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(FileIndex);
          }
          if (Line != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Line);
          }
          if (Col != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Col);
          }
          if (Func.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Func);
          }
          if (Code.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Code);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(FileLineCol other) {
          if (other == null) {
            return;
          }
          if (other.FileIndex != 0) {
            FileIndex = other.FileIndex;
          }
          if (other.Line != 0) {
            Line = other.Line;
          }
          if (other.Col != 0) {
            Col = other.Col;
          }
          if (other.Func.Length != 0) {
            Func = other.Func;
          }
          if (other.Code.Length != 0) {
            Code = other.Code;
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
                FileIndex = input.ReadInt32();
                break;
              }
              case 16: {
                Line = input.ReadInt32();
                break;
              }
              case 24: {
                Col = input.ReadInt32();
                break;
              }
              case 34: {
                Func = input.ReadString();
                break;
              }
              case 42: {
                Code = input.ReadString();
                break;
              }
            }
          }
        }

      }

      /// <summary>
      /// This represents a stack trace which is a ordered list of `FileLineCol`.
      /// </summary>
      public sealed partial class StackTrace : pb::IMessage<StackTrace> {
        private static readonly pb::MessageParser<StackTrace> _parser = new pb::MessageParser<StackTrace>(() => new StackTrace());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<StackTrace> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Tensorflow.GraphDebugInfo.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StackTrace() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StackTrace(StackTrace other) : this() {
          fileLineCols_ = other.fileLineCols_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public StackTrace Clone() {
          return new StackTrace(this);
        }

        /// <summary>Field number for the "file_line_cols" field.</summary>
        public const int FileLineColsFieldNumber = 1;
        private static readonly pb::FieldCodec<global::Tensorflow.GraphDebugInfo.Types.FileLineCol> _repeated_fileLineCols_codec
            = pb::FieldCodec.ForMessage(10, global::Tensorflow.GraphDebugInfo.Types.FileLineCol.Parser);
        private readonly pbc::RepeatedField<global::Tensorflow.GraphDebugInfo.Types.FileLineCol> fileLineCols_ = new pbc::RepeatedField<global::Tensorflow.GraphDebugInfo.Types.FileLineCol>();
        /// <summary>
        /// Each line in the stack trace.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::Tensorflow.GraphDebugInfo.Types.FileLineCol> FileLineCols {
          get { return fileLineCols_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as StackTrace);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(StackTrace other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if(!fileLineCols_.Equals(other.fileLineCols_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= fileLineCols_.GetHashCode();
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
          fileLineCols_.WriteTo(output, _repeated_fileLineCols_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          size += fileLineCols_.CalculateSize(_repeated_fileLineCols_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(StackTrace other) {
          if (other == null) {
            return;
          }
          fileLineCols_.Add(other.fileLineCols_);
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
                fileLineCols_.AddEntriesFrom(input, _repeated_fileLineCols_codec);
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
